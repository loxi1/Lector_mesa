Imports System.Net.NetworkInformation

Public Class frmMain
    Private Tipo_de_red As Integer = 0
    Private WithEvents _MainForm As System.Windows.Forms.Form

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        '_MainForm = New PruebaConfiguracion()
        '_MainForm.Show()
        'With Me
        '    .Size = New Size(0, 0)
        '    .Hide()
        'End With
        ' Obtener tipo de conexión de red
        ObtenerTipoConexionRed()

        If Tipo_de_red = 2 Then
            ' Mostrar el formulario de login del trabajador
            Dim formResponse As New FormTrabajador()

            If formResponse.ShowDialog() <> DialogResult.OK Then
                ' Salir si el login no fue exitoso
                Me.Close()
                Exit Sub
            End If

            ' Obtener los datos del trabajador
            Dim mCodTrabajador As String = formResponse.CodTrabajador
            Dim dato_usuario As String = formResponse.Usuario

            ' Validar que los datos no estén vacíos
            If String.IsNullOrWhiteSpace(mCodTrabajador) OrElse String.IsNullOrWhiteSpace(dato_usuario) Then
                AlertaError("Por favor, complete todos los campos.", Color.FromArgb(238, 26, 36))
                Me.Close()
                Exit Sub
            End If

            AlertaOk($"¡Hola {dato_usuario}!", Color.FromArgb(16, 175, 76), 60)
            ' Abrir el formulario principal si el login es válido
            _MainForm = New frmLector(mCodTrabajador, dato_usuario)
            _MainForm.Show()
            With Me
                .Size = New Size(0, 0)
                .Hide()
            End With
        Else
            ' Mostrar alerta si la conexión no es por cable (Ethernet)
            Dim mensaje As String = If(Tipo_de_red = 1, "Está conectado por WiFi, debe usar una conexión por cable.", "No se detectó una conexión activa.")
            AlertaError(mensaje, Color.FromArgb(238, 26, 36))
            Me.Close()
        End If
    End Sub

    Private Sub _MainForm_Closed(sender As Object, e As EventArgs) Handles _MainForm.Closed
        Me.Dispose()
    End Sub

    Private Sub ObtenerTipoConexionRed()
        Try
            ' Obtener todas las interfaces de red
            Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

            For Each ni As NetworkInterface In interfaces
                ' Verificar si la interfaz está operativa
                If ni.OperationalStatus = OperationalStatus.Up Then
                    ' Verificar el tipo de interfaz
                    Select Case ni.NetworkInterfaceType
                        Case NetworkInterfaceType.Ethernet
                            Tipo_de_red = 2
                            Console.WriteLine($"Detener el bucle si se detecta Ethernet Tipo_de_red-->{Tipo_de_red}")
                            Exit For ' Detener el bucle si se detecta Ethernet
                        Case NetworkInterfaceType.Wireless80211
                            Tipo_de_red = 1
                            Console.WriteLine($"Detener el bucle si se detecta Wi-Fi Tipo_de_red-->{Tipo_de_red}")
                            Exit For ' Detener el bucle si se detecta Wi-Fi
                    End Select
                End If
            Next
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub AlertaError(mensaje As String, color_ As Color)
        Using alerta As New FormAlertaError("Upss...", mensaje, color_)
            alerta.ShowDialog()
        End Using
    End Sub

    Private Sub AlertaOk(mensaje As String, color_ As Color, Optional tiempo As Integer = 30)
        Using alerta As New FormAlertaOk(mensaje, color_, tiempo)
            alerta.ShowDialog()
        End Using
    End Sub
End Class