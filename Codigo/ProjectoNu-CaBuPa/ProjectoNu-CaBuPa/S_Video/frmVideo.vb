Public Class frmVideo
    Dim videoID As Integer
    Dim editando As Boolean = False
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

        ModLog.Guardar(datosI.Length)
        datos = datosI

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
        serieID = If(datosI(2) = "", 0, datosI(2))
        dtV = DevolverTabla(PSQL("id_serie, nombre", "Serie", "True"))
        LlenarCombo(cbSerie, dtV, "nombre")
        If (Not IsNothing(dtV)) Then
            ExtraerDatos()
        End If
        cbSerie.SelectedIndex = pos
    End Sub

    Public Sub ExtraerDatos()
        ReDim position(dtV.Rows.Count)
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
        If editando Then
            ActualizarDatos()
            If Not CompararValores(datos, datosI) Then
                PrepararUpdate("video", datos, videoID)
                datosI = datos
            End If
        End If
        Alternar()
    End Sub

    Private Sub Alternar()
        txtNombre.ReadOnly = editando
        txtContenido.ReadOnly = editando
        editando = Not editando
        cbSerie.Enabled = editando
        dtpFecha.Enabled = editando

        btnEditar.Text = If(editando, "Guardar", "Editar")
        btnSalir.Text = If(editando, "Cancelar", "Salir")

        chbTieneFecha.Visible = editando

        If editando Then
            txtTapar.Visible = False

            ' FIXED: Ahora sirve
            If datosI(3) <> "" Then
                chbTieneFecha.Checked = True
            End If
        Else
            If datosI(3) = "" Then
                txtTapar.Visible = True
                chbTieneFecha.Visible = False
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Not editando Then
            Close()
        Else
            Rellenar()
            Alternar()
        End If
    End Sub

    Private Sub frmVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buscar()
        dtpFecha.BackColor = Color.FromArgb(64, 64, 64)
        dtpFecha.ForeColor = Color.White
    End Sub

    Private Sub frmVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If editando Then
            ActualizarDatos()
            If Not CompararValores(datos, datosI) Then
                Dim g As New frmGuardarEdicion("Video", datos, videoID, Me)
                g.ShowDialog()

                Alternar()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ActualizarDatos()
        datos = {txtContenido.Text, txtNombre.Text, If(cbSerie.SelectedIndex = 0, "null", position(cbSerie.SelectedIndex - 1)), If(chbTieneFecha.Checked, Format(dtpFecha.Value, "yyyy-MM-dd"), "null")}
    End Sub
End Class