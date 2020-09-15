Module ModTablas
    Public dt_programa As DataTable
    Public dt_dprograma As DataTable
    Public dt_evento As DataTable
    Public dt_tandas As DataTable
    Public dt_publi As DataTable
    Public dt_Ppubli As DataTable
    Public dt_Video As DataTable
    Public Function CargarID(ByRef Tabla As DataTable, ByRef Dgv As DataGridView) As Integer
        Return Tabla.Rows(Dgv.SelectedRows(0).Index).Item(0).ToString
    End Function
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
    Public Sub ActualizarTablaC(ByRef Tabla As DataTable, ByRef Dgv As DataGridView)
        ActualizarTabla(Tabla, Dgv)
        Dgv.Columns.RemoveAt(0)
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
    Public Function BuscarDatos(ByVal tabla As String, ByVal Columnas() As String, ByVal campo As String, ByVal id As String) As String()
        Dim res As String = ""
        Dim i As Integer = 1
        Dim resultado(Columnas.Length) As String
        For Each columna In Columnas
            res += String.Format("{0},", columna)
            i += 1
        Next
        res = res.Remove(res.Length - 1)
        Dim dtN As DataTable = DevolverTabla(PSQL(res, tabla, String.Format("{0} = '{1}'", campo, id)))
        For j As Integer = 0 To dtN.Rows.Count
            resultado(j) = dtN.Rows(0).Item(j).ToString
        Next
        Return resultado
    End Function
End Module
