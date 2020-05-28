Imports System
Imports System.IO
Imports System.Collections
Module ModUser
    ':::Ruta donde crearemos nuestro archivo txt
    Private ruta As String = "..\User\"
    ':::Nombre del archivo
    Private archivo As String = "User.txt"
    Private Barchivo As String = "Origin.txt"
    Private karchivo As String = "Key.txt"
    'Establece la key y una verificacion
    Public Sub Inicio()
        If Not Directory.Exists(ruta) Then
            Directory.CreateDirectory(ruta)
        End If
        Dim leer As New StreamReader(ruta & karchivo)
        If File.Exists(ruta & karchivo) Then
            ModCodificador.EKey(leer.ReadLine())
            ModCodificador.EKeyMaestra(leer.ReadLine())
        Else
            If File.Exists(ruta & archivo) Then
                File.Delete(ruta & archivo)
            End If
            If File.Exists(ruta & Barchivo) Then
                File.Delete(ruta & Barchivo)
            End If
            File.Create(ruta & karchivo)
            Dim escribir As New StreamWriter(ruta & karchivo, False)
            escribir.WriteLine(ModCodificador.GKey())
            escribir.WriteLine(ModCodificador.GKeyMaestra())
            escribir.Close()
        End If
        leer.Close()
        Verify()
        ModCodificador.Actualizar()
        LeeDatos()
    End Sub
    Public Sub Verify()
        If Not File.Exists(ruta & archivo) Then
            If Not File.Exists(ruta & Barchivo) Then
                File.Create(ruta & Barchivo)
            Else
                    File.Copy(ruta & Barchivo, ruta & archivo)
            End If
        End If
    End Sub
    Public Sub Borrar()
        If File.Exists(ruta & archivo) Then
            File.Delete(ruta & archivo)
        End If
    End Sub
    Public Sub LeeDatos()
        If File.Exists(ruta & archivo) Then
            Dim leer As New StreamReader(ruta & archivo)
            Dim Datos(4) As String
            Dim n As Byte = 0
            While leer.Peek <> -1
                'Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                'Agregramos los datos
                Datos(n) = ModCodificador.Desencriptar(linea)
                n += 1
            End While
            ModConector.Crear(Datos(0), Datos(1), Datos(2), Datos(3), Datos(4))
            leer.Close()
        End If

    End Sub
    Public Sub Guardar(ByVal Desarrollo As Boolean)
        Dim archivos As String
        If Desarrollo Then
            archivos = Barchivo

        Else
            archivos = archivo
        End If
        Dim escribir As New StreamWriter(ruta & Archivos, False)
        escribir.WriteLine(ModCodificador.Encriptar(ModConector.GAdress()))
        escribir.WriteLine(ModCodificador.Encriptar(ModConector.GPort()))
        escribir.WriteLine(ModCodificador.Encriptar(ModConector.GDatabase()))
        escribir.WriteLine(ModCodificador.Encriptar(ModConector.GUser()))
        escribir.WriteLine(ModCodificador.Encriptar(ModConector.GPass()))
        escribir.Close()

    End Sub
End Module
