﻿Imports System.Data
Imports System.Linq
Imports MySql.Data.MySqlClient

Public Class BDPrendaScm
    Private ReadOnly conexion As New MySQLconexion()
    Private ss_error As String = ""

    ' Método para obtener datos de la tabla
    Public Function GetData(whereParameters As Dictionary(Of String, Object)) As DataTable
        Dim dataTable As New DataTable()
        Debug.Print($"Entro a GetData")

        Try
            Using connection = conexion.Connect()
                If connection Is Nothing Then
                    'Debug.Print("La conexión es Nothing.")
                    Throw New Exception("No se pudo establecer conexión con la base de datos.")
                End If
                'Debug.Print($"Estado de la conexión: {connection.State}")

                Dim query As String = "SELECT `id_prenda`, `id_rfid`, `id_barras`, `fecha_registro`, `cod_trabajador`, `op`, `corte`, `subcorte` AS `sub_corte`, `cod_talla`, `id_talla`, `talla`, `cod_combinacion`, `color`, `estado`, `id_contenedor` FROM `bd_ci_scm`.`prenda`"
                Dim ls_where As String = BuildWhereClause(whereParameters)
                Console.WriteLine($"El query inicial: {query}")

                If Not String.IsNullOrEmpty(ls_where) Then
                    query &= " WHERE " & ls_where
                End If
                Console.WriteLine($"Query final: {query}")

                Using comando As New MySqlCommand(query, connection)
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", If(param.Value, DBNull.Value))
                    Next

                    Using reader = comando.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            Debug.Print($"Error al ejecutar consulta: {ex.Message}")
            LogError("Error en GetData", ex)
        End Try
        Return dataTable
    End Function

    ' Método para insertar datos en la tabla
    Public Function Insert(columns As Dictionary(Of String, Object)) As Long
        Dim ll_return As Long = 0
        'Debug.Print("Iniciando Insert...")
        'Debug.Print($"Datos a insertar: {String.Join(", ", columns.Select(Function(kv) $"{kv.Key}={kv.Value}"))}")

        Try
            ' Asegúrate de que la conexión esté siempre abierta para cada operación
            Using connection = conexion.Connect()
                If connection.State <> ConnectionState.Open Then
                    connection.Open()
                End If

                Dim tableName As String = "`prenda`"
                Dim columnNames As String = String.Join(", ", columns.Keys.Select(Function(key) $"`{key}`"))
                Dim parameterNames As String = String.Join(", ", columns.Keys.Select(Function(key) $"@{key}"))

                Dim sql As String = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})"
                'Debug.Print($"Consulta generada: {sql}")

                Using comando As New MySqlCommand(sql, connection)
                    For Each param In columns
                        comando.Parameters.AddWithValue($"@{param.Key}", If(param.Value, DBNull.Value))
                    Next

                    ll_return = comando.ExecuteNonQuery()
                    'Debug.Print($"Número de filas afectadas: {ll_return}")
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            Debug.Print($"Error en Insert: {ex.Message}")
            LogError("Error en Insert", ex)
            ll_return = -1
        End Try
        Return ll_return
    End Function

    ' Método para actualizar la tabla `prenda` con whereParameters y updateParameters
    Public Function UpdatePrenda(whereParameters As Dictionary(Of String, Object), updateParameters As Dictionary(Of String, Object)) As Integer
        Dim li_return As Integer = 0

        If whereParameters Is Nothing Then whereParameters = New Dictionary(Of String, Object)()
        If updateParameters Is Nothing Then updateParameters = New Dictionary(Of String, Object)()

        If updateParameters.Count = 0 Then
            Throw New ArgumentException("Debe proporcionar al menos un campo a actualizar en updateParameters.")
        End If

        Try
            Using connection = conexion.Connect()
                If connection.State <> ConnectionState.Open Then connection.Open()

                Using trans = connection.BeginTransaction()
                    Try
                        ' Construcción de cláusulas SQL
                        Dim setClause As String = BuildWhereClause(updateParameters, ", ")
                        Dim whereClause As String = BuildWhereClause(whereParameters)

                        ' Construir la consulta
                        Dim query As String = $"UPDATE prenda SET fecha_modificacion = NOW(), {setClause} WHERE {whereClause}"
                        Console.WriteLine($"Consulta generada: {query}")

                        Using comando As New MySqlCommand(query, connection, trans)
                            ' Agregar parámetros
                            AddParametersToCommand(comando, updateParameters)
                            AddParametersToCommand(comando, whereParameters)

                            ' Ejecutar actualización
                            li_return = comando.ExecuteNonQuery()
                            Console.WriteLine($"Filas afectadas: {li_return}")

                            ' Confirmar transacción si se actualizaron filas
                            If li_return > 0 Then
                                trans.Commit()
                            Else
                                trans.Rollback()
                            End If
                        End Using
                    Catch ex As Exception
                        trans.Rollback()
                        Throw New Exception($"Error en UpdatePrenda (Rollback ejecutado): {ex.Message}")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            Console.WriteLine($"Error en UpdatePrenda: {ex.Message}")
            LogError("Error en UpdatePrenda", ex)
        End Try

        Return li_return
    End Function



    ' Método para construir la cláusula WHERE dinámicamente
    Private Function BuildWhereClause(parameters As Dictionary(Of String, Object), Optional separacion As String = " AND ") As String
        If parameters Is Nothing OrElse parameters.Count = 0 Then Return "" ' Evita el error si el diccionario está vacío o nulo
        Return String.Join(separacion, parameters.Keys.Select(Function(key) $"{key} = @{key}"))
    End Function

    ' Método para agregar parámetros al comando
    ' Método para agregar parámetros al comando
    Private Sub AddParametersToCommand(comando As MySqlCommand, parameters As Dictionary(Of String, Object))
        If parameters Is Nothing OrElse parameters.Count = 0 Then Exit Sub

        For Each param In parameters
            Dim valorParametro As Object = If(param.Value Is Nothing, DBNull.Value, param.Value)
            Console.WriteLine($"@{param.Key} valor: {valorParametro}") ' Debug en consola

            ' Verificar si el parámetro ya existe antes de agregarlo
            If Not comando.Parameters.Contains($"@{param.Key}") Then
                comando.Parameters.AddWithValue($"@{param.Key}", valorParametro)
            End If
        Next
    End Sub


    ' Método para registrar errores en un archivo de log
    Private Sub LogError(message As String, Optional ex As Exception = Nothing)
        Dim logMessage As String = $"{DateTime.Now}: {message}"
        If ex IsNot Nothing Then
            logMessage &= Environment.NewLine & ex.ToString()
        End If
        IO.File.AppendAllText("mysql_errors.log", logMessage & Environment.NewLine)
    End Sub

    ' Método para obtener el último error registrado
    Public Function GetError() As String
        Return ss_error
    End Function
End Class