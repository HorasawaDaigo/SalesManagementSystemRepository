Public Class frmCustomer

    Private Sub frmCustmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBirthday_Leave(sender As Object, e As EventArgs) Handles txtBirthday.Leave

        Common.ageCalc(Me)
        Common.signCalc(Me)

        txtAge.Text = Common.ageCalc(Me)
        txtSign.Text = Common.signCalc(Me)

        Dim today = DateTime.Now
        If (txtBirthday.Text > today) Then
            txtBirthday.Text = ""
            txtAge.Text = ""
            txtSign.Text = ""
        End If

    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click

        sqlClass.regist(Me, Common.GetGender(Me), Common.GetBloodType(Me))

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        sqlClass.delete(Me)

    End Sub
End Class