<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncion
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
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.35135!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.64865!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(496, 247)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(488, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtDesc.ForeColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(125, 64)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDesc.MaxLength = 128
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(349, 91)
        Me.txtDesc.TabIndex = 4
        Me.txtDesc.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(125, 23)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 16
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(351, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.37795!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnSalir, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBorrar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEditar, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 180)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(488, 63)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(331, 4)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(153, 55)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Location = New System.Drawing.Point(163, 4)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(160, 55)
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditar.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Location = New System.Drawing.Point(4, 4)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(151, 55)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'frmFuncion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 242)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(514, 289)
        Me.MinimumSize = New System.Drawing.Size(514, 289)
        Me.Name = "frmFuncion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ver Función"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc As RichTextBox
End Class
