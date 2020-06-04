
Public Class frmConfiguracion
    Private UserID As Integer = Nothing
    Private UsuarioDatos As DataTable

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


    Private Sub frmConfiguracion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModUser.Inicio()
        ModConector.Inicio()
    End Sub

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ModConector.GDebug Then
            DebugCrear.Visible = True
            DebugCrear.Enabled = True
        End If
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        ActualizarUsuarios(False)
        'BGW.RunWorkerAsync(False)
        LimpiarEditar()
        limpiar()
    End Sub

  
#Region "Limpiadores"
    Private Sub limpiar()
        txtNombre.Text = ""
        txtContrasena.Text = ""
        dgvNombreUsuario.ClearSelection()
    End Sub
    Private Sub LimpiarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarUsuario.Click
        limpiar()
    End Sub
    Private Sub LimpiarEditar()
        txtENombre.Text = ""
        txtEContrasena.Text = ""
        UserID = Nothing
    End Sub
    Private Sub UAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UAplicar.Click
        If Not IsNothing(UserID) Then
            USQL("usuarios", "nombre ='" + txtENombre.Text + "',contrasena = AES_ENCRYPT('" + txtEContrasena.Text() + "',sha2('" + ModCodificador.GKey + "',256))", "id_usuario ='" + UserID.ToString() + "'")
            ActualizarUsuarios(False)
            If UserID = ModConector.GUsuarioID Then
                ModConector.BorrarUsuario()
                Me.Dispose()

            End If
        End If
        LimpiarEditar()
    End Sub
#End Region
#Region "Modificar Usuarios"
    Private Sub UBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UBorrar.Click
        If Not IsNothing(UserID) Then
            BSQL("usuarios", "id_usuario ='" + UserID.ToString + "'")
            ActualizarUsuarios(False)
            'BGW.RunWorkerAsync(False)
            If UserID = ModConector.GUsuarioID Then
                ModConector.BorrarUsuario()
                Me.Dispose()

            End If
        End If
        LimpiarEditar()
    End Sub

    Private Sub ActualizarUsuarios(ByVal actualizar As Boolean)
        Dim dt As DataTable = ModConector.AUsuarios(actualizar)
        If Not IsNothing(dt) Then
            Me.dgvNombreUsuario.DataSource = dt

        Else
            MessageBox.Show("No se cargo correctamente")
        End If
    End Sub

    Private Sub CrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearUsuario.Click
        ModConector.IUsuario(txtNombre.Text, txtContrasena.Text)
        ActualizarUsuarios(True)
        'BGW.RunWorkerAsync(True)
        limpiar()
    End Sub
#End Region
    Private Sub dgvNombreUsuario_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvNombreUsuario.CellMouseClick
        Try
            LimpiarEditar()
            txtENombre.Text = dgvNombreUsuario.CurrentRow.Cells("Nombre Usuarios").Value.ToString
            UserID = dgvNombreUsuario.CurrentRow.Cells("ID").Value
        Catch es As Exception
        End Try
    End Sub


    'Private Sub BGW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork
    '   ActualizarUsuarios(e.Argument())
    'End Sub


End Class