<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customization
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
        Me.butshirt = New System.Windows.Forms.Button()
        Me.butpant = New System.Windows.Forms.Button()
        Me.pctpant = New System.Windows.Forms.PictureBox()
        Me.pctshirt = New System.Windows.Forms.PictureBox()
        CType(Me.pctpant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctshirt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butshirt
        '
        Me.butshirt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butshirt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butshirt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butshirt.Location = New System.Drawing.Point(655, 139)
        Me.butshirt.Margin = New System.Windows.Forms.Padding(4)
        Me.butshirt.Name = "butshirt"
        Me.butshirt.Size = New System.Drawing.Size(232, 104)
        Me.butshirt.TabIndex = 2
        Me.butshirt.Text = "Select Shirt"
        Me.butshirt.UseVisualStyleBackColor = False
        '
        'butpant
        '
        Me.butpant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butpant.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpant.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butpant.Location = New System.Drawing.Point(666, 502)
        Me.butpant.Margin = New System.Windows.Forms.Padding(4)
        Me.butpant.Name = "butpant"
        Me.butpant.Size = New System.Drawing.Size(221, 111)
        Me.butpant.TabIndex = 3
        Me.butpant.Text = "Select Pant"
        Me.butpant.UseVisualStyleBackColor = False
        '
        'pctpant
        '
        Me.pctpant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctpant.Location = New System.Drawing.Point(215, 431)
        Me.pctpant.Margin = New System.Windows.Forms.Padding(4)
        Me.pctpant.Name = "pctpant"
        Me.pctpant.Size = New System.Drawing.Size(299, 358)
        Me.pctpant.TabIndex = 1
        Me.pctpant.TabStop = False
        '
        'pctshirt
        '
        Me.pctshirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctshirt.Location = New System.Drawing.Point(215, 65)
        Me.pctshirt.Margin = New System.Windows.Forms.Padding(4)
        Me.pctshirt.Name = "pctshirt"
        Me.pctshirt.Size = New System.Drawing.Size(299, 358)
        Me.pctshirt.TabIndex = 0
        Me.pctshirt.TabStop = False
        '
        'customization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.ShopQuik.My.Resources.Resources.istock_639223110_2
        Me.ClientSize = New System.Drawing.Size(1937, 814)
        Me.Controls.Add(Me.butpant)
        Me.Controls.Add(Me.butshirt)
        Me.Controls.Add(Me.pctpant)
        Me.Controls.Add(Me.pctshirt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "customization"
        Me.Text = "customization"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctpant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctshirt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctshirt As PictureBox
    Friend WithEvents pctpant As PictureBox
    Friend WithEvents butshirt As Button
    Friend WithEvents butpant As Button
End Class
