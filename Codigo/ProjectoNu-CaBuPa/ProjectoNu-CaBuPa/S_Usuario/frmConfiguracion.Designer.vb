<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DebugCrear = New System.Windows.Forms.Button()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.txtBD = New System.Windows.Forms.TextBox()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvNombreUsuario = New System.Windows.Forms.DataGridView()
        Me.UBorrar = New System.Windows.Forms.Button()
        Me.UAplicar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtENombre = New System.Windows.Forms.TextBox()
        Me.txtEContrasena = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LimpiarUsuario = New System.Windows.Forms.Button()
        Me.CrearUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvNombreUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(434, 303)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DebugCrear)
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.txtBD)
        Me.GroupBox1.Controls.Add(Me.txtPuerto)
        Me.GroupBox1.Controls.Add(Me.txtIp)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Contraseña)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(555, 354)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexion"
        '
        'DebugCrear
        '
        Me.DebugCrear.Enabled = False
        Me.DebugCrear.Location = New System.Drawing.Point(204, 303)
        Me.DebugCrear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DebugCrear.Name = "DebugCrear"
        Me.DebugCrear.Size = New System.Drawing.Size(99, 35)
        Me.DebugCrear.TabIndex = 13
        Me.DebugCrear.Text = "Crear"
        Me.DebugCrear.UseVisualStyleBackColor = True
        Me.DebugCrear.Visible = False
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Location = New System.Drawing.Point(312, 303)
        Me.btnRestablecer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(112, 35)
        Me.btnRestablecer.TabIndex = 12
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'txtBD
        '
        Me.txtBD.Location = New System.Drawing.Point(16, 249)
        Me.txtBD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(284, 26)
        Me.txtBD.TabIndex = 11
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(312, 180)
        Me.txtPuerto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(234, 26)
        Me.txtPuerto.TabIndex = 10
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(15, 182)
        Me.txtIp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(286, 26)
        Me.txtIp.TabIndex = 9
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(14, 115)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(288, 26)
        Me.txtContraseña.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(15, 55)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(286, 26)
        Me.txtUsuario.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Base de datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Puerto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IP"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Location = New System.Drawing.Point(9, 91)
        Me.Contraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(92, 20)
        Me.Contraseña.TabIndex = 2
        Me.Contraseña.Text = "Contraseña"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(10, 31)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 405)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(570, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conexion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(570, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Usuario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.UBorrar)
        Me.GroupBox2.Controls.Add(Me.UAplicar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtENombre)
        Me.GroupBox2.Controls.Add(Me.txtEContrasena)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(552, 225)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edición"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvNombreUsuario)
        Me.GroupBox3.Location = New System.Drawing.Point(274, 25)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(268, 191)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Usuarios"
        '
        'dgvNombreUsuario
        '
        Me.dgvNombreUsuario.AllowUserToAddRows = False
        Me.dgvNombreUsuario.AllowUserToDeleteRows = False
        Me.dgvNombreUsuario.AllowUserToResizeColumns = False
        Me.dgvNombreUsuario.AllowUserToResizeRows = False
        Me.dgvNombreUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNombreUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNombreUsuario.Location = New System.Drawing.Point(9, 29)
        Me.dgvNombreUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvNombreUsuario.MultiSelect = False
        Me.dgvNombreUsuario.Name = "dgvNombreUsuario"
        Me.dgvNombreUsuario.ReadOnly = True
        Me.dgvNombreUsuario.RowHeadersVisible = False
        Me.dgvNombreUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNombreUsuario.Size = New System.Drawing.Size(250, 152)
        Me.dgvNombreUsuario.TabIndex = 0
        '
        'UBorrar
        '
        Me.UBorrar.Location = New System.Drawing.Point(22, 180)
        Me.UBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UBorrar.Name = "UBorrar"
        Me.UBorrar.Size = New System.Drawing.Size(112, 35)
        Me.UBorrar.TabIndex = 6
        Me.UBorrar.Text = "Borrar"
        Me.UBorrar.UseVisualStyleBackColor = True
        '
        'UAplicar
        '
        Me.UAplicar.Location = New System.Drawing.Point(148, 180)
        Me.UAplicar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UAplicar.Name = "UAplicar"
        Me.UAplicar.Size = New System.Drawing.Size(112, 35)
        Me.UAplicar.TabIndex = 5
        Me.UAplicar.Text = "Aplicar"
        Me.UAplicar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nombre"
        '
        'txtENombre
        '
        Me.txtENombre.Location = New System.Drawing.Point(22, 54)
        Me.txtENombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtENombre.Name = "txtENombre"
        Me.txtENombre.Size = New System.Drawing.Size(236, 26)
        Me.txtENombre.TabIndex = 0
        '
        'txtEContrasena
        '
        Me.txtEContrasena.Location = New System.Drawing.Point(22, 123)
        Me.txtEContrasena.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEContrasena.Name = "txtEContrasena"
        Me.txtEContrasena.Size = New System.Drawing.Size(236, 26)
        Me.txtEContrasena.TabIndex = 1
        Me.txtEContrasena.UseSystemPasswordChar = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LimpiarUsuario)
        Me.GroupBox4.Controls.Add(Me.CrearUsuario)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.txtContrasena)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 242)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(552, 114)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Creación"
        '
        'LimpiarUsuario
        '
        Me.LimpiarUsuario.Location = New System.Drawing.Point(303, 60)
        Me.LimpiarUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LimpiarUsuario.Name = "LimpiarUsuario"
        Me.LimpiarUsuario.Size = New System.Drawing.Size(112, 35)
        Me.LimpiarUsuario.TabIndex = 6
        Me.LimpiarUsuario.Text = "Limpiar"
        Me.LimpiarUsuario.UseVisualStyleBackColor = True
        '
        'CrearUsuario
        '
        Me.CrearUsuario.Location = New System.Drawing.Point(430, 60)
        Me.CrearUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CrearUsuario.Name = "CrearUsuario"
        Me.CrearUsuario.Size = New System.Drawing.Size(112, 35)
        Me.CrearUsuario.TabIndex = 5
        Me.CrearUsuario.Text = "Crear"
        Me.CrearUsuario.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Contraseña"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(86, 20)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 26)
        Me.txtNombre.TabIndex = 0
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(370, 20)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(170, 26)
        Me.txtContrasena.TabIndex = 1
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'BW
        '
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 418)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvNombreUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Contraseña As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtBD As System.Windows.Forms.TextBox
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents DebugCrear As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UBorrar As System.Windows.Forms.Button
    Friend WithEvents UAplicar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtENombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEContrasena As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LimpiarUsuario As System.Windows.Forms.Button
    Friend WithEvents CrearUsuario As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents dgvNombreUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
End Class
