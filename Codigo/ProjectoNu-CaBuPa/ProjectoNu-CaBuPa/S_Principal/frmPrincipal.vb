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
        ActualizarTablaC(dt_evento, dgvEventos)
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
        'ActualizarProgramas()
        ActualizarTablaC(dt_programa, dgvPrograma)
        dgvProgramaColor()
        Funcionarios()
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
        ActualizarTablaC(dt_dprograma, dgvFuncionarios)
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

    Private Sub dgvPrograma_Click(sender As Object, e As EventArgs)
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

    Private Sub BWTandas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWTandas.RunWorkerCompleted
        Tandas()
        BWPublicidades.RunWorkerAsync()
    End Sub


    Private Sub dgvTandas_Click(sender As Object, e As EventArgs) Handles dgvTandas.Click
        If Not BWPublicidades.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If Not BWProgramas.IsBusy Then
            BWProgramas.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtpTanda_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanda.ValueChanged
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
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtVnombre.Text)) Then
            condicion = String.Format("v.nombre like '%{0}%'", txtVnombre.Text)
        End If
        If (cbFecha.Checked) Then
            condicion += String.Format(" and fecha = '{0}'", Format(dtpfechavideo.Value, "yyyy-MM-dd").ToString)
        End If
        If (Not String.IsNullOrWhiteSpace(txtVcontenido.Text)) Then
            condicion += String.Format(" and v.contenido like '%{0}%'", txtVcontenido.Text)
        End If
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("id_video, fecha as Fecha, v.nombre as Nombre, (select s.nombre from serie s where s.id_serie=v.id_serie) as Serie", "video v", condicion))
        End If
    End Sub

    Private Sub BWBuscador_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWBuscador.RunWorkerCompleted
        Select Case TBuscada
            Case "Video"
                dt_Video = TBusca
                ActualizarTablaC(dt_Video, dgvVB)
            Case "Serie"
                dt_Serie = TBusca
                ActualizarTablaC(dt_Serie, dgvBS)
            Case "Empresa"
                dt_Empresa = TBusca
                ActualizarTablaC(dt_Empresa, dgvClientes)
            Case "Programa"
                dt_BPrograma = TBusca
                ActualizarTablaC(dt_BPrograma, dgvBProgramas)
        End Select
        TBusca = Nothing
        TBuscada = ""
    End Sub


    Private Sub DgvVB_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVB.CellDoubleClick
        Dim i As Integer = CargarID(dt_Video, dgvVB)
        If (i <> -1) Then
            Dim formVideo As New frmVideo(i)
            AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
            formVideo.ShowDialog()
        End If
    End Sub

    Private Sub btnLimpiarBS_Click(sender As Object, e As EventArgs) Handles btnLimpiarBS.Click
        txtBSnombre.Clear()
        ctpSerie.Value = Now.Date
        cbS.Checked = False
        ActualizarTabla(Nothing, dgvBS)
    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Refresh()
    End Sub

    Private Sub btnlimpiarv_Click(sender As Object, e As EventArgs) Handles btnlimpiarv.Click
        txtVcontenido.Clear()
        txtVnombre.Clear()
        dtpfechavideo.Value = Now.Date
        cbFecha.Checked = False
        ActualizarTabla(Nothing, dgvVB)
    End Sub

    Private Sub btnBuscarBS_Click(sender As Object, e As EventArgs) Handles btnBuscarBS.Click
        TBuscada = "Serie"
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtBSnombre.Text)) Then
            condicion = "nombre like '%" + txtBSnombre.Text + "%'"
        End If
        If (cbS.Checked) Then
            condicion += String.Format(" and fecha_finalizacion = '{0}'", Format(ctpSerie.Value, "yyyy-MM-dd").ToString)
        End If
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("id_serie, fecha_finalizacion as Fecha, nombre as Nombre", "serie", condicion))
        End If
    End Sub

    Private Sub dgvBS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBS.CellDoubleClick
        Dim i() As String = CargarID(dt_Serie, dgvBS, {0, 1, 2})
        If (i.Length <> 1) Then
            Dim formSerie As New frmSerie(i)
            AddHandler formSerie.FormClosed, AddressOf FormSerie_FormClosed
            formSerie.ShowDialog()
        Else
            ' FIXME: Remove this, es de debug.
            'TBNotas.Text += "a"
            'Removido
        End If
    End Sub

    Private Sub FormVideo_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnbuscarv.PerformClick()
    End Sub

    Private Sub FormSerie_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnBuscarBS.PerformClick()
    End Sub

    Private Sub dgvVB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVB.CellClick
        ClickCheck(dgvVB)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If Not IsNothing(dt_Video) Then
            If dt_Video.Rows.Count > 0 Then
                Dim Id() As String = ObtenerCheck(dt_Video, dgvVB)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado("Video", Id, False)
                    formDelete.ShowDialog(Me)
                    btnbuscarv.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub btnBorrarS_Click(sender As Object, e As EventArgs) Handles btnBorrarS.Click
        If Not IsNothing(dt_Serie) Then
            If dt_Serie.Rows.Count > 0 Then
                Dim Id() As String = ObtenerCheck(dt_Serie, dgvBS)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado("Serie", Id, False)
                    formDelete.ShowDialog(Me)
                    btnBuscarBS.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub dgvBS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBS.CellClick
        ClickCheck(dgvBS)
    End Sub

    Private Sub btnIngresarV_Click(sender As Object, e As EventArgs) Handles btnIngresarV.Click
        Dim formVideo As New frmVideo(-1)
        AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
        formVideo.ShowDialog()
    End Sub

    Private Sub btnsIngresar_Click(sender As Object, e As EventArgs) Handles btnsIngresar.Click
        Dim formSerie As New frmSerie({-1, Now.Date.ToString, ""})
        AddHandler formSerie.FormClosed, AddressOf FormSerie_FormClosed
        formSerie.ShowDialog()
    End Sub

    Private Sub btncBuscar_Click(sender As Object, e As EventArgs) Handles btncBuscar.Click
        TBuscada = "Empresa"
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtCNombre.Text)) Then
            condicion = "Nombre like '%" + txtCNombre.Text + "%'"
        End If
        If (Not String.IsNullOrWhiteSpace(txtCTel.Text)) Then
            condicion += " and Telefono = '" + txtCTel.Text + "'"
        End If
        If (Not String.IsNullOrWhiteSpace(txtCMail.Text)) Then
            condicion += " and Mail = '" + txtCMail.Text + "'"
        End If
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("id_Empresa, Nombre, Telefono, Mail", "empresa", condicion))
        End If
    End Sub

    Private Sub btncBorrar_Click(sender As Object, e As EventArgs) Handles btncBorrar.Click
        If Not IsNothing(dt_Empresa) Then
            If (dt_Empresa.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_Empresa, dgvClientes)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado("Empresa", Id, False)
                    formDelete.ShowDialog(Me)
                    btncBuscar.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        ClickCheck(dgvClientes)
    End Sub
    Private Sub FormCliente_FormClosed(sender As Object, e As FormClosedEventArgs)
        btncBuscar.PerformClick()
    End Sub
    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        Dim i() As String = CargarID(dt_Empresa, dgvClientes, {0, 1, 2, 3})
        If (i.Length <> 1) Then
            Dim formCliente As New frmEmpresa(i)
            AddHandler formCliente.FormClosed, AddressOf FormCliente_FormClosed
            formCliente.ShowDialog()
        Else
            TBNotas.Text += "a"
        End If
    End Sub

    Private Sub btncIngresar_Click(sender As Object, e As EventArgs) Handles btncIngresar.Click
        Dim formCliente As New frmEmpresa({-1, "", "", ""})
        formCliente.ShowDialog()
    End Sub

    Private Sub btncLimpiar_Click(sender As Object, e As EventArgs) Handles btncLimpiar.Click
        txtCNombre.Clear()
        txtCMail.Clear()
        txtCTel.Clear()
        ActualizarTabla(Nothing, dgvClientes)
    End Sub

    Private Sub btnLimpiarBP_Click(sender As Object, e As EventArgs) Handles btnLimpiarBP.Click
        txtNombreBP.Clear()
        txtDescripcionBP.Clear()
        ActualizarTabla(Nothing, dgvBProgramas)
    End Sub

    Private Sub btnBuscarBP_Click(sender As Object, e As EventArgs) Handles btnBuscarBP.Click
        TBuscada = "Programa"
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If Not String.IsNullOrWhiteSpace(txtNombreBP.Text) Then
            condicion = String.Format("Nombre_Programa like '%{0}%'", txtNombreBP.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtDescripcionBP.Text) Then
            condicion += String.Format("Descripcion like '%{0}%'", txtDescripcionBP.Text)
        End If
        If Not BWBuscador.IsBusy Then
            BWBuscador.RunWorkerAsync(PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
        End If
    End Sub

    Private Sub btnBorrarBP_Click(sender As Object, e As EventArgs) Handles btnBorrarBP.Click
        If Not IsNothing(dt_BPrograma) Then
            If dt_BPrograma.Rows.Count > 0 Then
                Dim Id() As String = ObtenerCheck(dt_BPrograma, dgvBProgramas)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado("Programa", Id, False)
                    formDelete.ShowDialog(Me)
                    btnBuscarBP.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub dgvBProgramas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBProgramas.CellClick
        ClickCheck(dgvBProgramas)
    End Sub

    Private Sub dgvBProgramas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBProgramas.CellDoubleClick
        Dim i() As String = CargarID(dt_BPrograma, dgvBProgramas, {0})
        If (i.Length <> 0) Then
            Dim formPrograma As New frmPrograma(i(0))
            'AddHandler formSerie.FormClosed, AddressOf FormSerie_FormClosed
            formPrograma.ShowDialog()
        End If


    End Sub

    Private Sub dgvPrograma_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograma.CellDoubleClick
        Dim i() As String = CargarID(dt_programa, dgvPrograma, {0})
        If (i.Length <> 0) Then
            Dim formPrograma As New frmPrograma(i(0))
            'AddHandler formSerie.FormClosed, AddressOf FormSerie_FormClosed
            formPrograma.ShowDialog()
        End If
    End Sub

    Private Sub btnIngresarBP_Click(sender As Object, e As EventArgs) Handles btnIngresarBP.Click
        Dim formPrograma As New frmPrograma(-1)
        formPrograma.ShowDialog()
    End Sub
End Class
