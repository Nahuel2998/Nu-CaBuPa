﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpresa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresa))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSSalir = New System.Windows.Forms.Button()
        Me.btnSEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvVSM = New System.Windows.Forms.DataGridView()
        Me.CNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.RichTextBox()
        Me.txtTelefono = New System.Windows.Forms.RichTextBox()
        Me.txtMail = New System.Windows.Forms.RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvVSM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.32578!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.67422!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(661, 345)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8818!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1182!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnBorrar, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSEditar, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSSalir, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 296)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(657, 47)
        Me.TableLayoutPanel3.TabIndex = 28876924
        '
        'btnBorrar
        '
        Me.btnBorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBorrar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Location = New System.Drawing.Point(220, 3)
        Me.btnBorrar.MinimumSize = New System.Drawing.Size(90, 12)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(213, 41)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnSSalir
        '
        Me.btnSSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSSalir.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSSalir.Location = New System.Drawing.Point(516, 3)
        Me.btnSSalir.MinimumSize = New System.Drawing.Size(90, 12)
        Me.btnSSalir.Name = "btnSSalir"
        Me.btnSSalir.Size = New System.Drawing.Size(138, 41)
        Me.btnSSalir.TabIndex = 0
        Me.btnSSalir.Text = "Salir"
        Me.btnSSalir.UseVisualStyleBackColor = False
        '
        'btnSEditar
        '
        Me.btnSEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSEditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSEditar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSEditar.ForeColor = System.Drawing.Color.Black
        Me.btnSEditar.Location = New System.Drawing.Point(3, 3)
        Me.btnSEditar.MinimumSize = New System.Drawing.Size(90, 12)
        Me.btnSEditar.Name = "btnSEditar"
        Me.btnSEditar.Size = New System.Drawing.Size(152, 41)
        Me.btnSEditar.TabIndex = 1
        Me.btnSEditar.Text = "Editar"
        Me.btnSEditar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.dgvVSM)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 136)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(100, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Publicidades"
        '
        'dgvVSM
        '
        Me.dgvVSM.AllowUserToAddRows = False
        Me.dgvVSM.AllowUserToDeleteRows = False
        Me.dgvVSM.AllowUserToResizeColumns = False
        Me.dgvVSM.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVSM.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVSM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVSM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVSM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvVSM.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVSM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVSM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNombre, Me.PTema})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVSM.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVSM.Location = New System.Drawing.Point(5, 21)
        Me.dgvVSM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvVSM.MultiSelect = False
        Me.dgvVSM.Name = "dgvVSM"
        Me.dgvVSM.ReadOnly = True
        Me.dgvVSM.RowHeadersVisible = False
        Me.dgvVSM.RowHeadersWidth = 62
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvVSM.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVSM.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvVSM.RowTemplate.Height = 28
        Me.dgvVSM.RowTemplate.ReadOnly = True
        Me.dgvVSM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVSM.Size = New System.Drawing.Size(645, 131)
        Me.dgvVSM.TabIndex = 28876923
        '
        'CNombre
        '
        Me.CNombre.FillWeight = 40.28429!
        Me.CNombre.HeaderText = "Nombre"
        Me.CNombre.MinimumWidth = 6
        Me.CNombre.Name = "CNombre"
        Me.CNombre.ReadOnly = True
        '
        'PTema
        '
        Me.PTema.HeaderText = "Tema"
        Me.PTema.MinimumWidth = 6
        Me.PTema.Name = "PTema"
        Me.PTema.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(100, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 127)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTelefono, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMail, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(7, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(642, 94)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 62)
        Me.Label3.MinimumSize = New System.Drawing.Size(61, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 32)
        Me.Label3.TabIndex = 28876926
        Me.Label3.Text = "Mail:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(61, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.MinimumSize = New System.Drawing.Size(61, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Télefono:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(71, 3)
        Me.txtNombre.MaxLength = 64
        Me.txtNombre.Multiline = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(568, 25)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTelefono.ForeColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(71, 34)
        Me.txtTelefono.MaxLength = 16
        Me.txtTelefono.Multiline = False
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(568, 25)
        Me.txtTelefono.TabIndex = 28876928
        Me.txtTelefono.Text = ""
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMail.ForeColor = System.Drawing.Color.White
        Me.txtMail.Location = New System.Drawing.Point(71, 65)
        Me.txtMail.MaxLength = 64
        Me.txtMail.Multiline = False
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ReadOnly = True
        Me.txtMail.Size = New System.Drawing.Size(568, 26)
        Me.txtMail.TabIndex = 28876929
        Me.txtMail.Text = ""
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(685, 362)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(701, 401)
        Me.MinimumSize = New System.Drawing.Size(701, 401)
        Me.Name = "frmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empresa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvVSM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvVSM As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As RichTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnSSalir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSEditar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As RichTextBox
    Friend WithEvents txtMail As RichTextBox
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents PTema As DataGridViewTextBoxColumn
End Class
