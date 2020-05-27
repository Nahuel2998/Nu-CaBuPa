Imports MySql.Data.MySqlClient
Imports System.Data
Imports MySql.Data
Module ModConector

    Private conn As New MySqlConnection
    Private connStr As String
    Private Adress, User, Database, Port, Pass As String
    Private UsuarioID As Integer
    Private Usuario, Password As String
#Region "GetDirection"
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
        connStr = "Server=" + Adress + ";UID=" + User + ";database=" + Database + ";Password=" + ";Port=" + Port
        conn = New MySqlConnection(connStr)
        Try
            MessageBox.Show("Conectando al servidor")
            MessageBox.Show(connStr)
            conn.Open()
            MessageBox.Show("Conectado al servidor")
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
            Dim objCmd As New MySqlCommand(sql, conn)
            objCmd.Connection.Open()
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Return False
        End Try
        conn.Close()
        Return True
    End Function
    Public Function ESQLSelect(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim objCmd As New MySqlCommand(sql, conn)
            objCmd.Connection.Open()
            Dim sqladapter As New MySqlDataAdapter(objCmd)
            sqladapter.Fill(dt)
        Catch ex As Exception
            Return Nothing
        End Try
        conn.Close()
        Return dt
    End Function
#End Region
#Region "Comandos"
    Sub BSQL(ByVal nTabla As String, ByVal Condition As String)
        Dim borrar As String = "DELETE FROM " + nTabla + " WHERE " + Condition
        ESQL(borrar)
    End Sub
    Sub ISQL(ByVal nTabla As String, ByVal Column As String, ByVal Data As String)
        Dim insert As String = "Insert into " + nTabla + " ( " + Column + " ) values (" + Data + " )"
        ESQL(insert)
    End Sub
    Function SSQL(ByVal nColumn As String, ByVal nTabla As String, ByVal Condition As String) As DataTable
        Dim selector As String = "select " + nColumn + " FROM " + nTabla + " WHERE " + Condition
        Return ESQLSelect(selector)
    End Function
    Sub USQL(ByVal nTabla As String, ByVal Orden As String, ByVal Condition As String)
        Dim update As String = "update " + nTabla + " set " + Orden + " WHERE " + Condition
        ESQL(update)
    End Sub
#End Region
#Region "Usuarios"
    Public Function BUsuario(ByVal nombre As String, ByVal contraseña As String) As DataTable
        Try
            Dim sqladapter As MySqlDataAdapter
            Dim dt As New DataTable
            'Dim sqlreader As MySqlDataReader
            Dim Command As String = "SELECT id_usuario FROM usuarios WHERE nombre = '@nombre' AND contrasena = sha2('@contrasena',256)"

            Dim objCmd As New MySqlCommand("SELECT id_usuario FROM usuarios WHERE nombre = @nombre AND contrasena = sha2(@contrasena,256)", conn)
            objCmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre
            objCmd.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = contraseña
            objCmd.Prepare()
            sqladapter = New MySqlDataAdapter(objCmd)
            sqladapter.Fill(dt)
            Return dt
        Catch e As Exception
            MessageBox.Show(e.ToString)
        End Try
        Return Nothing
    End Function

#End Region
End Module
