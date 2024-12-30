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
                MessageBox.Show("Por favor, complete todos los campos.", "Error")
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
                MessageBox.Show("Código o password incorrecto, por favor verificar.", "Error")
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
            MessageBox.Show("Ocurrió un error al validar el trabajador: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
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
End Class