Public Class FormAlertaError
    Public Shared alertaAbierta As Boolean = False ' 🔥 Variable de control
    Private callback As Action
    Public Sub New(Titulo As String, Detalle As String, PColor As Color, Optional callback As Action = Nothing)
        InitializeComponent()
        Me.callback = callback ' Guardar la función de retorno

        icon_error.ForeColor = PColor
        FranjaAbajo.BackColor = PColor
        TituloAviso.Text = Titulo
        DescripcionAviso.Text = Detalle
    End Sub

    Private Sub FormAlertaError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verificar si ya hay una alerta en pantalla
        If alertaAbierta Then
            Me.Close()
            Return
        End If
        alertaAbierta = True ' Marcamos que hay una alerta activa

        ' Centrar la ventana en la pantalla
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(
            (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2,
            (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
        )
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        CerrarAlerta()
    End Sub

    ' Método para cerrar la alerta con animación y liberar la variable de control
    Private Sub CerrarAlerta()
        alertaAbierta = False ' 🔥 Asegurar que la variable se restablece
        Me.Close()
        If callback IsNot Nothing Then
            callback.Invoke()
        End If
    End Sub

    ' Asegurar que la variable de control se libere si la alerta se cierra de otra forma
    Private Sub FormAlertaError_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        alertaAbierta = False
    End Sub
End Class
