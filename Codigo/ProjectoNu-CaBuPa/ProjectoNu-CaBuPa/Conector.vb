Imports MySql.Data.MySqlClient
Imports System.Data

Imports MySql.Data

Public Class Conector
    Private conn As New MySqlConnection
    Private connStr As String
    Private Adress, User, Database, Port, Pass As String
#Region "Constructor"
    Public Sub New(ByVal RAdress As String, ByVal RUser As String, ByVal RDatabase As String, ByVal RPort As String, ByVal RPass As String)
        MyBase.New()
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
        Inicio()
    End Sub
#End Region
#Region "Conectar"
    Public Sub Inicio()
        connStr = "server=" + Adress + ";user=" + User + ";database=" + Database + ";port=" + Port + ";password=" + Pass + ";"
        Dim conn As New MySqlConnection(connStr)
        Try
            Console.WriteLine("Conectando")
            conn.Open()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        conn.Close()
        Console.WriteLine("Listo")
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
    Public Function ESQLSelect(ByVal sql As String) As DataSet
        Dim dt As New DataSet
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
    Function SSQL(ByVal nColumn As String, ByVal nTabla As String, ByVal Condition As String) As DataSet
        Dim selector As String = "select " + nColumn + "FROM " + nTabla + " WHERE " + Condition
        Return ESQLSelect(selector)
    End Function
    Sub USQL(ByVal nTabla As String, ByVal Orden As String, ByVal Condition As String)
        Dim update As String = "update " + nTabla + "set " + Orden + " WHERE " + Condition
        ESQL(update)
    End Sub
#End Region
End Class
