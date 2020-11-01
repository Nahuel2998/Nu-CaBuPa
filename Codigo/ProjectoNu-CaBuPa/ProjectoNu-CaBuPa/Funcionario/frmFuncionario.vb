Imports System.ComponentModel

Public Class frmFuncionario
    Dim ID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(3) As String
    Dim cambio As Boolean = False   ' Controla si han habido cambios desde el ultimo modo de edicion
    Dim dt_Funciones As New DataTable
    Dim datos() As String
    Dim TBuscada As Byte
    Dim TBusca As DataTable
    Dim dt_BFuncionesAs As DataTable
    Public Sub New(ByVal DatosI() As String)
        InitializeComponent()
        'Los siguientes datos se obtienen de la tabla en el elemento padre
        ID = DatosI(0)
        txtNombre.Text = DatosI(1)
        txtTelefono.Text = DatosI(2)
        txtMail.Text = DatosI(3)
    End Sub

    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
        If (ID = -1) Then
            tcF.TabPages.RemoveAt(1)
            Alternar()
        End If
        btnSalir.Select()
    End Sub

    Private Sub CargarDatos()
        datos = {txtTelefono.Text, txtNombre.Text, If(ValidarEmail(txtMail.Text), txtMail.Text, tmpDatos(3))}
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If ID = -1 Then
            CargarDatos()
            PrepararInsert("Funcionario", datos)
            Vaciar()
        ElseIf editando Then
            If cambio Then
                CargarDatos()
                If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                    PrepararUpdate("Funcionario", datos, ID)
                End If
                AlternarCambioHandlers()
            End If
        Else
            tmpDatos = {txtTelefono.Text, txtNombre.Text, txtMail.Text}
        End If

        Alternar()
    End Sub
    Private Sub Vaciar()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtMail.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Not editando Or ID = -1 Then
            Close()
        Else
            If cambio Then
                txtNombre.Text = tmpDatos(1)
                txtTelefono.Text = tmpDatos(0)
                txtMail.Text = tmpDatos(2)
                AlternarCambioHandlers()
            End If

            Alternar()
        End If
    End Sub

    Private Sub FrmFuncionario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambio And ID <> -1 Then
            CargarDatos()
            If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                Dim g As New frmGuardarEdicion("Funcionario", datos, ID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Funcionario") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Funcionario", "")
                Else
                    AlternarCambioHandlers()
                End If
            End If
        End If
    End Sub

    '' Alternar botones
    Private Sub Alternar()
        If ID = -1 Then
            btnEditar.Text = "Ingresar"
            btnBorrar.Visible = False
            btnSalir.Text = "Salir"
            Text = "Ingresar Funcionario"
        ElseIf editando Then
            btnEditar.Text = "Editar"
            btnSalir.Text = "Salir"
            Text = "Ver Funcionario"
        Else
            btnSalir.Text = "Cancelar"
            btnEditar.Text = "Guardar"
            Text = "Editar Funcionario"
        End If
        editando = Not editando

        txtNombre.ReadOnly = Not editando
        txtTelefono.ReadOnly = Not editando
        txtMail.ReadOnly = Not editando
    End Sub

    '' Checkean si hay cambios hechos
    '' Si cambio = True, no se llamaran
    Private Sub txt_ModifiedChanged(sender As Object, e As EventArgs) Handles txtNombre.ModifiedChanged, txtMail.ModifiedChanged, txtTelefono.ModifiedChanged
        If txtNombre.Modified Or txtMail.Modified Or txtTelefono.Modified Then
            AlternarCambioHandlers()
        End If
    End Sub

    ' Aqui yacIA mi variable, recordatorio de lo que una vez fue Y AUN ES
    ' cambio: I LIVED BITCH

    '' Alterna el estado de cambios y activa/desactiva la deteccion de cambios
    Private Sub AlternarCambioHandlers()
        '' cambio = True    -> Se aniadiran los handlers, se los necesita
        '' cambio = False   -> Se ha detectado un cambio, y los handlers se removeran hasta la siguiente llamada del metodo
        If cambio Then
            AddHandler txtNombre.ModifiedChanged, AddressOf txt_ModifiedChanged
            AddHandler txtMail.ModifiedChanged, AddressOf txt_ModifiedChanged
            AddHandler txtTelefono.ModifiedChanged, AddressOf txt_ModifiedChanged
        Else
            RemoveHandler txtNombre.ModifiedChanged, AddressOf txt_ModifiedChanged
            RemoveHandler txtMail.ModifiedChanged, AddressOf txt_ModifiedChanged
            RemoveHandler txtTelefono.ModifiedChanged, AddressOf txt_ModifiedChanged
        End If
        cambio = Not cambio
    End Sub

    Private Sub dgvFunciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFunciones.CellDoubleClick
        Dim i() As String = CargarID(dt_Funciones, dgvFunciones, {0, 1, 2})
        If (i.Length <> 1) Then
            Dim formFuncion As New frmFuncion(i)
            AddHandler formFuncion.FormClosed, AddressOf FormFuncion_FormClosed
            formFuncion.ShowDialog()
        End If
    End Sub

    '' Actualiza la tabla mostrando las funciones asociadas cuando el formulario de mostrar funciones se ha cerrado
    Private Sub FormFuncion_FormClosed(sender As Object, e As FormClosedEventArgs)
        ActualizarTabla()
    End Sub

    '' Actualizar tabla de Funciones
    Private Sub ActualizarTabla()
        dt_Funciones = DevolverTabla(PSQL("f.ID_Funcion, f.Nombre, f.Descripcion", "Funcion f join TrabajaComo t on f.ID_Funcion = t.ID_Funcion", String.Format("t.ID_Funcionario = '{0}'", ID)))
        ActualizarTablaC(dt_Funciones, dgvFunciones)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(FUNCIONARIO, {ID}, True)
        formDelete.ShowDialog(Me)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub BWBuscador_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWBuscador.RunWorkerCompleted
        Select Case TBuscada
            Case FUNCION
                dt_BFuncionesAs = TBusca
                ActualizarTablaC(dt_BFuncionesAs, dgvFuncionesBFF)

                TBuscada = FUNCIONARIO
                BWBuscador.RunWorkerAsync(PSQL("f.ID_Funcion, f.Nombre, f.Descripcion", "Funcion f join TrabajaComo t on f.ID_Funcion = t.ID_Funcion", String.Format("t.ID_Funcionario = '{0}'", ID)))
            Case FUNCIONARIO
                dt_Funciones = TBusca
                ActualizarTablaC(dt_Funciones, dgvFuncionesAs)

                TBusca = Nothing
                TBuscada = 0
        End Select
    End Sub

    Private Sub BWBuscador_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWBuscador.DoWork
        TBusca = DevolverTabla(e.Argument)
        ModLog.Guardar("Funcionario: " & e.Argument)
    End Sub

    Private Sub tcF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcF.SelectedIndexChanged
        If tcF.SelectedIndex = 0 Then
            ActualizarTabla()
        Else
            Buscar()
        End If
    End Sub

    Private Sub Buscar()
        TBuscada = FUNCION
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtNombreBFF.Text)) Then
            condicion = String.Format("Nombre like '%{0}%'", txtNombreBFF.Text)
        End If
        If (Not String.IsNullOrWhiteSpace(txtDescripcionBFF.Text)) Then
            condicion += String.Format(" and Descripcion like '%{0}%'", txtDescripcionBFF.Text)
        End If
        condicion += String.Format(" and ID_Funcion not in (select ID_Funcion from TrabajaComo where ID_Funcionario = {0})", ID)
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("ID_Funcion, Nombre, Descripcion", "Funcion", condicion))
        End If
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        If ObtenerCheck(dt_BFuncionesAs, dgvFuncionesBFF).Length > 0 Then
            MISQL("TrabajaComo",
              "ID_Funcion, ID_Funcionario",
              ObtenerCheck(dt_BFuncionesAs,
                           dgvFuncionesBFF,
                           0,
                           String.Format(",'{0}'", ID.ToString),
                           True))
            Buscar()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionesBFF.CellClick, dgvFuncionesAs.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub

    Private Sub btnDesasignar_Click(sender As Object, e As EventArgs) Handles btnDesasignar.Click
        Dim Checked() As String = ObtenerCheck(dt_Funciones, dgvFuncionesAs)
        If Checked.Length > 0 Then
            BSQL("TrabajaComo", String.Format("ID_Funcionario = '{0}' and ", ID) + CreadorCondicion("ID_Funcion", Checked))
            Buscar()
        End If
    End Sub
End Class
