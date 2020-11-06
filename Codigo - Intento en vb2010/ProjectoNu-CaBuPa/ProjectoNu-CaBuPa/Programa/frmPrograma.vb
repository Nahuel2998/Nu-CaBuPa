Imports System.ComponentModel

Public Class frmPrograma
    Dim programaID As Integer
    Private editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Private TBusca As DataTable
    Private dt_funcionario As DataTable
    Private dt_fechas As DataTable
    Private dt_FechaPrograma As DataTable
    Private dt_publicidades As DataTable
    Private TBuscada As Byte
    Private dt_Cuotas As DataTable
    Private CuotaId As Integer = -1

    Public Sub New(ByVal pid As Integer)
        InitializeComponent()
        programaID = pid
    End Sub

    Public Sub Buscar()
        Dim columnas() As String = {"Nombre_Programa", "Descripcion", "DATE_FORMAT(Fecha_Finalizacion,'%Y-%m-%d') as Fecha_Finalizacion"}
        datosI = BuscarDatos("programa", columnas, "id_programa", programaID)
    End Sub

    Private Sub Rellenar()
        txtNombre.Text = datosI(0)
        If datosI(2) <> "" Then
            dtpFecha.Value = CDate(datosI(2))
        Else
            txtTapar.Visible = True
        End If
        txtDescripcion.Text = datosI(1)
    End Sub
    Private Sub FormPubli_FormClosed(sender As Object, e As FormClosedEventArgs)
        PubliDeFecha(dt_publicidades, dgvProgramaPubli, programaID, dtpFPubli.Value)
    End Sub
    Private Sub frmPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If programaID <> -1 Then
            bwDatos.RunWorkerAsync()
            HORAIF(txtHI)
            HORAIF(txtHF)
            If Not PoseePermiso("Programa", "a") Then
                btnBorrar.Visible = False
                btnPEditar.Visible = False

                ocultar()
            End If
        Else
            ocultar()
            btnPEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
        End If
        dtpFecha.BackColor = Color.FromArgb(64, 64, 64)
        dtpFecha.ForeColor = Color.White
        btnPSalir.Select()
    End Sub
    Private Sub ocultar()
        tcP.TabPages.RemoveByKey("tbFuncionarios")
        tcP.TabPages.RemoveByKey("tbPublicidades")
        tcP.TabPages.RemoveByKey("tbAlquiler")
        tcP.TabPages.RemoveByKey("tbFechas")
        tcP.TabPages.RemoveByKey("tbFechasAgendadas")
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDatos.DoWork
        Buscar()
    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        Rellenar()
    End Sub
    Sub Activar()
        txtNombre.ReadOnly = editando
        txtDescripcion.ReadOnly = editando
        editando = Not editando
        dtpFecha.Enabled = editando
        chbTieneFecha.Visible = editando
    End Sub
    Private Sub Alternar()
        Activar()
        btnPEditar.Text = If(editando, "Guardar", "Editar")
        btnPSalir.Text = If(editando, "Cancelar", "Salir")
        chbTieneFecha.Checked = datosI(2) <> ""
        If editando Then
            txtTapar.Visible = False
        Else
            If datosI(2) = "" Then
                txtTapar.Visible = True
                chbTieneFecha.Visible = False
            End If
        End If
    End Sub
    Sub Vaciar()
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        dtpFecha.Value = Now.Date
        chbTieneFecha.Checked = False
    End Sub
    Private Sub ActualizarDatos()
        Dim des As String = txtDescripcion.Text
        Dim nom As String = txtNombre.Text
        Dim dat As String = If(chbTieneFecha.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null")
        datos = {nom, des, dat}
    End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnPEditar.Click
        If programaID = -1 Then
            ActualizarDatos()
            PrepararInsert("Programa", datos)
            vaciar()
        ElseIf editando Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                PrepararUpdate("Programa", datos, programaID)
                datosI = VaciarNull(datos)
            End If
            Alternar()
        Else
            Alternar()
        End If
    End Sub

    Private Sub frmPrograma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If editando And programaID <> -1 Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                Dim g As New frmGuardarEdicion("Programa", datos, programaID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Programa") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Programa", "")

                    ' ModInicializador.frmPrin.btnbuscarv.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub btnPSalir_Click(sender As Object, e As EventArgs) Handles btnPSalir.Click
        If Not editando Or programaID = -1 Then
            Close()
        Else
            Rellenar()
            Alternar()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(PROGRAMAS, {programaID}, True)
        formDelete.ShowDialog(Me)
    End Sub

    Private Sub bwCargador_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCargador.DoWork
        TBusca = DevolverTabla(e.Argument)
        ModLog.Guardar(e.Argument)
    End Sub

    Private Sub tcP_DoubleClick(sender As Object, e As EventArgs) Handles tcP.DoubleClick
        If editando And programaID <> -1 Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                Dim g As New frmGuardarEdicion("Programa", datos, programaID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Programa") Then
                    tcP.SelectedIndex = 0
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Programa", "")
                    ' ModInicializador.frmPrin.btnbuscarv.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub tcP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcP.SelectedIndexChanged
        TBuscada = 0
        Select Case tcP.SelectedIndex
            Case 1
                BuscarFuncionario()
            Case 2
                PubliDeFecha(dt_publicidades, dgvProgramaPubli, programaID, Now.Date)
            Case 3
                BuscarCuota()
            Case 4
                BFecha(cbFMes.Checked)
            Case 5
                BFechaRango(cbBMA.Checked)
        End Select
    End Sub
    Public Sub BFecha(Optional ByVal mes As Boolean = False)
        Dim Columna As String = "hora_inicio as 'Inicio', hora_fin as 'Final'"
        Dim fecha As String = If(mes, "month(fecha) = month('{1}')", "fecha = '{1}'")
        Dim Condicion As String = String.Format("id_programa = {0} and " + fecha, programaID, Format(dtpBP.Value, "yyyy-MM-dd"))
        Dim Tablas As String = "fechaprograma"
        TBuscada = FECHAPROGRAMA
        If Not (bwCargador.IsBusy) Then
            bwCargador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub
    Private Sub BuscarFuncionario()
        Dim Condicion As String = String.Format("ifnull(fecha_finalizacion,curdate()){0}curdate()", If(cbRP.Checked, "<", ">="))
        TBuscada = FUNCIONARIO
        Dim Columna As String = "fun.id_funcionario, ft.ID_TrabajaComo, fun.Nombre, f.Nombre as Función, fecha_inicio as 'Inicio de la función', fecha_finalizacion as 'Fin de la función', Telefono, Mail"
        Dim Tablas As String = "(select * from funtrabaja where id_Programa = {0}) ft inner join trabajacomo tc on ft.id_trabajacomo = tc.id_trabajacomo inner join funcion f on f.id_funcion = tc.id_funcion inner join funcionario fun on fun.id_funcionario = tc.id_funcionario"
        Tablas = String.Format(Tablas, programaID)
        If Not (bwCargador.IsBusy) And TBuscada <> 0 Then
            bwCargador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub
    Private Sub BuscarCuota()
        Dim Condicion As String = String.Format("id_programa='{0}' and Fecha_Pago is{1}null and year(fecha_emision)={2}", programaID, If(cbPagados.Checked, " not ", " "), Year(dtpYearCuota.Value))
        TBuscada = CUOTA
        Dim Columna As String = "id_programa_cuota, fecha_emision as 'Fecha de emisión', fecha_pago as 'Fecha de pago', precio as 'Valor'"
        Dim Tablas As String = "programacuota"
        If Not (bwCargador.IsBusy) Then
            bwCargador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub

    Private Sub bwCargador_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCargador.RunWorkerCompleted
        Select Case TBuscada
            Case FUNCIONARIO
                dt_funcionario = TBusca
                ActualizarTablaC(dt_funcionario, dgvFuncionarios, True, {1, 0, 6, 7})
            Case FECHAPROGRAMA
                dt_fechas = TBusca
                ActualizarTablaC(dt_fechas, dgvPrograma, False)
            Case PROGRAMAS
                dt_FechaPrograma = TBusca
                ActualizarTablaC(dt_FechaPrograma, dgvFechaPrograma, False)
            Case CUOTA
                dt_Cuotas = TBusca
                ActualizarTablaC(dt_Cuotas, dgvVerCuota, True)
        End Select
        TBusca = Nothing
        TBuscada = 0
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim datos() As String = {Format(dtpAP.Value().Date, "yyyy-MM-dd"), MysqlHM(txtHI.Value), MysqlHM(txtHF.Value), programaID}

        PrepararInsert("fechaprograma", datos, 0)
        txtHI.Value = Now
        txtHF.value = Now
        BFecha(cbFMes.Checked)
    End Sub


    Private Sub dtpBP_ValueChanged(sender As Object, e As EventArgs) Handles dtpBP.ValueChanged
        BFecha(cbFMes.Checked)
    End Sub


    Private Sub btnABorrar_Click(sender As Object, e As EventArgs) Handles btnABorrar.Click
        If Not IsNothing(dt_fechas) Then
            If (dt_fechas.Rows.Count > 0) Then
                Dim RId() As String = ObtenerCheck(dt_fechas, dgvPrograma, 0)
                If Not RId.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado(FECHAPROGRAMA, {dtpBP.Value}, False, RId, {programaID})
                    formDelete.ShowDialog(Me)
                    BFecha(cbFMes.Checked)
                End If
            End If
        End If
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgramaPubli.CellClick, dgvPrograma.CellClick, dgvFechaPrograma.CellClick, dgvFuncionarios.CellClick, dgvVerCuota.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub
    Private Sub dgvHeaderClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProgramaPubli.ColumnHeaderMouseClick, dgvPrograma.ColumnHeaderMouseClick, dgvFechaPrograma.ColumnHeaderMouseClick, dgvFuncionarios.ColumnHeaderMouseClick, dgvVerCuota.ColumnHeaderMouseClick
        CheckAll(sender, e.ColumnIndex)
    End Sub
    Private Sub dtpFPubli_ValueChanged(sender As Object, e As EventArgs) Handles dtpFPubli.ValueChanged
        PubliDeFecha(dt_publicidades, dgvProgramaPubli, programaID, dtpFPubli.Value)
    End Sub

    Private Sub btnBorrarSelect_Click(sender As Object, e As EventArgs) Handles btnBorrarSelect.Click
        If Not IsNothing(dt_publicidades) Then
            If (dt_publicidades.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_publicidades, dgvProgramaPubli, 0)
                Dim Id1() As String = ObtenerCheck(dt_publicidades, dgvProgramaPubli, 2)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado(PUBLICIDADPROGRAMA, Id, False, {programaID}, Id1)
                    formDelete.ShowDialog(Me)
                    PubliDeFecha(dt_publicidades, dgvProgramaPubli, programaID, dtpFPubli.Value)
                End If
            End If
        End If
    End Sub

    Private Sub dgvProgramaPubli_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgramaPubli.CellDoubleClick
        Dim i As String = CargarID(dt_publicidades, dgvProgramaPubli)
        If (i <> 0) Then
            Dim formPubli As New frmPublicidad(i)
            AddHandler formPubli.FormClosed, AddressOf FormPubli_FormClosed
            formPubli.ShowDialog()
        End If
    End Sub

    Private Sub btnBorrarAgenda_Click(sender As Object, e As EventArgs) Handles btnBorrarAgenda.Click
        If Not IsNothing(dt_FechaPrograma) Then
            If (dt_FechaPrograma.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_FechaPrograma, dgvFechaPrograma, 0)
                Dim Id2() As String = ObtenerCheck(dt_FechaPrograma, dgvFechaPrograma, 1)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado(FECHAPROGRAMA, Id, False, Id2, {programaID})
                    formDelete.ShowDialog(Me)
                    BFechaRango(cbBMA.Checked)
                End If
            End If
        End If
    End Sub
    Private Sub BFechaRango(ByVal mes As Boolean)
        Dim Columna As String = "Fecha, hora_inicio as 'Inicio', hora_fin as 'Final'"
        Dim fechasm As String = String.Format("fecha >= '{0}' and fecha <='{1}'", Format(mcFecha.SelectionStart, "yyyy-MM-dd"), Format(mcFecha.SelectionEnd, "yyyy-MM-dd"))
        Dim fecham As String = String.Format("month(fecha) = month('{0}')", Format(mcFecha.SelectionStart, "yyyy-MM-dd"))
        Dim fecha As String = If(mes, fecham, fechasm)
        Dim Condicion As String = String.Format("id_programa = {0} and " + fecha, programaID)
        Dim Tablas As String = "fechaprograma"
        TBuscada = PROGRAMAS
        If Not (bwCargador.IsBusy) Then
            bwCargador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
            ModLog.Guardar(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub

    Private Sub cbFMes_CheckedChanged(sender As Object, e As EventArgs) Handles cbFMes.CheckedChanged
        BFecha(cbFMes.Checked)
    End Sub

    Private Sub cbBMA_CheckedChanged(sender As Object, e As EventArgs) Handles cbBMA.CheckedChanged
        BFechaRango(cbBMA.Checked)
    End Sub

    Private Sub mcFecha_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mcFecha.DateSelected
        BFechaRango(cbBMA.Checked)
    End Sub

    Private Sub btnBorrarF_Click(sender As Object, e As EventArgs) Handles btnBorrarF.Click
        If Not IsNothing(dt_funcionario) Then
            If (dt_funcionario.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_funcionario, dgvFuncionarios, 1)
                Dim Id1() As String = ObtenerCheck(dt_funcionario, dgvFuncionarios, 4)
                If Not Id.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado(FUNTRABAJA, {programaID}, False, Id, Id1)
                    formDelete.ShowDialog(Me)
                    BuscarFuncionario()
                End If
            End If
        End If
    End Sub

    Private Sub cbRP_CheckedChanged(sender As Object, e As EventArgs) Handles cbRP.CheckedChanged
        BuscarFuncionario()
    End Sub

    Private Sub btnTerminarF_Click(sender As Object, e As EventArgs) Handles btnTerminarF.Click
        If Not IsNothing(dt_funcionario) Then
            If (dt_funcionario.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_funcionario, dgvFuncionarios, 1)
                Dim Id1() As String = ObtenerCheck(dt_funcionario, dgvFuncionarios, 4)
                If Not Id.Length = 0 Then
                    USQL("funtrabaja", String.Format("fecha_finalizacion='{0}'", Format(dtpTF.Value, "yyyy-MM-dd")), String.Format("id_programa='{0}'", programaID) + " and " + CreadorCondicion("ID_TrabajaComo", Id) + " and " + CreadorCondicion("fecha_inicio", Id1, True) + String.Format(" and fecha_inicio<='{0}'", Format(dtpTF.Value, "yyyy-MM-dd")))
                    BuscarFuncionario()
                End If
            End If
        End If
        dtpTF.Value = Now
    End Sub


    Private Sub cbPagados_CheckedChanged(sender As Object, e As EventArgs) Handles cbPagados.CheckedChanged
        BuscarCuota()
    End Sub

    Private Sub VaciarCuota()
        dtpFE.Value = Now
        dtpFP.Value = Now
        cbP.Checked = False
        nudValor.Value = 0
    End Sub
    Private Sub CambiarICuota()
        If (CuotaId = -1) Then
            btnBorrarC.Text = "Borrar"
            btnInsertarC.Text = "Añadir"
            gbAlquiler.Text = "Ingreso"
            VaciarCuota()
        Else
            btnBorrarC.Text = "Cancelar"
            btnInsertarC.Text = "Actualizar"
            gbAlquiler.Text = "Edición"
        End If
    End Sub

    Private Sub btnInsertarC_Click(sender As Object, e As EventArgs) Handles btnInsertarC.Click
        If (CuotaId = -1) Then
            ISQL("programacuota", "id_programa,fecha_emision, fecha_pago,precio", String.Format("'{0}','{1}',{2},'{3}'", programaID, Format(dtpFE.Value, "yyyy-MM-dd"), If(cbP.Checked, "'" + Format(dtpFP.Value, "yyyy-MM-dd") + "'", "null"), nudValor.Value.ToString.Replace(",", ".")))
            VaciarCuota()
            BuscarCuota()
        Else
            USQL("programacuota", String.Format("fecha_emision='{0}', fecha_pago={1},precio='{2}'", Format(dtpFE.Value, "yyyy-MM-dd"), If(cbP.Checked, "'" + Format(dtpFP.Value, "yyyy-MM-dd") + "'", "null"), nudValor.Value.ToString.Replace(",", ".")), String.Format("id_programa_cuota='{0}'", CuotaId))
            CuotaId = -1
            CambiarICuota()
            BuscarCuota()
        End If
    End Sub

    Private Sub btnBorrarC_Click(sender As Object, e As EventArgs) Handles btnBorrarC.Click
        If (CuotaId = -1) Then
            If Not IsNothing(dt_Cuotas) Then
                If (dt_Cuotas.Rows.Count > 0) Then
                    Dim RId() As String = ObtenerCheck(dt_Cuotas, dgvVerCuota, 0)
                    If Not RId.Length = 0 Then
                        Dim formDelete As New frmConfirmarBorrado(CUOTA, RId, False)
                        formDelete.ShowDialog(Me)
                        BuscarCuota()
                    End If
                End If
            End If
        Else
            CuotaId = -1
            CambiarICuota()
        End If
    End Sub

    Private Sub dgvVerCuota_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVerCuota.CellDoubleClick
        Dim i() As String = CargarID(dt_Cuotas, dgvVerCuota, {0, 1, 2, 3})
        If (i(0) <> 0) Then
            CuotaId = i(0)
            dtpFE.Value = i(1)
            dtpFP.Value = If(i(2) = "", Now, i(2))
            cbP.Checked = If(i(2) = "", False, True)
            nudValor.Value = i(3)
        End If
        CambiarICuota()
    End Sub

    Private Sub dtpYearCuota_ValueChanged(sender As Object, e As EventArgs) Handles dtpYearCuota.ValueChanged
        BuscarCuota()
    End Sub

    Private Sub dtpFE_ValueChanged(sender As Object, e As EventArgs) Handles dtpFE.ValueChanged
        If (dtpFE.Value > dtpFP.Value) Then
            dtpFP.Value = dtpFE.Value
        End If
        dtpFP.MinDate = dtpFE.Value
    End Sub

    Private Sub txtHI_ValueChanged(sender As Object, e As EventArgs) Handles txtHI.ValueChanged
        If (txtHI.Value > txtHF.Value) Then
            txtHF.Value = txtHI.Value
        End If
        txtHF.MinDate = txtHI.Value
    End Sub


    Private Sub dgvFuncionarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellDoubleClick
        Dim i() As String = CargarID(dt_funcionario, dgvFuncionarios, {0, 2, 6, 7})
        If (i(0) > 0) Then
            Dim formFunc As New frmFuncionario(i)
            AddHandler formFunc.FormClosed, AddressOf FormFunc_FormClosed
            formFunc.ShowDialog()
        End If
    End Sub
    Private Sub FormFunc_FormClosed(sender As Object, e As FormClosedEventArgs)
        BuscarFuncionario()
    End Sub

    Private Sub btnCF_Click(sender As Object, e As EventArgs) Handles btnCF.Click
        If Not IsNothing(dt_funcionario) Then
            If (dt_funcionario.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_funcionario, dgvFuncionarios, 1)
                Dim Id1() As String = ObtenerCheck(dt_funcionario, dgvFuncionarios, 4)
                If Not Id.Length = 0 Then
                    USQL("funtrabaja", "fecha_finalizacion=null", String.Format("id_programa='{0}'", programaID) + " and " + CreadorCondicion("ID_TrabajaComo", Id) + " and " + CreadorCondicion("fecha_inicio", Id1, True) + String.Format(" and fecha_inicio<='{0}'", Format(dtpTF.Value, "yyyy-MM-dd")))
                    BuscarFuncionario()
                End If
            End If
        End If
    End Sub
End Class