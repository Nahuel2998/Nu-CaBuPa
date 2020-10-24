Public Class frmConfirmarBorrado
    Dim tabla As Byte
    Dim id() As String
    Dim Rid() As String
    Dim c As Boolean = False
    Public Sub New(ByVal t As Byte, ByVal identificador() As String, ByVal Cerrar As Boolean, Optional ByVal Eid() As String = Nothing)
        InitializeComponent()
        tabla = t
        id = identificador
        Rid = Eid
        c = Cerrar
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Select Case tabla
            Case SERIE
                PrepararDelete("video", "id_serie", id)
                PrepararDelete("Serie", "id_serie", id)
            Case PUBLICIDAD
                PrepararDelete("publicidad", "id_publicidad", id)
                PrepararDelete("eventomuestrapubli", "id_publicidad", id)
                PrepararDelete("publicidadcuota", "id_publicidad", id)
                PrepararDelete("aparecepubli", "id_publicidad", id)
                PrepararDelete("pmustrapubli", "id_publicidad", id)
            Case VIDEO
                PrepararDelete("Video", "id_video", id)
            Case EMPRESA
                PrepararDelete("Empresa", "id_empresa", id)
            Case PROGRAMAS
                PrepararDelete("Programa", "ID_Programa", id)
            Case FECHAPROGRAMA
                BSQL("Fechaprograma", CreadorCondicion("fecha", id) + " and " + CreadorCondicion("Hora_inicio", Rid))
        End Select
        If (c) Then
            Owner.Close()
        End If
        Close()
    End Sub

    Private Sub BtnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarSerie.Click
        PrepararUpdate("video", {"id_serie"}, {"null"}, {"id_serie"}, id)
        PrepararDelete("Serie", "id_serie", id)
        If (Not IsNothing(dt_Video)) Then
            frmPrin.btnlimpiarv.PerformClick()
        End If
        If (c) Then
            Owner.Close()
        End If
        Close()
    End Sub

    Private Sub frmConfirmarBorrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (tabla = "Serie") Then
            btnBorrarSerie.Visible = True
        End If
    End Sub
End Class