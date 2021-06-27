<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productsview
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butview = New System.Windows.Forms.Button()
        Me.propgrid = New System.Windows.Forms.DataGridView()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        CType(Me.propgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(273, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product type"
        '
        'butview
        '
        Me.butview.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butview.Location = New System.Drawing.Point(408, 71)
        Me.butview.Margin = New System.Windows.Forms.Padding(4)
        Me.butview.Name = "butview"
        Me.butview.Size = New System.Drawing.Size(124, 42)
        Me.butview.TabIndex = 4
        Me.butview.Text = "View"
        Me.butview.UseVisualStyleBackColor = True
        '
        'propgrid
        '
        Me.propgrid.AllowUserToAddRows = False
        Me.propgrid.AllowUserToDeleteRows = False
        Me.propgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.propgrid.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.propgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.propgrid.Location = New System.Drawing.Point(16, 132)
        Me.propgrid.Margin = New System.Windows.Forms.Padding(4)
        Me.propgrid.Name = "propgrid"
        Me.propgrid.ReadOnly = True
        Me.propgrid.RowHeadersWidth = 51
        Me.propgrid.Size = New System.Drawing.Size(1317, 630)
        Me.propgrid.TabIndex = 5
        '
        'cmbtype
        '
        Me.cmbtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Pants", "Shirts", "Saries", "Dress", "Kids", "Tops", "Bottoms"})
        Me.cmbtype.Location = New System.Drawing.Point(448, 15)
        Me.cmbtype.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(253, 32)
        Me.cmbtype.TabIndex = 7
        '
        'Productsview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.propgrid)
        Me.Controls.Add(Me.butview)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Productsview"
        Me.Text = "Productsview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.propgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents butview As Button
    Friend WithEvents propgrid As DataGridView
    Friend WithEvents cmbtype As ComboBox
End Class
