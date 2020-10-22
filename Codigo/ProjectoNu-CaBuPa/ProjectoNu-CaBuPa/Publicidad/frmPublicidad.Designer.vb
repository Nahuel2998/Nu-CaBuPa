<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublicidad
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbNotas = New System.Windows.Forms.GroupBox()
        Me.txtTema = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.RichTextBox()
        Me.tcP = New System.Windows.Forms.TabControl()
        Me.tbDatos = New System.Windows.Forms.TabPage()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.tbTandas = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTanda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDateTimePicker2 = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.ColorDateTimePicker1 = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.tbProgramas = New System.Windows.Forms.TabPage()
        Me.GBPubli = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtp = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bwDatos = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.gbNotas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tcP.SuspendLayout()
        Me.tbDatos.SuspendLayout()
        Me.tbTandas.SuspendLayout()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbProgramas.SuspendLayout()
        Me.GBPubli.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbNotas
        '
        Me.gbNotas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbNotas.Controls.Add(Me.txtTema)
        Me.gbNotas.Location = New System.Drawing.Point(6, 156)
        Me.gbNotas.Name = "gbNotas"
        Me.gbNotas.Size = New System.Drawing.Size(404, 169)
        Me.gbNotas.TabIndex = 2
        Me.gbNotas.TabStop = False
        Me.gbNotas.Text = "Tema"
        '
        'txtTema
        '
        Me.txtTema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTema.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTema.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTema.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtTema.ForeColor = System.Drawing.Color.White
        Me.txtTema.Location = New System.Drawing.Point(7, 22)
        Me.txtTema.MaxLength = 64
        Me.txtTema.Name = "txtTema"
        Me.txtTema.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtTema.Size = New System.Drawing.Size(388, 141)
        Me.txtTema.TabIndex = 1
        Me.txtTema.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbEmpresa)
        Me.GroupBox2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.cbEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.Enabled = False
        Me.cbEmpresa.ForeColor = System.Drawing.Color.White
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(7, 30)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(388, 29)
        Me.cbEmpresa.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(7, 340)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 26)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Location = New System.Drawing.Point(317, 340)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 26)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 68)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(7, 26)
        Me.txtNombre.MaxLength = 64
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtNombre.Size = New System.Drawing.Size(389, 36)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'tcP
        '
        Me.tcP.Controls.Add(Me.tbDatos)
        Me.tcP.Controls.Add(Me.tbTandas)
        Me.tcP.Controls.Add(Me.tbProgramas)
        Me.tcP.Location = New System.Drawing.Point(12, 12)
        Me.tcP.Name = "tcP"
        Me.tcP.SelectedIndex = 0
        Me.tcP.Size = New System.Drawing.Size(426, 403)
        Me.tcP.TabIndex = 17
        '
        'tbDatos
        '
        Me.tbDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbDatos.Controls.Add(Me.btnBorrar)
        Me.tbDatos.Controls.Add(Me.GroupBox1)
        Me.tbDatos.Controls.Add(Me.GroupBox2)
        Me.tbDatos.Controls.Add(Me.gbNotas)
        Me.tbDatos.Controls.Add(Me.btnSalir)
        Me.tbDatos.Controls.Add(Me.btnEditar)
        Me.tbDatos.Location = New System.Drawing.Point(4, 27)
        Me.tbDatos.Name = "tbDatos"
        Me.tbDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDatos.Size = New System.Drawing.Size(418, 372)
        Me.tbDatos.TabIndex = 0
        Me.tbDatos.Text = "Datos"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Location = New System.Drawing.Point(156, 340)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(94, 26)
        Me.btnBorrar.TabIndex = 18
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'tbTandas
        '
        Me.tbTandas.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbTandas.Controls.Add(Me.Button3)
        Me.tbTandas.Controls.Add(Me.btnIngresar)
        Me.tbTandas.Controls.Add(Me.dgvFuncionarios)
        Me.tbTandas.Controls.Add(Me.Label3)
        Me.tbTandas.Controls.Add(Me.Label2)
        Me.tbTandas.Controls.Add(Me.cbTanda)
        Me.tbTandas.Controls.Add(Me.Label1)
        Me.tbTandas.Controls.Add(Me.ColorDateTimePicker2)
        Me.tbTandas.Controls.Add(Me.ColorDateTimePicker1)
        Me.tbTandas.Location = New System.Drawing.Point(4, 27)
        Me.tbTandas.Name = "tbTandas"
        Me.tbTandas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTandas.Size = New System.Drawing.Size(418, 372)
        Me.tbTandas.TabIndex = 1
        Me.tbTandas.Text = "Tandas"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(6, 317)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 48)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnIngresar.ForeColor = System.Drawing.Color.Black
        Me.btnIngresar.Location = New System.Drawing.Point(283, 317)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(128, 48)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'dgvFuncionarios
        '
        Me.dgvFuncionarios.AllowUserToAddRows = False
        Me.dgvFuncionarios.AllowUserToDeleteRows = False
        Me.dgvFuncionarios.AllowUserToResizeColumns = False
        Me.dgvFuncionarios.AllowUserToResizeRows = False
        Me.dgvFuncionarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.descrip})
        Me.dgvFuncionarios.Location = New System.Drawing.Point(7, 161)
        Me.dgvFuncionarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFuncionarios.MultiSelect = False
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.ReadOnly = True
        Me.dgvFuncionarios.RowHeadersVisible = False
        Me.dgvFuncionarios.RowHeadersWidth = 51
        Me.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionarios.Size = New System.Drawing.Size(404, 148)
        Me.dgvFuncionarios.TabIndex = 6
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Fecha Inicio"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'descrip
        '
        Me.descrip.HeaderText = "Fecha Finalización"
        Me.descrip.MinimumWidth = 6
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha inicial"
        '
        'cbTanda
        '
        Me.cbTanda.BackColor = System.Drawing.SystemColors.Window
        Me.cbTanda.FormattingEnabled = True
        Me.cbTanda.Location = New System.Drawing.Point(113, 47)
        Me.cbTanda.Name = "cbTanda"
        Me.cbTanda.Size = New System.Drawing.Size(207, 26)
        Me.cbTanda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanda"
        '
        'ColorDateTimePicker2
        '
        Me.ColorDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.ColorDateTimePicker2.Location = New System.Drawing.Point(212, 127)
        Me.ColorDateTimePicker2.Name = "ColorDateTimePicker2"
        Me.ColorDateTimePicker2.Size = New System.Drawing.Size(200, 27)
        Me.ColorDateTimePicker2.TabIndex = 3
        '
        'ColorDateTimePicker1
        '
        Me.ColorDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.ColorDateTimePicker1.Location = New System.Drawing.Point(6, 127)
        Me.ColorDateTimePicker1.Name = "ColorDateTimePicker1"
        Me.ColorDateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.ColorDateTimePicker1.TabIndex = 2
        '
        'tbProgramas
        '
        Me.tbProgramas.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbProgramas.Controls.Add(Me.GBPubli)
        Me.tbProgramas.Location = New System.Drawing.Point(4, 27)
        Me.tbProgramas.Name = "tbProgramas"
        Me.tbProgramas.Size = New System.Drawing.Size(418, 372)
        Me.tbProgramas.TabIndex = 2
        Me.tbProgramas.Text = "Programas"
        '
        'GBPubli
        '
        Me.GBPubli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBPubli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GBPubli.Controls.Add(Me.TableLayoutPanel5)
        Me.GBPubli.Controls.Add(Me.dtp)
        Me.GBPubli.Controls.Add(Me.DataGridView1)
        Me.GBPubli.Location = New System.Drawing.Point(2, 2)
        Me.GBPubli.Margin = New System.Windows.Forms.Padding(2)
        Me.GBPubli.Name = "GBPubli"
        Me.GBPubli.Padding = New System.Windows.Forms.Padding(2)
        Me.GBPubli.Size = New System.Drawing.Size(414, 368)
        Me.GBPubli.TabIndex = 3
        Me.GBPubli.TabStop = False
        Me.GBPubli.Text = "Publicidades"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 258)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(635, 50)
        Me.TableLayoutPanel5.TabIndex = 28876926
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Button1.Location = New System.Drawing.Point(318, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.MinimumSize = New System.Drawing.Size(120, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Button2.Location = New System.Drawing.Point(4, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.MinimumSize = New System.Drawing.Size(120, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Añadir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp.Location = New System.Drawing.Point(13, 28)
        Me.dtp.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(387, 27)
        Me.dtp.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNombre, Me.DataGridViewTextBoxColumn1, Me.PEliminar})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.Location = New System.Drawing.Point(13, 56)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(387, 251)
        Me.DataGridView1.TabIndex = 1
        '
        'PNombre
        '
        Me.PNombre.HeaderText = "Nombre"
        Me.PNombre.MinimumWidth = 6
        Me.PNombre.Name = "PNombre"
        Me.PNombre.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PEliminar
        '
        Me.PEliminar.FillWeight = 40.0!
        Me.PEliminar.HeaderText = "Eliminar"
        Me.PEliminar.MinimumWidth = 6
        Me.PEliminar.Name = "PEliminar"
        Me.PEliminar.ReadOnly = True
        Me.PEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'bwDatos
        '
        '
        'frmPublicidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 427)
        Me.Controls.Add(Me.tcP)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPublicidad"
        Me.Text = "Publicidad"
        Me.gbNotas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tcP.ResumeLayout(False)
        Me.tbDatos.ResumeLayout(False)
        Me.tbTandas.ResumeLayout(False)
        Me.tbTandas.PerformLayout()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbProgramas.ResumeLayout(False)
        Me.GBPubli.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbNotas As GroupBox
    Friend WithEvents txtTema As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As RichTextBox
    Friend WithEvents tcP As TabControl
    Friend WithEvents tbDatos As TabPage
    Friend WithEvents btnBorrar As Button
    Friend WithEvents tbTandas As TabPage
    Friend WithEvents tbProgramas As TabPage
    Friend WithEvents GBPubli As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dtp As ColorDateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PNombre As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PEliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColorDateTimePicker2 As ColorDateTimePicker
    Friend WithEvents ColorDateTimePicker1 As ColorDateTimePicker
    Friend WithEvents cbTanda As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFuncionarios As DataGridView
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents descrip As DataGridViewTextBoxColumn
    Friend WithEvents cbEmpresa As ComboBox
    Friend WithEvents bwDatos As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
