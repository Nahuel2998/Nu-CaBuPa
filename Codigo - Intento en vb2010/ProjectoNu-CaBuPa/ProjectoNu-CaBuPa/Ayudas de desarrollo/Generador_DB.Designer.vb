<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Generador_DB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generador_DB))
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.gbInsert = New System.Windows.Forms.GroupBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.cbTablas = New System.Windows.Forms.ComboBox()
        Me.btnCTabla = New System.Windows.Forms.Button()
        Me.gbInsert.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(252, 204)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(117, 26)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'gbInsert
        '
        Me.gbInsert.Controls.Add(Me.Limpiar)
        Me.gbInsert.Controls.Add(Me.dgvTabla)
        Me.gbInsert.Controls.Add(Me.cbTablas)
        Me.gbInsert.Controls.Add(Me.btnCTabla)
        Me.gbInsert.Controls.Add(Me.btnInsertar)
        Me.gbInsert.Location = New System.Drawing.Point(11, 10)
        Me.gbInsert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbInsert.Name = "gbInsert"
        Me.gbInsert.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbInsert.Size = New System.Drawing.Size(374, 234)
        Me.gbInsert.TabIndex = 7
        Me.gbInsert.TabStop = False
        Me.gbInsert.Text = "Insertar"
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(17, 204)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 26)
        Me.Limpiar.TabIndex = 5
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'dgvTabla
        '
        Me.dgvTabla.AllowUserToAddRows = False
        Me.dgvTabla.AllowUserToDeleteRows = False
        Me.dgvTabla.AllowUserToResizeColumns = False
        Me.dgvTabla.AllowUserToResizeRows = False
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(17, 58)
        Me.dgvTabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTabla.RowHeadersVisible = False
        Me.dgvTabla.RowHeadersWidth = 62
        Me.dgvTabla.RowTemplate.Height = 28
        Me.dgvTabla.Size = New System.Drawing.Size(352, 142)
        Me.dgvTabla.TabIndex = 4
        '
        'cbTablas
        '
        Me.cbTablas.FormattingEnabled = True
        Me.cbTablas.Location = New System.Drawing.Point(17, 23)
        Me.cbTablas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTablas.Name = "cbTablas"
        Me.cbTablas.Size = New System.Drawing.Size(230, 24)
        Me.cbTablas.TabIndex = 3
        '
        'btnCTabla
        '
        Me.btnCTabla.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCTabla.Location = New System.Drawing.Point(252, 20)
        Me.btnCTabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCTabla.Name = "btnCTabla"
        Me.btnCTabla.Size = New System.Drawing.Size(117, 28)
        Me.btnCTabla.TabIndex = 2
        Me.btnCTabla.Text = "Cargar Tabla"
        Me.btnCTabla.UseVisualStyleBackColor = True
        '
        'Generador_DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 254)
        Me.Controls.Add(Me.gbInsert)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Generador_DB"
        Me.Text = "Generador"
        Me.gbInsert.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInsertar As Button
    Friend WithEvents gbInsert As GroupBox
    Friend WithEvents cbTablas As ComboBox
    Friend WithEvents btnCTabla As Button
    Friend WithEvents dgvTabla As DataGridView
    Friend WithEvents Limpiar As Button
End Class
