<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderdetails
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
        Me.ordergrid = New System.Windows.Forms.DataGridView()
        CType(Me.ordergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ordergrid
        '
        Me.ordergrid.AllowUserToAddRows = False
        Me.ordergrid.AllowUserToDeleteRows = False
        Me.ordergrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ordergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ordergrid.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.ordergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordergrid.Location = New System.Drawing.Point(56, 30)
        Me.ordergrid.Margin = New System.Windows.Forms.Padding(4)
        Me.ordergrid.Name = "ordergrid"
        Me.ordergrid.ReadOnly = True
        Me.ordergrid.RowHeadersWidth = 51
        Me.ordergrid.Size = New System.Drawing.Size(1695, 802)
        Me.ordergrid.TabIndex = 6
        '
        'orderdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 878)
        Me.Controls.Add(Me.ordergrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "orderdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "orderdetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ordergrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ordergrid As DataGridView
End Class
