Imports System.ComponentModel

Public Class frmPublicidad
    Dim publicidadID As Integer
    Public editando As Boolean = False
    Dim datos() As String
    Dim datosI() As String
    Private TBusca As DataTable
    Private dt_fechas As DataTable
    Dim position() As String
    Dim pos As UInt16 = 0
    Dim empresaID As Integer = 0
    Public Sub New(ByVal pid As Integer)
        InitializeComponent()
        publicidadID = pid
    End Sub
    Public Sub Buscar()
        Dim columnas() As String = {"Nombre", "Tema", "id_empresa"}
        datosI = BuscarDatos("publicidad", columnas, "id_publicidad", publicidadID)
    End Sub

    Private Sub Rellenar()
        txtNombre.Text = datosI(0)
        txtTema.Text = datosI(1)
        empresaID = datosI(2)
        CargarCombo()
    End Sub
    Sub CargarCombo()
        dt_Empresa = DevolverTabla(PSQL("id_Empresa, Nombre, Telefono, Mail", "Empresa", "True"))
        LlenarCombo(cbEmpresa, dt_Empresa, "Nombre")
        If Not IsNothing(dt_Empresa) Then
            ExtraerDatos()
        End If
        cbEmpresa.SelectedIndex = pos
    End Sub
    Public Sub ExtraerDatos()
        ReDim position(dt_Empresa.Rows.Count - 1)
        For j As Integer = 0 To dt_Empresa.Rows.Count - 1
            position(j) = dt_Empresa.Rows(j).Item(0).ToString
        Next
        For i As Integer = 0 To position.Length - 1
            If empresaID = position(i) Then
                pos = i + 1
                Exit For
            End If
        Next
    End Sub


    Private Sub frmPublicidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If publicidadID <> -1 Then
            bwDatos.RunWorkerAsync()
        Else
            tcP.TabPages.RemoveAt(1)
            btnEditar.Text = "Insertar"
            btnBorrar.Visible = False
            Activar()
        End If
        btnSalir.Select()
    End Sub
    Sub Activar()
        txtNombre.ReadOnly = editando
        txtTema.ReadOnly = editando
        editando = Not editando
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwDatos.DoWork
        Buscar()
    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        Rellenar()
    End Sub
End Class