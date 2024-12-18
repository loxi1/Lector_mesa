Imports System.Data
Imports MySql.Data.MySqlClient

Public Class MySQLconexion
    Private myConexion As MySqlConnection
    Private m_ServerName As String = ""
    Private m_Port As String = ""
    Private m_DataBase As String = ""
    Private m_Usuario As String = "fjurado"
    Private m_Password As String = "987960662"
    Public s_error As String

    ' Método para conectarse a la base de datos
    Public Function Connect() As MySqlConnection
        If GetIni() = 1 Then
            Dim sCadenaConexion As String = $"Database={m_DataBase};Port={m_Port};Data Source={m_ServerName};Uid={m_Usuario};Pwd={m_Password};"
            Try
                If myConexion Is Nothing Then
                    myConexion = New MySqlConnection(sCadenaConexion)
                End If

                If myConexion.State = ConnectionState.Closed Then
                    myConexion.Open()
                End If
            Catch ex As MySqlException
                s_error = ex.Message
            End Try
        End If
        Return myConexion
    End Function

    ' Método para desconectarse de la base de datos
    Public Function Disconnect() As MySqlConnection
        If myConexion IsNot Nothing AndAlso myConexion.State = ConnectionState.Open Then
            myConexion.Close()
        End If
        Return myConexion
    End Function

    ' Método para obtener errores
    Public Function GetError() As String
        Return s_error
    End Function

    ' Método para cargar configuración (simulación del archivo .ini)
    Private Function GetIni() As Integer
        Try
            m_ServerName = "192.168.150.35"
            m_Port = "3306"
            m_DataBase = "bd_ci_scm"
            Return 1
        Catch ex As Exception
            s_error = ex.Message
            Return 0
        End Try
    End Function
End Class

