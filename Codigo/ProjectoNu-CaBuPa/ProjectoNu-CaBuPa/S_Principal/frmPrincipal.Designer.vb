<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seccion1")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modulo1", New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMenu = New System.Windows.Forms.Panel()
        Me.TreeMenu = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Status = New System.Windows.Forms.Panel()
        Me.Estado = New System.Windows.Forms.Label()
        Me.Content = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMenu.SuspendLayout()
        Me.TreeMenu.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.Content.SuspendLayout()
        Me.Title.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 108)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "En Diseño"
        '
        'CMenu
        '
        Me.CMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CMenu.Controls.Add(Me.TreeMenu)
        Me.CMenu.Location = New System.Drawing.Point(20, 20)
        Me.CMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CMenu.Name = "CMenu"
        Me.CMenu.Size = New System.Drawing.Size(201, 360)
        Me.CMenu.TabIndex = 1
        '
        'TreeMenu
        '
        Me.TreeMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeMenu.Controls.Add(Me.TreeView1)
        Me.TreeMenu.Location = New System.Drawing.Point(6, 6)
        Me.TreeMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TreeMenu.Name = "TreeMenu"
        Me.TreeMenu.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TreeMenu.Size = New System.Drawing.Size(190, 349)
        Me.TreeMenu.TabIndex = 1
        Me.TreeMenu.TabStop = False
        Me.TreeMenu.Text = "Menu"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(9, 29)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TreeView1.Name = "TreeView1"
        TreeNode3.Name = "Seccion1"
        TreeNode3.Tag = "Seccion1"
        TreeNode3.Text = "Seccion1"
        TreeNode4.Name = "Modulo1"
        TreeNode4.Tag = "Modulo1"
        TreeNode4.Text = "Modulo1"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.TreeView1.Size = New System.Drawing.Size(170, 309)
        Me.TreeView1.TabIndex = 0
        '
        'Status
        '
        Me.Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status.AutoSize = True
        Me.Status.Controls.Add(Me.Estado)
        Me.Status.Location = New System.Drawing.Point(20, 391)
        Me.Status.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(790, 52)
        Me.Status.TabIndex = 2
        '
        'Estado
        '
        Me.Estado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Estado.Location = New System.Drawing.Point(15, 17)
        Me.Estado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(771, 20)
        Me.Estado.TabIndex = 0
        Me.Estado.Text = "-Status"
        '
        'Content
        '
        Me.Content.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Content.Controls.Add(Me.Label4)
        Me.Content.Controls.Add(Me.Label1)
        Me.Content.Controls.Add(Me.Label3)
        Me.Content.Controls.Add(Me.Title)
        Me.Content.Location = New System.Drawing.Point(230, 20)
        Me.Content.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(580, 360)
        Me.Content.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "By: Manuel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Corregir y no juzgar T.T"
        '
        'Title
        '
        Me.Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.Controls.Add(Me.GroupBox1)
        Me.Title.Location = New System.Drawing.Point(6, 9)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(570, 74)
        Me.Title.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(560, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Title Modulo"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(9, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(540, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Titulo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(826, 458)
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.CMenu)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPrincipal"
        Me.Text = "Inicio"
        Me.CMenu.ResumeLayout(False)
        Me.TreeMenu.ResumeLayout(False)
        Me.Status.ResumeLayout(False)
        Me.Content.ResumeLayout(False)
        Me.Content.PerformLayout()
        Me.Title.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMenu As System.Windows.Forms.Panel
    Friend WithEvents TreeMenu As System.Windows.Forms.GroupBox
    Friend WithEvents Status As System.Windows.Forms.Panel
    Friend WithEvents Content As System.Windows.Forms.Panel
    Friend WithEvents Title As System.Windows.Forms.Panel
    Friend WithEvents Estado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
