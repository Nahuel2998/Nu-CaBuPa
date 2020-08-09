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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbpSerie = New System.Windows.Forms.TabPage()
        Me.Buscar = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbAccion = New System.Windows.Forms.TabControl()
        Me.Aregar.SuspendLayout()
        Me.tbTipoContenido.SuspendLayout()
        Me.tbpVideo.SuspendLayout()
        Me.Buscar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aregar
        '
        Me.Aregar.Controls.Add(Me.tbTipoContenido)
        Me.Aregar.Location = New System.Drawing.Point(4, 22)
        Me.Aregar.Name = "Aregar"
        Me.Aregar.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Aregar.Size = New System.Drawing.Size(536, 269)
        Me.Aregar.TabIndex = 1
        Me.Aregar.Text = "Agregar"
        Me.Aregar.UseVisualStyleBackColor = True
        '
        'tbTipoContenido
        '
        Me.tbTipoContenido.Controls.Add(Me.tbpVideo)
        Me.tbTipoContenido.Controls.Add(Me.tbpSerie)
        Me.tbTipoContenido.Location = New System.Drawing.Point(5, 6)
        Me.tbTipoContenido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbTipoContenido.Name = "tbTipoContenido"
        Me.tbTipoContenido.SelectedIndex = 0
        Me.tbTipoContenido.Size = New System.Drawing.Size(530, 263)
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
        Me.tbpVideo.Location = New System.Drawing.Point(4, 22)
        Me.tbpVideo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpVideo.Name = "tbpVideo"
        Me.tbpVideo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpVideo.Size = New System.Drawing.Size(522, 237)
        Me.tbpVideo.TabIndex = 0
        Me.tbpVideo.Text = "Video"
        Me.tbpVideo.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(77, 58)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(199, 74)
        Me.TextBox4.TabIndex = 66
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(101, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Boton "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(183, 81)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton3.TabIndex = 63
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "No"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(122, 81)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton4.TabIndex = 62
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Si"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(53, 13)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Activo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Nombre"
        '
        'tbpSerie
        '
        Me.tbpSerie.Location = New System.Drawing.Point(4, 22)
        Me.tbpSerie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpSerie.Name = "tbpSerie"
        Me.tbpSerie.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpSerie.Size = New System.Drawing.Size(522, 237)
        Me.tbpSerie.TabIndex = 1
        Me.tbpSerie.Text = "Serie"
        Me.tbpSerie.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Controls.Add(Me.GroupBox1)
        Me.Buscar.Location = New System.Drawing.Point(4, 22)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Buscar.Size = New System.Drawing.Size(536, 269)
        Me.Buscar.TabIndex = 0
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(529, 263)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video"
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
        Me.DataGridView1.Location = New System.Drawing.Point(4, 94)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(521, 166)
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
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(63, 44)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 46)
        Me.TextBox5.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Contenido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 20)
        Me.TextBox1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nombre serie"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(329, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(197, 20)
        Me.TextBox2.TabIndex = 43
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(361, 66)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 35
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(329, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(197, 20)
        Me.DateTimePicker1.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Fecha"
        '
        'tbAccion
        '
        Me.tbAccion.Controls.Add(Me.Buscar)
        Me.tbAccion.Controls.Add(Me.Aregar)
        Me.tbAccion.Location = New System.Drawing.Point(6, 12)
        Me.tbAccion.Name = "tbAccion"
        Me.tbAccion.SelectedIndex = 0
        Me.tbAccion.Size = New System.Drawing.Size(544, 295)
        Me.tbAccion.TabIndex = 0
        '
        'Multimedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 319)
        Me.Controls.Add(Me.tbAccion)
        Me.Name = "Multimedia"
        Me.Text = "Multimedia"
        Me.Aregar.ResumeLayout(False)
        Me.tbTipoContenido.ResumeLayout(False)
        Me.tbpVideo.ResumeLayout(False)
        Me.tbpVideo.PerformLayout()
        Me.Buscar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAccion.ResumeLayout(False)
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
