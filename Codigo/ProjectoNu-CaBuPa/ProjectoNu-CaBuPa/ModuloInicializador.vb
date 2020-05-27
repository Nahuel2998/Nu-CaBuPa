' El modulo trabaja como union y acceso entre los formularios
Module ModuloInicializador
    Public Sub Configuracion()
        Dim frmConfig As New frmConfiguracion
        ' Muestra el formulario de configuracion
        frmConfig.ShowDialog()
    End Sub
    Public Sub Principal()
        Dim frmPrin As New frmPrincipal
        ' Muestra el formulario de configuracion
        frmPrin.ShowDialog()
    End Sub
End Module
