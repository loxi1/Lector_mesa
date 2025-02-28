Public Class FormAlertaMsnError
    Public Sub New(Titulo As String, Detalle As String, PColor As Color)
        InitializeComponent()

        icon_error.ForeColor = PColor
        FranjaAbajo.BackColor = PColor
        TituloAviso.Text = Titulo
        DescripcionAviso.Text = Detalle
    End Sub

    Private Sub FormAlertaMsnError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Usar UtilidadesSVG para cargar el icono SVG
        Dim utilSVG As New UtilidadesSVG()
        Dim svgPath As String = utilSVG.ObtenerRutaSVG("icono_error_512.svg")
        utilSVG.CargarIconoSVG(icon_error, svgPath)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.Close()
    End Sub
End Class