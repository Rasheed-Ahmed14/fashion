Imports System.Text.RegularExpressions
Public Class LoginMain
    Private Sub LoginMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Usermain.Dispose()
            AdminMain.Dispose()
            lblnew.Visible = False
            ButSignUp.Visible = False
            lblor.Visible = False
            sep1.Visible = False
            sep2.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButLogin_Click(sender As Object, e As EventArgs) Handles ButLogin.Click
        Try
            If radEnduser.Checked = True Or radAdmin.Checked = True Then
                If radAdmin.Checked = True Then
                    If TxtAdminId.Text = "" Or TxtAdminPassword.Text = "" Then
                        MessageBox.Show("please enter the details")
                    Else
                        str = "select * from AdminDetails where AdminId='" & TxtAdminId.Text & "' and Password='" & TxtAdminPassword.Text & "'"
                        table = Database(str)
                        If table.Rows.Count() <= 0 Then
                            MessageBox.Show("invalid credentials!", "Alert!")
                        Else
                            AdminMain.Show()
                            Me.Hide()
                        End If
                    End If
                Else
                    If TxtUserId.Text = "" Or TxtUserPassword.Text = "" Then
                        MessageBox.Show("please enter the details")
                    Else
                        str = "select * from UserDetails where MobileNumber='" & TxtUserId.Text & "' and Password='" & TxtUserPassword.Text & "' "
                        table = Database(str)
                        If table.Rows.Count > 0 Then
                            RetrieveImage(Usermain.pctmain, 0, 6)
                            Usermain.lblusernamemain.Text = table.Rows(0)(0)
                            str = "select * from MainCartDetails where MobileNumber='" & TxtUserId.Text & "'"
                            table = Database(str)
                            If table.Rows.Count > 0 Then
                                Usermain.butcart.Text = table.Rows(0)(1)
                            End If
                            str = "select * from ProductDetails"
                            product(str, UserMainHome)
                            panelswitch(UserMainHome, Usermain.usermainpanel)
                            Me.Hide()
                            Usermain.Show()
                        Else
                            MessageBox.Show("invalid credentials!", "Alert!")
                        End If
                    End If
                End If
            Else
                MessageBox.Show("please select type of user")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButSignUp_Click(sender As Object, e As EventArgs) Handles ButSignUp.Click
        UserCreate.Show()
        Me.Hide()
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked = True Then
            TxtAdminPassword.isPassword = False
        Else
            TxtAdminPassword.isPassword = True
        End If
    End Sub

    Private Sub Linkforgotuser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkforgotuser.LinkClicked
        ForgotPassword.butcancel.Visible = True
        ForgotPassword.Show()
    End Sub

    Private Sub Userhidepassword_CheckedChanged(sender As Object, e As EventArgs) Handles userhidepassword.CheckedChanged
        If userhidepassword.Checked = True Then
            TxtUserPassword.isPassword = False
        Else
            TxtUserPassword.isPassword = True
        End If
    End Sub

    Private Sub RadAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin.CheckedChanged
        TxtAdminId.Text = ""
        TxtAdminPassword.Text = ""
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

    Private Sub RadEnduser_CheckedChanged(sender As Object, e As EventArgs) Handles radEnduser.CheckedChanged
        TxtUserId.Text = ""
        TxtUserPassword.Text = ""
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

    Private Sub Butexit_Click(sender As Object, e As EventArgs) Handles butexit.Click
        End
    End Sub
    Private Sub TxtUserId_textchanged(sender As Object, e As EventArgs) Handles TxtUserId.OnValueChanged
        If Regex.IsMatch(TxtUserId.Text, "[^0-9\b$]") Then
            MsgBox("only numerals are allowed")
            TxtUserId.Focus()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class