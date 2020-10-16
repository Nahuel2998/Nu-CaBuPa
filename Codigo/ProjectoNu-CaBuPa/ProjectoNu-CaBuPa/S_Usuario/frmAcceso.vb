Public Class frmAcceso
    Private UID As Integer = 0
    Public Sub New(Optional ByVal Uid As Integer = 1)
        InitializeComponent()
        Me.UID = Uid
    End Sub
    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPermisosAll(UID)
        CheckearPermisos()
        EstablecerList(cblP)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargaActualizacionP(cblP)
        CompararPermisos(cblP)
    End Sub
End Class