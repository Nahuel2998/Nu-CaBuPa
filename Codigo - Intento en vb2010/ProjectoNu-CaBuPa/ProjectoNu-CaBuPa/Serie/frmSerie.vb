﻿' TODO: Indicador de editar e ingresado correctamente.
Imports System.ComponentModel

Public Class frmSerie
    Dim serieID As Integer
    Dim editando As Boolean = False     ' Controla si se esta en modo de edicion o no
    Dim tmpDatos(1) As String
    Dim cambio As Boolean = False       ' Controla si han habido cambios desde el ultimo modo de edicion
    Dim dt_Video As New DataTable
    Dim TBuscada As Byte = 0
    Dim dt_VideoBV As DataTable
    Dim TBusca As DataTable
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

    Private Sub frmSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.BackColor = Color.FromArgb(64, 64, 64)
        dtpFecha.ForeColor = Color.White
        ActualizarTabla()
        If (serieID = -1) Then
            ocultar()
            Alternar()
        End If
        If Not PoseePermiso("Serie", "a") Then
            btnBorrar.Visible = False
            btnSEditar.Visible = False
            ocultar()
        End If
        If Not PoseePermiso("Video", "a") Then
            ocultar()
        End If
    End Sub
    Private Sub ocultar()
        tcS.TabPages.RemoveByKey("tbAV")
    End Sub

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        '' editando = True   -> Se guardaran los cambios
        '' editando = False  -> Se le permitira al usuario escribir en los campos
        If serieID = -1 Then
            Dim datos() As String = {If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null"), txtNombre.Text}
            PrepararInsert("Serie", datos)
            Vaciar()
        ElseIf editando Then
            If cambio Then
                Dim datos() As String = {If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null"), txtNombre.Text}
                If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                    PrepararUpdate("Serie", datos, serieID)
                End If

                AlternarCambioHandlers()
            End If

            Alternar()
        Else
            tmpDatos = {If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), ""), txtNombre.Text}

            Alternar()
        End If
    End Sub
    Private Sub Vaciar()
        txtNombre.Clear()
        dtpFecha.Value = Now.Date
        chbIncluir.Checked = True
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        If Not editando Or serieID = -1 Then
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
        If cambio And serieID <> -1 Then
            Dim datos() As String = {If(chbIncluir.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null"), txtNombre.Text}
            If Not CompararValores(VaciarNull(datos), tmpDatos) Then
                Dim g As New frmGuardarEdicion("Serie", datos, serieID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Serie") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Serie", "")
                Else
                    AlternarCambioHandlers()
                End If
            End If
        End If
    End Sub

    '' Alternar botones
    Private Sub Alternar()
        If serieID = -1 Then
            btnSEditar.Text = "Ingresar"
            btnBorrar.Visible = False
            btnSSalir.Text = "Salir"
            Text = "Ingresar Serie"

            txtTapar.Visible = False
        ElseIf editando Then
            btnSEditar.Text = "Editar"
            btnSSalir.Text = "Salir"
            Text = "Ver Serie"

            txtTapar.Visible = Not chbIncluir.Checked
        Else
            btnSSalir.Text = "Cancelar"
            btnSEditar.Text = "Guardar"
            Text = "Editar Serie"

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
    Private Sub txtNombre_ModifiedChanged(sender As Object, e As EventArgs)
        If txtNombre.Modified Then
            AlternarCambioHandlers()
        End If
    End Sub
    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs)
        AlternarCambioHandlers()
    End Sub
    Private Sub chbIncluir_CheckedChanged(sender As Object, e As EventArgs)
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

    Private Sub dgvVSM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVSM.CellDoubleClick, dgvVideoAs.CellDoubleClick
        Dim i As Integer = CargarID(dt_Video, sender)
        If (i <> -1) Then
            Dim formVideo As New frmVideo(i)
            AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
            formVideo.ShowDialog()
        End If
    End Sub

    Private Sub dgvVSB_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVideoBV.CellDoubleClick
        Dim i As Integer = CargarID(dt_VideoBV, sender)
        If (i <> -1) Then
            Dim formVideo As New frmVideo(i)
            AddHandler formVideo.FormClosed, AddressOf FormVideo_FormClosed
            formVideo.ShowDialog()
        End If
    End Sub

    '' Actualiza la tabla mostrando los videos asociados cuando el formulario de mostrar video se ha cerrado
    Private Sub FormVideo_FormClosed(sender As Object, e As FormClosedEventArgs)
        ActualizarTabla()
    End Sub

    Private Sub ActualizarTabla()
        dt_Video = DevolverTabla(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", String.Format("id_serie = '{0}'", serieID)))
        ActualizarTablaC(dt_Video, dgvVSM)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(SERIE, {serieID}, True)
        formDelete.ShowDialog(Me)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub Buscar()
        TBuscada = VIDEO
        Dim condicion As String = "true"        ' FIXME: Al poner limit 50 no sirve buscar solo por fecha. Asi que lo he quitado por ahora.
        If (Not String.IsNullOrWhiteSpace(txtNombreBV.Text)) Then
            condicion = String.Format("nombre like '%{0}%'", txtNombreBV.Text)
        End If
        If (chkFecha.Checked) Then
            condicion += String.Format(" and fecha = '{0}'", Format(dtpFechaBV.Value, "yyyy-MM-dd").ToString)
        End If
        condicion += " and ID_Serie is null"
        If Not (BWBuscador.IsBusy) Then
            BWBuscador.RunWorkerAsync(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", condicion))
        End If
    End Sub

    Private Sub BWBuscador_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWBuscador.RunWorkerCompleted
        Select Case TBuscada
            Case VIDEO
                dt_VideoBV = TBusca
                ActualizarTablaC(dt_VideoBV, dgvVideoBV)
                TBuscada = SERIE
                BWBuscador.RunWorkerAsync(PSQL("id_video, fecha as Fecha, nombre as Nombre", "video", String.Format("id_serie = '{0}'", serieID)))
            Case SERIE
                dt_Video = TBusca
                ActualizarTablaC(dt_Video, dgvVideoAs)
                TBusca = Nothing
                TBuscada = 0
        End Select
    End Sub

    Private Sub BWBuscador_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWBuscador.DoWork
        TBusca = DevolverTabla(e.Argument)
        ModLog.Guardar("Serie: " & e.Argument)
    End Sub

    Private Sub tcS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcS.SelectedIndexChanged
        If tcS.SelectedIndex = 0 Then
            ActualizarTabla()
        Else tcS.SelectedIndex = 1
            Buscar()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVideoBV.CellClick, dgvVideoAs.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub
    Private Sub dgvHeaderClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVideoBV.ColumnHeaderMouseClick, dgvVideoAs.ColumnHeaderMouseClick
        CheckAll(sender, e.ColumnIndex)
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim Checked() As String = ObtenerCheck(dt_VideoBV, dgvVideoBV)
        If Checked.Length > 0 Then
            PrepararUpdate("Video", {"ID_Serie"}, {serieID.ToString}, "ID_Video", Checked)
            Buscar()
        End If
    End Sub

    Private Sub btnDesasignar_Click(sender As Object, e As EventArgs) Handles btnDesasignar.Click
        Dim Checked() As String = ObtenerCheck(dt_Video, dgvVideoAs)
        If Checked.Length > 0 Then
            PrepararUpdate("Video", {"ID_Serie"}, {"null"}, "ID_Video", Checked)
            Buscar()
        End If
    End Sub
End Class
