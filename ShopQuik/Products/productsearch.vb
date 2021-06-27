Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class productsearch
    Dim m3 As New MemoryStream
    Private Sub Butserach_Click(sender As Object, e As EventArgs) Handles butserach.Click
        If cmbproductid.Text = "" Then
            MsgBox("please select the mobile number")
        Else
            str = "select * from ProductDetails where ProductID='" & cmbproductid.Text & "'"
            table.Clear()
            table = Database(str)
            With table
                TxtSpecification.Text = .Rows(0)(3)
                TxtPrice.Text = .Rows(0)(2)
                TxtName.Text = .Rows(0)(1)
                TxtQuantity.Text = .Rows(0)(4)
                txttype.Text = .Rows(0)(5)
                RetrieveImage(PctProduct, 0, 6)
                productpanel.Visible = True
            End With
        End If
    End Sub

    Private Sub Butremove_Click(sender As Object, e As EventArgs) Handles butremove.Click
        Dim cmd As New SqlCommand("delete from ProductDetails where ProductID='" & cmbproductid.Text & "'", con)
        Dim n As Integer = cmd.ExecuteNonQuery
        If n > 0 Then
            MsgBox("removed successfully")
            cmbproductid.Items.Remove(cmbproductid.Text)
            cmbproductid.Text = ""
            productpanel.Visible = False
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub Butupdate_Click(sender As Object, e As EventArgs) Handles butupdate.Click
        Dim m1 As New MemoryStream
        m1 = ConvertImage(PctProduct)
        Dim cmd As New SqlCommand("Update ProductDetails set ProductName='" & TxtName.Text & "',ProductPrice='" & TxtPrice.Text & "',Specifications='" & TxtSpecification.Text & "',Quantity='" & TxtQuantity.Text & "',ProductType='" & txttype.Text & "',ProductImage=@image where ProductID='" & cmbproductid.Text & "'", con)
        cmd.Parameters.Add("@image", SqlDbType.Image).Value = m1.ToArray
        Dim n As Integer = cmd.ExecuteNonQuery
        If n > 0 Then
            MsgBox("updated successfully")
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub ButImage_Click(sender As Object, e As EventArgs) Handles ButImage.Click
        SelectImage(PctProduct)
    End Sub
    Private Sub TxtProductID_OnValueChanged(sender As Object, e As EventArgs) Handles TxtName.OnValueChanged
        If Regex.IsMatch(TxtName.Text, "^a-zA-Z0-9\b\t$") Then
            MsgBox("special characters are not allowed")
            TxtName.Focus()
        End If
    End Sub

    Private Sub TxtPrice_OnValueChanged(sender As Object, e As EventArgs) Handles TxtPrice.OnValueChanged
        If Regex.IsMatch(TxtPrice.Text, "^0-9.\b$") Then
            MsgBox("only numerals are allowed")
            TxtPrice.Focus()
        End If
    End Sub

    Private Sub TxtQuantity_OnValueChanged(sender As Object, e As EventArgs) Handles TxtQuantity.OnValueChanged
        If Regex.IsMatch(TxtQuantity.Text, "^0-9\b$") Then
            MsgBox("only numerals are allowed")
            TxtQuantity.Focus()
        End If
    End Sub

    Private Sub cmbproductid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproductid.SelectedIndexChanged

    End Sub
End Class