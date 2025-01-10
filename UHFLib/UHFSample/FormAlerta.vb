Public Class FormAlerta
    Private conteo As Integer
    Private tiempo_ As Integer = 30  ' Valor por defecto de 30 segundos

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
        tiempo.Start()
    End Sub

    Private Sub FormAlerta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tiempo.Enabled = False ' Detener el tiempo
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        conteo += 1
        If conteo = tiempo_ Then
            Me.Close()
        End If
    End Sub
End Class