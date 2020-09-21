Public Class frmConfirmarBorrado
    Dim tabla As String
    Dim id As String
    Public Sub New(ByVal t As String, ByVal identificador As String)
        InitializeComponent()
        tabla = t
        id = identificador
        Beep()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Select Case tabla
            Case "Serie"
                PrepararDelete("video", {"id_serie"}, {id})
                PrepararDelete("Serie", {"id_serie"}, {id})
            Case "Video"
                PrepararDelete("Video", {"id_video"}, {id})
        End Select
        Owner.Close()
        Close()
    End Sub

    Private Sub BtnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarSerie.Click
        PrepararUpdate("video", {"id_serie"}, {"null"}, {"id_serie"}, {id})
        PrepararDelete("Serie", {"id_serie"}, {id})
        If (Not IsNothing(dt_Video)) Then
            frmPrin.btnlimpiarv.PerformClick()
        End If
        Owner.Close()
        Close()
    End Sub

    Private Sub frmConfirmarBorrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (tabla = "Serie") Then
            btnBorrarSerie.Visible = True
        End If
    End Sub
End Class