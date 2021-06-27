<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paymentmain
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
        Me.components = New System.ComponentModel.Container()
        Me.mainlabel = New System.Windows.Forms.Label()
        Me.paymentmainpanel = New System.Windows.Forms.Panel()
        Me.cashpanel = New System.Windows.Forms.Panel()
        Me.butback = New System.Windows.Forms.Button()
        Me.butcontinue = New System.Windows.Forms.Button()
        Me.radcash = New System.Windows.Forms.RadioButton()
        Me.netbankpanel = New System.Windows.Forms.Panel()
        Me.cmbbank = New System.Windows.Forms.ComboBox()
        Me.radnetbank = New System.Windows.Forms.RadioButton()
        Me.debitpanel = New System.Windows.Forms.Panel()
        Me.txtcardnumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtusername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.raddebit = New System.Windows.Forms.RadioButton()
        Me.butend = New System.Windows.Forms.Button()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.mainorderpanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.butplaceorder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpaymenttype = New System.Windows.Forms.Label()
        Me.lblshippingdate = New System.Windows.Forms.Label()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblquan = New System.Windows.Forms.Label()
        Me.lblshippingaddress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.paymentmainpanel.SuspendLayout()
        Me.cashpanel.SuspendLayout()
        Me.netbankpanel.SuspendLayout()
        Me.debitpanel.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        Me.mainorderpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainlabel
        '
        Me.mainlabel.AutoSize = True
        Me.mainlabel.BackColor = System.Drawing.Color.Transparent
        Me.mainlabel.Font = New System.Drawing.Font("Consolas", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mainlabel.Location = New System.Drawing.Point(151, 122)
        Me.mainlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(416, 40)
        Me.mainlabel.TabIndex = 0
        Me.mainlabel.Text = "Select Payment method"
        '
        'paymentmainpanel
        '
        Me.paymentmainpanel.BackColor = System.Drawing.Color.Indigo
        Me.paymentmainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paymentmainpanel.Controls.Add(Me.cashpanel)
        Me.paymentmainpanel.Controls.Add(Me.netbankpanel)
        Me.paymentmainpanel.Controls.Add(Me.debitpanel)
        Me.paymentmainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paymentmainpanel.Location = New System.Drawing.Point(0, 0)
        Me.paymentmainpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.paymentmainpanel.Name = "paymentmainpanel"
        Me.paymentmainpanel.Size = New System.Drawing.Size(464, 542)
        Me.paymentmainpanel.TabIndex = 1
        '
        'cashpanel
        '
        Me.cashpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cashpanel.Controls.Add(Me.butback)
        Me.cashpanel.Controls.Add(Me.butcontinue)
        Me.cashpanel.Controls.Add(Me.radcash)
        Me.cashpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cashpanel.Location = New System.Drawing.Point(0, 121)
        Me.cashpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cashpanel.Name = "cashpanel"
        Me.cashpanel.Size = New System.Drawing.Size(462, 419)
        Me.cashpanel.TabIndex = 2
        '
        'butback
        '
        Me.butback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butback.Location = New System.Drawing.Point(90, 213)
        Me.butback.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butback.Name = "butback"
        Me.butback.Size = New System.Drawing.Size(233, 41)
        Me.butback.TabIndex = 4
        Me.butback.Text = "Back"
        Me.butback.UseVisualStyleBackColor = True
        '
        'butcontinue
        '
        Me.butcontinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butcontinue.Location = New System.Drawing.Point(90, 106)
        Me.butcontinue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butcontinue.Name = "butcontinue"
        Me.butcontinue.Size = New System.Drawing.Size(233, 41)
        Me.butcontinue.TabIndex = 3
        Me.butcontinue.Text = "Continue"
        Me.butcontinue.UseVisualStyleBackColor = True
        '
        'radcash
        '
        Me.radcash.AutoSize = True
        Me.radcash.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radcash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radcash.Location = New System.Drawing.Point(54, 19)
        Me.radcash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radcash.Name = "radcash"
        Me.radcash.Size = New System.Drawing.Size(306, 32)
        Me.radcash.TabIndex = 2
        Me.radcash.TabStop = True
        Me.radcash.Text = "Pay on Delivery(Cash)"
        Me.radcash.UseVisualStyleBackColor = True
        '
        'netbankpanel
        '
        Me.netbankpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.netbankpanel.Controls.Add(Me.cmbbank)
        Me.netbankpanel.Controls.Add(Me.radnetbank)
        Me.netbankpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.netbankpanel.Location = New System.Drawing.Point(0, 61)
        Me.netbankpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.netbankpanel.Name = "netbankpanel"
        Me.netbankpanel.Size = New System.Drawing.Size(462, 60)
        Me.netbankpanel.TabIndex = 1
        '
        'cmbbank
        '
        Me.cmbbank.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbank.FormattingEnabled = True
        Me.cmbbank.Items.AddRange(New Object() {"SBI Bank", "ICICI Bank", "HDFC Bank", "Axis Bank", "Karnataka Bank", "PNB", "BOB", "Kotak Mahindra Bank", "Yes bank", "Sindicate Bank", "Corporation Bank"})
        Me.cmbbank.Location = New System.Drawing.Point(56, 60)
        Me.cmbbank.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbbank.Name = "cmbbank"
        Me.cmbbank.Size = New System.Drawing.Size(364, 31)
        Me.cmbbank.TabIndex = 2
        Me.cmbbank.Text = "Choose Bank"
        '
        'radnetbank
        '
        Me.radnetbank.AutoSize = True
        Me.radnetbank.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radnetbank.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radnetbank.Location = New System.Drawing.Point(56, 7)
        Me.radnetbank.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radnetbank.Name = "radnetbank"
        Me.radnetbank.Size = New System.Drawing.Size(176, 32)
        Me.radnetbank.TabIndex = 1
        Me.radnetbank.TabStop = True
        Me.radnetbank.Text = "Net Banking"
        Me.radnetbank.UseVisualStyleBackColor = True
        '
        'debitpanel
        '
        Me.debitpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.debitpanel.Controls.Add(Me.txtcardnumber)
        Me.debitpanel.Controls.Add(Me.txtusername)
        Me.debitpanel.Controls.Add(Me.raddebit)
        Me.debitpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.debitpanel.Location = New System.Drawing.Point(0, 0)
        Me.debitpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.debitpanel.Name = "debitpanel"
        Me.debitpanel.Size = New System.Drawing.Size(462, 61)
        Me.debitpanel.TabIndex = 0
        '
        'txtcardnumber
        '
        Me.txtcardnumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtcardnumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtcardnumber.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtcardnumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtcardnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcardnumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtcardnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcardnumber.HintForeColor = System.Drawing.Color.Gray
        Me.txtcardnumber.HintText = "card number"
        Me.txtcardnumber.isPassword = False
        Me.txtcardnumber.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtcardnumber.LineIdleColor = System.Drawing.Color.Gray
        Me.txtcardnumber.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtcardnumber.LineThickness = 3
        Me.txtcardnumber.Location = New System.Drawing.Point(56, 114)
        Me.txtcardnumber.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtcardnumber.MaxLength = 32767
        Me.txtcardnumber.Name = "txtcardnumber"
        Me.txtcardnumber.Size = New System.Drawing.Size(365, 41)
        Me.txtcardnumber.TabIndex = 3
        Me.txtcardnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtusername
        '
        Me.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtusername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtusername.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.HintForeColor = System.Drawing.Color.Empty
        Me.txtusername.HintText = ""
        Me.txtusername.isPassword = False
        Me.txtusername.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtusername.LineIdleColor = System.Drawing.Color.Gray
        Me.txtusername.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtusername.LineThickness = 3
        Me.txtusername.Location = New System.Drawing.Point(56, 64)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(365, 41)
        Me.txtusername.TabIndex = 2
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'raddebit
        '
        Me.raddebit.AutoSize = True
        Me.raddebit.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raddebit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.raddebit.Location = New System.Drawing.Point(56, 15)
        Me.raddebit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.raddebit.Name = "raddebit"
        Me.raddebit.Size = New System.Drawing.Size(358, 32)
        Me.raddebit.TabIndex = 0
        Me.raddebit.Text = "Add Debit/Credit/ATM Card"
        Me.raddebit.UseVisualStyleBackColor = True
        '
        'butend
        '
        Me.butend.BackColor = System.Drawing.Color.Red
        Me.butend.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butend.Location = New System.Drawing.Point(1883, 13)
        Me.butend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butend.Name = "butend"
        Me.butend.Size = New System.Drawing.Size(41, 30)
        Me.butend.TabIndex = 3
        Me.butend.Text = "X"
        Me.butend.UseVisualStyleBackColor = False
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.Transparent
        Me.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainpanel.Controls.Add(Me.paymentmainpanel)
        Me.mainpanel.Controls.Add(Me.mainorderpanel)
        Me.mainpanel.Location = New System.Drawing.Point(115, 181)
        Me.mainpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(466, 544)
        Me.mainpanel.TabIndex = 2
        '
        'mainorderpanel
        '
        Me.mainorderpanel.BackColor = System.Drawing.Color.Indigo
        Me.mainorderpanel.Controls.Add(Me.Button1)
        Me.mainorderpanel.Controls.Add(Me.Label9)
        Me.mainorderpanel.Controls.Add(Me.Label1)
        Me.mainorderpanel.Controls.Add(Me.BunifuSeparator2)
        Me.mainorderpanel.Controls.Add(Me.BunifuSeparator1)
        Me.mainorderpanel.Controls.Add(Me.butplaceorder)
        Me.mainorderpanel.Controls.Add(Me.Label2)
        Me.mainorderpanel.Controls.Add(Me.lblpaymenttype)
        Me.mainorderpanel.Controls.Add(Me.lblshippingdate)
        Me.mainorderpanel.Controls.Add(Me.lbltotalamount)
        Me.mainorderpanel.Controls.Add(Me.Label3)
        Me.mainorderpanel.Controls.Add(Me.lblquan)
        Me.mainorderpanel.Controls.Add(Me.lblshippingaddress)
        Me.mainorderpanel.Controls.Add(Me.Label4)
        Me.mainorderpanel.Controls.Add(Me.lblprice)
        Me.mainorderpanel.Controls.Add(Me.Label5)
        Me.mainorderpanel.Controls.Add(Me.lblproductname)
        Me.mainorderpanel.Controls.Add(Me.Label6)
        Me.mainorderpanel.Controls.Add(Me.Label7)
        Me.mainorderpanel.Controls.Add(Me.Label8)
        Me.mainorderpanel.Location = New System.Drawing.Point(1, -1)
        Me.mainorderpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mainorderpanel.Name = "mainorderpanel"
        Me.mainorderpanel.Size = New System.Drawing.Size(560, 465)
        Me.mainorderpanel.TabIndex = 4
        Me.mainorderpanel.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(41, 386)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(267, 185)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 24)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Rs."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(267, 270)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Rs."
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(-9, 345)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(581, 23)
        Me.BunifuSeparator2.TabIndex = 9
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-19, 100)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(581, 23)
        Me.BunifuSeparator1.TabIndex = 5
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'butplaceorder
        '
        Me.butplaceorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butplaceorder.Location = New System.Drawing.Point(209, 383)
        Me.butplaceorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butplaceorder.Name = "butplaceorder"
        Me.butplaceorder.Size = New System.Drawing.Size(233, 43)
        Me.butplaceorder.TabIndex = 4
        Me.butplaceorder.Text = "Place your Order"
        Me.butplaceorder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(36, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Shipping to:"
        '
        'lblpaymenttype
        '
        Me.lblpaymenttype.AutoSize = True
        Me.lblpaymenttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymenttype.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpaymenttype.Location = New System.Drawing.Point(267, 310)
        Me.lblpaymenttype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaymenttype.Name = "lblpaymenttype"
        Me.lblpaymenttype.Size = New System.Drawing.Size(49, 24)
        Me.lblpaymenttype.TabIndex = 4
        Me.lblpaymenttype.Text = "type"
        '
        'lblshippingdate
        '
        Me.lblshippingdate.AutoSize = True
        Me.lblshippingdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshippingdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblshippingdate.Location = New System.Drawing.Point(311, 68)
        Me.lblshippingdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblshippingdate.Name = "lblshippingdate"
        Me.lblshippingdate.Size = New System.Drawing.Size(50, 24)
        Me.lblshippingdate.TabIndex = 2
        Me.lblshippingdate.Text = "date"
        '
        'lbltotalamount
        '
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltotalamount.Location = New System.Drawing.Point(308, 270)
        Me.lbltotalamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(79, 24)
        Me.lbltotalamount.TabIndex = 5
        Me.lbltotalamount.Text = "amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(36, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Estimated Delivery:"
        '
        'lblquan
        '
        Me.lblquan.AutoSize = True
        Me.lblquan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblquan.Location = New System.Drawing.Point(267, 223)
        Me.lblquan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblquan.Name = "lblquan"
        Me.lblquan.Size = New System.Drawing.Size(57, 24)
        Me.lblquan.TabIndex = 6
        Me.lblquan.Text = "quan"
        '
        'lblshippingaddress
        '
        Me.lblshippingaddress.AutoSize = True
        Me.lblshippingaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshippingaddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblshippingaddress.Location = New System.Drawing.Point(217, 21)
        Me.lblshippingaddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblshippingaddress.Name = "lblshippingaddress"
        Me.lblshippingaddress.Size = New System.Drawing.Size(84, 24)
        Me.lblshippingaddress.TabIndex = 3
        Me.lblshippingaddress.Text = "address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(36, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product Name:"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblprice.Location = New System.Drawing.Point(311, 183)
        Me.lblprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(57, 24)
        Me.lblprice.TabIndex = 7
        Me.lblprice.Text = "price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(36, 180)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price:"
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblproductname.Location = New System.Drawing.Point(267, 139)
        Me.lblproductname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(62, 24)
        Me.lblproductname.TabIndex = 8
        Me.lblproductname.Text = "name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(36, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(36, 265)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(36, 308)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 28)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Payment Type:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Paymentmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShopQuik.My.Resources.Resources.payment_purple
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1937, 775)
        Me.Controls.Add(Me.butend)
        Me.Controls.Add(Me.mainlabel)
        Me.Controls.Add(Me.mainpanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Paymentmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paymentmain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.paymentmainpanel.ResumeLayout(False)
        Me.cashpanel.ResumeLayout(False)
        Me.cashpanel.PerformLayout()
        Me.netbankpanel.ResumeLayout(False)
        Me.netbankpanel.PerformLayout()
        Me.debitpanel.ResumeLayout(False)
        Me.debitpanel.PerformLayout()
        Me.mainpanel.ResumeLayout(False)
        Me.mainorderpanel.ResumeLayout(False)
        Me.mainorderpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainlabel As Label
    Friend WithEvents paymentmainpanel As Panel
    Friend WithEvents cashpanel As Panel
    Friend WithEvents radcash As RadioButton
    Friend WithEvents netbankpanel As Panel
    Friend WithEvents cmbbank As ComboBox
    Friend WithEvents radnetbank As RadioButton
    Friend WithEvents debitpanel As Panel
    Friend WithEvents txtcardnumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents raddebit As RadioButton
    Friend WithEvents butcontinue As Button
    Friend WithEvents butend As Button
    Friend WithEvents mainpanel As Panel
    Friend WithEvents mainorderpanel As Panel
    Friend WithEvents butplaceorder As Button
    Friend WithEvents lblpaymenttype As Label
    Friend WithEvents lbltotalamount As Label
    Friend WithEvents lblquan As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents lblproductname As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblshippingaddress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblshippingdate As Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents butback As Button
    Friend WithEvents Button1 As Button
End Class
