<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pMain = New System.Windows.Forms.TableLayoutPanel()
        Me.spNotEven = New System.Windows.Forms.TableLayoutPanel()
        Me.gbNotas = New System.Windows.Forms.GroupBox()
        Me.TBNotas = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbTandas = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tcSecciones = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.dgvPrograma = New System.Windows.Forms.DataGridView()
        Me.Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Programa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBFuncionarios = New System.Windows.Forms.GroupBox()
        Me.GBFuncionario = New System.Windows.Forms.GroupBox()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.GBDEscripcion = New System.Windows.Forms.GroupBox()
        Me.TBDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvVideo = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pCMain = New System.Windows.Forms.Panel()
        Me.BWProgramas = New System.ComponentModel.BackgroundWorker()
        Me.BWDPRogramas = New System.ComponentModel.BackgroundWorker()
        Me.pMain.SuspendLayout()
        Me.spNotEven.SuspendLayout()
        Me.gbNotas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbTandas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcSecciones.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFuncionarios.SuspendLayout()
        Me.GBFuncionario.SuspendLayout()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDEscripcion.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pStatus.SuspendLayout()
        Me.pCMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMain
        '
        resources.ApplyResources(Me.pMain, "pMain")
        Me.pMain.Controls.Add(Me.spNotEven, 2, 0)
        Me.pMain.Controls.Add(Me.Panel2, 0, 0)
        Me.pMain.Controls.Add(Me.tcSecciones, 1, 0)
        Me.pMain.Name = "pMain"
        '
        'spNotEven
        '
        resources.ApplyResources(Me.spNotEven, "spNotEven")
        Me.spNotEven.Controls.Add(Me.gbNotas, 0, 1)
        Me.spNotEven.Name = "spNotEven"
        '
        'gbNotas
        '
        resources.ApplyResources(Me.gbNotas, "gbNotas")
        Me.gbNotas.Controls.Add(Me.TBNotas)
        Me.gbNotas.Name = "gbNotas"
        Me.gbNotas.TabStop = False
        '
        'TBNotas
        '
        resources.ApplyResources(Me.TBNotas, "TBNotas")
        Me.TBNotas.Name = "TBNotas"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.gbTandas)
        Me.Panel2.Name = "Panel2"
        '
        'gbTandas
        '
        resources.ApplyResources(Me.gbTandas, "gbTandas")
        Me.gbTandas.Controls.Add(Me.DataGridView1)
        Me.gbTandas.Name = "gbTandas"
        Me.gbTandas.TabStop = False
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        '
        'tcSecciones
        '
        resources.ApplyResources(Me.tcSecciones, "tcSecciones")
        Me.tcSecciones.Controls.Add(Me.TabPage1)
        Me.tcSecciones.Controls.Add(Me.TabPage2)
        Me.tcSecciones.Name = "tcSecciones"
        Me.tcSecciones.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GBFuncionarios, 1, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.dgvPrograma)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'dtp
        '
        resources.ApplyResources(Me.dtp, "dtp")
        Me.dtp.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dtp.CalendarMonthBackground = System.Drawing.SystemColors.MenuText
        Me.dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtp.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dtp.Name = "dtp"
        '
        'dgvPrograma
        '
        Me.dgvPrograma.AllowUserToAddRows = False
        Me.dgvPrograma.AllowUserToDeleteRows = False
        Me.dgvPrograma.AllowUserToResizeColumns = False
        Me.dgvPrograma.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aquamarine
        Me.dgvPrograma.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgvPrograma, "dgvPrograma")
        Me.dgvPrograma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrograma.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Plum
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrograma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Inicio, Me.Final, Me.Programa})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrograma.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPrograma.MultiSelect = False
        Me.dgvPrograma.Name = "dgvPrograma"
        Me.dgvPrograma.ReadOnly = True
        Me.dgvPrograma.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvPrograma.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPrograma.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvPrograma.RowTemplate.Height = 28
        Me.dgvPrograma.RowTemplate.ReadOnly = True
        Me.dgvPrograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Inicio
        '
        resources.ApplyResources(Me.Inicio, "Inicio")
        Me.Inicio.Name = "Inicio"
        Me.Inicio.ReadOnly = True
        '
        'Final
        '
        resources.ApplyResources(Me.Final, "Final")
        Me.Final.Name = "Final"
        Me.Final.ReadOnly = True
        '
        'Programa
        '
        resources.ApplyResources(Me.Programa, "Programa")
        Me.Programa.Name = "Programa"
        Me.Programa.ReadOnly = True
        '
        'GBFuncionarios
        '
        resources.ApplyResources(Me.GBFuncionarios, "GBFuncionarios")
        Me.GBFuncionarios.Controls.Add(Me.GBFuncionario)
        Me.GBFuncionarios.Controls.Add(Me.GBDEscripcion)
        Me.GBFuncionarios.Name = "GBFuncionarios"
        Me.GBFuncionarios.TabStop = False
        '
        'GBFuncionario
        '
        resources.ApplyResources(Me.GBFuncionario, "GBFuncionario")
        Me.GBFuncionario.Controls.Add(Me.dgvFuncionarios)
        Me.GBFuncionario.Name = "GBFuncionario"
        Me.GBFuncionario.TabStop = False
        '
        'dgvFuncionarios
        '
        Me.dgvFuncionarios.AllowUserToAddRows = False
        Me.dgvFuncionarios.AllowUserToDeleteRows = False
        Me.dgvFuncionarios.AllowUserToResizeColumns = False
        Me.dgvFuncionarios.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Aquamarine
        Me.dgvFuncionarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.dgvFuncionarios, "dgvFuncionarios")
        Me.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Plum
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFuncionarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFuncionarios.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFuncionarios.MultiSelect = False
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.ReadOnly = True
        Me.dgvFuncionarios.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.dgvFuncionarios.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvFuncionarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvFuncionarios.RowTemplate.Height = 28
        Me.dgvFuncionarios.RowTemplate.ReadOnly = True
        Me.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'GBDEscripcion
        '
        resources.ApplyResources(Me.GBDEscripcion, "GBDEscripcion")
        Me.GBDEscripcion.Controls.Add(Me.TBDescripcion)
        Me.GBDEscripcion.Name = "GBDEscripcion"
        Me.GBDEscripcion.TabStop = False
        '
        'TBDescripcion
        '
        resources.ApplyResources(Me.TBDescripcion, "TBDescripcion")
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl1)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Name = "Label3"
        '
        'TextBox3
        '
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        '
        'DateTimePicker1
        '
        resources.ApplyResources(Me.DateTimePicker1, "DateTimePicker1")
        Me.DateTimePicker1.Name = "DateTimePicker1"
        '
        'GroupBox6
        '
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Name = "Label1"
        '
        'TextBox5
        '
        resources.ApplyResources(Me.TextBox5, "TextBox5")
        Me.TextBox5.Name = "TextBox5"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.dgvVideo)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'dgvVideo
        '
        Me.dgvVideo.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvVideo, "dgvVideo")
        Me.dgvVideo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVideo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Fecha, Me.Serie})
        Me.dgvVideo.MultiSelect = False
        Me.dgvVideo.Name = "dgvVideo"
        Me.dgvVideo.RowHeadersVisible = False
        '
        'Nombre
        '
        resources.ApplyResources(Me.Nombre, "Nombre")
        Me.Nombre.Name = "Nombre"
        '
        'Fecha
        '
        resources.ApplyResources(Me.Fecha, "Fecha")
        Me.Fecha.Name = "Fecha"
        '
        'Serie
        '
        resources.ApplyResources(Me.Serie, "Serie")
        Me.Serie.Name = "Serie"
        '
        'TabPage4
        '
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'pStatus
        '
        resources.ApplyResources(Me.pStatus, "pStatus")
        Me.pStatus.BackColor = System.Drawing.SystemColors.Highlight
        Me.pStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pStatus.Controls.Add(Me.lblStatus)
        Me.pStatus.Name = "pStatus"
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStatus.Name = "lblStatus"
        '
        'pCMain
        '
        resources.ApplyResources(Me.pCMain, "pCMain")
        Me.pCMain.Controls.Add(Me.pMain)
        Me.pCMain.Controls.Add(Me.pStatus)
        Me.pCMain.Name = "pCMain"
        '
        'BWProgramas
        '
        '
        'BWDPRogramas
        '
        '
        'frmPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.pCMain)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrincipal"
        Me.pMain.ResumeLayout(False)
        Me.spNotEven.ResumeLayout(False)
        Me.gbNotas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.gbTandas.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcSecciones.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFuncionarios.ResumeLayout(False)
        Me.GBFuncionario.ResumeLayout(False)
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDEscripcion.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatus.ResumeLayout(False)
        Me.pCMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMain As TableLayoutPanel
    Friend WithEvents pStatus As Panel
    Friend WithEvents spNotEven As TableLayoutPanel
    Friend WithEvents pCMain As Panel
    Friend WithEvents tcSecciones As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbNotas As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GBFuncionarios As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BWProgramas As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As Label
    Friend WithEvents gbTandas As GroupBox
    Friend WithEvents dgvPrograma As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvVideo As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Serie As DataGridViewTextBoxColumn
    Friend WithEvents BWDPRogramas As System.ComponentModel.BackgroundWorker
    Friend WithEvents TBNotas As RichTextBox
    Friend WithEvents GBFuncionario As GroupBox
    Friend WithEvents dgvFuncionarios As DataGridView
    Friend WithEvents GBDEscripcion As GroupBox
    Friend WithEvents TBDescripcion As RichTextBox
    Friend WithEvents Inicio As DataGridViewTextBoxColumn
    Friend WithEvents Final As DataGridViewTextBoxColumn
    Friend WithEvents Programa As DataGridViewTextBoxColumn
End Class
