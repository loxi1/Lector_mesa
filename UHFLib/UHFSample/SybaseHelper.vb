Imports System.Data
Imports Sybase.Data.AseClient

Public Class SybaseHelper
    Private ReadOnly sybase As New Sybase() ' Instancia de la clase Sybase para manejar la conexión
    Private errorMessage As String ' Para almacenar errores

    ' Método para validar usuario en la base de datos
    Public Function ValidateUser(codigo As String, claveEncriptada As String) As DataRow
        Dim query As String = "SELECT identificador, codigo, datos, empresa, estado, clave FROM usuario_timbrado WHERE codigo = @codigo AND clave = @clave"
        Dim result As DataTable = New DataTable()

        Try
            ' Establecer conexión
            Dim connection As AseConnection = sybase.Connect()

            ' Configurar comando SQL
            Using command As New AseCommand(query, connection)
                ' Agregar parámetros
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@clave", claveEncriptada)

                ' Ejecutar consulta
                Using reader As AseDataReader = command.ExecuteReader()
                    result.Load(reader) ' Cargar los resultados en un DataTable
                End Using
            End Using

            ' Cerrar conexión
            sybase.Disconnect()

        Catch ex As Exception
            ' Manejo de errores
            errorMessage = $"Error al validar usuario: {ex.Message}"
            sybase.Disconnect()
        End Try

        ' Retornar la primera fila si existe, de lo contrario Nothing
        If result.Rows.Count > 0 Then
            Return result.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    ' Método para validar usuario basado en un diccionario de parámetros
    Public Function ValidateUser(whereParameters As Dictionary(Of String, Object)) As DataTable
        Dim result As New DataTable()

        Try
            ' Construir la consulta dinámica
            Dim query As String = "SELECT identificador, codigo, datos, empresa, estado, clave FROM usuario_timbrado"
            Dim whereClause As New List(Of String)

            ' Agregar condiciones al WHERE dinámico
            For Each param In whereParameters
                whereClause.Add($"{param.Key} = @{param.Key}")
            Next

            If whereClause.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClause)
            End If
            Debug.Print($"Query->{query}")
            ' Establecer conexión
            Dim connection As AseConnection = sybase.Connect()

            ' Configurar comando SQL
            Using command As New AseCommand(query, connection)
                ' Agregar parámetros al comando
                For Each param In whereParameters
                    command.Parameters.AddWithValue($"@{param.Key}", param.Value)
                Next

                ' Ejecutar consulta
                Using reader As AseDataReader = command.ExecuteReader()
                    result.Load(reader) ' Cargar los resultados en un DataTable
                End Using
            End Using

            ' Cerrar conexión
            sybase.Disconnect()
        Catch ex As Exception
            ' Manejo de errores
            errorMessage = $"Error al validar usuario: {ex.Message}"
            sybase.Disconnect()
        End Try

        Return result ' Retorna un DataTable con los resultados
    End Function


    ' Método para obtener errores
    Public Function GetLastError() As String
        If Not String.IsNullOrEmpty(errorMessage) Then
            Return errorMessage
        Else
            Return sybase.GetError()
        End If
    End Function
End Class
