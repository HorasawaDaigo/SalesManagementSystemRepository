Public Class Common

    Public Shared Function ageCalc(customer As Form) As Integer

        'フォーム内から値を取得し格納する為の変数
        Dim formDate As DateTime

        '今日の日付を取得
        Dim today = DateTime.Now

        '値を格納
        formDate = DateTime.ParseExact(customer.Controls("txtBirthday").Text, "yyyy/MM/dd", Nothing)

        '年齢の計算
        Dim age As Integer = today.Year - formDate.Year

        If (formDate > today.AddYears(-age)) Then
            age -= 1
        End If

        Return age

    End Function


    Public Shared Function signCalc(customer As Form) As String

        'フォーム内から値を取得し格納する為の変数
        Dim formDate As DateTime

        '値を格納
        formDate = DateTime.ParseExact(customer.Controls("txtBirthday").Text, "yyyy/MM/dd", Nothing)

        Dim month As Integer = formDate.Month
        Dim day As Integer = formDate.Day

        Dim Sign As String
        If (month = 1) Then
            If (day <= 20) Then
                Sign = "やぎ座"
            End If
            If (day >= 21) Then
                Sign = "みずがめ座"
            End If
        End If
        If (month = 2) Then
            If (day <= 18) Then
                Sign = "みずがめ座"
            End If
            If (day >= 19) Then
                Sign = "うお座"
            End If
        End If
        If (month = 3) Then
            If (day <= 20) Then
                Sign = "うお座"
            End If
            If (day >= 21) Then
                Sign = "おひつじ座"
            End If
        End If
        If (month = 4) Then
            If (day <= 19) Then
                Sign = "おひつじ座"
            End If
            If (day >= 20) Then
                Sign = "おうし座"
            End If
        End If
        If (month = 5) Then
            If (day <= 20) Then
                Sign = "おうし座"
            End If
            If (day >= 21) Then
                Sign = "ふたご座"
            End If
        End If
        If (month = 6) Then
            If (day <= 21) Then
                Sign = "ふたご座"
            End If
            If (day >= 22) Then
                Sign = "かに座"
            End If
        End If
        If (month = 7) Then
            If (day <= 22) Then
                Sign = "かに座"
            End If
            If (day >= 23) Then
                Sign = "しし座"
            End If
        End If
        If (month = 8) Then
            If (day <= 22) Then
                Sign = "しし座"
            End If
            If (day >= 23) Then
                Sign = "おとめ座"
            End If
        End If
        If (month = 9) Then
            If (day <= 22) Then
                Sign = "おとめ座"
            End If
            If (day >= 23) Then
                Sign = "てんびん座"
            End If
        End If
        If (month = 10) Then
            If (day <= 23) Then
                Sign = "てんびん座"
            End If
            If (day >= 24) Then
                Sign = "さそり座"
            End If
        End If
        If (month = 11) Then
            If (day <= 22) Then
                Sign = "さそり座"
            End If
            If (day >= 23) Then
                Sign = "いて座"
            End If
        End If
        If (month = 12) Then
            If (day <= 21) Then
                Sign = "いて座"
            End If
            If (day >= 23) Then
                Sign = "やぎ座"
            End If
        End If

        Return Sign

    End Function

    Public Shared Function GetGender(customer As Form) As String
        Dim gender As String = ""
        For Each rbtGender As Windows.Forms.RadioButton In customer.Controls("pnlGender").Controls
            If rbtGender.Checked Then
                gender = rbtGender.Text
            End If
        Next
        Return gender
    End Function

    Public Shared Function GetBloodType(customer As Form) As String
        Dim bloodType As String = ""
        For Each rbtBloodType As Windows.Forms.RadioButton In customer.Controls("pnlBloodType").Controls
            If rbtBloodType.Checked Then
                bloodType = rbtBloodType.Text
            End If
        Next
        Return bloodType
    End Function


End Class
