Public Class frmGuardarEdicion
    Dim tabla As String
    Dim datos() As String
    Dim frm As Form
    Dim id As String

    Public Sub New(ByVal t As String, ByVal d() As String, ByVal identificador As String, ByRef f As Form)
        InitializeComponent()

        tabla = t
        datos = d
        id = identificador
        frm = f

        Beep()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnNoGuardar_Click(sender As Object, e As EventArgs) Handles btnNoGuardar.Click
        frm.Dispose()
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        PrepararUpdate(tabla, datos, id)
        frm.Dispose()
        Close()
    End Sub
End Class