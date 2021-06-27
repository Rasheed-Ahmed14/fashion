Imports System.Data.SqlClient
Public Class CartForm
    Private Sub Butbuy_Click(sender As Object, e As EventArgs) Handles butbuy.Click

    End Sub

    Private Sub Butremove_Click(sender As Object, e As EventArgs) Handles butremove.Click

    End Sub

    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            lblprice.Text = i
        Next
    End Sub
End Class