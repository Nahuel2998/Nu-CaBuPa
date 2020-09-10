<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Publicidad
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbNotas = New System.Windows.Forms.GroupBox()
        Me.TBNotas = New System.Windows.Forms.RichTextBox()
        Me.dgvPPublicidades = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.gbNotas.SuspendLayout()
        CType(Me.dgvPPublicidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbNotas
        '
        Me.gbNotas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbNotas.Controls.Add(Me.TBNotas)
        Me.gbNotas.Location = New System.Drawing.Point(12, 12)
        Me.gbNotas.Name = "gbNotas"
        Me.gbNotas.Size = New System.Drawing.Size(388, 155)
        Me.gbNotas.TabIndex = 2
        Me.gbNotas.TabStop = False
        Me.gbNotas.Text = "Contenido"
        '
        'TBNotas
        '
        Me.TBNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBNotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBNotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNotas.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TBNotas.ForeColor = System.Drawing.Color.White
        Me.TBNotas.Location = New System.Drawing.Point(7, 22)
        Me.TBNotas.Name = "TBNotas"
        Me.TBNotas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TBNotas.Size = New System.Drawing.Size(372, 123)
        Me.TBNotas.TabIndex = 1
        Me.TBNotas.Text = ""
        '
        'dgvPPublicidades
        '
        Me.dgvPPublicidades.AllowUserToAddRows = False
        Me.dgvPPublicidades.AllowUserToDeleteRows = False
        Me.dgvPPublicidades.AllowUserToResizeColumns = False
        Me.dgvPPublicidades.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPPublicidades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPPublicidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPPublicidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPPublicidades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvPPublicidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPPublicidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPPublicidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPPublicidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPPublicidades.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPPublicidades.Location = New System.Drawing.Point(7, 30)
        Me.dgvPPublicidades.MultiSelect = False
        Me.dgvPPublicidades.Name = "dgvPPublicidades"
        Me.dgvPPublicidades.ReadOnly = True
        Me.dgvPPublicidades.RowHeadersVisible = False
        Me.dgvPPublicidades.RowHeadersWidth = 62
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.dgvPPublicidades.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPPublicidades.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvPPublicidades.RowTemplate.Height = 28
        Me.dgvPPublicidades.RowTemplate.ReadOnly = True
        Me.dgvPPublicidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPPublicidades.Size = New System.Drawing.Size(379, 81)
        Me.dgvPPublicidades.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvPPublicidades)
        Me.GroupBox2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 117)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 296)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 26)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(310, 296)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 26)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Publicidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 331)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.gbNotas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Publicidad"
        Me.Text = "Publicidad"
        Me.gbNotas.ResumeLayout(False)
        CType(Me.dgvPPublicidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbNotas As GroupBox
    Friend WithEvents TBNotas As RichTextBox
    Friend WithEvents dgvPPublicidades As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
End Class
