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
End Module
