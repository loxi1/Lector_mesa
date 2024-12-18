Imports System.Data
Imports System.Linq
Imports MySql.Data.MySqlClient

Public Class BDPrendaScm
    Private ReadOnly conexion As New MySQLconexion()
    Private comando As New MySqlCommand()
    Private ss_error As String = ""

    ' Método para obtener datos de la tabla
    Public Function GetData(whereParameters As Dictionary(Of String, Object)) As DataTable
        Dim dataTable As New DataTable()
        Try
            Using connection = conexion.Connect()
                Dim query As String = "SELECT `id_prenda`, `id_rfid`, `id_barras`, `fecha_registro`, `cod_trabajador`, `op`, `corte`, `subcorte`, `cod_talla`, `id_talla`, `talla`, `cod_combinacion`, `color`, `estado`, `id_contenedor` FROM `bd_ci_scm`.`prenda`"

                Dim ls_where As String = ""
                For Each parameter In whereParameters
                    ls_where &= $"{parameter.Key} = @{parameter.Key} AND "
                Next

                ls_where = ls_where.TrimEnd(" AND ".ToCharArray())
                If Not String.IsNullOrEmpty(ls_where) Then
                    query &= " WHERE " & ls_where
                End If

                comando.Connection = connection
                comando.CommandText = query
                comando.Parameters.Clear()

                For Each parameter In whereParameters
                    comando.Parameters.AddWithValue($"@{parameter.Key}", parameter.Value)
                Next

                Using reader = comando.ExecuteReader()
                    dataTable.Load(reader)
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
        End Try
        Return dataTable
    End Function

    ' Método para insertar datos en la tabla
    Public Function Insert(columns As Dictionary(Of String, Object)) As Long
        Dim ll_return As Long
        Try
            Using connection = conexion.Connect()
                Dim tableName As String = "`prenda`"
                Dim columnNames As String = String.Join(", ", columns.Keys.Select(Function(key) $"`{key}`"))
                Dim parameterNames As String = String.Join(", ", columns.Keys.Select(Function(key) $"@{key}"))

                Dim sql As String = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})"

                comando.Connection = connection
                comando.CommandText = sql
                comando.Parameters.Clear()

                For Each column In columns
                    comando.Parameters.AddWithValue($"@{column.Key}", If(column.Value, DBNull.Value))
                Next

                ll_return = comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            ll_return = -1
        End Try
        Return ll_return
    End Function

    ' Método para obtener errores
    Public Function GetError() As String
        Return ss_error
    End Function
End Class