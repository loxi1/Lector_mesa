Imports System.Drawing
Imports System.Threading.Tasks

Public Class FormAlerta
    Private conteo As Integer
    Private tiempo_ As Integer = 30 ' Tiempo en segundos
    Private desplazamiento As Integer = 10 ' Velocidad de desplazamiento en píxeles
    Private destinoY As Integer ' Coordenada final del formulario en Y

    ' Constructor para recibir mensaje y color
    Public Sub New(mensaje As String, color As Color, tipo As Integer, Optional tiempo As Integer = 30)
        InitializeComponent()
        MSNAlerta.Text = mensaje
        MSNAlerta.ForeColor = color
        FranjaTop.BackColor = color
        Me.BackColor = ColorTranslator.FromHtml("#fff3cd")

        ' Asegurar que la alerta siempre esté en primer plano
        Me.TopMost = True
        Me.BringToFront()


        ' Ocultar todos los iconos y mostrar el correcto
        icon_error.Visible = False
        icon_ok.Visible = False
        icon_info.Visible = False

        Select Case tipo
            Case 1 : icon_ok.Visible = True
            Case 2 : icon_info.Visible = True
            Case Else : icon_error.Visible = True
        End Select

        ' Asignar tiempo personalizado
        tiempo_ = tiempo
    End Sub

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
