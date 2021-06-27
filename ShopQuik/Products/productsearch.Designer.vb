<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productsearch
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
        Me.productpanel = New System.Windows.Forms.Panel()
        Me.butupdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txttype = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PctProduct = New System.Windows.Forms.PictureBox()
        Me.TxtSpecification = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TxtQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ButImage = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TxtPrice = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.butremove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TxtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbproductid = New System.Windows.Forms.ComboBox()
        Me.butserach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.productpanel.SuspendLayout()
        CType(Me.PctProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productpanel
        '
        Me.productpanel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.productpanel.Controls.Add(Me.butupdate)
        Me.productpanel.Controls.Add(Me.txttype)
        Me.productpanel.Controls.Add(Me.PctProduct)
        Me.productpanel.Controls.Add(Me.TxtSpecification)
        Me.productpanel.Controls.Add(Me.BunifuSeparator1)
        Me.productpanel.Controls.Add(Me.BunifuSeparator3)
        Me.productpanel.Controls.Add(Me.TxtQuantity)
        Me.productpanel.Controls.Add(Me.ButImage)
        Me.productpanel.Controls.Add(Me.TxtPrice)
        Me.productpanel.Controls.Add(Me.butremove)
        Me.productpanel.Controls.Add(Me.TxtName)
        Me.productpanel.Controls.Add(Me.Label2)
        Me.productpanel.Location = New System.Drawing.Point(16, 144)
        Me.productpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.productpanel.Name = "productpanel"
        Me.productpanel.Size = New System.Drawing.Size(1412, 670)
        Me.productpanel.TabIndex = 0
        '
        'butupdate
        '
        Me.butupdate.Active = False
        Me.butupdate.Activecolor = System.Drawing.Color.DarkOrange
        Me.butupdate.BackColor = System.Drawing.Color.DarkOrange
        Me.butupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butupdate.BorderRadius = 5
        Me.butupdate.ButtonText = "Update Product"
        Me.butupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butupdate.DisabledColor = System.Drawing.Color.Black
        Me.butupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butupdate.Iconcolor = System.Drawing.Color.Transparent
        Me.butupdate.Iconimage = Nothing
        Me.butupdate.Iconimage_right = Nothing
        Me.butupdate.Iconimage_right_Selected = Nothing
        Me.butupdate.Iconimage_Selected = Nothing
        Me.butupdate.IconMarginLeft = 0
        Me.butupdate.IconMarginRight = 0
        Me.butupdate.IconRightVisible = True
        Me.butupdate.IconRightZoom = 0R
        Me.butupdate.IconVisible = True
        Me.butupdate.IconZoom = 90.0R
        Me.butupdate.IsTab = False
        Me.butupdate.Location = New System.Drawing.Point(945, 442)
        Me.butupdate.Margin = New System.Windows.Forms.Padding(5)
        Me.butupdate.Name = "butupdate"
        Me.butupdate.Normalcolor = System.Drawing.Color.DarkOrange
        Me.butupdate.OnHovercolor = System.Drawing.Color.Gold
        Me.butupdate.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butupdate.selected = False
        Me.butupdate.Size = New System.Drawing.Size(220, 52)
        Me.butupdate.TabIndex = 44
        Me.butupdate.Text = "Update Product"
        Me.butupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.butupdate.Textcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.butupdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txttype
        '
        Me.txttype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txttype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txttype.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txttype.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txttype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttype.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txttype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txttype.HintForeColor = System.Drawing.Color.White
        Me.txttype.HintText = ""
        Me.txttype.isPassword = False
        Me.txttype.LineFocusedColor = System.Drawing.SystemColors.HotTrack
        Me.txttype.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.txttype.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.txttype.LineThickness = 3
        Me.txttype.Location = New System.Drawing.Point(419, 117)
        Me.txttype.Margin = New System.Windows.Forms.Padding(5)
        Me.txttype.MaxLength = 32767
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(267, 41)
        Me.txttype.TabIndex = 43
        Me.txttype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PctProduct
        '
        Me.PctProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PctProduct.Location = New System.Drawing.Point(25, 117)
        Me.PctProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.PctProduct.Name = "PctProduct"
        Me.PctProduct.Size = New System.Drawing.Size(237, 289)
        Me.PctProduct.TabIndex = 32
        Me.PctProduct.TabStop = False
        '
        'TxtSpecification
        '
        Me.TxtSpecification.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtSpecification.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtSpecification.Location = New System.Drawing.Point(926, 117)
        Me.TxtSpecification.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSpecification.Multiline = True
        Me.TxtSpecification.Name = "TxtSpecification"
        Me.TxtSpecification.Size = New System.Drawing.Size(260, 294)
        Me.TxtSpecification.TabIndex = 40
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(781, 117)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(15, 341)
        Me.BunifuSeparator1.TabIndex = 35
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(303, 117)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(15, 341)
        Me.BunifuSeparator3.TabIndex = 41
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'TxtQuantity
        '
        Me.TxtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtQuantity.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtQuantity.HintForeColor = System.Drawing.Color.White
        Me.TxtQuantity.HintText = ""
        Me.TxtQuantity.isPassword = False
        Me.TxtQuantity.LineFocusedColor = System.Drawing.SystemColors.HotTrack
        Me.TxtQuantity.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtQuantity.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.TxtQuantity.LineThickness = 3
        Me.TxtQuantity.Location = New System.Drawing.Point(419, 353)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtQuantity.MaxLength = 32767
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(267, 41)
        Me.TxtQuantity.TabIndex = 42
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ButImage
        '
        Me.ButImage.Active = False
        Me.ButImage.Activecolor = System.Drawing.Color.DarkOrange
        Me.ButImage.BackColor = System.Drawing.Color.DarkOrange
        Me.ButImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButImage.BorderRadius = 5
        Me.ButImage.ButtonText = "Image"
        Me.ButImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButImage.DisabledColor = System.Drawing.Color.Black
        Me.ButImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButImage.Iconcolor = System.Drawing.Color.Transparent
        Me.ButImage.Iconimage = Nothing
        Me.ButImage.Iconimage_right = Nothing
        Me.ButImage.Iconimage_right_Selected = Nothing
        Me.ButImage.Iconimage_Selected = Nothing
        Me.ButImage.IconMarginLeft = 0
        Me.ButImage.IconMarginRight = 0
        Me.ButImage.IconRightVisible = True
        Me.ButImage.IconRightZoom = 0R
        Me.ButImage.IconVisible = True
        Me.ButImage.IconZoom = 90.0R
        Me.ButImage.IsTab = False
        Me.ButImage.Location = New System.Drawing.Point(25, 442)
        Me.ButImage.Margin = New System.Windows.Forms.Padding(5)
        Me.ButImage.Name = "ButImage"
        Me.ButImage.Normalcolor = System.Drawing.Color.DarkOrange
        Me.ButImage.OnHovercolor = System.Drawing.Color.Gold
        Me.ButImage.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButImage.selected = False
        Me.ButImage.Size = New System.Drawing.Size(220, 52)
        Me.ButImage.TabIndex = 37
        Me.ButImage.Text = "Image"
        Me.ButImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButImage.Textcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButImage.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TxtPrice
        '
        Me.TxtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtPrice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPrice.HintForeColor = System.Drawing.Color.White
        Me.TxtPrice.HintText = ""
        Me.TxtPrice.isPassword = False
        Me.TxtPrice.LineFocusedColor = System.Drawing.SystemColors.HotTrack
        Me.TxtPrice.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtPrice.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.TxtPrice.LineThickness = 3
        Me.TxtPrice.Location = New System.Drawing.Point(419, 271)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtPrice.MaxLength = 32767
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(267, 41)
        Me.TxtPrice.TabIndex = 34
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'butremove
        '
        Me.butremove.Active = False
        Me.butremove.Activecolor = System.Drawing.Color.DarkOrange
        Me.butremove.BackColor = System.Drawing.Color.DarkOrange
        Me.butremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butremove.BorderRadius = 5
        Me.butremove.ButtonText = "Remove Product"
        Me.butremove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butremove.DisabledColor = System.Drawing.Color.Black
        Me.butremove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butremove.Iconcolor = System.Drawing.Color.Transparent
        Me.butremove.Iconimage = Nothing
        Me.butremove.Iconimage_right = Nothing
        Me.butremove.Iconimage_right_Selected = Nothing
        Me.butremove.Iconimage_Selected = Nothing
        Me.butremove.IconMarginLeft = 0
        Me.butremove.IconMarginRight = 0
        Me.butremove.IconRightVisible = True
        Me.butremove.IconRightZoom = 0R
        Me.butremove.IconVisible = True
        Me.butremove.IconZoom = 90.0R
        Me.butremove.IsTab = False
        Me.butremove.Location = New System.Drawing.Point(432, 442)
        Me.butremove.Margin = New System.Windows.Forms.Padding(5)
        Me.butremove.Name = "butremove"
        Me.butremove.Normalcolor = System.Drawing.Color.DarkOrange
        Me.butremove.OnHovercolor = System.Drawing.Color.Gold
        Me.butremove.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butremove.selected = False
        Me.butremove.Size = New System.Drawing.Size(220, 52)
        Me.butremove.TabIndex = 38
        Me.butremove.Text = "Remove Product"
        Me.butremove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.butremove.Textcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.butremove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TxtName
        '
        Me.TxtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtName.HintForeColor = System.Drawing.Color.White
        Me.TxtName.HintText = ""
        Me.TxtName.isPassword = False
        Me.TxtName.LineFocusedColor = System.Drawing.SystemColors.HotTrack
        Me.TxtName.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtName.LineMouseHoverColor = System.Drawing.Color.Orange
        Me.TxtName.LineThickness = 3
        Me.TxtName.Location = New System.Drawing.Point(419, 197)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtName.MaxLength = 32767
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(267, 41)
        Me.TxtName.TabIndex = 33
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 33)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Other Specifications:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(305, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product ID"
        '
        'cmbproductid
        '
        Me.cmbproductid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproductid.FormattingEnabled = True
        Me.cmbproductid.Location = New System.Drawing.Point(499, 26)
        Me.cmbproductid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbproductid.Name = "cmbproductid"
        Me.cmbproductid.Size = New System.Drawing.Size(313, 32)
        Me.cmbproductid.TabIndex = 6
        '
        'butserach
        '
        Me.butserach.Active = False
        Me.butserach.Activecolor = System.Drawing.Color.DarkOrange
        Me.butserach.BackColor = System.Drawing.Color.DarkOrange
        Me.butserach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butserach.BorderRadius = 0
        Me.butserach.ButtonText = "Search"
        Me.butserach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butserach.DisabledColor = System.Drawing.Color.Gray
        Me.butserach.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butserach.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butserach.Iconcolor = System.Drawing.Color.Transparent
        Me.butserach.Iconimage = Nothing
        Me.butserach.Iconimage_right = Nothing
        Me.butserach.Iconimage_right_Selected = Nothing
        Me.butserach.Iconimage_Selected = Nothing
        Me.butserach.IconMarginLeft = 0
        Me.butserach.IconMarginRight = 0
        Me.butserach.IconRightVisible = True
        Me.butserach.IconRightZoom = 0R
        Me.butserach.IconVisible = True
        Me.butserach.IconZoom = 90.0R
        Me.butserach.IsTab = False
        Me.butserach.Location = New System.Drawing.Point(582, 79)
        Me.butserach.Margin = New System.Windows.Forms.Padding(5)
        Me.butserach.Name = "butserach"
        Me.butserach.Normalcolor = System.Drawing.Color.DarkOrange
        Me.butserach.OnHovercolor = System.Drawing.Color.Gold
        Me.butserach.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butserach.selected = False
        Me.butserach.Size = New System.Drawing.Size(230, 56)
        Me.butserach.TabIndex = 44
        Me.butserach.Text = "Search"
        Me.butserach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.butserach.Textcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.butserach.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'productsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ShopQuik.My.Resources.Resources.cart_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 822)
        Me.Controls.Add(Me.butserach)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbproductid)
        Me.Controls.Add(Me.productpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "productsearch"
        Me.Text = "productsearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.productpanel.ResumeLayout(False)
        Me.productpanel.PerformLayout()
        CType(Me.PctProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents productpanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbproductid As ComboBox
    Friend WithEvents butserach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents butupdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txttype As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PctProduct As PictureBox
    Friend WithEvents TxtSpecification As TextBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TxtQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ButImage As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TxtPrice As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents butremove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TxtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
End Class
