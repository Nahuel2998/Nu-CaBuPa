' TODO: Indicador de editar (?)
Public Class frmSerie
    Dim serieID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(1) As String
    Dim cambio As Boolean = False   ' Controla si han habido cambios desde el ultimo modo de edicion

    'Public Sub New(ByVal sid As Integer, ByVal nombre As String, ByVal fecha As Date)
    '   InitializeComponent()
    '
    ' Los siguientes datos se obtienen de la tabla en el elemento padre
    '  serieID = sid
    ' txtNombre.Text = nombre
    'dtpFecha.Value = fecha
    'End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If editando Then
            If cambio Then
                Dim datos() As String = {Format(dtpFecha.Value, "yyyy-MM-dd"), txtNombre.Text}
                If Not CompararValores(datos, tmpDatos) Then
                    PrepararUpdate("Serie", datos, serieID)
                End If

                AlternarCambioHandlers()
            End If
        Else
            tmpDatos(0) = Format(dtpFecha.Value, "yyyy-MM-dd")
            tmpDatos(1) = txtNombre.Text
        End If

        Alternar()
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        If Not editando Then
            Close()
        Else
            If cambio Then
                dtpFecha.Value = CDate(tmpDatos(0))
                txtNombre.Text = tmpDatos(1)

                AlternarCambioHandlers()
            End If

            Alternar()
        End If
    End Sub

    Private Sub Serie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambio Then
            Dim datos() As String = {Format(dtpFecha.Value, "yyyy-MM-dd"), txtNombre.Text}
            If Not CompararValores(datos, tmpDatos) Then
                Dim g As New frmGuardarEdicion("Serie", datos, serieID, Me)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Serie") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Serie", "")
                Else
                    ' Ejecutar boton de buscar de BuscarSerie
                    AlternarCambioHandlers()
                End If
            End If
        End If
    End Sub

    '' Alternar botones
    Private Sub Alternar()
        If editando Then
            btnSEditar.Text = "Editar"
            btnSSalir.Text = "Salir"
            ActiveForm.Text = "Ver Serie"
        Else
            btnSSalir.Text = "Cancelar"
            btnSEditar.Text = "Guardar"
            ActiveForm.Text = "Editar Serie"
        End If
        editando = Not editando

        txtNombre.ReadOnly = Not editando
        dtpFecha.Enabled = editando
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

    ' Aqui yacIA mi variable, recordatorio de lo que una vez fue Y AUN ES
    ' cambio: I LIVED BITCH

    '' Alterna el estado de cambios y activa/desactiva la deteccion de cambios
    Private Sub AlternarCambioHandlers()
        '' cambio = True    -> Se aniadiran los handlers, se los necesita
        '' cambio = False   -> Se ha detectado un cambio, y los handlers se removeran hasta la siguiente llamada del metodo
        If cambio Then
            AddHandler dtpFecha.ValueChanged, AddressOf dtpFecha_ValueChanged
            AddHandler txtNombre.ModifiedChanged, AddressOf txtNombre_ModifiedChanged
        Else
            RemoveHandler dtpFecha.ValueChanged, AddressOf dtpFecha_ValueChanged
            RemoveHandler txtNombre.ModifiedChanged, AddressOf txtNombre_ModifiedChanged
        End If
        cambio = Not cambio
    End Sub
End Class
