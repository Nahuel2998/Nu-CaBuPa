Imports System.ComponentModel
Imports System.Drawing.Text

Public Class Serie
    Dim serieID As Integer
    Dim editando As Boolean = False

    'Public Sub New(ByVal sid As Integer, ByVal nombre As String, ByVal fecha As Date)
    '   InitializeComponent()
    '
    'serieID = sid
    'txtNombre.Text = nombre
    'dtpFecha.Value = fecha
    'End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        btnSEditar.Text = If(editando, "Editar", "Guardar")

        txtNombre.ReadOnly = editando
        dtpFecha.Enabled = Not editando

        editando = Not editando
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        Me.Close()
    End Sub

    Private Sub Serie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If editando Then
            e.Cancel = True
        End If
    End Sub
End Class