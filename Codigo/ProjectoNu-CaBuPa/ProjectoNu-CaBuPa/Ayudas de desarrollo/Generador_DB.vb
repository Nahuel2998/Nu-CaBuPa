Imports MySql.Data.MySqlClient

Public Class Generador_DB
    Dim dt As New DataTable
    Dim nTabla As String = ""
    Private Sub Generador_DB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTablas.DataSource = ESQLSelect("show tables")
        cbTablas.ValueMember = "Tables_in_jvrpdatabase"
        nTabla = "acceso"
    End Sub

    Private Sub btnCTabla_Click(sender As Object, e As EventArgs) Handles btnCTabla.Click
        ModLog.Guardar(nTabla)
        dt = New DataTable
        dt = ESQLSelect("describe " + nTabla)
        dgvTabla.DataSource = dt
        For i As Integer = 5 To 1 Step -1
            dgvTabla.Columns.RemoveAt(i)
        Next
        dgvTabla.Columns.Add("Datos", "Datos")
        dgvTabla.Columns.Add("Mantener", "Mantener")
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim Consulta As String() = GeneradorDeString()
        ModConector.ISQL(nTabla, Consulta(0), Consulta(1))
        Limpiador()
    End Sub
    Public Sub Limpiador()
        For i As Integer = 0 To dgvTabla.Rows.Count - 1
            If IsNothing(dgvTabla.Rows(i).Cells(2).Value) Then
                dgvTabla.Rows(i).Cells(1).Value = ""
            End If
        Next
    End Sub
    Private Function GeneradorDeString() As String()
        Dim Texto As String() = {"", ""}
        For i As Integer = 0 To dgvTabla.Rows.Count - 1
            If dt.Rows(i).Item(3).ToString() = "no" Or Not String.IsNullOrWhiteSpace(dgvTabla.Rows(i).Cells(1).Value.ToString()) Then
                Texto(0) += dgvTabla.Rows(i).Cells(0).Value.ToString() + ","
                Texto(1) += "'" + dgvTabla.Rows(i).Cells(1).Value.ToString() + "',"

            End If
        Next
        Texto(0) = Texto(0).Remove(Texto(0).Length - 1)
        Texto(1) = Texto(1).Remove(Texto(1).Length - 1)
        ModLog.Guardar(Texto(0) + Texto(1))
        Return Texto
    End Function

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Limpiador()
    End Sub

    Private Sub cbTablas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTablas.SelectedValueChanged
        If nTabla <> "" Then

            nTabla = cbTablas.SelectedValue
        End If
    End Sub
End Class