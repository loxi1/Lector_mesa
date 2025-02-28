﻿Imports System.Data
Imports System.Linq
Imports Sybase.Data.AseClient

Public Class BDPrenda
    Friend ReadOnly myConexion As New Sybase()
    Private comando As New AseCommand()
    Private ss_error As String = ""
    Private Const ESTADO_EMBALAJE As String = "SALIDA EMBALAJE"
    Private Const COMPANIA As String = "02"
    Public Function TieneRFID(pOp As String) As Integer
        Dim esRFID As Integer = 0
        Console.WriteLine("TieneRFID")
        Try
            Using connection = myConexion.Connect()
                Dim query As String = "
                SELECT COUNT(d.nnope) AS cantidad 
                FROM avhcd d 
                JOIN almart a ON a.ctpar = d.ctpar AND a.cartc = d.cartc 
                JOIN alwart w ON w.ctpar = a.ctpar AND w.cartc = a.cartc 
                WHERE d.ctpar = '11' 
                AND d.nnope = @nnope 
                AND a.tartc LIKE '%RFID%' 
                AND a.ccrct1 = '21'"

                Using comando As New AseCommand(query, connection)
                    comando.Parameters.Add(New AseParameter("@nnope", AseDbType.VarChar)).Value = pOp

                    Console.WriteLine($"Ejecutando consulta SQL...{query}")

                    Using reader As AseDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            ' Verificar si el valor no es nulo antes de asignarlo
                            esRFID = If(Not reader.IsDBNull(0), reader.GetInt32(0), 0)
                            Console.WriteLine($"esRFID->{esRFID}")
                        Else
                            Console.WriteLine("No se encontraron resultados.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error al ejecutar TieneRFID: {ex.Message}")
            LogError("Error en TieneRFID", ex)
        End Try

        Return esRFID
    End Function
    Public Function Retrieve(connection As AseConnection, pCodigoTrabajador As String, pOp As String, pNroCorte As String, petiqueta As String) As DataTable
        Dim tabla As New DataTable()
        If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
            Throw New InvalidOperationException("Conexión inválida o cerrada.")
        End If

        Try
            Dim query As String = BuildRetrieveQuery(pCodigoTrabajador, pOp, pNroCorte, petiqueta)
            Using command As New AseCommand(query, connection)
                ' Ajustar parámetros directamente al comando
                command.Parameters.Add(New AseParameter("@estado", AseDbType.VarChar)).Value = ESTADO_EMBALAJE
                Using reader As AseDataReader = command.ExecuteReader()
                    tabla.Load(reader)
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            LogError("Error en Retrieve", ex)
            Throw
        End Try

        Return tabla
    End Function

    Private Function BuildRetrieveQuery(pCodigoTrabajador As String, pOp As String, pNroCorte As String, petiqueta As String) As String
        Dim query As String = "SELECT op, corte, sub_corte, color, talla, id_talla, linea, fecha, fotocheck, estado, etiqueta, cod_talla, cod_comb FROM tmp_etiq_timbradas"
        Dim whereClause As String = ""

        If pOp <> "%" Then
            whereClause &= "op = @Op AND "
            comando.Parameters.Add(New AseParameter("@Op", AseDbType.VarChar)).Value = pOp
        End If

        If pNroCorte <> "%" Then
            whereClause &= "corte = @NroCorte AND "
            comando.Parameters.Add(New AseParameter("@NroCorte", AseDbType.VarChar)).Value = pNroCorte
        End If

        If pCodigoTrabajador <> "%" Then
            whereClause &= "fotocheck = @CodigoTrabajador AND "
            comando.Parameters.Add(New AseParameter("@CodigoTrabajador", AseDbType.VarChar)).Value = pCodigoTrabajador
        End If

        If petiqueta <> "%" Then
            whereClause &= "etiqueta = @etiqueta AND "
            comando.Parameters.Add(New AseParameter("@etiqueta", AseDbType.VarChar)).Value = petiqueta
        End If

        whereClause &= "estado = @estado"
        comando.Parameters.Add(New AseParameter("@estado", AseDbType.VarChar)).Value = ESTADO_EMBALAJE
        'Console.WriteLine($"pCodigoTrabajador-->{pCodigoTrabajador} petiqueta-->{petiqueta} query-->{query} whereClause-->{whereClause}")

        Return If(String.IsNullOrEmpty(whereClause), query, $"{query} WHERE {whereClause}")
    End Function

    ' Método para insertar un registro usando un procedimiento almacenado
    Public Function SetRfid(connection As AseConnection, sCodBarra As String, sCompania As String, sCodTrabajador As String, sIDRfid As String) As Tuple(Of Integer, String, DataTable)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()
        'Console.WriteLine("Iniciando SetRfid...")
        'Console.WriteLine($"Parámetros recibidos: sCodBarra={sCodBarra}, sCompania={sCompania}, sCodTrabajador={sCodTrabajador}, sIDRfid={sIDRfid}")

        Console.WriteLine($"Estado de la conexión al iniciar SetRfid: {connection?.State}")
        If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
            'Console.WriteLine("La conexión con la base de datos no pudo establecerse.")
            Return Tuple.Create(-1, "Error en conexión", tabla)
        End If

        Try
            Using trans = connection.BeginTransaction()
                'Console.WriteLine("Transacción iniciada.")
                Dim command As New AseCommand("USP_SAL_EMB_CON_RFID", connection) With {
                    .CommandType = CommandType.StoredProcedure,
                    .Transaction = trans
                }

                ' Agregar parámetros
                command.Parameters.Add(New AseParameter("@etqt", AseDbType.VarChar)).Value = sCodBarra
                command.Parameters.Add(New AseParameter("@empresa", AseDbType.VarChar)).Value = sCompania
                command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
                command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = sIDRfid
                Console.WriteLine("Parámetros agregados correctamente.")

                ' Ejecutar el comando
                Using reader As AseDataReader = command.ExecuteReader()
                    tabla.Load(reader)
                    Console.WriteLine($"Filas devueltas: {tabla.Rows.Count}")

                    If tabla.Rows.Count > 0 Then
                        li_return = Convert.ToInt32(tabla.Rows(0)(0))
                        If tabla.Columns.Count > 1 Then
                            s_mensaje = tabla.Rows(0)(1).ToString()
                        End If
                        Console.WriteLine($"Procedimiento exitoso: li_return={li_return}, s_mensaje={s_mensaje}")
                    Else
                        Console.WriteLine("No se devolvieron filas.")
                    End If
                End Using

                ' Llamar a Retrieve para obtener datos adicionales
                'Console.WriteLine("Llamando a Retrieve desde SetRfid...")
                Dim retrievedData = Retrieve(connection, sCodTrabajador, "%", "%", sCodBarra)
                'Console.WriteLine($"Filas devueltas por Retrieve: {retrievedData.Rows.Count}")
                If retrievedData.Rows.Count > 0 Then
                    tabla = retrievedData
                End If

                trans.Commit()
            End Using
        Catch ex As AseException
            Console.WriteLine($"Error en el procedimiento almacenado: {ex.Message}")
            ss_error = ex.Message
            li_return = -1
            LogError("Error en SetRfid", ex)
        End Try

        Return Tuple.Create(li_return, s_mensaje, tabla)
    End Function

    Public Function GetTimbradasByWorkerAndEtiqueta(pCodigoTrabajador As String, petiqueta As String) As DataTable
        Dim resultTable As New DataTable()

        Try
            Using connection = myConexion.Connect()
                Dim query As String = "SELECT op, corte, sub_corte, color, talla, id_talla, linea, fecha, fotocheck, estado, etiqueta, cod_talla, cod_comb " &
                                  "FROM tmp_etiq_timbradas " &
                                  "WHERE estado = @estado AND fotocheck = @fotocheck AND etiqueta = @etiqueta"

                Using comando As New AseCommand(query, connection)
                    comando.Parameters.Add(New AseParameter("@estado", AseDbType.VarChar)).Value = ESTADO_EMBALAJE
                    comando.Parameters.Add(New AseParameter("@fotocheck", AseDbType.VarChar)).Value = pCodigoTrabajador
                    comando.Parameters.Add(New AseParameter("@etiqueta", AseDbType.VarChar)).Value = petiqueta

                    Console.WriteLine("Ejecutando consulta SQL...")

                    Using reader As AseDataReader = comando.ExecuteReader()
                        resultTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error al ejecutar GetTimbradasByWorkerAndEtiqueta: {ex.Message}")
            LogError("Error en GetTimbradasByWorkerAndEtiqueta", ex)
            Throw
        End Try

        Console.WriteLine($"Filas devueltas: {resultTable.Rows.Count}")
        Return resultTable
    End Function

    ' Método para eliminar registros de tmp_etiq_timbradas basado en parámetros
    Public Function DeleteRows(whereParameters As Dictionary(Of String, Object)) As Integer
        Dim li_return As Integer = 0

        Using connectionAse = myConexion.Connect()
            Try
                Dim query As String = "DELETE FROM tmp_etiq_timbradas WHERE estado = @estado"
                comando.Connection = connectionAse
                comando.Parameters.Add(New AseParameter("@estado", AseDbType.VarChar)).Value = ESTADO_EMBALAJE

                For Each parameter In whereParameters
                    query &= $" AND {parameter.Key} = @{parameter.Key}"
                    comando.Parameters.Add(New AseParameter($"@{parameter.Key}", AseDbType.VarChar)).Value = parameter.Value
                Next

                comando.CommandText = query
                li_return = comando.ExecuteNonQuery()
            Catch ex As Exception
                ss_error = ex.Message
                LogError("Error en DeleteRows", ex)
            Finally
                myConexion.Disconnect()
            End Try
        End Using

        Return li_return
    End Function

    Public Function SaveRFID(sCodBarra As String, sCompania As String, sCodTrabajador As String, sIDRfid As String, nHoja As String) As Tuple(Of Integer, String)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()

        Try
            Using connectionAse = myConexion.Connect()
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New Exception("Error en conexión con la base de datos.")
                End If

                Using trans = connectionAse.BeginTransaction()
                    Try
                        Using command As New AseCommand("USP_SAL_EMB_CON_RFID", connectionAse, trans)
                            command.CommandType = CommandType.StoredProcedure
                            command.Parameters.Add(New AseParameter("@etqt", AseDbType.VarChar)).Value = sCodBarra
                            command.Parameters.Add(New AseParameter("@empresa", AseDbType.VarChar)).Value = sCompania
                            command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
                            command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = sIDRfid
                            command.Parameters.Add(New AseParameter("@nHoja", AseDbType.VarChar)).Value = nHoja

                            Using reader As AseDataReader = command.ExecuteReader()
                                tabla.Load(reader)
                                If tabla.Rows.Count > 0 Then
                                    li_return = Convert.ToInt32(tabla.Rows(0)(0))
                                    s_mensaje = If(tabla.Columns.Count > 1, tabla.Rows(0)(1).ToString(), "")
                                End If
                            End Using
                        End Using

                        trans.Commit()
                    Catch ex As Exception
                        trans.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            LogError("Error en SaveRFID", ex)
            li_return = -1
        End Try

        Return Tuple.Create(li_return, s_mensaje)
    End Function
    Public Function GetTBTimbrado(pCodigoTrabajador As String, pOp As String, pNroCorte As String, petiqueta As String) As DataTable
        Dim tabla As New DataTable()

        Using connectionAse = myConexion.Connect()
            Console.WriteLine($"Estado de la conexión en Retrieve: {connectionAse?.State}")
            Try
                comando.Connection = connectionAse
                comando.CommandText = BuildRetrieveQuery(pCodigoTrabajador, pOp, pNroCorte, petiqueta)
                Using reader As AseDataReader = comando.ExecuteReader()
                    tabla.Load(reader)
                End Using
            Catch ex As Exception
                ss_error = ex.Message
                LogError("Error en Retrieve", ex)
            Finally
                ' Evita desconectar si no es necesario
                myConexion.Disconnect()
            End Try
        End Using
        Return tabla
    End Function
    Public Function UpdateOrdenAcabadoTallasMov(whereParameters As Dictionary(Of String, Object), sCodTrabajador As String, codQR As String) As Tuple(Of Integer, String)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()

        Try
            Using connectionAse = myConexion.Connect()
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New Exception("Error en conexión con la base de datos.")
                End If

                Using trans = connectionAse.BeginTransaction()
                    Try
                        ' Ajustar los valores para que coincidan con la base de datos
                        Dim nnope As String = whereParameters("nnope").ToString()
                        Dim nordencorte As String = whereParameters("nordencorte").ToString()
                        Dim nordensubcorte As String = whereParameters("nordensubcorte").ToString()
                        Dim cod_talla As String = whereParameters("cod_talla").ToString()
                        Dim id_talla As String = whereParameters("id_talla").ToString()

                        Using command As New AseCommand("USP_SAL_EMB_UPD_RFID", connectionAse, trans)
                            command.CommandType = CommandType.StoredProcedure
                            command.Parameters.Add(New AseParameter("@op", AseDbType.VarChar)).Value = nnope
                            command.Parameters.Add(New AseParameter("@corte", AseDbType.VarChar)).Value = nordencorte
                            command.Parameters.Add(New AseParameter("@scorte", AseDbType.VarChar)).Value = nordensubcorte
                            command.Parameters.Add(New AseParameter("@cod_talla", AseDbType.VarChar)).Value = cod_talla
                            command.Parameters.Add(New AseParameter("@id", AseDbType.VarChar)).Value = id_talla
                            command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
                            command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = codQR

                            Using reader As AseDataReader = command.ExecuteReader()
                                tabla.Load(reader)
                                If tabla.Rows.Count > 0 Then
                                    li_return = Convert.ToInt32(tabla.Rows(0)(0))
                                    s_mensaje = If(tabla.Columns.Count > 1, tabla.Rows(0)(1).ToString(), "")
                                End If
                            End Using
                        End Using

                        trans.Commit()
                    Catch ex As Exception
                        trans.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            LogError("Error en Editar", ex)
            s_mensaje = "Error en DB"
            li_return = -1
        End Try

        Return Tuple.Create(li_return, s_mensaje)
    End Function

    Public Function UPDAcabadosTallaMov(whereParameters As Dictionary(Of String, Object), updateParameters As Dictionary(Of String, Object)) As Integer
        Dim li_return As Integer = 0

        ' Verificar que los parámetros necesarios estén en el diccionario
        If Not whereParameters.ContainsKey("nnope") OrElse Not whereParameters.ContainsKey("nordensubcorte") OrElse
       Not whereParameters.ContainsKey("cod_talla") OrElse Not whereParameters.ContainsKey("id_talla") OrElse
       Not whereParameters.ContainsKey("nordencorte") Then
            Throw New ArgumentException("Faltan parámetros necesarios en el diccionario.")
        End If

        ' Agregar ccmpn y flgestado a whereParameters si no están ya presentes
        If Not whereParameters.ContainsKey("ccmpn") Then whereParameters.Add("ccmpn", COMPANIA)
        If Not whereParameters.ContainsKey("flgestado") Then whereParameters.Add("flgestado", ESTADO_EMBALAJE)

        Try
            Using connectionAse As AseConnection = GetConnection()
                ' Validar que la conexión esté abierta
                If connectionAse.State <> ConnectionState.Open Then
                    Throw New InvalidOperationException("La conexión a la base de datos no está abierta.")
                End If

                ' Manejo de transacción
                Using trans = connectionAse.BeginTransaction()
                    Try
                        ' Construcción dinámica del SET en el UPDATE
                        Dim setClause As String = String.Join(", ", updateParameters.Keys.Select(Function(k) $"{k} = @{k}"))

                        ' Construcción dinámica del WHERE en el UPDATE
                        Dim whereClause As String = String.Join(" AND ", whereParameters.Keys.Select(Function(k) $"{k} = @{k}"))

                        ' Construir la consulta final
                        Dim query As String = $"UPDATE ordenacabadostallasmov SET fsalemb = GETDATE(), {setClause} WHERE {whereClause}"

                        ' Depuración: imprimir consulta
                        Console.WriteLine($"Consulta generada: {query}")

                        ' Crear comando con transacción
                        Using comando As New AseCommand(query, connectionAse, trans)
                            ' Agregar parámetros de actualización (SET), excepto fsalemb que ya está en GETDATE()
                            For Each param In updateParameters
                                comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                            Next

                            ' Agregar parámetros de condición (WHERE)
                            For Each param In whereParameters
                                comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                            Next

                            ' Ejecutar la actualización
                            li_return = comando.ExecuteNonQuery()

                            ' Depuración: mostrar resultado
                            Console.WriteLine($"Filas afectadas: {li_return}")

                            ' Confirmar transacción si se actualizaron filas
                            If li_return > 0 Then
                                trans.Commit()
                            Else
                                trans.Rollback()
                            End If
                        End Using

                    Catch ex As Exception
                        ' Si hay error, revertir cambios
                        trans.Rollback()
                        Console.WriteLine($"Error en UPDAcabadosTallaMov: {ex.Message}")
                        LogError("Error en UpdateOrdenAcabadoTallasMov", ex)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine($"Error en la conexión o ejecución del query: {ex.Message}")
            LogError("Error general en UPDAcabadosTallaMov", ex)
        End Try

        Return li_return
    End Function

    Public Function ListarTimbradas(whereParameters As Dictionary(Of String, Object)) As Tuple(Of Integer, String, DataTable)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()

        ' Agregar estado a whereParameters si no están ya presentes
        If Not whereParameters.ContainsKey("estado") Then whereParameters.Add("estado", ESTADO_EMBALAJE)

        Try
            Using connectionAse As AseConnection = GetConnection()
                ' Validar que la conexión esté abierta
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New InvalidOperationException("La conexión a la base de datos no está abierta.")
                End If

                ' Construcción dinámica del WHERE en el select
                Dim whereClause As String = String.Join(" AND ", whereParameters.Keys.Select(Function(k) $"{k} = @{k}"))

                ' Construir la consulta final
                Dim query As String = $"select linea,op,nhoja AS hoja_marcacion,corte,sub_corte AS subcorte,color,talla,cod_talla,id_talla,fecha,rfid AS id_rfid from tmp_etiq_timbradas WHERE {whereClause} order by fecha desc"

                ' Depuración: imprimir la consulta generada
                Console.WriteLine($"Consulta generada: {query}")

                ' Crear y ejecutar el comando SQL
                Using comando As New AseCommand(query, connectionAse)
                    ' Agregar parámetros al comando
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                    Next

                    ' Ejecutar la consulta y cargar los datos en el DataTable
                    Using reader As AseDataReader = comando.ExecuteReader()
                        tabla.Load(reader)
                    End Using
                End Using

                ' Determinar el número de filas devueltas
                li_return = tabla.Rows.Count
                s_mensaje = If(li_return > 0, "Datos obtenidos correctamente", "No se encontraron resultados")

            End Using

        Catch ex As Exception
            Console.WriteLine($"Error en ListarTimbradas: {ex.Message}")
            LogError("Error en ListarTimbradas", ex)
            li_return = -1
            s_mensaje = "Error en la consulta"
        End Try

        Return Tuple.Create(li_return, s_mensaje, tabla)
    End Function

    ' Método para eliminar registros de tmp_etiq_timbradas
    Public Function NuevoTimbrado(whereParameters As Dictionary(Of String, Object)) As Integer
        Dim li_return As Integer = 0
        ' Agregar estado a whereParameters si no están ya presentes
        If Not whereParameters.ContainsKey("estado") Then whereParameters.Add("estado", ESTADO_EMBALAJE)

        Try
            Using connectionAse As AseConnection = GetConnection()
                ' Validar que la conexión esté abierta
                If connectionAse.State <> ConnectionState.Open Then
                    Throw New InvalidOperationException("La conexión a la base de datos no está abierta.")
                End If

                ' Manejo de transacción
                Using trans = connectionAse.BeginTransaction()
                    Try

                        ' Construcción dinámica del WHERE en el UPDATE
                        Dim whereClause As String = String.Join(" AND ", whereParameters.Keys.Select(Function(k) $"{k} = @{k}"))

                        ' Construir la consulta final
                        Dim query As String = $"DELETE FROM tmp_etiq_timbradas WHERE {whereClause}"

                        ' Depuración: imprimir consulta
                        Console.WriteLine($"Consulta generada: {query}")

                        ' Crear comando con transacción
                        Using comando As New AseCommand(query, connectionAse, trans)

                            ' Agregar parámetros de condición (WHERE)
                            For Each param In whereParameters
                                comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                            Next

                            ' Ejecutar la actualización
                            li_return = comando.ExecuteNonQuery()

                            ' Depuración: mostrar resultado
                            Console.WriteLine($"Filas afectadas: {li_return}")

                            ' Confirmar transacción si se actualizaron filas
                            If li_return > 0 Then
                                trans.Commit()
                            Else
                                trans.Rollback()
                            End If
                        End Using

                    Catch ex As Exception
                        ' Si hay error, revertir cambios
                        trans.Rollback()
                        Console.WriteLine($"Error en NuevoTimbrado: {ex.Message}")
                        LogError("Error en NuevoTimbrado", ex)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine($"Error en la conexión o ejecución del query: {ex.Message}")
            LogError("Error general en NuevoTimbrado", ex)
        End Try

        Return li_return
    End Function

    Public Function UpdateTimbrado(whereParameters As Dictionary(Of String, Object), updateParameters As Dictionary(Of String, Object)) As Integer
        Dim li_return As Integer = 0

        ' Agregar estado a whereParameters si no están ya presentes
        If Not whereParameters.ContainsKey("estado") Then whereParameters.Add("estado", ESTADO_EMBALAJE)

        Try
            Using connectionAse As AseConnection = GetConnection()
                ' Validar que la conexión esté abierta
                If connectionAse.State <> ConnectionState.Open Then
                    Throw New InvalidOperationException("La conexión a la base de datos no está abierta.")
                End If

                ' Manejo de transacción
                Using trans = connectionAse.BeginTransaction()
                    Try
                        ' Construcción dinámica del SET en el UPDATE
                        Dim setClause As String = String.Join(", ", updateParameters.Keys.Select(Function(k) $"{k} = @{k}"))

                        ' Construcción dinámica del WHERE en el UPDATE
                        Dim whereClause As String = String.Join(" AND ", whereParameters.Keys.Select(Function(k) $"{k} = @{k}"))

                        ' Construir la consulta final
                        Dim query As String = $"UPDATE tmp_etiq_timbradas SET fecha = GETDATE(), {setClause} WHERE {whereClause}"

                        ' Depuración: imprimir consulta
                        Console.WriteLine($"Consulta generada: {query}")

                        ' Crear comando con transacción
                        Using comando As New AseCommand(query, connectionAse, trans)
                            ' Agregar parámetros de actualización (SET), excepto fsalemb que ya está en GETDATE()
                            For Each param In updateParameters
                                comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                            Next

                            ' Agregar parámetros de condición (WHERE)
                            For Each param In whereParameters
                                comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                            Next

                            ' Ejecutar la actualización
                            li_return = comando.ExecuteNonQuery()

                            ' Depuración: mostrar resultado
                            Console.WriteLine($"Filas afectadas: {li_return}")

                            ' Confirmar transacción si se actualizaron filas
                            If li_return > 0 Then
                                trans.Commit()
                            Else
                                trans.Rollback()
                            End If
                        End Using

                    Catch ex As Exception
                        ' Si hay error, revertir cambios
                        trans.Rollback()
                        Console.WriteLine($"Error en UpdateTimbrado: {ex.Message}")
                        LogError("Error en UpdateTimbrado", ex)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine($"Error en la conexión o ejecución del query: {ex.Message}")
            LogError("Error general en UpdateTimbrado", ex)
        End Try

        Return li_return
    End Function

    ' Método para registrar errores
    Private Sub LogError(message As String, Optional ex As Exception = Nothing)
        Dim logMessage As String = $"{DateTime.Now}: {message}"
        If ex IsNot Nothing Then
            logMessage &= Environment.NewLine & ex.ToString()
        End If
        IO.File.AppendAllText("db_errors.log", logMessage & Environment.NewLine)
    End Sub
    ' Método público para obtener la conexión
    Public Function GetConnection() As AseConnection
        Return myConexion.Connect()
    End Function

    ' Método para obtener el último error
    Public Function GetError() As String
        Return ss_error
    End Function
End Class
