<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartForm
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
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.cartpanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butremove = New System.Windows.Forms.Button()
        Me.butbuy = New System.Windows.Forms.Button()
        Me.cmbquan = New System.Windows.Forms.ComboBox()
        Me.pctcartimage = New System.Windows.Forms.PictureBox()
        Me.cartpanel.SuspendLayout()
        CType(Me.pctcartimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblproductname.Location = New System.Drawing.Point(265, 70)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(105, 32)
        Me.lblproductname.TabIndex = 2
        Me.lblproductname.Text = "Label1"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.Gold
        Me.lblprice.Location = New System.Drawing.Point(266, 119)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(90, 28)
        Me.lblprice.TabIndex = 3
        Me.lblprice.Text = "Label2"
        '
        'cartpanel
        '
        Me.cartpanel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cartpanel.Controls.Add(Me.Label1)
        Me.cartpanel.Controls.Add(Me.butremove)
        Me.cartpanel.Controls.Add(Me.butbuy)
        Me.cartpanel.Controls.Add(Me.cmbquan)
        Me.cartpanel.Controls.Add(Me.pctcartimage)
        Me.cartpanel.Controls.Add(Me.lblprice)
        Me.cartpanel.Controls.Add(Me.lblproductname)
        Me.cartpanel.Location = New System.Drawing.Point(237, 52)
        Me.cartpanel.Name = "cartpanel"
        Me.cartpanel.Size = New System.Drawing.Size(456, 409)
        Me.cartpanel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantity"
        '
        'butremove
        '
        Me.butremove.BackColor = System.Drawing.Color.LightSeaGreen
        Me.butremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butremove.Location = New System.Drawing.Point(129, 337)
        Me.butremove.Name = "butremove"
        Me.butremove.Size = New System.Drawing.Size(180, 39)
        Me.butremove.TabIndex = 6
        Me.butremove.Text = "Remove from Cart"
        Me.butremove.UseVisualStyleBackColor = False
        '
        'butbuy
        '
        Me.butbuy.BackColor = System.Drawing.Color.LightSeaGreen
        Me.butbuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butbuy.Location = New System.Drawing.Point(129, 261)
        Me.butbuy.Name = "butbuy"
        Me.butbuy.Size = New System.Drawing.Size(180, 39)
        Me.butbuy.TabIndex = 5
        Me.butbuy.Text = "Proceed to Buy"
        Me.butbuy.UseVisualStyleBackColor = False
        '
        'cmbquan
        '
        Me.cmbquan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbquan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbquan.FormattingEnabled = True
        Me.cmbquan.Location = New System.Drawing.Point(341, 174)
        Me.cmbquan.Name = "cmbquan"
        Me.cmbquan.Size = New System.Drawing.Size(100, 26)
        Me.cmbquan.TabIndex = 4
        '
        'pctcartimage
        '
        Me.pctcartimage.BackColor = System.Drawing.Color.White
        Me.pctcartimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctcartimage.Location = New System.Drawing.Point(46, 39)
        Me.pctcartimage.Name = "pctcartimage"
        Me.pctcartimage.Size = New System.Drawing.Size(166, 181)
        Me.pctcartimage.TabIndex = 0
        Me.pctcartimage.TabStop = False
        '
        'CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1108, 514)
        Me.Controls.Add(Me.cartpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CartForm"
        Me.Text = "CartForm"
        Me.cartpanel.ResumeLayout(False)
        Me.cartpanel.PerformLayout()
        CType(Me.pctcartimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctcartimage As PictureBox
    Friend WithEvents lblproductname As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents cartpanel As Panel
    Friend WithEvents butremove As Button
    Friend WithEvents butbuy As Button
    Friend WithEvents cmbquan As ComboBox
    Friend WithEvents Label1 As Label
End Class
