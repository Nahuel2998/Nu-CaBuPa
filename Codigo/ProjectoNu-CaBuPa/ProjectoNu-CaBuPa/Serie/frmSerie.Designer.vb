<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSerie
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvVSM = New System.Windows.Forms.DataGridView()
        Me.VFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSEditar = New System.Windows.Forms.Button()
        Me.btnSSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.RichTextBox()
        Me.dtpFecha = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvVSM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.7975!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.2025!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(661, 354)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.dgvVSM)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 101)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(100, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Videos"
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
        Me.dgvVSM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VFecha, Me.VNombre})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVSM.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVSM.Location = New System.Drawing.Point(5, 21)
        Me.dgvVSM.Margin = New System.Windows.Forms.Padding(2)
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
        Me.dgvVSM.Size = New System.Drawing.Size(645, 170)
        Me.dgvVSM.TabIndex = 2
        '
        'VFecha
        '
        Me.VFecha.FillWeight = 40.28429!
        Me.VFecha.HeaderText = "Fecha"
        Me.VFecha.MinimumWidth = 6
        Me.VFecha.Name = "VFecha"
        Me.VFecha.ReadOnly = True
        '
        'VNombre
        '
        Me.VNombre.FillWeight = 150.7157!
        Me.VNombre.HeaderText = "Nombre"
        Me.VNombre.MinimumWidth = 6
        Me.VNombre.Name = "VNombre"
        Me.VNombre.ReadOnly = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 303)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSEditar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSSalir)
        Me.SplitContainer1.Size = New System.Drawing.Size(655, 48)
        Me.SplitContainer1.SplitterDistance = 410
        Me.SplitContainer1.TabIndex = 2
        '
        'btnSEditar
        '
        Me.btnSEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSEditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSEditar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSEditar.Location = New System.Drawing.Point(0, 0)
        Me.btnSEditar.MinimumSize = New System.Drawing.Size(90, 12)
        Me.btnSEditar.Name = "btnSEditar"
        Me.btnSEditar.Size = New System.Drawing.Size(146, 48)
        Me.btnSEditar.TabIndex = 1
        Me.btnSEditar.Text = "Editar"
        Me.btnSEditar.UseVisualStyleBackColor = True
        '
        'btnSSalir
        '
        Me.btnSSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSSalir.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSSalir.Location = New System.Drawing.Point(95, 0)
        Me.btnSSalir.MinimumSize = New System.Drawing.Size(90, 12)
        Me.btnSSalir.Name = "btnSSalir"
        Me.btnSSalir.Size = New System.Drawing.Size(146, 48)
        Me.btnSSalir.TabIndex = 2
        Me.btnSSalir.Text = "Salir"
        Me.btnSSalir.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Size = New System.Drawing.Size(655, 92)
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
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpFecha, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(7, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(642, 62)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(61, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 31)
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
        Me.Label2.Size = New System.Drawing.Size(61, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(67, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(572, 25)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = ""
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.dtpFecha.Location = New System.Drawing.Point(67, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(572, 23)
        Me.dtpFecha.TabIndex = 3
        '
        'frmSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(685, 370)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(701, 409)
        Me.MinimumSize = New System.Drawing.Size(701, 409)
        Me.Name = "frmSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ver Serie"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvVSM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvVSM As DataGridView
    Friend WithEvents btnSEditar As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents VFecha As DataGridViewTextBoxColumn
    Friend WithEvents VNombre As DataGridViewTextBoxColumn
    Friend WithEvents btnSSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As RichTextBox
    Friend WithEvents dtpFecha As ColorDateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
