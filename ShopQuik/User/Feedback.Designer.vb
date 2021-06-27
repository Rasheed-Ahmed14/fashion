<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radgreat = New System.Windows.Forms.RadioButton()
        Me.raddispoint = New System.Windows.Forms.RadioButton()
        Me.radgood = New System.Windows.Forms.RadioButton()
        Me.butfeedback = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtfeedback = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(90, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How do you feel..?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(92, 300)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Thanks.Anything else you'd like to add?"
        '
        'radgreat
        '
        Me.radgreat.AutoSize = True
        Me.radgreat.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radgreat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radgreat.Location = New System.Drawing.Point(96, 114)
        Me.radgreat.Margin = New System.Windows.Forms.Padding(4)
        Me.radgreat.Name = "radgreat"
        Me.radgreat.Size = New System.Drawing.Size(189, 32)
        Me.radgreat.TabIndex = 2
        Me.radgreat.Text = "It was Great"
        Me.radgreat.UseVisualStyleBackColor = True
        '
        'raddispoint
        '
        Me.raddispoint.AutoSize = True
        Me.raddispoint.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raddispoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.raddispoint.Location = New System.Drawing.Point(96, 228)
        Me.raddispoint.Margin = New System.Windows.Forms.Padding(4)
        Me.raddispoint.Name = "raddispoint"
        Me.raddispoint.Size = New System.Drawing.Size(267, 32)
        Me.raddispoint.TabIndex = 3
        Me.raddispoint.Text = "I was Disappointed"
        Me.raddispoint.UseVisualStyleBackColor = True
        '
        'radgood
        '
        Me.radgood.AutoSize = True
        Me.radgood.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radgood.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radgood.Location = New System.Drawing.Point(96, 172)
        Me.radgood.Margin = New System.Windows.Forms.Padding(4)
        Me.radgood.Name = "radgood"
        Me.radgood.Size = New System.Drawing.Size(176, 32)
        Me.radgood.TabIndex = 4
        Me.radgood.Text = "It was Good"
        Me.radgood.UseVisualStyleBackColor = True
        '
        'butfeedback
        '
        Me.butfeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butfeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butfeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.butfeedback.Location = New System.Drawing.Point(170, 469)
        Me.butfeedback.Margin = New System.Windows.Forms.Padding(4)
        Me.butfeedback.Name = "butfeedback"
        Me.butfeedback.Size = New System.Drawing.Size(228, 54)
        Me.butfeedback.TabIndex = 6
        Me.butfeedback.Text = "Submit Feedback"
        Me.butfeedback.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.txtfeedback)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.butfeedback)
        Me.Panel2.Controls.Add(Me.radgreat)
        Me.Panel2.Controls.Add(Me.radgood)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.raddispoint)
        Me.Panel2.Location = New System.Drawing.Point(447, 94)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(567, 613)
        Me.Panel2.TabIndex = 8
        '
        'txtfeedback
        '
        Me.txtfeedback.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtfeedback.Location = New System.Drawing.Point(104, 361)
        Me.txtfeedback.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfeedback.Multiline = True
        Me.txtfeedback.Name = "txtfeedback"
        Me.txtfeedback.Size = New System.Drawing.Size(339, 77)
        Me.txtfeedback.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(475, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Give Your Feedback.."
        '
        'Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Feedback"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedback"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radgreat As RadioButton
    Friend WithEvents raddispoint As RadioButton
    Friend WithEvents radgood As RadioButton
    Friend WithEvents butfeedback As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtfeedback As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label3 As Label
End Class
