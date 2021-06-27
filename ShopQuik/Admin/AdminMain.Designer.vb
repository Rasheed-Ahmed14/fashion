<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.prodview = New System.Windows.Forms.ToolStripMenuItem()
        Me.prodadd = New System.Windows.Forms.ToolStripMenuItem()
        Me.prodsearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.products = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.userview = New System.Windows.Forms.ToolStripMenuItem()
        Me.usersearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.Users = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.butpaym = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.butuser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.MenuLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuFeedback = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Menuproducts = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.adminmainpanel = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.products.SuspendLayout()
        Me.Users.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ShopQuik.My.Resources.Resources.tcc
        Me.PictureBox1.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1897, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1942, 52)
        Me.Panel2.TabIndex = 7
        '
        'prodview
        '
        Me.prodview.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.prodview.BackColor = System.Drawing.Color.Azure
        Me.prodview.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodview.ForeColor = System.Drawing.Color.Black
        Me.prodview.Image = CType(resources.GetObject("prodview.Image"), System.Drawing.Image)
        Me.prodview.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.prodview.Name = "prodview"
        Me.prodview.Padding = New System.Windows.Forms.Padding(5)
        Me.prodview.Size = New System.Drawing.Size(178, 42)
        Me.prodview.Text = "View"
        Me.prodview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prodadd
        '
        Me.prodadd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.prodadd.BackColor = System.Drawing.Color.Azure
        Me.prodadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodadd.ForeColor = System.Drawing.Color.Black
        Me.prodadd.Image = CType(resources.GetObject("prodadd.Image"), System.Drawing.Image)
        Me.prodadd.Name = "prodadd"
        Me.prodadd.Padding = New System.Windows.Forms.Padding(5)
        Me.prodadd.Size = New System.Drawing.Size(178, 42)
        Me.prodadd.Text = "Add"
        '
        'prodsearch
        '
        Me.prodsearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.prodsearch.BackColor = System.Drawing.Color.Azure
        Me.prodsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodsearch.ForeColor = System.Drawing.Color.Black
        Me.prodsearch.Image = CType(resources.GetObject("prodsearch.Image"), System.Drawing.Image)
        Me.prodsearch.Name = "prodsearch"
        Me.prodsearch.Size = New System.Drawing.Size(168, 34)
        Me.prodsearch.Text = "Search"
        '
        'products
        '
        Me.products.AllowDrop = True
        Me.products.BackColor = System.Drawing.Color.Azure
        Me.products.DropShadowEnabled = False
        Me.products.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.products.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prodview, Me.prodadd, Me.prodsearch})
        Me.products.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.products.Name = "HomeAppliances"
        Me.products.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.products.Size = New System.Drawing.Size(169, 122)
        '
        'userview
        '
        Me.userview.BackColor = System.Drawing.Color.Azure
        Me.userview.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userview.ForeColor = System.Drawing.Color.Black
        Me.userview.Image = CType(resources.GetObject("userview.Image"), System.Drawing.Image)
        Me.userview.Name = "userview"
        Me.userview.Padding = New System.Windows.Forms.Padding(5)
        Me.userview.Size = New System.Drawing.Size(178, 42)
        Me.userview.Text = "View"
        Me.userview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.userview.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'usersearch
        '
        Me.usersearch.BackColor = System.Drawing.Color.Azure
        Me.usersearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usersearch.ForeColor = System.Drawing.Color.Black
        Me.usersearch.Image = CType(resources.GetObject("usersearch.Image"), System.Drawing.Image)
        Me.usersearch.Name = "usersearch"
        Me.usersearch.Padding = New System.Windows.Forms.Padding(5)
        Me.usersearch.Size = New System.Drawing.Size(178, 42)
        Me.usersearch.Text = "Search"
        Me.usersearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.usersearch.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Users
        '
        Me.Users.AllowDrop = True
        Me.Users.BackColor = System.Drawing.Color.Azure
        Me.Users.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Users.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userview, Me.usersearch})
        Me.Users.Name = "HomeAppliances"
        Me.Users.Size = New System.Drawing.Size(169, 88)
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Crimson
        Me.panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.panel1.Controls.Add(Me.butpaym)
        Me.panel1.Controls.Add(Me.PictureBox2)
        Me.panel1.Controls.Add(Me.butuser)
        Me.panel1.Controls.Add(Me.MenuButton)
        Me.panel1.Controls.Add(Me.BunifuSeparator1)
        Me.panel1.Controls.Add(Me.MenuLogout)
        Me.panel1.Controls.Add(Me.MenuFeedback)
        Me.panel1.Controls.Add(Me.Menuproducts)
        Me.panel1.Controls.Add(Me.MenuHome)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 52)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(271, 711)
        Me.panel1.TabIndex = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Orders"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(4, 404)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(232, 38)
        Me.BunifuFlatButton1.TabIndex = 18
        Me.BunifuFlatButton1.Text = "Orders"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'butpaym
        '
        Me.butpaym.Active = False
        Me.butpaym.Activecolor = System.Drawing.Color.Transparent
        Me.butpaym.BackColor = System.Drawing.Color.Transparent
        Me.butpaym.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butpaym.BorderRadius = 0
        Me.butpaym.ButtonText = "Payment Details"
        Me.butpaym.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butpaym.DisabledColor = System.Drawing.Color.Gray
        Me.butpaym.Iconcolor = System.Drawing.Color.Transparent
        Me.butpaym.Iconimage = CType(resources.GetObject("butpaym.Iconimage"), System.Drawing.Image)
        Me.butpaym.Iconimage_right = Nothing
        Me.butpaym.Iconimage_right_Selected = Nothing
        Me.butpaym.Iconimage_Selected = Nothing
        Me.butpaym.IconMarginLeft = 0
        Me.butpaym.IconMarginRight = 0
        Me.butpaym.IconRightVisible = True
        Me.butpaym.IconRightZoom = 0R
        Me.butpaym.IconVisible = True
        Me.butpaym.IconZoom = 60.0R
        Me.butpaym.IsTab = False
        Me.butpaym.Location = New System.Drawing.Point(4, 479)
        Me.butpaym.Margin = New System.Windows.Forms.Padding(5)
        Me.butpaym.Name = "butpaym"
        Me.butpaym.Normalcolor = System.Drawing.Color.Transparent
        Me.butpaym.OnHovercolor = System.Drawing.Color.Transparent
        Me.butpaym.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.butpaym.selected = False
        Me.butpaym.Size = New System.Drawing.Size(233, 38)
        Me.butpaym.TabIndex = 17
        Me.butpaym.Text = "Payment Details"
        Me.butpaym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.butpaym.Textcolor = System.Drawing.Color.White
        Me.butpaym.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.ShopQuik.My.Resources.Resources.tcc_1
        Me.PictureBox2.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'butuser
        '
        Me.butuser.Active = False
        Me.butuser.Activecolor = System.Drawing.Color.Transparent
        Me.butuser.BackColor = System.Drawing.Color.Transparent
        Me.butuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butuser.BorderRadius = 0
        Me.butuser.ButtonText = "Users"
        Me.butuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butuser.DisabledColor = System.Drawing.Color.Gray
        Me.butuser.Iconcolor = System.Drawing.Color.Transparent
        Me.butuser.Iconimage = CType(resources.GetObject("butuser.Iconimage"), System.Drawing.Image)
        Me.butuser.Iconimage_right = Nothing
        Me.butuser.Iconimage_right_Selected = Nothing
        Me.butuser.Iconimage_Selected = Nothing
        Me.butuser.IconMarginLeft = 0
        Me.butuser.IconMarginRight = 0
        Me.butuser.IconRightVisible = True
        Me.butuser.IconRightZoom = 0R
        Me.butuser.IconVisible = True
        Me.butuser.IconZoom = 60.0R
        Me.butuser.IsTab = False
        Me.butuser.Location = New System.Drawing.Point(-1, 245)
        Me.butuser.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.butuser.Name = "butuser"
        Me.butuser.Normalcolor = System.Drawing.Color.Transparent
        Me.butuser.OnHovercolor = System.Drawing.Color.Transparent
        Me.butuser.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.butuser.selected = False
        Me.butuser.Size = New System.Drawing.Size(236, 55)
        Me.butuser.TabIndex = 15
        Me.butuser.Text = "Users"
        Me.butuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.butuser.Textcolor = System.Drawing.Color.White
        Me.butuser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuButton
        '
        Me.MenuButton.Active = True
        Me.MenuButton.Activecolor = System.Drawing.Color.Transparent
        Me.MenuButton.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuButton.BorderRadius = 5
        Me.MenuButton.ButtonText = ""
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.DisabledColor = System.Drawing.Color.Transparent
        Me.MenuButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuButton.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuButton.Iconimage = Nothing
        Me.MenuButton.Iconimage_right = Nothing
        Me.MenuButton.Iconimage_right_Selected = Nothing
        Me.MenuButton.Iconimage_Selected = Nothing
        Me.MenuButton.IconMarginLeft = 0
        Me.MenuButton.IconMarginRight = 0
        Me.MenuButton.IconRightVisible = True
        Me.MenuButton.IconRightZoom = 0R
        Me.MenuButton.IconVisible = True
        Me.MenuButton.IconZoom = 70.0R
        Me.MenuButton.IsTab = True
        Me.MenuButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuButton.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuButton.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.MenuButton.selected = True
        Me.MenuButton.Size = New System.Drawing.Size(271, 44)
        Me.MenuButton.TabIndex = 3
        Me.MenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuButton.Textcolor = System.Drawing.Color.White
        Me.MenuButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(4, 158)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(259, 12)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'MenuLogout
        '
        Me.MenuLogout.Active = False
        Me.MenuLogout.Activecolor = System.Drawing.Color.Transparent
        Me.MenuLogout.BackColor = System.Drawing.Color.Transparent
        Me.MenuLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuLogout.BorderRadius = 0
        Me.MenuLogout.ButtonText = "Logout"
        Me.MenuLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuLogout.DisabledColor = System.Drawing.Color.Gray
        Me.MenuLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuLogout.Iconimage = CType(resources.GetObject("MenuLogout.Iconimage"), System.Drawing.Image)
        Me.MenuLogout.Iconimage_right = Nothing
        Me.MenuLogout.Iconimage_right_Selected = Nothing
        Me.MenuLogout.Iconimage_Selected = Nothing
        Me.MenuLogout.IconMarginLeft = 0
        Me.MenuLogout.IconMarginRight = 0
        Me.MenuLogout.IconRightVisible = True
        Me.MenuLogout.IconRightZoom = 0R
        Me.MenuLogout.IconVisible = True
        Me.MenuLogout.IconZoom = 60.0R
        Me.MenuLogout.IsTab = False
        Me.MenuLogout.Location = New System.Drawing.Point(5, 635)
        Me.MenuLogout.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuLogout.Name = "MenuLogout"
        Me.MenuLogout.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuLogout.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuLogout.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.MenuLogout.selected = False
        Me.MenuLogout.Size = New System.Drawing.Size(232, 38)
        Me.MenuLogout.TabIndex = 7
        Me.MenuLogout.Text = "Logout"
        Me.MenuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuLogout.Textcolor = System.Drawing.Color.White
        Me.MenuLogout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuFeedback
        '
        Me.MenuFeedback.Active = False
        Me.MenuFeedback.Activecolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.BackColor = System.Drawing.Color.Transparent
        Me.MenuFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuFeedback.BorderRadius = 0
        Me.MenuFeedback.ButtonText = "Feedbacks"
        Me.MenuFeedback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuFeedback.DisabledColor = System.Drawing.Color.Gray
        Me.MenuFeedback.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.Iconimage = CType(resources.GetObject("MenuFeedback.Iconimage"), System.Drawing.Image)
        Me.MenuFeedback.Iconimage_right = Nothing
        Me.MenuFeedback.Iconimage_right_Selected = Nothing
        Me.MenuFeedback.Iconimage_Selected = Nothing
        Me.MenuFeedback.IconMarginLeft = 0
        Me.MenuFeedback.IconMarginRight = 0
        Me.MenuFeedback.IconRightVisible = True
        Me.MenuFeedback.IconRightZoom = 0R
        Me.MenuFeedback.IconVisible = True
        Me.MenuFeedback.IconZoom = 60.0R
        Me.MenuFeedback.IsTab = False
        Me.MenuFeedback.Location = New System.Drawing.Point(4, 556)
        Me.MenuFeedback.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuFeedback.Name = "MenuFeedback"
        Me.MenuFeedback.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.MenuFeedback.selected = False
        Me.MenuFeedback.Size = New System.Drawing.Size(233, 38)
        Me.MenuFeedback.TabIndex = 4
        Me.MenuFeedback.Text = "Feedbacks"
        Me.MenuFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuFeedback.Textcolor = System.Drawing.Color.White
        Me.MenuFeedback.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Menuproducts
        '
        Me.Menuproducts.Active = False
        Me.Menuproducts.Activecolor = System.Drawing.Color.Transparent
        Me.Menuproducts.BackColor = System.Drawing.Color.Transparent
        Me.Menuproducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Menuproducts.BorderRadius = 0
        Me.Menuproducts.ButtonText = "Products"
        Me.Menuproducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menuproducts.DisabledColor = System.Drawing.Color.Gray
        Me.Menuproducts.Iconcolor = System.Drawing.Color.Transparent
        Me.Menuproducts.Iconimage = CType(resources.GetObject("Menuproducts.Iconimage"), System.Drawing.Image)
        Me.Menuproducts.Iconimage_right = Nothing
        Me.Menuproducts.Iconimage_right_Selected = Nothing
        Me.Menuproducts.Iconimage_Selected = Nothing
        Me.Menuproducts.IconMarginLeft = 0
        Me.Menuproducts.IconMarginRight = 0
        Me.Menuproducts.IconRightVisible = True
        Me.Menuproducts.IconRightZoom = 0R
        Me.Menuproducts.IconVisible = True
        Me.Menuproducts.IconZoom = 60.0R
        Me.Menuproducts.IsTab = False
        Me.Menuproducts.Location = New System.Drawing.Point(4, 329)
        Me.Menuproducts.Margin = New System.Windows.Forms.Padding(5)
        Me.Menuproducts.Name = "Menuproducts"
        Me.Menuproducts.Normalcolor = System.Drawing.Color.Transparent
        Me.Menuproducts.OnHovercolor = System.Drawing.Color.Transparent
        Me.Menuproducts.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.Menuproducts.selected = False
        Me.Menuproducts.Size = New System.Drawing.Size(232, 38)
        Me.Menuproducts.TabIndex = 3
        Me.Menuproducts.Text = "Products"
        Me.Menuproducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Menuproducts.Textcolor = System.Drawing.Color.White
        Me.Menuproducts.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuHome
        '
        Me.MenuHome.Active = False
        Me.MenuHome.Activecolor = System.Drawing.Color.Transparent
        Me.MenuHome.BackColor = System.Drawing.Color.Transparent
        Me.MenuHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuHome.BorderRadius = 0
        Me.MenuHome.ButtonText = "Home"
        Me.MenuHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuHome.DisabledColor = System.Drawing.Color.Gray
        Me.MenuHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuHome.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuHome.Iconimage = CType(resources.GetObject("MenuHome.Iconimage"), System.Drawing.Image)
        Me.MenuHome.Iconimage_right = Nothing
        Me.MenuHome.Iconimage_right_Selected = Nothing
        Me.MenuHome.Iconimage_Selected = Nothing
        Me.MenuHome.IconMarginLeft = 0
        Me.MenuHome.IconMarginRight = 0
        Me.MenuHome.IconRightVisible = True
        Me.MenuHome.IconRightZoom = 0R
        Me.MenuHome.IconVisible = True
        Me.MenuHome.IconZoom = 60.0R
        Me.MenuHome.IsTab = False
        Me.MenuHome.Location = New System.Drawing.Point(0, 188)
        Me.MenuHome.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuHome.Name = "MenuHome"
        Me.MenuHome.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuHome.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuHome.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.MenuHome.selected = False
        Me.MenuHome.Size = New System.Drawing.Size(232, 38)
        Me.MenuHome.TabIndex = 2
        Me.MenuHome.Text = "Home"
        Me.MenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuHome.Textcolor = System.Drawing.Color.White
        Me.MenuHome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'adminmainpanel
        '
        Me.adminmainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminmainpanel.Location = New System.Drawing.Point(271, 52)
        Me.adminmainpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.adminmainpanel.Name = "adminmainpanel"
        Me.adminmainpanel.Size = New System.Drawing.Size(1671, 711)
        Me.adminmainpanel.TabIndex = 11
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 763)
        Me.Controls.Add(Me.adminmainpanel)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminMain"
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.products.ResumeLayout(False)
        Me.Users.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents prodview As ToolStripMenuItem
    Friend WithEvents prodadd As ToolStripMenuItem
    Friend WithEvents prodsearch As ToolStripMenuItem
    Friend WithEvents products As ContextMenuStrip
    Friend WithEvents userview As ToolStripMenuItem
    Friend WithEvents usersearch As ToolStripMenuItem
    Friend WithEvents Users As ContextMenuStrip
    Friend WithEvents panel1 As Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents butpaym As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents butuser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents MenuLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuFeedback As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Menuproducts As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents adminmainpanel As Panel
End Class
