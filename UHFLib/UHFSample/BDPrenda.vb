Imports System.Data
Imports Sybase.Data.AseClient ' O usa WL.Sybase.AdoNet4.AseClient

Public Class BDPrenda
    Private ReadOnly myConexion As New Sybase()
    Private connectionAse As AseConnection
    Private ss_error As String = ""

    Public Function SetRfid(sCodBarra As String, sCompania As String, sCodTrabajador As String, sIDRfid As String) As Tuple(Of Integer, String, DataTable)
        Dim li_return As Integer = 0
        Dim s_mensaje As String = ""
        Dim tabla As New DataTable()

        Using connectionAse = myConexion.Connect()
            Try
                Dim trans = connectionAse.BeginTransaction()

                Dim storedProcedureName As String = "USP_SAL_EMB_CON_RFID"

                Using command As New AseCommand(storedProcedureName, connectionAse)
                    command.CommandType = CommandType.StoredProcedure
                    command.Transaction = trans

                    ' Agregar parámetros al procedimiento almacenado
                    command.Parameters.Add(New AseParameter("@etqt", AseDbType.VarChar)).Value = sCodBarra
                    command.Parameters.Add(New AseParameter("@empresa", AseDbType.VarChar)).Value = sCompania
                    command.Parameters.Add(New AseParameter("@usr", AseDbType.VarChar)).Value = sCodTrabajador
                    command.Parameters.Add(New AseParameter("@rfid", AseDbType.VarChar)).Value = sIDRfid

                    ' Ejecutar el comando y leer los resultados
                    Using reader As AseDataReader = command.ExecuteReader()
                        tabla.Load(reader)
                        If tabla.Rows.Count > 0 Then
                            li_return = Convert.ToInt32(tabla.Rows(0)(0))
                            If tabla.Columns.Count > 1 Then
                                s_mensaje = Convert.ToString(tabla.Rows(0)(1))
                            End If
                            trans.Commit()
                        End If
                    End Using
                End Using
            Catch ex As AseException
                ss_error = ex.Message
                li_return = -1
            Finally
                myConexion.Disconnect()
            End Try
        End Using
        Return Tuple.Create(li_return, s_mensaje, tabla)
    End Function

    ' Método para obtener errores
    Public Function GetError() As String
        Return ss_error
    End Function
End Class
