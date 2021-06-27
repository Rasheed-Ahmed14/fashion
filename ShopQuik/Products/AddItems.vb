Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class AddItems
    Dim m As New MemoryStream
    Private Sub ButAddProduct_Click(sender As Object, e As EventArgs) Handles ButAddProduct.Click
        Try
            If TxtProductID.Text = "" Or TxtQuantity.Text = "" Or TxtPrice.Text = "" Or TxtName.Text = "" Or CmbProductType.SelectedItem = Nothing Or pctproduct.Image Is Nothing Then
                MsgBox("please enter all the details")
            Else
                str = "select ProductID from ProductDetails where ProductID='" & TxtProductID.Text & "'"
                table.Clear()
                table = Database(str)
                If table.Rows.Count > 0 Then
                    MsgBox("Product with ID '" & TxtProductID.Text & "' already exist")
                    TxtProductID.Focus()
                Else
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    m = ConvertImage(pctproduct)
                    Dim command As New SqlCommand("insert into ProductDetails values('" & TxtProductID.Text & "','" & TxtName.Text & "','" & TxtPrice.Text & "','" & TxtSpecification.Text & "','" & TxtQuantity.Text & "','" & CmbProductType.Text & "',@img)", con)
                    command.Parameters.Add("@img", SqlDbType.Image).Value = m.ToArray()
                    Dim row As Integer = command.ExecuteNonQuery()
                    If row > 0 Then
                        MessageBox.Show("Product Added Successfully!", "ShopQuik")
                        TxtName.Text = ""
                        TxtPrice.Text = ""
                        TxtSpecification.Text = ""
                        pctproduct.Image = Nothing
                        CmbProductType.Text = ""
                        TxtQuantity.Text = ""
                        TxtProductID.Text = ""
                        CmbProductType.Focus()
                    Else
                        MessageBox.Show("error!")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButImage_Click(sender As Object, e As EventArgs) Handles ButImage.Click
        Try
            SelectImage(pctproduct)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtProductID_OnValueChanged(sender As Object, e As EventArgs) Handles TxtProductID.OnValueChanged
        If Regex.IsMatch(TxtProductID.Text, "^a-zA-Z0-9\b$") Then
            MsgBox("special characters are not allowed")
            TxtProductID.Focus()
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

    Private Sub TxtName_OnValueChanged(sender As Object, e As EventArgs) Handles TxtName.OnValueChanged
        If Regex.IsMatch(TxtName.Text, "^a-zA-Z0-9\s\b$") Then
            MsgBox("special characters are not allowed")
            TxtName.Focus()
        End If
    End Sub

    Private Sub TxtProductID_GotFocus(sender As Object, e As EventArgs) Handles TxtProductID.GotFocus
        Dim ran As New Random()
Temp:
        TxtProductID.Text = "PRD" & ran.Next(1, 999)
        str = "select * from ProductDetails where ProductID='" & TxtProductID.Text & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then
            GoTo Temp
        End If
    End Sub

    Private Sub CmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProductType.SelectedIndexChanged

    End Sub
End Class