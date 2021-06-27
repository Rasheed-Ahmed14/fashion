Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Paymentmain
    Dim paymenttype As String
    Dim ordno As String
    Private Sub Raddebit_CheckedChanged(sender As Object, e As EventArgs) Handles raddebit.CheckedChanged
        If debitpanel.Height = 50 Then
            paymentmainpanel.Height = 340
            mainpanel.Height = 340
            debitpanel.Height = 150
            radnetbank.Checked = False
            radcash.Checked = False
        Else
            debitpanel.Height = 50
        End If
        txtusername.Text = UserMain.lblusernamemain.Text
    End Sub

    Private Sub Radnetbank_CheckedChanged(sender As Object, e As EventArgs) Handles radnetbank.CheckedChanged
        If netbankpanel.Height = 45 Then
            paymentmainpanel.Height = 30
            mainpanel.Height = 340
            netbankpanel.Height = 100
            raddebit.Checked = False
            radcash.Checked = False
        Else
            netbankpanel.Height = 45
        End If
    End Sub

    Private Sub Radcash_CheckedChanged(sender As Object, e As EventArgs) Handles radcash.CheckedChanged
        raddebit.Checked = False
        radnetbank.Checked = False
        paymentmainpanel.Height = 320
        mainpanel.Height = 320
    End Sub

    Private Sub Butcontinue_Click(sender As Object, e As EventArgs) Handles butcontinue.Click
        If radcash.Checked = True Or raddebit.Checked = True Or radnetbank.Checked = True Then
            If radcash.Checked = True Then
                paymenttype = "Cash on Delivery"
            ElseIf raddebit.Checked = True Then
                paymenttype = "Debit/Credit/Atm Card"
                If txtcardnumber.Text = "" Then
                    MsgBox("please enter the Card Number")
                ElseIf len(txtcardnumber.Text) = 16 Then
                    MsgBox("invalid card number")
                End If
            Else radnetbank.Checked = True
                paymenttype = "Net Banking"
                If cmbbank.SelectedItem Is Nothing Then
                    MsgBox("please select the bank")
                End If
            End If
            mainpanel.Height = 380
            lblquan.Text = BuyForm.cmbquantity.Text
            lblproductname.Text = BuyForm.LblName.Text
            lblprice.Text = BuyForm.lblprice.Text
            str = "Select * from UserDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table = Database(str)
            lblshippingaddress.Text = table.Rows(0)(0) + " ," + BuyForm.LblDeliver.Text
            lbltotalamount.Text = Val(BuyForm.lblprice.Text) * Val(BuyForm.cmbquantity.Text)
            mainlabel.Text = "Order Now"
            lblpaymenttype.Text = paymenttype
            paymentmainpanel.Visible = False
            mainorderpanel.Visible = True
        Else
            MessageBox.Show("please select the payment type")
        End If
    End Sub
    Private Sub Butend_Click(sender As Object, e As EventArgs) Handles butend.Click
        End
    End Sub

    Private Sub Paymentmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Butplaceorder_Click(sender As Object, e As EventArgs) Handles butplaceorder.Click
        Dim ran As New Random()
Temp:
        ordno = "ORD" & ran.Next(0, 999)
        str = "select * from OrderDetails where OrderID='" & ordno & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then
            GoTo Temp
        End If
        Dim sta As String
        If lblpaymenttype.Text = "Cash on Delivery" Then
            If lblshippingdate.Text = Date.Now.ToString("dd MMM yyyy") Then
                sta = "Payed"
            Else
                sta = "Payed"
            End If
        Else
            sta = "Payed"
        End If
        str = "select * from ProductDetails where ProductName='" & lblproductname.Text & "'"
        table = Database(str)
        Dim prdid As String = table.Rows(0)(0)
        str = "insert into OrderDetails values('" & ordno & "','" & prdid & "','" & LoginMain.TxtUserId.Text & "','" & lblprice.Text & "','" & lblquan.Text & "','" & lbltotalamount.Text & "','" & lblproductname.Text & "')"
        Dim cmd As New SqlCommand(str, con)
        Dim n As Integer = cmd.ExecuteNonQuery()
        If n > 0 Then
            str = "insert into PaymentDetails values('" & LoginMain.TxtUserId.Text & "','" & lblpaymenttype.Text & "','" & sta & "','" & lbltotalamount.Text & "')"
            table.Clear()
            table = Database(str)
            str = "select * from ProductDetails where ProductName='" & lblproductname.Text & "'"
            table.Clear()
            table = Database(str)
            Dim quan As Integer = table.Rows(0)(4)
            quan -= Val(lblquan.Text)
            If quan = 0 Then
                str = "delete from ProductDetails where ProductName='" & lblproductname.Text & "'"
                table.Clear()
                table = Database(str)
                str = "delete from CartDetails where ProductID='" & prdid & "'"
                table.Clear()
                table = Database(str)
                Dim cart As Integer = Usermain.butcart.Text
                If cart > 0 Then
                    str = "update MainCartDetails set CartItems='" & cart - 1 & "' where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
                    table.Clear()
                    table = Database(str)
                End If
            End If
            str = "update ProductDetails set Quantity='" & quan & "' where ProductName='" & lblproductname.Text & "'"
            table.Clear()
            table = Database(str)
            MessageBox.Show("your order is successful")
            str = "select * from MainCartDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table.Clear()
            table = Database(str)
            Usermain.butcart.Text = table.Rows(0)(1)
            Me.Close()
            str = "select * from ProductDetails"
            product(str, UserMainHome)
            panelswitch(UserMainHome, Usermain.usermainpanel)
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblshippingdate.Text = Date.Now.AddDays(5).ToString("dd MMM yyyy")
    End Sub

    Private Sub Butback_Click(sender As Object, e As EventArgs) Handles butback.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        paymentmainpanel.Visible = True
        mainorderpanel.Visible = False
    End Sub

    Private Sub txtcardnumber_VisibleChanged(sender As Object, e As EventArgs) Handles txtcardnumber.VisibleChanged
        If Regex.IsMatch(txtcardnumber.Text, "[^0-9\s\b$]") Then
            MsgBox("enter proper card number")
            txtcardnumber.Focus()
        End If
    End Sub
End Class