<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchuser
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
        Me.userpanel = New System.Windows.Forms.Panel()
        Me.Butremove = New System.Windows.Forms.Button()
        Me.TxtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PctUserImage = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TxtPincode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbnumber = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.userpanel.SuspendLayout()
        CType(Me.PctUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userpanel
        '
        Me.userpanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.userpanel.Controls.Add(Me.Butremove)
        Me.userpanel.Controls.Add(Me.TxtAddress)
        Me.userpanel.Controls.Add(Me.PctUserImage)
        Me.userpanel.Controls.Add(Me.BunifuSeparator1)
        Me.userpanel.Controls.Add(Me.TxtPincode)
        Me.userpanel.Controls.Add(Me.TxtEmail)
        Me.userpanel.Controls.Add(Me.TxtName)
        Me.userpanel.Location = New System.Drawing.Point(148, 321)
        Me.userpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.userpanel.Name = "userpanel"
        Me.userpanel.Size = New System.Drawing.Size(1212, 593)
        Me.userpanel.TabIndex = 0
        Me.userpanel.Visible = False
        '
        'Butremove
        '
        Me.Butremove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Butremove.AutoEllipsis = True
        Me.Butremove.BackColor = System.Drawing.Color.DodgerBlue
        Me.Butremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butremove.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butremove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Butremove.Location = New System.Drawing.Point(596, 456)
        Me.Butremove.Margin = New System.Windows.Forms.Padding(4)
        Me.Butremove.Name = "Butremove"
        Me.Butremove.Size = New System.Drawing.Size(290, 83)
        Me.Butremove.TabIndex = 33
        Me.Butremove.Text = "Remove"
        Me.Butremove.UseVisualStyleBackColor = False
        '
        'TxtAddress
        '
        Me.TxtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAddress.HintText = ""
        Me.TxtAddress.isPassword = False
        Me.TxtAddress.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtAddress.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtAddress.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtAddress.LineThickness = 3
        Me.TxtAddress.Location = New System.Drawing.Point(527, 261)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtAddress.MaxLength = 32767
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(349, 60)
        Me.TxtAddress.TabIndex = 29
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PctUserImage
        '
        Me.PctUserImage.BackColor = System.Drawing.Color.White
        Me.PctUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PctUserImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PctUserImage.Location = New System.Drawing.Point(71, 150)
        Me.PctUserImage.Margin = New System.Windows.Forms.Padding(4)
        Me.PctUserImage.Name = "PctUserImage"
        Me.PctUserImage.Size = New System.Drawing.Size(271, 255)
        Me.PctUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctUserImage.TabIndex = 26
        Me.PctUserImage.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(422, 114)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(24, 314)
        Me.BunifuSeparator1.TabIndex = 25
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
        Me.TxtPincode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPincode.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPincode.HintText = ""
        Me.TxtPincode.isPassword = False
        Me.TxtPincode.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtPincode.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtPincode.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtPincode.LineThickness = 3
        Me.TxtPincode.Location = New System.Drawing.Point(527, 331)
        Me.TxtPincode.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtPincode.MaxLength = 32767
        Me.TxtPincode.Name = "TxtPincode"
        Me.TxtPincode.Size = New System.Drawing.Size(349, 41)
        Me.TxtPincode.TabIndex = 23
        Me.TxtPincode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtEmail
        '
        Me.TxtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TxtEmail.HintText = ""
        Me.TxtEmail.isPassword = False
        Me.TxtEmail.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtEmail.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtEmail.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtEmail.LineThickness = 3
        Me.TxtEmail.Location = New System.Drawing.Point(527, 209)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtEmail.MaxLength = 32767
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(349, 52)
        Me.TxtEmail.TabIndex = 20
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtName
        '
        Me.TxtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtName.HintForeColor = System.Drawing.Color.Empty
        Me.TxtName.HintText = ""
        Me.TxtName.isPassword = False
        Me.TxtName.LineFocusedColor = System.Drawing.Color.DodgerBlue
        Me.TxtName.LineIdleColor = System.Drawing.Color.Gold
        Me.TxtName.LineMouseHoverColor = System.Drawing.Color.MediumBlue
        Me.TxtName.LineThickness = 3
        Me.TxtName.Location = New System.Drawing.Point(527, 150)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtName.MaxLength = 32767
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(349, 49)
        Me.TxtName.TabIndex = 18
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 36)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Mobile Number"
        '
        'cmbnumber
        '
        Me.cmbnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbnumber.FormattingEnabled = True
        Me.cmbnumber.Location = New System.Drawing.Point(570, 28)
        Me.cmbnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbnumber.Name = "cmbnumber"
        Me.cmbnumber.Size = New System.Drawing.Size(291, 32)
        Me.cmbnumber.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(444, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 53)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'searchuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbnumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "searchuser"
        Me.Text = "usersearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.userpanel.ResumeLayout(False)
        CType(Me.PctUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userpanel As Panel
    Friend WithEvents TxtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PctUserImage As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TxtPincode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Butremove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbnumber As ComboBox
    Friend WithEvents Button1 As Button
End Class
