﻿Imports System.Linq
Imports System.Text
Imports Sybase.Data.AseClient
Imports System.Collections.Generic
Imports System.Data

Public Class DBConsultarPrenda
    Friend ReadOnly myConexion As New Sybase()
    Private ReadOnly sybase As New Sybase() ' Instancia de la clase Sybase para manejar la conexión
    Private comando As New AseCommand()
    Private ss_error As String = ""
    Private Const ESTADO_EMBALAJE As String = "SALIDA EMBALAJE"
    Private Const COMPANIA As String = "02"
    Public Function ObtenerSubCorte(pOp As String, pCorte As String, pCodTalla As String, pIdTalla As String) As String
        Dim pSubCorte As String = ""
        If String.IsNullOrEmpty(pOp) OrElse String.IsNullOrEmpty(pCorte) OrElse String.IsNullOrEmpty(pCodTalla) OrElse String.IsNullOrEmpty(pIdTalla) Then
            Throw New ArgumentException("Los parámetros no pueden estar vacíos o nulos.")
        End If

        Try
            Using connection = myConexion.Connect()
                Dim query As String = $"Select NOrdenSubCorte from ordencortetallasid where ccmpn = '{COMPANIA}' " &
                "and nnope=@nnope " &
                "and nordencorte = @nordencorte " &
                "and cod_talla= @cod_talla " &
                "and id_talla = @id_talla"

                Using comando As New AseCommand(query, connection)
                    comando.Parameters.Add(New AseParameter("@nnope", AseDbType.VarChar)).Value = pOp
                    comando.Parameters.Add(New AseParameter("@nordencorte", AseDbType.VarChar)).Value = pCorte
                    comando.Parameters.Add(New AseParameter("@cod_talla", AseDbType.VarChar)).Value = pCodTalla
                    comando.Parameters.Add(New AseParameter("@id_talla", AseDbType.VarChar)).Value = pIdTalla

                    Using reader As AseDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            ' Verificar si el valor no es nulo antes de asignarlo
                            pSubCorte = If(Not reader.IsDBNull(0), reader.GetString(0), "")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
            Throw
        End Try

        Return pSubCorte
    End Function
    Public Function GetHistorialPrenda(pOp As String, pCorte As String, pSubCorte As String, pCodTalla As String, pIdTalla As String) As DataTable
        Dim tabla As New DataTable()

        Try
            Using connectionAse = myConexion.Connect()
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New Exception("Error en conexión con la base de datos.")
                End If

                Using command As New AseCommand("USP_ACAB_EMB_MOV_PRENDAS", connectionAse)
                    command.CommandType = CommandType.StoredProcedure

                    ' Parámetros
                    command.Parameters.Add(New AseParameter("@compania", AseDbType.VarChar)).Value = COMPANIA
                    command.Parameters.Add(New AseParameter("@op", AseDbType.VarChar)).Value = pOp
                    command.Parameters.Add(New AseParameter("@corte", AseDbType.VarChar)).Value = pCorte
                    command.Parameters.Add(New AseParameter("@subcorte", AseDbType.VarChar)).Value = pSubCorte
                    command.Parameters.Add(New AseParameter("@talla", AseDbType.VarChar)).Value = pCodTalla
                    command.Parameters.Add(New AseParameter("@id", AseDbType.VarChar)).Value = pIdTalla

                    ' Ejecución del comando
                    Using reader As AseDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
                        tabla.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As AseException
            LogError($"Error de base de datos: {ex.Message}", ex)
            Throw
        Catch ex As Exception
            LogError("Error general al ejecutar GetHistorialPrenda", ex)
            Throw
        End Try

        Return tabla
    End Function

    Public Function ValidarOP(whereParameters As Dictionary(Of String, Object), tipo As String) As String

        Dim queryBuilder As New StringBuilder("SELECT TOP 1 norpd,nhjmr FROM althmd")
        Dim result As String = ""
        Dim datos As New DataTable()

        ' Validar que el parámetro no sea nulo o vacío
        If whereParameters.Count = 0 Then
            Throw New ArgumentException("El parámetro pOp no puede estar vacío o ser nulo.")
        End If

        ' Construir la cláusula WHERE con los parámetros proporcionados
        queryBuilder.Append(" Where ").Append(BuildWhereClause(whereParameters))
        Dim query As String = queryBuilder.ToString()
        Console.WriteLine($"<query> {query}")
        Try
            Using connectionAse = myConexion.Connect()
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New Exception("Error en conexión con la base de datos.")
                End If

                Using comando As New AseCommand(query, connectionAse)
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                        Console.WriteLine($"@{param.Key} : {param.Value}")
                    Next

                    ' Ejecutar consulta
                    Using reader As AseDataReader = comando.ExecuteReader()
                        datos.Load(reader) ' Cargar los resultados en un DataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores
            Dim errorMessage As String = $"Error al validar OP: {ex.Message}"
        End Try

        ' Verificar si hay resultados
        If datos.Rows.Count > 0 Then
            Dim row As DataRow = datos.Rows(0)

            ' Convertir el resultado a entero de forma segura
            If row("norpd") IsNot DBNull.Value Then
                result = row(tipo).ToString()
            End If
        End If

        Return result
    End Function
    Public Function BuscarHMDetalle(whereParameters As Dictionary(Of String, Object)) As Tuple(Of Integer, List(Of Dictionary(Of String, Object)), Dictionary(Of String, List(Of Dictionary(Of String, Object))))
        Console.WriteLine($"Ingreso BuscarHMDetalle")
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("SELECT ")
        queryBuilder.AppendLine("    alt.cclrcl,")
        queryBuilder.AppendLine("    alt.tclrcl,")
        queryBuilder.AppendLine("    alt.qartsl,")
        queryBuilder.AppendLine("    alw.tcrct6")
        queryBuilder.AppendLine("FROM althmd alt")
        queryBuilder.AppendLine("LEFT JOIN almart alm ON alm.ctpar = alt.ctpar AND alm.cartc = alt.cartc")
        queryBuilder.AppendLine("LEFT JOIN alwart alw ON alm.ctpar = alw.ctpar AND alm.cartc = alw.cartc")

        Dim datos As New DataTable()
        Dim totalTalla As New List(Of Dictionary(Of String, Object))
        Dim detalleTalla As New Dictionary(Of String, List(Of Dictionary(Of String, Object)))()
        Dim codigo As Integer = 0

        ' Validar parámetros
        If whereParameters Is Nothing OrElse whereParameters.Count = 0 Then
            Throw New ArgumentException("El parámetro whereParameters no puede estar vacío o ser nulo.")
        End If

        ' Construir WHERE dinámico
        Dim l_where As String = BuildWhereClause(whereParameters)
        Console.WriteLine($"l_where(1)=>{l_where}")
        l_where = l_where.Replace("norpd =", "alt.norpd =").Replace("nhjmr =", "alt.nhjmr =")
        Console.WriteLine($"l_where(2)=>{l_where}")
        queryBuilder.Append(" WHERE ").Append(l_where)

        Try
            ' Ejecutar consulta y cargar datos
            Dim query As String = queryBuilder.ToString()
            Console.WriteLine($"Query ejecutado: {query}")
            Using connectionAse = myConexion.Connect()
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New Exception("Error en conexión con la base de datos.")
                End If

                Using comando As New AseCommand(query, connectionAse)
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                    Next

                    Using reader As AseDataReader = comando.ExecuteReader()
                        datos.Load(reader)
                    End Using
                End Using
            End Using

            If datos.Rows.Count = 0 Then
                Return Tuple.Create(0, totalTalla, detalleTalla)
            End If
            ' Agrupar manualmente los datos
            Dim agrupados = New Dictionary(Of String, (tclrcl As String, total As Integer, detalles As List(Of Dictionary(Of String, Object))))()

            For Each row As DataRow In datos.Rows
                Dim cclrcl = row("cclrcl").ToString()
                Dim tclrcl = row("tclrcl").ToString()
                Dim qartsl = Convert.ToInt32(row("qartsl"))
                Dim tcrct6 = row("tcrct6").ToString()

                ' Crear clave única para agrupar
                If Not agrupados.ContainsKey(cclrcl) Then
                    agrupados(cclrcl) = (tclrcl, 0, New List(Of Dictionary(Of String, Object))())
                End If

                ' Actualizar total y detalles
                agrupados(cclrcl) = (agrupados(cclrcl).tclrcl, agrupados(cclrcl).total + qartsl, agrupados(cclrcl).detalles)
                agrupados(cclrcl).detalles.Add(New Dictionary(Of String, Object) From {
                    {"talla", tcrct6},
                    {"cantidad", qartsl}
                })
            Next

            ' Convertir resultados a totalTalla y detalleTalla
            For Each grupo In agrupados
                totalTalla.Add(New Dictionary(Of String, Object) From {
                    {"cclrcl", grupo.Key},
                    {"tclrcl", grupo.Value.tclrcl},
                    {"total", grupo.Value.total}
                })

                detalleTalla.Add(grupo.Key, grupo.Value.detalles)
            Next

        Catch ex As Exception
            Dim errorMessage As String = $"Error al Buscar HM: {ex.Message}"
            Console.WriteLine(errorMessage)
        End Try

        Return Tuple.Create(1, totalTalla, detalleTalla)
    End Function


    Public Function BuscarHMCabecera(whereParameters As Dictionary(Of String, Object)) As DataTable
        ' Crear un StringBuilder para construir la consulta SQL
        Dim queryBuilder As New StringBuilder()

        ' Agregar la consulta especificando solo las columnas necesarias
        queryBuilder.AppendLine("SELECT ")
        queryBuilder.AppendLine("    althmc.norpd,")
        queryBuilder.AppendLine("    althmc.nhjmr,")
        queryBuilder.AppendLine("    althmc.cclnt,")
        queryBuilder.AppendLine("    althmc.npocl,")
        queryBuilder.AppendLine("    CONVERT(VARCHAR, althmc.fentr, 105) AS fentr,")
        queryBuilder.AppendLine("    althmc.cctgr,")
        queryBuilder.AppendLine("    althmc.tfrmem,")
        queryBuilder.AppendLine("    althmc.ptlrnc,")
        queryBuilder.AppendLine("    althmc.clgren,")
        queryBuilder.AppendLine("    althmc.tvia,")
        queryBuilder.AppendLine("    althmc.totros,")
        queryBuilder.AppendLine("    althmc.cestcl,")
        queryBuilder.AppendLine("    althmc.testcl,")
        queryBuilder.AppendLine("    althmc.sesthm,")
        queryBuilder.AppendLine("    althmc.cusula,")
        queryBuilder.AppendLine("    althmc.fultac,")
        queryBuilder.AppendLine("    althmc.ctptr,")
        queryBuilder.AppendLine("    althmc.mainmarks,")
        queryBuilder.AppendLine("    althmc.sidemarks,")
        queryBuilder.AppendLine("    althmc.sestps,")
        queryBuilder.AppendLine("    althmc.cod_tgen,")
        queryBuilder.AppendLine("    althmc.nro_kit,")
        queryBuilder.AppendLine("    althmc.nro_referencia,")
        queryBuilder.AppendLine("    ptmtrc.ttrcr,")
        queryBuilder.AppendLine("    almlge_a.tdrcc,")
        queryBuilder.AppendLine("    almlge_a.tlgen,")
        queryBuilder.AppendLine("    altopc.cmodelo,")
        queryBuilder.AppendLine("    almcad.tdscr,")
        queryBuilder.AppendLine("    altopc.cgrtalla,")
        queryBuilder.AppendLine("    althmc.npocl AS 'npocl_act',")
        queryBuilder.AppendLine("    altopc.sreserva,")
        queryBuilder.AppendLine("    altopc.temporada,")
        queryBuilder.AppendLine("    altopc.cproto,")
        queryBuilder.AppendLine("    altopc.nro_certificado,")
        queryBuilder.AppendLine("    altopc.flgdespacho,")
        queryBuilder.AppendLine("    althmc.cod_lugrent_cobro,")
        queryBuilder.AppendLine("    almlge_b.tlgen,")
        queryBuilder.AppendLine("    almlge_b.tdrcc,")
        queryBuilder.AppendLine("    CASE WHEN altopc.flgdespacho = '0' THEN 'SIN DESPACHAR' WHEN altopc.flgdespacho = '1' THEN 'DESPACHADO' ELSE '' END AS flgdes")
        queryBuilder.AppendLine("FROM althmc")
        queryBuilder.AppendLine("INNER JOIN altopc ON ( althmc.norpd = altopc.nnope )")
        queryBuilder.AppendLine("INNER JOIN ptmtrc ON ( althmc.cclnt = ptmtrc.ctrcr )")
        queryBuilder.AppendLine("LEFT OUTER JOIN almlge almlge_a ON ( althmc.ctptr = almlge_a.ctptr AND althmc.cclnt = almlge_a.ctrcr AND althmc.clgren = almlge_a.clgen )")
        queryBuilder.AppendLine("LEFT OUTER JOIN almlge almlge_b ON ( althmc.ctptr = almlge_b.ctptr AND althmc.cclnt = almlge_b.ctrcr AND althmc.cod_lugrent_cobro = almlge_b.clgen )")
        queryBuilder.AppendLine("LEFT OUTER JOIN almcad ON altopc.cmodelo = almcad.ccrct")
        queryBuilder.AppendLine("WHERE almcad.ctpar = '10' AND almcad.norden = '1'")

        Dim datos As New DataTable()

        ' Validar que el parámetro no sea nulo o vacío
        If whereParameters Is Nothing OrElse whereParameters.Count = 0 Then
            Throw New ArgumentException("El parámetro whereParameters no puede estar vacío o ser nulo.")
        End If

        Dim l_where As String = BuildWhereClause(whereParameters)
        l_where = l_where.Replace("norpd  =", "althmc.norpd  =")
        l_where = l_where.Replace("nhjmr =", "althmc.nhjmr =")

        ' Construir la cláusula WHERE con los parámetros proporcionados
        queryBuilder.Append(" And ").Append(l_where)
        Dim query As String = queryBuilder.ToString()
        'Console.WriteLine($"El query<- {query} ->")
        Try
            Using connectionAse = myConexion.Connect()
                If connectionAse Is Nothing OrElse connectionAse.State <> ConnectionState.Open Then
                    Throw New Exception("Error en conexión con la base de datos.")
                End If

                Using comando As New AseCommand(query, connectionAse)
                    For Each param In whereParameters
                        comando.Parameters.AddWithValue($"@{param.Key}", param.Value)
                    Next

                    ' Ejecutar consulta
                    Using reader As AseDataReader = comando.ExecuteReader()
                        datos.Load(reader) ' Cargar los resultados en un DataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores
            Dim errorMessage As String = $"Error al Buscar HM: {ex.Message}"
            Console.WriteLine(errorMessage)
        End Try

        Return datos
    End Function

    ' Método para construir la cláusula WHERE dinámicamente
    Private Function BuildWhereClause(parameters As Dictionary(Of String, Object)) As String
        Return String.Join(" AND ", parameters.Keys.Select(Function(key) $"{key} = @{key}"))
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
