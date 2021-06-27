<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ButLogin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.sep1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.sep2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.ButSignUp = New System.Windows.Forms.Button()
        Me.lblnew = New System.Windows.Forms.Label()
        Me.lblor = New System.Windows.Forms.Label()
        Me.userpanel = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.linkforgotuser = New System.Windows.Forms.LinkLabel()
        Me.userhidepassword = New System.Windows.Forms.CheckBox()
        Me.TxtUserPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUserId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.radEnduser = New System.Windows.Forms.RadioButton()
        Me.adminpanel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkForgotadmin = New System.Windows.Forms.LinkLabel()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.TxtAdminPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtAdminId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainpanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.userpanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.adminpanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ShopQuik.My.Resources.Resources.sq_logo
        Me.PictureBox1.Location = New System.Drawing.Point(-15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.DodgerBlue
        Me.mainpanel.Controls.Add(Me.Panel5)
        Me.mainpanel.Controls.Add(Me.userpanel)
        Me.mainpanel.Controls.Add(Me.adminpanel)
        Me.mainpanel.Location = New System.Drawing.Point(301, 93)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(483, 160)
        Me.mainpanel.TabIndex = 31
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ButLogin)
        Me.Panel5.Controls.Add(Me.sep1)
        Me.Panel5.Controls.Add(Me.sep2)
        Me.Panel5.Controls.Add(Me.ButSignUp)
        Me.Panel5.Controls.Add(Me.lblnew)
        Me.Panel5.Controls.Add(Me.lblor)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(483, 60)
        Me.Panel5.TabIndex = 2
        '
        'ButLogin
        '
        Me.ButLogin.BackColor = System.Drawing.Color.Transparent
        Me.ButLogin.BackgroundImage = CType(resources.GetObject("ButLogin.BackgroundImage"), System.Drawing.Image)
        Me.ButLogin.ButtonText = "Login"
        Me.ButLogin.ButtonTextMarginLeft = 0
        Me.ButLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.ButLogin.DisabledFillColor = System.Drawing.Color.White
        Me.ButLogin.DisabledForecolor = System.Drawing.Color.White
        Me.ButLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButLogin.ForeColor = System.Drawing.Color.White
        Me.ButLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ButLogin.IconPadding = 10
        Me.ButLogin.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ButLogin.IdleBorderColor = System.Drawing.Color.Black
        Me.ButLogin.IdleBorderRadius = 1
        Me.ButLogin.IdleBorderThickness = 0
        Me.ButLogin.IdleFillColor = System.Drawing.Color.OrangeRed
        Me.ButLogin.IdleIconLeftImage = Nothing
        Me.ButLogin.IdleIconRightImage = Nothing
        Me.ButLogin.Location = New System.Drawing.Point(208, 18)
        Me.ButLogin.Name = "ButLogin"
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.BorderRadius = 1
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.ButLogin.onHoverState = StateProperties6
        Me.ButLogin.Size = New System.Drawing.Size(76, 31)
        Me.ButLogin.TabIndex = 4
        Me.ButLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sep1
        '
        Me.sep1.BackColor = System.Drawing.Color.Transparent
        Me.sep1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sep1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sep1.LineThickness = 1
        Me.sep1.Location = New System.Drawing.Point(34, 68)
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(191, 10)
        Me.sep1.TabIndex = 17
        Me.sep1.Transparency = 255
        Me.sep1.Vertical = False
        '
        'sep2
        '
        Me.sep2.BackColor = System.Drawing.Color.Transparent
        Me.sep2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sep2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sep2.LineThickness = 1
        Me.sep2.Location = New System.Drawing.Point(263, 68)
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(191, 10)
        Me.sep2.TabIndex = 19
        Me.sep2.Transparency = 255
        Me.sep2.Vertical = False
        '
        'ButSignUp
        '
        Me.ButSignUp.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButSignUp.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButSignUp.ForeColor = System.Drawing.Color.White
        Me.ButSignUp.Location = New System.Drawing.Point(290, 101)
        Me.ButSignUp.Name = "ButSignUp"
        Me.ButSignUp.Size = New System.Drawing.Size(98, 36)
        Me.ButSignUp.TabIndex = 21
        Me.ButSignUp.Text = "Sign Up"
        Me.ButSignUp.UseVisualStyleBackColor = False
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.BackColor = System.Drawing.Color.Transparent
        Me.lblnew.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnew.ForeColor = System.Drawing.Color.White
        Me.lblnew.Location = New System.Drawing.Point(39, 109)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(180, 23)
        Me.lblnew.TabIndex = 20
        Me.lblnew.Text = "New To ShopQuik?"
        '
        'lblor
        '
        Me.lblor.AutoSize = True
        Me.lblor.BackColor = System.Drawing.Color.Transparent
        Me.lblor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblor.Location = New System.Drawing.Point(235, 66)
        Me.lblor.Name = "lblor"
        Me.lblor.Size = New System.Drawing.Size(23, 13)
        Me.lblor.TabIndex = 18
        Me.lblor.Text = "OR"
        '
        'userpanel
        '
        Me.userpanel.Controls.Add(Me.GroupBox3)
        Me.userpanel.Controls.Add(Me.radEnduser)
        Me.userpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.userpanel.Location = New System.Drawing.Point(0, 50)
        Me.userpanel.Name = "userpanel"
        Me.userpanel.Size = New System.Drawing.Size(483, 50)
        Me.userpanel.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.linkforgotuser)
        Me.GroupBox3.Controls.Add(Me.userhidepassword)
        Me.GroupBox3.Controls.Add(Me.TxtUserPassword)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtUserId)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 168)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "User ID"
        '
        'linkforgotuser
        '
        Me.linkforgotuser.AutoSize = True
        Me.linkforgotuser.BackColor = System.Drawing.Color.Transparent
        Me.linkforgotuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkforgotuser.ForeColor = System.Drawing.Color.DarkMagenta
        Me.linkforgotuser.LinkColor = System.Drawing.Color.OldLace
        Me.linkforgotuser.Location = New System.Drawing.Point(271, 128)
        Me.linkforgotuser.Name = "linkforgotuser"
        Me.linkforgotuser.Size = New System.Drawing.Size(117, 16)
        Me.linkforgotuser.TabIndex = 31
        Me.linkforgotuser.TabStop = True
        Me.linkforgotuser.Text = "Forgot Password?"
        '
        'userhidepassword
        '
        Me.userhidepassword.AutoSize = True
        Me.userhidepassword.BackColor = System.Drawing.Color.Transparent
        Me.userhidepassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userhidepassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.userhidepassword.Location = New System.Drawing.Point(9, 143)
        Me.userhidepassword.Name = "userhidepassword"
        Me.userhidepassword.Size = New System.Drawing.Size(56, 20)
        Me.userhidepassword.TabIndex = 34
        Me.userhidepassword.Text = "Hide"
        Me.userhidepassword.UseVisualStyleBackColor = False
        '
        'TxtUserPassword
        '
        Me.TxtUserPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtUserPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtUserPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtUserPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUserPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtUserPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtUserPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TxtUserPassword.HintText = ""
        Me.TxtUserPassword.isPassword = False
        Me.TxtUserPassword.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtUserPassword.LineIdleColor = System.Drawing.Color.Fuchsia
        Me.TxtUserPassword.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtUserPassword.LineThickness = 3
        Me.TxtUserPassword.Location = New System.Drawing.Point(133, 86)
        Me.TxtUserPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUserPassword.MaxLength = 32767
        Me.TxtUserPassword.Name = "TxtUserPassword"
        Me.TxtUserPassword.Size = New System.Drawing.Size(262, 33)
        Me.TxtUserPassword.TabIndex = 35
        Me.TxtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Password"
        '
        'TxtUserId
        '
        Me.TxtUserId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtUserId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtUserId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtUserId.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtUserId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUserId.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtUserId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtUserId.HintForeColor = System.Drawing.Color.Empty
        Me.TxtUserId.HintText = ""
        Me.TxtUserId.isPassword = False
        Me.TxtUserId.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtUserId.LineIdleColor = System.Drawing.Color.Fuchsia
        Me.TxtUserId.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtUserId.LineThickness = 3
        Me.TxtUserId.Location = New System.Drawing.Point(133, 22)
        Me.TxtUserId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUserId.MaxLength = 32767
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.Size = New System.Drawing.Size(262, 33)
        Me.TxtUserId.TabIndex = 36
        Me.TxtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'radEnduser
        '
        Me.radEnduser.AutoSize = True
        Me.radEnduser.BackColor = System.Drawing.Color.Transparent
        Me.radEnduser.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEnduser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radEnduser.Location = New System.Drawing.Point(30, 9)
        Me.radEnduser.Name = "radEnduser"
        Me.radEnduser.Size = New System.Drawing.Size(124, 28)
        Me.radEnduser.TabIndex = 29
        Me.radEnduser.Text = "End User"
        Me.radEnduser.UseVisualStyleBackColor = False
        '
        'adminpanel
        '
        Me.adminpanel.Controls.Add(Me.GroupBox2)
        Me.adminpanel.Controls.Add(Me.radAdmin)
        Me.adminpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.adminpanel.Location = New System.Drawing.Point(0, 0)
        Me.adminpanel.Name = "adminpanel"
        Me.adminpanel.Size = New System.Drawing.Size(483, 50)
        Me.adminpanel.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LinkForgotadmin)
        Me.GroupBox2.Controls.Add(Me.ShowPassword)
        Me.GroupBox2.Controls.Add(Me.TxtAdminPassword)
        Me.GroupBox2.Controls.Add(Me.TxtAdminId)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 166)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.White
        Me.lblid.Location = New System.Drawing.Point(6, 26)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(106, 24)
        Me.lblid.TabIndex = 13
        Me.lblid.Text = "Admin ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password"
        '
        'LinkForgotadmin
        '
        Me.LinkForgotadmin.AutoSize = True
        Me.LinkForgotadmin.BackColor = System.Drawing.Color.Transparent
        Me.LinkForgotadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkForgotadmin.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LinkForgotadmin.LinkColor = System.Drawing.Color.OldLace
        Me.LinkForgotadmin.Location = New System.Drawing.Point(265, 123)
        Me.LinkForgotadmin.Name = "LinkForgotadmin"
        Me.LinkForgotadmin.Size = New System.Drawing.Size(117, 16)
        Me.LinkForgotadmin.TabIndex = 5
        Me.LinkForgotadmin.TabStop = True
        Me.LinkForgotadmin.Text = "Forgot Password?"
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ShowPassword.Location = New System.Drawing.Point(10, 139)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(56, 20)
        Me.ShowPassword.TabIndex = 22
        Me.ShowPassword.Text = "Hide"
        Me.ShowPassword.UseVisualStyleBackColor = False
        '
        'TxtAdminPassword
        '
        Me.TxtAdminPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtAdminPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtAdminPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAdminPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtAdminPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAdminPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtAdminPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAdminPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAdminPassword.HintText = ""
        Me.TxtAdminPassword.isPassword = False
        Me.TxtAdminPassword.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtAdminPassword.LineIdleColor = System.Drawing.Color.Fuchsia
        Me.TxtAdminPassword.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtAdminPassword.LineThickness = 3
        Me.TxtAdminPassword.Location = New System.Drawing.Point(127, 81)
        Me.TxtAdminPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAdminPassword.MaxLength = 32767
        Me.TxtAdminPassword.Name = "TxtAdminPassword"
        Me.TxtAdminPassword.Size = New System.Drawing.Size(262, 33)
        Me.TxtAdminPassword.TabIndex = 23
        Me.TxtAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtAdminId
        '
        Me.TxtAdminId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtAdminId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtAdminId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAdminId.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtAdminId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAdminId.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtAdminId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAdminId.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAdminId.HintText = ""
        Me.TxtAdminId.isPassword = False
        Me.TxtAdminId.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtAdminId.LineIdleColor = System.Drawing.Color.Fuchsia
        Me.TxtAdminId.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtAdminId.LineThickness = 3
        Me.TxtAdminId.Location = New System.Drawing.Point(127, 17)
        Me.TxtAdminId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAdminId.MaxLength = 32767
        Me.TxtAdminId.Name = "TxtAdminId"
        Me.TxtAdminId.Size = New System.Drawing.Size(262, 33)
        Me.TxtAdminId.TabIndex = 24
        Me.TxtAdminId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.BackColor = System.Drawing.Color.Transparent
        Me.radAdmin.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radAdmin.Location = New System.Drawing.Point(30, 12)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(88, 28)
        Me.radAdmin.TabIndex = 31
        Me.radAdmin.Text = "Admin"
        Me.radAdmin.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShopQuik.My.Resources.Resources.images
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainpanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.userpanel.ResumeLayout(False)
        Me.userpanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.adminpanel.ResumeLayout(False)
        Me.adminpanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mainpanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ButLogin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents sep1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents sep2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents ButSignUp As Button
    Friend WithEvents lblnew As Label
    Friend WithEvents lblor As Label
    Friend WithEvents userpanel As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents linkforgotuser As LinkLabel
    Friend WithEvents userhidepassword As CheckBox
    Friend WithEvents TxtUserPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUserId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents radEnduser As RadioButton
    Friend WithEvents adminpanel As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkForgotadmin As LinkLabel
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents TxtAdminPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtAdminId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents radAdmin As RadioButton
End Class
