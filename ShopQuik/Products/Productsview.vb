Public Class Productsview

    Private Sub Butview_Click(sender As Object, e As EventArgs) Handles butview.Click
        If cmbtype.Text = "" Then
            MsgBox("please enter the details")
        Else
            If cmbtype.Text = "All" Then
                str = "select * from ProductDetails"
                table.Clear()
                table = Database(str)
            Else
                str = "select * from ProductDetails where ProductType='" & cmbtype.Text & "'"
                table.Clear()
                table = Database(str)
            End If
            Dim imgc As New DataGridViewImageColumn
            propgrid.RowTemplate.Height = 50
            propgrid.DataSource = table
            imgc = propgrid.Columns(6)
            imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        End If
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged

    End Sub
End Class