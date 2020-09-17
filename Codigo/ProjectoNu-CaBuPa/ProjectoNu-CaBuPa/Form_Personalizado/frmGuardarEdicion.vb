Imports System.ComponentModel

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
        ModInicializador.Cancelar = True
        Close()

    End Sub

    Private Sub btnNoGuardar_Click(sender As Object, e As EventArgs) Handles btnNoGuardar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        PrepararUpdate(tabla, datos, id)
        Close()
    End Sub

    Private Sub frmGuardarEdicion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ModInicializador.Cancelar = False
    End Sub
End Class