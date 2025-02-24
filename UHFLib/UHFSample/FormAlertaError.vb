Public Class FormAlertaError
    Private callback As Action ' Variable para almacenar la función de retorno

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Nuevo constructor que recibe una función opcional como parámetro
    Public Sub New(Titulo As String, Detalle As String, PColor As Color, Optional callback As Action = Nothing)
        InitializeComponent()
        Me.callback = callback ' Guardar la función de retorno

        icon_error.ForeColor = PColor
        FranjaAbajo.BackColor = PColor
        TituloAviso.Text = Titulo
        DescripcionAviso.Text = Detalle
    End Sub

    Private Sub FormAlertaError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Usar UtilidadesSVG para cargar el icono SVG
        Dim utilSVG As New UtilidadesSVG()
        Dim svgPath As String = utilSVG.ObtenerRutaSVG("icono_error_512.svg")
        utilSVG.CargarIconoSVG(icon_error, svgPath)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.Close()
        ' Ejecutar la función de retorno si existe
        If callback IsNot Nothing Then
            callback.Invoke()
        End If
    End Sub
End Class
