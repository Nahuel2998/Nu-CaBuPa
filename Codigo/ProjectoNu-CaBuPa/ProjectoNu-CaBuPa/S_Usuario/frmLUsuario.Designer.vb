<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLUsuario
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
        Me.panelUsuario = New System.Windows.Forms.GroupBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnOpciones = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelUsuario.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUsuario
        '
        Me.panelUsuario.Controls.Add(Me.btnOpciones)
        Me.panelUsuario.Controls.Add(Me.txtPass)
        Me.panelUsuario.Controls.Add(Me.txtUsuario)
        Me.panelUsuario.Controls.Add(Me.btnSalir)
        Me.panelUsuario.Controls.Add(Me.btnEntrar)
        Me.panelUsuario.Controls.Add(Me.lblPass)
        Me.panelUsuario.Controls.Add(Me.lblUsuario)
        Me.panelUsuario.Location = New System.Drawing.Point(3, 3)
        Me.panelUsuario.MinimumSize = New System.Drawing.Size(148, 116)
        Me.panelUsuario.Name = "panelUsuario"
        Me.panelUsuario.Size = New System.Drawing.Size(238, 117)
        Me.panelUsuario.TabIndex = 0
        Me.panelUsuario.TabStop = False
        Me.panelUsuario.Text = "Datos"
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.Location = New System.Drawing.Point(80, 57)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(148, 20)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.Location = New System.Drawing.Point(80, 29)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(148, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(90, 80)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(68, 31)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntrar.Location = New System.Drawing.Point(160, 80)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(68, 31)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'lblPass
        '
        Me.lblPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(7, 57)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 13)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Contraseña :"
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(7, 29)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(49, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario :"
        '
        'btnOpciones
        '
        Me.btnOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpciones.Location = New System.Drawing.Point(6, 80)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(83, 31)
        Me.btnOpciones.TabIndex = 0
        Me.btnOpciones.Text = "Configuración"
        Me.btnOpciones.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.panelUsuario)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 123)
        Me.Panel1.TabIndex = 2
        '
        'frmLUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 143)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmLUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.panelUsuario.ResumeLayout(False)
        Me.panelUsuario.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnOpciones As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
