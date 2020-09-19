<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.VFecha = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbTieneFecha = New System.Windows.Forms.CheckBox()
        Me.txtTapar = New System.Windows.Forms.TextBox()
        Me.cbSerie = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dtpFecha = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.VSerie = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(166, 30)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(138, 27)
        Me.txtNombre.TabIndex = 2
        '
        'txtContenido
        '
        Me.txtContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContenido.ForeColor = System.Drawing.Color.White
        Me.txtContenido.Location = New System.Drawing.Point(8, 24)
        Me.txtContenido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtContenido.Multiline = True
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.ReadOnly = True
        Me.txtContenido.Size = New System.Drawing.Size(365, 147)
        Me.txtContenido.TabIndex = 3
        '
        'VFecha
        '
        Me.VFecha.AutoSize = True
        Me.VFecha.Location = New System.Drawing.Point(100, 72)
        Me.VFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VFecha.Name = "VFecha"
        Me.VFecha.Size = New System.Drawing.Size(50, 18)
        Me.VFecha.TabIndex = 2
        Me.VFecha.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chbTieneFecha)
        Me.GroupBox1.Controls.Add(Me.txtTapar)
        Me.GroupBox1.Controls.Add(Me.cbSerie)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.VSerie)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.VFecha)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(394, 360)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'chbTieneFecha
        '
        Me.chbTieneFecha.AutoSize = True
        Me.chbTieneFecha.Location = New System.Drawing.Point(310, 68)
        Me.chbTieneFecha.Name = "chbTieneFecha"
        Me.chbTieneFecha.Size = New System.Drawing.Size(78, 22)
        Me.chbTieneFecha.TabIndex = 4
        Me.chbTieneFecha.Text = "Incluir"
        Me.chbTieneFecha.UseVisualStyleBackColor = True
        Me.chbTieneFecha.Visible = False
        '
        'txtTapar
        '
        Me.txtTapar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTapar.Enabled = False
        Me.txtTapar.ForeColor = System.Drawing.Color.White
        Me.txtTapar.Location = New System.Drawing.Point(166, 66)
        Me.txtTapar.Name = "txtTapar"
        Me.txtTapar.Size = New System.Drawing.Size(138, 27)
        Me.txtTapar.TabIndex = 3
        Me.txtTapar.Text = "No posee fecha"
        Me.txtTapar.Visible = False
        '
        'cbSerie
        '
        Me.cbSerie.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.cbSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSerie.Enabled = False
        Me.cbSerie.ForeColor = System.Drawing.Color.White
        Me.cbSerie.FormattingEnabled = True
        Me.cbSerie.Location = New System.Drawing.Point(166, 102)
        Me.cbSerie.Name = "cbSerie"
        Me.cbSerie.Size = New System.Drawing.Size(138, 26)
        Me.cbSerie.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(296, 328)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 26)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(8, 328)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 26)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(166, 66)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(138, 27)
        Me.dtpFecha.TabIndex = 3
        '
        'VSerie
        '
        Me.VSerie.AutoSize = True
        Me.VSerie.Location = New System.Drawing.Point(106, 105)
        Me.VSerie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VSerie.Name = "VSerie"
        Me.VSerie.Size = New System.Drawing.Size(44, 18)
        Me.VSerie.TabIndex = 9
        Me.VSerie.Text = "Serie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtContenido)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 140)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(381, 184)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contenido"
        '
        'frmVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(446, 434)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(446, 434)
        Me.Name = "frmVideo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Video"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtContenido As TextBox
    Friend WithEvents VFecha As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VSerie As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpFecha As ColorDateTimePicker
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents cbSerie As ComboBox
    Friend WithEvents txtTapar As TextBox
    Friend WithEvents chbTieneFecha As CheckBox
End Class
