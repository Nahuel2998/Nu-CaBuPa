Imports MySql.Data.MySqlClient
Imports System.Data
Imports MySql.Data
Imports System.Drawing.Text

Module ModConector
    Private Debug As Boolean = True
    Private conn As New MySqlConnection
    Private connStr As String
    Private Address, User, Database, Port, Pass As String
    Private UsuarioID As Integer
    Private Usuario, Password As String
    Private objCmd As New MySqlCommand
    Private ds As New DataSet
    Private dt As New DataTable

#Region "GetDirection"
    Public Function GDT(ByVal Nombre As String) As DataTable
        Return ds.Tables(Nombre)
    End Function
    Public Function GUsuarioID() As Integer
        Return UsuarioID
    End Function
    Public Sub BorrarUsuario()
        Usuario = ""
        Password = ""
        UsuarioID = Nothing
    End Sub
    Public Function GDebug() As Boolean
        Return Debug
    End Function
    Public Function GAddress() As String
        Return Address
    End Function
    Public Function GUser() As String
        Return User
    End Function
    Public Function GDatabase() As String
        Return Database
    End Function
    Public Function GPort() As String
        Return Port
    End Function
    Public Function GPass() As String
        Return Pass
    End Function
#End Region
#Region "Constructor"
    Public Sub Crear(ByVal RAddress As String, ByVal RPort As String, ByVal RDatabase As String, ByVal RUser As String, ByVal RPass As String)
        If Not String.IsNullOrEmpty(RAddress) Then
            Address = RAddress
        Else
            Address = "localhost"
        End If
        If Not String.IsNullOrEmpty(RUser) Then
            User = RUser
        Else
            User = "root"
        End If
        If Not String.IsNullOrEmpty(RDatabase) Then
            Database = RDatabase
        Else
            Database = "jvrpdatabase"
        End If
        If Not String.IsNullOrEmpty(RPort) Then
            Port = RPort
        Else
            Port = "3306"
        End If
        Pass = RPass
    End Sub
    Public Sub EAddress(ByVal NAddress As String)
        Address = NAddress
    End Sub
    Public Sub EPort(ByVal NPort As String)
        Port = NPort
    End Sub
    Public Sub EUser(ByVal NUser As String)
        User = NUser
    End Sub
    Public Sub EPass(ByVal NPass As String)
        Pass = NPass
    End Sub
    Public Sub EDatabase(ByVal NDatabase As String)
        Database = NDatabase
    End Sub
#End Region
#Region "Conectar"
    Public Sub Inicio()
        Try
            connStr = "DataSource=" + Address + "; Port=" + Port + "; Database=" + Database + "; Uid=" + User + "; Pwd=" + Pass + "; CharSet=utf8mb4"
            'connStr = "DataSource=" + Address + "; Port=" + Port + "; Database=" + Database + "; Uid=" + User + "; Pwd=" + Pass + "; CharSet=utf8mb4_general_ci"
            'connStr = "Server=" + Address + "; Database=" + Database + "; Uid=" + User + "; Pwd=root; CharSet=utf8mb4"
            conn = New MySqlConnection(connStr)
            ModLog.Guardar(connStr)
            If Not conn.Ping Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub desconectar()
        conn.Close()
    End Sub
    Public Function RConexion() As MySqlConnection
        Return conn
    End Function
