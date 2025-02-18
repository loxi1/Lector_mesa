Imports System.Drawing
Imports System.IO
Imports System.Threading.Tasks

Public Class FormAlerta
    Private conteo As Integer
    Private tiempo_ As Integer = 30 ' Tiempo en segundos
    Private desplazamiento As Integer = 10 ' Velocidad de desplazamiento en píxeles
    Private destinoY As Integer ' Coordenada final del formulario en Y
    Private ReadOnly utilSVG As New UtilidadesSVG() ' Instancia de UtilidadesSVG

    ''' <summary>
    ''' Constructor que recibe un PictureBox y la ruta del archivo SVG.
    ''' </summary>
    ''' <param name="pictureBox">El PictureBox donde se mostrará el SVG.</param>
    ''' <param name="svgPath">La ruta del archivo SVG.</param>
    Public Sub New(pictureBox As PictureBox, svgPath As String)
        InitializeComponent()
        utilSVG.CargarIconoSVG(pictureBox, svgPath)
    End Sub

    ''' <summary>
    ''' Constructor que recibe un mensaje, color y tipo de alerta.
    ''' </summary>
    ''' <param name="mensaje">Mensaje de la alerta.</param>
    ''' <param name="color">Color de la alerta.</param>
    ''' <param name="tipo">Tipo de alerta (1=OK, 2=Info, otro=Error).</param>
    ''' <param name="tiempo">Tiempo de visualización (opcional).</param>
    Public Sub New(mensaje As String, color As Color, tipo As Integer, Optional tiempo As Integer = 30)
        InitializeComponent()
        MSNAlerta.Text = mensaje
        MSNAlerta.ForeColor = color
        FranjaTop.BackColor = color
        Me.BackColor = ColorTranslator.FromHtml("#fff3cd")

        ' Asegurar que la alerta siempre esté en primer plano
        Me.TopMost = True
        Me.BringToFront()

        ' Ocultar todos los iconos
        icon_error.Visible = False
        icon_ok.Visible = False
        icon_info.Visible = False

        ' Cargar el icono adecuado según el tipo de alerta
        CargarIcono(tipo)

        ' Asignar tiempo personalizado
        tiempo_ = tiempo
    End Sub

    ''' <summary>
    ''' Carga el icono correspondiente según el tipo de alerta.
    ''' </summary>
    ''' <param name="tipo">Tipo de alerta (1=OK, 2=Info, otro=Error).</param>
    Private Sub CargarIcono(tipo As Integer)
        Dim svgFileName As String

        Select Case tipo
            Case 1
                icon_ok.Visible = True
                svgFileName = "icono_check_512.svg"
            Case 2
                icon_info.Visible = True
                svgFileName = "icono_info_512.svg"
            Case Else
                icon_error.Visible = True
                svgFileName = "icono_error_512.svg"
        End Select

        ' Cargar el SVG en el PictureBox correspondiente
        Dim svgPath As String = utilSVG.ObtenerRutaSVG(svgFileName)
        utilSVG.CargarIconoSVG(If(tipo = 1, icon_ok, If(tipo = 2, icon_info, icon_error)), svgPath)
    End Sub

    ''' <summary>
    ''' Manejo de animación y cierre de la alerta.
    ''' </summary>
    Private Async Sub FormAlerta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Posicionar la alerta fuera de la pantalla (abajo)
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 50
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height

        ' Obtener la posición correcta
        destinoY = AlertaManager.ObtenerPosicion()

        ' Animación para desplazar la alerta hacia arriba
        While Me.Top > destinoY
            Me.Top -= desplazamiento
            Await Task.Delay(10) ' Delay para suavizar la animación
        End While

        ' Esperar el tiempo de visualización antes de cerrar
        Await Task.Delay(tiempo_ * 1000)

        ' Desvanecer y cerrar
        For i As Double = 1.0 To 0 Step -0.1
            Me.Opacity = i
            Await Task.Delay(50)
        Next

        ' Remover la alerta y reorganizar
        Me.Close()
        AlertaManager.RemoverAlerta(Me)
    End Sub
End Class
