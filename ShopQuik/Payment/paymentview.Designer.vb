<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentview))
        Me.paymentgrid = New System.Windows.Forms.DataGridView()
        CType(Me.paymentgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paymentgrid
        '
        Me.paymentgrid.AllowUserToAddRows = False
        Me.paymentgrid.AllowUserToDeleteRows = False
        Me.paymentgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.paymentgrid.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.paymentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.paymentgrid.Location = New System.Drawing.Point(87, 37)
        Me.paymentgrid.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentgrid.Name = "paymentgrid"
        Me.paymentgrid.ReadOnly = True
        Me.paymentgrid.RowHeadersWidth = 51
        Me.paymentgrid.Size = New System.Drawing.Size(1666, 715)
        Me.paymentgrid.TabIndex = 6
        '
        'paymentview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShopQuik.My.Resources.Resources.pay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.paymentgrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "paymentview"
        Me.Text = resources.GetString("$this.Text")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.paymentgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents paymentgrid As DataGridView
End Class
