Imports System.Data.SqlClient
Imports System.IO

Module MainModule
    Dim mybutton() As Button
    Public table As New DataTable()
    Public OpenFileDialog1 As New OpenFileDialog
    Public str As String
    Public con As New SqlConnection("server=LAPTOP-LKGQCRID\RASHEED;database=ShopQuik;integrated security=True")

    Public Function Database(ByVal str As String)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim command As New SqlCommand(str, con)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Return table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Sub panelswitch(ByVal form As Form, ByVal panel As Panel)
        Try
            panel.Controls.Clear()
            form.TopLevel = False
            panel.Controls.Add(form)
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SelectImage(ByVal pctbox As PictureBox)
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "(*.PNG;*.JPG;*.GIF;*JPEG)|*.png;*.jpg;*.gif;*.jpeg"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                pctbox.Image = Nothing
                pctbox.Image = Image.FromFile(OpenFileDialog1.FileName)
                pctbox.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ConvertImage(ByVal pctbox As PictureBox)
        Try
            Dim ms As New MemoryStream()
            pctbox.Image.Save(ms, pctbox.Image.RawFormat)
            Return ms
        Catch ex As Exception

        End Try
    End Function
    Public Sub RetrieveImage(ByVal pctbox As PictureBox, ByVal r As Integer, ByVal c As Integer)
        Try

            Dim img() As Byte
            img = table.Rows(r)(c)
            Dim ms1 As New MemoryStream(img)
            pctbox.Image = Image.FromStream(ms1)
            pctbox.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RetrieveImagebut(ByVal but As Button, ByVal r As Integer, ByVal c As Integer)
        Try

            Dim img() As Byte
            img = table.Rows(r)(c)
            Dim m As New MemoryStream(img)
            but.BackgroundImage = Image.FromStream(m)
            but.BackgroundImageLayout = ImageLayout.Stretch

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub dynamicbut(ByVal frm As Form)
        Try
            CartMain.Controls.Clear()
            Dim table1 As New DataTable
            str = "select * from CartDetails Where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table1 = Database(str)
            Dim totprod As Integer = table1.Rows.Count
            CartMain.lblcaption.Visible = False
            ReDim mybutton(totprod)
            Dim rownum As Integer = 0
            Dim topval As Integer = 100
            Dim leftval As Integer = 0
            Dim prdid As String
            For j = 0 To totprod - 1
                prdid = table1.Rows(j)(1)
                If rownum = 4 Then
                    topval = 150 + (j * 60)
                    rownum = 0
                    leftval = 0
                End If
                str = "select * from ProductDetails where ProductID='" & prdid & "'"
                Dim tab1 As New DataTable
                table.Clear()
                table = Database(str)
                mybutton(j) = New Button
                With mybutton(j)
                    .Name = table.Rows(0)(1)
                    '.Text = table.Rows(0)(1)
                    RetrieveImagebut(mybutton(j), 0, 6)
                    .BackgroundImageLayout = ImageLayout.Stretch
                    .TextImageRelation = TextImageRelation.ImageBeforeText
                    .Width = 150
                    .Height = 250
                    .Top = topval
                    .Left = 50 + (leftval * 200)
                    .TextAlign = ContentAlignment.BottomCenter
                    .Font = New Font("consolas", 16, FontStyle.Bold)
                    leftval += 1
                    AddHandler .Click, AddressOf mymessage
                End With
                rownum += 1
                frm.Controls.Add(mybutton(j))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub product(ByVal st As String, ByVal frm As Form)

        table.Clear()
        table = Database(st)
        Dim totprod As Integer = table.Rows.Count
        If totprod > 0 Then
            If frm.Name = UserMainHome.Name Then
                UserMainHome.lblcaption.Visible = False
            End If
            ReDim mybutton(totprod)
            Dim rownum As Integer = 0
            Dim topval As Integer = 100
            Dim leftval As Integer = 0
            For i = 0 To totprod - 1
                If rownum = 6 Then
                    topval = 150 + (i * 60)
                    rownum = 0
                    leftval = 0
                End If
                mybutton(i) = New Button
                With mybutton(i)
                    .Name = table.Rows(i)(1)
                    '.Text = table.Rows(i)(1)
                    .Width = 150
                    .Height = 250
                    .Top = topval
                    .Left = 50 + (leftval * 200)
                    .TextAlign = ContentAlignment.BottomCenter
                    .Font = New Font("consolas", 16, FontStyle.Bold)
                    .BackgroundImageLayout = ImageLayout.Stretch
                    RetrieveImagebut(mybutton(i), i, 6)
                    leftval += 1
                    AddHandler .Click, AddressOf mymessage
                End With
                rownum += 1
                frm.Controls.Add(mybutton(i))
            Next
        Else
            UserMainHome.Controls.Clear()
            UserMainHome.Controls.Add(UserMainHome.lblcaption)
            UserMainHome.lblcaption.Visible = True
        End If
    End Sub
    Private Sub mymessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        str = "Select * from ProductDetails where ProductName='" & sender.name & "'"
        table = Database(str)
        BuyForm.LblName.Text = sender.name
        BuyForm.pctbuyform.BackgroundImage = sender.backgroundimage
        BuyForm.pctbuyform.BackgroundImageLayout = ImageLayout.Stretch
        BuyForm.lblprice.Text = table.Rows(0)(2)
        Dim prdid As String = table.Rows(0)(0)
        Dim n As Integer = table.Rows(0)(4)
        BuyForm.cmbquantity.Items.Clear()
        For i = 1 To n
            BuyForm.cmbquantity.Items.Add(i)
        Next
        If BuyForm.ButAddToCart.Name = "butremove" Then
            str = "select * from CartDetails Where MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table = Database(str)
            'BuyForm.cmbquantity.Text = table.Rows(0)(2)
            panelswitch(BuyForm, Usermain.usermainpanel)
        Else
            str = "select * from CartDetails where ProductID='" & prdid & "' and MobileNumber='" & LoginMain.TxtUserId.Text & "'"
            table = Database(str)
            If table.Rows.Count > 0 Then
                BuyForm.ButAddToCart.Enabled = False
            Else
                BuyForm.ButAddToCart.Enabled = True
            End If
            panelswitch(BuyForm, Usermain.usermainpanel)
        End If
    End Sub
End Module
