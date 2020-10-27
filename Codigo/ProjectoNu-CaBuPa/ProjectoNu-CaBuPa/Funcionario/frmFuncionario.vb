﻿Public Class frmFuncionario
    Dim ID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(3) As String
    Dim cambio As Boolean = False   ' Controla si han habido cambios desde el ultimo modo de edicion
    'Dim dt_Funcion As New DataTable
    Dim datos() As String
    Public Sub New(ByVal DatosI() As String)
        InitializeComponent()
        'Los siguientes datos se obtienen de la tabla en el elemento padre
        ID = DatosI(0)
        txtNombre.Text = DatosI(1)
        txtTelefono.Text = DatosI(2)
        txtMail.Text = DatosI(3)
    End Sub

    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ActualizarTabla()
        If (ID = -1) Then
            Alternar()
        End If
        btnSalir.Select()
    End Sub
    Private Sub CargarDatos()
        datos = {txtNombre.Text, txtTelefono.Text, If(ValidarEmail(txtMail.Text), txtMail.Text, tmpDatos(3))}
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
            tmpDatos(0) = txtNombre.Text
            tmpDatos(1) = txtTelefono.Text
            tmpDatos(2) = txtMail.Text
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
                txtNombre.Text = tmpDatos(0)
                txtTelefono.Text = tmpDatos(1)
                txtMail.Text = tmpDatos(2)
                AlternarCambioHandlers()
            End If

            Alternar()
        End If
    End Sub

    Private Sub Funcionario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub txt_ModifiedChanged(sender As Object, e As EventArgs)
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

    'Private Sub dgvVSM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVSM.CellDoubleClick
    '    'Dim i As Integer = CargarID(dt_Video, dgvVSM)
    '    'If (i <> -1) Then
    '    'Dim formVideo As New frmVideo(i)
    '    'AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
    '    'formVideo.ShowDialog()
    '    'End If
    'End Sub

    '' Actualiza la tabla mostrando las funciones asociadas cuando el formulario de mostrar funciones se ha cerrado
    'Private Sub FormFuncion_FormClosed(sender As Object, e As FormClosedEventArgs)
    '    ActualizarTabla()
    '    ' TODO: Darle uso.
    'End Sub

    '' Actualizar tabla de Funcionarios
    'Private Sub ActualizarTabla()
    '    dt_Publicidad = DevolverTabla(PSQL("ID_Publicidad, Tema", "publicidad", String.Format("ID_Empresa = '{0}'", empresaID)))
    '    ActualizarTablaC(dt_Publicidad, dgvVSM)
    'End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(FUNCIONARIO, {ID}, True)
        formDelete.ShowDialog(Me)
    End Sub
End Class
