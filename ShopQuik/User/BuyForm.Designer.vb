<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuyForm
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
        Me.lblspeci = New System.Windows.Forms.Label()
        Me.CheckSpeci = New System.Windows.Forms.CheckBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.LblDeliver = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButAddToCart = New System.Windows.Forms.Button()
        Me.ButBuyNow = New System.Windows.Forms.Button()
        Me.cmbquantity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctbuyform = New System.Windows.Forms.PictureBox()
        Me.butcustm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pctbuyform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblspeci
        '
        Me.lblspeci.AutoSize = True
        Me.lblspeci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblspeci.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspeci.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblspeci.Location = New System.Drawing.Point(31, 122)
        Me.lblspeci.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblspeci.Name = "lblspeci"
        Me.lblspeci.Size = New System.Drawing.Size(137, 22)
        Me.lblspeci.TabIndex = 29
        Me.lblspeci.Text = "specifications"
        Me.lblspeci.Visible = False
        '
        'CheckSpeci
        '
        Me.CheckSpeci.AutoSize = True
        Me.CheckSpeci.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSpeci.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckSpeci.Location = New System.Drawing.Point(31, 69)
        Me.CheckSpeci.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckSpeci.Name = "CheckSpeci"
        Me.CheckSpeci.Size = New System.Drawing.Size(247, 36)
        Me.CheckSpeci.TabIndex = 28
        Me.CheckSpeci.Text = "Specifications"
        Me.CheckSpeci.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(674, 26)
        Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(90, 31)
        Me.LblName.TabIndex = 27
        Me.LblName.Text = "Name"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblprice.Location = New System.Drawing.Point(120, 20)
        Me.lblprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(81, 31)
        Me.lblprice.TabIndex = 2
        Me.lblprice.Text = "Price"
        '
        'LblDeliver
        '
        Me.LblDeliver.AutoSize = True
        Me.LblDeliver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblDeliver.Location = New System.Drawing.Point(515, 519)
        Me.LblDeliver.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDeliver.Name = "LblDeliver"
        Me.LblDeliver.Size = New System.Drawing.Size(138, 31)
        Me.LblDeliver.TabIndex = 32
        Me.LblDeliver.Text = "Deliver To"
        Me.LblDeliver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButAddToCart
        '
        Me.ButAddToCart.BackColor = System.Drawing.Color.DarkOrange
        Me.ButAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.ButAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButAddToCart.Location = New System.Drawing.Point(566, 569)
        Me.ButAddToCart.Margin = New System.Windows.Forms.Padding(4)
        Me.ButAddToCart.Name = "ButAddToCart"
        Me.ButAddToCart.Size = New System.Drawing.Size(261, 60)
        Me.ButAddToCart.TabIndex = 34
        Me.ButAddToCart.Text = "Add To Cart"
        Me.ButAddToCart.UseVisualStyleBackColor = False
        '
        'ButBuyNow
        '
        Me.ButBuyNow.BackColor = System.Drawing.Color.DarkOrange
        Me.ButBuyNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.ButBuyNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButBuyNow.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButBuyNow.Location = New System.Drawing.Point(174, 569)
        Me.ButBuyNow.Margin = New System.Windows.Forms.Padding(4)
        Me.ButBuyNow.Name = "ButBuyNow"
        Me.ButBuyNow.Size = New System.Drawing.Size(235, 60)
        Me.ButBuyNow.TabIndex = 35
        Me.ButBuyNow.Text = "Buy Now"
        Me.ButBuyNow.UseVisualStyleBackColor = False
        '
        'cmbquantity
        '
        Me.cmbquantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbquantity.FormattingEnabled = True
        Me.cmbquantity.Location = New System.Drawing.Point(191, 338)
        Me.cmbquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbquantity.Name = "cmbquantity"
        Me.cmbquantity.Size = New System.Drawing.Size(111, 24)
        Me.cmbquantity.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(25, 331)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Quantity"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(369, 519)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(138, 31)
        Me.BunifuCustomLabel1.TabIndex = 37
        Me.BunifuCustomLabel1.Text = "Deliver To"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbquantity)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pctbuyform)
        Me.Panel1.Controls.Add(Me.lblprice)
        Me.Panel1.Controls.Add(Me.lblspeci)
        Me.Panel1.Controls.Add(Me.CheckSpeci)
        Me.Panel1.Location = New System.Drawing.Point(410, 82)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 418)
        Me.Panel1.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(65, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 31)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Rs."
        '
        'pctbuyform
        '
        Me.pctbuyform.BackColor = System.Drawing.Color.White
        Me.pctbuyform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctbuyform.Location = New System.Drawing.Point(384, 20)
        Me.pctbuyform.Margin = New System.Windows.Forms.Padding(4)
        Me.pctbuyform.Name = "pctbuyform"
        Me.pctbuyform.Size = New System.Drawing.Size(320, 342)
        Me.pctbuyform.TabIndex = 0
        Me.pctbuyform.TabStop = False
        '
        'butcustm
        '
        Me.butcustm.BackColor = System.Drawing.Color.DarkOrange
        Me.butcustm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.butcustm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butcustm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butcustm.Location = New System.Drawing.Point(930, 569)
        Me.butcustm.Margin = New System.Windows.Forms.Padding(4)
        Me.butcustm.Name = "butcustm"
        Me.butcustm.Size = New System.Drawing.Size(328, 60)
        Me.butcustm.TabIndex = 39
        Me.butcustm.Text = "Add To Customization"
        Me.butcustm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "SIZE"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"28", "30", "32", "34", "36", "38", "40"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 284)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 39
        '
        'BuyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.butcustm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.ButBuyNow)
        Me.Controls.Add(Me.ButAddToCart)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.LblDeliver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BuyForm"
        Me.Text = "image"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctbuyform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblspeci As Label
    Friend WithEvents CheckSpeci As CheckBox
    Friend WithEvents LblName As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents pctbuyform As PictureBox
    Friend WithEvents LblDeliver As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ButAddToCart As Button
    Friend WithEvents ButBuyNow As Button
    Friend WithEvents cmbquantity As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents butcustm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
