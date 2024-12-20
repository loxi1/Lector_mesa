Imports System.Data
Imports System.IO
Imports Newtonsoft.Json
Imports Sybase.Data.AseClient ' O usa WL.Sybase.AdoNet4.AseClient

Public Class Sybase
    Private myConexion As AseConnection
    Private ReadOnly m_Usuario As String = "corporativo"
    Private ReadOnly m_Password As String = "c0rp0r@t1v0"
    Private m_ServerName As String = ""
    Private m_Port As String = ""
    Private m_DataBase As String = ""
    Public s_error As String = ""

    ' Método para conectarse a la base de datos
    Public Function Connect() As AseConnection
        If LoadConfig("tsconfig.json") Then
            Dim sCadenaConexion As String = $"Data Source={m_ServerName};Port={m_Port};Database={m_DataBase};Uid={m_Usuario};Pwd={m_Password};"
            Debug.Print($"Cadena de conexión generada: {sCadenaConexion}")
            Try
                If myConexion Is Nothing Then
                    myConexion = New AseConnection(sCadenaConexion)
                End If

                If myConexion.State = ConnectionState.Closed Then
                    myConexion.Open()
                End If
                Debug.Print($"Estado de la conexión después de intentar abrir: {myConexion.State}")
            Catch ex As AseException
                s_error = $"Error al conectar: {ex.Message}"
                Debug.Print(s_error)
                Throw New Exception(s_error)
            End Try
        Else
            Debug.Print("No se pudo cargar la configuración.")
            Throw New Exception("Error al cargar la configuración de la base de datos.")
        End If

        Return myConexion
    End Function

    ' Método para desconectarse de la base de datos
    Public Function Disconnect() As Integer
        Try
            If myConexion IsNot Nothing AndAlso myConexion.State = ConnectionState.Open Then
                myConexion.Close()
            End If
        Catch ex As AseException
            s_error = ex.Message
            LogError("Error al cerrar la conexión a la base de datos", ex)
        End Try
        Return 1
    End Function

    ' Método para obtener errores
    Public Function GetError() As String
        Return s_error
    End Function

    ' Método para registrar errores en un log
    Private Sub LogError(message As String, Optional ex As Exception = Nothing)
        ' Registrar errores en un archivo de log
        Dim logMessage As String = $"{DateTime.Now}: {message}"
        If ex IsNot Nothing Then
            logMessage &= Environment.NewLine & ex.ToString()
        End If

        File.AppendAllText("db_errors.log", logMessage & Environment.NewLine)
    End Sub

    ' Método para cargar configuración desde un archivo JSON
    Private Function LoadConfig(filePath As String) As Boolean
        Try
            If File.Exists(filePath) Then
                Dim json As String = File.ReadAllText(filePath)
                Dim config As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)

                m_ServerName = config("SERVER_NAME_SY")
                m_Port = config("PORT_SY")
                m_DataBase = config("DATA_BASE_SY")
                Return True
            Else
                s_error = $"El archivo de configuración '{filePath}' no existe."
                Return False
            End If
        Catch ex As Exception
            s_error = $"Error al cargar configuración: {ex.Message}"
            Return False
        End Try
    End Function
End Class
