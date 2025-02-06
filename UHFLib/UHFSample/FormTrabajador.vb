Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Public Class FormTrabajador
    Inherits Form
    Public Property CodTrabajador As String
    Public Property Usuario As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Try
            ' Validar campos
            If String.IsNullOrWhiteSpace(txtCodTrabajador.Text) OrElse String.IsNullOrWhiteSpace(ClaveTrabajador.Text) Then
                AlertaError("Por favor, Complete todos los campos.", Color.Red)
                Exit Sub
            End If

            'Dim helper As New CryptoHelper()
            Dim lsCodTrabajador As String = txtCodTrabajador.Text.Trim()
            Dim lsPassword As String = ClaveTrabajador.Text.Trim()

            Dim helper As New DBConsultas()
            Dim textoEncriptado As String = helper.Encrypt(lsPassword)

            Debug.Print($"lsPassword->{lsPassword} clave->{textoEncriptado}")
            Dim usuario As New SybaseHelper()
            Dim whereParameters As New Dictionary(Of String, Object) From {{"codigo", lsCodTrabajador}, {"clave", textoEncriptado}}
            Dim ldtTrabajador As DataTable = usuario.ValidateUser(whereParameters)

            If ldtTrabajador Is Nothing OrElse ldtTrabajador.Rows.Count = 0 Then
                AlertaError("Código o password incorrecto, Verificar.", Color.Red)
                Exit Sub
            End If

            Dim row As DataRow = ldtTrabajador.Rows(0)

            ' Asignar valores al usuario y código del trabajador
            Me.Usuario = row("datos").ToString()
            Me.CodTrabajador = lsCodTrabajador

            ' Cerrar el formulario con éxito
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            AlertaError("Ocurrió un error al validar el trabajador: ", Color.Red)
        End Try
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        txtCodTrabajador.Text = ""
        ClaveTrabajador.Text = ""
    End Sub

    Private Sub txtCodTrabajador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodTrabajador.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ClaveTrabajador.Focus()
        End If
    End Sub

    Private Sub FormTrabajador_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtCodTrabajador.Focus()
    End Sub

    ' === Métodos Auxiliares ===

    Private Function ValidarEntradas() As Boolean
        Return Not String.IsNullOrWhiteSpace(txtCodTrabajador.Text) AndAlso
               Not String.IsNullOrWhiteSpace(ClaveTrabajador.Text)
    End Function

    Private Sub LimpiarEntradas()
        txtCodTrabajador.Text = ""
        ClaveTrabajador.Text = ""
        txtCodTrabajador.Focus()
    End Sub

    Private Sub ClaveTrabajador_KeyDown(sender As Object, e As KeyEventArgs) Handles ClaveTrabajador.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ButtonOk.Focus()
        End If
    End Sub

    Private Sub AlertaError(mensaje As String, color_ As Color)
        Using alerta As New FormAlertaError("Upss...", mensaje, color_)
            alerta.ShowDialog()
        End Using
    End Sub
    Private Sub EstiloBoton(btnViste As Button, Optional bkcolor As String = "#28A745", Optional txtcolor As String = "#FFFFFF", Optional bkcolorHover As String = "#218838")
        ' Configuración mejorada para el botón btnClear
        With btnViste
            .Anchor = System.Windows.Forms.AnchorStyles.Left
            .BackColor = ColorTranslator.FromHtml(bkcolor)
            .ForeColor = ColorTranslator.FromHtml(txtcolor)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 1 ' Sin borde
            .FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(bkcolorHover) ' Cambio de color al pasar el mouse
            .Font = New Font("Arial", 12, FontStyle.Bold) ' Fuente más grande y negrita
            .Size = New Size(150, 40) ' Aumentar el tamaño del botón
            .TextAlign = ContentAlignment.MiddleCenter
            .Cursor = Cursors.Hand ' Cambiar el cursor a mano al pasar por encima
        End With
    End Sub

    Private Sub FormTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloBoton(ButtonOk)
        EstiloBoton(buttonCancelar, "#E0E0E0", "#000000", "#BDBDBD")
    End Sub

    Private Sub ButtonCancelar_MouseLeave(sender As Object, e As EventArgs) Handles buttonCancelar.MouseLeave
        buttonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(115, Byte), Integer))
    End Sub

    Private Sub ButtonOk_MouseLeave(sender As Object, e As EventArgs) Handles ButtonOk.MouseLeave
        ButtonOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(115, Byte), Integer))
    End Sub
End Class