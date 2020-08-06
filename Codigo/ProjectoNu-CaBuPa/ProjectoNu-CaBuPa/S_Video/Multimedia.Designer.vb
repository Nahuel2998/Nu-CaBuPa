<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Multimedia
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
        Me.Aregar = New System.Windows.Forms.TabPage()
        Me.tbTipoContenido = New System.Windows.Forms.TabControl()
        Me.tbpVideo = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbpSerie = New System.Windows.Forms.TabPage()
        Me.Buscar = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.tbAccion = New System.Windows.Forms.TabControl()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aregar.SuspendLayout()
        Me.tbTipoContenido.SuspendLayout()
        Me.tbpVideo.SuspendLayout()
        Me.Buscar.SuspendLayout()
        Me.tbAccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aregar
        '
        Me.Aregar.Controls.Add(Me.tbTipoContenido)
        Me.Aregar.Location = New System.Drawing.Point(4, 29)
        Me.Aregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Aregar.Name = "Aregar"
        Me.Aregar.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Aregar.Size = New System.Drawing.Size(808, 421)
        Me.Aregar.TabIndex = 1
        Me.Aregar.Text = "Agregar"
        Me.Aregar.UseVisualStyleBackColor = True
        '
        'tbTipoContenido
        '
        Me.tbTipoContenido.Controls.Add(Me.tbpVideo)
        Me.tbTipoContenido.Controls.Add(Me.tbpSerie)
        Me.tbTipoContenido.Location = New System.Drawing.Point(8, 9)
        Me.tbTipoContenido.Name = "tbTipoContenido"
        Me.tbTipoContenido.SelectedIndex = 0
        Me.tbTipoContenido.Size = New System.Drawing.Size(795, 404)
        Me.tbTipoContenido.TabIndex = 59
        '
        'tbpVideo
        '
        Me.tbpVideo.Controls.Add(Me.TextBox4)
        Me.tbpVideo.Controls.Add(Me.Button2)
        Me.tbpVideo.Controls.Add(Me.RadioButton3)
        Me.tbpVideo.Controls.Add(Me.RadioButton4)
        Me.tbpVideo.Controls.Add(Me.TextBox3)
        Me.tbpVideo.Controls.Add(Me.Label6)
        Me.tbpVideo.Controls.Add(Me.Label7)
        Me.tbpVideo.Location = New System.Drawing.Point(4, 29)
        Me.tbpVideo.Name = "tbpVideo"
        Me.tbpVideo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpVideo.Size = New System.Drawing.Size(787, 371)
        Me.tbpVideo.TabIndex = 0
        Me.tbpVideo.Text = "Video"
        Me.tbpVideo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 289)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Boton "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(275, 124)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(54, 24)
        Me.RadioButton3.TabIndex = 63
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "No"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(183, 124)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton4.TabIndex = 62
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Si"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(80, 20)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 26)
        Me.TextBox3.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Activo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Nombre"
        '
        'tbpSerie
        '
        Me.tbpSerie.Location = New System.Drawing.Point(4, 29)
        Me.tbpSerie.Name = "tbpSerie"
        Me.tbpSerie.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSerie.Size = New System.Drawing.Size(787, 371)
        Me.tbpSerie.TabIndex = 1
        Me.tbpSerie.Text = "Serie"
        Me.tbpSerie.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Controls.Add(Me.GroupBox1)
        Me.Buscar.Location = New System.Drawing.Point(4, 29)
        Me.Buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Buscar.Size = New System.Drawing.Size(808, 421)
        Me.Buscar.TabIndex = 0
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(494, 64)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(293, 26)
        Me.DateTimePicker1.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(494, 20)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(293, 26)
        Me.TextBox2.TabIndex = 43
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 20)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nombre serie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(541, 101)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(112, 35)
        Me.btnbuscar.TabIndex = 35
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'tbAccion
        '
        Me.tbAccion.Controls.Add(Me.Buscar)
        Me.tbAccion.Controls.Add(Me.Aregar)
        Me.tbAccion.Location = New System.Drawing.Point(9, 18)
        Me.tbAccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAccion.Name = "tbAccion"
        Me.tbAccion.SelectedIndex = 0
        Me.tbAccion.Size = New System.Drawing.Size(816, 454)
        Me.tbAccion.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(115, 89)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(297, 112)
        Me.TextBox4.TabIndex = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 405)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Contenido"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(95, 67)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(280, 69)
        Me.TextBox5.TabIndex = 47
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Serie, Me.Fecha})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(781, 255)
        Me.DataGridView1.TabIndex = 48
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.MinimumWidth = 8
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 8
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Multimedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 491)
        Me.Controls.Add(Me.tbAccion)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Multimedia"
        Me.Text = "Multimedia"
        Me.Aregar.ResumeLayout(False)
        Me.tbTipoContenido.ResumeLayout(False)
        Me.tbpVideo.ResumeLayout(False)
        Me.tbpVideo.PerformLayout()
        Me.Buscar.ResumeLayout(False)
        Me.tbAccion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Aregar As System.Windows.Forms.TabPage
    Friend WithEvents Buscar As System.Windows.Forms.TabPage
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tbAccion As System.Windows.Forms.TabControl
    Friend WithEvents tbTipoContenido As TabControl
    Friend WithEvents tbpVideo As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbpSerie As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Serie As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
End Class
