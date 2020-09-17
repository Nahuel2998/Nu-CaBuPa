' El modulo trabaja como union y acceso entre los formularios
Module ModInicializador
    Public Cancelar As Boolean = False
    Public frmPrin As frmPrincipal
    Public Sub Configuracion()
        Dim frmConfig As New frmConfiguracion
        ' Muestra el formulario de configuracion
        frmConfig.ShowDialog()
    End Sub
    Public Sub Generadores()
        Dim Gen As New Generador_DB
        ' Muestra el formulario de configuracion
        Gen.ShowDialog()
    End Sub
    Public Sub Principal()
        frmPrin = New frmPrincipal
        ' Muestra el formulario de configuracion
        frmPrin.Show()
    End Sub
End Module
