﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pMain = New System.Windows.Forms.TableLayoutPanel()
        Me.spNotEven = New System.Windows.Forms.TableLayoutPanel()
        Me.gbNotas = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tcSecciones = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.dgvPrograma = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbTandas = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pCMain = New System.Windows.Forms.Panel()
        Me.BWNumberOne = New System.ComponentModel.BackgroundWorker()
        Me.pMain.SuspendLayout()
        Me.spNotEven.SuspendLayout()
        Me.gbNotas.SuspendLayout()
        Me.tcSecciones.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbTandas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pStatus.SuspendLayout()
        Me.pCMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMain
        '
        resources.ApplyResources(Me.pMain, "pMain")
        Me.pMain.Controls.Add(Me.spNotEven, 2, 0)
        Me.pMain.Controls.Add(Me.tcSecciones, 1, 0)
        Me.pMain.Controls.Add(Me.Panel2, 0, 0)
        Me.pMain.Name = "pMain"
        '
        'spNotEven
        '
        resources.ApplyResources(Me.spNotEven, "spNotEven")
        Me.spNotEven.Controls.Add(Me.gbNotas, 0, 1)
        Me.spNotEven.Name = "spNotEven"
        '
        'gbNotas
        '
        resources.ApplyResources(Me.gbNotas, "gbNotas")
        Me.gbNotas.Controls.Add(Me.TextBox1)
        Me.gbNotas.Name = "gbNotas"
        Me.gbNotas.TabStop = False
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Name = "TextBox1"
        '
        'tcSecciones
        '
        resources.ApplyResources(Me.tcSecciones, "tcSecciones")
        Me.tcSecciones.Controls.Add(Me.TabPage1)
        Me.tcSecciones.Controls.Add(Me.TabPage2)
        Me.tcSecciones.Name = "tcSecciones"
        Me.tcSecciones.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.dgvPrograma)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'dtp
        '
        resources.ApplyResources(Me.dtp, "dtp")
        Me.dtp.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dtp.CalendarMonthBackground = System.Drawing.SystemColors.MenuText
        Me.dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtp.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dtp.Name = "dtp"
        '
        'dgvPrograma
        '
        Me.dgvPrograma.AllowUserToAddRows = False
        Me.dgvPrograma.AllowUserToDeleteRows = False
        Me.dgvPrograma.AllowUserToResizeColumns = False
        Me.dgvPrograma.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aquamarine
        Me.dgvPrograma.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgvPrograma, "dgvPrograma")
        Me.dgvPrograma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrograma.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Plum
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrograma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrograma.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPrograma.MultiSelect = False
        Me.dgvPrograma.Name = "dgvPrograma"
        Me.dgvPrograma.ReadOnly = True
        Me.dgvPrograma.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.dgvPrograma.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPrograma.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvPrograma.RowTemplate.Height = 28
        Me.dgvPrograma.RowTemplate.ReadOnly = True
        Me.dgvPrograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'TabPage2
        '
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.gbTandas)
        Me.Panel2.Name = "Panel2"
        '
        'gbTandas
        '
        resources.ApplyResources(Me.gbTandas, "gbTandas")
        Me.gbTandas.Controls.Add(Me.DataGridView1)
        Me.gbTandas.Name = "gbTandas"
        Me.gbTandas.TabStop = False
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        '
        'pStatus
        '
        resources.ApplyResources(Me.pStatus, "pStatus")
        Me.pStatus.BackColor = System.Drawing.SystemColors.Highlight
        Me.pStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pStatus.Controls.Add(Me.lblStatus)
        Me.pStatus.Name = "pStatus"
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStatus.Name = "lblStatus"
        '
        'pCMain
        '
        resources.ApplyResources(Me.pCMain, "pCMain")
        Me.pCMain.Controls.Add(Me.pMain)
        Me.pCMain.Controls.Add(Me.pStatus)
        Me.pCMain.Name = "pCMain"
        '
        'BWNumberOne
        '
        '
        'frmPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.pCMain)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrincipal"
        Me.pMain.ResumeLayout(False)
        Me.spNotEven.ResumeLayout(False)
        Me.gbNotas.ResumeLayout(False)
        Me.gbNotas.PerformLayout()
        Me.tcSecciones.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbTandas.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pStatus.ResumeLayout(False)
        Me.pCMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMain As TableLayoutPanel
    Friend WithEvents pStatus As Panel
    Friend WithEvents spNotEven As TableLayoutPanel
    Friend WithEvents pCMain As Panel
    Friend WithEvents tcSecciones As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbNotas As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BWNumberOne As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As Label
    Friend WithEvents gbTandas As GroupBox
    Friend WithEvents dgvPrograma As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp As DateTimePicker
End Class
