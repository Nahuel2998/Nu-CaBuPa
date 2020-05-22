Imports MySql.Data.MySqlClient
Imports System.Data

Imports MySql.Data

Public Class Conector
    Dim conn As New MySqlConnection
    Public Sub Inicio(ByVal Adress As String, ByVal User As String, ByVal Database As String, ByVal Port As String, ByVal Pass As String)
        Dim connStr As String = "server=" + Adress + ";user=" + User + ";database=" + Database + ";port=" + Port + ";password=" + Pass + ";"
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
    Public Function ESQL(ByVal sql As String) As Boolean
        Try
            conn.Open()
            Dim objCmd As New MySqlCommand(sql, conn)
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Return False
        End Try
        conn.Close()
        Return True
    End Function
    Public Function ESQLSelect(ByVal sql As String) As MySqlDataReader
        Dim resultado As MySqlDataReader
        Try
            conn.Open()
            Dim objCmd As New MySqlCommand(sql, conn)
            resultado = objCmd.ExecuteReader()
        Catch ex As Exception
            Return Nothing

        End Try
        conn.Close()
        Return resultado
    End Function
End Class
