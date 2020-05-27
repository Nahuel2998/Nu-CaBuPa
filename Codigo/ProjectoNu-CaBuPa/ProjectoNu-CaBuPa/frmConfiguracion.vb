
Public Class frmConfiguracion
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        ModUser.Borrar()
        ModUser.Inicio()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (txtIp.Text <> "") Then
            ModConector.EAdress(txtIp.Text)
        End If
        If (txtPuerto.Text <> "") Then
            ModConector.EPort(txtPuerto.Text)
        End If
        If (txtUsuario.Text <> "") Then
            ModConector.EUser(txtUsuario.Text)
        End If
        ModConector.EPass(txtContraseña.Text)
        If (txtBD.Text <> "") Then
            ModConector.EDatabase(txtBD.Text)
        End If
        ModUser.Guardar(False)
        ModUser.LeeDatos()
    End Sub

    Private Sub DebugCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugCrear.Click
        If (txtIp.Text <> "") Then
            ModConector.EAdress(txtIp.Text)
        End If
        If (txtPuerto.Text <> "") Then
            ModConector.EPort(txtPuerto.Text)
        End If
        If (txtUsuario.Text <> "") Then
            ModConector.EUser(txtUsuario.Text)
        End If
        ModConector.EPass(txtContraseña.Text)
        If (txtBD.Text <> "") Then
            ModConector.EDatabase(txtBD.Text)
        End If
        ModUser.Guardar(True)
        ModUser.LeeDatos()
        Me.Dispose()
    End Sub

    Private Sub DebugCrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModConector.IUsuario(txtUsuario.Text, txtContraseña.Text)
    End Sub

    Private Sub ActualizarUsuarios()
        MessageBox.Show("Carga")
        Dim dt As DataTable = ModConector.AUsuarios()
        If Not IsNothing(dt) Then
            NombresUsuario.DataSource = dt
            cmbUsuarios.DataSource = dt
            MessageBox.Show("Carga")
        Else
            MessageBox.Show("No")
        End If
    End Sub
    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        ActualizarUsuarios()
    End Sub

    Private Sub CrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearUsuario.Click
        ModConector.IUsuario(txtNombre.Text, txtContrasena.Text)
        ActualizarUsuarios()
    End Sub

  
    Private Sub CargarUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarUsuarios.Click
        ActualizarUsuarios()
    End Sub
End Class