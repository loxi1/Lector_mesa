Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Imports System.Linq

Public Class DBConsultas
    ' Variables de configuración
    Private SECRET_KEY As String
    Private SECRET_IV As String
    Private METHOD As String

    ' Variables para clave y vector de inicialización
    Private key As Byte()
    Private iv As Byte()

    ' Constructor que carga los valores desde un archivo JSON
    Public Sub New()
        Dim filePath As String = "tsconfig.json"
        ' Obtener el directorio base de ejecución
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Console.WriteLine($"baseDirectory-->{baseDirectory}")
        ' Subir dos niveles para llegar a "bin"
        Dim binDirectory As String = Directory.GetParent(Directory.GetParent(baseDirectory).FullName).FullName
        Console.WriteLine($"binDirectory-->{binDirectory}")
        ' Construir la ruta del archivo tsconfig.json
        Dim iniDirectory As String = Path.Combine(binDirectory, "Ini")
        Console.WriteLine($"iniDirectory-->{iniDirectory}")
        Dim configPath As String = Path.Combine(iniDirectory, filePath)
        Console.WriteLine($"configPath-->{configPath}")

        ' Leer y procesar el archivo JSON
        If File.Exists(configPath) Then
            Dim jsonContent As String = File.ReadAllText(configPath)
            Dim config = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonContent)

            ' Extraer los valores de configuración
            SECRET_KEY = config("SECRET_KEY")
            SECRET_IV = config("SECRET_IV")
            METHOD = config("METHOD")

            ' Convertir SECRET_KEY y SECRET_IV a hash de 256 bits y 128 bits respectivamente
            key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(SECRET_KEY))
            iv = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(SECRET_IV)).Take(16).ToArray()
        Else
            Throw New FileNotFoundException($"baseDirectory->{baseDirectory} binDirectory->{binDirectory} iniDirectory->{iniDirectory} baseDirectory->{baseDirectory} configPath->{configPath} ")
            'Throw New FileNotFoundException($"El archivo de configuración '{filePath}' no existe.")
        End If
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
