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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.panelUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUsuario
        '
        Me.panelUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUsuario.Controls.Add(Me.TextBox2)
        Me.panelUsuario.Controls.Add(Me.TextBox1)
        Me.panelUsuario.Controls.Add(Me.btnSalir)
        Me.panelUsuario.Controls.Add(Me.btnEntrar)
        Me.panelUsuario.Controls.Add(Me.lblPass)
        Me.panelUsuario.Controls.Add(Me.lblUsuario)
        Me.panelUsuario.Location = New System.Drawing.Point(13, 13)
        Me.panelUsuario.MinimumSize = New System.Drawing.Size(148, 116)
        Me.panelUsuario.Name = "panelUsuario"
        Me.panelUsuario.Size = New System.Drawing.Size(263, 130)
        Me.panelUsuario.TabIndex = 0
        Me.panelUsuario.TabStop = False
        Me.panelUsuario.Text = "Datos"
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
        'btnEntrar
        '
        Me.btnEntrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntrar.Location = New System.Drawing.Point(120, 93)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(68, 31)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(189, 93)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(68, 31)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(80, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(80, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(173, 20)
        Me.TextBox2.TabIndex = 5
        '
        'frmLUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 155)
        Me.Controls.Add(Me.panelUsuario)
        Me.MinimumSize = New System.Drawing.Size(190, 179)
        Me.Name = "frmLUsuario"
        Me.Text = "Login"
        Me.panelUsuario.ResumeLayout(False)
        Me.panelUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
