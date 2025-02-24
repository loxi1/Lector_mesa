Public Class PruebaConfiguracion
    Dim m_BDPrenda As New BDPrenda()
    Private Sub PruebaConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar una fila al DataGridView
        DataGridView1.Rows.Add()
        DataGridView1.Rows(0).Cells("op").Value = "1000038527"
        DataGridView1.Rows(0).Cells("hoja_marcacion").Value = "006"
        DataGridView1.Rows(0).Cells("corte").Value = "0001"
        DataGridView1.Rows(0).Cells("subcorte").Value = "000103"
        DataGridView1.Rows(0).Cells("cod_talla").Value = "01"
        DataGridView1.Rows(0).Cells("linea").Value = "35B"
        DataGridView1.Rows(0).Cells("id_talla").Value = "0341"
        DataGridView1.Rows(0).Cells("fecha").Value = "17-02-2025 10:35:00"
        DataGridView1.Rows(0).Cells("id_rfid").Value = "3BD000002550130EBC5AC930"


        ' Permitir edición en el DataGridView
        Me.DataGridView1.ReadOnly = False
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect ' Permite editar celdas individualmente

        ' Asegurar que todas las columnas sean de solo lectura excepto "hoja_marcacion"
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.ReadOnly = (column.Name <> "hoja_marcacion")
        Next

        Me.KeyPreview = True
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

                Dim updateParameters As New Dictionary(Of String, Object) From {
                    {"codQR", idRfid},
                    {"usregsalemb", mCodTrabajador}
                }

                ' Llamar al método UpdateOrdenAcabadoTallasMov con los parámetros y el ID RFID
                Dim lsResult = m_BDPrenda.UPDAcabadosTallaMov(whereParameters, updateParameters)
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
            Using confirmForm As New FormConfirmacion("¿Deseas editar el RFID?", Color.FromArgb(255, 165, 0), "¿Desea continuar con la edición?")
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

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ' Verificar que el clic sea con el botón izquierdo y en una celda válida
        If e.Button = MouseButtons.Left AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Verificar si la columna es "hoja_marcacion"
            If DataGridView1.Columns(e.ColumnIndex).Name = "hoja_marcacion" Then
                DataGridView1.BeginEdit(True) ' Habilitar edición
                Console.WriteLine($"Editara HM")
            Else
                DataGridView1.EndEdit() ' Evitar edición en otras columnas
                Console.WriteLine($"NO editar")
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "hoja_marcacion" Then
            Dim nuevaHojaMarcacion As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            ' Verificar que el valor sea numérico antes de formatearlo
            If IsNumeric(nuevaHojaMarcacion) Then
                ' Completar con ceros a la izquierda hasta tres dígitos
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = nuevaHojaMarcacion.PadLeft(3, "0"c)

            Else
                ' En caso de que el usuario ingrese un valor no numérico, mostrar alerta
                MessageBox.Show("Ingrese solo valores numéricos en Hoja Marcación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Restaurar el valor anterior si es inválido
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "000"
            End If

            Console.WriteLine($"Valor actualizado en hoja_marcacion: {DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value}")
        End If
    End Sub


    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        ' Solo permitir la entrada si es la columna "hoja_marcacion"
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("hoja_marcacion").Index Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
        End If
    End Sub

    ' Validar que solo se ingresen valores específicos en "hoja_marcacion"    
    Private Sub ValidarEntradaHojaMarcacion(sender As Object, e As KeyPressEventArgs)
        ' Permitir solo números y borrar con Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True ' Bloquea la entrada
        End If
    End Sub

    Private Sub PruebaConfiguracion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1 ' Tecla F1 para "Nuevo Timbrado"
                'btnClear.PerformClick()
                Console.WriteLine($"Tecla F1 para Nuevo Timbrado")

            Case Keys.F2 ' Tecla F2 para "Limpiar"
                'btnLimpiarRFID.PerformClick()
                Console.WriteLine($"Tecla F2 para Nuevo Timbrado")

        End Select
    End Sub
End Class