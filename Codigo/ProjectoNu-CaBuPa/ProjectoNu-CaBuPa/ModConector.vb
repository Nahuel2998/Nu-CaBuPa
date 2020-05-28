Imports MySql.Data.MySqlClient
Imports System.Data
Imports MySql.Data
Module ModConector
    Private Debug As Boolean = True
    Private conn As New MySqlConnection
    Private connStr As String
    Private Adress, User, Database, Port, Pass As String
    Private UsuarioID As Integer
    Private Usuario, Password As String
    Private objCmd As New MySqlCommand
    Private ds As New DataSet
    Private dt As New DataTable
    Private sqladapter As MySqlDataAdapter
#Region "GetDirection"
    Public Function GDebug() As Boolean
        Return Debug
    End Function
    Public Function GAdress() As String
        Return Adress
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
    Public Sub Crear(ByVal RAdress As String, ByVal RPort As String, ByVal RDatabase As String, ByVal RUser As String, ByVal RPass As String)
        If Not String.IsNullOrEmpty(Adress) Then
            Adress = RAdress
        Else
            Adress = "localhost"
        End If
        If Not String.IsNullOrEmpty(Adress) Then
            User = RUser
        Else
            User = "root"
        End If
        If Not String.IsNullOrEmpty(Adress) Then
            Database = RDatabase
        Else
            Database = "JVRPDB"
        End If
        If Not String.IsNullOrEmpty(Adress) Then
            Port = RPort
        Else
            Port = "3306"
        End If
        If Not String.IsNullOrEmpty(Adress) Then
            Pass = RPass
        Else
            Pass = "root"
        End If
    End Sub
    Public Sub EAdress(ByVal NAdress As String)
        Adress = NAdress
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
            connStr = "Server=" + Adress + "; UID=" + User + "; database=" + Database + "; Password=" + Pass + "; Port=" + Port + "; CharSet=utf8"
            conn = New MySqlConnection(connStr)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Console.WriteLine(ex.ToString())
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
        Try
            objCmd = New MySqlCommand(sql, conn)
            objCmd.Prepare()
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Return False
        End Try
        Return True
    End Function
    Public Function ESQLSelect(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Try
            objCmd = New MySqlCommand(sql, conn)
            objCmd.Prepare()
            sqladapter = New MySqlDataAdapter(objCmd)
            sqladapter.Fill(dt)
            ds.Tables.Add(dt)
        Catch ex As Exception
            Return Nothing
        End Try
        Return dt
    End Function
    Public Function ESQLSelect(ByVal objCmd As MySqlCommand) As DataTable
        dt = New DataTable
        Try
            sqladapter = New MySqlDataAdapter(objCmd)
            sqladapter.Fill(dt)
            ds.Tables.Add(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return Nothing
        End Try
        Return dt
    End Function
#End Region
#Region "Comandos"
    Public Sub BSQL(ByVal nTabla As String, ByVal Condition As String)
        Dim borrar As String = "DELETE FROM " + nTabla + " WHERE " + Condition
        ESQL(borrar)
    End Sub
    Public Sub ISQL(ByVal nTabla As String, ByVal Column As String, ByVal Data As String)
        Dim insert As String = "Insert into " + nTabla + " ( " + Column + " ) values (" + Data + " )"
        ESQL(insert)
    End Sub
    Public Function SSQL(ByVal nColumn As String, ByVal nTabla As String, ByVal Condition As String) As DataTable
        Dim selector As String = "select " + nColumn + " FROM " + nTabla + " WHERE " + Condition
        If ds.Tables.Contains(nTabla) Then
            dt = New DataTable
            dt.Columns.Add(ds.Tables(nTabla).Columns(nColumn))
            Return dt
        Else

            Return ESQLSelect(selector)
        End If
    End Function
    Public Sub USQL(ByVal nTabla As String, ByVal Orden As String, ByVal Condition As String)
        Dim update As String = "update " + nTabla + " set " + Orden + " WHERE " + Condition
        ESQL(update)
    End Sub
#End Region
#Region "Usuarios"
    Public Function AUsuarios(ByVal actualizar As Boolean) As DataTable
        If ds.Tables.Contains("usuarios") And Not actualizar Then
            dt = New DataTable()
            dt.Columns.Add(ds.Tables("usuarios").Columns("Nombre Usuarios"))
            Return dt
        Else
            Try
                objCmd = New MySqlCommand("SELECT nombre as 'Nombre Usuarios' FROM usuarios", conn)
                objCmd.Prepare()
                Dim dt As DataTable = ESQLSelect(objCmd)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No hay usuarios")
                    Else
                        Return dt
                    End If
                End If
            Catch e As Exception
                MessageBox.Show(e.ToString)
            End Try
            Return Nothing
        End If

    End Function
    Public Function BUsuario(ByVal nombre As String, ByVal contraseña As String) As Boolean
        Try
            objCmd = New MySqlCommand("SELECT id_usuario FROM usuarios WHERE nombre = @nombre AND contrasena = sha2(@contrasena,256)", conn)
            objCmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre
            objCmd.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = contraseña
            objCmd.Prepare()
            Dim dt As DataTable = ESQLSelect(objCmd)
            If Not IsNothing(dt) Then
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Contraseña o Usuario Incorrecto")
                Else
                    Usuario = nombre
                    Password = contraseña
                    UsuarioID = Integer.Parse(dt.Rows(0)("id_usuario"))
                    Return True
                End If
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString)
        End Try

        Return False
    End Function
    Public Sub IUsuario(ByVal nombre As String, ByVal contraseña As String)
        ISQL("usuarios", "nombre , contrasena", "'" + nombre + "',sha2('" + contraseña + "',256)")
    End Sub

#End Region
End Module
