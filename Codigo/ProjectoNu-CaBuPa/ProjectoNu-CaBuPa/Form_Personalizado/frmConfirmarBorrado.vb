Public Class frmConfirmarBorrado
    Dim tabla As Byte
    Dim id() As String
    Dim id2() As String
    Dim id3() As String
    Dim id4() As String
    Dim c As Boolean = False
    Public Sub New(ByVal t As Byte, ByVal identificador() As String, ByVal Cerrar As Boolean, Optional ByVal Eid() As String = Nothing, Optional ByVal Fid() As String = Nothing, Optional ByVal Gid() As String = Nothing)
        InitializeComponent()
        tabla = t
        id = identificador
        id2 = Eid
        id3 = Fid
        id4 = Gid
        c = Cerrar
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Select Case tabla
            Case SERIE
                PrepararDelete("video", "id_serie", id)
                USQL("evento", "id_video=null", String.Format("id_video='{0}'", id))
                PrepararDelete("Serie", "id_serie", id)
            Case PUBLICIDAD
                PrepararDelete("publicidad", "id_publicidad", id)
                PrepararDelete("eventomuestrapubli", "id_publicidad", id)
                PrepararDelete("publicidadcuota", "id_publicidad", id)
                PrepararDelete("aparecepubli", "id_publicidad", id)
                PrepararDelete("pmustrapubli", "id_publicidad", id)
            Case VIDEO
                PrepararDelete("Video", "id_video", id)
                USQL("evento", "id_video=null", String.Format("id_video='{0}'", id))
            Case FUNTRABAJA
                BSQL("funtrabaja", String.Format("id_programa='{0}'", id(0)) + " and " + CreadorCondicion("ID_TrabajaComo", id2) + " and " + CreadorCondicion("fecha_inicio", id3, True))
            Case EMPRESA
                PrepararDelete("Empresa", "id_empresa", id)
                USQL("publicidad", "id_empresa=null", String.Format("id_publicidad='{0}'", id))
            Case PROGRAMAS
                PrepararDelete("Programa", "ID_Programa", id)
                PrepararDelete("programacuota", "id_programa", id)
                PrepararDelete("fechaprograma", "id_programa", id)
                PrepararDelete("pmustrapubli", "id_programa", id)
            Case FUNCIONARIO
                PrepararDelete("Funcionario", "ID_Funcionario", id)
                Dim Borrado As DataTable = DevolverTabla(PSQL("id_trabajacomo", "trabajacomo", String.Format("ID_Funcionario='{0}'", id)))
                Dim idTrabaja() As String = CargarTodo(Borrado, 0)
                PrepararDelete("trabajacomo", "ID_Funcionario", id)
                BSQL("funtrabaja", CreadorCondicion("id_trabajacomo", idTrabaja))
            Case FECHAPROGRAMA
                BSQL("Fechaprograma", CreadorCondicion("fecha", id, True) + " and " + CreadorCondicion("Hora_inicio", id2) + "and id_programa='" + id3(0) + "'")
            Case PUBLICIDADPROGRAMA
                BSQL("pmuestrapubli", CreadorCondicion("id_publicidad", id) + " and " + CreadorCondicion("id_programa", id2) + " and " + CreadorCondicion("Fecha_inicio", id3, True))
            Case PUBLICIDADEVENTO
                BSQL("eventomuestrapubli", CreadorCondicion("id_publicidad", id) + " and " + CreadorCondicion("id_evento", id2) + " and " + CreadorCondicion("Fecha_inicio", id3, True))
            Case TANDASHORAS
                BSQL("tanda", CreadorCondicion("Hora_Inicio", id))
            Case CUOTA
                BSQL("programacuota", CreadorCondicion("id_programa_cuota", id))
            Case FUNCION
                Dim Borrado As DataTable = DevolverTabla(PSQL("id_trabajacomo", "trabajacomo", String.Format("ID_Funcion='{0}'", id)))
                Dim idTrabaja() As String = CargarTodo(Borrado, 0)
                PrepararDelete("Funcion", "ID_Funcion", id)
                PrepararDelete("trabajacomo", "ID_Funcion", id)
                BSQL("funtrabaja", CreadorCondicion("id_trabajacomo", idTrabaja))
            Case CUOTAPUBLICIDAD
                BSQL("publicidadcuota", CreadorCondicion("id_publicidadcuota", id))
            Case EVENTO
                BSQL("evento", CreadorCondicion("id_evento", id))
                BSQL("fechaevento", CreadorCondicion("id_evento", id))
                BSQL("eventomuestrapubli", CreadorCondicion("id_evento", id))
        End Select
        If (c) Then
            Owner.Close()
        End If
        Close()
    End Sub

    Private Sub BtnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarSerie.Click
        PrepararUpdate("video", {"id_serie"}, {"null"}, {"id_serie"}, id)
        PrepararDelete("Serie", "id_serie", id)
        If (Not IsNothing(dt_Video)) Then
            frmPrin.btnlimpiarv.PerformClick()
        End If
        If (c) Then
            Owner.Close()
        End If
        Close()
    End Sub

    Private Sub frmConfirmarBorrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (tabla = SERIE) Then
            btnBorrarSerie.Visible = True
        End If
    End Sub
End Class