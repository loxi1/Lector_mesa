Imports System.Security.Cryptography
Imports System.Text

Public Class CryptoHelper
    ' Variables de configuración
    Private SECRET_KEY As String
    Private SECRET_IV As String
    Private METHOD As String

    ' Variables para clave y vector de inicialización
    Private key As Byte()
    Private iv As Byte()

    ' Constructor que recibe el JSON de configuración (simulado como un diccionario simple)
    Public Sub New(jsonContent As String)
        ' Simulación de un "JSON" básico sin usar Newtonsoft.Json
        ' Parseamos la cadena manualmente
        Dim parts As String() = jsonContent.Split(","c)
        For Each part In parts
            If part.Contains("SECRET_KEY") Then
                SECRET_KEY = part.Split(":"c)(1).Trim().Trim(""""c)
            ElseIf part.Contains("SECRET_IV") Then
                SECRET_IV = part.Split(":"c)(1).Trim().Trim(""""c)
            ElseIf part.Contains("METHOD") Then
                METHOD = part.Split(":"c)(1).Trim().Trim(""""c)
            End If
        Next

        ' Convertir SECRET_KEY y SECRET_IV a hash de 256 bits y 128 bits respectivamente
        key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(SECRET_KEY))
        iv = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(SECRET_IV)).Take(16).ToArray()
    End Sub

    ' Función para cifrar un texto
    Public Function Encrypt(stringToEncrypt As String) As String
        Using aes As Aes = Aes.Create()
            aes.Key = key
            aes.IV = iv
            aes.Mode = CipherMode.CBC

            Using encryptor As ICryptoTransform = aes.CreateEncryptor()
                Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(stringToEncrypt)
                Dim cipherTextBytes As Byte() = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length)
                Return Convert.ToBase64String(cipherTextBytes)
            End Using
        End Using
    End Function

    ' Función para descifrar un texto
    Public Function Decrypt(stringToDecrypt As String) As String
        Using aes As Aes = Aes.Create()
            aes.Key = key
            aes.IV = iv
            aes.Mode = CipherMode.CBC

            Using decryptor As ICryptoTransform = aes.CreateDecryptor()
                Dim cipherTextBytes As Byte() = Convert.FromBase64String(stringToDecrypt)
                Dim plainTextBytes As Byte() = decryptor.TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length)
                Return Encoding.UTF8.GetString(plainTextBytes)
            End Using
        End Using
    End Function
End Class

Public Module Program
    ' La clave estática a encriptar
    Private _clave As String = "xhEaYalLB4gWqzdUtgwhkQ=="

    Public Sub Main(args() As String)
        ' JSON de configuración con comillas dobles correctamente escapadas (simulación)
        Dim jsonContent As String = "{
            ""SECRET_KEY"": ""$BP@2017"",
            ""SECRET_IV"": ""101712"",
            ""METHOD"": ""AES-256-CBC""
        }"

        ' Crear una instancia de la clase CryptoHelper con el JSON
        Dim crypto As New CryptoHelper(jsonContent)

        ' Encriptar y luego desencriptar la clave
        Dim encri As String = crypto.Encrypt(_clave)
        Dim decry As String = crypto.Decrypt(_clave)

        ' Mostrar resultados
        Console.WriteLine("Encriptar--> " & encri)
        Console.WriteLine("Desencriptar--> " & decry)
    End Sub
End Module
