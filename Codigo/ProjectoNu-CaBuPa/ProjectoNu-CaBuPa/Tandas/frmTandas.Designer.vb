<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTandas
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHI = New System.Windows.Forms.MaskedTextBox()
        Me.txtHF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tandas = New System.Windows.Forms.Label()
        Me.dgvTandas = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsalirt = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTandas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Tandas)
        Me.GroupBox1.Controls.Add(Me.dgvTandas)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(294, 340)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtHI)
        Me.GroupBox2.Controls.Add(Me.txtHF)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 83)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hora inicio:"
        '
        'txtHI
        '
        Me.txtHI.Location = New System.Drawing.Point(25, 50)
        Me.txtHI.Mask = "00:00"
        Me.txtHI.Name = "txtHI"
        Me.txtHI.Size = New System.Drawing.Size(90, 27)
        Me.txtHI.TabIndex = 8
        Me.txtHI.Text = "0000"
        Me.txtHI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHI.ValidatingType = GetType(Date)
        '
        'txtHF
        '
        Me.txtHF.Location = New System.Drawing.Point(171, 50)
        Me.txtHF.Mask = "00:00"
        Me.txtHF.Name = "txtHF"
        Me.txtHF.Size = New System.Drawing.Size(90, 27)
        Me.txtHF.TabIndex = 9
        Me.txtHF.Text = "0000"
        Me.txtHF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHF.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(178, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora fin:"
        '
        'Tandas
        '
        Me.Tandas.AutoSize = True
        Me.Tandas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tandas.ForeColor = System.Drawing.Color.White
        Me.Tandas.Location = New System.Drawing.Point(109, 19)
        Me.Tandas.Name = "Tandas"
        Me.Tandas.Size = New System.Drawing.Size(64, 20)
        Me.Tandas.TabIndex = 10
        Me.Tandas.Text = "Tandas"
        '
        'dgvTandas
        '
        Me.dgvTandas.AllowUserToAddRows = False
        Me.dgvTandas.AllowUserToDeleteRows = False
        Me.dgvTandas.AllowUserToResizeColumns = False
        Me.dgvTandas.AllowUserToResizeRows = False
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvTandas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTandas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTandas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvTandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTandas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.descrip, Me.TEliminar})
        Me.dgvTandas.Location = New System.Drawing.Point(8, 41)
        Me.dgvTandas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTandas.MultiSelect = False
        Me.dgvTandas.Name = "dgvTandas"
        Me.dgvTandas.ReadOnly = True
        Me.dgvTandas.RowHeadersVisible = False
        Me.dgvTandas.RowHeadersWidth = 51
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.dgvTandas.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTandas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTandas.Size = New System.Drawing.Size(278, 147)
        Me.dgvTandas.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnsalirt, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBorrar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIngresar, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 286)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(294, 54)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnsalirt
        '
        Me.btnsalirt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalirt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsalirt.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnsalirt.ForeColor = System.Drawing.Color.Black
        Me.btnsalirt.Location = New System.Drawing.Point(4, 4)
        Me.btnsalirt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsalirt.Name = "btnsalirt"
        Me.btnsalirt.Size = New System.Drawing.Size(90, 46)
        Me.btnsalirt.TabIndex = 2
        Me.btnsalirt.Text = "Salir"
        Me.btnsalirt.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Location = New System.Drawing.Point(102, 4)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(90, 46)
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnIngresar.ForeColor = System.Drawing.Color.Black
        Me.btnIngresar.Location = New System.Drawing.Point(200, 4)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(90, 46)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Hora Inicio"
        Me.Nombre.MaxInputLength = 5
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'descrip
        '
        Me.descrip.HeaderText = "Hora Finalización"
        Me.descrip.MaxInputLength = 5
        Me.descrip.MinimumWidth = 6
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        '
        'TEliminar
        '
        Me.TEliminar.FillWeight = 75.0!
        Me.TEliminar.HeaderText = "Eliminar"
        Me.TEliminar.MinimumWidth = 6
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.ReadOnly = True
        Me.TEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmTandas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 355)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTandas"
        Me.Text = "Tanda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvTandas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnsalirt As Button
    Friend WithEvents dgvTandas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtHI As MaskedTextBox
    Friend WithEvents txtHF As MaskedTextBox
    Friend WithEvents Tandas As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents descrip As DataGridViewTextBoxColumn
    Friend WithEvents TEliminar As DataGridViewCheckBoxColumn
End Class
