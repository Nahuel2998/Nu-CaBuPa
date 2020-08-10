Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class frmPrincipal
    Private dt_programa As DataTable
    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.85
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        BWNumberOne.RunWorkerAsync()
    End Sub

    Private Sub BWNumberOne_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWNumberOne.DoWork
        dt_programa = ModConector.APrograma(dtp.Value.Date)
    End Sub
    Private Sub ActualizarProgramas()
        For i As Integer = 0 To dgvPrograma.Columns.Count - 1
            dgvPrograma.Columns.RemoveAt(0)
        Next
        If Not IsNothing(dt_programa) Then
            dgvPrograma.DataSource = dt_programa
            dgvProgramaColor()
            For i As Integer = 0 To dgvPrograma.Columns.Count - 1
                dgvPrograma.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End If
    End Sub
    Public Sub dgvProgramaColor()
        Dim fin As TimeSpan
        Dim inicio As TimeSpan
        Dim colores As Color
        If (Now.Date >= dtp.Value.Date) Then
            For i As Integer = 0 To dgvPrograma.Rows.Count - 1
                inicio = dgvPrograma.Rows(i).Cells(0).Value()
                fin = dgvPrograma.Rows(i).Cells(1).Value()
                colores = dgvPrograma.Rows(i).DefaultCellStyle.BackColor

                If (inicio < Now.TimeOfDay) Then
                    If (Now.TimeOfDay < fin And Now.Date = dtp.Value.Date) Then

                        dgvPrograma.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(colores.R * 1.5, 0, 0)

                    Else
                        dgvPrograma.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(colores.R * 1.5, 0, colores.B * 1.5)

                    End If
                    dgvPrograma.Rows(i).DefaultCellStyle.ForeColor = Color.FromArgb(235, 235, 235)
                End If

            Next
        End If
    End Sub
    Private Sub BWNumberOne_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWNumberOne.RunWorkerCompleted
        ActualizarProgramas()
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        BWNumberOne.RunWorkerAsync()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        DataGridView1.RowHeadersVisible = False
    End Sub

    Private Sub dgvPrograma_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograma.CellContentClick

    End Sub

    Private Sub dgvvideo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub pCMain_Paint(sender As Object, e As PaintEventArgs) Handles pCMain.Paint

    End Sub
End Class
