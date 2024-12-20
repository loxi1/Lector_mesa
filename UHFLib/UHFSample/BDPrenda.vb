Imports System.Data
Imports Sybase.Data.AseClient

Public Class BDPrenda
    Friend ReadOnly myConexion As New Sybase()
    Private comando As New AseCommand()
    Private ss_error As String = ""
    Private Const ESTADO_EMBALAJE As String = "SALIDA EMBALAJE"

    ' Método para obtener datos de la tabla
    Public Function Retrieve(connection As AseConnection, pCodigoTrabajador As String, pOp As String, pNroCorte As String, petiqueta As String) As DataTable
        Dim tabla As New DataTable()
        Debug.Print("Iniciando Retrieve...")
        If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
            Debug.Print("La conexión no está abierta. No se puede ejecutar Retrieve.")
            Throw New InvalidOperationException("Conexión inválida o cerrada.")
        End If

        Try
            Debug.Print($"Estado de la conexión en Retrieve: {connection?.State}")
            Dim command As New AseCommand(BuildRetrieveQuery(pCodigoTrabajador, pOp, pNroCorte, petiqueta), connection)
            Using reader As AseDataReader = command.ExecuteReader()
                tabla.Load(reader)
                Debug.Print("Columnas devueltas por el procedimiento almacenado:")
                For Each column As DataColumn In tabla.Columns
                    Debug.Print($"Columna: {column.ColumnName}")
                Next
            End Using
        Catch ex As Exception
            ss_error = ex.Message
            LogError("Error en Retrieve", ex)
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
        Debug.Print($"pCodigoTrabajador-->{pCodigoTrabajador} petiqueta-->{petiqueta} query-->{query} whereClause-->{whereClause}")

        Return If(String.IsNullOrEmpty(whereClause), query, $"{query} WHERE {whereClause}")
    End Function

    ' Método para insertar un registro usando un procedimiento almacenado
    Public Function SetRfid(connection As AseConnection, sCodBarra As String, sCompania As String, sCodTrabajador As String, sIDRfid As String) As Tuple(Of Integer, String, DataTable)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()
        Debug.Print("Iniciando SetRfid...")
        Debug.Print($"Parámetros recibidos: sCodBarra={sCodBarra}, sCompania={sCompania}, sCodTrabajador={sCodTrabajador}, sIDRfid={sIDRfid}")

        Debug.Print($"Estado de la conexión al iniciar SetRfid: {connection?.State}")
        If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
            Debug.Print("La conexión con la base de datos no pudo establecerse.")
            Return Tuple.Create(-1, "Error en conexión", tabla)
        End If

        Try
            Using trans = connection.BeginTransaction()
                Debug.Print("Transacción iniciada.")
                Dim command As New AseCommand("USP_SAL_EMB_CON_RFID", connection) With {
                    .CommandType = CommandType.StoredProcedure,
                    .Transaction = trans
                }

                ' Agregar parámetros
                command.Parameters.Add(New AseParameter("@etqt", AseDbType.VarChar)).Value = sCodBarra
                command.Parameters.Add(New AseParameter("@empresa", AseDbType.VarChar)).Value = sCompania
                command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
                command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = sIDRfid
                Debug.Print("Parámetros agregados correctamente.")

                ' Ejecutar el comando
                Using reader As AseDataReader = command.ExecuteReader()
                    tabla.Load(reader)
                    Debug.Print($"Filas devueltas: {tabla.Rows.Count}")

                    If tabla.Rows.Count > 0 Then
                        li_return = Convert.ToInt32(tabla.Rows(0)(0))
                        If tabla.Columns.Count > 1 Then
                            s_mensaje = tabla.Rows(0)(1).ToString()
                        End If
                        Debug.Print($"Procedimiento exitoso: li_return={li_return}, s_mensaje={s_mensaje}")
                    Else
                        Debug.Print("No se devolvieron filas.")
                    End If
                End Using

                ' Llamar a Retrieve para obtener datos adicionales
                Debug.Print("Llamando a Retrieve desde SetRfid...")
                Dim retrievedData = Retrieve(connection, sCodTrabajador, "%", "%", sCodBarra)
                Debug.Print($"Filas devueltas por Retrieve: {retrievedData.Rows.Count}")
                If retrievedData.Rows.Count > 0 Then
                    tabla = retrievedData
                End If

                trans.Commit()
            End Using
        Catch ex As AseException
            Debug.Print($"Error en el procedimiento almacenado: {ex.Message}")
            ss_error = ex.Message
            li_return = -1
            LogError("Error en SetRfid", ex)
        End Try

        Return Tuple.Create(li_return, s_mensaje, tabla)
    End Function

    Public Function GetTimbradasByWorkerAndEtiqueta(pCodigoTrabajador As String, petiqueta As String) As DataTable
        Dim resultTable As New DataTable()
        Debug.Print("Iniciando GetTimbradasByWorkerAndEtiqueta...")

        Using connection = myConexion.Connect()
            If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
                Debug.Print("No se pudo establecer la conexión con la base de datos.")
                Throw New Exception("Error en la conexión a la base de datos.")
            End If

            Try
                Dim query As String = "SELECT op, corte, sub_corte, color, talla, id_talla, linea, fecha, fotocheck, estado, etiqueta, cod_talla, cod_comb " &
                                  "FROM tmp_etiq_timbradas " &
                                  "WHERE estado = @estado AND fotocheck = @fotocheck AND etiqueta = @etiqueta"

                Using comando As New AseCommand(query, connection)
                    ' Agregar parámetros
                    comando.Parameters.Add(New AseParameter("@estado", AseDbType.VarChar)).Value = ESTADO_EMBALAJE
                    comando.Parameters.Add(New AseParameter("@fotocheck", AseDbType.VarChar)).Value = pCodigoTrabajador
                    comando.Parameters.Add(New AseParameter("@etiqueta", AseDbType.VarChar)).Value = petiqueta

                    Debug.Print("Ejecutando consulta SQL...")

                    ' Ejecutar la consulta
                    Using reader As AseDataReader = comando.ExecuteReader()
                        resultTable.Load(reader)
                    End Using
                End Using

                Debug.Print($"Filas devueltas: {resultTable.Rows.Count}")
            Catch ex As Exception
                Debug.Print($"Error al ejecutar GetTimbradasByWorkerAndEtiqueta: {ex.Message}")
                LogError("Error en GetTimbradasByWorkerAndEtiqueta", ex)
            End Try
        End Using

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
    'Public Function SaveRFID(sCodBarra As String, sCompania As String, sCodTrabajador As String, sIDRfid As String) As Tuple(Of Integer, String)
    '    Dim li_return As Integer = 0
    '    Dim s_mensaje As String = ""
    '    Dim tabla As New DataTable()

    '    Debug.Print("Iniciando SetRfid...")
    '    Debug.Print($"Parámetros recibidos: sCodBarra={sCodBarra}, sCompania={sCompania}, sCodTrabajador={sCodTrabajador}, sIDRfid={sIDRfid}")

    '    Using connectionAse = myConexion.Connect()
    '        Debug.Print($"Estado de la conexión: {connectionAse?.State}")
    '        If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
    '            Debug.Print("La conexión con la base de datos no pudo establecerse.")
    '            Return Tuple.Create(-1, "Error en conexión")
    '        End If

    '        Try
    '            Using trans = connectionAse.BeginTransaction()
    '                Debug.Print("Transacción iniciada.")
    '                Dim command As New AseCommand("USP_SAL_EMB_CON_RFID", connectionAse) With {
    '                    .CommandType = CommandType.StoredProcedure,
    '                    .Transaction = trans
    '                }

    '                command.Parameters.Add(New AseParameter("@etqt", AseDbType.VarChar)).Value = sCodBarra
    '                command.Parameters.Add(New AseParameter("@empresa", AseDbType.VarChar)).Value = sCompania
    '                command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
    '                command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = sIDRfid

    '                Debug.Print("Ejecutando el procedimiento almacenado...")
    '                Using reader As AseDataReader = command.ExecuteReader()
    '                    tabla.Load(reader)
    '                    If tabla.Rows.Count > 0 Then
    '                        li_return = Convert.ToInt32(tabla.Rows(0)(0))
    '                        If tabla.Columns.Count > 1 Then
    '                            s_mensaje = tabla.Rows(0)(1).ToString()
    '                        End If
    '                        Debug.Print($"Procedimiento exitoso: li_return={li_return}, s_mensaje={s_mensaje}")
    '                    Else
    '                        Debug.Print("No se devolvieron filas.")
    '                    End If
    '                    Debug.Print($"Filas devueltas: {tabla.Rows.Count}")
    '                End Using

    '                trans.Commit()
    '                Debug.Print("Transacción confirmada.")
    '            End Using
    '        Catch ex As AseException
    '            Debug.Print($"Error en el procedimiento almacenado: {ex.Message}")
    '            ss_error = ex.Message
    '        Finally
    '            myConexion.Disconnect()
    '        End Try
    '    End Using

    '    Return Tuple.Create(li_return, s_mensaje)
    'End Function
    Public Function SaveRFID(sCodBarra As String, sCompania As String, sCodTrabajador As String, sIDRfid As String) As Tuple(Of Integer, String)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()

        Debug.Print("Iniciando SaveRFID...")
        Debug.Print($"Parámetros recibidos: sCodBarra={sCodBarra}, sCompania={sCompania}, sCodTrabajador={sCodTrabajador}, sIDRfid={sIDRfid}")

        Dim connectionAse As AseConnection = Nothing

        Try
            connectionAse = myConexion.Connect()
            Debug.Print($"Estado de la conexión: {connectionAse?.State}")
            If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                Debug.Print("La conexión con la base de datos no pudo establecerse.")
                Return Tuple.Create(-1, "Error en conexión")
            End If

            Using trans = connectionAse.BeginTransaction()
                Debug.Print("Transacción iniciada.")
                Dim command As New AseCommand("USP_SAL_EMB_CON_RFID", connectionAse) With {
                .CommandType = CommandType.StoredProcedure,
                .Transaction = trans
            }

                command.Parameters.Add(New AseParameter("@etqt", AseDbType.VarChar)).Value = sCodBarra
                command.Parameters.Add(New AseParameter("@empresa", AseDbType.VarChar)).Value = sCompania
                command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
                command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = sIDRfid

                Debug.Print("Ejecutando el procedimiento almacenado...")
                Using reader As AseDataReader = command.ExecuteReader()
                    tabla.Load(reader)
                    If tabla.Rows.Count > 0 Then
                        li_return = Convert.ToInt32(tabla.Rows(0)(0))
                        If tabla.Columns.Count > 1 Then
                            s_mensaje = tabla.Rows(0)(1).ToString()
                        End If
                        Debug.Print($"Procedimiento exitoso: li_return={li_return}, s_mensaje={s_mensaje}")
                    Else
                        Debug.Print("No se devolvieron filas.")
                    End If
                    Debug.Print($"Filas devueltas: {tabla.Rows.Count}")
                End Using

                ' Llamar a Retrieve dentro de la misma conexión
                Debug.Print("Llamando a Retrieve desde SaveRFID...")
                Dim retrievedData = Retrieve(connectionAse, sCodTrabajador, "%", "%", sCodBarra)
                Debug.Print($"Filas devueltas por Retrieve: {retrievedData.Rows.Count}")
                If retrievedData.Rows.Count > 0 Then
                    tabla = retrievedData
                End If

                trans.Commit()
                Debug.Print("Transacción confirmada.")
            End Using
        Catch ex As AseException
            Debug.Print($"Error en el procedimiento almacenado: {ex.Message}")
            ss_error = ex.Message
        Finally
            If connectionAse IsNot Nothing AndAlso connectionAse.State = ConnectionState.Open Then
                connectionAse.Close()
            End If
        End Try

        Return Tuple.Create(li_return, s_mensaje)
    End Function

    Public Function GetTBTimbrado(pCodigoTrabajador As String, pOp As String, pNroCorte As String, petiqueta As String) As DataTable
        Dim tabla As New DataTable()
        Debug.Print("Iniciando Retrieve...")
        Using connectionAse = myConexion.Connect()
            Debug.Print($"Estado de la conexión en Retrieve: {connectionAse?.State}")
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
