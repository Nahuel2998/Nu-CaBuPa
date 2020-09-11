Public Class Video
    Private Edit As Boolean = False
    Public id_Video As Integer = 0
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Edit = Not Edit
        tbVideo.Enabled = Edit
        tbContenido.Enabled = Edit
        cbSerie.Enabled = Edit
        dtpFecha.Enabled = Edit
        If (Edit) Then
            btnEditar.Text = "Guardar"
        Else
            btnEditar.Text = "Editar"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class