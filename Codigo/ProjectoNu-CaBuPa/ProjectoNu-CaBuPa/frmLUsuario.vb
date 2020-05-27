Public Class frmLUsuario

    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        If BUsuario(txtUsuario.Text, txtPass.Text) Then
            ModuloInicializador.Configuracion()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
        ModConector.desconectar()
    End Sub
    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtPass.Text = ""
    End Sub
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If BUsuario(txtUsuario.Text, txtPass.Text) Then
                MessageBox.Show("Bienvenido")
                ModuloInicializador.Principal()
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
            MessageBox.Show(e.ToString)
        End Try
    End Sub
End Class