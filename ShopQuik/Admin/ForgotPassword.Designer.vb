<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butcancel = New System.Windows.Forms.Button()
        Me.TxtNewPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.TxtMobileEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButResetPasword = New System.Windows.Forms.Button()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.TxtConfirmPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.Controls.Add(Me.butcancel)
        Me.Panel1.Controls.Add(Me.TxtNewPassword)
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.TxtMobileEmail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ButResetPasword)
        Me.Panel1.Controls.Add(Me.ShowPassword)
        Me.Panel1.Controls.Add(Me.TxtConfirmPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(241, 76)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 666)
        Me.Panel1.TabIndex = 0
        '
        'butcancel
        '
        Me.butcancel.BackColor = System.Drawing.Color.RoyalBlue
        Me.butcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butcancel.ForeColor = System.Drawing.Color.White
        Me.butcancel.Location = New System.Drawing.Point(393, 484)
        Me.butcancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butcancel.Name = "butcancel"
        Me.butcancel.Size = New System.Drawing.Size(176, 52)
        Me.butcancel.TabIndex = 21
        Me.butcancel.Text = "Cancel"
        Me.butcancel.UseVisualStyleBackColor = False
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNewPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtNewPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TxtNewPassword.HintText = ""
        Me.TxtNewPassword.isPassword = False
        Me.TxtNewPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.TxtNewPassword.LineIdleColor = System.Drawing.Color.White
        Me.TxtNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TxtNewPassword.LineThickness = 3
        Me.TxtNewPassword.Location = New System.Drawing.Point(65, 176)
        Me.TxtNewPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtNewPassword.MaxLength = 10
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(327, 41)
        Me.TxtNewPassword.TabIndex = 20
        Me.TxtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.Transparent
        Me.lblid.Location = New System.Drawing.Point(60, 32)
        Me.lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(210, 32)
        Me.lblid.TabIndex = 19
        Me.lblid.Text = "Mobile Number"
        '
        'TxtMobileEmail
        '
        Me.TxtMobileEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtMobileEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtMobileEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtMobileEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMobileEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtMobileEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtMobileEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TxtMobileEmail.HintText = ""
        Me.TxtMobileEmail.isPassword = False
        Me.TxtMobileEmail.LineFocusedColor = System.Drawing.Color.Blue
        Me.TxtMobileEmail.LineIdleColor = System.Drawing.Color.White
        Me.TxtMobileEmail.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TxtMobileEmail.LineThickness = 3
        Me.TxtMobileEmail.Location = New System.Drawing.Point(65, 79)
        Me.TxtMobileEmail.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtMobileEmail.MaxLength = 10
        Me.TxtMobileEmail.Name = "TxtMobileEmail"
        Me.TxtMobileEmail.Size = New System.Drawing.Size(327, 41)
        Me.TxtMobileEmail.TabIndex = 2
        Me.TxtMobileEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(60, 353)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(461, 46)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Great Passwords use upper and lower case " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "characters,numbers,and symbols like @&" &
    "$#."
        '
        'ButResetPasword
        '
        Me.ButResetPasword.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButResetPasword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButResetPasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButResetPasword.ForeColor = System.Drawing.Color.White
        Me.ButResetPasword.Location = New System.Drawing.Point(115, 482)
        Me.ButResetPasword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButResetPasword.Name = "ButResetPasword"
        Me.ButResetPasword.Size = New System.Drawing.Size(176, 52)
        Me.ButResetPasword.TabIndex = 17
        Me.ButResetPasword.Text = "Reset Password"
        Me.ButResetPasword.UseVisualStyleBackColor = False
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ShowPassword.Location = New System.Drawing.Point(447, 176)
        Me.ShowPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(92, 35)
        Me.ShowPassword.TabIndex = 16
        Me.ShowPassword.Text = "Hide"
        Me.ShowPassword.UseVisualStyleBackColor = False
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
        Me.TxtConfirmPassword.HintText = ""
        Me.TxtConfirmPassword.isPassword = False
        Me.TxtConfirmPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.TxtConfirmPassword.LineIdleColor = System.Drawing.Color.White
        Me.TxtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TxtConfirmPassword.LineThickness = 3
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(65, 283)
        Me.TxtConfirmPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtConfirmPassword.MaxLength = 10
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(327, 41)
        Me.TxtConfirmPassword.TabIndex = 3
        Me.TxtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(60, 249)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(60, 142)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(800, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(380, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Reset Your Password below"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ShopQuik.My.Resources.Resources.OIP__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1045, 76)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(496, 666)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassword"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtConfirmPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtMobileEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButResetPasword As Button
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents TxtNewPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents butcancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
