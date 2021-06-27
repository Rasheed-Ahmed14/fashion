<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedbackmain
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
        Me.feedgrid = New System.Windows.Forms.DataGridView()
        CType(Me.feedgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'feedgrid
        '
        Me.feedgrid.AllowUserToAddRows = False
        Me.feedgrid.AllowUserToDeleteRows = False
        Me.feedgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.feedgrid.BackgroundColor = System.Drawing.Color.DarkViolet
        Me.feedgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.feedgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.feedgrid.Location = New System.Drawing.Point(74, 30)
        Me.feedgrid.Margin = New System.Windows.Forms.Padding(4)
        Me.feedgrid.Name = "feedgrid"
        Me.feedgrid.ReadOnly = True
        Me.feedgrid.RowHeadersWidth = 51
        Me.feedgrid.Size = New System.Drawing.Size(1369, 709)
        Me.feedgrid.TabIndex = 7
        '
        'feedbackmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.feedgrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "feedbackmain"
        Me.Text = "feedbackmain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.feedgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents feedgrid As DataGridView
End Class
