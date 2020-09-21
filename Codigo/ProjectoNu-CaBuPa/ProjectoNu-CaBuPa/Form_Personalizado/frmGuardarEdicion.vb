Imports System.ComponentModel

Public Class frmGuardarEdicion
    Dim tabla As String
    Dim datos() As String
    Dim id As String

    Public Sub New(ByVal t As String, ByVal d() As String, ByVal identificador As String)
        InitializeComponent()

        tabla = t
        datos = d
        id = identificador
        Beep()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModInicializador.Cancelar += tabla
        Close()
    End Sub

    Private Sub btnNoGuardar_Click(sender As Object, e As EventArgs) Handles btnNoGuardar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        PrepararUpdate(tabla, datos, id)
        Close()
    End Sub

    Private Sub frmGuardarEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class