Imports System.ComponentModel

Public Class frmPrograma
    Dim programaID As Integer
    Public editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String

    Public Sub New(ByVal pid As Integer)
        InitializeComponent()
        programaID = pid
    End Sub

    Public Sub Buscar()
        Dim columnas() As String = {"Nombre_Programa", "Descripcion", "Fecha_Finalizacion", "DATE_FORMAT(Fecha,'%Y-%m-%d') as Fecha"}
        datosI = BuscarDatos("programa", columnas, "id_programa", programaID)
    End Sub

    Private Sub Rellenar()
        txtNombre.Text = datosI(0)
        If datosI(2) <> "" Then
            dtpFecha.Value = CDate(datosI(2))
        Else
            txtTapar.Visible = True
        End If
        txtDescripcion.Text = datosI(1)
    End Sub

    Private Sub frmPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bwDatos.RunWorkerAsync()
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDatos.DoWork
        Buscar()
    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        Rellenar()
    End Sub
End Class