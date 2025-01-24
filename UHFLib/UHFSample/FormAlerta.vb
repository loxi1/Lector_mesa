Imports System.Drawing

Public Class FormAlerta
    Private conteo As Integer
    Private tiempo_ As Integer = 30  ' Tiempo en segundos
    Private desplazamiento As Integer = 100 ' Velocidad de desplazamiento en píxeles
    Private destinoY As Integer ' Coordenada final del formulario en Y

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(PMensaje As String, PColor As Color, tipo As Integer, Optional tiempo As Integer = 30)
        InitializeComponent()
        MSNAlerta.Text = PMensaje
        MSNAlerta.ForeColor = PColor
        FranjaTop.BackColor = PColor
        icon_error.Visible = False
        icon_ok.Visible = False
        icon_info.Visible = False

        Me.BackColor = ColorTranslator.FromHtml("#fff3cd")

        ' Asignar tiempo personalizado
        tiempo_ = tiempo

        If tipo = 1 Then ' Tipo Ok
            icon_ok.Visible = True
        ElseIf tipo = 2 Then ' Tipo Info
            icon_info.Visible = True
        Else
            icon_error.Visible = True
        End If
    End Sub

    Private Sub FormAlerta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Posicionar fuera de la pantalla (abajo)
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 50
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height
        destinoY = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 100

        ' Iniciar la animación
        tiempo.Start()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        ' Animación para desplazar el formulario hacia arriba
        If Me.Top > destinoY Then
            Me.Top -= desplazamiento
        Else
            conteo += 1

            ' Si el tiempo ha expirado, cerrar
            If conteo = tiempo_ Then
                Me.Close()
            End If
        End If
    End Sub
End Class
