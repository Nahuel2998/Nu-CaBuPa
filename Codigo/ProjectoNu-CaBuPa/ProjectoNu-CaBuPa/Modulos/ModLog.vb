Imports System.IO

Module ModLog
    ':::Ruta donde crearemos nuestro archivo txt
    Private ruta As String = "..\User\"
    ':::Nombre del archivo
    Private archivo As String = "Log.txt"
    Public Sub Guardar(ByVal Acciones As String)
        Dim escribir As New StreamWriter(ruta & archivo, True)
        escribir.WriteLine(Now.ToString + " " + Acciones)
        escribir.Close()

    End Sub
End Module
