<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
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
        Me.txtfuncion = New System.Windows.Forms.TextBox()
        Me.txttelefonofun = New System.Windows.Forms.TextBox()
        Me.txtemailfun = New System.Windows.Forms.TextBox()
        Me.txtnombrefun = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnlimpiarfun = New System.Windows.Forms.Button()
        Me.btningresarfun = New System.Windows.Forms.Button()
        Me.btnbuscarfun = New System.Windows.Forms.Button()
        Me.btnborrarfun = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, -1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.75221!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.24779!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(922, 485)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvFuncionarios)
        Me.GroupBox1.Controls.Add(Me.txtfuncion)
        Me.GroupBox1.Controls.Add(Me.txttelefonofun)
        Me.GroupBox1.Controls.Add(Me.txtemailfun)
        Me.GroupBox1.Controls.Add(Me.txtnombrefun)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(914, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txtfuncion
        '
        Me.txtfuncion.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtfuncion.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.txtfuncion.ForeColor = System.Drawing.Color.White
        Me.txtfuncion.Location = New System.Drawing.Point(119, 153)
        Me.txtfuncion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfuncion.Multiline = True
        Me.txtfuncion.Name = "txtfuncion"
        Me.txtfuncion.Size = New System.Drawing.Size(403, 64)
        Me.txtfuncion.TabIndex = 7
        '
        'txttelefonofun
        '
        Me.txttelefonofun.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txttelefonofun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.txttelefonofun.ForeColor = System.Drawing.Color.White
        Me.txttelefonofun.Location = New System.Drawing.Point(119, 70)
        Me.txttelefonofun.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelefonofun.Name = "txttelefonofun"
        Me.txttelefonofun.Size = New System.Drawing.Size(403, 27)
        Me.txttelefonofun.TabIndex = 6
        '
        'txtemailfun
        '
        Me.txtemailfun.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtemailfun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.txtemailfun.ForeColor = System.Drawing.Color.White
        Me.txtemailfun.Location = New System.Drawing.Point(119, 114)
        Me.txtemailfun.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemailfun.Name = "txtemailfun"
        Me.txtemailfun.Size = New System.Drawing.Size(403, 27)
        Me.txtemailfun.TabIndex = 5
        '
        'txtnombrefun
        '
        Me.txtnombrefun.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtnombrefun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.txtnombrefun.ForeColor = System.Drawing.Color.White
        Me.txtnombrefun.Location = New System.Drawing.Point(119, 31)
        Me.txtnombrefun.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombrefun.Name = "txtnombrefun"
        Me.txtnombrefun.Size = New System.Drawing.Size(403, 27)
        Me.txtnombrefun.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Función:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-Mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 239)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(914, 178)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        Me.dgvFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Telefono, Me.contacto, Me.funcion})
        Me.dgvFuncionarios.Location = New System.Drawing.Point(542, 20)
        Me.dgvFuncionarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFuncionarios.MultiSelect = False
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.ReadOnly = True
        Me.dgvFuncionarios.RowHeadersVisible = False
        Me.dgvFuncionarios.RowHeadersWidth = 51
        Me.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionarios.Size = New System.Drawing.Size(222, 199)
        Me.dgvFuncionarios.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.MinimumWidth = 6
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'contacto
        '
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.MinimumWidth = 6
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        '
        'funcion
        '
        Me.funcion.HeaderText = "Función"
        Me.funcion.MinimumWidth = 6
        Me.funcion.Name = "funcion"
        Me.funcion.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnlimpiarfun, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btningresarfun, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnbuscarfun, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnborrarfun, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 425)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(914, 56)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnlimpiarfun
        '
        Me.btnlimpiarfun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlimpiarfun.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnlimpiarfun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnlimpiarfun.ForeColor = System.Drawing.Color.White
        Me.btnlimpiarfun.Location = New System.Drawing.Point(4, 4)
        Me.btnlimpiarfun.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlimpiarfun.Name = "btnlimpiarfun"
        Me.btnlimpiarfun.Size = New System.Drawing.Size(220, 48)
        Me.btnlimpiarfun.TabIndex = 0
        Me.btnlimpiarfun.Text = "Limpiar busqueda"
        Me.btnlimpiarfun.UseVisualStyleBackColor = False
        '
        'btningresarfun
        '
        Me.btningresarfun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btningresarfun.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btningresarfun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btningresarfun.ForeColor = System.Drawing.Color.White
        Me.btningresarfun.Location = New System.Drawing.Point(232, 4)
        Me.btningresarfun.Margin = New System.Windows.Forms.Padding(4)
        Me.btningresarfun.Name = "btningresarfun"
        Me.btningresarfun.Size = New System.Drawing.Size(220, 48)
        Me.btningresarfun.TabIndex = 1
        Me.btningresarfun.Text = "Ingresar"
        Me.btningresarfun.UseVisualStyleBackColor = False
        '
        'btnbuscarfun
        '
        Me.btnbuscarfun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscarfun.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnbuscarfun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnbuscarfun.ForeColor = System.Drawing.Color.White
        Me.btnbuscarfun.Location = New System.Drawing.Point(460, 4)
        Me.btnbuscarfun.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscarfun.Name = "btnbuscarfun"
        Me.btnbuscarfun.Size = New System.Drawing.Size(220, 48)
        Me.btnbuscarfun.TabIndex = 2
        Me.btnbuscarfun.Text = "Buscar"
        Me.btnbuscarfun.UseVisualStyleBackColor = False
        '
        'btnborrarfun
        '
        Me.btnborrarfun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnborrarfun.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnborrarfun.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnborrarfun.ForeColor = System.Drawing.Color.White
        Me.btnborrarfun.Location = New System.Drawing.Point(688, 4)
        Me.btnborrarfun.Margin = New System.Windows.Forms.Padding(4)
        Me.btnborrarfun.Name = "btnborrarfun"
        Me.btnborrarfun.Size = New System.Drawing.Size(222, 48)
        Me.btnborrarfun.TabIndex = 3
        Me.btnborrarfun.Text = "Borrar"
        Me.btnborrarfun.UseVisualStyleBackColor = False
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 482)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFuncionario"
        Me.Text = "Funcionario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfuncion As TextBox
    Friend WithEvents txttelefonofun As TextBox
    Friend WithEvents txtemailfun As TextBox
    Friend WithEvents txtnombrefun As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvFuncionarios As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents contacto As DataGridViewTextBoxColumn
    Friend WithEvents funcion As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnlimpiarfun As Button
    Friend WithEvents btningresarfun As Button
    Friend WithEvents btnbuscarfun As Button
    Friend WithEvents btnborrarfun As Button
End Class
