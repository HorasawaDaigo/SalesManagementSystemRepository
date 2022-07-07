Public Class frmCustomer
    Public dt As DataTable
    Private Sub frmCustmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsNothing(Me.dt) Then
            Exit Sub
        End If
        Dim row As DataRow = dt.Rows(0)
        For Each ctrl As Windows.Forms.Control In Me.Controls
            If Not ctrl.Name.StartsWith("lbl") AndAlso Not ctrl.Name.StartsWith("btn") AndAlso Not ctrl.Name.StartsWith("rbt") Then
                If ctrl.Name.StartsWith("txt") OrElse ctrl.Name.StartsWith("cbo") Then
                    ctrl.Text = row(ctrl.Name.Substring(3)).ToString
                End If
                If ctrl.Name.StartsWith("pnl") Then
                    For Each rbt As Windows.Forms.RadioButton In ctrl.Controls
                        If rbt.Text = row(ctrl.Name.Substring(3)).ToString Then
                            rbt.Checked = True
                        End If
                    Next
                End If
            End If
        Next

    End Sub

    Private Sub txtBirthday_Leave(sender As Object, e As EventArgs) Handles txtBirthday.Leave

        Common.ageCalc(Me)
        Common.signCalc(Me)
        Check(Me)

    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click

        sqlClass.regist(Me, Common.GetGender(Me), Common.GetBloodType(Me))

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        sqlClass.delete(Me)

    End Sub
End Class