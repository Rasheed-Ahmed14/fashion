<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserCreate))
        Me.lblpas = New System.Windows.Forms.Label()
        Me.butimage = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.TxtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PctUserImage = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TxtPincode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtConfirmPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtMobileNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblpas
        '
        Me.lblpas.AutoSize = True
        Me.lblpas.BackColor = System.Drawing.Color.Transparent
        Me.lblpas.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblpas.Location = New System.Drawing.Point(772, 793)
        Me.lblpas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpas.Name = "lblpas"
        Me.lblpas.Size = New System.Drawing.Size(180, 20)
        Me.lblpas.TabIndex = 36
        Me.lblpas.Text = "Already a customer?"
        '
        'butimage
        '
        Me.butimage.BackColor = System.Drawing.Color.DarkCyan
        Me.butimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butimage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butimage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.butimage.Location = New System.Drawing.Point(334, 627)
        Me.butimage.Margin = New System.Windows.Forms.Padding(4)
        Me.butimage.Name = "butimage"
        Me.butimage.Size = New System.Drawing.Size(139, 39)
        Me.butimage.TabIndex = 35
        Me.butimage.Text = "Image"
        Me.butimage.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ShopQuik.My.Resources.Resources.tcc_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(860, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(482, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ShowPassword.Location = New System.Drawing.Point(1159, 658)
        Me.ShowPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(151, 24)
        Me.ShowPassword.TabIndex = 33
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = False
        '
        'TxtAddress
        '
        Me.TxtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAddress.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAddress.HintText = "Enter Address "
        Me.TxtAddress.isPassword = False
        Me.TxtAddress.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtAddress.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtAddress.LineThickness = 3
        Me.TxtAddress.Location = New System.Drawing.Point(776, 483)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtAddress.MaxLength = 32767
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(349, 59)
        Me.TxtAddress.TabIndex = 32
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(543, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Sign Up To Start your Shop at TCC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(349, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 36)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Welcome  "
        '
        'ButLogin
        '
        Me.ButLogin.BackColor = System.Drawing.Color.DarkCyan
        Me.ButLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButLogin.Location = New System.Drawing.Point(446, 702)
        Me.ButLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.ButLogin.Name = "ButLogin"
        Me.ButLogin.Size = New System.Drawing.Size(139, 39)
        Me.ButLogin.TabIndex = 29
        Me.ButLogin.Text = "Login"
        Me.ButLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(160, 711)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Already a customer?"
        '
        'PctUserImage
        '
        Me.PctUserImage.BackColor = System.Drawing.Color.Transparent
        Me.PctUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PctUserImage.Image = CType(resources.GetObject("PctUserImage.Image"), System.Drawing.Image)
        Me.PctUserImage.Location = New System.Drawing.Point(253, 320)
        Me.PctUserImage.Margin = New System.Windows.Forms.Padding(4)
        Me.PctUserImage.Name = "PctUserImage"
        Me.PctUserImage.Size = New System.Drawing.Size(299, 272)
        Me.PctUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctUserImage.TabIndex = 27
        Me.PctUserImage.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(700, 303)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(24, 551)
        Me.BunifuSeparator1.TabIndex = 26
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'TxtPincode
        '
        Me.TxtPincode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtPincode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtPincode.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtPincode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPincode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtPincode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPincode.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPincode.HintText = "Enter PINCODE of your Locality"
        Me.TxtPincode.isPassword = False
        Me.TxtPincode.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPincode.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtPincode.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtPincode.LineThickness = 3
        Me.TxtPincode.Location = New System.Drawing.Point(776, 570)
        Me.TxtPincode.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtPincode.MaxLength = 6
        Me.TxtPincode.Name = "TxtPincode"
        Me.TxtPincode.Size = New System.Drawing.Size(349, 48)
        Me.TxtPincode.TabIndex = 25
        Me.TxtPincode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtConfirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtConfirmPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConfirmPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtConfirmPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TxtConfirmPassword.HintText = "Confirm Password"
        Me.TxtConfirmPassword.isPassword = False
        Me.TxtConfirmPassword.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtConfirmPassword.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtConfirmPassword.LineThickness = 3
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(776, 718)
        Me.TxtConfirmPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtConfirmPassword.MaxLength = 10
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(349, 50)
        Me.TxtConfirmPassword.TabIndex = 24
        Me.TxtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtPassword
        '
        Me.TxtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TxtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPassword.HintText = "Enter New Password"
        Me.TxtPassword.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TxtPassword.isPassword = False
        Me.TxtPassword.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPassword.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtPassword.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtPassword.LineThickness = 3
        Me.TxtPassword.Location = New System.Drawing.Point(776, 643)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtPassword.MaxLength = 10
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(349, 56)
        Me.TxtPassword.TabIndex = 23
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtEmail
        '
        Me.TxtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TxtEmail.HintText = "Enter Email Id "
        Me.TxtEmail.isPassword = False
        Me.TxtEmail.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtEmail.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtEmail.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtEmail.LineThickness = 3
        Me.TxtEmail.Location = New System.Drawing.Point(776, 424)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtEmail.MaxLength = 32767
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(349, 49)
        Me.TxtEmail.TabIndex = 22
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtMobileNumber
        '
        Me.TxtMobileNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtMobileNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtMobileNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMobileNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtMobileNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtMobileNumber.HintForeColor = System.Drawing.Color.Empty
        Me.TxtMobileNumber.HintText = "Please enter the Mobile Number "
        Me.TxtMobileNumber.isPassword = False
        Me.TxtMobileNumber.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtMobileNumber.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtMobileNumber.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtMobileNumber.LineThickness = 3
        Me.TxtMobileNumber.Location = New System.Drawing.Point(776, 354)
        Me.TxtMobileNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtMobileNumber.MaxLength = 10
        Me.TxtMobileNumber.Name = "TxtMobileNumber"
        Me.TxtMobileNumber.Size = New System.Drawing.Size(349, 60)
        Me.TxtMobileNumber.TabIndex = 21
        Me.TxtMobileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtName
        '
        Me.TxtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtName.HintForeColor = System.Drawing.Color.Empty
        Me.TxtName.HintText = "Please enter the Name"
        Me.TxtName.isPassword = False
        Me.TxtName.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtName.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtName.LineMouseHoverColor = System.Drawing.Color.GhostWhite
        Me.TxtName.LineThickness = 3
        Me.TxtName.Location = New System.Drawing.Point(776, 293)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtName.MaxLength = 32767
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(372, 51)
        Me.TxtName.TabIndex = 20
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(875, 843)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 53)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UserCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1937, 922)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblpas)
        Me.Controls.Add(Me.butimage)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PctUserImage)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.TxtPincode)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtMobileNumber)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserCreate1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpas As Label
    Friend WithEvents butimage As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents TxtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PctUserImage As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TxtPincode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtConfirmPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtMobileNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
End Class
