Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmPrincipal
    Private DescripcionP As String
    Private PNombre As String = "Datos del programa"
    Private TBuscada As Byte = 0
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
        Width = Screen.PrimaryScreen.WorkingArea.Width * 0.85
        Height = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        CenterToScreen()
        dtp.BackColor = Color.FromArgb(64, 64, 64)
        dtp.ForeColor = Color.White
        dtpTanda.BackColor = Color.FromArgb(64, 64, 64)
        dtpTanda.ForeColor = Color.White
    End Sub
    Public Sub ONBW()
        BWProgramas.RunWorkerAsync()
        BWTandas.RunWorkerAsync(True)
        BWEventos.RunWorkerAsync()
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EPropiedades()
        ONBW()
        LeerNotas()
        QuitarTab()
    End Sub
    Private Sub QuitarTab()
        If Not (PoseePermiso("Programa")) Then
            tcSecciones.TabPages.RemoveByKey("tbMenu")
        Else
            If Not (PoseePermiso("Programa", "a")) Then
                tcPubli.TabPages.RemoveAt(2)
            End If
            If Not (PoseePermiso("Serie")) Then
                tcSecciones.TabPages.RemoveByKey("tbSeries")
            End If
        End If
        If Not (PoseePermiso("Video")) Then
            TabControl1.TabPages.RemoveByKey("tbVideo")
        End If
        If Not (PoseePermiso("Empresa")) Then
            tcSecciones.TabPages.RemoveByKey("tbEmpresa")
        End If
        If Not (PoseePermiso("Publicid")) Then
            tcSecciones.TabPages.RemoveByKey("tbPublicidad")
        Else
            If Not (PoseePermiso("Publicid", "a")) Then
                tcPubli.TabPages.RemoveAt(1)
            End If

        End If
        If Not (PoseePermiso("Funciona")) Then
            tcSecciones.TabPages.RemoveByKey("tbFuncionario")
        End If
        If Not (PoseePermiso("Evento")) Then
            tcSecciones.TabPages.RemoveByKey("tbEvento")
        End If
    End Sub
