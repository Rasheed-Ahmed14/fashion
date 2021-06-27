Public Class AdminMain

    Private Sub Butuser_Click(sender As Object, e As EventArgs) Handles butuser.Click
        Users.Show(butuser, 5, butuser.Height)
    End Sub

    Private Sub Menuproducts_Click(sender As Object, e As EventArgs) Handles Menuproducts.Click
        products.Show(Menuproducts, 0, Menuproducts.Height)
    End Sub

    Private Sub Prodview_Click(sender As Object, e As EventArgs) Handles prodview.Click
        Productsview.cmbtype.Text = ""
        panelswitch(Productsview, adminmainpanel)
    End Sub

    Private Sub Prodadd_Click(sender As Object, e As EventArgs) Handles prodadd.Click
        panelswitch(AddItems, adminmainpanel)
    End Sub

    Private Sub Prodsearch_Click(sender As Object, e As EventArgs) Handles prodsearch.Click
        str = "select * from ProductDetails "
        table.Clear()
        table = Database(str)
        productsearch.cmbproductid.Items.Clear()
        For i = 0 To table.Rows.Count - 1
            productsearch.cmbproductid.Items.Add(table.Rows(i)(0))
        Next
        productsearch.cmbproductid.Text = ""
        productsearch.productpanel.Visible = False
        table = Database(str)
        panelswitch(productsearch, adminmainpanel)
    End Sub

    Private Sub Userview_Click(sender As Object, e As EventArgs) Handles userview.Click
        str = "select * from UserDetails"
        table.Clear()
        table = Database(str)
        Dim imgc As New DataGridViewImageColumn
        viewuser.usergrid.RowTemplate.Height = 50
        viewuser.usergrid.DataSource = table
        imgc = viewuser.usergrid.Columns(6)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        panelswitch(viewuser, adminmainpanel)
    End Sub

    Private Sub Usersearch_Click(sender As Object, e As EventArgs) Handles usersearch.Click
        str = "select * from UserDetails "
        table.Clear()
        table = Database(str)
        searchuser.cmbnumber.Items.Clear()
        For i = 0 To table.Rows.Count - 1
            searchuser.cmbnumber.Items.Add(table.Rows(i)(1))
        Next
        searchuser.cmbnumber.Text = ""
        searchuser.userpanel.Visible = False
        panelswitch(searchuser, adminmainpanel)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        str = "select * from OrderDetails "
        table.Clear()
        table = Database(str)
        orderdetails.ordergrid.DataSource = table
        panelswitch(orderdetails, adminmainpanel)
    End Sub

    Private Sub Butpaym_Click(sender As Object, e As EventArgs) Handles butpaym.Click
        str = "select * from PaymentDetails "
        table.Clear()
        table = Database(str)
        paymentview.paymentgrid.DataSource = table
        panelswitch(paymentview, adminmainpanel)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub MenuLogout_Click(sender As Object, e As EventArgs) Handles MenuLogout.Click
        LoginMain.Show()
        Me.Hide()
        LoginMain.radAdmin.Checked = False
        LoginMain.mainpanel.Height = 270
    End Sub

    Private Sub MenuFeedback_Click(sender As Object, e As EventArgs) Handles MenuFeedback.Click
        str = "select * from feedback"
        table.Clear()
        table = Database(str)
        feedbackmain.feedgrid.DataSource = table
        panelswitch(feedbackmain, adminmainpanel)
    End Sub

    Private Sub MenuHome_Click(sender As Object, e As EventArgs) Handles MenuHome.Click
        panelswitch(Adminhome, adminmainpanel)
    End Sub
    Private Sub AdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelswitch(Adminhome, adminmainpanel)
    End Sub

    'Private Sub adminmainpanel_Paint(sender As Object, e As PaintEventArgs) Handles MyBasepanel.Paint

    'End Sub

    'Private Sub adminmainpanel_Paint_1(sender As Object, e As PaintEventArgs) Handles MyBasepanel.Paint, MyBasepanel.Paint

    'End Sub
End Class