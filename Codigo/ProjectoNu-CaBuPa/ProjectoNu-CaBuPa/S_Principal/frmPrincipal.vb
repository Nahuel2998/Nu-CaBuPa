Imports System.Drawing.Drawing2D

Public Class frmPrincipal

    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.85
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
    End Sub

    Private Sub frmPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim p As Pen = New Pen(Color.Red)
        e.Graphics.DrawRectangle(p, Panel1.Left - 1, Panel1.Top - 1, Panel1.Width + 100, Panel1.Height + 1)
    End Sub
End Class
