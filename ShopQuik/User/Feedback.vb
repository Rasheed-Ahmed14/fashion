Imports System.Data.SqlClient
Public Class Feedback
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radgreat.CheckedChanged
        If radgreat.Checked = True Then
            radgreat.ForeColor = Color.DarkBlue
        Else
            radgreat.ForeColor = Color.White
        End If
    End Sub

    Private Sub Radgood_CheckedChanged(sender As Object, e As EventArgs) Handles radgood.CheckedChanged
        If radgood.Checked = True Then
            radgood.ForeColor = Color.DarkBlue
        Else
            radgood.ForeColor = Color.White
        End If
    End Sub

    Private Sub Raddispoint_CheckedChanged(sender As Object, e As EventArgs) Handles raddispoint.CheckedChanged
        If raddispoint.Checked = True Then
            raddispoint.ForeColor = Color.DarkBlue
        Else
            raddispoint.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butfeedback.Click
        Dim st As String
        If raddispoint.Checked = False And radgood.Checked = False And radgreat.Checked = False Then
            MessageBox.Show("please select an option")
        Else
            If raddispoint.Checked = True Then
                st = raddispoint.Text
            ElseIf radgood.Checked = True Then
                st = radgood.Text
            Else
                st = radgreat.Text
            End If
            Dim feed As String = st + " ," + txtfeedback.Text
            str = "select * from UserDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table.Clear()
            table = Database(str)
            Dim name As String = table.Rows(0)(0)
            Dim cmd As New SqlCommand("insert into feedback values('" & LoginMain.TxtUserId.Text & "','" & name & "','" & feed & "')", con)
            Dim n As Integer = cmd.ExecuteNonQuery
            If n > 0 Then
                MessageBox.Show("feedback Sended Successfully")
                txtfeedback.Text = ""
                radgreat.Checked = False
                radgood.Checked = False
                raddispoint.Checked = False
            Else
                MsgBox("error")
            End If
        End If
    End Sub
End Class