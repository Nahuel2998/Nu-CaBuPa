<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvento
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
        Me.tcP = New System.Windows.Forms.TabControl()
        Me.tbDatos = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.cbVideo = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.VSerie = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.tbFechas = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mcFecha = New System.Windows.Forms.MonthCalendar()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.dtpYearE = New System.Windows.Forms.DateTimePicker()
        Me.dgvFechas = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnABorrar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.bwFechas = New System.ComponentModel.BackgroundWorker()
        Me.tcP.SuspendLayout()
        Me.tbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbFechas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbBuscar.SuspendLayout()
        CType(Me.dgvFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcP
        '
        Me.tcP.Controls.Add(Me.tbDatos)
        Me.tcP.Controls.Add(Me.tbFechas)
        Me.tcP.Location = New System.Drawing.Point(12, 12)
        Me.tcP.Name = "tcP"
        Me.tcP.SelectedIndex = 0
        Me.tcP.Size = New System.Drawing.Size(498, 348)
        Me.tcP.TabIndex = 5
        '
        'tbDatos
        '
        Me.tbDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbDatos.Controls.Add(Me.GroupBox1)
        Me.tbDatos.Location = New System.Drawing.Point(4, 25)
        Me.tbDatos.Name = "tbDatos"
        Me.tbDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDatos.Size = New System.Drawing.Size(490, 319)
        Me.tbDatos.TabIndex = 0
        Me.tbDatos.Text = "Datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.cbVideo)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.VSerie)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(479, 307)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Location = New System.Drawing.Point(162, 249)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(124, 52)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'cbVideo
        '
        Me.cbVideo.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.cbVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVideo.Enabled = False
        Me.cbVideo.ForeColor = System.Drawing.Color.White
        Me.cbVideo.FormattingEnabled = True
        Me.cbVideo.Location = New System.Drawing.Point(99, 82)
        Me.cbVideo.Name = "cbVideo"
        Me.cbVideo.Size = New System.Drawing.Size(364, 28)
        Me.cbVideo.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(8, 249)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 52)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Location = New System.Drawing.Point(312, 249)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(159, 52)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'VSerie
        '
        Me.VSerie.AutoSize = True
        Me.VSerie.Location = New System.Drawing.Point(8, 85)
        Me.VSerie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VSerie.Name = "VSerie"
        Me.VSerie.Size = New System.Drawing.Size(56, 20)
        Me.VSerie.TabIndex = 9
        Me.VSerie.Text = "Video:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 116)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(463, 127)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(8, 25)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDescripcion.MaxLength = 128
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(447, 96)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(99, 32)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombre.MaxLength = 48
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(364, 27)
        Me.txtNombre.TabIndex = 2
        '
        'tbFechas
        '
        Me.tbFechas.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tbFechas.Controls.Add(Me.GroupBox3)
        Me.tbFechas.Controls.Add(Me.gbBuscar)
        Me.tbFechas.Controls.Add(Me.TableLayoutPanel7)
        Me.tbFechas.Location = New System.Drawing.Point(4, 25)
        Me.tbFechas.Name = "tbFechas"
        Me.tbFechas.Size = New System.Drawing.Size(490, 319)
        Me.tbFechas.TabIndex = 4
        Me.tbFechas.Text = "Agendar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mcFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 255)
        Me.GroupBox3.TabIndex = 28876930
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agendar"
        '
        'mcFecha
        '
        Me.mcFecha.Location = New System.Drawing.Point(12, 30)
        Me.mcFecha.Name = "mcFecha"
        Me.mcFecha.TabIndex = 3
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.dtpYearE)
        Me.gbBuscar.Controls.Add(Me.dgvFechas)
        Me.gbBuscar.Location = New System.Drawing.Point(257, 4)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(230, 255)
        Me.gbBuscar.TabIndex = 28876929
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscar"
        '
        'dtpYearE
        '
        Me.dtpYearE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpYearE.CustomFormat = "yyyy"
        Me.dtpYearE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearE.Location = New System.Drawing.Point(135, 16)
        Me.dtpYearE.Name = "dtpYearE"
        Me.dtpYearE.ShowUpDown = True
        Me.dtpYearE.Size = New System.Drawing.Size(89, 22)
        Me.dtpYearE.TabIndex = 28876930
        '
        'dgvFechas
        '
        Me.dgvFechas.AllowUserToAddRows = False
        Me.dgvFechas.AllowUserToDeleteRows = False
        Me.dgvFechas.AllowUserToResizeColumns = False
        Me.dgvFechas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvFechas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFechas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvFechas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFechas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.PFEliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFechas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFechas.Location = New System.Drawing.Point(5, 47)
        Me.dgvFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvFechas.MultiSelect = False
        Me.dgvFechas.Name = "dgvFechas"
        Me.dgvFechas.ReadOnly = True
        Me.dgvFechas.RowHeadersVisible = False
        Me.dgvFechas.RowHeadersWidth = 62
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvFechas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFechas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvFechas.RowTemplate.Height = 28
        Me.dgvFechas.RowTemplate.ReadOnly = True
        Me.dgvFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFechas.Size = New System.Drawing.Size(220, 195)
        Me.dgvFechas.TabIndex = 28876927
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 8
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'PFEliminar
        '
        Me.PFEliminar.HeaderText = "Eliminar"
        Me.PFEliminar.MinimumWidth = 8
        Me.PFEliminar.Name = "PFEliminar"
        Me.PFEliminar.ReadOnly = True
        Me.PFEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PFEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnABorrar, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnAnadir, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 264)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(484, 50)
        Me.TableLayoutPanel7.TabIndex = 28876926
        '
        'btnABorrar
        '
        Me.btnABorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnABorrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnABorrar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnABorrar.ForeColor = System.Drawing.Color.Black
        Me.btnABorrar.Location = New System.Drawing.Point(256, 4)
        Me.btnABorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnABorrar.MinimumSize = New System.Drawing.Size(120, 15)
        Me.btnABorrar.Name = "btnABorrar"
        Me.btnABorrar.Size = New System.Drawing.Size(224, 42)
        Me.btnABorrar.TabIndex = 2
        Me.btnABorrar.Text = "Borrar"
        Me.btnABorrar.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAnadir.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnAnadir.ForeColor = System.Drawing.Color.Black
        Me.btnAnadir.Location = New System.Drawing.Point(4, 4)
        Me.btnAnadir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnadir.MinimumSize = New System.Drawing.Size(120, 15)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(244, 42)
        Me.btnAnadir.TabIndex = 1
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'bwFechas
        '
        '
        'frmEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 369)
        Me.Controls.Add(Me.tcP)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEvento"
        Me.Text = "Eventos"
        Me.tcP.ResumeLayout(False)
        Me.tbDatos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbFechas.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.gbBuscar.ResumeLayout(False)
        CType(Me.dgvFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcP As TabControl
    Friend WithEvents tbDatos As TabPage
    Friend WithEvents tbFechas As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents dgvFechas As DataGridView
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnABorrar As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents cbVideo As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents VSerie As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dtpYearE As DateTimePicker
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents PFEliminar As DataGridViewCheckBoxColumn
    Friend WithEvents mcFecha As MonthCalendar
    Friend WithEvents bwFechas As System.ComponentModel.BackgroundWorker
End Class
