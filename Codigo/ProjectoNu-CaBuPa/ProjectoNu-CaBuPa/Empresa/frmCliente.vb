﻿' TODO: Indicador de editar (?)
Public Class frmCliente
    Dim empresaID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(2) As String
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
        ' ...Esto tambien, supongo.....
        ''ModLog.Guardar(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", String.Format("id_serie = '{0}'", DatosI(0))))
    End Sub

    Private Sub frmSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
        If (empresaID = -1) Then
            Alternar()
        End If
    End Sub
    Sub CargarDatos()
        datos = {txtNombre.Text, txtTelefono.Text, If(ValidarEmail(txtMail.Text), txtMail.Text, "")}
    End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If empresaID = -1 Then
            CargarDatos()
            PrepararInsert("Empresa", datos)
            vaciar()
        ElseIf editando Then
            If cambio Then
                CargarDatos()
                If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                    PrepararUpdate("Empresa", datos, empresaID)
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
    Sub vaciar()
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        If Not editando Or empresaID <> -1 Then
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
            ActiveForm.Text = "Ingresar Cliente"
        ElseIf editando Then
            btnSEditar.Text = "Editar"
            btnSSalir.Text = "Salir"
            ActiveForm.Text = "Ver Cliente"
        Else
            btnSSalir.Text = "Cancelar"
            btnSEditar.Text = "Guardar"
            ActiveForm.Text = "Editar Cliente"
        End If
        editando = Not editando

        txtNombre.ReadOnly = Not editando
        txtTelefono.ReadOnly = Not editando
        txtMail.ReadOnly = Not editando
    End Sub

    '' Checkean si hay cambios hechos
    '' Si cambio = True, no se llamaran
    Private Sub txtNombre_ModifiedChanged(sender As Object, e As EventArgs) Handles txtNombre.ModifiedChanged
        If txtNombre.Modified Then
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
            AddHandler txtNombre.ModifiedChanged, AddressOf txtNombre_ModifiedChanged
            AddHandler txtMail.ModifiedChanged, AddressOf txtMail_ModifiedChanged
            AddHandler txtTelefono.ModifiedChanged, AddressOf txtTelefono_ModifiedChanged
        Else
            RemoveHandler txtNombre.ModifiedChanged, AddressOf txtNombre_ModifiedChanged
            RemoveHandler txtMail.ModifiedChanged, AddressOf txtMail_ModifiedChanged
            RemoveHandler txtTelefono.ModifiedChanged, AddressOf txtTelefono_ModifiedChanged
        End If
        cambio = Not cambio
    End Sub

    Private Sub dgvVSM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVSM.CellDoubleClick
        'Dim i As Integer = CargarID(dt_Video, dgvVSM)
        'If (i <> -1) Then
        'Dim formVideo As New frmVideo(i)
        'AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
        'formVideo.ShowDialog()
        'End If
    End Sub

    '' Actualiza la tabla mostrando los videos asociados cuando el formulario de mostrar video se ha cerrado
    Private Sub FormVideo_FormClosed(sender As Object, e As FormClosedEventArgs)
        ActualizarTabla()
    End Sub

    Private Sub ActualizarTabla()
        dt_Publicidad = DevolverTabla(PSQL("ID_Publicidad, Tema", "publicidad", String.Format("ID_Empresa = '{0}'", empresaID)))
        ActualizarTablaC(dt_Publicidad, dgvVSM)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado("Empresa", {empresaID}, True)
        formDelete.ShowDialog(Me)
    End Sub

    Private Sub txtMail_ModifiedChanged(sender As Object, e As EventArgs) Handles txtMail.ModifiedChanged
        If txtMail.Modified Then
            AlternarCambioHandlers()
        End If
    End Sub

    Private Sub txtTelefono_ModifiedChanged(sender As Object, e As EventArgs) Handles txtTelefono.ModifiedChanged
        If txtTelefono.Modified Then
            AlternarCambioHandlers()
        End If
    End Sub

End Class
