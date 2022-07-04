Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 遷移先のフォームのインスタンスを作成
        Dim moveScreen As New frmMenu
        ' 遷移先のフォームを表示
        moveScreen.Show()
        ' 遷移後の画面非表示
        Me.Visible = False
    End Sub
End Class