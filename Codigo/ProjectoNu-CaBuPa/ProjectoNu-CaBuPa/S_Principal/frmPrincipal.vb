Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmPrincipal
    Private dt_programa As DataTable
    Private dt_dprograma As DataTable
    Private DescripcionP As String
    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.85
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        BWProgramas.RunWorkerAsync()
        LeerNotas()
    End Sub

    Private Sub BWNumberOne_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWProgramas.DoWork
        dt_programa = ModConector.APrograma(dtp.Value.Date)
    End Sub
    Private Sub ActualizarProgramas()
        If Not IsNothing(dt_programa) Then
            dgvPrograma.Columns.Clear()
            dgvPrograma.DataSource = dt_programa
            dgvPrograma.Columns().RemoveAt(0)
            dgvProgramaColor()
            For i As Integer = 0 To dgvPrograma.Columns.Count - 1
                dgvPrograma.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
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

        Dim idRow As Integer = dgvPrograma.SelectedRows(0).Index
        Dim id As Integer = CInt(dt_programa.Rows(idRow)(0).ToString)
        dt_dprograma = ModConector.AFPrograma(id)
        DescripcionP = ModConector.ADPrograma(id)
    End Sub

    Private Sub BWDPRogramas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWDPRogramas.RunWorkerCompleted
        dgvFuncionarios.DataSource = dt_dprograma
        TBDescripcion.Text = DescripcionP
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

    Private Sub frmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class
