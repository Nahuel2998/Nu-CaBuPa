Public Class frmLUsuario

    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        If BUsuario(txtUsuario.Text, txtPass.Text) Or ModConector.GDebug Then
            ModInicializador.Configuracion()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
        ModConector.desconectar()
    End Sub
    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtPass.Text = ""
    End Sub
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If ModConector.BUsuario(txtUsuario.Text, txtPass.Text) Then
            ModInicializador.Principal()
            Me.SetVisibleCore(False)
        End If
    End Sub

    Private Sub frmLUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
    End Sub

    Private Sub frmLUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ModUser.Inicio()
            ModConector.Inicio()
        Catch m As Exception
            If (ModConector.GDebug) Then
                MessageBox.Show(e.ToString)
            End If
        End Try
    End Sub

    Private Sub lblPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPass.Click

    End Sub
End Class