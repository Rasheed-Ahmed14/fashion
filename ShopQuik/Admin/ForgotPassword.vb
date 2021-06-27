Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class ForgotPassword
    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked = True Then
            TxtNewPassword.isPassword = True
            TxtConfirmPassword.isPassword = True
        Else
            TxtNewPassword.isPassword = False
            TxtConfirmPassword.isPassword = False
        End If
    End Sub
    Private Sub ButResetPasword_Click(sender As Object, e As EventArgs) Handles ButResetPasword.Click
        Try
            str = "select * from UserDetails where MobileNumber='" & TxtMobileEmail.Text & "'"
            table.Clear()
            table = Database(str)
            If table.Rows.Count > 0 Then
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If TxtConfirmPassword.Text = TxtNewPassword.Text Then
                    Dim cmd As New SqlCommand("update UserDetails set Password='" & TxtNewPassword.Text & "' where MobileNumber='" & TxtMobileEmail.Text & "'", con)
                    Dim n As Integer = cmd.ExecuteNonQuery
                    If n > 0 Then
                        MessageBox.Show("Your password Reseted Successfully", "ShopQuik")
                        TxtNewPassword.Text = ""
                        TxtConfirmPassword.Text = ""
                    Else
                        MsgBox("error")
                    End If
                Else
                    MsgBox("password does not match")
                End If

            Else
                MsgBox("Account with This '" & TxtMobileEmail.Text & "' mobile number does not exist")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Butcancel_Click(sender As Object, e As EventArgs) Handles butcancel.Click
        Me.Hide()
    End Sub

    Private Sub TxtMobileEmail_OnValueChanged(sender As Object, e As EventArgs) Handles TxtMobileEmail.OnValueChanged
        If Regex.IsMatch(TxtMobileEmail.Text, "[^0-9\b$]") Then
            MsgBox("only numerals are allowed")
            TxtMobileEmail.Focus()
        End If
    End Sub
End Class