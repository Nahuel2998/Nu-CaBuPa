' TODO: Indicador de editar (?)
Public Class frmEmpresa
    Dim empresaID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos() As String = {"", "", "", ""}
    Dim cambio As Boolean = False    ' Controla si han habido cambios desde el ultimo modo de edicion
    Dim dt_Publicidad As New DataTable
    Dim datos() As String
    Public Sub New(ByVal DatosI() As String)
        InitializeComponent()
        'Los siguientes datos se obtienen de la tabla en el elemento padre
        empresaID = DatosI(0)
        txtNombre.Text = DatosI(1)
        txtTelefono.Text = DatosI(2)
        txtMail.Text = DatosI(3)
        ''ModLog.Guardar(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", String.Format("id_serie = '{0}'", DatosI(0))))
    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
        If (empresaID = -1) Then
            Alternar()
        End If
        If Not PoseePermiso("Empresa", "a") Then
            btnBorrar.Visible = False
            btnSEditar.Visible = False
        End If
    End Sub
    Private Sub CargarDatos()
        datos = {txtNombre.Text, txtTelefono.Text, If(ValidarEmail(txtMail.Text), txtMail.Text, tmpDatos(3))}
    End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If empresaID = -1 Then
            CargarDatos()
            If (ValidarEmail(txtMail.Text)) Then

                PrepararInsert("Empresa", datos)
                Vaciar()
            Else
                MessageBox.Show("Debe ingresar un mail de contacto válido")
            End If
        ElseIf editando Then
            If cambio Then
                CargarDatos()
                If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                    PrepararUpdate("Empresa", datos, empresaID)
                End If
                'AlternarCambioHandlers()
            End If
            Alternar()
        Else
            tmpDatos(0) = txtNombre.Text
            tmpDatos(1) = txtTelefono.Text
            tmpDatos(2) = txtMail.Text
            Alternar()
        End If
    End Sub
    Private Sub Vaciar()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtMail.Clear()
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        If Not editando Or empresaID = -1 Then
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

    Private Sub Serie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambio And empresaID <> -1 Then
            CargarDatos()
            If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                Dim g As New frmGuardarEdicion("Empresa", datos, empresaID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Empresa") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Empresa", "")
                Else
                    AlternarCambioHandlers()
                End If
            End If
        End If
    End Sub

    '' Alternar botones
    Private Sub Alternar()
        If empresaID = -1 Then
            btnSEditar.Text = "Ingresar"
            btnBorrar.Visible = False
            btnSSalir.Text = "Salir"
            Text = "Ingresar Empresa"
        ElseIf editando Then
            btnSEditar.Text = "Editar"
            btnSSalir.Text = "Salir"
            Text = "Ver Empresa"
        Else
            btnSSalir.Text = "Cancelar"
            btnSEditar.Text = "Guardar"
            Text = "Editar Empresa"
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

    Private Sub dgvVSM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVSM.CellDoubleClick
        Dim i As Integer = CargarID(dt_Video, dgvVSM)
        If (i <> -1) And PoseePermiso("Publicidades") Then
            Dim formPubli As New frmPublicidad(i)
            AddHandler formPubli.FormClosed, AddressOf formPubli_FormClosed
            formPubli.ShowDialog()
        End If
    End Sub
    Private Sub formPubli_FormClosed(sender As Object, e As FormClosedEventArgs)
        ActualizarTabla()
    End Sub

    '' Actualiza la tabla mostrando los videos asociados cuando el formulario de mostrar video se ha cerrado
    Private Sub FormPublicidad_FormClosed(sender As Object, e As FormClosedEventArgs)
        ActualizarTabla()
        ' TODO: Darle uso.
    End Sub

    Private Sub ActualizarTabla()
        dt_Publicidad = DevolverTabla(PSQL("ID_Publicidad, Nombre, Tema", "publicidad", String.Format("ID_Empresa = '{0}'", empresaID)))
        ActualizarTablaC(dt_Publicidad, dgvVSM)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(EMPRESA, {empresaID}, True)
        formDelete.ShowDialog(Me)
    End Sub

End Class
