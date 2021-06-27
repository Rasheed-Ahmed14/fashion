Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class UserCreate
    Dim m10 As New MemoryStream
    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked = True Then
            TxtPassword.isPassword = False
            TxtConfirmPassword.isPassword = False
        Else
            TxtPassword.isPassword = True
            TxtConfirmPassword.isPassword = True
        End If
    End Sub

    Private Sub ButLogin_Click(sender As Object, e As EventArgs) Handles ButLogin.Click
        LoginMain.Show()
        Me.Hide()
    End Sub

    Private Sub Butimage_Click(sender As Object, e As EventArgs) Handles butimage.Click
        SelectImage(PctUserImage)
    End Sub

    Private Sub TxtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles TxtPassword.OnValueChanged
        TxtPassword.isPassword = True
        lblpas.Visible = True
        If Len(TxtPassword.Text) < 6 Then
            lblpas.Text = "Password should contain minimum 6 characters"
        ElseIf Len(TxtPassword.Text) > 10 Then
            lblpas.Text = "Password should be within 10 characters"
        End If
    End Sub

    Private Sub TxtConfirmPassword_OnValueChanged(sender As Object, e As EventArgs) Handles TxtConfirmPassword.OnValueChanged
        TxtConfirmPassword.isPassword = True
    End Sub

    Private Sub ButCreate_Click_1(sender As Object, e As EventArgs)
        Try
            If Len(TxtMobileNumber.Text) = 10 Then
                str = "select * from UserDetails where MobileNumber='" & TxtMobileNumber.Text & "'"
                table = Database(str)
                If table.Rows.Count > 0 Then
                    MessageBox.Show("Already Have an account", "ShopQuik")
                Else
                    Dim par As String = "^\w+@['gmail']+?\.['com']{3,3}$"
                    If Not Regex.IsMatch(TxtEmail.Text, par) Then
                        MsgBox("invalid email")
                        TxtEmail.Focus()
                    Else
                        If TxtPassword.Text = TxtConfirmPassword.Text Then
                            If Len(TxtPassword.Text) < 6 Then
                                MsgBox("password should contain minimum 6 characters")
                            Else
                                If con.State = ConnectionState.Open Then
                                    con.Close()
                                End If
                                con.Open()
                                m10 = ConvertImage(PctUserImage)
                                Dim command As New SqlCommand("insert into UserDetails values('" & TxtName.Text & "','" & TxtMobileNumber.Text & "','" & TxtEmail.Text & "','" & TxtAddress.Text & "','" & TxtPincode.Text & "','" & TxtPassword.Text & "',@UserImage)", con)
                                If PctUserImage.Image Is Nothing Then
                                    command.Parameters.Add("@UserImage", SqlDbType.Image).Value = DBNull.Value
                                Else
                                    command.Parameters.Add("@UserImage", SqlDbType.Image).Value = m10.ToArray()
                                End If
                                Dim n As Integer = command.ExecuteNonQuery()
                                If n > 0 Then
                                    MessageBox.Show("Your Account Created Successfully...", "ShopQuik")
                                    LoginMain.Show()
                                    Me.Hide()
                                Else
                                    MessageBox.Show("Error in creating!", "ShopQuik")
                                End If
                            End If
                        Else
                            MessageBox.Show("Password doesn't match!")
                        End If
                    End If
                End If
            Else
                MsgBox("invalid Mobile Number")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TxtMobileNumber_OnValueChanged(sender As Object, e As EventArgs) Handles TxtMobileNumber.OnValueChanged
        If Regex.IsMatch(TxtMobileNumber.Text, "[^0-9\b$]") Then
            MsgBox("only numerals are allowed")
            TxtMobileNumber.Focus()
        End If
    End Sub

    Private Sub TxtName_OnValueChanged(sender As Object, e As EventArgs) Handles TxtName.OnValueChanged
        If Regex.IsMatch(TxtName.Text, "[^0-9A-Za-z\s\b$]") Then
            MsgBox("special characters are not allowed")
            TxtName.Focus()
        End If
    End Sub

    Private Sub TxtPincode_OnValueChanged(sender As Object, e As EventArgs) Handles TxtPincode.OnValueChanged
        If Regex.IsMatch(TxtPincode.Text, "[^0-9\b$]") Then
            MsgBox("only numerals are allowed")
            TxtPincode.Focus()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Len(TxtMobileNumber.Text) = 10 Then
                str = "select * from UserDetails where MobileNumber='" & TxtMobileNumber.Text & "'"
                table = Database(str)
                If table.Rows.Count > 0 Then
                    MessageBox.Show("Already Have an account", "ShopQuik")
                Else
                    Dim par As String = "^\w+@['gmail']+?\.['com']{3,3}$"
                    If Not Regex.IsMatch(TxtEmail.Text, par) Then
                        MsgBox("invalid email")
                        TxtEmail.Focus()
                    Else
                        If TxtPassword.Text = TxtConfirmPassword.Text Then
                            If Len(TxtPassword.Text) < 6 Then
                                MsgBox("password should contain minimum 6 characters")
                            Else
                                If con.State = ConnectionState.Open Then
                                    con.Close()
                                End If
                                con.Open()
                                m10 = ConvertImage(PctUserImage)
                                Dim command As New SqlCommand("insert into UserDetails values('" & TxtName.Text & "','" & TxtMobileNumber.Text & "','" & TxtEmail.Text & "','" & TxtAddress.Text & "','" & TxtPincode.Text & "','" & TxtPassword.Text & "',@UserImage)", con)
                                If PctUserImage.Image Is Nothing Then
                                    command.Parameters.Add("@UserImage", SqlDbType.Image).Value = DBNull.Value
                                Else
                                    command.Parameters.Add("@UserImage", SqlDbType.Image).Value = m10.ToArray()
                                End If
                                Dim n As Integer = command.ExecuteNonQuery()
                                If n > 0 Then
                                    MessageBox.Show("Your Account Created Successfully...", "ShopQuik")
                                    LoginMain.Show()
                                    Me.Hide()
                                Else
                                    MessageBox.Show("Error in creating!", "ShopQuik")
                                End If
                            End If
                        Else
                            MessageBox.Show("Password doesn't match!")
                        End If
                    End If
                End If
            Else
                MsgBox("invalid Mobile Number")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UserCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class