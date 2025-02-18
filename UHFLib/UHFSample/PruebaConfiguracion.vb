Public Class PruebaConfiguracion
    Dim m_BDPrenda As New BDPrenda()
    Private Sub PruebaConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar una fila al DataGridView
        DataGridView1.Rows.Add()
        DataGridView1.Rows(0).Cells("op").Value = "1000038527"
        DataGridView1.Rows(0).Cells("corte").Value = "0001"
        DataGridView1.Rows(0).Cells("subcorte").Value = "000103"
        DataGridView1.Rows(0).Cells("cod_talla").Value = "01"
        DataGridView1.Rows(0).Cells("linea").Value = "35B"
        DataGridView1.Rows(0).Cells("id_talla").Value = "0341"
        DataGridView1.Rows(0).Cells("fecha").Value = "17-02-2025 10:35:00"
        DataGridView1.Rows(0).Cells("id_rfid").Value = "3BD000002550130EBC5AC930"
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'AlertaManager.MostrarAlerta("Operación exitosa.", Color.Green, tipo:=1, tiempo:=5)
        'AlertaManager.MostrarAlerta("Ocurrió un error.", Color.Red, tipo:=2, tiempo:=5)
        'Return

        If Confirmacion() Then
            ' Verificar que la fila seleccionada no es la de los encabezados
            If e.RowIndex >= 0 Then
                ' Obtener la fila que se ha hecho doble clic
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Obtener los valores de las celdas por nombre de columna
                Dim op As String = selectedRow.Cells("op").Value.ToString()
                Dim corte As String = selectedRow.Cells("corte").Value.ToString()
                Dim subcorte As String = selectedRow.Cells("subcorte").Value.ToString()
                Dim cod_talla As String = selectedRow.Cells("cod_talla").Value.ToString()
                Dim idTalla As String = selectedRow.Cells("id_talla").Value.ToString()
                Dim idRfid As String = ""
                Dim mCodTrabajador As String = "36104"
                Dim mColor As Color = Color.Red
                Dim mTipo As Integer = 3
                Dim mMsn As String = "Error al Actualizar"

                ' Crear un diccionario con los parámetros para la actualización
                Dim whereParameters As New Dictionary(Of String, Object) From {
                    {"nnope", op},
                    {"nordencorte", corte},
                    {"nordensubcorte", subcorte},
                    {"cod_talla", cod_talla},
                    {"id_talla", idTalla}
                }
                ' Llamar al método UpdateOrdenAcabadoTallasMov con los parámetros y el ID RFID
                Dim lsResult = m_BDPrenda.UPDAcabadosTallaMov(whereParameters, mCodTrabajador, idRfid)
                If lsResult > 0 Then
                    mColor = Color.Green
                    mTipo = 1
                    mMsn = "Actualización OK"
                    ' **Actualizar el campo `id_rfid` en la DataGridView**
                    selectedRow.Cells("id_rfid").Value = idRfid
                End If
                AlertaManager.MostrarAlerta($"{mMsn}", mColor, mTipo, 15)
                ' Llamar al método UpdateOrdenAcabadoTallasMov con los parámetros y el ID RFID
                'Dim lsResult = m_BDPrenda.UpdateOrdenAcabadoTallasMov(whereParameters, mCodTrabajador, idRfid)
                'Console.WriteLine($"Codigo: {lsResult.Item1} Msn: {lsResult.Item2}")
                ' Actualizar el control 'MsnVincular' de forma segura
                'SafeUpdateLabel(MsnVincular, lsResult.Item2)
                'If lsResult.Item1 = 1 Then
                'mColor = Color.Green
                'mTipo = 1

                ' **Actualizar el campo `id_rfid` en la DataGridView**
                'selectedRow.Cells("id_rfid").Value = idRfid
                'End If
                'mTipo = If(lsResult.Item1 = -1, 3, mTipo)
                'Console.WriteLine($"mColor: {mColor} mTipo:{mTipo}")

                'AlertaManager.MostrarAlerta($"{lsResult.Item2}", mColor, mTipo, 15)
                'SafeUpdateLabel(MsnVincular, lsResult.Item2)
                'SafeUpdateTextBox(CodBarras, "")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Muestra un cuadro de diálogo de confirmación y devuelve un booleano.
    ''' </summary>
    ''' <returns>True si el usuario confirmó, False en caso contrario.</returns>
    Private Function Confirmacion() As Boolean
        Try
            Using confirmForm As New FormConfirmacion("¿Está seguro de editar?", Color.FromArgb(255, 165, 0), "¿Desea continuar con la edición?")
                Return confirmForm.ShowDialog() = DialogResult.OK
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error en Confirmacion(): {ex.Message}")
            Return False
        End Try
    End Function

    Private Sub MostrarError()
        ' Crear una instancia del formulario de alerta de error
        Dim alertaError As New FormAlertaError("Error de conexión", "Hubo un problema al intentar conectarse al servidor. Por favor, intente nuevamente.", Color.Red)

        ' Mostrar el formulario de alerta de error
        alertaError.ShowDialog()
    End Sub

    Private Sub MostrarAlertaOk()
        ' Crear una instancia del formulario FormAlertaOk
        Dim alertaOk As New FormAlertaOk("¡Operación exitosa!", Color.Green, 10, "La operación se completó con éxito.")

        ' Mostrar el formulario de alerta
        alertaOk.ShowDialog()
    End Sub

    Private Sub MostrarAlertaExito()
        ' Crear una instancia del formulario FormAlerta con mensaje, color y tipo
        Dim alerta As New FormAlerta("Operación exitosa", Color.Green, 1, 5) ' 1: Tipo éxito, 5 segundos de duración

        ' Mostrar el formulario de alerta
        alerta.Show()
    End Sub


End Class