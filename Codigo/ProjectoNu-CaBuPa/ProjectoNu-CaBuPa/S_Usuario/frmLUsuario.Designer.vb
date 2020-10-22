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
        Me.btnOpciones = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UI_GradientPanel1 = New UIDC.UI_GradientPanel()
        Me.UI_TitleBanner1 = New UIDC.UI_TitleBanner()
        Me.panelUsuario.SuspendLayout()
        Me.UI_GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUsuario
        '
        Me.panelUsuario.BackColor = System.Drawing.Color.Transparent
        Me.panelUsuario.Controls.Add(Me.btnOpciones)
        Me.panelUsuario.Controls.Add(Me.txtPass)
        Me.panelUsuario.Controls.Add(Me.txtUsuario)
        Me.panelUsuario.Controls.Add(Me.btnEntrar)
        Me.panelUsuario.Controls.Add(Me.lblPass)
        Me.panelUsuario.Controls.Add(Me.lblUsuario)
        Me.panelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panelUsuario.Location = New System.Drawing.Point(10, 37)
        Me.panelUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.panelUsuario.MinimumSize = New System.Drawing.Size(197, 143)
        Me.panelUsuario.Name = "panelUsuario"
        Me.panelUsuario.Padding = New System.Windows.Forms.Padding(4)
        Me.panelUsuario.Size = New System.Drawing.Size(562, 225)
        Me.panelUsuario.TabIndex = 0
        Me.panelUsuario.TabStop = False
        Me.panelUsuario.Text = "Datos"
        '
        'btnOpciones
        '
        Me.btnOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpciones.Location = New System.Drawing.Point(21, 172)
        Me.btnOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(136, 45)
        Me.btnOpciones.TabIndex = 3
        Me.btnOpciones.Text = "Configuración"
        Me.btnOpciones.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.Location = New System.Drawing.Point(136, 112)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.MaxLength = 256
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(411, 22)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.Location = New System.Drawing.Point(135, 57)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.MaxLength = 16
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(411, 22)
        Me.txtUsuario.TabIndex = 0
        '
        'btnEntrar
        '
        Me.btnEntrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnEntrar.Location = New System.Drawing.Point(427, 172)
        Me.btnEntrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(122, 45)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'lblPass
        '
        Me.lblPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPass.Location = New System.Drawing.Point(9, 112)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(114, 20)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Contraseña:"
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuario.Location = New System.Drawing.Point(8, 57)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(81, 20)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.Location = New System.Drawing.Point(13, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 250)
        Me.Panel1.TabIndex = 2
        '
        'UI_GradientPanel1
        '
        Me.UI_GradientPanel1.AutoSize = True
        Me.UI_GradientPanel1.BackColor = System.Drawing.Color.White
        Me.UI_GradientPanel1.Controls.Add(Me.UI_TitleBanner1)
        Me.UI_GradientPanel1.Controls.Add(Me.panelUsuario)
        Me.UI_GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UI_GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UI_GradientPanel1.Name = "UI_GradientPanel1"
        Me.UI_GradientPanel1.Size = New System.Drawing.Size(590, 274)
        Me.UI_GradientPanel1.TabIndex = 4
        Me.UI_GradientPanel1.UIBackColor = System.Drawing.Color.Empty
        Me.UI_GradientPanel1.UIBottomLeft = System.Drawing.Color.DarkBlue
        Me.UI_GradientPanel1.UIBottomRight = System.Drawing.Color.Orange
        Me.UI_GradientPanel1.UIForeColor = System.Drawing.Color.Empty
        Me.UI_GradientPanel1.UIPrimerColor = System.Drawing.Color.White
        Me.UI_GradientPanel1.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners
        Me.UI_GradientPanel1.UITopLeft = System.Drawing.Color.Lime
        Me.UI_GradientPanel1.UITopRight = System.Drawing.Color.Fuchsia
        '
        'UI_TitleBanner1
        '
        Me.UI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateON
        Me.UI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOn
        Me.UI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close_Minimize
        Me.UI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UI_TitleBanner1.FlatAppearance.BorderSize = 0
        Me.UI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UI_TitleBanner1.Font = New System.Drawing.Font("Roboto Medium", 10.0!)
        Me.UI_TitleBanner1.ForeColor = System.Drawing.Color.White
        Me.UI_TitleBanner1.Location = New System.Drawing.Point(0, 0)
        Me.UI_TitleBanner1.MoveActive = True
        Me.UI_TitleBanner1.Name = "UI_TitleBanner1"
        Me.UI_TitleBanner1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.UI_TitleBanner1.ParentControl = Me
        Me.UI_TitleBanner1.Size = New System.Drawing.Size(590, 30)
        Me.UI_TitleBanner1.TabIndex = 1
        Me.UI_TitleBanner1.Text = "Inicio de sesión"
        Me.UI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.UI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows
        Me.UI_TitleBanner1.UseVisualStyleBackColor = False
        '
        'frmLUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 274)
        Me.Controls.Add(Me.UI_GradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmLUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.panelUsuario.ResumeLayout(False)
        Me.panelUsuario.PerformLayout()
        Me.UI_GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnOpciones As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UI_GradientPanel1 As UIDC.UI_GradientPanel
    Friend WithEvents UI_TitleBanner1 As UIDC.UI_TitleBanner
End Class