#End Region
#Region "Interpretar"
    Public Function ESQL(ByVal sql As String) As Boolean
        Dim conT = New MySqlConnection(connStr)
        conT.OpenAsync()
        ModLog.Guardar(sql)
        Try
            objCmd = New MySqlCommand(sql, conT) 'çonT
            objCmd.Prepare()
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
        conT.CloseAsync()
        Return True
    End Function
    Public Function ESQLSelect(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim sqladapter As MySqlDataAdapter
        Dim conT = New MySqlConnection(connStr)
        conT.OpenAsync()
        Try
            objCmd = New MySqlCommand(sql, conT)
            objCmd.Prepare()
            sqladapter = New MySqlDataAdapter(objCmd)
            sqladapter.FillAsync(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return Nothing
        End Try
        conT.CloseAsync()
        Return dt
    End Function
    Public Function ESQLSelect(ByVal objCmd As MySqlCommand, ByVal guardar As Boolean) As DataTable
        dt = New DataTable
        Dim sqladapter As MySqlDataAdapter
        Try
            sqladapter = New MySqlDataAdapter(objCmd)
            sqladapter.Fill(dt)
            If guardar Then
                If ds.Tables.Contains(dt.TableName) Then
                    ds.Tables.Remove(dt.TableName)
                End If
                ds.Tables.Add(dt)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return Nothing
        End Try
        sqladapter.Dispose()
        Return dt
    End Function
#End Region
#Region "Comandos"
    Public Sub BSQL(ByVal nTabla As String, ByVal Condition As String)
        ESQL("DELETE FROM " + nTabla + " WHERE " + Condition)
        ModLog.Guardar("DELETE FROM " + nTabla + " WHERE " + Condition)
    End Sub
    Public Sub ISQL(ByVal nTabla As String, ByVal Column As String, ByVal Data As String, Optional parentesis As Boolean = True)

        If (parentesis) Then
            ESQL("Insert IGNORE into " + nTabla + " ( " + Column + " ) values (" + Data + " )")
        Else
            ESQL("Insert IGNORE into " + nTabla + " ( " + Column + " ) values " + Data)
        End If

    End Sub
    Public Sub MISQL(ByVal nTabla As String, ByVal Column As String, ByVal datos() As String, Optional comilla As Boolean = True)
        Dim r As String = ""
        For Each d In datos
            r += String.Format("{0}),(", d)
        Next
        If Not r.Length < 3 Then
            ISQL(nTabla, Column, r.Remove(r.Length - 3), comilla)
        End If
    End Sub
    Public Function SSQL(ByVal nColumn As String, ByVal nTabla As String, ByVal Condition As String) As DataTable
        If ds.Tables.Contains(nTabla) Then
            dt = New DataTable
            dt.Columns.Add(ds.Tables(nTabla).Columns(nColumn))
            Return dt
        Else
            Return ESQLSelect("select " + nColumn + " FROM " + nTabla + " WHERE " + Condition)
        End If
    End Function
    Public Function PSQL(ByVal nColumn As String, ByVal nTabla As String, ByVal Condition As String) As String
        Return "select " + nColumn + " FROM " + nTabla + " WHERE " + Condition
    End Function
    Public Sub USQL(ByVal nTabla As String, ByVal Orden As String, ByVal Condition As String)
        ESQL("update " + nTabla + " set " + Orden + " WHERE " + Condition)
    End Sub
#End Region
#Region "Usuarios"
    Public Function AUsuarios(ByVal actualizar As Boolean) As DataTable
        If ds.Tables.Contains("usuarios") And Not actualizar Then
            dt = New DataTable()
            dt.Columns.Add(ds.Tables("usuarios").Columns("Nombre Usuarios"))
            Return dt
        Else
            Return DevolverTabla(PSQL("id_usuario as 'ID', nombre as 'Nombre Usuarios'", "usuarios", "True"))
        End If

    End Function
    Public Function BUsuario(ByVal nombre As String, ByVal contraseña As String) As Boolean
        Try
            objCmd = New MySqlCommand(PSQL("id_usuario", "usuarios as User", "nombre = @nombre AND contrasena = AES_ENCRYPT(@contrasena,sha2(@key,256))"), conn)
            objCmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre
            objCmd.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = contraseña
            objCmd.Parameters.Add("@key", MySqlDbType.VarChar).Value = ModCodificador.GKey
            objCmd.Prepare()
            Dim dt As DataTable = ESQLSelect(objCmd, False)
            If Not IsNothing(dt) Then
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Contraseña o Usuario Incorrecto")
                Else
                    Usuario = nombre
                    Password = contraseña
                    UsuarioID = Integer.Parse(dt.Rows(0)("id_usuario"))
                    ModPermisos.Esid(UsuarioID)
                    CargarPermiso()
                    Return True
                End If
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString)
        End Try

        Return False
    End Function
    Public Sub IUsuario(ByVal nombre As String, ByVal contraseña As String)
        ISQL("usuarios", "nombre , contrasena", "'" + nombre + "', AES_ENCRYPT('" + contraseña + "',sha2('" + ModCodificador.GKey + "',256))")
    End Sub

#End Region
#Region "Main"
    Public Function DevolverTabla(ByVal Datos As String) As DataTable
        Try
            Dim dt As DataTable = ESQLSelect(Datos)
            If Not IsNothing(dt) Then
                If Not dt.Rows.Count = 0 Then
                    Return dt
                End If
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString)
        End Try
        Return Nothing
    End Function
