Imports System.ComponentModel
Imports System.Drawing.Text

' TODO: Indicador de editar (?)
Public Class frmSerie
    Dim serieID As Integer
    Dim editando As Boolean = False ' Controla si se esta en modo de edicion o no
    Dim tmpNombre As String
    Dim tmpFecha As Date
    Dim cambio As Boolean = False   ' Controla si han habido cambios desde el ultimo modo de edicion

    Public Sub New(ByVal sid As Integer, ByVal nombre As String, ByVal fecha As Date)
        InitializeComponent()

        ' Los siguientes datos se obtienen de la tabla en el elemento padre
        serieID = sid
        txtNombre.Text = nombre
        dtpFecha.Value = fecha
    End Sub
    

    Private Sub btnSEditar_Click(sender As Object, e As EventArgs) Handles btnSEditar.Click
        ' editando = True   -> Se guardaran los cambios
        ' editando = False  -> Se le permitira al usuario escribir en los campos
        If editando Then
            If cambio Then
                Dim datos() As String = {Format(dtpFecha.Value, "yyyy-MM-dd"), txtNombre.Text}
                PrepararUpdate("Serie", datos, serieID)

                cambio = False
            End If
        Else
            tmpFecha = dtpFecha.Value
            tmpNombre = txtNombre.Text
        End If

        Alternar()
    End Sub

    Private Sub btnSSalir_Click(sender As Object, e As EventArgs) Handles btnSSalir.Click
        If Not editando Then
            Close()
        Else
            txtNombre.Text = tmpNombre
            dtpFecha.Value = tmpFecha

            cambio = False

            Alternar()
        End If
    End Sub

    Private Sub Serie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambio Then
            Dim datos() As String = {Format(dtpFecha.Value, "yyyy-MM-dd"), txtNombre.Text}
            Dim g As New frmGuardarEdicion("Serie", datos, serieID, Me)
            g.ShowDialog()
            e.Cancel = True

            cambio = False
        End If
    End Sub

    ' Alternar botones
    Private Sub Alternar()
        If editando Then
            btnSEditar.Text = "Editar"
            btnSSalir.Text = "Salir"
            ActiveForm.Text = "Ver Serie"
        Else
            btnSSalir.Text = "Cancelar"
            btnSEditar.Text = "Guardar"
            ActiveForm.Text = "Editar Serie"
        End If
        editando = Not editando

        txtNombre.ReadOnly = Not editando
        dtpFecha.Enabled = editando
    End Sub

    ' Checkea si hay cambios hechos
    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        cambio = True
    End Sub
    Private Sub txtNombre_ModifiedChanged(sender As Object, e As EventArgs) Handles txtNombre.ModifiedChanged
        If txtNombre.Modified Then
            cambio = True
        End If
    End Sub

End Class