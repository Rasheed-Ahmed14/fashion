Imports System.Data.SqlClient
Public Class login
    Private Sub ButLogin_Click(sender As Object, e As EventArgs) Handles ButLogin.Click
        Try
            If radEnduser.Checked = True Or radAdmin.Checked = True Then
                If radAdmin.Checked = True Then
                    str = "select * from AdminTable where AdminId='" & TxtAdminId.Text & "' and Password='" & TxtAdminPassword.Text & "'"
                    table = Database(str)
                Else
                    radEnduser.Checked = True
                    str = "select * from UserDetails where MobileNumber='" & TxtUserId.Text & "' and Password='" & TxtUserPassword.Text & "' "
                    table = Database(str)

                End If
                If table.Rows.Count() <= 0 Then
                    MessageBox.Show("invalid credentials!", "Alert!")
                Else

                    UserMain.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("please select type of user")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked = True Then
            TxtAdminPassword.isPassword = True

        Else
            TxtAdminPassword.isPassword = False

        End If

    End Sub

    Private Sub ButSignUp_Click(sender As Object, e As EventArgs) Handles ButSignUp.Click
        UserCreate.Show()
        Me.Hide()
    End Sub

    Private Sub LinkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkForgotadmin.LinkClicked
        ForgotPassword.Show()

    End Sub


    Private Sub RadEnduser_CheckedChanged(sender As Object, e As EventArgs) Handles radEnduser.CheckedChanged
        If userpanel.Height = 50 Then
            mainpanel.Height = 450
            userpanel.Height = 230
            radAdmin.Checked = False
        Else
            userpanel.Height = 50
        End If
        lblnew.Visible = True
        ButSignUp.Visible = True
        lblor.Visible = True
        sep1.Visible = True
        sep2.Visible = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblnew.Visible = False
            ButSignUp.Visible = False
            lblor.Visible = False
            sep1.Visible = False
            sep2.Visible = False
        Catch ex As Exception

        End Try


    End Sub


    Private Sub RadAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin.CheckedChanged
        If adminpanel.Height = 50 Then
            mainpanel.Height = 345
            adminpanel.Height = 230
            radEnduser.Checked = False
        Else
            adminpanel.Height = 50
        End If
        lblnew.Visible = False
        ButSignUp.Visible = False
        lblor.Visible = False
        sep1.Visible = False
        sep2.Visible = False
    End Sub

    Private Sub Linkforgotuser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkforgotuser.LinkClicked
        ForgotPassword.Show()
    End Sub

    Private Sub userhidepassword_CheckedChanged(sender As Object, e As EventArgs) Handles userhidepassword.CheckedChanged
        If userhidepassword.Checked = True Then
            TxtUserPassword.isPassword = True

        Else
            TxtUserPassword.isPassword = False

        End If
    End Sub
End Class
