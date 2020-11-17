Imports System.ComponentModel

Public Class frmLUsuario
    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        BUsuario(txtUsuario.Text, txtPass.Text, False)
        ModInicializador.Configuracion()
        ' End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModConector.desconectar()
        End
    End Sub
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If ModConector.BUsuario(txtUsuario.Text, txtPass.Text) Then
            If PoseePermiso("Inicio") Then
                ModInicializador.Principal()
                Me.Close()
            Else
                MessageBox.Show("No posee permisos para ingresar")
            End If
        End If
    End Sub

    Private Sub frmLUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
    End Sub

    Private Sub frmLUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            ModUser.Inicio()
        Catch m As Exception
            If (ModConector.GDebug) Then
                MessageBox.Show(e.ToString)
            End If
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ModConector.Inicio()
        btnEntrar.Enabled = True
    End Sub
End Class