' El modulo trabaja como union y acceso entre los formularios
Module ModInicializador
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
        Dim frmPrin As New frmPrincipal
        ' Muestra el formulario de configuracion
        frmPrin.Show()
    End Sub
End Module
