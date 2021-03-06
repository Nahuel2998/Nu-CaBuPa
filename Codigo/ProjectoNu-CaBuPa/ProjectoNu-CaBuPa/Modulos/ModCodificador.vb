﻿Imports System.Text
Imports System.Security.Cryptography
'Se utiliza para encriptar y desencriptar datos de tipo string
'Usa una key y un vector de incializacion, que llamaremos key maestra
'Por mas información de esta ultima se puede buscar en:
'https://es.wikipedia.org/wiki/Vector_de_inicializaci%C3%B3n
Module ModCodificador
    Private KeyMaestra As String = "rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5"
    Private Key As String = "12345678"
    Private IV() As Byte
    Private EncryptionKey() As Byte
    Private buffer() As Byte
    Private des As TripleDESCryptoServiceProvider
    Public Sub EKey(ByVal NKey As String)
        If Not String.IsNullOrEmpty(NKey) Then
            Key = NKey
        End If
    End Sub
    Public Sub Actualizar()
        IV = ASCIIEncoding.ASCII.GetBytes(Key) 'La clave debe ser de 8 caracteres
        EncryptionKey = Convert.FromBase64String(KeyMaestra) 'No se puede alterar la cantidad de caracteres pero si la clave
        des = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
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
        'convierte el texto a bytes utilizando el formato utf8
        buffer = Encoding.UTF8.GetBytes(Texto)
        'Crea un objeto de encriptacion, luego crea un valor hash con el buffer y utiliza todo su largo, comenzando en el byte 0
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function
    Public Function Desencriptar(ByVal Texto As String) As String
        'convierte el texto encriptado a bytes
        buffer = Convert.FromBase64String(Texto)
        'desencripta el texto(ahora en array de bytes) y utiliza el formato utf8
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function
End Module
