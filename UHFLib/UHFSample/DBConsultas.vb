Imports System.Data
Imports System.Collections.Generic
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Sybase.Data.AseClient

Public Class DBConsultas
    Private ReadOnly myConexion As New Sybase()
    Private comando As New AseCommand()
    Private ss_error As String = ""

    Private SECRET_KEY As String
    Private SECRET_IV As String
    Private METHOD As String

    Private _key As Byte()
    Private _iv As Byte()
    Private _clave As String = "xhEaYalLB4gWqzdUtgwhkQ=="
    Public Function GetData(whereParameters As Dictionary(Of String, Object)) As DataTable
        Dim dataTable As New DataTable()
        Try
            Using connection = myConexion.Connect()
                If connection.State <> ConnectionState.Open Then
                    Throw New Exception("No se pudo establecer la conexión con la base de datos Sybase.")
                End If

                Dim query As String = "SELECT identificador, codigo, datos, empresa, estado, clave FROM usuario_timbrado"
                If whereParameters.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereParameters.Keys.Select(Function(k) $"{k} = @{k}"))
                End If

                Using comando = New AseCommand(query, connection)
                    comando.Parameters.Clear()
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                    Next

                    Using reader = comando.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            LogError("Error en GetData", ex)
        End Try
        Return dataTable
    End Function

    Public Function ExtraerData(whereParameters As Dictionary(Of String, Object)) As DataTable
        Dim dataTable As New DataTable()
        Try
            Using connection = myConexion.Connect()
                If connection.State <> ConnectionState.Open Then
                    Throw New Exception("No se pudo establecer la conexión con la base de datos Sybase.")
                End If

                Dim query As String = "SELECT identificador, codigo, datos, empresa, estado FROM usuario_timbrado"
                If whereParameters.Count > 0 Then
                    query &= " WHERE " & String.Join(" AND ", whereParameters.Keys.Select(Function(k) $"{k} = @{k}"))
                End If

                Using comando = New AseCommand(query, connection)
                    comando.Parameters.Clear()
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                    Next

                    Using reader = comando.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            LogError("Error en ExtraerData", ex)
        End Try
        Return dataTable
    End Function

    Private Function GetIniSecret(titulo As String) As Integer
        Try
            Dim json As String = File.ReadAllText("tsconfig.json")
            Dim config = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)

            SECRET_KEY = config("SECRET_KEY")
            SECRET_IV = config("SECRET_IV")
            METHOD = config("METHOD")

            Return 1
        Catch ex As Exception
            ss_error = $"Error al cargar configuración: {ex.Message}"
            LogError("Error en GetIniSecret", ex)
            Return 0
        End Try
    End Function

    Private Sub LogError(message As String, Optional ex As Exception = Nothing)
        Dim logMessage As String = $"{DateTime.Now}: {message}"
        If ex IsNot Nothing Then
            logMessage &= Environment.NewLine & ex.ToString()
        End If
        File.AppendAllText("db_errors.log", logMessage & Environment.NewLine)
    End Sub
End Class