#End Region

    Private Sub BWNumberOne_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWProgramas.DoWork
        dt_programa = ModConector.APrograma(dtp.Value.Date)
    End Sub
    Private Sub Trabajando(sender As Object, e As DoWorkEventArgs) Handles BWBuscador.DoWork, BWDPRogramas.DoWork, BWEventos.DoWork, BWProgramas.DoWork, BWPublicidades.DoWork, BWTandas.DoWork
        sender.ReportProgress(1)
    End Sub
    Private Sub Trabajando() Handles BWBuscador.ProgressChanged, BWDPRogramas.ProgressChanged, BWEventos.ProgressChanged, BWProgramas.ProgressChanged, BWPublicidades.ProgressChanged, BWTandas.ProgressChanged
        lblStatus.Text = "Trabajando"
    End Sub
    Private Sub Descansando() Handles BWBuscador.RunWorkerCompleted, BWDPRogramas.RunWorkerCompleted, BWEventos.RunWorkerCompleted, BWProgramas.RunWorkerCompleted, BWPublicidades.RunWorkerCompleted, BWTandas.RunWorkerCompleted
        lblStatus.Text = "Listo"
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
        NumerTime(dt_programa, RecPA, 2)
        dgvProgramaColor()
        Funcionarios()
    End Sub

    Public Sub GuardarNotas()
        Dim ruta As String = "C:\Nu-CaBuPa\"
        Dim archivo As String = String.Format("Notas_{0}.txt", ModConector.DUsuario())
        Dim escribir As New StreamWriter(ruta & archivo, False)
        escribir.Write(TBNotas.Text)
        escribir.Close()
    End Sub

    Public Sub LeerNotas()
        Dim ruta As String = "C:\Nu-CaBuPa\"
        Dim archivo As String = String.Format("Notas_{0}.txt", ModConector.DUsuario())
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
                dt_dprograma = ModConector.AFPrograma(dtp.Value.Date, id)
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
        ActualizarTablaC(dt_dprograma, dgvFuncionarios, True, {0, 3})
        ActualizarTablaC(dt_Ppubli, dgvPPublicidades) 'fix
        GBFuncionarios.Text = PNombre
        TBDescripcion.Text = DescripcionP
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
        If PoseePermiso("Eventos") Then
            dt_evento = ModConector.AEventos()
        End If
    End Sub

    Private Sub BWEventos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWEventos.RunWorkerCompleted
        ActualizarEvento()
    End Sub

    Private Sub BWPublicidades_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWPublicidades.DoWork
        If dgvTandas.Rows.Count > 0 And dgvTandas.SelectedRows.Count > 0 Then
            Dim Horas As String = MysqlHM(CDate(CargarID(dt_tandas, dgvTandas, {0})(0)))
            If Not IsNothing(dt_tandas) Then
                dt_publi = ModConector.APublicidad(dtpTanda.Value, Horas, cbTodTand.Checked)
            End If
        Else
            dt_publi = Nothing
        End If
    End Sub

    Private Sub BWPublicidades_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWPublicidades.RunWorkerCompleted
        ActualizarTablaC(dt_publi, dgvPublicidades) 'fix
    End Sub

    Private Sub BWTandas_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWTandas.DoWork
        dt_tandas = ModConector.ATandas(e.Argument)
    End Sub
    Public Sub Tandas()
        ActualizarTablaC(dt_tandas, dgvTandas, False) 'fix
        NumerTime(dt_tandas, RecTan, 1)
    End Sub

    Private Sub BWTandas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWTandas.RunWorkerCompleted
        Tandas()
        If Not BWPublicidades.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
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
        If Not BWPublicidades.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub

    Private Sub BWBuscador_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWBuscador.DoWork
        TBusca = DevolverTabla(e.Argument)
        ModLog.Guardar(e.Argument)
    End Sub

    Private Sub btnbuscarv_Click(sender As Object, e As EventArgs) Handles btnbuscarv.Click
        TBuscada = VIDEO
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
            Case VIDEO
                dt_Video = TBusca
                ActualizarTablaC(dt_Video, dgvVB)
            Case SERIE
                dt_Serie = TBusca
                ActualizarTablaC(dt_Serie, dgvBS)
            Case EMPRESA
                dt_Empresa = TBusca
                ActualizarTablaC(dt_Empresa, dgvClientes)
            Case PROGRAMAS
                dt_BPrograma = TBusca
                ActualizarTablaC(dt_BPrograma, dgvBProgramas)
            Case PUBLICIDAD
                dt_BPubli = TBusca
                ActualizarTablaC(dt_BPubli, dgvPubliB)
            Case FUNCIONARIO
                dt_BFuncionario = TBusca
                ActualizarTablaC(dt_BFuncionario, dgvFuncionarioBF)
            Case FUNCION
                dt_BFuncion = TBusca
                ActualizarTablaC(dt_BFuncion, dgvFuncionesBFF)
            Case EVENTO
                dt_BEvento = TBusca
                ActualizarTablaC(dt_BEvento, dgvBEvento)
            Case GRAPUBLI
                dt_GraPubli = TBusca
                ActualizarGraficos(dt_GraPubli, ChartPubli, "Ganancias")
            Case GRAPROGRAMA
                dt_GraPrograma = TBusca
                ActualizarGraficos(dt_GraPrograma, ChartProg, "Ganancias")
        End Select
        TBusca = Nothing
        TBuscada = 0
    End Sub
    Private Sub BuscarGraPRog(ByVal buscada As Byte)
        TBuscada = buscada
        Dim Condicion As String = String.Format("year(fecha_pago)='{0}' and fecha_pago is not null group by 1", Year(If(buscada = GRAPROGRAMA, dtpYearCuota.Value, dtpGra.Value)))
        Dim Columna As String = "month(fecha_pago) as Fecha, sum(precio) as 'Valor'"
        Dim Tablas As String = If(buscada = GRAPROGRAMA, "programacuota", "publicidadcuota")
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
            ModLog.Guardar(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub

    Private Sub DgvVB_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVB.CellDoubleClick
        Dim i As Integer = CargarID(dt_Video, dgvVB)
        If (i <> -1 And i <> 0) Then
            Dim formVideo As New frmVideo(i)
            AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
            formVideo.ShowDialog()
        End If
    End Sub

    Private Sub btnLimpiarBS_Click(sender As Object, e As EventArgs) Handles btnLimpiarBS.Click
        txtBSnombre.Clear()
        ctpSerie.Value = Now.Date
        cbS.Checked = False
        ActualizarTablaC(Nothing, dgvBS, False) 'fix
    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Refresh()
    End Sub

    Private Sub btnlimpiarv_Click(sender As Object, e As EventArgs) Handles btnlimpiarv.Click
        txtVcontenido.Clear()
        txtVnombre.Clear()
        dtpfechavideo.Value = Now.Date
        cbFecha.Checked = False
        ActualizarTablaC(Nothing, dgvVB, False) 'fix
    End Sub

    Private Sub btnBuscarBS_Click(sender As Object, e As EventArgs) Handles btnBuscarBS.Click
        TBuscada = SERIE
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
        If (i(0) > 0) Then
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

    '' Nahuel del futuro aqui, vengo a decir gracias al Nahuel del pasado por hacer esto
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVB.CellClick, dgvBS.CellClick, dgvClientes.CellClick, dgvBProgramas.CellClick, dgvPubliB.CellClick, dgvFuncionarioBF.CellClick, dgvFuncionesBFF.CellClick, dgvBEvento.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub
    Private Sub dgvHeaderClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVB.ColumnHeaderMouseClick, dgvBS.ColumnHeaderMouseClick, dgvClientes.ColumnHeaderMouseClick, dgvBProgramas.ColumnHeaderMouseClick, dgvPubliB.ColumnHeaderMouseClick, dgvFuncionarioBF.ColumnHeaderMouseClick, dgvFuncionesBFF.ColumnHeaderMouseClick, dgvBEvento.ColumnHeaderMouseClick

        CheckAll(sender, e.ColumnIndex)
    End Sub


    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        BorrarConfirmar(Me, dt_Video, dgvVB, VIDEO, btnbuscarv)
    End Sub

    Private Sub btnBorrarS_Click(sender As Object, e As EventArgs) Handles btnBorrarS.Click
        BorrarConfirmar(Me, dt_Serie, dgvBS, SERIE, btnBuscarBS)
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
        TBuscada = EMPRESA
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
            BWBuscador.RunWorkerAsync(PSQL("id_Empresa, Nombre, Telefono, Mail as 'E-Mail'", "empresa", condicion))
        End If
    End Sub

    Private Sub btncBorrar_Click(sender As Object, e As EventArgs) Handles btncBorrar.Click
        BorrarConfirmar(Me, dt_Empresa, dgvClientes, EMPRESA, btncBuscar)
    End Sub

    Private Sub FormCliente_FormClosed(sender As Object, e As FormClosedEventArgs)
        btncBuscar.PerformClick()
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        Dim i() As String = CargarID(dt_Empresa, dgvClientes, {0, 1, 2, 3})
        If (i(0) > 0) Then
            Dim formCliente As New frmEmpresa(i)
            AddHandler formCliente.FormClosed, AddressOf FormCliente_FormClosed
            formCliente.ShowDialog()
        Else
            TBNotas.Text += "a"
        End If
    End Sub

    Private Sub btncIngresar_Click(sender As Object, e As EventArgs) Handles btncIngresar.Click
        Dim formCliente As New frmEmpresa({-1, "", "", ""})
        AddHandler formCliente.FormClosed, AddressOf FormCliente_FormClosed
        formCliente.ShowDialog()
    End Sub

    Private Sub btncLimpiar_Click(sender As Object, e As EventArgs) Handles btncLimpiar.Click
        txtCNombre.Clear()
        txtCMail.Clear()
        txtCTel.Clear()
        ActualizarTablaC(Nothing, dgvClientes, False) 'fix
    End Sub

    Private Sub btnLimpiarBP_Click(sender As Object, e As EventArgs) Handles btnLimpiarBP.Click
        txtNombreBP.Clear()
        txtDescripcionBP.Clear()
        ActualizarTablaC(Nothing, dgvBProgramas, False) 'fix
    End Sub

    Private Sub btnBuscarBP_Click(sender As Object, e As EventArgs) Handles btnBuscarBP.Click
        TBuscada = PROGRAMAS
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If Not String.IsNullOrWhiteSpace(txtNombreBP.Text) Then
            condicion = String.Format("Nombre_Programa like '%{0}%'", txtNombreBP.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtDescripcionBP.Text) Then
            condicion += String.Format(" and Descripcion like '%{0}%'", txtDescripcionBP.Text)
        End If
        If Not BWBuscador.IsBusy Then
            BWBuscador.RunWorkerAsync(PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
        End If
    End Sub

    Private Sub btnBorrarBP_Click(sender As Object, e As EventArgs) Handles btnBorrarBP.Click
        BorrarConfirmar(Me, dt_BPrograma, dgvBProgramas, PROGRAMAS, btnBuscarBP)
    End Sub

    Private Sub dgvBProgramas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBProgramas.CellDoubleClick
        Dim i() As String = CargarID(dt_BPrograma, dgvBProgramas, {0})
        If (i(0) <> 0) Then
            Dim formPrograma As New frmPrograma(i(0))
            AddHandler formPrograma.FormClosed, AddressOf FormPrograma_FormClosed
            formPrograma.ShowDialog()
        End If
    End Sub

    Private Sub dgvPrograma_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograma.CellDoubleClick
        Dim i() As String = CargarID(dt_programa, dgvPrograma, {0})
        If (i(0) <> 0) Then
            Dim formPrograma As New frmPrograma(i(0))
            AddHandler formPrograma.FormClosed, AddressOf ACPrograma
            'TODO: Crear otro handler para actualizar la tabla de programas agendados
            formPrograma.ShowDialog()
        End If
    End Sub
    Private Sub ACPrograma()
        If Not BWProgramas.IsBusy Then
            BWProgramas.RunWorkerAsync()
        End If
    End Sub


    Private Sub btnIngresarBP_Click(sender As Object, e As EventArgs) Handles btnIngresarBP.Click
        Dim formPrograma As New frmPrograma(-1)
        AddHandler formPrograma.FormClosed, AddressOf FormPrograma_FormClosed
        formPrograma.ShowDialog()
    End Sub
    Private Sub FormPrograma_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnBuscarBP.PerformClick()
        If Not (BWProgramas.IsBusy) Then
            BWProgramas.RunWorkerAsync()
        End If
    End Sub
    Private Sub FormEvento_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnBuscarE.PerformClick()
        If Not (BWEventos.IsBusy) Then
            BWEventos.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnagendarEvento_Click(sender As Object, e As EventArgs) Handles btnagendarEvento.Click
        Dim formEvento As New frmEvento(-1)
        AddHandler formEvento.FormClosed, AddressOf FormEvento_FormClosed
        formEvento.ShowDialog()
    End Sub

    Private Sub btnLimpiarPubliB_Click(sender As Object, e As EventArgs) Handles btnLimpiarPubliB.Click
        txtNombre.Clear()
        txtEmpresa.Clear()
        ctpPubli.Value = Now.Date
        cbPubli.Checked = False
        ActualizarTablaC(Nothing, dgvClientes, False) 'fix
    End Sub

    Private Sub btnBuscarPubliB_Click(sender As Object, e As EventArgs) Handles btnBuscarPubliB.Click
        TBuscada = PUBLICIDAD
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtNombre.Text)) Then
            condicion = "p.nombre like '%" + txtNombre.Text + "%'"
        End If
        If (cbPubli.Checked) Then
            condicion += String.Format(" and p.id_publicidad in (select id_publicidad from aparecepubli where fecha_inicio <= '{0}' and fecha_finalizacion >= '{0}')", Format(ctpPubli.Value, "yyyy-MM-dd").ToString)
        End If
        If (Not String.IsNullOrWhiteSpace(txtEmpresa.Text)) Then
            condicion += " and e.nombre like '%" + txtEmpresa.Text + "%'"
        End If
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("p.id_publicidad, p.nombre as Nombre, e.nombre As Empresa", "publicidad p inner join empresa e on p.id_empresa = e.id_empresa", condicion))
        End If
        'ModLog.Guardar(PSQL("p.id_publicidad, p.nombre as Nombre, e.nombre As Empresa", "publicidad p inner join empresa e on p.id_empresa = e.id_empresa", condicion))
    End Sub

    Private Sub cbTTodas_CheckedChanged(sender As Object, e As EventArgs) Handles cbTTodas.CheckedChanged
        If Not BWTandas.IsBusy Then
            BWTandas.RunWorkerAsync(Not cbTTodas.Checked)
        End If
    End Sub

    Private Sub dgvPubliB_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPubliB.CellDoubleClick
        Dim i As String = CargarID(dt_BPubli, dgvPubliB)
        If (i <> 0) Then
            Dim formPubli As New frmPublicidad(i)
            AddHandler formPubli.FormClosed, AddressOf FormPubli_FormClosed
            formPubli.ShowDialog()
        End If
    End Sub
    Private Sub FormPubli_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnBuscarPubliB.PerformClick()
        If Not BWTandas.IsBusy Then
            BWTandas.RunWorkerAsync(Not cbTTodas.Checked)
        End If
    End Sub

    Private Sub btnIngresarPubliB_Click(sender As Object, e As EventArgs) Handles btnIngresarPubliB.Click
        Dim formPubli As New frmPublicidad(-1)
        AddHandler formPubli.FormClosed, AddressOf FormPubli_FormClosed
        formPubli.ShowDialog()
    End Sub

    Private Sub btnLimpiarBF_Click(sender As Object, e As EventArgs) Handles btnLimpiarBF.Click
        txtNombreBF.Clear()
        txtMailBF.Clear()
        txtTelefonoBF.Clear()
        ActualizarTablaC(Nothing, dgvFuncionarioBF, False) 'fix
    End Sub

    Private Sub btnBuscarBF_Click(sender As Object, e As EventArgs) Handles btnBuscarBF.Click
        TBuscada = ModTablas.FUNCIONARIO
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtNombreBF.Text)) Then
            condicion = "Nombre like '%" + txtNombreBF.Text + "%'"
        End If
        If (Not String.IsNullOrWhiteSpace(txtTelefonoBF.Text)) Then
            condicion += " and Telefono = '" + txtTelefonoBF.Text + "'"
        End If
        If (Not String.IsNullOrWhiteSpace(txtMailBF.Text)) Then
            condicion += " and Mail = '" + txtMailBF.Text + "'"
        End If
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("id_Funcionario, Nombre, Telefono, Mail as 'E-Mail'", "funcionario", condicion))
        End If
    End Sub

    Private Sub btnBorrarPubliB_Click(sender As Object, e As EventArgs) Handles btnBorrarPubliB.Click
        BorrarConfirmar(Me, dt_BPubli, dgvPubliB, PUBLICIDAD, btnBuscarPubliB)
    End Sub


    Private Sub btnBorrarBF_Click(sender As Object, e As EventArgs) Handles btnBorrarBF.Click
        BorrarConfirmar(Me, dt_BFuncionario, dgvFuncionarioBF, ModTablas.FUNCIONARIO, btnBuscarBF)
    End Sub

    Private Sub btnIngresarBF_Click(sender As Object, e As EventArgs) Handles btnIngresarBF.Click
        Dim formFuncionario As New frmFuncionario({-1, "", "", ""})
        AddHandler formFuncionario.FormClosed, AddressOf FormFuncrio_FormClosed
        formFuncionario.ShowDialog()
    End Sub

    Private Sub btnTanda_Click(sender As Object, e As EventArgs) Handles btnTanda.Click
        Dim formTanda As New frmTandas()
        AddHandler formTanda.FormClosed, AddressOf tandasClosed
        formTanda.ShowDialog()
    End Sub
    Private Sub tandasClosed()
        If Not BWProgramas.IsBusy Then
            BWTandas.RunWorkerAsync(Not cbTTodas.Checked)
        End If
    End Sub

    Private Sub dgvFuncionarioBF_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarioBF.CellDoubleClick
        Dim i() As String = CargarID(dt_BFuncionario, dgvFuncionarioBF, {0, 1, 2, 3})
        If (i(0) > 0) Then
            Dim formFuncrio As New frmFuncionario(i)
            AddHandler formFuncrio.FormClosed, AddressOf FormFuncrio_FormClosed
            formFuncrio.ShowDialog()
        End If
    End Sub

    Private Sub FormFuncrio_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnBuscarBF.PerformClick()
    End Sub

    Private Sub btnBuscarBFF_Click(sender As Object, e As EventArgs) Handles btnBuscarBFF.Click
        TBuscada = FUNCION
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtNombreBFF.Text)) Then
            condicion = String.Format("Nombre like '%{0}%'", txtNombreBFF.Text)
        End If
        If (Not String.IsNullOrWhiteSpace(txtDescripcionBFF.Text)) Then
            condicion += String.Format(" and Descripcion like '%{0}%'", txtDescripcionBFF.Text)
        End If
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("ID_Funcion, Nombre, Descripcion", "Funcion", condicion))
        End If
    End Sub

    Private Sub btnBorrarBFF_Click(sender As Object, e As EventArgs) Handles btnBorrarBFF.Click
        BorrarConfirmar(Me, dt_BFuncion, dgvFuncionesBFF, FUNCION, btnBuscarBFF)
    End Sub

    Private Sub btnIngresarBFF_Click(sender As Object, e As EventArgs) Handles btnIngresarBFF.Click
        Dim formFuncion As New frmFuncion({-1, "", "", ""})
        AddHandler formFuncion.FormClosed, AddressOf FormFunc_FormClosed
        formFuncion.ShowDialog()
    End Sub

    Private Sub btnLimpiarBFF_Click(sender As Object, e As EventArgs) Handles btnLimpiarBFF.Click
        txtNombreBFF.Clear()
        txtDescripcionBFF.Clear()
        ActualizarTablaC(Nothing, dgvFuncionesBFF, False) 'fix
    End Sub

    Private Sub dgvFuncionesBFF_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionesBFF.CellDoubleClick
        Dim i() As String = CargarID(dt_BFuncion, dgvFuncionesBFF, {0, 1, 2})
        If (i(0) > 0) Then
            Dim formFunc As New frmFuncion(i)
            AddHandler formFunc.FormClosed, AddressOf FormFunc_FormClosed
            formFunc.ShowDialog()
        End If
    End Sub

    Private Sub FormFunc_FormClosed(sender As Object, e As FormClosedEventArgs)
        btnBuscarBFF.PerformClick()
    End Sub

    Private Sub btnBuscarE_Click(sender As Object, e As EventArgs) Handles btnBuscarE.Click
        TBuscada = EVENTO
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If Not String.IsNullOrWhiteSpace(txtNombreE.Text) Then
            condicion = String.Format("nombre like '%{0}%'", txtNombreE.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtDescripcionE.Text) Then
            condicion += String.Format(" and descripcion like '%{0}%'", txtDescripcionE.Text)
        End If
        If Not BWBuscador.IsBusy Then
            BWBuscador.RunWorkerAsync(PSQL("ID_Evento, nombre as Nombre, descripcion as Descripcion", "evento", condicion))
        End If
    End Sub

    Private Sub btnBEvento_Click(sender As Object, e As EventArgs) Handles btnBEvento.Click
        BorrarConfirmar(Me, dt_BEvento, dgvBEvento, EVENTO, btnBuscarE)
    End Sub

    Private Sub btnIngresarE_Click(sender As Object, e As EventArgs) Handles btnIngresarE.Click
        Dim formEvento As New frmEvento(-1)
        AddHandler formEvento.FormClosed, AddressOf FormEvento_FormClosed
        formEvento.ShowDialog()
    End Sub

    Private Sub dgvBEvento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBEvento.CellDoubleClick
        Dim i As Integer = CargarID(dt_BEvento, dgvBEvento)
        If (i <> -1 And i <> 0) Then
            Dim formEvento As New frmEvento(i)
            AddHandler formEvento.FormClosed, AddressOf FormEvento_FormClosed
            formEvento.ShowDialog()
        End If
    End Sub

    Private Sub btnLimpiarEvento_Click(sender As Object, e As EventArgs) Handles btnLimpiarEvento.Click
        txtNombreE.Clear()
        txtDescripcionE.Clear()
        ActualizarTablaC(Nothing, dgvBEvento, False) 'fix
    End Sub


    Private Sub dgvEventos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEventos.CellDoubleClick
        Dim i As Integer = CargarID(dt_evento, dgvEventos)
        If (i <> -1 And i <> 0) Then
            Dim formEvento As New frmEvento(i)
            AddHandler formEvento.FormClosed, AddressOf FormEvento_FormClosed
            formEvento.ShowDialog()
        End If
    End Sub


    Private Sub dgvPublicidades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPublicidades.CellDoubleClick
        Dim i As Integer = CargarID(dt_publi, dgvPublicidades)
        If (i <> -1 And i <> 0) And PoseePermiso("Publicid") Then
            Dim formPubli As New frmPublicidad(i)
            AddHandler formPubli.FormClosed, AddressOf FormPubli_Close
            formPubli.ShowDialog()
        End If
    End Sub

    Private Sub dgvPPublicidades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPPublicidades.CellDoubleClick
        Dim i As Integer = CargarID(dt_Ppubli, dgvPPublicidades)
        If (i <> -1 And i <> 0) Then
            Dim formPubli As New frmPublicidad(i)
            AddHandler formPubli.FormClosed, AddressOf FormPPubli_FormClosed
            formPubli.ShowDialog()
        End If
    End Sub
    Private Sub FormPPubli_FormClosed()
        If Not (BWDPRogramas.IsBusy) Then
            BWDPRogramas.RunWorkerAsync()
        End If
    End Sub
    Private Sub FormPubli_Close()
        If Not (BWPublicidades.IsBusy) Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub

    Private Sub dgvFuncionarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellDoubleClick
        Dim i() As String = CargarID(dt_dprograma, dgvFuncionarios, {0, 1, 2, 3})
        If (i(0) > 0) Then
            Dim formFun As New frmFuncionario(i)
            AddHandler formFun.FormClosed, AddressOf FormPPubli_FormClosed
            formFun.ShowDialog()
        End If
    End Sub

    Private Sub RecTan_Tick(sender As Object, e As EventArgs) Handles RecTan.Tick
        If Not BWTandas.IsBusy Then
            BWTandas.RunWorkerAsync(Not cbTTodas.Checked)
        End If
    End Sub

    Private Sub RecPA_Tick(sender As Object, e As EventArgs) Handles RecPA.Tick
        If Not BWProgramas.IsBusy Then
            BWProgramas.RunWorkerAsync()
        End If
    End Sub

    Private Sub tProgramas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tProgramas.SelectedIndexChanged
        If (tProgramas.SelectedIndex = 0) Then
            If Not BWProgramas.IsBusy Then
                BWProgramas.RunWorkerAsync()
            End If
        ElseIf (tProgramas.SelectedIndex = 2) Then
            BuscarGraPRog(GRAPROGRAMA)
        End If
    End Sub

    Private Sub tcSecciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcSecciones.SelectedIndexChanged
        Select Case tcSecciones.SelectedIndex
            Case 0
                If Not BWProgramas.IsBusy Then
                    BWProgramas.RunWorkerAsync()
                End If
                BuscarGraPRog(GRAPROGRAMA)
            Case 3
                BuscarGraPRog(GRAPUBLI)
        End Select
    End Sub


    Private Sub dgvPrograma_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograma.CellClick
        If Not BWDPRogramas.IsBusy Then
            BWDPRogramas.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbTodTand_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodTand.CheckedChanged
        If Not BWPublicidades.IsBusy Then
            BWPublicidades.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtpYearCuota_ValueChanged(sender As Object, e As EventArgs) Handles dtpYearCuota.ValueChanged
        BuscarGraPRog(GRAPROGRAMA)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpGra.ValueChanged
        BuscarGraPRog(GRAPUBLI)
    End Sub

    Private Sub tcPubli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcPubli.SelectedIndexChanged
        If (tcPubli.SelectedIndex = 1) Then
            BuscarGraPRog(GRAPUBLI)
        End If
    End Sub

    Private Sub dgvTandas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTandas.CellDoubleClick
        Dim formTanda As New frmTandas()
        AddHandler formTanda.FormClosed, AddressOf tandasClosed
        formTanda.ShowDialog()
    End Sub

    Private Sub btnGuardarNota_Click(sender As Object, e As EventArgs) Handles btnGuardarNota.Click
        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim ruta As String = s + "\"
        Dim archivo As String = String.Format("Notas_{0}.txt", ModConector.DUsuario)
        Dim escribir As New StreamWriter(ruta & archivo, False)
        escribir.Write(TBNotas.Text)
        escribir.Close()
    End Sub
End Class