#Region "Actualizar"
    Public Function APrograma(fecha As Date) As DataTable
        Return DevolverTabla(PSQL("p.id_programa, time_format(hora_inicio, '%H:%i') as 'Inicio', time_format(hora_fin, '%H:%i') as 'Final', Nombre_programa as 'Programa'", "fechaprograma f inner join programa p on f.id_programa=p.id_programa", "fecha = '" + Format(fecha, "yyyy-MM-dd") + "'"))
    End Function
    Public Function AFPrograma(Fecha As Date, idPrograma As Integer) As DataTable
        Dim Columna As String = "fun.id_funcionario, fun.Nombre, Telefono, Mail, f.Nombre as Función"
        Dim Tablas As String = "(select * from funtrabaja where id_Programa = {0}) ft inner join trabajacomo tc on ft.id_trabajacomo = tc.id_trabajacomo inner join funcion f on f.id_funcion = tc.id_funcion inner join funcionario fun on fun.id_funcionario = tc.id_funcionario"
        Tablas = String.Format(Tablas, idPrograma)
        Dim Condicion As String = String.Format("fecha_inicio<='{0}' and ifnull(fecha_finalizacion,'{0}')>='{0}'", Format(Fecha, "yyyy-MM-dd"))
        Return DevolverTabla(PSQL(Columna, Tablas, Condicion))
    End Function
    Public Function APublicidad(Fecha As Date, Hora As String, ByVal todas As Boolean) As DataTable
        Dim condicion As String
        If (todas) Then
            condicion = "a.hora_inicio = '" + Hora + "'"
        Else
            condicion = "a.fecha_inicio <= '" + Format(Fecha, "yyyy-MM-dd") + "' and a.fecha_finalizacion >= '" + Format(Fecha, "yyyy-MM-dd") + "' and a.hora_inicio = '" + Hora + "'"
        End If
        Return DevolverTabla(PSQL("distinct p.id_publicidad, Nombre", "publicidad p inner join aparecepubli a on p.id_publicidad=a.id_publicidad", condicion))

    End Function
    Public Function APPublicidad(ByVal Fecha As Date, ByVal idPrograma As Integer) As DataTable
        Return DevolverTabla(PSQL("pp.id_publicidad, Nombre", "pmuestrapubli pp inner join publicidad ppp on pp.id_publicidad = ppp.id_publicidad", "pp.fecha_inicio <= '" + Format(Fecha, "yyyy-MM-dd") + "' and pp.fecha_finalizacion >= '" + Format(Fecha, "yyyy-MM-dd").ToString + "' and pp.id_programa = '" + idPrograma.ToString + "'"))
        ModLog.Guardar(PSQL("pp.id_publicidad, Nombre", "pmuestrapubli pp inner join publicidad ppp on pp.id_publicidad = ppp.id_publicidad", "pp.fecha_inicio <= '" + Format(Fecha, "yyyy-MM-dd") + "' and pp.fecha_finalizacion >= '" + Format(Fecha, "yyyy-MM-dd").ToString + "' and pp.id_programa = '" + idPrograma.ToString + "'"))
    End Function
    Public Function AEventos() As DataTable
        Return DevolverTabla(PSQL("e.id_Evento, DATE_FORMAT(Fecha,'%d/%m/%Y') as Fecha, Nombre", "evento e inner join fechaevento f on f.id_evento=e.id_evento", "f.fecha >= now()"))
    End Function
    Public Function ATandas(Optional siguiente As Boolean = True) As DataTable
        Dim condicion As String = "true"
        If (siguiente) Then
            condicion = "(hora_inicio <= curtime() and hora_fin >= curtime()) or hora_inicio >= curtime()"
        End If
        Return DevolverTabla(PSQL("hora_inicio as 'Inicio', hora_fin as 'Final'", "tanda", condicion))
    End Function
    Public Function ADPrograma(idPrograma As Integer) As String
        Dim dt As DataTable = DevolverTabla(PSQL("Descripcion", "programa", "id_programa = '" + idPrograma.ToString + "'"))
        Return dt.Rows(0)(0).ToString
    End Function
#End Region
#End Region
End Module
