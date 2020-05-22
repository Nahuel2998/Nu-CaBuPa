Public Class Form1
    Dim R As New Random
    Dim myArray = {"NNN", "NNN", "NNN"}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Dibujo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dibujo.TextChanged
        For i = 0 To 2

            myArray(i) = (R.Next(0, 2)).ToString
            myArray(i) += (R.Next(0, 2)).ToString
            myArray(i) += R.Next(0, 2).ToString
        Next
        Dibujo.Lines = myArray
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dibujo_Click(sender, e)
    End Sub

End Class
