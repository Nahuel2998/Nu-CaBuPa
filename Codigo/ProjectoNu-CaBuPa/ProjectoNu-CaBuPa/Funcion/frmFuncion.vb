Public Class frmFuncion
    Dim ID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(1) As String
    Dim cambio As Boolean = False   ' Controla si han habido cambios desde el ultimo modo de edicion
    Dim datos() As String
    Public Sub New(ByVal DatosI() As String)
        InitializeComponent()
        'Los siguientes datos se obtienen de la tabla en el elemento padre
        ID = DatosI(0)
        txtNombre.Text = DatosI(1)
        txtDesc.Text = DatosI(2)
    End Sub

    Private Sub frmFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not PoseePermiso("Funcionario", "a") Then
            btnBorrar.Visible = False
            btnEditar.Visible = False
        End If
        If (ID = -1) Then
            Alternar()
        End If
        btnSalir.Select()
    End Sub

    Private Sub CargarDatos()
        datos = {txtNombre.Text, txtDesc.Text}
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If ID = -1 Then
            CargarDatos()
            PrepararInsert("Funcion", datos)
            Vaciar()
        ElseIf editando Then
            If cambio Then
                CargarDatos()
                If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                    PrepararUpdate("Funcion", datos, ID)
                End If
                AlternarCambioHandlers()
            End If
        Else
            tmpDatos = {txtNombre.Text, txtDesc.Text}
        End If

        Alternar()
    End Sub
    Private Sub Vaciar()
        txtNombre.Clear()
        txtDesc.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Not editando Or ID = -1 Then
            Close()
        Else
            If cambio Then
                txtNombre.Text = tmpDatos(0)
                txtDesc.Text = tmpDatos(1)
                AlternarCambioHandlers()
            End If

            Alternar()
        End If
    End Sub

    Private Sub FrmFuncion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambio And ID <> -1 Then
            CargarDatos()
            If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                Dim g As New frmGuardarEdicion("Funcion", datos, ID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Funcion") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Funcion", "")
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
            Text = "Ingresar Funcion"
        ElseIf editando Then
            btnEditar.Text = "Editar"
            btnSalir.Text = "Salir"
            Text = "Ver Funcion"
        Else
            btnSalir.Text = "Cancelar"
            btnEditar.Text = "Guardar"
            Text = "Editar Funcion"
        End If
        editando = Not editando

        txtNombre.ReadOnly = Not editando
        txtDesc.ReadOnly = Not editando
    End Sub

    '' Checkean si hay cambios hechos
    '' Si cambio = True, no se llamaran
    Private Sub txt_ModifiedChanged(sender As Object, e As EventArgs) Handles txtNombre.ModifiedChanged, txtDesc.ModifiedChanged
        If txtNombre.Modified Or txtDesc.Modified Then
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
            AddHandler txtDesc.ModifiedChanged, AddressOf txt_ModifiedChanged
        Else
            RemoveHandler txtNombre.ModifiedChanged, AddressOf txt_ModifiedChanged
            RemoveHandler txtDesc.ModifiedChanged, AddressOf txt_ModifiedChanged
        End If
        cambio = Not cambio
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(FUNCION, {ID}, True)
        formDelete.ShowDialog(Me)
    End Sub
End Class