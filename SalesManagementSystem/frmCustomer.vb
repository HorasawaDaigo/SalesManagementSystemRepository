Public Class frmCustomer
    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        'キーが [0]～[9] または [BackSpace] 以外の場合イベントをキャンセル
        If Not (("0"c <= e.KeyChar And e.KeyChar <= "9"c) Or e.KeyChar = ControlChars.Back) Then
            'コントロールの既定の処理を省略する場合は true
            e.Handled = True
        End If
    End Sub

    Private Sub TtxtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        '[Delete] キーを無効にする場合
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

End Class