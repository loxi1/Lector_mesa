Imports System.IO
Imports Svg
Public Class UtilidadesSVG
    ''' <summary>
    ''' Obtiene la ruta del archivo SVG dentro de la carpeta "Ini".
    ''' </summary>
    ''' <param name="fileName">Nombre del archivo SVG.</param>
    ''' <returns>Ruta completa del archivo SVG.</returns>
    Public Function ObtenerRutaSVG(fileName As String) As String
        Try
            ' Obtener la ruta base de la aplicación
            Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

            ' Subir dos niveles para llegar a la carpeta "bin"
            Dim binDirectory As String = Directory.GetParent(Directory.GetParent(baseDirectory).FullName).FullName

            ' Construir la ruta de la carpeta "Ini"
            Dim iniDirectory As String = Path.Combine(binDirectory, "Ini")

            ' Construir la ruta completa del archivo SVG
            Dim svgFilePath As String = Path.Combine(iniDirectory, fileName)

            ' Verificar si el archivo existe
            If File.Exists(svgFilePath) Then
                Return svgFilePath
            Else
                Debug.Print($"⚠️ Archivo SVG no encontrado: {svgFilePath}")
                Return String.Empty
            End If
        Catch ex As Exception
            Debug.Print($"❌ Error obteniendo la ruta SVG: {ex.Message}")
            Return String.Empty
        End Try
    End Function

    ''' <summary>
    ''' Carga un archivo SVG y lo convierte en un Bitmap para mostrarlo en un PictureBox.
    ''' </summary>
    ''' <param name="pictureBox">PictureBox donde se mostrará el SVG.</param>
    ''' <param name="svgFileName">Nombre del archivo SVG.</param>
    Public Sub CargarIconoSVG(pictureBox As PictureBox, svgFileName As String)
        If pictureBox Is Nothing Then
            Console.WriteLine("❌ El PictureBox es NULL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtener la ruta del archivo SVG
        Dim svgPath As String = ObtenerRutaSVG(svgFileName)

        ' Validar que el archivo existe
        If String.IsNullOrEmpty(svgPath) Then
            Console.WriteLine($"⚠️ Archivo SVG no encontrado: {svgPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Cargar el documento SVG
            Dim svgDocument As SvgDocument = SvgDocument.Open(svgPath)
            If svgDocument Is Nothing Then
                Console.WriteLine("⚠️ No se pudo cargar el SVG.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Renderizar el SVG como Bitmap
            Dim bitmap As Bitmap = svgDocument.Draw()

            ' Verificar que el bitmap es válido
            If bitmap Is Nothing Then
                Console.WriteLine("⚠️ Error al convertir SVG a Bitmap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Asignar la imagen al PictureBox
            pictureBox.Image = bitmap
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Refresh()
        Catch ex As Exception
            Console.WriteLine($"⚠️ Error al cargar el archivo SVG.{vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
