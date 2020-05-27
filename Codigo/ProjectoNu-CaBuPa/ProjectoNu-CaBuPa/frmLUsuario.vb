Public Class frmLUsuario

    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        ModuloInicializador.Configuracion()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
        ModConector.desconectar()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        ModConector.Inicio()
        Dim dt As DataTable = BUsuario(txtUsuario.Text, txtPass.Text)
        If Not IsNothing(dt) Then
            DataGridView1.DataSource = dt
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Contraseña o Usuario Incorrecto")
            Else
                ModuloInicializador.Principal()
                MessageBox.Show("Bienvenido")
                Me.Dispose()
            End If
        End If
        
            
    End Sub

    Private Sub frmLUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
    End Sub

    Private Sub frmLUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModUser.Inicio()
        ModUser.Leer()
    End Sub
End Class