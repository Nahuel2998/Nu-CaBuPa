<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcceso))
        Me.cblP = New System.Windows.Forms.CheckedListBox()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnActualizar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.SuspendLayout()
        '
        'cblP
        '
        Me.cblP.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cblP.CheckOnClick = True
        Me.cblP.FormattingEnabled = True
        Me.cblP.Location = New System.Drawing.Point(12, 46)
        Me.cblP.Name = "cblP"
        Me.cblP.Size = New System.Drawing.Size(355, 191)
        Me.cblP.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.BorderRadius = 0
        Me.btnSalir.ButtonText = "Salir"
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DisabledColor = System.Drawing.Color.Gray
        Me.btnSalir.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSalir.Iconimage = Nothing
        Me.btnSalir.Iconimage_right = Nothing
        Me.btnSalir.Iconimage_right_Selected = Nothing
        Me.btnSalir.Iconimage_Selected = Nothing
        Me.btnSalir.IconMarginLeft = 0
        Me.btnSalir.IconMarginRight = 0
        Me.btnSalir.IconRightVisible = True
        Me.btnSalir.IconRightZoom = 0R
        Me.btnSalir.IconVisible = True
        Me.btnSalir.IconZoom = 90.0R
        Me.btnSalir.IsTab = False
        Me.btnSalir.Location = New System.Drawing.Point(13, 255)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSalir.selected = False
        Me.btnSalir.Size = New System.Drawing.Size(96, 34)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSalir.Textcolor = System.Drawing.Color.White
        Me.btnSalir.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnActualizar
        '
        Me.btnActualizar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnActualizar.BackColor = System.Drawing.Color.Navy
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.BorderRadius = 0
        Me.btnActualizar.ButtonText = "Actualizar"
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.DisabledColor = System.Drawing.Color.Gray
        Me.btnActualizar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnActualizar.Iconimage = CType(resources.GetObject("btnActualizar.Iconimage"), System.Drawing.Image)
        Me.btnActualizar.Iconimage_right = Nothing
        Me.btnActualizar.Iconimage_right_Selected = Nothing
        Me.btnActualizar.Iconimage_Selected = Nothing
        Me.btnActualizar.IconMarginLeft = 0
        Me.btnActualizar.IconMarginRight = 0
        Me.btnActualizar.IconRightVisible = True
        Me.btnActualizar.IconRightZoom = 0R
        Me.btnActualizar.IconVisible = True
        Me.btnActualizar.IconZoom = 90.0R
        Me.btnActualizar.IsTab = False
        Me.btnActualizar.Location = New System.Drawing.Point(117, 255)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Normalcolor = System.Drawing.Color.Navy
        Me.btnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnActualizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnActualizar.selected = False
        Me.btnActualizar.Size = New System.Drawing.Size(249, 34)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnActualizar.Textcolor = System.Drawing.Color.White
        Me.btnActualizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(163, 9)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(80, 20)
        Me.UI_LabelMaterial1.TabIndex = 3
        Me.UI_LabelMaterial1.Text = "Permisos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 302)
        Me.Controls.Add(Me.UI_LabelMaterial1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cblP)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(397, 349)
        Me.MinimumSize = New System.Drawing.Size(397, 349)
        Me.Name = "frmAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Permisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cblP As CheckedListBox
    Friend WithEvents btnSalir As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnActualizar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
End Class
