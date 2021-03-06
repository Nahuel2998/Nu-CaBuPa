﻿Public Class frmTandas
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
        hora1 = Convert.ToDateTime(Dia(Now.Date) + " " + MysqlHM(dtpHI.Value))
        hora2 = Convert.ToDateTime(Dia(Now.Date) + " " + MysqlHM(dtpHF.Value))

        If (dgvTandas.Rows.Count > 0) Then
            For i As Integer = 0 To dgvTandas.Rows.Count - 1
                Dim horaN1 As DateTime = Convert.ToDateTime(Dia(Now.Date) + " " + dgvTandas.Rows(i).Cells(0).Value().ToString)
                Dim horaN2 As DateTime = Convert.ToDateTime(Dia(Now.Date) + " " + dgvTandas.Rows(i).Cells(1).Value().ToString)
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


    Private Sub frmTandas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarT()
        HORAIF(dtpHI)
        HORAIF(dtpHF)
        If Not PoseePermiso("Tanda", "a") Then
            btnBorrar.Visible = False
            btnIngresar.Visible = False
        End If
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
    Private Sub dgvHeaderClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTandas.ColumnHeaderMouseClick
        CheckAll(sender, e.ColumnIndex)
    End Sub

    Private Sub dtpHI_ValueChanged(sender As Object, e As EventArgs) Handles dtpHI.ValueChanged
        If (dtpHF.Value < dtpHI.Value) Then
            dtpHF.Value = dtpHI.Value
        End If
        dtpHF.MinDate = dtpHI.Value
    End Sub
End Class