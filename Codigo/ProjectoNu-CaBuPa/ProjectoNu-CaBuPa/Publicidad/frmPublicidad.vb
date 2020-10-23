Imports System.ComponentModel

Public Class frmPublicidad
    Dim publicidadID As Integer
    Public editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Private TBusca As DataTable
    Private TBuscada As String = ""
    Private dt_fechas As DataTable
    Dim position() As String
    Dim positionTanda() As String
    Dim pos() As UInt16 = {0, 0}
    Dim empresaID As Integer = 0
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
            MessageBox.Show("Debe tener empresas ingresadas")
            Close()
        End If
        cbTanda.SelectedIndex = pos(1)
    End Sub
    Public Sub ExtraerDatosTan()
        ReDim positionTanda(dt_tandasCon.Rows.Count - 1)
        For j As Integer = 0 To dt_tandasCon.Rows.Count - 1
            positionTanda(j) = dt_tandasCon.Rows(j).Item(0).ToString
        Next
        'For i As Integer = 0 To position.Length - 1
        'If empresaID = positionTanda(i) Then
        'pos(1) = i + 1
        'Exit For
        'End If
        'Next
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
        Dim Columna As String = ""
        Dim Condicion As String = "true"
        Dim Tablas As String = ""
        If Not (bwDatos.IsBusy) Then
            bwDatos.RunWorkerAsync(tcP.SelectedIndex)
        End If
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDatos.DoWork
        Select Case e.Argument
            Case 1
                TBuscada = "Tanda"
                dt_tandasCon = DevolverTabla(PSQL("Hora_inicio, concat('Tanda ',Hora_Inicio,' ',Hora_fin) as 'Horas'", "Tanda", "True"))
                ModLog.Guardar(PSQL("Hora_inicio, concat('Tanda ',Hora_Inicio,' ',Hora_fin) as 'Horas'", "Tanda", "True"))
        End Select
    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        Select Case TBuscada
            Case "Tanda"
                CargarComboTandas()
        End Select
    End Sub
End Class