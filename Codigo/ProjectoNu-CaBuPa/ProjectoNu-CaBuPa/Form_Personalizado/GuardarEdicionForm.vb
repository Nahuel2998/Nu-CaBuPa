Public Class GuardarEdicionForm
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnNoGuardar_Click(sender As Object, e As EventArgs) Handles btnNoGuardar.Click
        ParentForm.Dispose()
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'GuardarCambios
        Close()
    End Sub
End Class