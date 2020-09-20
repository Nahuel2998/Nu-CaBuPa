Module ModTablas
    Public dt_programa As DataTable
    Public dt_dprograma As DataTable
    Public dt_evento As DataTable
    Public dt_tandas As DataTable
    Public dt_publi As DataTable
    Public dt_Ppubli As DataTable
    Public dt_Video As DataTable
    Public dt_Serie As DataTable
    Public Function CargarID(ByRef Tabla As DataTable, ByRef Dgv As DataGridView) As Integer
        If (Not IsNothing(Tabla)) Then
            Return Tabla.Rows(Dgv.SelectedRows(0).Index).Item(0).ToString
        End If
        Return -1
    End Function
    Public Function CargarID(ByRef Tabla As DataTable, ByRef Dgv As DataGridView, ByVal NumCol() As Byte) As String()
        If (Not IsNothing(Tabla)) Then
            Dim res(NumCol.Length - 1) As String
            Dim j As Byte = 0
            For Each i As Byte In NumCol
                res(j) = Tabla.Rows(Dgv.SelectedRows(0).Index).Item(i).ToString
                j += 1
            Next
            Return res
        End If
        Dim err(0) As String
        Return err
    End Function

    Public Sub ActualizarTabla(ByRef Tabla As DataTable, ByRef Dgv As DataGridView)
        If Not IsNothing(Tabla) Then
            Dim Tamanos(Dgv.Columns.Count() - 1) As Single
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Tamanos(i) = Dgv.Columns(i).FillWeight()
            Next
            Dgv.Columns.Clear()
            Dgv.DataSource = Tabla
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Dgv.Columns(i).FillWeight() = Tamanos(i)
                Dgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            Dgv.Refresh()
        Else
            If (Dgv.Rows.Count > 0) Then
                Dgv.DataSource.Rows.Clear()
                Dgv.Refresh()
            End If
        End If
        Dgv.AllowUserToOrderColumns = False
    End Sub

    Public Sub ActualizarTablaC(ByRef Tabla As DataTable, ByRef Dgv As DataGridView)
        If Not IsNothing(Tabla) Then
            Dim Tamanos(Dgv.Columns.Count() - 1) As Single
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Tamanos(i) = Dgv.Columns(i).FillWeight()
            Next
            Dgv.Columns.Clear()
            Dgv.DataSource = Tabla
            Dgv.Columns.RemoveAt(0)
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Dgv.Columns(i).FillWeight() = Tamanos(i)
                Dgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
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
            res += String.Format(If(dato = "null", "{0} = {1},", "{0} = '{1}',"), dt.Rows(i).Item(0).ToString, dato)
            i += 1
        Next
        res = res.Remove(res.Length - 1)
        USQL(tabla, res, String.Format("{0} = '{1}'", dt.Rows(0).Item(0).ToString, id))
    End Sub

    Public Function BuscarDatos(ByVal tabla As String, ByVal Columnas() As String, ByVal campo As String, ByVal id As String) As String()
        Dim res As String = ""
        Dim resultado(Columnas.Length - 1) As String
        For Each columna In Columnas
            res += String.Format("{0}, ", columna)
        Next
        res = res.Remove(res.Length - 2)
        Dim dtN As DataTable = DevolverTabla(PSQL(res, tabla, String.Format("{0} = '{1}'", campo, id)))
        If (Not IsNothing(dtN)) Then
            For j As Integer = 0 To dtN.Columns.Count - 1
                resultado(j) = dtN.Rows(0).Item(j).ToString
            Next
        End If
        Return resultado
    End Function

    Public Sub LlenarCombo(ByRef con As ComboBox, ByVal dt As DataTable, ByVal col As String)
        con.Items.Clear()
        con.Items.Add("No está relacionado")
        For j As Integer = 0 To dt.Rows.Count - 1
            con.Items.Add(dt.Rows(j).Item(col).ToString)
        Next
    End Sub

    Public Function CompararValores(ByVal s1() As String, ByVal s2() As String) As Boolean
        For j As Integer = 0 To s2.Length - 1
            If s1(j) <> s2(j) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function VaciarNull(ByVal s1() As String) As String()
        Dim sN(s1.Length - 1) As String
        For j As Integer = 0 To s1.Length - 1
            sN(j) = s1(j)
            If s1(j) = "null" Then
                sN(j) = ""
            End If
        Next
        Return sN
    End Function
End Module
