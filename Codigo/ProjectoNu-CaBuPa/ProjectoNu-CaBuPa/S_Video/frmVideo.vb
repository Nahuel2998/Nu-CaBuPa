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
    Dim pos As UInt16 = 0

    Public Sub New(ByVal vid As Integer)

        InitializeComponent()
        videoID = vid
    End Sub
    Private Sub Rellenar()
        Dim columnas() As String = {"Nombre", "DATE_FORMAT(Fecha,'%d/%m/%Y') as Fecha", "contenido", "id_serie"}
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
            cbSerie.Items.Add("Ninguna")
            cbSerie.DataSource = dtV
            cbSerie.ValueMember = "nombre"
            ExtraerDatos()
            If (pos <> 0) Then
                cbSerie.SelectedIndex = pos
            End If

        End If
        txtNombre.ForeColor = Color.White
        txtContenido.ForeColor = Color.White
        cbSerie.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Public Sub ExtraerDatos()
        ReDim position(dtV.Rows.Count)
        For j As Integer = 0 To dtV.Rows.Count - 1
            position(j) = dtV.Rows(j).Item(0).ToString
        Next
        For i As Integer = 0 To position.Length - 1
            If (videoID = position(i)) Then
                pos = i
                Exit For
            End If
        Next
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If editando Then
            If cambio Then
                Dim datos() As String = {txtContenido.Text, txtNombre.Text, If(pos = 0, "null", pos), Format(dtpFecha.Value, "yyyy-MM-dd"), txtNombre.Text}
                PrepararUpdate("video", datos, videoID)

                cambio = False
            End If
        Else
            tmpContenido = txtContenido.Text
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
        dtpFecha.BackColor = Color.FromArgb(64, 64, 64)
        dtpFecha.ForeColor = Color.White

    End Sub
End Class