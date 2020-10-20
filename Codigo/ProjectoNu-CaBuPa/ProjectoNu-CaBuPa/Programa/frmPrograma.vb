Imports System.ComponentModel

Public Class frmPrograma
    Dim programaID As Integer
    Public editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Private TBusca As DataTable
    Private dt_funcionario As DataTable
    Private dt_fechas As DataTable
    Private TBuscada As String

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

    Private Sub frmPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If programaID <> -1 Then
            bwDatos.RunWorkerAsync()
        Else
            tcP.TabPages.RemoveAt(1)
            tcP.TabPages.RemoveAt(2)
            tcP.TabPages.RemoveAt(3)
            tcP.TabPages.RemoveAt(4)
            btnPEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
        End If
        dtpFecha.BackColor = Color.FromArgb(64, 64, 64)
        dtpFecha.ForeColor = Color.White
        btnPSalir.Select()
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
    Sub vaciar()
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
        Dim formDelete As New frmConfirmarBorrado("Programa", {programaID}, True)
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
        Dim Columna As String = ""
        Dim Condicion As String = "true"
        Dim Tablas As String = ""
        Select Case tcP.SelectedIndex
            Case 1
                TBuscada = "Funcionario"
                Columna = "fun.id_funcionario, fun.Nombre, Telefono, Mail as EMail, f.Nombre as Función, fecha_inicio as 'Inicio de la función', fecha_finalizacion as 'Fin de la función'"
                Tablas = "(select * from funtrabaja where id_Programa = {0}) ft inner join trabajacomo tc on ft.id_trabajacomo = tc.id_trabajacomo inner join funcion f on f.id_funcion = tc.id_funcion inner join funcionario fun on fun.id_funcionario = tc.id_funcionario"
                Tablas = String.Format(Tablas, programaID)
            Case 4
                TBuscada = "fechaprograma"
                Columna = "hora_inicio as 'Inicio', hora_fin as 'Final'"
                Tablas = "fechaprograma"
                Condicion = String.Format("id_programa = {0} and fecha = '{1}'", programaID, Format(Now.Date, "yyyy-MM-dd"))
        End Select
        If Not (bwCargador.IsBusy) Then
            bwCargador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub
    Public Sub BFecha()
        Dim Columna As String = "hora_inicio as 'Inicio', hora_fin as 'Final'"
        Dim Condicion As String = String.Format("id_programa = {0} and fecha = '{1}'", programaID, Format(dtpBP.Value, "yyyy-MM-dd"))
        Dim Tablas As String = "fechaprograma"
        TBuscada = "fechaprograma"
        If Not (bwCargador.IsBusy) Then
            bwCargador.RunWorkerAsync(PSQL(Columna, Tablas, Condicion))
        End If
    End Sub

    Private Sub bwCargador_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCargador.RunWorkerCompleted
        Select Case TBuscada
            Case "Funcionario"
                dt_funcionario = TBusca
                ActualizarTablaC(dt_funcionario, dgvFuncionarios)
            Case "fechaprograma"
                dt_fechas = TBusca
                ActualizarTablaC(dt_fechas, dgvPrograma, False)
            Case "FechaPrograma"
                dt_Empresa = TBusca
               ' ActualizarTablaC(dt_Empresa, dgvClientes)
            Case "CuotaPrograma"
                dt_BPrograma = TBusca
                ' ActualizarTablaC(dt_BPrograma, dgvBProgramas)
        End Select
        TBusca = Nothing
        TBuscada = ""
    End Sub




    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim datos() As String = {Format(dtpAP.Value().Date, "yyyy-MM-dd"), txtHI.Text, txtHF.Text, programaID}
        PrepararInsert("fechaprograma", datos, 0)
        txtHI.Text = ""
        txtHF.Text = ""
    End Sub

    Private Sub dtpBP_ValueChanged(sender As Object, e As EventArgs) Handles dtpBP.ValueChanged
        BFecha()
    End Sub

    Private Sub dgvPrograma_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograma.CellClick
        ClickCheck(dgvPrograma)
    End Sub

    Private Sub btnABorrar_Click(sender As Object, e As EventArgs) Handles btnABorrar.Click
        If Not IsNothing(dt_fechas) Then
            If (dt_fechas.Rows.Count > 0) Then
                Dim RId() As String = ObtenerCheck(dt_fechas, dgvPrograma, 0)
                If Not RId.Length = 0 Then
                    Dim formDelete As New frmConfirmarBorrado("Fechaprograma", {Format(dtpBP.Value, "yyyy-MM-dd")}, False, RId)
                    formDelete.ShowDialog(Me)
                    BFecha()
                End If
            End If
        End If
    End Sub
End Class