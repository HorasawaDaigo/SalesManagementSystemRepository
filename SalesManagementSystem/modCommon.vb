Module modCommon
    Public Sub Check(customer As Form)

        Dim Common As New Common
        Dim today = DateTime.Now

        If (customer.Controls("txtBirthday").Text <= today) Then
            customer.Controls("txtAge").Text = Common.ageCalc(customer)
            customer.Controls("txtSign").Text = Common.signCalc(customer)
        End If
        If (customer.Controls("txtBirthday").Text > today) Then
            customer.Controls("txtBirthday").Text = ""
            customer.Controls("txtAge").Text = ""
            customer.Controls("txtSign").Text = ""
        End If

    End Sub
End Module
