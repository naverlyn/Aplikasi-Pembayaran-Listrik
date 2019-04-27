Imports System.Data.Odbc

Module Module1

    Public connect As OdbcConnection
    Public reader As OdbcDataReader
    Public adapter As OdbcDataAdapter
    Public command As OdbcCommand
    Public kutil As DataSet


    Sub koneksi()
        connect = New OdbcConnection("Dsn=token listrik;uid=root")
        connect.Open()
    End Sub

End Module
