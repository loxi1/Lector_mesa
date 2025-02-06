Public Class AlertaManager
    Private Shared alertasActivas As New List(Of FormAlerta)()
    Private Shared ReadOnly alertasLock As New Object() ' Bloqueo para evitar concurrencia

    ' Muestra una nueva alerta sin bloquear la UI
    Public Shared Sub MostrarAlerta(mensaje As String, color As Color, Optional tipo As Integer = 3, Optional tiempo As Integer = 5)
        Dim nuevaAlerta As New FormAlerta(mensaje, color, tipo, tiempo)

        ' Calcular posición
        nuevaAlerta.StartPosition = FormStartPosition.Manual
        nuevaAlerta.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - nuevaAlerta.Width - 50, ObtenerPosicion())

        ' Agregar a la lista y mostrar
        alertasActivas.Add(nuevaAlerta)
        nuevaAlerta.Show()
    End Sub

    ' Calcula la próxima posición en la pantalla
    Public Shared Function ObtenerPosicion() As Integer
        Dim pantallaAlto As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim alertaAlto As Integer = 70
        Dim margen As Integer = 10

        ' Calcular la posición Y de la nueva alerta
        Return pantallaAlto - ((alertaAlto + margen) * (alertasActivas.Count + 1))
    End Function

    ' Remueve la alerta de la lista y reorganiza las restantes
    Public Shared Sub RemoverAlerta(alerta As FormAlerta)
        alertasActivas.Remove(alerta)
        ReorganizarAlertas()
    End Sub

    ' Reorganiza las posiciones de las alertas activas
    Private Shared Sub ReorganizarAlertas()
        Dim alertaAlto As Integer = 70
        Dim margen As Integer = 10
        Dim pantallaAlto As Integer = Screen.PrimaryScreen.WorkingArea.Height

        For i As Integer = 0 To alertasActivas.Count - 1
            alertasActivas(i).Location = New Point(alertasActivas(i).Location.X, pantallaAlto - ((alertaAlto + margen) * (i + 1)))
        Next
    End Sub
End Class
