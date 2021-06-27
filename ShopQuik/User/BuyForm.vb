Imports System.Data.SqlClient
Imports System.IO
Public Class BuyForm

    Dim con As New SqlConnection("server=LAPTOP-LKGQCRID\RASHEED;database=ShopQuik;integrated security=True")
    Private Sub CheckSpeci_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckSpeci.CheckedChanged
        Try
            If CheckSpeci.Checked = True Then
                lblspeci.Visible = True
                str = "Select * from ProductDetails where ProductName='" & LblName.Text & "'"
                table = Database(str)
                If table.Rows(0)(3) = "" Then
                    lblspeci.Text = "No Specifications..."
                Else
                    lblspeci.Text = table.Rows(0)(3)
                End If
            Else
                lblspeci.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BuyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        str = "Select * from UserDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
        table = Database(str)
        LblDeliver.Text = table.Rows(0)(3) + " " + table.Rows(0)(4).ToString
    End Sub

    Private Sub ButAddToCart_Click(sender As Object, e As EventArgs) Handles ButAddToCart.Click
        Dim conn As New SqlConnection("server=LAPTOP-LKGQCRID\RASHEED;database=ShopQuik;integrated security=True")
        If ButAddToCart.Name = "butremove" Then
            str = "select * from ProductDetails where ProductName='" & LblName.Text & "'"
            table = Database(str)
            Dim prid As String = table.Rows(0)(0)
            str = "delete from CartDetails where ProductID='" & prid & "'"

            Dim comd As New SqlCommand(str, conn)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim n As Integer = comd.ExecuteNonQuery
            If n > 0 Then
                Usermain.butcart.Text -= 1
                str = "update MainCartDetails set CartItems='" & Usermain.butcart.Text & "'"
                table = Database(str)
                panelswitch(UserMainHome, Usermain.usermainpanel)
            Else
                MsgBox("error")
            End If
        Else
            If cmbquantity.Text = "" Then
                MsgBox("please select the Quantity")
            Else
                str = "Select * from ProductDetails where ProductName='" & LblName.Text & "'"
                table = Database(str)
                Dim prdid As String = table.Rows(0)(0)
                Usermain.butcart.Text += 1
                    str = "insert into CartDetails values('" & LoginMain.TxtUserId.Text & "','" & prdid & "','" & cmbquantity.Text & "')"
                    table = Database(str)
                    str = "select * from MainCartDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
                    table = Database(str)
                    If table.Rows.Count > 0 Then
                        str = "update MainCartDetails set CartItems='" & Usermain.butcart.Text & "' where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
                        table = Database(str)
                    Else
                        str = "insert into MainCartDetails values('" & LoginMain.TxtUserId.Text & "','" & Usermain.butcart.Text & "')"
                        table = Database(str)
                    End If
                ButAddToCart.Enabled = False
            End If
        End If
    End Sub

    Private Sub ButBuyNow_Click(sender As Object, e As EventArgs) Handles ButBuyNow.Click
        If cmbquantity.Text = "" Then
            MessageBox.Show("please select the Quantity")
        Else
            Paymentmain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub butcustm_Click(sender As Object, e As EventArgs) Handles butcustm.Click
        str = "Select * from ProductDetails where ProductName='" & LblName.Text & "'"
        table = Database(str)
        Dim pro = table.Rows(0)(5)
        str = "Select * from Customization where ProductName='" & LblName.Text & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then
            MsgBox("'" & LblName.Text & "' already added to customization")
        Else
            str = "select * from Customization where ProductType='" & pro & "'"
            table = Database(str)
            If table.Rows.Count > 0 Then
                str = "delete from Customization where ProductType='" & pro & "'"
                Database(str)
            End If
            str = "insert into Customization values('" & LblName.Text & "','" & LoginMain.TxtUserId.Text & "','" & pro & "')"
            Database(str)
            MsgBox("Added to customization")
        End If
    End Sub

    Private Sub pctbuyform_Click(sender As Object, e As EventArgs) Handles pctbuyform.Click

    End Sub

    Private Sub cmbquantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbquantity.SelectedIndexChanged

    End Sub
End Class
