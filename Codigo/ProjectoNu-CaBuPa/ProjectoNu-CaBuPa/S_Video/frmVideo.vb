Public Class frmVideo
    Dim videoID As Integer
    Private editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Dim dtV As DataTable
    Dim position() As String
    Dim pos As UInt16 = 0
    Dim serieID As String = ""

    Public Sub New(ByVal vid As Integer)
        InitializeComponent()
        videoID = vid
    End Sub
    Public Sub Buscar()
        Dim columnas() As String = {"contenido", "Nombre", "id_serie", "DATE_FORMAT(Fecha,'%Y-%m-%d') as Fecha"}
        datosI = BuscarDatos("video", columnas, "id_video", videoID)
        Rellenar()
    End Sub

    Private Sub Rellenar()
        txtNombre.Text = datosI(1)
        If datosI(3) <> "" Then
            dtpFecha.Value = CDate(datosI(3))
        Else
            txtTapar.Visible = True
        End If
        txtContenido.Text = datosI(0)
        If (datosI(2) = "") Then
            serieID = 0
        Else
            serieID = datosI(2)
            If (datosI(2) = 0) Then
                datosI(2) = ""
            End If
        End If
        CargarCombo()
    End Sub
    Sub CargarCombo()
        dtV = DevolverTabla(PSQL("id_serie, nombre", "Serie", "True"))
        LlenarCombo(cbSerie, dtV, "nombre")
        If Not IsNothing(dtV) Then
            ExtraerDatos()
        End If
        cbSerie.SelectedIndex = pos
    End Sub

    Public Sub ExtraerDatos()
        ReDim position(dtV.Rows.Count - 1)
        For j As Integer = 0 To dtV.Rows.Count - 1
            position(j) = dtV.Rows(j).Item(0).ToString
        Next
        For i As Integer = 0 To position.Length - 1
            If serieID = position(i) Then
                pos = i + 1
                Exit For
            End If
        Next
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If videoID = -1 Then
            ActualizarDatos()
            PrepararInsert("video", datos)
            Vaciar()
        ElseIf editando Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                PrepararUpdate("video", datos, videoID)
                datosI = VaciarNull(datos)
            End If
            Alternar()
        Else
            Alternar()
        End If
    End Sub
    Sub Activar()
        txtNombre.ReadOnly = editando
        txtContenido.ReadOnly = editando
        editando = Not editando
        cbSerie.Enabled = editando
        dtpFecha.Enabled = editando
        chbTieneFecha.Visible = editando
    End Sub
    Private Sub Alternar()
        Activar()
        btnEditar.Text = If(editando, "Guardar", "Editar")
        btnSalir.Text = If(editando, "Cancelar", "Salir")
        chbTieneFecha.Checked = datosI(3) <> ""
            If editando Then
            txtTapar.Visible = False
        Else
            If datosI(3) = "" Then
                txtTapar.Visible = True
                chbTieneFecha.Visible = False
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Not editando Or videoID = -1 Then
            Close()
        Else
            Rellenar()
            Alternar()
        End If
    End Sub

    Private Sub frmVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If videoID <> -1 Then
            Buscar()
            btnSalir.Select()
        Else
            btnEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
            CargarCombo()
        End If
        dtpFecha.BackColor = Color.FromArgb(64, 64, 64)
        dtpFecha.ForeColor = Color.White
        btnSalir.Select()
    End Sub
    Sub Vaciar()
        txtNombre.Clear()
        txtContenido.Clear()
        cbSerie.SelectedIndex = -1
        dtpFecha.Value = Now.Date
        chbTieneFecha.Checked = False
    End Sub

    Private Sub frmVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If editando And videoID <> -1 Then
            ActualizarDatos()
            If Not CompararValores(VaciarNull(datos), datosI) Then
                Dim g As New frmGuardarEdicion("Video", datos, videoID)
                g.ShowDialog()
                If ModInicializador.Cancelar.Contains("Video") Then
                    e.Cancel = True
                    ModInicializador.Cancelar = ModInicializador.Cancelar.Replace("Video", "")

                    ' ModInicializador.frmPrin.btnbuscarv.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub ActualizarDatos()
        Dim con As String = txtContenido.Text
        Dim nom As String = txtNombre.Text
        Dim dat As String = If(chbTieneFecha.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null")
        Dim ser As String = If(cbSerie.SelectedIndex <= 0, "null", position(cbSerie.SelectedIndex - 1))
        datos = {con, nom, ser, dat}
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim formDelete As New frmConfirmarBorrado(VIDEO, {videoID}, True)
        formDelete.ShowDialog(Me)
    End Sub

End Class