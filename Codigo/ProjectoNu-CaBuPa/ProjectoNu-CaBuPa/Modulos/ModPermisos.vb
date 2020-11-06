Module ModPermisos
    Public Permisos As DataTable = Nothing
    Public PermisosT As DataTable = Nothing
    Public TieneP As Boolean()
    Public ActualizaP As Boolean()
    Private EliminarP As String = ""
    Private AgregarP As String = ""
    Private USid As Integer = Nothing
#Region "usuario"
    Public Sub Esid(ByVal EUsid As Integer)
        USid = EUsid
    End Sub
#End Region
#Region "Cargadores"
    Public Sub CargaActualizacionP(ByVal che As CheckedListBox)
        ReDim ActualizaP(TieneP.Length - 1)
        For i As Integer = 0 To TieneP.Length - 1
            ActualizaP(i) = False
        Next
        For i As Integer = 0 To che.CheckedItems.Count - 1
            ActualizaP(che.CheckedIndices(i)) = True
        Next
    End Sub
    Public Sub CompararPermisos(ByRef che As CheckedListBox)
        For i As Integer = 0 To TieneP.Length - 1
            If (TieneP(i) <> ActualizaP(i)) Then
                If (TieneP(i) = False) Then
                    AgregarP += String.Format("('{0}','{1}'),", USid, PermisosT.Rows(i).Item(0).ToString)
                Else
                    EliminarP += String.Format("'{0}',", PermisosT.Rows(i).Item(0).ToString)
                End If
            End If
        Next
        If (AgregarP <> "") Then
            AgregarP = AgregarP.Remove(AgregarP.Length - 1)
            ISQL("ustieneacceso", "id_usuario, id_acceso", AgregarP, False)
        End If
        If (EliminarP <> "") Then
            EliminarP = EliminarP.Remove(EliminarP.Length - 1)
            Dim con As String = String.Format("id_acceso in ({0}) and id_usuario = '{1}'", EliminarP, USid)
            BSQL("ustieneacceso", con)
        End If
        CargarPermisosAll(USid)
        CheckearPermisos()
        EstablecerList(che)
        AgregarP = ""
        EliminarP = ""
    End Sub
    Public Sub CargarPermiso(ByVal UID As Integer)
        Permisos = DevolverTabla(PSQL("a.*", "acceso a inner join ustieneacceso u on a.id_acceso = u.id_acceso", "id_usuario = " + UID.ToString + " order by id_acceso"))
    End Sub
    Public Sub CargarPermiso()
        Permisos = DevolverTabla(PSQL("a.*", "acceso a inner join ustieneacceso u on a.id_acceso = u.id_acceso", "id_usuario = " + USid.ToString + " order by id_acceso"))
    End Sub
    Public Sub CargarPermisoT()
        PermisosT = DevolverTabla(PSQL("*", "acceso", "true order by id_acceso"))
        ReDim TieneP(PermisosT.Rows.Count - 1)
    End Sub
    Public Sub EstablecerAll(ByRef che As CheckedListBox)
        If (TieneP.Length > 0) Then
            Dim sec As Boolean
            sec = Not che.CheckedIndices().Contains(0)
            For i As Integer = 0 To TieneP.Length - 1
                TieneP(i) = sec
            Next
            EstablecerList(che)
            CheckearPermisos()
        End If
    End Sub
    Public Sub CargarPermisosAll(ByVal UID As Integer)
        USid = UID
        CargarPermisoT()
        CargarPermiso()
    End Sub
    Public Sub CheckearPermisos()
        For i As Integer = 0 To TieneP.Length - 1
            TieneP(i) = False
        Next
        If (Not IsNothing(Permisos)) Then
            Dim e As Integer = 0
            For a As Integer = 0 To PermisosT.Rows.Count - 1
                For i As Integer = e To Permisos.Rows.Count - 1
                    If (PermisosT.Rows(a).Item(0) = Permisos.Rows(i).Item(0)) Then
                        TieneP(a) = True
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
            For i As Integer = 0 To TieneP.Length - 1
                che.Items.Add(String.Format("Sector: {0}. Acceso: {1}", PermisosT.Rows(i).Item(1), PermisosT.Rows(i).Item(2)), TieneP(i))
            Next
        End If
    End Sub
#End Region
    Public Function PoseePermiso(ByVal Seccion As String, Optional tipo As String = "") As Boolean
        If Not IsNothing(Permisos) Then
            For i As Integer = 0 To Permisos.Rows.Count - 1
                If (Permisos.Rows(i).Item(1) = Seccion) Then
                    If (tipo <> "") Then
                        ModLog.Guardar(Permisos.Rows(i).Item(2))
                        If (Permisos.Rows(i).Item(2).ToString.Contains(tipo)) Then
                            Return True
                        End If
                    Else
                        Return True
                    End If
                End If
            Next
        End If
        Return False 'FIXME: Cambiar a False
    End Function
End Module
