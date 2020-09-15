Module ModTablas
    Public dt_programa As DataTable
    Public dt_dprograma As DataTable
    Public dt_evento As DataTable
    Public dt_tandas As DataTable
    Public dt_publi As DataTable
    Public dt_Ppubli As DataTable
    Public dt_Video As DataTable
    Public Sub ActualizarTabla(ByRef Tabla As DataTable, ByRef Dgv As DataGridView)
        If Not IsNothing(Tabla) Then
            Dgv.Columns.Clear()
            Dgv.DataSource = Tabla
            Dgv.Refresh()
        Else
            If (Dgv.Rows.Count > 0) Then
                Dgv.DataSource.Rows.Clear()
                Dgv.Refresh()
            End If
        End If
    End Sub

    Public Sub PrepararUpdate(ByVal tabla As String, ByVal datos() As String, ByVal id As String)
        Dim res As String = ""
        Dim dt As DataTable = ESQLSelect("describe " + tabla)
        Dim i As Integer = 1
        For Each dato In datos
            res += String.Format("{0} = '{1}',", dt.Rows(i).Item(0).ToString, dato)
            i += 1
        Next
        res = res.Remove(res.Length - 1)
        USQL(tabla, res, String.Format("{0} = '{1}'", dt.Rows(0).Item(0).ToString, id))
    End Sub
End Module
