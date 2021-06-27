Imports System.Data.SqlClient
Imports System.IO
Public Class UserProfile
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            str = "select * from UserDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table = Database(str)
            lblusername.Text = table.Rows(0)(0)
            lblMn.Text = table.Rows(0)(1)
            lblemail.Text = table.Rows(0)(2)
            lbladdress.Text = table.Rows(0)(3)
            lblpincode.Text = table.Rows(0)(4)
            RetrieveImage(pctprofile, 0, 6)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class