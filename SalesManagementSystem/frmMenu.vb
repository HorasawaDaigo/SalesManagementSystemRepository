Public Class frmMenu
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        ' 遷移先のフォームのインスタンスを作成
        Dim moveScreen As New frmCustomer
        ' 遷移先のフォームを表示
        moveScreen.Show()
        ' 遷移後の画面非表示
        Me.Visible = False
    End Sub
    Private Sub btnCustomerList_Click(sender As Object, e As EventArgs) Handles btnCustomerList.Click
        ' 遷移先のフォームのインスタンスを作成
        Dim moveScreen As New frmCustomerList
        ' 遷移先のフォームを表示
        moveScreen.Show()
        ' 遷移後の画面非表示
        Me.Visible = False
    End Sub
End Class