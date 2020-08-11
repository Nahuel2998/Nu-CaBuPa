﻿Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmPrincipal
    Private dt_programa As DataTable
    Private dt_dprograma As DataTable
    Private dt_evento As DataTable
    Private dt_tandas As DataTable
    Private dt_publi As DataTable
    Private Ejecucion As Integer = -1
    Private DescripcionP As String
    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
        End
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.85
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        BWEventos.RunWorkerAsync()
        LeerNotas()
    End Sub

    Private Sub BWNumberOne_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWProgramas.DoWork
        dt_programa = ModConector.APrograma(dtp.Value.Date)
    End Sub
    Private Sub ActualizarProgramas()
        dgvPrograma.Columns.Clear()
        If Not IsNothing(dt_programa) Then
            dgvPrograma.DataSource = dt_programa
            dgvPrograma.Columns().RemoveAt(0)
            dgvProgramaColor()
            For i As Integer = 0 To dgvPrograma.Columns.Count - 1
                dgvPrograma.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        Else
            dt_programa = New DataTable
            dgvPrograma.DataSource = dt_programa
            dgvPrograma.Columns.Add("PInicio", "Inicio")
            dgvPrograma.Columns.Add("PFinal", "Final")
            dgvPrograma.Columns.Add("PPrograma", "Programa")
        End If


    End Sub
    Private Sub ActualizarEvento()
        dgvEventos.Columns.Clear()
        dgvFuncionarios.Rows.Clear()
        If Not IsNothing(dt_evento) Then
            dgvEventos.DataSource = dt_evento
            If dt_evento.Rows.Count > 0 Then
                dgvEventos.Columns().RemoveAt(0)
            End If
            dgvEventos.ClearSelection()
        Else
            dt_programa = New DataTable
            dgvEventos.DataSource = dt_programa
            dgvEventos.Columns.Add("EFecha", "EFecha")
            dgvEventos.Columns.Add("ENombre", "Nombre")
        End If
    End Sub
    Public Sub dgvProgramaColor()
        Dim fin As TimeSpan
        Dim inicio As TimeSpan
        Dim colores As Color = dgvPrograma.DefaultCellStyle.ForeColor
        Dim colorNuevo As Color
        Dim Activo As Integer = -1
        If (Now.Date >= dtp.Value.Date) Then
            For i As Integer = 0 To dgvPrograma.Rows.Count - 1
                inicio = TimeSpan.Parse(dgvPrograma.Rows(i).Cells(0).Value())
                fin = TimeSpan.Parse(dgvPrograma.Rows(i).Cells(1).Value())
                If (inicio < Now.TimeOfDay Or Now.Date > dtp.Value.Date) Then
                    If (Now.TimeOfDay < fin And Now.Date = dtp.Value.Date) Then
                        colorNuevo = Color.FromArgb(245, 94, 94)
                        dgvPrograma.Rows(i).Selected = True
                        Activo = i
                    Else
                        colorNuevo = Color.FromArgb(154, 94, 245)
                    End If
                    dgvPrograma.Rows(i).DefaultCellStyle.ForeColor = colorNuevo
                Else
                    If Activo = -1 Then
                        Activo = i
                        dgvPrograma.Rows(i).Selected = True
                    End If
                End If

            Next
        End If
    End Sub
    Private Sub BWNumberOne_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWProgramas.RunWorkerCompleted
        ActualizarProgramas()
        Funcionarios()
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        BWProgramas.RunWorkerAsync()
    End Sub


    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GuardarNotas()
    End Sub

    Public Sub GuardarNotas()
        Dim ruta As String = "..\User\"
        Dim archivo As String = "Notas.txt"
        Dim escribir As New StreamWriter(ruta & archivo, False)
        escribir.Write(TBNotas.Text)
        escribir.Close()
    End Sub
    Public Sub LeerNotas()
        Dim ruta As String = "..\User\"
        Dim archivo As String = "Notas.txt"
        If File.Exists(ruta & archivo) Then
            TBNotas.Text = ""
            Dim leer As New StreamReader(ruta & archivo)
            TBNotas.Text = leer.ReadToEnd()
            leer.Close()
        End If
    End Sub

    Private Sub BWDPRogramas_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWDPRogramas.DoWork
        If (dgvPrograma.Rows.Count > 0) Then
            Dim idRow As Integer = dgvPrograma.SelectedRows(0).Index
            If (idRow >= 0) And Not IsNothing(dt_programa) Then
                Dim id As Integer = CInt(dt_programa.Rows(idRow)(0).ToString)
                dt_dprograma = ModConector.AFPrograma(id)
                DescripcionP = ModConector.ADPrograma(id)
            End If
        Else
            dt_dprograma = Nothing
        End If
    End Sub

    Private Sub BWDPRogramas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWDPRogramas.RunWorkerCompleted
        dgvFuncionarios.Columns.Clear()
        If IsNothing(dt_dprograma) Then
            dt_dprograma = New DataTable
            dgvFuncionarios.Columns.Add("FNombre", "Nombre")
            dgvFuncionarios.Columns.Add("FTelefono", "Telefono")
        End If
        dgvFuncionarios.DataSource = dt_dprograma
        dgvFuncionarios.ClearSelection()
        TBDescripcion.Text = DescripcionP
        If Ejecucion = -1 Then
            BWTandas.RunWorkerAsync()
            Ejecucion = 0
        End If
    End Sub
    Public Sub Funcionarios()
        If Not (BWDPRogramas.IsBusy) Then
            If Not (BWProgramas.IsBusy) Then
                BWDPRogramas.RunWorkerAsync()
            End If
        End If
    End Sub
    Private Sub dgvPrograma_Click(sender As Object, e As EventArgs) Handles dgvPrograma.Click
        Funcionarios()
    End Sub

    Private Sub BWEventos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWEventos.DoWork
        dt_evento = ModConector.AEventos()
    End Sub

    Private Sub BWEventos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWEventos.RunWorkerCompleted
        ActualizarEvento()
        If Ejecucion = -1 Then
            BWProgramas.RunWorkerAsync()
        End If
    End Sub

    Private Sub dgvPrograma_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograma.CellContentClick

    End Sub

    Private Sub BWPublicidades_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWPublicidades.DoWork
        If (dgvTandas.Rows.Count > 0) Then
            Dim Hora As TimeSpan = TimeSpan.Parse(dgvTandas.SelectedRows(0).Cells(0).Value)
            If Not IsNothing(dt_tandas) Then
                dt_publi = ModConector.APublicidad(dtpTanda.Value.Date, Hora)
            End If
        Else
            dt_publi = Nothing
        End If
    End Sub

    Private Sub BWPublicidades_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWPublicidades.RunWorkerCompleted
        dgvPublicidades.Columns.Clear()
        If IsNothing(dt_publi) Then
            dt_publi = New DataTable
            dgvPublicidades.Columns.Add("PDescripcion", "Descripcion")
        End If
        dgvPublicidades.DataSource = dt_publi
        dgvPublicidades.ClearSelection()
    End Sub

    Private Sub BWTandas_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWTandas.DoWork
        dt_tandas = ModConector.ATandas()
    End Sub

    Private Sub BWTandas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWTandas.RunWorkerCompleted
        dgvTandas.Columns.Clear()
        If Not IsNothing(dt_tandas) Then
            dgvTandas.DataSource = dt_tandas
        Else
            dt_tandas = New DataTable
            dgvTandas.DataSource = dt_tandas
            dgvTandas.Columns.Add("TInicio", "Inicio")
            dgvTandas.Columns.Add("TFinal", "Final")
        End If
        BWPublicidades.RunWorkerAsync()
    End Sub

    Private Sub dtpTanda_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanda.ValueChanged
        BWPublicidades.RunWorkerAsync()
    End Sub

    Private Sub dgvTandas_Click(sender As Object, e As EventArgs) Handles dgvTandas.Click
        If BWPublicidades.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub
End Class
