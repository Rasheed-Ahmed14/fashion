Public Class customization
    Private Sub butshirt_Click(sender As Object, e As EventArgs) Handles butshirt.Click
        Dim type As String = "Shirts"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, Usermain.usermainpanel)
    End Sub

    Private Sub butpant_Click(sender As Object, e As EventArgs) Handles butpant.Click
        Dim type As String = "Pants"
        UserMainHome.Controls.Clear()
        str = "select * from ProductDetails where ProductType='" & type & "'"
        product(str, UserMainHome)
        panelswitch(UserMainHome, Usermain.usermainpanel)
    End Sub

    Private Sub customization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim pant = "Pants"
        'Dim shirt = "Shirts"
        'str = "select * from Customization where ProductType='" & pant & "'"
        'table = Database(str)
        'If table.Rows.Count > 0 Then
        'str = "select * from ProductDetails where ProductName='" & table.Rows(0)(0) & "'"
        'table = Database(str)
        'RetrieveImage(pctpant, 0, 6)
        'End If
        'str = "select * from Customization where ProductType='" & shirt & "'"
        'table = Database(str)
        'If table.Rows.Count > 0 Then
        'str = "select * from ProductDetails where ProductName='" & table.Rows(0)(0) & "'"
        'table = Database(str)
        'RetrieveImage(pctshirt, 0, 6)
        'End If
    End Sub

    Private Sub pctpant_Click(sender As Object, e As EventArgs) Handles pctpant.Click

    End Sub

    Private Sub pctshirt_Click(sender As Object, e As EventArgs) Handles pctshirt.Click

    End Sub
End Class