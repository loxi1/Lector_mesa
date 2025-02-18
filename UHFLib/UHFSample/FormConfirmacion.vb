Imports System.Drawing.Drawing2D
Imports System.IO

Public Class FormConfirmacion
    ' Constructor con parámetros PictureBox y ruta SVG
    Public Sub New(pictureBox As PictureBox, svgPath As String)
        InitializeComponent()
    End Sub
    Private Sub FormConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim utilSVG As New UtilidadesSVG()
        Dim svgPath As String = utilSVG.ObtenerRutaSVG("icono_exclamation_512.svg")

        If Not String.IsNullOrEmpty(svgPath) Then
            utilSVG.CargarIconoSVG(Me.pictureBox1, svgPath)
        Else
            Debug.Print("⚠️ No se pudo encontrar la imagen SVG.")
        End If
    End Sub

    Public Sub New(titulo As String, PColor As Color, mensaje As String, Optional m_aceptar As String = "Sí, Editar", Optional m_cancelar As String = "No, Cancelar")
        InitializeComponent()

        ' Aplicar estilos
        EstiloBoton(btnAceptar, "#3085d6", "#FFFFFF", "#2b77c0")
        EstiloBoton(btnCancelar, "#dd3333", "#FFFFFF", "#c72e2e")
        TituloAviso.Text = titulo
        DescripcionAviso.Text = mensaje
        btnAceptar.Text = m_aceptar
        btnCancelar.Text = m_cancelar

        AplicarEstilos()
    End Sub

    ' Método para aplicar estilos
    Private Sub AplicarEstilos()
        ' 🔹 Aplicar degradado al fondo
        AddHandler Me.Paint, Sub(sender, e)
                                 Using brush As New LinearGradientBrush(Me.ClientRectangle, Color.White, Color.FromArgb(230, 230, 230), LinearGradientMode.Vertical)
                                     e.Graphics.FillRectangle(brush, Me.ClientRectangle)
                                 End Using
                             End Sub

        ' 🔹 Aplicar estilos a los botones
        EstiloBoton(btnAceptar, "#3085d6", "#FFFFFF", "#1f6ac1")
        EstiloBoton(btnCancelar, "#dd3333", "#FFFFFF", "#b52b2b")

        ' 🔹 Aplicar estilos a los textos
        TituloAviso.ForeColor = Color.Black
        DescripcionAviso.ForeColor = Color.FromArgb(100, 100, 100)

        ' 🔹 Bordes redondeados
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.White
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
    End Sub

    ' Método para dar estilo a los botones
    Private Sub EstiloBoton(btn As Button, colorFondo As String, colorTexto As String, colorHover As String)
        btn.BackColor = ColorTranslator.FromHtml(colorFondo)
        btn.ForeColor = ColorTranslator.FromHtml(colorTexto)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(colorHover)
        btn.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        btn.Cursor = Cursors.Hand
    End Sub

    ' 🔹 Método para crear bordes redondeados
    <System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(left As Integer, top As Integer, [right] As Integer, bottom As Integer, width As Integer, height As Integer) As IntPtr
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class