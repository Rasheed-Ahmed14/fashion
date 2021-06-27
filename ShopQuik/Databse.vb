Imports System.Data.SqlClient
Imports System.IO
Module Databse
    Public table As New DataTable()
    Public str As String
    Dim con As New SqlConnection("server=DESKTOP-SN7DM5O\GIRISHSQL;database=ShopQuik;integrated security=True")
    Public Function Database(ByVal str As String)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim command As New SqlCommand(str, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table
    End Function
End Module
