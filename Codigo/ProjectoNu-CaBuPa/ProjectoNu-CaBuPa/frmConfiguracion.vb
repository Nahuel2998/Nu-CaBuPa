
Public Class frmConfiguracion
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        ModUser.Borrar()
        ModUser.Verify()
        ModUser.Leer()
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (txtIp.Text <> "") Then
            ModConector.EAdress(txtIp.Text)
        End If
        If (txtPuerto.Text <> "") Then
            ModConector.EPort(txtPuerto.Text)
        End If
        If (txtNombre.Text <> "") Then
            ModConector.EUser(txtNombre.Text)
        End If
        If (txtContraseña.Text <> "") Then
            ModConector.EPass(txtContraseña.Text)
        End If
        If (txtBD.Text <> "") Then
            ModConector.EDatabase(txtBD.Text)
        End If
        ModUser.Guardar(False)
        ModUser.Leer()
        Me.Dispose()
    End Sub

    Private Sub DebugCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugCrear.Click
        If (txtIp.Text <> "") Then
            ModConector.EAdress(txtIp.Text)
        End If
        If (txtPuerto.Text <> "") Then
            ModConector.EPort(txtPuerto.Text)
        End If
        If (txtNombre.Text <> "") Then
            ModConector.EUser(txtNombre.Text)
        End If
        ModConector.EPass(txtContraseña.Text)
        If (txtBD.Text <> "") Then
            ModConector.EDatabase(txtBD.Text)
        End If
        ModUser.Guardar(True)
        ModUser.Leer()
        Me.Dispose()
    End Sub
End Class