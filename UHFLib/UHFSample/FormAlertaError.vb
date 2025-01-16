Public Class FormAlertaError
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(Titulo As String, Detalle As String, PColor As Color)
        InitializeComponent()
        icon_error.ForeColor = PColor
        FranjaAbajo.BackColor = PColor
        TituloAviso.Text = Titulo
        DescripcionAviso.Text = Detalle
        ' Asignar tiempo personalizado
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.Close()
    End Sub
End Class