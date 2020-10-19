Imports System.Text.RegularExpressions

Module ModTablas
    Public dt_programa As DataTable
    Public dt_BPrograma As DataTable
    Public dt_dprograma As DataTable
    Public dt_evento As DataTable
    Public dt_tandas As DataTable
    Public dt_publi As DataTable
    Public dt_Ppubli As DataTable
    Public dt_BPubli As DataTable
    Public dt_Video As DataTable
    Public dt_Serie As DataTable
    Public dt_Empresa As DataTable
    Public Function ValidarEmail(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
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
    Public Sub ClickCheck(ByRef Dgv As DataGridView)
        If Dgv.Rows.Count > 0 Then
            Dgv.SelectedRows(0).Cells(Dgv.Columns.Count - 1).Value = Not Dgv.SelectedRows(0).Cells(Dgv.Columns.Count - 1).Value
        End If
    End Sub
    Public Function ObtenerCheck(ByRef Tabla As DataTable, ByRef Dgv As DataGridView, Optional ByVal Col As Integer = 0) As String()
        Dim UltiCol As Integer = Dgv.Columns.Count - 1
        Dim Ids(Dgv.Rows.Count - 1) As String
        Dim Valores As Integer = 0
        For i As Integer = 0 To Dgv.Rows.Count - 1
            If (Dgv.Rows(i).Cells(UltiCol).Value = True) Then
                Ids(i) = Tabla.Rows(i).Item(Col).ToString
                Valores += 1
            Else
                Ids(i) = ""
            End If
        Next
        Dim ID(Valores - 1) As String
        Dim iter As Integer = 0
        For Each i As String In Ids
            If (i <> "") Then
                ID(iter) = i
                iter += 1
            End If
        Next
        Return ID
    End Function

    Public Sub ActualizarTablaC(ByRef Tabla As DataTable, ByRef Dgv As DataGridView, Optional C As Boolean = True)
        If Not IsNothing(Tabla) Then
            Dim Tamanos(Dgv.Columns.Count() - 1) As Single
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Tamanos(i) = Dgv.Columns(i).FillWeight()
            Next
            Dim Columna As DataGridViewColumn
            Columna = Dgv.Columns(Tamanos.Length - 1)
            Columna.ReadOnly = False
            Dgv.Columns.Clear()
            Dgv.DataSource = Tabla
            If (Tabla.Columns.Count > 1 And C) Then
                Dgv.Columns.RemoveAt(0)
            End If
            If ((Tabla.Columns.Count = Tamanos.Length And C) Or (Not C And Tabla.Columns.Count = Tamanos.Length - 1)) Then
                Dgv.Columns.Add(Columna)
            End If
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Dgv.Columns(i).FillWeight() = Tamanos(i)
                Dgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                Dgv.Columns(i).ReadOnly = If(Tabla.Columns.Count = Tamanos.Length, False, True)
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
    Public Sub PrepararInsert(ByVal tabla As String, ByVal datos() As String, Optional Inicio As Integer = 1)
        Dim col As String = ""
        Dim valu As String = ""
        Dim dt As DataTable = ESQLSelect("describe " + tabla)
        Dim i As Integer = Inicio
        For Each dato In datos
            col += String.Format("{0},", dt.Rows(i).Item(0).ToString)
            valu += String.Format(If(dato = "null" Or dato.Contains("("), "{0},", "'{0}',"), dato)
            i += 1
        Next
        col = col.Remove(col.Length - 1)
        valu = valu.Remove(valu.Length - 1)
        ISQL(tabla, col, valu)
    End Sub
    Public Sub PrepararUpdate(ByVal tabla As String, ByVal Columna() As String, ByVal datos() As String, ByVal Condiciones() As String, ByVal id() As String)
        Dim res As String = ""
        Dim i As Integer = 0
        For Each dato In datos
            res += String.Format(If(dato = "null", "{0} = {1},", "{0} = '{1}',"), Columna(i), dato)
            i += 1
        Next
        i = 0
        res = res.Remove(res.Length - 1)
        Dim condicion As String = ""
        For Each con In Condiciones
            condicion += String.Format(If(id(i) = "null", "{0} = {1} and", "{0} = '{1}' and"), con, id(i))
            i += 1
        Next
        condicion = condicion.Remove(condicion.Length - 4)
        USQL(tabla, res, condicion)
    End Sub
    Public Sub PrepararDelete(ByVal tabla As String, ByVal datos() As String, ByVal ids() As String)
        Dim res As String = ""
        Dim i As Integer = 0
        For Each dato In datos
            res += String.Format(If(ids(i) = "null", "{0} = {1} and", "{0} = '{1}' and"), datos(i), ids(i))
            i += 1
        Next
        res = res.Remove(res.Length - 3)
        BSQL(tabla, res)
    End Sub
    Public Sub PrepararDelete(ByVal tabla As String, ByVal datos As String, ByVal ids() As String)
        Dim res As String = datos + " in ("
        For Each id In ids
            res += String.Format(If(id = "null", "{0} ,", "'{0}' ,"), id)
        Next
        res = res.Remove(res.Length - 1)
        res += ")"
        BSQL(tabla, res)
    End Sub
    Public Function CreadorCondicion(ByVal datos As String, ByVal ids() As String)
        Dim res As String = datos + " in ("
        For Each id In ids
            res += String.Format(If(id = "null", "{0} ,", "'{0}' ,"), id)
        Next
        res = res.Remove(res.Length - 1)
        res += ")"
        Return res
    End Function

    Public Function BuscarDatos(ByVal tabla As String, ByVal Columnas() As String, ByVal campo As String, ByVal id As String) As String()
        Dim res As String = ""
        Dim resultado(Columnas.Length - 1) As String
        For Each columna In Columnas
            res += String.Format("{0}, ", columna)
        Next
        res = res.Remove(res.Length - 2)
        Dim dtN As DataTable = DevolverTabla(PSQL(res, tabla, String.Format("{0} = '{1}'", campo, id)))
        'ModLog.Guardar(PSQL(res, tabla, String.Format("{0} = '{1}'", campo, id)))
        If (Not IsNothing(dtN)) Then
            For j As Integer = 0 To dtN.Columns.Count - 1
                resultado(j) = dtN.Rows(0).Item(j).ToString
            Next
        End If
        Return resultado
    End Function
    Public Sub CargarListBox(ByRef lis As CheckedListBox, ByVal dt As DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1
            lis.Items.Add(dt.Rows(i).Item(1).ToString + dt.Rows(i).Item(1).ToString)
        Next
    End Sub
    Public Sub LlenarCombo(ByRef con As ComboBox, ByVal dt As DataTable, ByVal col As String)
        con.Items.Clear()
        con.Items.Add("No está relacionado")
        If (Not IsNothing(dt)) Then
            If (dt.Rows.Count > 0) Then
                For j As Integer = 0 To dt.Rows.Count - 1
                    con.Items.Add(dt.Rows(j).Item(col).ToString)
                Next
            End If
        End If
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
