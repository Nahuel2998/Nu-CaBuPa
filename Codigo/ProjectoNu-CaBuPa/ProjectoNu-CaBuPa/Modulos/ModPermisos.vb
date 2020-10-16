Module ModPermisos
    Public Permisos As DataTable
    Public PermisosT As DataTable
    Public Tiene As Boolean()
    Public Sub CargarPermiso(ByVal UID As Integer)
        Permisos = DevolverTabla(PSQL("a.*", "acceso a inner join ustieneacceso u on a.id_acceso = u.id_acceso", "id_usuario = " + UID.ToString))
    End Sub
    Public Sub CargarPermisoT()
        PermisosT = DevolverTabla(PSQL("*", "acceso", "true"))
        ReDim Tiene(PermisosT.Rows.Count - 1)
    End Sub
    Public Sub CargarPermisosAll(ByVal UID As Integer)
        CargarPermisoT()
        CargarPermiso(UID)
    End Sub
    Public Sub CheckearPermisos()
        Dim e As Integer = 0
        For i As Integer = 0 To Tiene.Length - 1
            Tiene(i) = False
        Next
        If (Not IsNothing(Permisos)) Then

            For a As Integer = 0 To Permisos.Rows.Count - 1
                For i As Integer = e To PermisosT.Rows.Count - 1
                    If (Permisos.Rows(a).Item(0) = Permisos.Rows(i).Item(0)) Then
                        Tiene(e) = True
                        e = i + 1
                        Exit For
                    End If
                Next
            Next

        End If

    End Sub
    Public Sub EstablecerList(ByRef che As CheckedListBox)
        che.Items.Clear()
        If (Not IsNothing(PermisosT)) Then

            For i As Integer = 0 To Tiene.Length - 1
                che.Items.Add(PermisosT.Rows(i).Item(1), Tiene(i))
            Next
        End If
    End Sub
    Public Function Comparar(ByVal Seccion As String, Optional tipo As String = "") As Boolean
        For i As Integer = 0 To Permisos.Rows.Count - 1
            If (Permisos.Rows(i).Item(1) = Seccion) Then
                If (tipo <> "") Then
                    If (Permisos.Rows(i).Item(2) = tipo) Then
                        Return True
                    End If
                End If
            End If
        Next
        Return False
    End Function
End Module
