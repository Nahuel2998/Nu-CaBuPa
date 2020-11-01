Imports System.ComponentModel

Public Class frmEvento
    Private eventoID As Integer
    Private editando As Boolean = False
    Private datos() As String
    Private datosI() As String
    Private dtE As DataTable
    Private dt_fechas As DataTable
    Private position() As String
    Private pos As UInt16 = 0
    Private videoID As String = ""
    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        eventoID = id
    End Sub
    Public Sub Buscar()
        Dim columnas() As String = {"Nombre", "Descripcion", "id_video"}
        datosI = BuscarDatos("evento", columnas, "id_evento", eventoID)
        Rellenar()
    End Sub

    Private Sub frmEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If eventoID <> -1 Then
            Buscar()
            btnSalir.Select()
        Else
            tcP.TabPages.RemoveByKey("tbFechas")
            btnEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
            CargarCombo()
        End If
        btnSalir.Select()
    End Sub
    Private Sub Rellenar()
        txtNombre.Text = datosI(0)
        txtDescripcion.Text = datosI(1)
        If (datosI(2) = "") Then
            videoID = 0
        Else
            videoID = datosI(2)
            If (datosI(2) = 0) Then
                datosI(2) = ""
            End If
        End If
        CargarCombo()
    End Sub
    Sub CargarCombo()
        dtE = DevolverTabla(PSQL("id_video, Nombre", "video", "True"))
        LlenarCombo(cbVideo, dtE, "Nombre")
        If Not IsNothing(dtE) Then
            ExtraerDatos()
        End If
        cbVideo.SelectedIndex = pos
    End Sub

    Public Sub ExtraerDatos()
        ReDim position(dtE.Rows.Count - 1)
        For j As Integer = 0 To dtE.Rows.Count - 1
            position(j) = dtE.Rows(j).Item(0).ToString
        Next
        For i As Integer = 0 To position.Length - 1
            If videoID = position(i) Then
                pos = i + 1
                Exit For
            End If
        Next
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Not editando Or videoID = -1 Then
            Close()
        Else
            Rellenar()
            Alternar()
        End If
    End Sub
    Private Sub ActualizarDatos()
        Dim des As String = txtDescripcion.Text
        Dim nom As String = txtNombre.Text
        Dim vid As String = If(cbVideo.SelectedIndex <= 0, "null", position(cbVideo.SelectedIndex - 1))
        datos = {nom, des, vid}
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(EVENTO, {eventoID}, True)
        formDelete.ShowDialog(Me)
    End Sub
    Sub Activar()
        txtNombre.ReadOnly = editando
        txtDescripcion.ReadOnly = editando
        editando = Not editando
        cbVideo.Enabled = editando
    End Sub
    Private Sub Alternar()
        Activar()
        btnEditar.Text = If(editando, "Guardar", "Editar")
        btnSalir.Text = If(editando, "Cancelar", "Salir")
    End Sub
    Sub Vaciar()
        txtNombre.Clear()
        txtDescripcion.Clear()
        cbVideo.SelectedIndex = -1
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If eventoID = -1 Then
            ActualizarDatos()
            PrepararInsert("evento", datos)
            Vaciar()
        ElseIf editando Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                PrepararUpdate("evento", datos, eventoID)
                datosI = VaciarNull(datos)
            End If
            Alternar()
        Else
            Alternar()
        End If
    End Sub

    Private Sub frmEvento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If editando And eventoID <> -1 Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                Dim g As New frmGuardarEdicion("Evento", datos, videoID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Evento") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Evento", "")

                    ' ModInicializador.frmPrin.btnbuscarv.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click

        Dim datosN() As String
        For i As Byte = mcFecha.SelectionStart.Day To mcFecha.SelectionEnd.Day
            datosN = {eventoID, String.Format(Format(mcFecha.SelectionStart, "yyyy-MM") + "-{0}", i)}
            PrepararInsert("fechaevento", datosN, 0)
        Next
        bwFechas.RunWorkerAsync()
    End Sub

    Private Sub btnABorrar_Click(sender As Object, e As EventArgs) Handles btnABorrar.Click
        If Not IsNothing(dt_fechas) Then
            If (dt_fechas.Rows.Count > 0) Then
                Dim Id() As String = ObtenerCheck(dt_fechas, dgvFechas, 0)
                If Not Id.Length = 0 Then
                    BSQL("fechaevento", String.Format("id_evento='{0}'", eventoID) + " and " + CreadorCondicion("fecha", Id, True))
                    If Not (bwFechas.IsBusy) Then
                        bwFechas.RunWorkerAsync()
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub dgvPrograma_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFechas.CellClick
        ClickCheck(sender, e.ColumnIndex)
    End Sub

    Private Sub tcP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcP.SelectedIndexChanged
        If (tcP.SelectedIndex = 1) Then
            bwFechas.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwFechas_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwFechas.DoWork
        Dim Columna As String = "Fecha"
        Dim fecha As String = "year(fecha) = year('{1}')"
        Dim Condicion As String = String.Format("id_evento = {0} and " + fecha, eventoID, Format(dtpYearE.Value, "yyyy-MM-dd"))
        Dim Tablas As String = "fechaevento"
        dt_fechas = DevolverTabla(PSQL(Columna, Tablas, Condicion))
    End Sub

    Private Sub bwFechas_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwFechas.RunWorkerCompleted
        ActualizarTablaC(dt_fechas, dgvFechas, False)
    End Sub
End Class