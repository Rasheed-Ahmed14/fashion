Imports System.Data.SqlClient
Imports System.IO
Public Class AddItems

    Private Sub ButAddProduct_Click(sender As Object, e As EventArgs) Handles ButAddProduct.Click
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            ConvertImage(PctProduct)
            Dim command As New SqlCommand("insert into ProductDetails values('" & TxtProductID.Text & "','" & TxtName.Text & "','" & TxtPrice.Text & "','" & TxtSpecification.Text & "','" & TxtQuantity.Text & "','" & CmbProductType.Text & "',@Image)", con)
            command.Parameters.Add("@Image", SqlDbType.Image).Value = ms.ToArray()


            Dim row As Integer = command.ExecuteNonQuery()
            If row > 0 Then
                MessageBox.Show("Product Added Successfully!", "ShopQuik")
                TxtName.Text = ""
                TxtPrice.Text = ""
                TxtSpecification.Text = ""
                PctProduct.Image = Nothing
                CmbProductType.Text = ""
                TxtQuantity.Text = ""
                TxtProductID.Text = ""
            Else
                MessageBox.Show("error!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButImage_Click_1(sender As Object, e As EventArgs) Handles ButImage.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "(*.PNG;*.JPG;*.GIF)|*.png;*.jpg;*.gif"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PctProduct.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
                PctProduct.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class