Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmPrincipal
    Private DescripcionP As String
    Private PNombre As String = "Datos del programa"
    Private TBuscada As String = ""
    Private TBusca As New DataTable
    Public dt_Buscada As New DataTable
#Region "Carga y descarga"
    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ModConector.desconectar()
        End
    End Sub
    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GuardarNotas()
    End Sub
    Public Sub EPropiedades()
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.85
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        dtp.BackColor = Color.FromArgb(64, 64, 64)
        dtp.ForeColor = Color.White
        dtpTanda.BackColor = Color.FromArgb(64, 64, 64)
        dtpTanda.ForeColor = Color.White
    End Sub
    Public Sub ONBW()
        BWProgramas.RunWorkerAsync()
        BWTandas.RunWorkerAsync()
        BWEventos.RunWorkerAsync()
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EPropiedades()
        ONBW()
        LeerNotas()
    End Sub
#End Region

    Private Sub BWNumberOne_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWProgramas.DoWork
        dt_programa = ModConector.APrograma(dtp.Value.Date)
    End Sub
    Private Sub ActualizarProgramas()
        dgvPrograma.Columns.Clear()
        If Not IsNothing(dt_programa) Then
            dgvPrograma.DataSource = dt_programa
            dgvPrograma.Columns().RemoveAt(0)

            dgvPrograma.Columns.Add("PEstado", "Estado")
            dgvProgramaColor()
            For i As Integer = 0 To dgvPrograma.Columns.Count - 1
                dgvPrograma.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        Else
            dt_programa = New DataTable
            dgvPrograma.DataSource = dt_programa
            dgvPrograma.Columns.Add("PInicio", "Inicio")
            dgvPrograma.Columns.Add("PFinal", "Final")
            dgvPrograma.Columns.Add("PPrograma", "Programa")
            dgvPrograma.Columns.Add("PEstado", "Estado")
        End If


    End Sub
    Private Sub ActualizarEvento()
        ActualizarTabla(dt_evento, dgvEventos)
        dgvEventos.Columns().RemoveAt(0)
        dgvEventos.ClearSelection()
    End Sub
    Public Sub dgvProgramaColor()
        Dim fin As TimeSpan
        Dim inicio As TimeSpan
        Dim colores As Color = dgvPrograma.DefaultCellStyle.ForeColor
        Dim colorNuevo As Color
        Dim estado As String
        Dim Activo As Integer = -1
        If (Now.Date >= dtp.Value.Date) And dgvPrograma.Rows.Count > 0 Then
            For i As Integer = 0 To dgvPrograma.Rows.Count - 1
                If Not (TimeSpan.TryParse(dgvPrograma.Rows(i).Cells(0).Value().ToString, inicio) And TimeSpan.TryParse(dgvPrograma.Rows(i).Cells(1).Value().ToString, fin)) Then
                    Exit Sub
                End If
                If (inicio < Now.TimeOfDay Or Now.Date > dtp.Value.Date) Then
                    If (Now.TimeOfDay < fin And Now.Date = dtp.Value.Date) Then
                        colorNuevo = Color.FromArgb(245, 94, 94)
                        estado = "Activo"
                        dgvPrograma.Rows(i).Selected = True
                        Activo = i
                    Else
                        estado = "Finalizado"
                        colorNuevo = Color.FromArgb(154, 94, 245)
                    End If

                    dgvPrograma.Rows(i).Cells(dgvPrograma.Rows(i).Cells.Count - 1).Style.ForeColor = colorNuevo
                Else
                    If Activo = -1 Then
                        Activo = i
                        dgvPrograma.Rows(i).Selected = True
                    End If
                    estado = "Activo"
                End If
                dgvPrograma.Rows(i).Cells(dgvPrograma.Rows(i).Cells.Count - 1).Value = estado
            Next
        Else
            For i As Integer = 0 To dgvPrograma.Rows.Count - 1
                dgvPrograma.Rows(i).Cells(dgvPrograma.Rows(i).Cells.Count - 1).Value = "Proximo"
            Next
        End If
    End Sub
    Private Sub BWNumberOne_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWProgramas.RunWorkerCompleted
        ActualizarProgramas()
        Funcionarios()
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs)
        If Not BWProgramas.IsBusy Then
            BWProgramas.RunWorkerAsync()
        End If
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
        If (dgvPrograma.Rows.Count > 0) And dgvPrograma.SelectedRows.Count > 0 Then
            Dim idRow As Integer = dgvPrograma.SelectedRows(0).Index
            If (idRow >= 0) And Not IsNothing(dt_programa) Then
                Dim id As Integer = CInt(dt_programa.Rows(idRow)(0).ToString)
                dt_dprograma = ModConector.AFPrograma(id)
                DescripcionP = ModConector.ADPrograma(id)
                dt_Ppubli = ModConector.APPublicidad(dtp.Value.Date, id)
                PNombre = "Datos del programa : " + dt_programa.Rows(idRow)(3).ToString
            End If
        Else
            PNombre = "Datos del programa"
            dt_Ppubli = Nothing
            dt_dprograma = Nothing
        End If
    End Sub

    Private Sub BWDPRogramas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWDPRogramas.RunWorkerCompleted
        ActualizarTabla(dt_dprograma, dgvFuncionarios)
        ActualizarTabla(dt_publi, dgvPPublicidades)
        GBFuncionarios.Text = PNombre
        TBDescripcion.Text = DescripcionP
        dgvFuncionarios.ClearSelection()
        dgvPPublicidades.ClearSelection()
        dgvPrograma.ClearSelection()
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

    Private Sub BWEventos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWEventos.DoWork
        dt_evento = ModConector.AEventos()
    End Sub

    Private Sub BWEventos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWEventos.RunWorkerCompleted
        ActualizarEvento()
    End Sub


    Private Sub BWPublicidades_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWPublicidades.DoWork
        If dgvTandas.Rows.Count > 0 And dgvTandas.SelectedRows.Count > 0 Then
            Dim Hora As TimeSpan = TimeSpan.Parse(dgvTandas.SelectedRows(0).Cells(0).Value)
            If Not IsNothing(dt_tandas) Then
                dt_publi = ModConector.APublicidad(dtpTanda.Value.Date, Hora)
            End If
        Else
            dt_publi = Nothing
        End If
    End Sub

    Private Sub BWPublicidades_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWPublicidades.RunWorkerCompleted
        ActualizarTabla(dt_publi, dgvPublicidades)
    End Sub

    Private Sub BWTandas_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWTandas.DoWork
        dt_tandas = ModConector.ATandas()

    End Sub
    Public Sub Tandas()
        ActualizarTabla(dt_tandas, dgvTandas)
    End Sub
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
    Private Sub BWTandas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWTandas.RunWorkerCompleted
        Tandas()
        BWPublicidades.RunWorkerAsync()
    End Sub

    Private Sub dtpTanda_ValueChanged(sender As Object, e As EventArgs)
        If Not BWTandas.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub

    Private Sub dgvTandas_Click(sender As Object, e As EventArgs) Handles dgvTandas.Click
        If Not BWPublicidades.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtp_ValueChanged_1(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If Not BWProgramas.IsBusy Then
            BWProgramas.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtpTanda_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpTanda.ValueChanged
        If Not BWTandas.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub



    Private Sub BWBuscador_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWBuscador.DoWork
        TBusca = DevolverTabla(e.Argument)
        ModLog.Guardar(e.Argument)
    End Sub

    Private Sub btnbuscarv_Click(sender As Object, e As EventArgs) Handles btnbuscarv.Click
        TBuscada = "Video"
        Dim condicion As String = "true"
        If (Not String.IsNullOrWhiteSpace(txtVnombre.Text)) Then
            condicion = "v.nombre = '" + txtVnombre.Text + "'"
        End If
        If (cbFecha.Checked) Then
            condicion += " and fecha = '" + Format(CDate(dtpfechavideo.Value), "yyyy-MM-dd").ToString + "'"
        End If
        If (Not String.IsNullOrWhiteSpace(txtVcontenido.Text)) Then
            condicion += " and v.contenido = '" + txtVcontenido.Text + "'"
        End If
        BWBuscador.RunWorkerAsync(PSQL("fecha as Fecha, v.nombre as Nombre, (select s.nombre from serie s where s.id_serie=v.id_serie) as Serie", "video v", condicion))
    End Sub

    Private Sub BWBuscador_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWBuscador.RunWorkerCompleted
        Select Case TBuscada
            Case "Video"
                dt_Video = TBusca
                ActualizarTabla(dt_Video, dgvVB)
        End Select
        TBusca = Nothing
        TBuscada = ""
    End Sub
End Class
