<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartMain
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
        Me.lblcaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblcaption
        '
        Me.lblcaption.AutoSize = True
        Me.lblcaption.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcaption.Location = New System.Drawing.Point(477, 266)
        Me.lblcaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcaption.Name = "lblcaption"
        Me.lblcaption.Size = New System.Drawing.Size(264, 40)
        Me.lblcaption.TabIndex = 8
        Me.lblcaption.Text = "No Items....."
        '
        'CartMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.lblcaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CartMain"
        Me.Text = "CartMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcaption As Label
End Class
