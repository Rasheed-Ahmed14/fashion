<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usermain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usermain))
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.butlogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.custom = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButElectronics = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButFashion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblusernamemain = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.menucart = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pctmain = New System.Windows.Forms.PictureBox()
        Me.MenuButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuReset = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuFeedback = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuOrder = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuProfile = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.butcart = New System.Windows.Forms.Button()
        Me.usermainpanel = New System.Windows.Forms.Panel()
        Me.Men = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pant = New System.Windows.Forms.ToolStripMenuItem()
        Me.shirt = New System.Windows.Forms.ToolStripMenuItem()
        Me.Women = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.sarie = New System.Windows.Forms.ToolStripMenuItem()
        Me.dress = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.pctmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Men.SuspendLayout()
        Me.Women.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(7, 250)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(272, 12)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1895, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'butlogout
        '
        Me.butlogout.BackColor = System.Drawing.Color.Transparent
        Me.butlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.butlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.butlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butlogout.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butlogout.ForeColor = System.Drawing.Color.White
        Me.butlogout.Location = New System.Drawing.Point(1629, 12)
        Me.butlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.butlogout.Name = "butlogout"
        Me.butlogout.Size = New System.Drawing.Size(52, 44)
        Me.butlogout.TabIndex = 22
        Me.butlogout.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel3.Controls.Add(Me.custom)
        Me.Panel3.Controls.Add(Me.butlogout)
        Me.Panel3.Controls.Add(Me.ButElectronics)
        Me.Panel3.Controls.Add(Me.ButFashion)
        Me.Panel3.Controls.Add(Me.ButHome)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(281, 40)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1661, 60)
        Me.Panel3.TabIndex = 7
        '
        'custom
        '
        Me.custom.Active = False
        Me.custom.Activecolor = System.Drawing.Color.Transparent
        Me.custom.BackColor = System.Drawing.Color.Transparent
        Me.custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.custom.BorderRadius = 0
        Me.custom.ButtonText = "Customization"
        Me.custom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.custom.DisabledColor = System.Drawing.Color.Gray
        Me.custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.custom.Iconcolor = System.Drawing.Color.Transparent
        Me.custom.Iconimage = Nothing
        Me.custom.Iconimage_right = Nothing
        Me.custom.Iconimage_right_Selected = Nothing
        Me.custom.Iconimage_Selected = Nothing
        Me.custom.IconMarginLeft = 0
        Me.custom.IconMarginRight = 0
        Me.custom.IconRightVisible = True
        Me.custom.IconRightZoom = 0R
        Me.custom.IconVisible = True
        Me.custom.IconZoom = 60.0R
        Me.custom.IsTab = False
        Me.custom.Location = New System.Drawing.Point(1029, 10)
        Me.custom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.custom.Name = "custom"
        Me.custom.Normalcolor = System.Drawing.Color.Transparent
        Me.custom.OnHovercolor = System.Drawing.Color.Transparent
        Me.custom.OnHoverTextColor = System.Drawing.Color.RoyalBlue
        Me.custom.selected = False
        Me.custom.Size = New System.Drawing.Size(272, 44)
        Me.custom.TabIndex = 24
        Me.custom.Text = "Customization"
        Me.custom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.custom.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.custom.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButElectronics
        '
        Me.ButElectronics.Active = False
        Me.ButElectronics.Activecolor = System.Drawing.Color.Transparent
        Me.ButElectronics.BackColor = System.Drawing.Color.Transparent
        Me.ButElectronics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButElectronics.BorderRadius = 0
        Me.ButElectronics.ButtonText = "Women"
        Me.ButElectronics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButElectronics.DisabledColor = System.Drawing.Color.Gray
        Me.ButElectronics.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButElectronics.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButElectronics.Iconcolor = System.Drawing.Color.Transparent
        Me.ButElectronics.Iconimage = Nothing
        Me.ButElectronics.Iconimage_right = Nothing
        Me.ButElectronics.Iconimage_right_Selected = Nothing
        Me.ButElectronics.Iconimage_Selected = Nothing
        Me.ButElectronics.IconMarginLeft = 0
        Me.ButElectronics.IconMarginRight = 0
        Me.ButElectronics.IconRightVisible = True
        Me.ButElectronics.IconRightZoom = 0R
        Me.ButElectronics.IconVisible = True
        Me.ButElectronics.IconZoom = 60.0R
        Me.ButElectronics.IsTab = False
        Me.ButElectronics.Location = New System.Drawing.Point(659, 7)
        Me.ButElectronics.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ButElectronics.Name = "ButElectronics"
        Me.ButElectronics.Normalcolor = System.Drawing.Color.Transparent
        Me.ButElectronics.OnHovercolor = System.Drawing.Color.Transparent
        Me.ButElectronics.OnHoverTextColor = System.Drawing.Color.RoyalBlue
        Me.ButElectronics.selected = False
        Me.ButElectronics.Size = New System.Drawing.Size(225, 44)
        Me.ButElectronics.TabIndex = 7
        Me.ButElectronics.Text = "Women"
        Me.ButElectronics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButElectronics.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.ButElectronics.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButFashion
        '
        Me.ButFashion.Active = False
        Me.ButFashion.Activecolor = System.Drawing.Color.Transparent
        Me.ButFashion.BackColor = System.Drawing.Color.Transparent
        Me.ButFashion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButFashion.BorderRadius = 0
        Me.ButFashion.ButtonText = "Men"
        Me.ButFashion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButFashion.DisabledColor = System.Drawing.Color.Gray
        Me.ButFashion.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButFashion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButFashion.Iconcolor = System.Drawing.Color.Transparent
        Me.ButFashion.Iconimage = Nothing
        Me.ButFashion.Iconimage_right = Nothing
        Me.ButFashion.Iconimage_right_Selected = Nothing
        Me.ButFashion.Iconimage_Selected = Nothing
        Me.ButFashion.IconMarginLeft = 0
        Me.ButFashion.IconMarginRight = 0
        Me.ButFashion.IconRightVisible = True
        Me.ButFashion.IconRightZoom = 0R
        Me.ButFashion.IconVisible = True
        Me.ButFashion.IconZoom = 60.0R
        Me.ButFashion.IsTab = False
        Me.ButFashion.Location = New System.Drawing.Point(366, 0)
        Me.ButFashion.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ButFashion.Name = "ButFashion"
        Me.ButFashion.Normalcolor = System.Drawing.Color.Transparent
        Me.ButFashion.OnHovercolor = System.Drawing.Color.Transparent
        Me.ButFashion.OnHoverTextColor = System.Drawing.Color.RoyalBlue
        Me.ButFashion.selected = False
        Me.ButFashion.Size = New System.Drawing.Size(230, 60)
        Me.ButFashion.TabIndex = 5
        Me.ButFashion.Text = "Men"
        Me.ButFashion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButFashion.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.ButFashion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButHome
        '
        Me.ButHome.Active = False
        Me.ButHome.Activecolor = System.Drawing.Color.Transparent
        Me.ButHome.BackColor = System.Drawing.Color.Transparent
        Me.ButHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButHome.BorderRadius = 0
        Me.ButHome.ButtonText = "Home"
        Me.ButHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButHome.DisabledColor = System.Drawing.Color.Gray
        Me.ButHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButHome.Iconcolor = System.Drawing.Color.Transparent
        Me.ButHome.Iconimage = Nothing
        Me.ButHome.Iconimage_right = Nothing
        Me.ButHome.Iconimage_right_Selected = Nothing
        Me.ButHome.Iconimage_Selected = Nothing
        Me.ButHome.IconMarginLeft = 0
        Me.ButHome.IconMarginRight = 0
        Me.ButHome.IconRightVisible = True
        Me.ButHome.IconRightZoom = 0R
        Me.ButHome.IconVisible = True
        Me.ButHome.IconZoom = 60.0R
        Me.ButHome.IsTab = False
        Me.ButHome.Location = New System.Drawing.Point(93, 6)
        Me.ButHome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ButHome.Name = "ButHome"
        Me.ButHome.Normalcolor = System.Drawing.Color.Transparent
        Me.ButHome.OnHovercolor = System.Drawing.Color.Transparent
        Me.ButHome.OnHoverTextColor = System.Drawing.Color.RoyalBlue
        Me.ButHome.selected = False
        Me.ButHome.Size = New System.Drawing.Size(198, 50)
        Me.ButHome.TabIndex = 4
        Me.ButHome.Text = "Home"
        Me.ButHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButHome.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.ButHome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblusernamemain
        '
        Me.lblusernamemain.AutoSize = True
        Me.lblusernamemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusernamemain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblusernamemain.Location = New System.Drawing.Point(88, 221)
        Me.lblusernamemain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusernamemain.Name = "lblusernamemain"
        Me.lblusernamemain.Size = New System.Drawing.Size(66, 24)
        Me.lblusernamemain.TabIndex = 0
        Me.lblusernamemain.Text = "Label1"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.menucart)
        Me.panel1.Controls.Add(Me.lblusernamemain)
        Me.panel1.Controls.Add(Me.pctmain)
        Me.panel1.Controls.Add(Me.MenuButton)
        Me.panel1.Controls.Add(Me.BunifuSeparator1)
        Me.panel1.Controls.Add(Me.MenuLogout)
        Me.panel1.Controls.Add(Me.MenuReset)
        Me.panel1.Controls.Add(Me.MenuFeedback)
        Me.panel1.Controls.Add(Me.MenuOrder)
        Me.panel1.Controls.Add(Me.MenuHome)
        Me.panel1.Controls.Add(Me.MenuProfile)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 40)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(281, 620)
        Me.panel1.TabIndex = 6
        '
        'menucart
        '
        Me.menucart.Active = False
        Me.menucart.Activecolor = System.Drawing.Color.Transparent
        Me.menucart.BackColor = System.Drawing.Color.Transparent
        Me.menucart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menucart.BorderRadius = 0
        Me.menucart.ButtonText = "Your Cart"
        Me.menucart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menucart.DisabledColor = System.Drawing.Color.Gray
        Me.menucart.Iconcolor = System.Drawing.Color.Transparent
        Me.menucart.Iconimage = CType(resources.GetObject("menucart.Iconimage"), System.Drawing.Image)
        Me.menucart.Iconimage_right = Nothing
        Me.menucart.Iconimage_right_Selected = Nothing
        Me.menucart.Iconimage_Selected = Nothing
        Me.menucart.IconMarginLeft = 0
        Me.menucart.IconMarginRight = 0
        Me.menucart.IconRightVisible = True
        Me.menucart.IconRightZoom = 0R
        Me.menucart.IconVisible = True
        Me.menucart.IconZoom = 60.0R
        Me.menucart.IsTab = False
        Me.menucart.Location = New System.Drawing.Point(-1, 448)
        Me.menucart.Margin = New System.Windows.Forms.Padding(5)
        Me.menucart.Name = "menucart"
        Me.menucart.Normalcolor = System.Drawing.Color.Transparent
        Me.menucart.OnHovercolor = System.Drawing.Color.Transparent
        Me.menucart.OnHoverTextColor = System.Drawing.Color.Black
        Me.menucart.selected = False
        Me.menucart.Size = New System.Drawing.Size(243, 38)
        Me.menucart.TabIndex = 16
        Me.menucart.Text = "Your Cart"
        Me.menucart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.menucart.Textcolor = System.Drawing.Color.White
        Me.menucart.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pctmain
        '
        Me.pctmain.Location = New System.Drawing.Point(56, 57)
        Me.pctmain.Margin = New System.Windows.Forms.Padding(4)
        Me.pctmain.Name = "pctmain"
        Me.pctmain.Size = New System.Drawing.Size(148, 150)
        Me.pctmain.TabIndex = 15
        Me.pctmain.TabStop = False
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
        Me.MenuButton.Iconimage_right = CType(resources.GetObject("MenuButton.Iconimage_right"), System.Drawing.Image)
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
        Me.MenuButton.Size = New System.Drawing.Size(279, 50)
        Me.MenuButton.TabIndex = 3
        Me.MenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuButton.Textcolor = System.Drawing.Color.White
        Me.MenuButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MenuLogout.Location = New System.Drawing.Point(-1, 560)
        Me.MenuLogout.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuLogout.Name = "MenuLogout"
        Me.MenuLogout.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuLogout.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuLogout.OnHoverTextColor = System.Drawing.Color.Black
        Me.MenuLogout.selected = False
        Me.MenuLogout.Size = New System.Drawing.Size(241, 38)
        Me.MenuLogout.TabIndex = 7
        Me.MenuLogout.Text = "Logout"
        Me.MenuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuLogout.Textcolor = System.Drawing.Color.White
        Me.MenuLogout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuReset
        '
        Me.MenuReset.Active = False
        Me.MenuReset.Activecolor = System.Drawing.Color.Transparent
        Me.MenuReset.AllowDrop = True
        Me.MenuReset.BackColor = System.Drawing.Color.Transparent
        Me.MenuReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuReset.BorderRadius = 0
        Me.MenuReset.ButtonText = "Reset Password"
        Me.MenuReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuReset.DisabledColor = System.Drawing.Color.Gray
        Me.MenuReset.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuReset.Iconimage = CType(resources.GetObject("MenuReset.Iconimage"), System.Drawing.Image)
        Me.MenuReset.Iconimage_right = Nothing
        Me.MenuReset.Iconimage_right_Selected = Nothing
        Me.MenuReset.Iconimage_Selected = Nothing
        Me.MenuReset.IconMarginLeft = 0
        Me.MenuReset.IconMarginRight = 0
        Me.MenuReset.IconRightVisible = True
        Me.MenuReset.IconRightZoom = 0R
        Me.MenuReset.IconVisible = True
        Me.MenuReset.IconZoom = 60.0R
        Me.MenuReset.IsTab = False
        Me.MenuReset.Location = New System.Drawing.Point(0, 506)
        Me.MenuReset.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuReset.Name = "MenuReset"
        Me.MenuReset.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuReset.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuReset.OnHoverTextColor = System.Drawing.Color.Black
        Me.MenuReset.selected = False
        Me.MenuReset.Size = New System.Drawing.Size(241, 37)
        Me.MenuReset.TabIndex = 6
        Me.MenuReset.Text = "Reset Password"
        Me.MenuReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuReset.Textcolor = System.Drawing.Color.White
        Me.MenuReset.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuFeedback
        '
        Me.MenuFeedback.Active = False
        Me.MenuFeedback.Activecolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.BackColor = System.Drawing.Color.Transparent
        Me.MenuFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuFeedback.BorderRadius = 0
        Me.MenuFeedback.ButtonText = "Feedback"
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
        Me.MenuFeedback.Location = New System.Drawing.Point(0, 626)
        Me.MenuFeedback.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuFeedback.Name = "MenuFeedback"
        Me.MenuFeedback.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuFeedback.OnHoverTextColor = System.Drawing.Color.Black
        Me.MenuFeedback.selected = False
        Me.MenuFeedback.Size = New System.Drawing.Size(243, 38)
        Me.MenuFeedback.TabIndex = 4
        Me.MenuFeedback.Text = "Feedback"
        Me.MenuFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuFeedback.Textcolor = System.Drawing.Color.White
        Me.MenuFeedback.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuOrder
        '
        Me.MenuOrder.Active = False
        Me.MenuOrder.Activecolor = System.Drawing.Color.Transparent
        Me.MenuOrder.BackColor = System.Drawing.Color.Transparent
        Me.MenuOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuOrder.BorderRadius = 0
        Me.MenuOrder.ButtonText = "Your Orders"
        Me.MenuOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuOrder.DisabledColor = System.Drawing.Color.Gray
        Me.MenuOrder.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuOrder.Iconimage = CType(resources.GetObject("MenuOrder.Iconimage"), System.Drawing.Image)
        Me.MenuOrder.Iconimage_right = Nothing
        Me.MenuOrder.Iconimage_right_Selected = Nothing
        Me.MenuOrder.Iconimage_Selected = Nothing
        Me.MenuOrder.IconMarginLeft = 0
        Me.MenuOrder.IconMarginRight = 0
        Me.MenuOrder.IconRightVisible = True
        Me.MenuOrder.IconRightZoom = 0R
        Me.MenuOrder.IconVisible = True
        Me.MenuOrder.IconZoom = 60.0R
        Me.MenuOrder.IsTab = False
        Me.MenuOrder.Location = New System.Drawing.Point(-1, 389)
        Me.MenuOrder.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuOrder.Name = "MenuOrder"
        Me.MenuOrder.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuOrder.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuOrder.OnHoverTextColor = System.Drawing.Color.Black
        Me.MenuOrder.selected = False
        Me.MenuOrder.Size = New System.Drawing.Size(241, 38)
        Me.MenuOrder.TabIndex = 3
        Me.MenuOrder.Text = "Your Orders"
        Me.MenuOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuOrder.Textcolor = System.Drawing.Color.White
        Me.MenuOrder.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MenuHome.Location = New System.Drawing.Point(0, 272)
        Me.MenuHome.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuHome.Name = "MenuHome"
        Me.MenuHome.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuHome.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuHome.OnHoverTextColor = System.Drawing.Color.Black
        Me.MenuHome.selected = False
        Me.MenuHome.Size = New System.Drawing.Size(241, 38)
        Me.MenuHome.TabIndex = 2
        Me.MenuHome.Text = "Home"
        Me.MenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuHome.Textcolor = System.Drawing.Color.White
        Me.MenuHome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuProfile
        '
        Me.MenuProfile.Active = False
        Me.MenuProfile.Activecolor = System.Drawing.Color.Transparent
        Me.MenuProfile.BackColor = System.Drawing.Color.Transparent
        Me.MenuProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuProfile.BorderRadius = 0
        Me.MenuProfile.ButtonText = "Your Profile"
        Me.MenuProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuProfile.DisabledColor = System.Drawing.Color.Gray
        Me.MenuProfile.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuProfile.Iconimage = CType(resources.GetObject("MenuProfile.Iconimage"), System.Drawing.Image)
        Me.MenuProfile.Iconimage_right = Nothing
        Me.MenuProfile.Iconimage_right_Selected = Nothing
        Me.MenuProfile.Iconimage_Selected = Nothing
        Me.MenuProfile.IconMarginLeft = 0
        Me.MenuProfile.IconMarginRight = 0
        Me.MenuProfile.IconRightVisible = True
        Me.MenuProfile.IconRightZoom = 0R
        Me.MenuProfile.IconVisible = True
        Me.MenuProfile.IconZoom = 60.0R
        Me.MenuProfile.IsTab = False
        Me.MenuProfile.Location = New System.Drawing.Point(-1, 330)
        Me.MenuProfile.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuProfile.Name = "MenuProfile"
        Me.MenuProfile.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuProfile.OnHovercolor = System.Drawing.Color.Transparent
        Me.MenuProfile.OnHoverTextColor = System.Drawing.Color.Black
        Me.MenuProfile.selected = False
        Me.MenuProfile.Size = New System.Drawing.Size(243, 38)
        Me.MenuProfile.TabIndex = 1
        Me.MenuProfile.Text = "Your Profile"
        Me.MenuProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenuProfile.Textcolor = System.Drawing.Color.White
        Me.MenuProfile.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.butcart)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1942, 40)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ShopQuik.My.Resources.Resources.tcc
        Me.PictureBox1.Image = Global.ShopQuik.My.Resources.Resources.tcc
        Me.PictureBox1.Location = New System.Drawing.Point(849, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'butcart
        '
        Me.butcart.BackColor = System.Drawing.Color.Transparent
        Me.butcart.BackgroundImage = CType(resources.GetObject("butcart.BackgroundImage"), System.Drawing.Image)
        Me.butcart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.butcart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.butcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butcart.ForeColor = System.Drawing.Color.White
        Me.butcart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.butcart.Location = New System.Drawing.Point(1838, 4)
        Me.butcart.Margin = New System.Windows.Forms.Padding(4)
        Me.butcart.Name = "butcart"
        Me.butcart.Size = New System.Drawing.Size(49, 33)
        Me.butcart.TabIndex = 17
        Me.butcart.Text = "0"
        Me.butcart.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.butcart.UseVisualStyleBackColor = False
        '
        'usermainpanel
        '
        Me.usermainpanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.usermainpanel.AllowDrop = True
        Me.usermainpanel.AutoScroll = True
        Me.usermainpanel.AutoScrollMargin = New System.Drawing.Size(0, 100)
        Me.usermainpanel.AutoScrollMinSize = New System.Drawing.Size(0, 100)
        Me.usermainpanel.AutoSize = True
        Me.usermainpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.usermainpanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.usermainpanel.Location = New System.Drawing.Point(281, 100)
        Me.usermainpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.usermainpanel.Name = "usermainpanel"
        Me.usermainpanel.Size = New System.Drawing.Size(0, 0)
        Me.usermainpanel.TabIndex = 8
        '
        'Men
        '
        Me.Men.AccessibleName = "ButFashion"
        Me.Men.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Men.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pant, Me.shirt})
        Me.Men.Name = "Men"
        Me.Men.Size = New System.Drawing.Size(115, 52)
        '
        'pant
        '
        Me.pant.Name = "pant"
        Me.pant.Size = New System.Drawing.Size(114, 24)
        Me.pant.Text = "Pants"
        '
        'shirt
        '
        Me.shirt.Name = "shirt"
        Me.shirt.Size = New System.Drawing.Size(114, 24)
        Me.shirt.Text = "Shirts"
        '
        'Women
        '
        Me.Women.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Women.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sarie, Me.dress, Me.TopsToolStripMenuItem, Me.BottomsToolStripMenuItem})
        Me.Women.Name = "Women"
        Me.Women.Size = New System.Drawing.Size(135, 100)
        '
        'sarie
        '
        Me.sarie.Name = "sarie"
        Me.sarie.Size = New System.Drawing.Size(134, 24)
        Me.sarie.Text = "Saries"
        '
        'dress
        '
        Me.dress.Name = "dress"
        Me.dress.Size = New System.Drawing.Size(134, 24)
        Me.dress.Text = "Dress"
        '
        'TopsToolStripMenuItem
        '
        Me.TopsToolStripMenuItem.Name = "TopsToolStripMenuItem"
        Me.TopsToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.TopsToolStripMenuItem.Text = "Tops"
        '
        'BottomsToolStripMenuItem
        '
        Me.BottomsToolStripMenuItem.Name = "BottomsToolStripMenuItem"
        Me.BottomsToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.BottomsToolStripMenuItem.Text = "Bottoms"
        '
        'Usermain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 660)
        Me.Controls.Add(Me.usermainpanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usermain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pctmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Men.ResumeLayout(False)
        Me.Women.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Button1 As Button
    Friend WithEvents butcart As Button
    Friend WithEvents menucart As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuReset As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuFeedback As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuOrder As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuProfile As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents butlogout As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButElectronics As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButFashion As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblusernamemain As Label
    Friend WithEvents MenuButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents usermainpanel As Panel
    Friend WithEvents pctmain As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Men As ContextMenuStrip
    Friend WithEvents Women As ContextMenuStrip
    Friend WithEvents pant As ToolStripMenuItem
    Friend WithEvents shirt As ToolStripMenuItem
    Friend WithEvents sarie As ToolStripMenuItem
    Friend WithEvents dress As ToolStripMenuItem
    Friend WithEvents custom As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TopsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BottomsToolStripMenuItem As ToolStripMenuItem
End Class
