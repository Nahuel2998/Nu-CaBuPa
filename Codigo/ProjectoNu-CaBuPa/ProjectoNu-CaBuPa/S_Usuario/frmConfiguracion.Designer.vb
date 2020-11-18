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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGenerador = New System.Windows.Forms.Button()
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
        Me.TAB = New System.Windows.Forms.TabControl()
        Me.TBconexion = New System.Windows.Forms.TabPage()
        Me.TPusuarios = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAccesos = New System.Windows.Forms.Button()
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
        Me.TAB.SuspendLayout()
        Me.TBconexion.SuspendLayout()
        Me.TPusuarios.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvNombreUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardar.Location = New System.Drawing.Point(386, 242)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnGenerador)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(493, 283)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexion"
        '
        'btnGenerador
        '
        Me.btnGenerador.Enabled = False
        Me.btnGenerador.Location = New System.Drawing.Point(303, 37)
        Me.btnGenerador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerador.Name = "btnGenerador"
        Me.btnGenerador.Size = New System.Drawing.Size(156, 76)
        Me.btnGenerador.TabIndex = 14
        Me.btnGenerador.Text = "Generador"
        Me.btnGenerador.UseVisualStyleBackColor = True
        Me.btnGenerador.Visible = False
        '
        'DebugCrear
        '
        Me.DebugCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DebugCrear.Enabled = False
        Me.DebugCrear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DebugCrear.Location = New System.Drawing.Point(181, 242)
        Me.DebugCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.DebugCrear.Name = "DebugCrear"
        Me.DebugCrear.Size = New System.Drawing.Size(88, 28)
        Me.DebugCrear.TabIndex = 13
        Me.DebugCrear.Text = "Crear"
        Me.DebugCrear.UseVisualStyleBackColor = False
        Me.DebugCrear.Visible = False
        '
        'btnRestablecer
        '
        Me.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestablecer.ForeColor = System.Drawing.Color.White
        Me.btnRestablecer.Location = New System.Drawing.Point(277, 242)
        Me.btnRestablecer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(100, 28)
        Me.btnRestablecer.TabIndex = 12
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = False
        '
        'txtBD
        '
        Me.txtBD.Location = New System.Drawing.Point(14, 199)
        Me.txtBD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(253, 22)
        Me.txtBD.TabIndex = 11
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(277, 144)
        Me.txtPuerto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(208, 22)
        Me.txtPuerto.TabIndex = 10
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(13, 146)
        Me.txtIp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(255, 22)
        Me.txtIp.TabIndex = 9
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(12, 92)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(256, 22)
        Me.txtContraseña.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(13, 44)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(255, 22)
        Me.txtUsuario.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Base de datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Puerto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IP"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Location = New System.Drawing.Point(8, 73)
        Me.Contraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(81, 17)
        Me.Contraseña.TabIndex = 2
        Me.Contraseña.Text = "Contraseña"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(9, 25)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'TAB
        '
        Me.TAB.Controls.Add(Me.TBconexion)
        Me.TAB.Controls.Add(Me.TPusuarios)
        Me.TAB.Location = New System.Drawing.Point(8, 10)
        Me.TAB.Margin = New System.Windows.Forms.Padding(4)
        Me.TAB.Name = "TAB"
        Me.TAB.SelectedIndex = 0
        Me.TAB.Size = New System.Drawing.Size(514, 324)
        Me.TAB.TabIndex = 17
        '
        'TBconexion
        '
        Me.TBconexion.Controls.Add(Me.GroupBox1)
        Me.TBconexion.Location = New System.Drawing.Point(4, 25)
        Me.TBconexion.Margin = New System.Windows.Forms.Padding(4)
        Me.TBconexion.Name = "TBconexion"
        Me.TBconexion.Padding = New System.Windows.Forms.Padding(4)
        Me.TBconexion.Size = New System.Drawing.Size(506, 295)
        Me.TBconexion.TabIndex = 0
        Me.TBconexion.Text = "Conexion"
        Me.TBconexion.UseVisualStyleBackColor = True
        '
        'TPusuarios
        '
        Me.TPusuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TPusuarios.Controls.Add(Me.GroupBox2)
        Me.TPusuarios.Controls.Add(Me.GroupBox4)
        Me.TPusuarios.Location = New System.Drawing.Point(4, 25)
        Me.TPusuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.TPusuarios.Name = "TPusuarios"
        Me.TPusuarios.Padding = New System.Windows.Forms.Padding(4)
        Me.TPusuarios.Size = New System.Drawing.Size(506, 295)
        Me.TPusuarios.TabIndex = 1
        Me.TPusuarios.Text = "Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAccesos)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.UBorrar)
        Me.GroupBox2.Controls.Add(Me.UAplicar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtENombre)
        Me.GroupBox2.Controls.Add(Me.txtEContrasena)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(491, 186)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edición"
        '
        'btnAccesos
        '
        Me.btnAccesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccesos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAccesos.Location = New System.Drawing.Point(137, 151)
        Me.btnAccesos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAccesos.Name = "btnAccesos"
        Me.btnAccesos.Size = New System.Drawing.Size(100, 28)
        Me.btnAccesos.TabIndex = 13
        Me.btnAccesos.Text = "Permisos"
        Me.btnAccesos.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvNombreUsuario)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(244, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(238, 152)
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
        Me.dgvNombreUsuario.Location = New System.Drawing.Point(8, 23)
        Me.dgvNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvNombreUsuario.MultiSelect = False
        Me.dgvNombreUsuario.Name = "dgvNombreUsuario"
        Me.dgvNombreUsuario.ReadOnly = True
        Me.dgvNombreUsuario.RowHeadersVisible = False
        Me.dgvNombreUsuario.RowHeadersWidth = 62
        Me.dgvNombreUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNombreUsuario.Size = New System.Drawing.Size(222, 122)
        Me.dgvNombreUsuario.TabIndex = 0
        '
        'UBorrar
        '
        Me.UBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UBorrar.ForeColor = System.Drawing.Color.White
        Me.UBorrar.Location = New System.Drawing.Point(20, 117)
        Me.UBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.UBorrar.Name = "UBorrar"
        Me.UBorrar.Size = New System.Drawing.Size(100, 28)
        Me.UBorrar.TabIndex = 6
        Me.UBorrar.Text = "Borrar"
        Me.UBorrar.UseVisualStyleBackColor = False
        '
        'UAplicar
        '
        Me.UAplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UAplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UAplicar.Location = New System.Drawing.Point(137, 117)
        Me.UAplicar.Margin = New System.Windows.Forms.Padding(4)
        Me.UAplicar.Name = "UAplicar"
        Me.UAplicar.Size = New System.Drawing.Size(100, 28)
        Me.UAplicar.TabIndex = 5
        Me.UAplicar.Text = "Aplicar"
        Me.UAplicar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nombre"
        '
        'txtENombre
        '
        Me.txtENombre.Location = New System.Drawing.Point(20, 43)
        Me.txtENombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtENombre.Name = "txtENombre"
        Me.txtENombre.Size = New System.Drawing.Size(210, 22)
        Me.txtENombre.TabIndex = 0
        '
        'txtEContrasena
        '
        Me.txtEContrasena.Location = New System.Drawing.Point(20, 88)
        Me.txtEContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEContrasena.Name = "txtEContrasena"
        Me.txtEContrasena.Size = New System.Drawing.Size(210, 22)
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
        Me.GroupBox4.Location = New System.Drawing.Point(8, 194)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(486, 91)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Creación"
        '
        'LimpiarUsuario
        '
        Me.LimpiarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LimpiarUsuario.ForeColor = System.Drawing.Color.White
        Me.LimpiarUsuario.Location = New System.Drawing.Point(263, 55)
        Me.LimpiarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.LimpiarUsuario.Name = "LimpiarUsuario"
        Me.LimpiarUsuario.Size = New System.Drawing.Size(100, 28)
        Me.LimpiarUsuario.TabIndex = 6
        Me.LimpiarUsuario.Text = "Limpiar"
        Me.LimpiarUsuario.UseVisualStyleBackColor = False
        '
        'CrearUsuario
        '
        Me.CrearUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CrearUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CrearUsuario.Location = New System.Drawing.Point(370, 55)
        Me.CrearUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.CrearUsuario.Name = "CrearUsuario"
        Me.CrearUsuario.Size = New System.Drawing.Size(100, 28)
        Me.CrearUsuario.TabIndex = 5
        Me.CrearUsuario.Text = "Crear"
        Me.CrearUsuario.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Contraseña"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 18)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(144, 22)
        Me.txtNombre.TabIndex = 0
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(316, 18)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(153, 22)
        Me.txtContrasena.TabIndex = 1
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'BW
        '
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 342)
        Me.Controls.Add(Me.TAB)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(549, 389)
        Me.MinimumSize = New System.Drawing.Size(549, 389)
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TAB.ResumeLayout(False)
        Me.TBconexion.ResumeLayout(False)
        Me.TPusuarios.ResumeLayout(False)
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
    Friend WithEvents TAB As System.Windows.Forms.TabControl
    Friend WithEvents TBconexion As System.Windows.Forms.TabPage
    Friend WithEvents TPusuarios As System.Windows.Forms.TabPage
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
    Friend WithEvents btnAccesos As Button
    Friend WithEvents btnGenerador As Button
End Class
