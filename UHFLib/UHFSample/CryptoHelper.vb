Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json

Public Class CryptoHelper
    ' Propiedades y variables
    Private ReadOnly _key As Byte()
    Private ReadOnly _iv As Byte()
    Private SECRET_KEY As String
    Private SECRET_IV As String
    Private ss_error As String

    Public Sub New()
        If GetIniSecret() = 1 Then
            Try
                _key = Create_Key(SECRET_KEY)
                _iv = Create_IV(SECRET_IV)
                Debug.Print($"_key->{BitConverter.ToString(_key)} _iv->{BitConverter.ToString(_iv)}")
            Catch ex As Exception
                Debug.Print("Error al generar claves: " & ex.Message)
            End Try
        Else
            Throw New Exception("No se pudo cargar la configuración de encriptación.")
        End If
    End Sub

    Private Function Create_Key(secretKey As String) As Byte()
        Return Encoding.UTF8.GetBytes(secretKey.PadRight(32).Substring(0, 32))
    End Function

    Private Function Create_IV(secretIV As String) As Byte()
        Return Encoding.UTF8.GetBytes(secretIV.PadRight(16).Substring(0, 16))
    End Function

    Private Function GetIniSecret() As Integer
        Try
            Dim json As String = File.ReadAllText("tsconfig.json")
            Dim config = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
            SECRET_KEY = config("SECRET_KEY")
            SECRET_IV = config("SECRET_IV")
            Return 1
        Catch ex As Exception
            ss_error = $"Error al cargar configuración: {ex.Message}"
            Return 0
        End Try
    End Function

    Public Function Encriptar(texto As String) As String
        If _key.Length <> 32 OrElse _iv.Length <> 16 Then
            Throw New Exception("Tamaño de clave o IV incorrecto.")
        End If

        Using aes As Aes = Aes.Create()
            aes.Key = _key
            aes.IV = _iv
            aes.Mode = CipherMode.CBC
            aes.Padding = PaddingMode.PKCS7

            Dim encryptor = aes.CreateEncryptor(aes.Key, aes.IV)
            Dim inputBytes = Encoding.UTF8.GetBytes(texto)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                    cs.Write(inputBytes, 0, inputBytes.Length)
                    cs.FlushFinalBlock()
                End Using
                Return Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
    End Function

    Public Function Desencriptar(encryptedText As String) As String
        Using aes As Aes = Aes.Create()
            aes.Key = _key
            aes.IV = _iv
            aes.Mode = CipherMode.CBC
            aes.Padding = PaddingMode.PKCS7

            Dim decryptor = aes.CreateDecryptor(aes.Key, aes.IV)
            Dim inputBytes = Convert.FromBase64String(encryptedText)

            Using ms As New MemoryStream(inputBytes)
                Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                    Using sr As New StreamReader(cs)
                        Return sr.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
    End Function
End Class
