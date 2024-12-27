Public Class FormInicio
    Dim miFormulario As FormInicio = Me
    Public Sub New()
        InitializeComponent() ' Inicializa los controles del formulario.
    End Sub

    Private Sub FormInicio_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        If functionCallStatusLabel IsNot Nothing Then
            functionCallStatusLabel.Width = Me.Width - 85
        End If

        If MainMenuStrip IsNot Nothing Then
            MainMenuStrip.Size = New System.Drawing.Size(Me.Width, 50)
        End If
    End Sub

    Private Sub FormInicio_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If MainMenuStrip IsNot Nothing Then
            MainMenuStrip.Size = New System.Drawing.Size(Me.Width, 50)
        End If
    End Sub

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Main()
        Try
            Application.Run(New FormInicio())
        Catch ex As Exception
            MessageBox.Show($"Error al ejecutar la aplicación: {ex.Message}{Environment.NewLine}InnerException: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class