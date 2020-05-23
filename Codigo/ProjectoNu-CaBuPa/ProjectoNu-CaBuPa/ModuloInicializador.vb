Module ModuloInicializador
    Public Sub Main()
        ' Abre el formulario para el ingreso 
        frmLUsuario.ShowDialog()
        MsgBox(" Bienvenido  ", vbInformation, " Ingreso Correcto ")
        ' Abre el formulario principal del programa  
        frmPrincipal.Show()
    End Sub
End Module
