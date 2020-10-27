Imports System.ComponentModel

Public Class frmPublicidad
    Dim publicidadID As Integer
    Public editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Private dt_ProgramasP As DataTable
    Private dt_FProgramas As DataTable
    Private TBuscada As String = ""
    Private dt_fechas As DataTable
    Private dt_fechasA As DataTable
    Dim position() As String
    Dim positionTanda() As String
    Dim positionPrograma() As String
    Dim pos() As UInt16 = {0, 0, 0}
    Dim empresaID As Integer = 0
    Dim fecha1 As String
    Dim fecha2 As String
    Dim fechaP1 As String
    Dim fechaP2 As String
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
            Close()
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
    Public Sub ExtraerDatosProg()
        ReDim positionPrograma(dt_ProgramasP.Rows.Count - 1)
        For j As Integer = 0 To dt_ProgramasP.Rows.Count - 1
            positionPrograma(j) = dt_ProgramasP.Rows(j).Item(0).ToString
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
        Else
            tcP.TabPages.RemoveAt(1)
            tcP.TabPages.RemoveAt(2)
            tcP.TabPages.RemoveAt(3)
            btnEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
            CargarCombo()
        End If
        btnSalir.Select()
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
        If (tcP.SelectedIndex() = 1 Or tcP.SelectedIndex() = 2) Then
            If Not (bwDatos.IsBusy) Then
                bwDatos.RunWorkerAsync(tcP.SelectedIndex())
            End If
        End If
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDatos.DoWork
        Select Case e.Argument
            Case 1
                TBuscada = "Tanda"
                dt_tandasCon = DevolverTabla(PSQL("Hora_inicio, concat('Tanda ',Hora_Inicio,' ',Hora_fin) as 'Horas'", "Tanda", "True"))
                ModLog.Guardar(PSQL("Hora_inicio, concat('Tanda ',Hora_Inicio,' ',Hora_fin) as 'Horas'", "Tanda", "True"))
            Case 2
                TBuscada = "Fecha"
                Dim condicion = "true"
                dt_fechasA = DevolverTabla(PSQL("distinct a.hora_inicio as 'Hora de tanda', fecha_inicio as 'Fecha Inicio', fecha_finalizacion as 'Fecha Finalización'", "aparecepubli a left join tanda t on t.hora_inicio = null", condicion))
        End Select
    End Sub
    Private Sub ATAntigua()
        ActualizarTablaC(dt_fechasA, dgvTE, False)
    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        Select Case TBuscada
            Case "Tanda"
                CargarComboTandas()
            Case "Fecha"
                ATAntigua()
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
            bwDatos.RunWorkerAsync(2) 'PSQL("ID_Programa, Nombre_Programa as Nombre, Descripcion", "programa", condicion))
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
    Private Sub dgvTE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTE.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub
End Class