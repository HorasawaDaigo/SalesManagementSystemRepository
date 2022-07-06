Public Class sqlClass

    Public Shared Sub regist(customer As Form, gender As String, bloodType As String)

        Using Conn As New System.Data.SqlClient.SqlConnection
            Conn.ConnectionString =
                   ("Data Source=INF-21-022X\SQLEXPRESS;" &
                    "Initial Catalog=SalesManagementSystem;" &
                    "Integrated Security=SSPI;")
            Conn.Open()
            Dim cd As New SqlClient.SqlCommand
            Dim SQL1 As String
            'SQL文生成
            SQL1 = ""
            SQL1 &= "INSERT INTO frmCustomer"
            SQL1 &= "("
            SQL1 &= "Code,"
            SQL1 &= "Name,"
            SQL1 &= "NameKana,"
            SQL1 &= "PostCode,"
            SQL1 &= "Prefectures,"
            SQL1 &= "Municipalities,"
            SQL1 &= "Address,"
            SQL1 &= "Tel,"
            SQL1 &= "Fax,"
            SQL1 &= "Memo,"
            SQL1 &= "ManagerName,"
            SQL1 &= "Department,"
            SQL1 &= "Position,"
            SQL1 &= "HonorificTitle,"
            SQL1 &= "Email,"
            SQL1 &= "Gender,"
            SQL1 &= "BloodType,"
            SQL1 &= "Birthday,"
            SQL1 &= "Age,"
            SQL1 &= "Sign,"
            SQL1 &= "PhoneNumber,"
            SQL1 &= "Register,"
            SQL1 &= "Updater,"
            SQL1 &= "ResistDate,"
            SQL1 &= "UpdateDate"
            SQL1 &= ")"
            SQL1 &= "VALUES"
            SQL1 &= "("
            SQL1 &= customer.Controls("txtCode").Text & ","
            SQL1 &= "'" & customer.Controls("txtName").Text & "',"
            SQL1 &= "'" & customer.Controls("txtNameKana").Text & "',"
            SQL1 &= "'" & customer.Controls("txtPostCode").Text & "',"
            SQL1 &= "'" & customer.Controls("cboPrefectures").Text & "',"
            SQL1 &= "'" & customer.Controls("txtMunicipalities").Text & "',"
            SQL1 &= "'" & customer.Controls("txtAddress").Text & "',"
            SQL1 &= "'" & customer.Controls("txtTel").Text & "',"
            SQL1 &= "'" & customer.Controls("txtFax").Text & "',"
            SQL1 &= "'" & customer.Controls("txtMemo").Text & "',"
            SQL1 &= "'" & customer.Controls("txtManagerName").Text & "',"
            SQL1 &= "'" & customer.Controls("txtDepartment").Text & "',"
            SQL1 &= "'" & customer.Controls("txtPosition").Text & "',"
            SQL1 &= "'" & customer.Controls("cboHonorificTitle").Text & "',"
            SQL1 &= "'" & customer.Controls("txtEmail").Text & "',"
            SQL1 &= "'" & gender & "',"
            SQL1 &= "'" & bloodType & "',"
            SQL1 &= "'" & customer.Controls("txtBirthday").Text & "',"
            SQL1 &= "'" & customer.Controls("txtAge").Text & "',"
            SQL1 &= "'" & customer.Controls("txtSign").Text & "',"
            SQL1 &= "'" & customer.Controls("txtPhoneNumber").Text & "',"
            SQL1 &= "'" & customer.Controls("txtRegister").Text & "',"
            SQL1 &= "'" & customer.Controls("txtUpdater").Text & "',"
            SQL1 &= "'" & customer.Controls("txtResistDate").Text & "',"
            SQL1 &= "'" & customer.Controls("txtUpdateDate").Text & "'"
            SQL1 &= ")"
            'SQLコマンド設定
            cd.CommandText = SQL1
            cd.Connection = Conn
            cd.ExecuteNonQuery()

        End Using

    End Sub

    Public Shared Sub delete(customer As Form)

        Using Conn As New System.Data.SqlClient.SqlConnection

            Conn.ConnectionString =
                   ("Data Source=INF-21-022X\SQLEXPRESS;" &
                    "Initial Catalog=SalesManagementSystem;" &
                    "Integrated Security=SSPI;")
            Conn.Open()

            Dim cd As New SqlClient.SqlCommand
            Dim SQL1 As String

            'SQL文生成
            SQL1 = ""
            SQL1 &= "DELETE FROM frmCustomer WHERE"
            SQL1 &= "("
            SQL1 &= "Code ="
            SQL1 &= "'" & customer.Controls("txtCode").Text & "'"
            SQL1 &= ")"

            'SQLコマンド設定
            cd.CommandText = SQL1
            cd.Connection = Conn
            cd.ExecuteNonQuery()

        End Using

    End Sub

End Class
