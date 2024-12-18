Imports System.Data
Imports System.IO
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
        If GetIni() = 1 Then
            Dim sCadenaConexion As String = $"Data Source={m_ServerName};Port={m_Port};Database={m_DataBase};Uid={m_Usuario};Pwd={m_Password};"
            Try
                If myConexion Is Nothing Then
                    myConexion = New AseConnection(sCadenaConexion)
                End If

                If myConexion.State = ConnectionState.Closed Then
                    myConexion.Open()
                End If
            Catch ex As AseException
                s_error = ex.Message
            End Try
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
        End Try
        Return 1
    End Function

    ' Método para obtener errores
    Public Function GetError() As String
        Return s_error
    End Function

    ' Método para cargar configuración desde un archivo .ini
    Private Function GetIni() As Integer
        Try
            ' Simulación de carga de configuración, reemplazar con lógica de archivo INI real si es necesario
            m_ServerName = "dbsybase06.cofaco.com"
            m_Port = "6100"
            m_DataBase = "nexus"
            Return 1
        Catch ex As Exception
            s_error = ex.Message
            Return 0
        End Try
    End Function
End Class
