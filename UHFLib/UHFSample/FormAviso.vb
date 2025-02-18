Public Class FormAviso
    Private conteo As Integer
    Private tiempo_ As Integer = 30  ' Valor por defecto de 30 segundos

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(PMensaje As String, PColor As Color, Optional tiempo As Integer = 30)
        InitializeComponent()
        DescripcionAviso.Text = PMensaje
        'DescripcionAviso.ForeColor = PColor
        FranjaAbajo.BackColor = PColor
        icon_error.Visible = False
        ' Usar UtilidadesSVG para cargar el icono SVG
        Dim utilSVG As New UtilidadesSVG()
        Dim svgPath As String = utilSVG.ObtenerRutaSVG("icono_error_512.svg")
        utilSVG.CargarIconoSVG(icon_error, svgPath)
        ' Asignar tiempo personalizado
        tiempo_ = tiempo
    End Sub

    Private Sub FormAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiempo.Start()
        ' Usar UtilidadesSVG para cargar el icono SVG
        Dim utilSVG As New UtilidadesSVG()
        Dim svgPath As String = utilSVG.ObtenerRutaSVG("icono_error_512")
        utilSVG.CargarIconoSVG(icon_error, svgPath)
    End Sub

    Private Sub FormAviso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tiempo.Enabled = False ' Detener el tiempo
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        conteo += 1
        If conteo = tiempo_ Then
            Me.Close()
        End If
    End Sub
End Class