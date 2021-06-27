Imports System.Data.SqlClient
Imports System.IO
Public Class Usermain
    Public cont As New ContextMenuStrip
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If panel1.Width = 37 Then
            panel1.Width = 180
        Else
            panel1.Width = 37
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub MenuProfile_Click(sender As Object, e As EventArgs) Handles MenuProfile.Click
        panelswitch(UserProfile, usermainpanel)
        str = "select * from UserDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
        table = Database(str)
        RetrieveImage(pctmain, 0, 6)
        RetrieveImage(UserProfile.pctprofile, 0, 6)
    End Sub

    Private Sub UserMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UserMainHome.AutoScroll = True
            panelswitch(UserMainHome, usermainpanel)
            str = "select * from ProductDetails"
            product(str, UserMainHome)
            str = "select * from UserDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table = Database(str)
            RetrieveImage(pctmain, 0, 6)
            lblusernamemain.Text = table.Rows(0)(0)
            str = "select * from MainCartDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table = Database(str)
            butcart.Text = table.Rows(0)(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButHome_Click(sender As Object, e As EventArgs) Handles ButHome.Click
        BuyForm.ButAddToCart.Enabled = True
        BuyForm.ButAddToCart.Text = "Add To Cart"
        BuyForm.ButAddToCart.Name = "butcart"
        str = "select * from ProductDetails"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub MenuHome_Click(sender As Object, e As EventArgs) Handles MenuHome.Click
        BuyForm.ButAddToCart.Enabled = True
        BuyForm.ButAddToCart.Text = "Add To Cart"
        BuyForm.ButAddToCart.Name = "butcart"
        str = "select * from ProductDetails"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub MenuReset_Click(sender As Object, e As EventArgs) Handles MenuReset.Click
        panelswitch(ForgotPassword, usermainpanel)
        ForgotPassword.butcancel.Visible = False
    End Sub

    Private Sub Pctmain_Click(sender As Object, e As EventArgs) Handles pctmain.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        SelectImage(pctmain)
        Dim m As New MemoryStream
        m = ConvertImage(pctmain)
        Dim command As New SqlCommand("update UserDetails set UserImage=@UserImage where MobileNumber='" & LoginMain.TxtUserId.Text & "'", con)
        command.Parameters.Add("@UserImage", SqlDbType.Image).Value = m.ToArray
        Dim n As Integer = command.ExecuteNonQuery()
        If n > 0 Then
            UserProfile.pctprofile.BackgroundImage = pctmain.BackgroundImage
        End If
    End Sub

    Private Sub ButFashion_Click(sender As Object, e As EventArgs) Handles ButFashion.Click
        Men.Show(ButFashion, 0, ButFashion.Height)
    End Sub

    Private Sub ButElectronics_Click(sender As Object, e As EventArgs) Handles ButElectronics.Click
        Women.Show(ButElectronics, 0, ButFashion.Height)
    End Sub

    Private Sub MenuLogout_Click(sender As Object, e As EventArgs) Handles MenuLogout.Click
        Me.Hide()
        LoginMain.Show()
        LoginMain.radEnduser.Checked = False
        LoginMain.mainpanel.Height = 270
    End Sub

    Private Sub MenuFeedback_Click(sender As Object, e As EventArgs) Handles MenuFeedback.Click
        panelswitch(Feedback, usermainpanel)
    End Sub

    Private Sub MenuOrder_Click(sender As Object, e As EventArgs) Handles MenuOrder.Click
        str = "select ProductName,ProductPrice,Quantity,TotalAmount from OrderDetails where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
        table.Clear()
        table = Database(str)
        OrdersMain.DataGridView1.DataSource = table
        panelswitch(OrdersMain, usermainpanel)
    End Sub

    Private Sub Menucart_Click(sender As Object, e As EventArgs) Handles menucart.Click
        Dim table1 As New DataTable



        BuyForm.ButAddToCart.Enabled = True
        BuyForm.ButAddToCart.Text = "Remove From Cart"
        BuyForm.ButAddToCart.Name = "butremove"
        str = "select * from CartDetails Where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then

            dynamicbut(CartMain)
            panelswitch(CartMain, usermainpanel)

        Else
            CartMain.Controls.Clear()
            CartMain.Controls.Add(CartMain.lblcaption)
            CartMain.lblcaption.Visible = True
            panelswitch(CartMain, usermainpanel)
        End If
    End Sub

    Private Sub Butcart_Click(sender As Object, e As EventArgs) Handles butcart.Click
        BuyForm.ButAddToCart.Enabled = True
        BuyForm.ButAddToCart.Text = "Remove From Cart"
        BuyForm.ButAddToCart.Name = "butremove"
        str = "select * from CartDetails Where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then
            dynamicbut(CartMain)
            panelswitch(CartMain, usermainpanel)
        Else
            CartMain.Controls.Clear()
            CartMain.Controls.Add(CartMain.lblcaption)
            CartMain.lblcaption.Visible = True
            panelswitch(CartMain, usermainpanel)
        End If
    End Sub

    Private Sub Butlogout_Click(sender As Object, e As EventArgs) Handles butlogout.Click
        LoginMain.Show()
        Me.Hide()
    End Sub

    Private Sub Women_Click(sender As Object, e As EventArgs) Handles shirt.Click
        Dim type As String = "Shirts"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub pant_Click(sender As Object, e As EventArgs) Handles pant.Click
        Dim type As String = "Pants"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub sarie_Click(sender As Object, e As EventArgs) Handles sarie.Click
        Dim type As String = "Saries"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub dress_Click(sender As Object, e As EventArgs) Handles dress.Click
        Dim type As String = "Dress"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub custom_Click(sender As Object, e As EventArgs) Handles custom.Click
        Dim pant = "Pants"
        Dim shirt = "Shirts"
        str = "select * from Customization where ProductType='" & pant & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then
            str = "select * from ProductDetails where ProductName='" & table.Rows(0)(0) & "'"
            table = Database(str)
            RetrieveImage(customization.pctpant, 0, 6)
        End If
        str = "select * from Customization where ProductType='" & shirt & "'"
        table = Database(str)
        If table.Rows.Count > 0 Then
            str = "select * from ProductDetails where ProductName='" & table.Rows(0)(0) & "'"
            table = Database(str)
            RetrieveImage(customization.pctshirt, 0, 6)
        End If
        panelswitch(customization, usermainpanel)
    End Sub

    Private Sub TopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopsToolStripMenuItem.Click
        Dim type As String = "Tops"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)

    End Sub

    Private Sub BottomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomsToolStripMenuItem.Click
        Dim type As String = "Bottoms"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, usermainpanel)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub


End Class