Imports System.Text
Imports System.Security.Cryptography
Module ModCodificador
    Private KeyMaestra As String = "rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5"
    Private Key As String = "12345678"
    Public Sub EKey(ByVal NKey As String)
        If Not String.IsNullOrEmpty(NKey) Then
            Key = NKey
        End If
    End Sub
    Public Sub EKeyMaestra(ByVal NKeyMaestra As String)
        If Not String.IsNullOrEmpty(NKeyMaestra) Then
            KeyMaestra = NKeyMaestra
        End If
    End Sub
    Public Function GKey() As String
        Return Key
    End Function
    Public Function GKeyMaestra() As String
        Return KeyMaestra
    End Function
    Public Function Encriptar(ByVal Texto As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes(Key) 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String(KeyMaestra) 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Texto)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function
    Public Function Desencriptar(ByVal Texto As String) As String
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes(Key) 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String(KeyMaestra) 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Texto)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function
End Module
