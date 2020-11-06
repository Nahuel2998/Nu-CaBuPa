Imports System.IO

Module ModLog
    ':::Ruta donde crearemos nuestro archivo txt
    Private ruta As String = "..\User\"
    ':::Nombre del archivo
    Private archivo As String = "Log.txt"
    Private ENUSU As Boolean = True
    Public Sub Guardar(ByVal Acciones As String)
        If Not ENUSU Then
            ENUSU = True
            Dim escribir As New StreamWriter(ruta & archivo, True)
            escribir.WriteLine(Now.ToString + " " + My.Computer.Name + " ' " + Acciones + " ")
            escribir.Close()
            ENUSU = True
        End If
    End Sub
End Module
