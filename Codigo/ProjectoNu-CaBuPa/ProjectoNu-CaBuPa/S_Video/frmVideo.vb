Public Class frmVideo
    Dim videoID As Integer
    Dim editando As Boolean = False
    Dim tmpNombre As String
    Dim tmpFecha As Date
    Dim tmpSerie As String
    Dim tmpContenido As String
    Dim dtV As DataTable
    Dim cambio As Boolean = False
    Dim position() As String
    Dim pos As UInt16

    Public Sub New(ByVal vid As Integer)

        InitializeComponent()
        videoID = vid
    End Sub
    Private Sub Rellenar()
        Dim columnas() As String = {"Nombre", "DATE_FORMAT(Fecha,'%d/%m/%Y') as Fecha", "Contenido", "id_serie"}
        Dim datosI() As String = BuscarDatos("video", columnas, "id_video", videoID)
        txtNombre.Text = datosI(0)
        If (datosI(1) <> "") Then
            dtpFecha.Value = CDate(datosI(1))
        Else
            txtTapar.Visible = True
        End If

        txtContenido.Text = datosI(2)
        dtV = DevolverTabla(PSQL("id_serie, nombre", "Serie", "True"))
        If (Not IsNothing(dtV)) Then
            cbSerie.DataSource = dtV
            cbSerie.ValueMember = "nombre"
            ExtraerDatos()
            cbSerie.SelectedIndex = pos
        End If
        ''tmpNombre = datosI(0)
        ''tmpFecha = datosI(1)
        ''tmpContenido = datosI(2)
    End Sub
    Public Sub ExtraerDatos()
        For j As Integer = 0 To dtV.Rows.Count
            position(j) = dtV.Rows(1).Item(j).ToString
        Next
        For i As Integer = 0 To position.Length
            If (videoID = position(i)) Then
                pos = i
                Exit For
            End If
        Next
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If editando Then
            If cambio Then
                Dim datos() As String = {Format(dtpFecha.Value, "yyyy-MM-dd"), txtNombre.Text}
                PrepararUpdate("video", datos, videoID)

                cambio = False
            End If
        Else
            tmpFecha = dtpFecha.Value
            tmpNombre = txtNombre.Text
        End If

        Alternar()
    End Sub
    Private Sub Alternar()
        editando = Not editando
        txtNombre.Enabled = editando
        txtContenido.Enabled = editando
        cbSerie.Enabled = editando
        dtpFecha.Enabled = editando
        If (editando) Then
            btnEditar.Text = "Guardar"
        Else
            btnEditar.Text = "Editar"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub frmVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rellenar()
    End Sub
End Class