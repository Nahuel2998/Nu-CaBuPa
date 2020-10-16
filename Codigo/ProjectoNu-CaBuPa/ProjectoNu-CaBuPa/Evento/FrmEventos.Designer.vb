<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEventos
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEventoVideo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEventoF = New System.Windows.Forms.DateTimePicker()
        Me.txtProgEvento = New System.Windows.Forms.TextBox()
        Me.txtdescripevento = New System.Windows.Forms.TextBox()
        Me.txtnombreevento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvEvento = New System.Windows.Forms.DataGridView()
        Me.nombreEven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripeven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programaEven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.videoEven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBorrarEv = New System.Windows.Forms.Button()
        Me.btnAñadirEv = New System.Windows.Forms.Button()
        Me.btnBuscarEv = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.11917!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.88083!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(506, 386)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtEventoVideo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpEventoF)
        Me.GroupBox1.Controls.Add(Me.txtProgEvento)
        Me.GroupBox1.Controls.Add(Me.txtdescripevento)
        Me.GroupBox1.Controls.Add(Me.txtnombreevento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txtEventoVideo
        '
        Me.txtEventoVideo.Location = New System.Drawing.Point(337, 89)
        Me.txtEventoVideo.Name = "txtEventoVideo"
        Me.txtEventoVideo.Size = New System.Drawing.Size(137, 20)
        Me.txtEventoVideo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(289, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Video"
        '
        'dtpEventoF
        '
        Me.dtpEventoF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventoF.Location = New System.Drawing.Point(337, 21)
        Me.dtpEventoF.Name = "dtpEventoF"
        Me.dtpEventoF.Size = New System.Drawing.Size(137, 20)
        Me.dtpEventoF.TabIndex = 7
        '
        'txtProgEvento
        '
        Me.txtProgEvento.Location = New System.Drawing.Point(337, 57)
        Me.txtProgEvento.Name = "txtProgEvento"
        Me.txtProgEvento.Size = New System.Drawing.Size(137, 20)
        Me.txtProgEvento.TabIndex = 6
        '
        'txtdescripevento
        '
        Me.txtdescripevento.Location = New System.Drawing.Point(101, 57)
        Me.txtdescripevento.Multiline = True
        Me.txtdescripevento.Name = "txtdescripevento"
        Me.txtdescripevento.Size = New System.Drawing.Size(131, 52)
        Me.txtdescripevento.TabIndex = 5
        '
        'txtnombreevento
        '
        Me.txtnombreevento.Location = New System.Drawing.Point(101, 16)
        Me.txtnombreevento.Name = "txtnombreevento"
        Me.txtnombreevento.Size = New System.Drawing.Size(131, 20)
        Me.txtnombreevento.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(268, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Programa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(279, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvEvento)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgvEvento
        '
        Me.dgvEvento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEvento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreEven, Me.descripeven, Me.fechaEven, Me.programaEven, Me.videoEven})
        Me.dgvEvento.Location = New System.Drawing.Point(6, 9)
        Me.dgvEvento.Name = "dgvEvento"
        Me.dgvEvento.RowHeadersVisible = False
        Me.dgvEvento.ShowCellErrors = False
        Me.dgvEvento.ShowCellToolTips = False
        Me.dgvEvento.ShowEditingIcon = False
        Me.dgvEvento.ShowRowErrors = False
        Me.dgvEvento.Size = New System.Drawing.Size(509, 176)
        Me.dgvEvento.TabIndex = 0
        '
        'nombreEven
        '
        Me.nombreEven.HeaderText = "Nombre"
        Me.nombreEven.Name = "nombreEven"
        '
        'descripeven
        '
        Me.descripeven.HeaderText = "Descripción"
        Me.descripeven.Name = "descripeven"
        '
        'fechaEven
        '
        Me.fechaEven.HeaderText = "Fecha"
        Me.fechaEven.Name = "fechaEven"
        '
        'programaEven
        '
        Me.programaEven.HeaderText = "Programa"
        Me.programaEven.Name = "programaEven"
        '
        'videoEven
        '
        Me.videoEven.HeaderText = "Video"
        Me.videoEven.Name = "videoEven"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAñadirEv, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBuscarEv, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBorrarEv, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 327)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(500, 56)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnBorrarEv
        '
        Me.btnBorrarEv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarEv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrarEv.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrarEv.Location = New System.Drawing.Point(3, 3)
        Me.btnBorrarEv.Name = "btnBorrarEv"
        Me.btnBorrarEv.Size = New System.Drawing.Size(164, 50)
        Me.btnBorrarEv.TabIndex = 0
        Me.btnBorrarEv.Text = "Borrar"
        Me.btnBorrarEv.UseVisualStyleBackColor = False
        '
        'btnAñadirEv
        '
        Me.btnAñadirEv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAñadirEv.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAñadirEv.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnAñadirEv.Location = New System.Drawing.Point(173, 3)
        Me.btnAñadirEv.Name = "btnAñadirEv"
        Me.btnAñadirEv.Size = New System.Drawing.Size(164, 50)
        Me.btnAñadirEv.TabIndex = 1
        Me.btnAñadirEv.Text = "Añadir"
        Me.btnAñadirEv.UseVisualStyleBackColor = False
        '
        'btnBuscarEv
        '
        Me.btnBuscarEv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarEv.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarEv.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBuscarEv.Location = New System.Drawing.Point(343, 3)
        Me.btnBuscarEv.Name = "btnBuscarEv"
        Me.btnBuscarEv.Size = New System.Drawing.Size(154, 50)
        Me.btnBuscarEv.TabIndex = 2
        Me.btnBuscarEv.Text = "Buscar"
        Me.btnBuscarEv.UseVisualStyleBackColor = False
        '
        'FrmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(509, 386)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmEventos"
        Me.Text = "Eventos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpEventoF As DateTimePicker
    Friend WithEvents txtProgEvento As TextBox
    Friend WithEvents txtdescripevento As TextBox
    Friend WithEvents txtnombreevento As TextBox
    Friend WithEvents txtEventoVideo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvEvento As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAñadirEv As Button
    Friend WithEvents btnBuscarEv As Button
    Friend WithEvents btnBorrarEv As Button
    Friend WithEvents nombreEven As DataGridViewTextBoxColumn
    Friend WithEvents descripeven As DataGridViewTextBoxColumn
    Friend WithEvents fechaEven As DataGridViewTextBoxColumn
    Friend WithEvents programaEven As DataGridViewTextBoxColumn
    Friend WithEvents videoEven As DataGridViewTextBoxColumn
End Class
