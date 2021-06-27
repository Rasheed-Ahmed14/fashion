<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItems
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
        Me.PctProduct = New System.Windows.Forms.PictureBox()
        Me.TxtPrice = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CmbProductType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButImage = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButAddProduct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TxtSpecification = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtProductID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.PctProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PctProduct
        '
        Me.PctProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PctProduct.Location = New System.Drawing.Point(288, 194)
        Me.PctProduct.Name = "PctProduct"
        Me.PctProduct.Size = New System.Drawing.Size(207, 220)
        Me.PctProduct.TabIndex = 0
        Me.PctProduct.TabStop = False
        '
        'TxtPrice
        '
        Me.TxtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtPrice.ForeColor = System.Drawing.Color.Black
        Me.TxtPrice.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPrice.HintText = "Price"
        Me.TxtPrice.isPassword = False
        Me.TxtPrice.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.TxtPrice.LineIdleColor = System.Drawing.Color.DarkCyan
        Me.TxtPrice.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TxtPrice.LineThickness = 3
        Me.TxtPrice.Location = New System.Drawing.Point(607, 321)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrice.MaxLength = 32767
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(200, 33)
        Me.TxtPrice.TabIndex = 2
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CmbProductType
        '
        Me.CmbProductType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProductType.FormattingEnabled = True
        Me.CmbProductType.Items.AddRange(New Object() {"HomeAppliance", "Mobile", "Laptop", "Men's Clothing", "Women's Clothing", "Kids", "Accessories"})
        Me.CmbProductType.Location = New System.Drawing.Point(658, 109)
        Me.CmbProductType.Name = "CmbProductType"
        Me.CmbProductType.Size = New System.Drawing.Size(227, 26)
        Me.CmbProductType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(473, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Type of Product"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(850, 180)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(11, 277)
        Me.BunifuSeparator1.TabIndex = 9
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(903, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Other Specifications:"
        '
        'ButImage
        '
        Me.ButImage.Active = False
        Me.ButImage.Activecolor = System.Drawing.Color.LightSeaGreen
        Me.ButImage.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButImage.BorderRadius = 0
        Me.ButImage.ButtonText = "Image"
        Me.ButImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButImage.DisabledColor = System.Drawing.Color.Gray
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
        Me.ButImage.Location = New System.Drawing.Point(316, 444)
        Me.ButImage.Name = "ButImage"
        Me.ButImage.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.ButImage.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.ButImage.OnHoverTextColor = System.Drawing.Color.White
        Me.ButImage.selected = False
        Me.ButImage.Size = New System.Drawing.Size(165, 42)
        Me.ButImage.TabIndex = 12
        Me.ButImage.Text = "Image"
        Me.ButImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButImage.Textcolor = System.Drawing.Color.White
        Me.ButImage.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButAddProduct
        '
        Me.ButAddProduct.Active = False
        Me.ButAddProduct.Activecolor = System.Drawing.Color.LightSeaGreen
        Me.ButAddProduct.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButAddProduct.BorderRadius = 0
        Me.ButAddProduct.ButtonText = "Add Product"
        Me.ButAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButAddProduct.DisabledColor = System.Drawing.Color.Gray
        Me.ButAddProduct.Iconcolor = System.Drawing.Color.Transparent
        Me.ButAddProduct.Iconimage = Nothing
        Me.ButAddProduct.Iconimage_right = Nothing
        Me.ButAddProduct.Iconimage_right_Selected = Nothing
        Me.ButAddProduct.Iconimage_Selected = Nothing
        Me.ButAddProduct.IconMarginLeft = 0
        Me.ButAddProduct.IconMarginRight = 0
        Me.ButAddProduct.IconRightVisible = True
        Me.ButAddProduct.IconRightZoom = 0R
        Me.ButAddProduct.IconVisible = True
        Me.ButAddProduct.IconZoom = 90.0R
        Me.ButAddProduct.IsTab = False
        Me.ButAddProduct.Location = New System.Drawing.Point(607, 533)
        Me.ButAddProduct.Name = "ButAddProduct"
        Me.ButAddProduct.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.ButAddProduct.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.ButAddProduct.OnHoverTextColor = System.Drawing.Color.White
        Me.ButAddProduct.selected = False
        Me.ButAddProduct.Size = New System.Drawing.Size(165, 42)
        Me.ButAddProduct.TabIndex = 13
        Me.ButAddProduct.Text = "Add Product"
        Me.ButAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButAddProduct.Textcolor = System.Drawing.Color.White
        Me.ButAddProduct.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ShopQuik.My.Resources.Resources.sq_logo
        Me.PictureBox1.Location = New System.Drawing.Point(-26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'TxtName
        '
        Me.TxtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtName.ForeColor = System.Drawing.Color.Black
        Me.TxtName.HintForeColor = System.Drawing.Color.Empty
        Me.TxtName.HintText = "Name of the Product"
        Me.TxtName.isPassword = False
        Me.TxtName.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.TxtName.LineIdleColor = System.Drawing.Color.DarkCyan
        Me.TxtName.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TxtName.LineThickness = 3
        Me.TxtName.Location = New System.Drawing.Point(607, 253)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtName.MaxLength = 32767
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(200, 33)
        Me.TxtName.TabIndex = 1
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(892, 488)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(222, 15)
        Me.BunifuSeparator2.TabIndex = 27
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'TxtSpecification
        '
        Me.TxtSpecification.Location = New System.Drawing.Point(904, 229)
        Me.TxtSpecification.Multiline = True
        Me.TxtSpecification.Name = "TxtSpecification"
        Me.TxtSpecification.Size = New System.Drawing.Size(191, 214)
        Me.TxtSpecification.TabIndex = 28
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(535, 180)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(11, 277)
        Me.BunifuSeparator3.TabIndex = 29
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtQuantity.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtQuantity.ForeColor = System.Drawing.Color.Black
        Me.TxtQuantity.HintForeColor = System.Drawing.Color.Empty
        Me.TxtQuantity.HintText = "Quantity"
        Me.TxtQuantity.isPassword = False
        Me.TxtQuantity.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.TxtQuantity.LineIdleColor = System.Drawing.Color.DarkCyan
        Me.TxtQuantity.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TxtQuantity.LineThickness = 3
        Me.TxtQuantity.Location = New System.Drawing.Point(607, 389)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQuantity.MaxLength = 32767
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(200, 33)
        Me.TxtQuantity.TabIndex = 30
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtProductID
        '
        Me.TxtProductID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtProductID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtProductID.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtProductID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtProductID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtProductID.ForeColor = System.Drawing.Color.Black
        Me.TxtProductID.HintForeColor = System.Drawing.Color.Empty
        Me.TxtProductID.HintText = "Product ID"
        Me.TxtProductID.isPassword = False
        Me.TxtProductID.LineFocusedColor = System.Drawing.Color.DarkOrange
        Me.TxtProductID.LineIdleColor = System.Drawing.Color.DarkCyan
        Me.TxtProductID.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TxtProductID.LineThickness = 3
        Me.TxtProductID.Location = New System.Drawing.Point(607, 194)
        Me.TxtProductID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProductID.MaxLength = 32767
        Me.TxtProductID.Name = "TxtProductID"
        Me.TxtProductID.Size = New System.Drawing.Size(200, 33)
        Me.TxtProductID.TabIndex = 31
        Me.TxtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShopQuik.My.Resources.Resources.gradient_wallpaper_26036_26721_hd_wallpapers_jpg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TxtProductID)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.TxtSpecification)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButAddProduct)
        Me.Controls.Add(Me.ButImage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbProductType)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.PctProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddItems"
        Me.Text = "AddItems"
        CType(Me.PctProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PctProduct As PictureBox
    Friend WithEvents TxtPrice As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CmbProductType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents ButImage As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButAddProduct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TxtSpecification As TextBox
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtProductID As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
