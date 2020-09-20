' TODO: Indicador de editar (?)
Public Class frmSerie
    Dim serieID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(1) As String
    Dim cambio As Boolean = False    ' Controla si han habido cambios desde el ultimo modo de edicion
    Dim dt_Video As New DataTable
    Public Sub New(ByVal DatosI() As String)
        InitializeComponent()
        'Los siguientes datos se obtienen de la tabla en el elemento padre
        serieID = DatosI(0)
        txtNombre.Text = DatosI(2)
        If DatosI(1) <> "" Then
            RemoveHandler dtpFecha.ValueChanged, AddressOf dtpFecha_ValueChanged
            dtpFecha.Value = CDate(DatosI(1))
            AddHandler dtpFecha.ValueChanged, AddressOf dtpFecha_ValueChanged
            ' Fix temporal... no me maten
        Else
            txtTapar.Visible = True
        End If
        RemoveHandler chbIncluir.CheckedChanged, AddressOf chbIncluir_CheckedChanged
        chbIncluir.Checked = DatosI(1) <> ""
        AddHandler chbIncluir.CheckedChanged, AddressOf chbIncluir_CheckedChanged
        ' ...Esto tambien, supongo.....
        ''ModLog.Guardar(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", String.Format("id_serie = '{0}'", DatosI(0))))

    End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If editando Then
            If cambio Then
                Dim datos() As String = {If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null"), txtNombre.Text}
                If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                    PrepararUpdate("Serie", datos, serieID)
                End If

                AlternarCambioHandlers()
            End If
        Else
            tmpDatos(0) = If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "")
            tmpDatos(1) = txtNombre.Text
        End If

        Alternar()
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        If Not editando Then
            Close()
        Else
            If cambio Then
                If tmpDatos(0) <> "" Then
                    dtpFecha.Value = CDate(tmpDatos(0))
                Else
                    dtpFecha.Value = Now.Date

                    chbIncluir.Checked = False
                End If
                txtNombre.Text = tmpDatos(1)

                AlternarCambioHandlers()
            End If

            Alternar()
        End If
    End Sub

    Private Sub Serie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambio Then
            Dim datos() As String = {If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null"), txtNombre.Text}
            If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                Dim g As New frmGuardarEdicion("Serie", datos, serieID, Me)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Serie") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Serie", "")
                Else
                    AlternarCambioHandlers()
                End If
            End If
        End If
        ' FIXME: Probablemente mover esto?
        frmPrin.btnBuscarBS.PerformClick()
    End Sub

    '' Alternar botones
    Private Sub Alternar()
        If editando Then
            btnSEditar.Text = "Editar"
            btnSSalir.Text = "Salir"
            ActiveForm.Text = "Ver Serie"

            txtTapar.Visible = Not chbIncluir.Checked
        Else
            btnSSalir.Text = "Cancelar"
            btnSEditar.Text = "Guardar"
            ActiveForm.Text = "Editar Serie"

            RemoveHandler chbIncluir.CheckedChanged, AddressOf chbIncluir_CheckedChanged
            chbIncluir.Checked = tmpDatos(0) <> ""
            AddHandler chbIncluir.CheckedChanged, AddressOf chbIncluir_CheckedChanged
            ' ...Sufro con poner esas dos lineas

            txtTapar.Visible = False
        End If
        editando = Not editando

        txtNombre.ReadOnly = Not editando
        dtpFecha.Enabled = editando
        chbIncluir.Enabled = editando
    End Sub

    '' Checkean si hay cambios hechos
    '' Si cambio = True, no se llamaran
    Private Sub txtNombre_ModifiedChanged(sender As Object, e As EventArgs) Handles txtNombre.ModifiedChanged
        If txtNombre.Modified Then
            AlternarCambioHandlers()
        End If
    End Sub
    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        AlternarCambioHandlers()
    End Sub
    Private Sub chbIncluir_CheckedChanged(sender As Object, e As EventArgs) Handles chbIncluir.CheckedChanged
        AlternarCambioHandlers()
    End Sub

    ' Aqui yacIA mi variable, recordatorio de lo que una vez fue Y AUN ES
    ' cambio: I LIVED BITCH

    '' Alterna el estado de cambios y activa/desactiva la deteccion de cambios
    Private Sub AlternarCambioHandlers()
        '' cambio = True    -> Se aniadiran los handlers, se los necesita
        '' cambio = False   -> Se ha detectado un cambio, y los handlers se removeran hasta la siguiente llamada del metodo
        If cambio Then
            AddHandler dtpFecha.ValueChanged, AddressOf dtpFecha_ValueChanged
            AddHandler txtNombre.ModifiedChanged, AddressOf txtNombre_ModifiedChanged
            AddHandler chbIncluir.CheckedChanged, AddressOf chbIncluir_CheckedChanged
        Else
            RemoveHandler dtpFecha.ValueChanged, AddressOf dtpFecha_ValueChanged
            RemoveHandler txtNombre.ModifiedChanged, AddressOf txtNombre_ModifiedChanged
            RemoveHandler chbIncluir.CheckedChanged, AddressOf chbIncluir_CheckedChanged
        End If
        cambio = Not cambio
    End Sub

    Private Sub frmSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_Video = DevolverTabla(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", String.Format("id_serie = '{0}'", serieID)))
        ActualizarTablaC(dt_Video, dgvVSM)
    End Sub

    Private Sub dgvVSM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVSM.CellDoubleClick
        Dim i As Integer = CargarID(dt_Video, dgvVSM)
        If (i <> -1) Then
            Dim formVideo As New frmVideo(i)
            formVideo.ShowDialog()
        End If
    End Sub
End Class
