Public Class frmTandas
    Private hora1 As DateTime
    Private hora2 As DateTime
    Private dt_MTandas As DataTable
    Private Sub btnsalirt_Click(sender As Object, e As EventArgs) Handles btnsalirt.Click
        Close()
    End Sub
    Private Sub BuscarT()
        dt_MTandas = ATandas(False)
        ActualizarTablaC(dt_MTandas, dgvTandas, False)
    End Sub
    Private Sub FechasMax(Optional ingresar As Boolean = True)
        Try
            hora1 = dtpHI.Value
            hora2 = dtpHF.Value
        Catch e As Exception
            MessageBox.Show("Error del formato de fecha")
            Exit Sub
        End Try

        If (dgvTandas.Rows.Count > 0) Then
            For i As Integer = 0 To dgvTandas.Rows.Count - 1
                Dim horaN1 As DateTime = Convert.ToDateTime("31/10/2020 " + dgvTandas.Rows(i).Cells(0).Value().ToString)
                Dim horaN2 As DateTime = Convert.ToDateTime("31/10/2020 " + dgvTandas.Rows(i).Cells(1).Value().ToString)
                If (horaN1 < hora1 And horaN2 > hora1) Then
                    hora1 = horaN1
                End If
                If (horaN2 > hora2 And horaN1 < hora2) Then
                    hora2 = horaN2
                End If
            Next
            BSQL("tanda", String.Format("Hora_Inicio>='{0}' and Hora_fin<='{1}'", MysqlHM(hora1), MysqlHM(hora2)))
        End If
        If (ingresar) Then
            ISQL("tanda", "hora_inicio, hora_fin", String.Format("'{0}','{1}'", MysqlHM(hora1), MysqlHM(hora2)))
            USQL("aparecepubli", String.Format("hora_inicio='{0}'", MysqlHM(hora1)), String.Format("Hora_Inicio='{0}'", MysqlHM(hora1)))
        End If
        BuscarT()
    End Sub
    Private Function ceros(ByVal h As String) As String
        Dim hor As String = If(h.Length = 1, "0" + h, h)
        Return hor
    End Function
    Private Function MysqlHM(ByVal hora As DateTime) As String
        Dim h As String = String.Format("{0}:{1}:{2}", ceros(Hour(hora).ToString), ceros(Minute(hora)), ceros(Second(hora)))
        Return h
    End Function

    Private Sub frmTandas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarT()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        FechasMax()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If Not IsNothing(dt_MTandas) Then
            If (dt_MTandas.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_MTandas, dgvTandas, 0)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado(TANDASHORAS, Id, False)
                    formDelete.ShowDialog(Me)
                    BuscarT()
                End If
            End If
        End If
    End Sub

    Private Sub dgvTandas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTandas.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub

    Private Sub dtpHI_ValueChanged(sender As Object, e As EventArgs) Handles dtpHI.ValueChanged
        If (dtpHF.Value < dtpHI.Value) Then
            dtpHF.MinDate = dtpHI.Value
        End If
    End Sub

End Class