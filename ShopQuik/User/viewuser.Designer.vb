<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewuser
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
        Me.usergrid = New System.Windows.Forms.DataGridView()
        CType(Me.usergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usergrid
        '
        Me.usergrid.AllowUserToAddRows = False
        Me.usergrid.AllowUserToDeleteRows = False
        Me.usergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.usergrid.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.usergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usergrid.Location = New System.Drawing.Point(87, 113)
        Me.usergrid.Margin = New System.Windows.Forms.Padding(4)
        Me.usergrid.Name = "usergrid"
        Me.usergrid.ReadOnly = True
        Me.usergrid.RowHeadersWidth = 51
        Me.usergrid.Size = New System.Drawing.Size(1470, 633)
        Me.usergrid.TabIndex = 6
        '
        'viewuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.usergrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "viewuser"
        Me.Text = "userview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.usergrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents usergrid As DataGridView
End Class
