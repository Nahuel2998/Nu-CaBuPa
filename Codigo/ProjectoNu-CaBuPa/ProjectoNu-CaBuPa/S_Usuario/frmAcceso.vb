Public Class frmAcceso
    Private UID As Integer = 0
    Public Sub New(ByVal Uid As Integer)
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

    End Sub
End Class