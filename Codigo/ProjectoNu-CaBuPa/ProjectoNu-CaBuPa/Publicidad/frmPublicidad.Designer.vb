<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPublicidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBorrrT = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.dgvFechas = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTanda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFF = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.dtpFI = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBPubli = New System.Windows.Forms.Button()
        Me.dgvTE = New System.Windows.Forms.DataGridView()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tbProgramas = New System.Windows.Forms.TabPage()
        Me.dgvProgramaP = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbPrograma = New System.Windows.Forms.ComboBox()
        Me.btnPrograma = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBorrarP = New System.Windows.Forms.Button()
        Me.btnIngresarP = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFFP = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.dtpFIP = New ProjectoNu_CaBuPa.ColorDateTimePicker()
        Me.bwDatos = New System.ComponentModel.BackgroundWorker()
        Me.gbNotas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tcP.SuspendLayout()
        Me.tbDatos.SuspendLayout()
        Me.tbTandas.SuspendLayout()
        CType(Me.dgvFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbProgramas.SuspendLayout()
        CType(Me.dgvProgramaP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tcP.Controls.Add(Me.TabPage1)
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
        Me.tbTandas.Controls.Add(Me.Label4)
        Me.tbTandas.Controls.Add(Me.btnBorrrT)
        Me.tbTandas.Controls.Add(Me.btnIngresar)
        Me.tbTandas.Controls.Add(Me.dgvFechas)
        Me.tbTandas.Controls.Add(Me.Label3)
        Me.tbTandas.Controls.Add(Me.Label2)
        Me.tbTandas.Controls.Add(Me.cbTanda)
        Me.tbTandas.Controls.Add(Me.Label1)
        Me.tbTandas.Controls.Add(Me.dtpFF)
        Me.tbTandas.Controls.Add(Me.dtpFI)
        Me.tbTandas.Location = New System.Drawing.Point(4, 27)
        Me.tbTandas.Name = "tbTandas"
        Me.tbTandas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTandas.Size = New System.Drawing.Size(418, 372)
        Me.tbTandas.TabIndex = 1
        Me.tbTandas.Text = "Tandas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Agenda"
        '
        'btnBorrrT
        '
        Me.btnBorrrT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrrT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrrT.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrrT.ForeColor = System.Drawing.Color.Black
        Me.btnBorrrT.Location = New System.Drawing.Point(6, 317)
        Me.btnBorrrT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrrT.Name = "btnBorrrT"
        Me.btnBorrrT.Size = New System.Drawing.Size(131, 48)
        Me.btnBorrrT.TabIndex = 8
        Me.btnBorrrT.Text = "Borrar"
        Me.btnBorrrT.UseVisualStyleBackColor = False
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
        'dgvFechas
        '
        Me.dgvFechas.AllowUserToAddRows = False
        Me.dgvFechas.AllowUserToDeleteRows = False
        Me.dgvFechas.AllowUserToResizeColumns = False
        Me.dgvFechas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvFechas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFechas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.descrip})
        Me.dgvFechas.Location = New System.Drawing.Point(7, 182)
        Me.dgvFechas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFechas.MultiSelect = False
        Me.dgvFechas.Name = "dgvFechas"
        Me.dgvFechas.ReadOnly = True
        Me.dgvFechas.RowHeadersVisible = False
        Me.dgvFechas.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvFechas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFechas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFechas.Size = New System.Drawing.Size(404, 127)
        Me.dgvFechas.TabIndex = 6
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
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanda"
        '
        'dtpFF
        '
        Me.dtpFF.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFF.Location = New System.Drawing.Point(212, 113)
        Me.dtpFF.Name = "dtpFF"
        Me.dtpFF.Size = New System.Drawing.Size(200, 27)
        Me.dtpFF.TabIndex = 3
        '
        'dtpFI
        '
        Me.dtpFI.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFI.Location = New System.Drawing.Point(6, 113)
        Me.dtpFI.Name = "dtpFI"
        Me.dtpFI.Size = New System.Drawing.Size(200, 27)
        Me.dtpFI.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnBPubli)
        Me.TabPage1.Controls.Add(Me.dgvTE)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(418, 372)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Tandas Eliminadas"
        '
        'btnBPubli
        '
        Me.btnBPubli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBPubli.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBPubli.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBPubli.ForeColor = System.Drawing.Color.Black
        Me.btnBPubli.Location = New System.Drawing.Point(7, 313)
        Me.btnBPubli.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBPubli.Name = "btnBPubli"
        Me.btnBPubli.Size = New System.Drawing.Size(404, 55)
        Me.btnBPubli.TabIndex = 9
        Me.btnBPubli.Text = "Borrar"
        Me.btnBPubli.UseVisualStyleBackColor = False
        '
        'dgvTE
        '
        Me.dgvTE.AllowUserToAddRows = False
        Me.dgvTE.AllowUserToDeleteRows = False
        Me.dgvTE.AllowUserToResizeColumns = False
        Me.dgvTE.AllowUserToResizeRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvTE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTE.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hora, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.TEliminar})
        Me.dgvTE.Location = New System.Drawing.Point(7, 4)
        Me.dgvTE.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTE.MultiSelect = False
        Me.dgvTE.Name = "dgvTE"
        Me.dgvTE.ReadOnly = True
        Me.dgvTE.RowHeadersVisible = False
        Me.dgvTE.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvTE.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTE.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTE.Size = New System.Drawing.Size(404, 301)
        Me.dgvTE.TabIndex = 7
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora de tanda"
        Me.Hora.MinimumWidth = 6
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Finalización"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TEliminar
        '
        Me.TEliminar.HeaderText = "Eliminar"
        Me.TEliminar.MinimumWidth = 6
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.ReadOnly = True
        '
        'tbProgramas
        '
        Me.tbProgramas.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbProgramas.Controls.Add(Me.dgvProgramaP)
        Me.tbProgramas.Controls.Add(Me.Label10)
        Me.tbProgramas.Controls.Add(Me.cbPrograma)
        Me.tbProgramas.Controls.Add(Me.btnPrograma)
        Me.tbProgramas.Controls.Add(Me.Label9)
        Me.tbProgramas.Controls.Add(Me.txtNombreP)
        Me.tbProgramas.Controls.Add(Me.Label5)
        Me.tbProgramas.Controls.Add(Me.btnBorrarP)
        Me.tbProgramas.Controls.Add(Me.btnIngresarP)
        Me.tbProgramas.Controls.Add(Me.Label6)
        Me.tbProgramas.Controls.Add(Me.Label7)
        Me.tbProgramas.Controls.Add(Me.Label8)
        Me.tbProgramas.Controls.Add(Me.dtpFFP)
        Me.tbProgramas.Controls.Add(Me.dtpFIP)
        Me.tbProgramas.Location = New System.Drawing.Point(4, 27)
        Me.tbProgramas.Name = "tbProgramas"
        Me.tbProgramas.Size = New System.Drawing.Size(418, 372)
        Me.tbProgramas.TabIndex = 2
        Me.tbProgramas.Text = "Programas"
        '
        'dgvProgramaP
        '
        Me.dgvProgramaP.AllowUserToAddRows = False
        Me.dgvProgramaP.AllowUserToDeleteRows = False
        Me.dgvProgramaP.AllowUserToResizeColumns = False
        Me.dgvProgramaP.AllowUserToResizeRows = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvProgramaP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProgramaP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProgramaP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProgramaP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvProgramaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramaP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvProgramaP.Location = New System.Drawing.Point(6, 197)
        Me.dgvProgramaP.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProgramaP.MultiSelect = False
        Me.dgvProgramaP.Name = "dgvProgramaP"
        Me.dgvProgramaP.ReadOnly = True
        Me.dgvProgramaP.RowHeadersVisible = False
        Me.dgvProgramaP.RowHeadersWidth = 51
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvProgramaP.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProgramaP.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvProgramaP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProgramaP.Size = New System.Drawing.Size(404, 109)
        Me.dgvProgramaP.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Finalización"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Programa"
        '
        'cbPrograma
        '
        Me.cbPrograma.BackColor = System.Drawing.SystemColors.Window
        Me.cbPrograma.FormattingEnabled = True
        Me.cbPrograma.Location = New System.Drawing.Point(99, 80)
        Me.cbPrograma.Name = "cbPrograma"
        Me.cbPrograma.Size = New System.Drawing.Size(207, 26)
        Me.cbPrograma.TabIndex = 23
        '
        'btnPrograma
        '
        Me.btnPrograma.Location = New System.Drawing.Point(324, 48)
        Me.btnPrograma.Name = "btnPrograma"
        Me.btnPrograma.Size = New System.Drawing.Size(87, 27)
        Me.btnPrograma.TabIndex = 22
        Me.btnPrograma.Text = "Buscar"
        Me.btnPrograma.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Nombre"
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(75, 47)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(243, 27)
        Me.txtNombreP.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Agenda"
        '
        'btnBorrarP
        '
        Me.btnBorrarP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrarP.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrarP.ForeColor = System.Drawing.Color.Black
        Me.btnBorrarP.Location = New System.Drawing.Point(6, 314)
        Me.btnBorrarP.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrarP.Name = "btnBorrarP"
        Me.btnBorrarP.Size = New System.Drawing.Size(131, 48)
        Me.btnBorrarP.TabIndex = 18
        Me.btnBorrarP.Text = "Borrar"
        Me.btnBorrarP.UseVisualStyleBackColor = False
        '
        'btnIngresarP
        '
        Me.btnIngresarP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngresarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresarP.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnIngresarP.ForeColor = System.Drawing.Color.Black
        Me.btnIngresarP.Location = New System.Drawing.Point(283, 314)
        Me.btnIngresarP.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresarP.Name = "btnIngresarP"
        Me.btnIngresarP.Size = New System.Drawing.Size(128, 48)
        Me.btnIngresarP.TabIndex = 17
        Me.btnIngresarP.Text = "Ingresar"
        Me.btnIngresarP.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Fecha final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fecha inicial"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Programa"
        '
        'dtpFFP
        '
        Me.dtpFFP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFFP.Location = New System.Drawing.Point(210, 145)
        Me.dtpFFP.Name = "dtpFFP"
        Me.dtpFFP.Size = New System.Drawing.Size(200, 27)
        Me.dtpFFP.TabIndex = 13
        '
        'dtpFIP
        '
        Me.dtpFIP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFIP.Location = New System.Drawing.Point(4, 145)
        Me.dtpFIP.Name = "dtpFIP"
        Me.dtpFIP.Size = New System.Drawing.Size(200, 27)
        Me.dtpFIP.TabIndex = 12
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Publicidad"
        Me.gbNotas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tcP.ResumeLayout(False)
        Me.tbDatos.ResumeLayout(False)
        Me.tbTandas.ResumeLayout(False)
        Me.tbTandas.PerformLayout()
        CType(Me.dgvFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbProgramas.ResumeLayout(False)
        Me.tbProgramas.PerformLayout()
        CType(Me.dgvProgramaP, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFF As ColorDateTimePicker
    Friend WithEvents dtpFI As ColorDateTimePicker
    Friend WithEvents cbTanda As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFechas As DataGridView
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnBorrrT As Button
    Friend WithEvents cbEmpresa As ComboBox
    Friend WithEvents bwDatos As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents descrip As DataGridViewTextBoxColumn
    Friend WithEvents btnPrograma As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBorrarP As Button
    Friend WithEvents btnIngresarP As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpFFP As ColorDateTimePicker
    Friend WithEvents dtpFIP As ColorDateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbPrograma As ComboBox
    Friend WithEvents dgvProgramaP As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvTE As DataGridView
    Friend WithEvents btnBPubli As Button
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TEliminar As DataGridViewCheckBoxColumn
End Class
