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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerie))
        Me.tcS = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvVSM = New System.Windows.Forms.DataGridView()
        Me.VFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTapar = New System.Windows.Forms.RichTextBox()
        Me.chbIncluir = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.RichTextBox()
        Me.tbAV = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvVideoBV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvVideoAs = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnDesasignar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreBV = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFechaBV = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.BWBuscador = New System.ComponentModel.BackgroundWorker()
        Me.tcS.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvVSM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tbAV.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dgvVideoBV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dgvVideoAs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcS
        '
        Me.tcS.Controls.Add(Me.TabPage1)
        Me.tcS.Controls.Add(Me.tbAV)
        Me.tcS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcS.Location = New System.Drawing.Point(0, 0)
        Me.tcS.Margin = New System.Windows.Forms.Padding(4)
        Me.tcS.Name = "tcS"
        Me.tcS.SelectedIndex = 0
        Me.tcS.Size = New System.Drawing.Size(911, 436)
        Me.tcS.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(903, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.7975!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.2025!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(895, 399)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.btnSSalir, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnBorrar, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSEditar, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 338)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(875, 58)
        Me.TableLayoutPanel3.TabIndex = 28876924
        '
        'btnSSalir
        '
        Me.btnSSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSSalir.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSSalir.Location = New System.Drawing.Point(720, 4)
        Me.btnSSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSSalir.MinimumSize = New System.Drawing.Size(120, 15)
        Me.btnSSalir.Name = "btnSSalir"
        Me.btnSSalir.Size = New System.Drawing.Size(151, 50)
        Me.btnSSalir.TabIndex = 0
        Me.btnSSalir.Text = "Salir"
        Me.btnSSalir.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBorrar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Location = New System.Drawing.Point(335, 4)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.MinimumSize = New System.Drawing.Size(120, 15)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(248, 50)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnSEditar
        '
        Me.btnSEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSEditar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSEditar.ForeColor = System.Drawing.Color.Black
        Me.btnSEditar.Location = New System.Drawing.Point(4, 4)
        Me.btnSEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSEditar.MinimumSize = New System.Drawing.Size(120, 15)
        Me.btnSEditar.Name = "btnSEditar"
        Me.btnSEditar.Size = New System.Drawing.Size(195, 50)
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(133, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(887, 218)
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
        Me.dgvVSM.Location = New System.Drawing.Point(7, 26)
        Me.dgvVSM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.dgvVSM.Size = New System.Drawing.Size(873, 188)
        Me.dgvVSM.TabIndex = 28876923
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(133, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(887, 102)
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
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(9, 28)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(869, 63)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTapar)
        Me.Panel1.Controls.Add(Me.chbIncluir)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(88, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 28)
        Me.Panel1.TabIndex = 28876925
        '
        'txtTapar
        '
        Me.txtTapar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTapar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTapar.ForeColor = System.Drawing.Color.White
        Me.txtTapar.Location = New System.Drawing.Point(0, 0)
        Me.txtTapar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTapar.Multiline = False
        Me.txtTapar.Name = "txtTapar"
        Me.txtTapar.ReadOnly = True
        Me.txtTapar.Size = New System.Drawing.Size(778, 28)
        Me.txtTapar.TabIndex = 5
        Me.txtTapar.Text = "No posee fecha."
        Me.txtTapar.Visible = False
        '
        'chbIncluir
        '
        Me.chbIncluir.AutoSize = True
        Me.chbIncluir.Enabled = False
        Me.chbIncluir.Location = New System.Drawing.Point(676, 5)
        Me.chbIncluir.Margin = New System.Windows.Forms.Padding(4)
        Me.chbIncluir.Name = "chbIncluir"
        Me.chbIncluir.Size = New System.Drawing.Size(78, 22)
        Me.chbIncluir.TabIndex = 4
        Me.chbIncluir.Text = "Incluir"
        Me.chbIncluir.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.dtpFecha.Location = New System.Drawing.Point(1, 1)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(667, 27)
        Me.dtpFecha.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(81, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(81, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(89, 4)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 48
        Me.txtNombre.Multiline = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(776, 23)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = ""
        '
        'tbAV
        '
        Me.tbAV.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbAV.Controls.Add(Me.TableLayoutPanel4)
        Me.tbAV.Location = New System.Drawing.Point(4, 25)
        Me.tbAV.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAV.Name = "tbAV"
        Me.tbAV.Padding = New System.Windows.Forms.Padding(4)
        Me.tbAV.Size = New System.Drawing.Size(903, 407)
        Me.tbAV.TabIndex = 1
        Me.tbAV.Text = "Asignar Videos"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(895, 399)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(4, 84)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(439, 311)
        Me.GroupBox3.TabIndex = 2342332
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Asignar"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dgvVideoBV, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnAsignar, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(431, 288)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'dgvVideoBV
        '
        Me.dgvVideoBV.AllowUserToAddRows = False
        Me.dgvVideoBV.AllowUserToDeleteRows = False
        Me.dgvVideoBV.AllowUserToResizeColumns = False
        Me.dgvVideoBV.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVideoBV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVideoBV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVideoBV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvVideoBV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVideoBV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVideoBV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVideoBV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVideoBV.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVideoBV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVideoBV.Location = New System.Drawing.Point(3, 2)
        Me.dgvVideoBV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvVideoBV.MultiSelect = False
        Me.dgvVideoBV.Name = "dgvVideoBV"
        Me.dgvVideoBV.ReadOnly = True
        Me.dgvVideoBV.RowHeadersVisible = False
        Me.dgvVideoBV.RowHeadersWidth = 62
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.dgvVideoBV.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvVideoBV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvVideoBV.RowTemplate.Height = 28
        Me.dgvVideoBV.RowTemplate.ReadOnly = True
        Me.dgvVideoBV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVideoBV.Size = New System.Drawing.Size(425, 235)
        Me.dgvVideoBV.TabIndex = 2342327
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnAsignar
        '
        Me.btnAsignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAsignar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAsignar.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.ForeColor = System.Drawing.Color.Black
        Me.btnAsignar.Location = New System.Drawing.Point(4, 243)
        Me.btnAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(423, 41)
        Me.btnAsignar.TabIndex = 2342328
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(451, 84)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(440, 311)
        Me.GroupBox4.TabIndex = 2342331
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Asignados"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.dgvVideoAs, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnDesasignar, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(432, 288)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'dgvVideoAs
        '
        Me.dgvVideoAs.AllowUserToAddRows = False
        Me.dgvVideoAs.AllowUserToDeleteRows = False
        Me.dgvVideoAs.AllowUserToResizeColumns = False
        Me.dgvVideoAs.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVideoAs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvVideoAs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVideoAs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvVideoAs.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVideoAs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvVideoAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVideoAs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Seleccionar})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVideoAs.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvVideoAs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVideoAs.Location = New System.Drawing.Point(3, 2)
        Me.dgvVideoAs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvVideoAs.MultiSelect = False
        Me.dgvVideoAs.Name = "dgvVideoAs"
        Me.dgvVideoAs.ReadOnly = True
        Me.dgvVideoAs.RowHeadersVisible = False
        Me.dgvVideoAs.RowHeadersWidth = 62
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        Me.dgvVideoAs.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvVideoAs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvVideoAs.RowTemplate.Height = 28
        Me.dgvVideoAs.RowTemplate.ReadOnly = True
        Me.dgvVideoAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVideoAs.Size = New System.Drawing.Size(426, 235)
        Me.dgvVideoAs.TabIndex = 2342327
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Seleccionar
        '
        Me.Seleccionar.FillWeight = 20.0!
        Me.Seleccionar.HeaderText = ""
        Me.Seleccionar.MinimumWidth = 6
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        Me.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnDesasignar
        '
        Me.btnDesasignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDesasignar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDesasignar.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesasignar.ForeColor = System.Drawing.Color.Black
        Me.btnDesasignar.Location = New System.Drawing.Point(4, 243)
        Me.btnDesasignar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDesasignar.Name = "btnDesasignar"
        Me.btnDesasignar.Size = New System.Drawing.Size(424, 41)
        Me.btnDesasignar.TabIndex = 2342328
        Me.btnDesasignar.Text = "Desasignar"
        Me.btnDesasignar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel4.SetColumnSpan(Me.TableLayoutPanel6, 2)
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.60207!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.39793!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnBuscar, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txtNombreBV, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(887, 72)
        Me.TableLayoutPanel6.TabIndex = 2342330
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(758, 4)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.TableLayoutPanel6.SetRowSpan(Me.btnBuscar, 2)
        Me.btnBuscar.Size = New System.Drawing.Size(125, 64)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 41)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreBV
        '
        Me.txtNombreBV.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtNombreBV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreBV.ForeColor = System.Drawing.Color.White
        Me.txtNombreBV.Location = New System.Drawing.Point(106, 4)
        Me.txtNombreBV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreBV.MaxLength = 48
        Me.txtNombreBV.Name = "txtNombreBV"
        Me.txtNombreBV.Size = New System.Drawing.Size(644, 22)
        Me.txtNombreBV.TabIndex = 3
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.chkFecha, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.dtpFechaBV, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(106, 35)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(644, 33)
        Me.TableLayoutPanel8.TabIndex = 4
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkFecha.Location = New System.Drawing.Point(621, 4)
        Me.chkFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(19, 25)
        Me.chkFecha.TabIndex = 1
        Me.chkFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'dtpFechaBV
        '
        Me.dtpFechaBV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFechaBV.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaBV.Location = New System.Drawing.Point(4, 4)
        Me.dtpFechaBV.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaBV.Name = "dtpFechaBV"
        Me.dtpFechaBV.Size = New System.Drawing.Size(609, 22)
        Me.dtpFechaBV.TabIndex = 0
        '
        'BWBuscador
        '
        '
        'frmSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(911, 436)
        Me.Controls.Add(Me.tcS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(929, 483)
        Me.MinimumSize = New System.Drawing.Size(929, 483)
        Me.Name = "frmSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ver Serie"
        Me.tcS.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvVSM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbAV.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dgvVideoBV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.dgvVideoAs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcS As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnSSalir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSEditar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvVSM As DataGridView
    Friend WithEvents VFecha As DataGridViewTextBoxColumn
    Friend WithEvents VNombre As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTapar As RichTextBox
    Friend WithEvents chbIncluir As CheckBox
    Friend WithEvents dtpFecha As ColorDateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As RichTextBox
    Friend WithEvents tbAV As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreBV As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents dgvVideoBV As DataGridView
    Friend WithEvents btnAsignar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents dgvVideoAs As DataGridView
    Friend WithEvents btnDesasignar As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents chkFecha As CheckBox
    Friend WithEvents dtpFechaBV As ColorDateTimePicker
    Friend WithEvents BWBuscador As System.ComponentModel.BackgroundWorker
End Class
