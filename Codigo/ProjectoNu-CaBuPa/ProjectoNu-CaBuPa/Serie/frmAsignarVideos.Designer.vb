<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarVideos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstLeft = New System.Windows.Forms.ListBox()
        Me.txtBuscarLeft = New System.Windows.Forms.TextBox()
        Me.btnBuscarLeft = New System.Windows.Forms.Button()
        Me.btnPasarRight = New System.Windows.Forms.Button()
        Me.btnBuscarRight = New System.Windows.Forms.Button()
        Me.txtBuscarRight = New System.Windows.Forms.TextBox()
        Me.lstRight = New System.Windows.Forms.ListBox()
        Me.btnPasarIzquierda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLeft
        '
        Me.lstLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstLeft.ForeColor = System.Drawing.Color.White
        Me.lstLeft.FormattingEnabled = True
        Me.lstLeft.ItemHeight = 15
        Me.lstLeft.Location = New System.Drawing.Point(12, 42)
        Me.lstLeft.Name = "lstLeft"
        Me.lstLeft.Size = New System.Drawing.Size(244, 379)
        Me.lstLeft.TabIndex = 0
        '
        'txtBuscarLeft
        '
        Me.txtBuscarLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBuscarLeft.ForeColor = System.Drawing.Color.White
        Me.txtBuscarLeft.Location = New System.Drawing.Point(12, 12)
        Me.txtBuscarLeft.Name = "txtBuscarLeft"
        Me.txtBuscarLeft.Size = New System.Drawing.Size(178, 23)
        Me.txtBuscarLeft.TabIndex = 2
        '
        'btnBuscarLeft
        '
        Me.btnBuscarLeft.Location = New System.Drawing.Point(196, 12)
        Me.btnBuscarLeft.Name = "btnBuscarLeft"
        Me.btnBuscarLeft.Size = New System.Drawing.Size(60, 23)
        Me.btnBuscarLeft.TabIndex = 3
        Me.btnBuscarLeft.Text = "Buscar"
        Me.btnBuscarLeft.UseVisualStyleBackColor = True
        '
        'btnPasarRight
        '
        Me.btnPasarRight.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasarRight.Location = New System.Drawing.Point(262, 101)
        Me.btnPasarRight.Name = "btnPasarRight"
        Me.btnPasarRight.Size = New System.Drawing.Size(55, 104)
        Me.btnPasarRight.TabIndex = 7
        Me.btnPasarRight.Text = "🡺"
        Me.btnPasarRight.UseVisualStyleBackColor = True
        '
        'btnBuscarRight
        '
        Me.btnBuscarRight.Location = New System.Drawing.Point(507, 12)
        Me.btnBuscarRight.Name = "btnBuscarRight"
        Me.btnBuscarRight.Size = New System.Drawing.Size(60, 23)
        Me.btnBuscarRight.TabIndex = 10
        Me.btnBuscarRight.Text = "Buscar"
        Me.btnBuscarRight.UseVisualStyleBackColor = True
        '
        'txtBuscarRight
        '
        Me.txtBuscarRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBuscarRight.ForeColor = System.Drawing.Color.White
        Me.txtBuscarRight.Location = New System.Drawing.Point(323, 12)
        Me.txtBuscarRight.Name = "txtBuscarRight"
        Me.txtBuscarRight.Size = New System.Drawing.Size(178, 23)
        Me.txtBuscarRight.TabIndex = 9
        '
        'lstRight
        '
        Me.lstRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstRight.ForeColor = System.Drawing.Color.White
        Me.lstRight.FormattingEnabled = True
        Me.lstRight.ItemHeight = 15
        Me.lstRight.Location = New System.Drawing.Point(323, 42)
        Me.lstRight.Name = "lstRight"
        Me.lstRight.Size = New System.Drawing.Size(244, 379)
        Me.lstRight.TabIndex = 8
        '
        'btnPasarIzquierda
        '
        Me.btnPasarIzquierda.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasarIzquierda.Location = New System.Drawing.Point(262, 248)
        Me.btnPasarIzquierda.Name = "btnPasarIzquierda"
        Me.btnPasarIzquierda.Size = New System.Drawing.Size(55, 104)
        Me.btnPasarIzquierda.TabIndex = 11
        Me.btnPasarIzquierda.Text = "🡸"
        Me.btnPasarIzquierda.UseVisualStyleBackColor = True
        '
        'frmAsignarVideos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 433)
        Me.Controls.Add(Me.btnPasarIzquierda)
        Me.Controls.Add(Me.btnBuscarRight)
        Me.Controls.Add(Me.txtBuscarRight)
        Me.Controls.Add(Me.lstRight)
        Me.Controls.Add(Me.btnPasarRight)
        Me.Controls.Add(Me.btnBuscarLeft)
        Me.Controls.Add(Me.txtBuscarLeft)
        Me.Controls.Add(Me.lstLeft)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAsignarVideos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Videos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLeft As ListBox
    Friend WithEvents txtBuscarLeft As TextBox
    Friend WithEvents btnBuscarLeft As Button
    Friend WithEvents btnPasarRight As Button
    Friend WithEvents btnBuscarRight As Button
    Friend WithEvents txtBuscarRight As TextBox
    Friend WithEvents lstRight As ListBox
    Friend WithEvents btnPasarIzquierda As Button
End Class
