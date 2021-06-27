Imports System.Data.SqlClient
Imports System.IO
Public Class searchuser
    Dim ms2 As New MemoryStream

    Private Sub Butsearch_Click(sender As Object, e As EventArgs) 
        If cmbnumber.Text = "" Then
            MsgBox("please select the mobile number")
        Else
            str = "select * from UserDetails where MobileNumber='" & cmbnumber.Text & "'"
            table.Clear()
            table = Database(str)
            With table
                TxtAddress.Text = .Rows(0)(3)
                TxtEmail.Text = .Rows(0)(2)
                TxtName.Text = .Rows(0)(0)
                TxtPincode.Text = .Rows(0)(4)
                RetrieveImage(PctUserImage, 0, 6)
                userpanel.Visible = True
            End With
        End If
    End Sub

    'Private Sub Butimage_Click(sender As Object, e As EventArgs)
    '    SelectImage(PctUserImage)
    'End Sub

    Private Sub Butremove_Click(sender As Object, e As EventArgs) Handles Butremove.Click
        Dim cmd As New SqlCommand("delete from UserDetails where MobileNumber='" & cmbnumber.Text & "'", con)
        Dim n As Integer = cmd.ExecuteNonQuery
        If n > 0 Then
            MsgBox("removed successfully")
            cmbnumber.Items.Remove(cmbnumber.Text)
            cmbnumber.Items.Remove(cmbnumber.SelectedItem)
            cmbnumber.Text = ""
            userpanel.Visible = False
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub TxtName_OnValueChanged(sender As Object, e As EventArgs) Handles TxtName.OnValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbnumber.Text = "" Then
            MsgBox("please select the mobile number")
        Else
            str = "select * from UserDetails where MobileNumber='" & cmbnumber.Text & "'"
            table.Clear()
            table = Database(str)
            With table
                TxtAddress.Text = .Rows(0)(3)
                TxtEmail.Text = .Rows(0)(2)
                TxtName.Text = .Rows(0)(0)
                TxtPincode.Text = .Rows(0)(4)
                RetrieveImage(PctUserImage, 0, 6)
                userpanel.Visible = True
            End With
        End If
    End Sub

    'Private Sub Butupdate_Click(sender As Object, e As EventArgs) Handles butupdate.Click
    '    ms2 = ConvertImage(PctUserImage)
    '    Dim cmd As New SqlCommand("Update UserDetails set Name='" & TxtName.Text & "',EmailID='" & TxtEmail.Text & "',Address='" & TxtAddress.Text & "',PINCode='" & TxtPincode.Text & "',UserImage=@image where MobileNumber='" & cmbnumber.Text & "'", con)
    '    cmd.Parameters.Add("@image", SqlDbType.Image).Value = ms2.ToArray
    '    Dim n As Integer = cmd.ExecuteNonQuery
    '    If n > 0 Then
    '        MsgBox("updated successfully")
    '    Else
    '        MsgBox("error")
    '    End If
    'End Sub
End Class