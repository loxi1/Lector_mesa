Public Class FormAlertaOk
    Private conteo As Integer
    Private tiempo_ As Integer = 30  ' Valor por defecto de 30 segundos

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(Titulo As String, PColor As Color, Optional tiempo As Integer = 30, Optional Detalle As String = "Qué bueno verte nuevamente.")
        InitializeComponent()
        TituloAviso.Text = Titulo
        icon_ok.ForeColor = PColor
        FranjaAbajo.BackColor = PColor
        DescripcionAviso.Text = Detalle
        ' Asignar tiempo personalizado
        tiempo_ = tiempo
    End Sub

    Private Sub FormAlertaOk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tiempo.Start()
        ' Usar UtilidadesSVG para cargar el icono SVG
        Dim utilSVG As New UtilidadesSVG()
        Dim svgPath As String = utilSVG.ObtenerRutaSVG("icono_checking_512.svg")

        If Not String.IsNullOrEmpty(svgPath) Then
            utilSVG.CargarIconoSVG(Me.icon_ok, svgPath)
        Else
            Debug.Print("⚠️ No se pudo encontrar la imagen SVG.")
        End If
    End Sub

    Private Sub FormAlertaOk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Tiempo.Enabled = False ' Detener el tiempo
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        conteo += 1
        If conteo = tiempo_ Then
            Me.Close()
        End If
    End Sub
End Class