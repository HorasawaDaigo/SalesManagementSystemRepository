Public Class frmCustomerList
    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        sqlClass.sqlSearch(Me)
        dgdList.DataSource = sqlClass.sqlSearch(Me)

        'DataGridViewButtonColumnの作成
        Dim columnSelect As New DataGridViewButtonColumn()
        '列の名前を設定
        columnSelect.Name = "btnSelect"
        '全てのボタンに"選択"と表示する
        columnSelect.UseColumnTextForButtonValue = True
        columnSelect.Text = "選択"
        'DataGridViewに追加する
        dgdList.Columns.Add(columnSelect)

        'DataGridViewButtonColumnの作成
        Dim columnDelete As New DataGridViewButtonColumn()
        '列の名前を設定
        columnDelete.Name = "btnDelete"
        '全てのボタンに"削除"と表示する
        columnDelete.UseColumnTextForButtonValue = True
        columnDelete.Text = "削除"
        'DataGridViewに追加する
        dgdList.Columns.Add(columnDelete)

    End Sub

    Private Sub dgdList_CellContentClick(ByVal sender As Object,
        ByVal e As DataGridViewCellEventArgs) Handles dgdList.CellContentClick

        Dim dgv As DataGridView = CType(sender, DataGridView)
        If dgv.Columns(e.ColumnIndex).Name = "btnSelect" Then

            Dim dt As DataTable = sqlClass.inputInformation(Me)

            ' 遷移先のフォームのインスタンスを作成
            Dim moveScreen As New frmCustomer
            moveScreen.dt = dt
            ' 遷移先のフォームを表示
            moveScreen.Show()
            ' 遷移後の画面非表示
            Me.Visible = False

        End If
        If dgv.Columns(e.ColumnIndex).Name = "btnDelete" Then

            sqlClass.delete(Me)

        End If

    End Sub
End Class