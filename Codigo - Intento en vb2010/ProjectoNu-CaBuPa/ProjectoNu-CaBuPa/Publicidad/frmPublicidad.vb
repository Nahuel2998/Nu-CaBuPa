Imports System.ComponentModel

Public Class frmPublicidad
    Dim publicidadID As Integer
    private editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Private dt_ProgramasP As DataTable
    Private dt_FProgramas As DataTable
    Private dt_FEventos As DataTable
    Private TBuscada As Byte = 0
    Private dt_fechas As DataTable
    Private dt_fechasA As DataTable
    Dim position() As String
    Dim positionTanda() As String
    Dim positionPrograma() As String
    Dim positionEvento() As String
    Dim pos() As UInt16 = {0, 0, 0, 0}
    Dim empresaID As Integer = 0
    Dim fecha1 As String
    Dim fecha2 As String
    Dim fechaP1 As String
    Dim fechaP2 As String
    Dim fechaE1 As String
    Dim fechaE2 As String
    Private dt_Cuotas As DataTable
    Private CuotaId As Integer = -1
    Public Sub New(ByVal pid As Integer)
        InitializeComponent()
        publicidadID = pid
    End Sub
    Public Sub Buscar()
        Dim columnas() As String = {"Nombre", "Tema", "id_empresa"}
        datosI = BuscarDatos("publicidad", columnas, "id_publicidad", publicidadID)
        Rellenar()
    End Sub

    Private Sub Rellenar()
        txtNombre.Text = datosI(0)
        txtTema.Text = datosI(1)
        empresaID = datosI(2)
        CargarCombo()
    End Sub
    Sub CargarCombo()
        dt_Empresa = DevolverTabla(PSQL("id_Empresa, Nombre, Telefono, Mail", "Empresa", "True"))
        LlenarCombo(cbEmpresa, dt_Empresa, "Nombre")
        If Not IsNothing(dt_Empresa) Then
            ExtraerDatos()
        Else
            MessageBox.Show("Debe tener empresas ingresadas")
        End If
        cbEmpresa.SelectedIndex = pos(0)
    End Sub
    Sub CargarComboTandas()
        LlenarCombo(cbTanda, dt_tandasCon, "Horas")
        If Not IsNothing(dt_tandasCon) Then
            ExtraerDatosTan()
        Else
            MessageBox.Show("Debe tener tandas ingresadas")
            tcP.SelectedIndex = 0
        End If
        cbTanda.SelectedIndex = pos(1)
    End Sub
    Sub CargarComboPrograma()
        LlenarCombo(cbPrograma, dt_ProgramasP, "Nombre_Programa")
        If Not IsNothing(dt_ProgramasP) Then
            ExtraerDatosProg()
        Else
            MessageBox.Show("No se encontró el programa")
        End If
        cbPrograma.SelectedIndex = pos(2)
    End Sub
    Sub CargarComboEvento()
        LlenarCombo(cbEvento, dt_FEventos, "Nombre")
        If Not IsNothing(dt_FEventos) Then
            ExtraerDatosEven()
        Else
            MessageBox.Show("No se encontró el evento")
        End If
        cbEvento.SelectedIndex = pos(3)
    End Sub
    Public Sub ExtraerDatosProg()
        ReDim positionPrograma(dt_ProgramasP.Rows.Count - 1)
        For j As Integer = 0 To dt_ProgramasP.Rows.Count - 1
            positionPrograma(j) = dt_ProgramasP.Rows(j).Item(0).ToString
        Next
    End Sub
    Public Sub ExtraerDatosEven()
        ReDim positionEvento(dt_FEventos.Rows.Count - 1)
        For j As Integer = 0 To dt_FEventos.Rows.Count - 1
            positionEvento(j) = dt_FEventos.Rows(j).Item(0).ToString
        Next
    End Sub
    Public Sub ExtraerDatosTan()
        ReDim positionTanda(dt_tandasCon.Rows.Count - 1)
        For j As Integer = 0 To dt_tandasCon.Rows.Count - 1
            positionTanda(j) = dt_tandasCon.Rows(j).Item(0).ToString
        Next
    End Sub
    Public Sub ExtraerDatos()
        ReDim position(dt_Empresa.Rows.Count - 1)
        For j As Integer = 0 To dt_Empresa.Rows.Count - 1
            position(j) = dt_Empresa.Rows(j).Item(0).ToString
        Next
        For i As Integer = 0 To position.Length - 1
            If empresaID = position(i) Then
                pos(0) = i + 1
                Exit For
            End If
        Next
    End Sub


    Private Sub frmPublicidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If publicidadID <> -1 Then
            Buscar()
            btnSalir.Select()
            If Not PoseePermiso("Publicid", "a") Then
                btnBorrar.Visible = False
                btnEditar.Visible = False
                btnBorrarC.Visible = False
                btnInsertarC.Visible = False
                ocultar()
            ElseIf Not PoseePermiso("Evento", "a") Then
                tcP.TabPages.RemoveByKey("tbEventos")
            ElseIf Not PoseePermiso("Programa", "a") Then

                tcP.TabPages.RemoveByKey("tbProgramas")
            End If
        Else
            ocultar()
            tcP.TabPages.RemoveByKey("tbCuotas")
            btnEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
            CargarCombo()
        End If
        btnSalir.Select()
    End Sub
    Private Sub ocultar()
        tcP.TabPages.RemoveByKey("tbTandas")
        tcP.TabPages.RemoveByKey("tbTandasE")
        tcP.TabPages.RemoveByKey("tbProgramas")
        tcP.TabPages.RemoveByKey("tbEventos")
    End Sub
    Sub Activar()
        txtNombre.ReadOnly = editando
        txtTema.ReadOnly = editando
        editando = Not editando
        cbEmpresa.Enabled = editando
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Not editando Or publicidadID = -1 Then
            Close()
        Else
            Rellenar()
            Alternar()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        PrepararDelete("publicidad", "id_publicidad", {publicidadID})
        Close()
    End Sub
    Private Sub Alternar()
        Activar()
        btnEditar.Text = If(editando, "Guardar", "Editar")
        btnSalir.Text = If(editando, "Cancelar", "Salir")
    End Sub
    Sub vaciar()
        txtNombre.Text = ""
        txtTema.Text = ""
        cbEmpresa.SelectedIndex = -1
    End Sub
    Private Sub ActualizarDatos()
        Dim tem As String = txtTema.Text
        Dim nom As String = txtNombre.Text
        Dim emp As String = If(cbEmpresa.SelectedIndex <= 0, "null", position(cbEmpresa.SelectedIndex - 1))
        datos = {nom, tem, emp}
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (cbEmpresa.SelectedIndex <= 0) Then
            MessageBox.Show("Debe seleccionar una empresa")
            Exit Sub
        End If
        If publicidadID = -1 Then
            ActualizarDatos()
            PrepararInsert("publicidad", datos)
            vaciar()
        ElseIf editando Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                PrepararUpdate("publicidad", datos, publicidadID)
                datosI = VaciarNull(datos)
            End If
            Alternar()
        Else
            Alternar()
        End If
    End Sub

    Private Sub tcP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcP.SelectedIndexChanged
        If (tcP.SelectedIndex() = 1 Or tcP.SelectedIndex() = 2 Or tcP.SelectedIndex() = 5) Then
            If Not (bwDatos.IsBusy) Then
                bwDatos.RunWorkerAsync(tcP.SelectedIndex())
            End If
        End If
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDatos.DoWork
        Select Case e.Argument
            Case 1
                TBuscada = TANDASHORAS
                dt_tandasCon = DevolverTabla(PSQL("Hora_inicio, concat('Tanda ',Hora_Inicio,' ',Hora_fin) as 'Horas'", "Tanda", "True"))
                ModLog.Guardar(PSQL("Hora_inicio, concat('Tanda ',Hora_Inicio,' ',Hora_fin) as 'Horas'", "Tanda", "True"))
            Case 2
                TBuscada = PUBLICIDAD
                Dim condicion = "true"
                dt_fechasA = DevolverTabla(PSQL("distinct a.hora_inicio as 'Hora de tanda', fecha_inicio as 'Fecha Inicio', fecha_finalizacion as 'Fecha Finalización'", "aparecepubli a left join tanda t on t.hora_inicio = null", condicion))
            Case 3
                TBuscada = PROGRAMAS
                Dim condicion = "false"
                If Not String.IsNullOrWhiteSpace(txtNombreP.Text) Then
                    condicion = String.Format("Nombre_Programa like '%{0}%'", txtNombreP.Text)
                End If
                dt_ProgramasP = DevolverTabla(PSQL("id_programa, Nombre_Programa", "programa", condicion))
            Case 4
                TBuscada = EVENTO
                Dim condicion = "false"
                If Not String.IsNullOrWhiteSpace(txtNEvento.Text) Then
                    condicion = String.Format("nombre like '%{0}%'", txtNEvento.Text)
                End If
                dt_FEventos = DevolverTabla(PSQL("id_evento, nombre", "evento", condicion))
                ModLog.Guardar(PSQL("id_evento, nombre", "evento", condicion))
            Case 5
                Dim Condicion As String = String.Format("id_publicidad='{0}' and Fecha_Pago is{1}null and year(fecha_emision)={2}", publicidadID, If(cbPagados.Checked, " not ", " "), Year(dtpYearCuota.Value))
                TBuscada = CUOTAPUBLICIDAD
                Dim Columna As String = "id_publicidadcuota, fecha_emision as 'Fecha de emisión', fecha_pago as 'Fecha de pago', precio as 'Valor'"
                Dim Tablas As String = "publicidadcuota"
                dt_Cuotas = DevolverTabla(PSQL(Columna, Tablas, Condicion))
                ModLog.Guardar(PSQL(Columna, Tablas, Condicion))
        End Select
    End Sub
    Private Sub ATAntigua()
        ActualizarTablaC(dt_fechasA, dgvTE, False)
    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        Select Case TBuscada
            Case TANDASHORAS
                CargarComboTandas()
            Case PROGRAMAS
                CargarComboPrograma()
            Case PUBLICIDAD
                ATAntigua()
            Case EVENTO
                CargarComboEvento()
            Case CUOTAPUBLICIDAD
                ActualizarTablaC(dt_Cuotas, dgvVerCuota, True)
        End Select
    End Sub

    Private Sub cbTanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTanda.SelectedIndexChanged
        BuscarF()
    End Sub
    Private Sub BuscarF()
        CargarPubliT(dt_fechas, dgvFechas, publicidadID, If(cbTanda.SelectedIndex <= 0, "00:00:00", positionTanda(cbTanda.SelectedIndex - 1)), Format(dtpFI.Value, "yyyy-MM-dd"), Format(dtpFF.Value, "yyyy-MM-dd"))
    End Sub
    Private Sub BuscarFP()
        CargarPubliP(dt_FProgramas, dgvProgramaP, publicidadID, If(cbPrograma.SelectedIndex <= 0, "0", positionPrograma(cbPrograma.SelectedIndex - 1)), Format(dtpFIP.Value, "yyyy-MM-dd"), Format(dtpFFP.Value, "yyyy-MM-dd"))
    End Sub
    Private Sub BuscarFE()
        CargarPubliE(dt_FEventos, dgvAEvento, publicidadID, If(cbEvento.SelectedIndex <= 0, "0", positionEvento(cbEvento.SelectedIndex - 1)), Format(dtpFIE.Value, "yyyy-MM-dd"), Format(dtpFFE.Value, "yyyy-MM-dd"))
    End Sub

    Private Sub dtpFI_ValueChanged(sender As Object, e As EventArgs) Handles dtpFI.ValueChanged
        If (dtpFF.Value < dtpFI.Value) Then
            dtpFF.Value = dtpFI.Value
        End If
        dtpFF.MinDate = dtpFI.Value
        BuscarF()
    End Sub

    Private Sub dtpFF_ValueChanged(sender As Object, e As EventArgs) Handles dtpFF.ValueChanged
        BuscarF()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        FechasMax()
    End Sub
    Private Sub FechasMaxP(Optional ingresar As Boolean = True)
        fechaP1 = Format(dtpFIP.Value, "yyyy-MM-dd")
        fechaP2 = Format(dtpFFP.Value, "yyyy-MM-dd")
        If (cbPrograma.SelectedIndex > 0) Then
            If (dgvProgramaP.Rows.Count > 0) Then
                For i As Integer = 0 To dgvProgramaP.Rows.Count - 1
                    Dim fechaN1 As String = dgvProgramaP.Rows(i).Cells(0).Value().ToString
                    Dim fechaN2 As String = dgvProgramaP.Rows(i).Cells(1).Value().ToString
                    If (CDate(fechaN1) < CDate(fechaP1)) Then
                        fechaP1 = Format(CDate(fechaN1), "yyyy-MM-dd")
                    End If
                    If (CDate(fechaN2) > CDate(fechaP2)) Then
                        fechaP2 = Format(CDate(fechaN2), "yyyy-MM-dd")
                    End If
                Next
                BSQL("pmuestrapubli", String.Format("id_publicidad='{0}' and id_programa='{1}' and fecha_inicio >= '{2}' and fecha_finalizacion <= '{3}'", publicidadID, positionPrograma(cbPrograma.SelectedIndex - 1), fechaP1, fechaP2))
            End If
            If (ingresar) Then
                ISQL("pmuestrapubli", "id_publicidad, id_programa, fecha_inicio, fecha_finalizacion", String.Format("'{0}','{1}','{2}','{3}'", publicidadID, positionPrograma(cbPrograma.SelectedIndex - 1), fechaP1, fechaP2))
            End If
            BuscarFP()
        Else
            MessageBox.Show("Debe seleccionar un programa para agendar la publicidad")
        End If
    End Sub
    Private Sub FechasMaxE(Optional ingresar As Boolean = True)
        fechaE1 = Format(dtpFIE.Value, "yyyy-MM-dd")
        fechaE2 = Format(dtpFFE.Value, "yyyy-MM-dd")
        If (cbEvento.SelectedIndex > 0) Then
            If (dgvAEvento.Rows.Count > 0) Then
                For i As Integer = 0 To dgvAEvento.Rows.Count - 1
                    Dim fechaN1 As String = dgvAEvento.Rows(i).Cells(0).Value().ToString
                    Dim fechaN2 As String = dgvAEvento.Rows(i).Cells(1).Value().ToString
                    If (CDate(fechaN1) < CDate(fechaE1)) Then
                        fechaE1 = Format(CDate(fechaN1), "yyyy-MM-dd")
                    End If
                    If (CDate(fechaN2) > CDate(fechaE2)) Then
                        fechaE2 = Format(CDate(fechaN2), "yyyy-MM-dd")
                    End If
                Next
                BSQL("eventomuestrapubli", String.Format("id_publicidad='{0}' and id_evento='{1}' and fecha_inicio >= '{2}' and fecha_finalizacion <= '{3}'", publicidadID, positionEvento(cbEvento.SelectedIndex - 1), fechaE1, fechaE2))
            End If
            If (ingresar) Then
                ISQL("eventomuestrapubli", "id_publicidad, id_evento, fecha_inicio, fecha_finalizacion", String.Format("'{0}','{1}','{2}','{3}'", publicidadID, positionEvento(cbEvento.SelectedIndex - 1), fechaE1, fechaE2))
            End If
            BuscarFE()
        Else
            MessageBox.Show("Debe seleccionar un evento para agendar la publicidad")
        End If
    End Sub
    Private Sub FechasMax(Optional ingresar As Boolean = True)
        fecha1 = Format(dtpFI.Value, "yyyy-MM-dd")
        fecha2 = Format(dtpFF.Value, "yyyy-MM-dd")
        If (cbTanda.SelectedIndex > 0) Then
            If (dgvFechas.Rows.Count > 0) Then
                For i As Integer = 0 To dgvFechas.Rows.Count - 1
                    Dim fechaN1 As String = dgvFechas.Rows(i).Cells(0).Value().ToString
                    Dim fechaN2 As String = dgvFechas.Rows(i).Cells(1).Value().ToString
                    If (CDate(fechaN1) < CDate(fecha1)) Then
                        fecha1 = Format(CDate(fechaN1), "yyyy-MM-dd")
                    End If
                    If (CDate(fechaN2) > CDate(fecha2)) Then
                        fecha2 = Format(CDate(fechaN2), "yyyy-MM-dd")
                    End If
                Next
                BSQL("aparecepubli", String.Format("id_publicidad='{0}' and Hora_Inicio='{1}' and fecha_inicio >= '{2}' and fecha_finalizacion <= '{3}'", publicidadID, positionTanda(cbTanda.SelectedIndex - 1), fecha1, fecha2))
            End If
            If (ingresar) Then
                ISQL("aparecepubli", "id_publicidad, hora_inicio, fecha_inicio, fecha_finalizacion", String.Format("'{0}','{1}','{2}','{3}'", publicidadID, positionTanda(cbTanda.SelectedIndex - 1), fecha1, fecha2))
            End If
            BuscarF()
        Else
            MessageBox.Show("Debe seleccionar una tanda para agendar la publicidad")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBorrrT.Click
        FechasMax(False)
    End Sub


    Private Sub btnPrograma_Click(sender As Object, e As EventArgs) Handles btnPrograma.Click
        If Not bwDatos.IsBusy Then
            bwDatos.RunWorkerAsync(3) 'PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
        End If
    End Sub

    Private Sub dtpFIP_ValueChanged(sender As Object, e As EventArgs) Handles dtpFIP.ValueChanged
        If (dtpFFP.Value < dtpFIP.Value) Then
            dtpFFP.Value = dtpFIP.Value
        End If
        dtpFFP.MinDate = dtpFIP.Value
        BuscarFP()
    End Sub

    Private Sub cbPrograma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPrograma.SelectedIndexChanged
        BuscarFP()
    End Sub

    Private Sub dtpFFP_ValueChanged(sender As Object, e As EventArgs) Handles dtpFFP.ValueChanged
        BuscarFP()
    End Sub

    Private Sub btnIngresarP_Click(sender As Object, e As EventArgs) Handles btnIngresarP.Click
        FechasMaxP()
    End Sub

    Private Sub btnBorrarP_Click(sender As Object, e As EventArgs) Handles btnBorrarP.Click
        FechasMaxP(False)
    End Sub

    Private Sub btnBPubli_Click(sender As Object, e As EventArgs) Handles btnBPubli.Click
        If Not IsNothing(dt_fechasA) Then
            If (dt_fechasA.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_fechasA, dgvTE, 0)
                Dim Id2() As String = ObtenerCheck(dt_fechasA, dgvTE, 1)
                Dim Id3() As String = ObtenerCheck(dt_fechasA, dgvTE, 2)
                If Not Id.Length = 0 Then
                    BSQL("aparecepubli", String.Format("id_publicidad='{0}'", publicidadID) + " and " + CreadorCondicion("Hora_Inicio", Id) + " and " + CreadorCondicion("fecha_inicio", Id2, True) + " and " + CreadorCondicion("fecha_finalizacion", Id3, True))
                    If Not (bwDatos.IsBusy) Then
                        bwDatos.RunWorkerAsync(2)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub dgvTE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTE.CellClick, dgvVerCuota.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub
    Private Sub dgvHeaderClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTE.ColumnHeaderMouseClick, dgvVerCuota.ColumnHeaderMouseClick
        CheckAll(sender, e.ColumnIndex)
    End Sub
    Private Sub BuscarCuota()
        If Not (bwDatos.IsBusy) Then
            bwDatos.RunWorkerAsync(5)
        End If
    End Sub
    Private Sub dtpYearCuota_ValueChanged(sender As Object, e As EventArgs) Handles dtpYearCuota.ValueChanged
        BuscarCuota()
    End Sub

    Private Sub cbPagados_CheckedChanged(sender As Object, e As EventArgs) Handles cbPagados.CheckedChanged
        BuscarCuota()
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
    Private Sub btnBorrarC_Click(sender As Object, e As EventArgs) Handles btnBorrarC.Click
        If (CuotaId = -1) Then
            If Not IsNothing(dt_Cuotas) Then
                If (dt_Cuotas.Rows.Count > 0) Then
                    Dim RId() As String = ObtenerCheck(dt_Cuotas, dgvVerCuota, 0)
                    If Not RId.Length = 0 Then
                        Dim formDelete As New frmConfirmarBorrado(CUOTAPUBLICIDAD, RId, False)
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
    Private Sub VaciarCuota()
        dtpFE.Value = Now
        dtpFP.Value = Now
        cbP.Checked = False
        nudValor.Value = 0
    End Sub
    Private Sub btnInsertarC_Click(sender As Object, e As EventArgs) Handles btnInsertarC.Click
        If (CuotaId = -1) Then
            ISQL("publicidadcuota", "id_publicidad,fecha_emision, fecha_pago,precio", String.Format("'{0}','{1}',{2},'{3}'", publicidadID, Format(dtpFE.Value, "yyyy-MM-dd"), If(cbP.Checked, "'" + Format(dtpFP.Value, "yyyy-MM-dd") + "'", "null"), nudValor.Value.ToString.Replace(",", ".")))
            VaciarCuota()
            BuscarCuota()
        Else
            USQL("publicidadcuota", String.Format("fecha_emision='{0}', fecha_pago={1},precio='{2}'", Format(dtpFE.Value, "yyyy-MM-dd"), If(cbP.Checked, "'" + Format(dtpFP.Value, "yyyy-MM-dd") + "'", "null"), nudValor.Value.ToString.Replace(",", ".")), String.Format("id_publicidadcuota='{0}'", CuotaId))
            CuotaId = -1
            CambiarICuota()
            BuscarCuota()
        End If
    End Sub

    Private Sub dgvVerCuota_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVerCuota.CellDoubleClick
        Dim i() As String = CargarID(dt_Cuotas, dgvVerCuota, {0, 1, 2, 3})
        If (i(0) <> 0) Then
            CuotaId = i(0)
            dtpFE.Value = i(1)
            dtpFP.Value = If(i(2) = "", Now, i(2))
            cbP.Checked = i(2) IsNot ""
            nudValor.Value = i(3)
        End If
        CambiarICuota()
    End Sub

    Private Sub btnBEvento_Click(sender As Object, e As EventArgs) Handles btnBEvento.Click
        If Not bwDatos.IsBusy Then
            bwDatos.RunWorkerAsync(4) 'PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
        End If
    End Sub

    Private Sub cbEvento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEvento.SelectedIndexChanged
        BuscarFE()
    End Sub

    Private Sub dtpFFE_ValueChanged(sender As Object, e As EventArgs) Handles dtpFFE.ValueChanged
        BuscarFE()
    End Sub

    Private Sub dtpFIE_ValueChanged(sender As Object, e As EventArgs) Handles dtpFIE.ValueChanged
        If (dtpFFE.Value < dtpFIE.Value) Then
            dtpFFE.Value = dtpFIE.Value
        End If
        dtpFFE.MinDate = dtpFIE.Value
        BuscarFE()
    End Sub

    Private Sub btnBPEvento_Click(sender As Object, e As EventArgs) Handles btnBPEvento.Click
        FechasMaxE(False)
    End Sub

    Private Sub btnIEvento_Click(sender As Object, e As EventArgs) Handles btnIEvento.Click
        FechasMaxE()
    End Sub
    Private Sub btnMP_Click(sender As Object, e As EventArgs) Handles btnMP.Click
        If (cbPrograma.SelectedIndex > 0) Then
            Dim formPrograma As New frmPrograma(positionPrograma(cbPrograma.SelectedIndex - 1))
            AddHandler formPrograma.FormClosed, AddressOf FormPrograma_FormClosed
            formPrograma.ShowDialog()
        End If
    End Sub
    Private Sub FormPrograma_FormClosed()
        If Not bwDatos.IsBusy Then
            bwDatos.RunWorkerAsync(3) 'PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
        End If
    End Sub

    Private Sub btnMostrarE_Click(sender As Object, e As EventArgs) Handles btnMostrarE.Click
        If (cbEvento.SelectedIndex > 0) Then
            Dim formEvento As New frmEvento(positionEvento(cbEvento.SelectedIndex - 1))
            AddHandler formEvento.FormClosed, AddressOf FormEvento_FormClosed
            formEvento.ShowDialog()
        End If
    End Sub
    Private Sub FormEvento_FormClosed()
        If Not bwDatos.IsBusy Then
            bwDatos.RunWorkerAsync(4) 'PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
        End If
    End Sub
End Class