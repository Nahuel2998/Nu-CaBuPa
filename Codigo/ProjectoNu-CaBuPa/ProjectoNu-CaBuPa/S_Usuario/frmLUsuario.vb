Public Class frmLUsuario
    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        If PoseePermiso("Configuracion") Then
            If BUsuario(txtUsuario.Text, txtPass.Text) Or ModConector.GDebug Then
                ModInicializador.Configuracion()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModConector.desconectar()
        End
    End Sub
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If ModConector.BUsuario(txtUsuario.Text, txtPass.Text) Then
            If PoseePermiso("Inicio") Then
                ModInicializador.Principal()
                Me.Dispose()
            Else
                MessageBox.Show("No posee permisos para ingresar")
            End If
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
End Class