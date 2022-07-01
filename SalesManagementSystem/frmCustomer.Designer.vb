<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCustmerCode = New System.Windows.Forms.Label()
        Me.txtCustmerCode = New System.Windows.Forms.TextBox()
        Me.lblCusttmerName = New System.Windows.Forms.Label()
        Me.txtCustmerName = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtMunicipalities = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtCustmerNameKana = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblMunicipalities = New System.Windows.Forms.Label()
        Me.lblPrefectures = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblCustmerNameKana = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblMemo = New System.Windows.Forms.Label()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblHonorificTitle = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblManagerName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblBloodType = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtHonorificTitle = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.txtManagerName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtSign = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.rbtMen = New System.Windows.Forms.RadioButton()
        Me.rbtAB = New System.Windows.Forms.RadioButton()
        Me.rbtO = New System.Windows.Forms.RadioButton()
        Me.rbtB = New System.Windows.Forms.RadioButton()
        Me.rbtA = New System.Windows.Forms.RadioButton()
        Me.rbtWomen = New System.Windows.Forms.RadioButton()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.lblResistDate = New System.Windows.Forms.Label()
        Me.lblUpdater = New System.Windows.Forms.Label()
        Me.txtUpdateDate = New System.Windows.Forms.TextBox()
        Me.txtResistDate = New System.Windows.Forms.TextBox()
        Me.txtUpdater = New System.Windows.Forms.TextBox()
        Me.txtRegister = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboPrefectures = New System.Windows.Forms.ComboBox()
        Me.pnlGender = New System.Windows.Forms.Panel()
        Me.pnlBloodType = New System.Windows.Forms.Panel()
        Me.lblManagerForm = New System.Windows.Forms.Label()
        Me.pnlGender.SuspendLayout()
        Me.pnlBloodType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustmerCode
        '
        Me.lblCustmerCode.AutoSize = True
        Me.lblCustmerCode.Location = New System.Drawing.Point(83, 113)
        Me.lblCustmerCode.Name = "lblCustmerCode"
        Me.lblCustmerCode.Size = New System.Drawing.Size(85, 15)
        Me.lblCustmerCode.TabIndex = 0
        Me.lblCustmerCode.Text = "得意先コード"
        '
        'txtCustmerCode
        '
        Me.txtCustmerCode.Location = New System.Drawing.Point(196, 110)
        Me.txtCustmerCode.Name = "txtCustmerCode"
        Me.txtCustmerCode.Size = New System.Drawing.Size(100, 22)
        Me.txtCustmerCode.TabIndex = 1
        '
        'lblCusttmerName
        '
        Me.lblCusttmerName.AutoSize = True
        Me.lblCusttmerName.Location = New System.Drawing.Point(83, 142)
        Me.lblCusttmerName.Name = "lblCusttmerName"
        Me.lblCusttmerName.Size = New System.Drawing.Size(67, 15)
        Me.lblCusttmerName.TabIndex = 2
        Me.lblCusttmerName.Text = "得意先名"
        '
        'txtCustmerName
        '
        Me.txtCustmerName.Location = New System.Drawing.Point(196, 138)
        Me.txtCustmerName.Name = "txtCustmerName"
        Me.txtCustmerName.Size = New System.Drawing.Size(100, 22)
        Me.txtCustmerName.TabIndex = 3
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(196, 309)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 22)
        Me.txtTel.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(196, 281)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtAddress.TabIndex = 5
        '
        'txtMunicipalities
        '
        Me.txtMunicipalities.Location = New System.Drawing.Point(196, 254)
        Me.txtMunicipalities.Name = "txtMunicipalities"
        Me.txtMunicipalities.Size = New System.Drawing.Size(100, 22)
        Me.txtMunicipalities.TabIndex = 6
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(196, 197)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(100, 22)
        Me.txtPostCode.TabIndex = 7
        '
        'txtCustmerNameKana
        '
        Me.txtCustmerNameKana.Location = New System.Drawing.Point(196, 169)
        Me.txtCustmerNameKana.Name = "txtCustmerNameKana"
        Me.txtCustmerNameKana.Size = New System.Drawing.Size(100, 22)
        Me.txtCustmerNameKana.TabIndex = 8
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(83, 283)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(97, 15)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "上記以降住所"
        '
        'lblMunicipalities
        '
        Me.lblMunicipalities.AutoSize = True
        Me.lblMunicipalities.Location = New System.Drawing.Point(83, 257)
        Me.lblMunicipalities.Name = "lblMunicipalities"
        Me.lblMunicipalities.Size = New System.Drawing.Size(67, 15)
        Me.lblMunicipalities.TabIndex = 10
        Me.lblMunicipalities.Text = "市区町村"
        '
        'lblPrefectures
        '
        Me.lblPrefectures.AutoSize = True
        Me.lblPrefectures.Location = New System.Drawing.Point(83, 226)
        Me.lblPrefectures.Name = "lblPrefectures"
        Me.lblPrefectures.Size = New System.Drawing.Size(67, 15)
        Me.lblPrefectures.TabIndex = 11
        Me.lblPrefectures.Text = "都道府県"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(83, 197)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(67, 15)
        Me.lblPostCode.TabIndex = 12
        Me.lblPostCode.Text = "郵便番号"
        '
        'lblCustmerNameKana
        '
        Me.lblCustmerNameKana.AutoSize = True
        Me.lblCustmerNameKana.Location = New System.Drawing.Point(83, 169)
        Me.lblCustmerNameKana.Name = "lblCustmerNameKana"
        Me.lblCustmerNameKana.Size = New System.Drawing.Size(90, 15)
        Me.lblCustmerNameKana.TabIndex = 13
        Me.lblCustmerNameKana.Text = "得意先名カナ"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(83, 312)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(32, 15)
        Me.lblTel.TabIndex = 14
        Me.lblTel.Text = "TEL"
        '
        'lblMemo
        '
        Me.lblMemo.AutoSize = True
        Me.lblMemo.Location = New System.Drawing.Point(87, 338)
        Me.lblMemo.Name = "lblMemo"
        Me.lblMemo.Size = New System.Drawing.Size(28, 15)
        Me.lblMemo.TabIndex = 15
        Me.lblMemo.Text = "メモ"
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(196, 338)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(136, 59)
        Me.txtMemo.TabIndex = 16
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(447, 229)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 15)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.Text = "e-mail"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(447, 173)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(37, 15)
        Me.lblPosition.TabIndex = 18
        Me.lblPosition.Text = "役職"
        '
        'lblHonorificTitle
        '
        Me.lblHonorificTitle.AutoSize = True
        Me.lblHonorificTitle.Location = New System.Drawing.Point(447, 205)
        Me.lblHonorificTitle.Name = "lblHonorificTitle"
        Me.lblHonorificTitle.Size = New System.Drawing.Size(37, 15)
        Me.lblHonorificTitle.TabIndex = 19
        Me.lblHonorificTitle.Text = "敬称"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(447, 142)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(37, 15)
        Me.lblDepartment.TabIndex = 20
        Me.lblDepartment.Text = "部署"
        '
        'lblManagerName
        '
        Me.lblManagerName.AutoSize = True
        Me.lblManagerName.Location = New System.Drawing.Point(447, 113)
        Me.lblManagerName.Name = "lblManagerName"
        Me.lblManagerName.Size = New System.Drawing.Size(67, 15)
        Me.lblManagerName.TabIndex = 21
        Me.lblManagerName.Text = "担当者名"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(447, 364)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 15)
        Me.lblAge.TabIndex = 22
        Me.lblAge.Text = "年齢"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(447, 338)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(67, 15)
        Me.lblBirthday.TabIndex = 23
        Me.lblBirthday.Text = "生年月日"
        '
        'lblBloodType
        '
        Me.lblBloodType.AutoSize = True
        Me.lblBloodType.Location = New System.Drawing.Point(447, 295)
        Me.lblBloodType.Name = "lblBloodType"
        Me.lblBloodType.Size = New System.Drawing.Size(52, 15)
        Me.lblBloodType.TabIndex = 24
        Me.lblBloodType.Text = "血液型"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(447, 262)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(37, 15)
        Me.lblGender.TabIndex = 25
        Me.lblGender.Text = "性別"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Location = New System.Drawing.Point(83, 465)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(52, 15)
        Me.lblRegister.TabIndex = 26
        Me.lblRegister.Text = "登録者"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(447, 423)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(67, 15)
        Me.lblPhoneNumber.TabIndex = 27
        Me.lblPhoneNumber.Text = "携帯番号"
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Location = New System.Drawing.Point(447, 392)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(37, 15)
        Me.lblSign.TabIndex = 28
        Me.lblSign.Text = "星座"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(520, 226)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtEmail.TabIndex = 29
        '
        'txtHonorificTitle
        '
        Me.txtHonorificTitle.Location = New System.Drawing.Point(520, 198)
        Me.txtHonorificTitle.Name = "txtHonorificTitle"
        Me.txtHonorificTitle.Size = New System.Drawing.Size(100, 22)
        Me.txtHonorificTitle.TabIndex = 30
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(520, 170)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 22)
        Me.txtPosition.TabIndex = 31
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(520, 142)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(100, 22)
        Me.txtDepartment.TabIndex = 32
        '
        'txtManagerName
        '
        Me.txtManagerName.Location = New System.Drawing.Point(520, 110)
        Me.txtManagerName.Name = "txtManagerName"
        Me.txtManagerName.Size = New System.Drawing.Size(100, 22)
        Me.txtManagerName.TabIndex = 33
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(519, 420)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtPhoneNumber.TabIndex = 34
        '
        'txtSign
        '
        Me.txtSign.Location = New System.Drawing.Point(519, 392)
        Me.txtSign.Name = "txtSign"
        Me.txtSign.Size = New System.Drawing.Size(100, 22)
        Me.txtSign.TabIndex = 35
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(519, 364)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 22)
        Me.txtAge.TabIndex = 36
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(519, 335)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(100, 22)
        Me.txtBirthday.TabIndex = 37
        '
        'rbtMen
        '
        Me.rbtMen.AutoSize = True
        Me.rbtMen.Location = New System.Drawing.Point(3, 8)
        Me.rbtMen.Name = "rbtMen"
        Me.rbtMen.Size = New System.Drawing.Size(43, 19)
        Me.rbtMen.TabIndex = 38
        Me.rbtMen.TabStop = True
        Me.rbtMen.Text = "男"
        Me.rbtMen.UseVisualStyleBackColor = True
        '
        'rbtAB
        '
        Me.rbtAB.AutoSize = True
        Me.rbtAB.Location = New System.Drawing.Point(141, 12)
        Me.rbtAB.Name = "rbtAB"
        Me.rbtAB.Size = New System.Drawing.Size(47, 19)
        Me.rbtAB.TabIndex = 39
        Me.rbtAB.TabStop = True
        Me.rbtAB.Text = "AB"
        Me.rbtAB.UseVisualStyleBackColor = True
        '
        'rbtO
        '
        Me.rbtO.AutoSize = True
        Me.rbtO.Location = New System.Drawing.Point(96, 12)
        Me.rbtO.Name = "rbtO"
        Me.rbtO.Size = New System.Drawing.Size(39, 19)
        Me.rbtO.TabIndex = 40
        Me.rbtO.TabStop = True
        Me.rbtO.Text = "O"
        Me.rbtO.UseVisualStyleBackColor = True
        '
        'rbtB
        '
        Me.rbtB.AutoSize = True
        Me.rbtB.Location = New System.Drawing.Point(47, 12)
        Me.rbtB.Name = "rbtB"
        Me.rbtB.Size = New System.Drawing.Size(38, 19)
        Me.rbtB.TabIndex = 41
        Me.rbtB.TabStop = True
        Me.rbtB.Text = "B"
        Me.rbtB.UseVisualStyleBackColor = True
        '
        'rbtA
        '
        Me.rbtA.AutoSize = True
        Me.rbtA.Location = New System.Drawing.Point(3, 12)
        Me.rbtA.Name = "rbtA"
        Me.rbtA.Size = New System.Drawing.Size(37, 19)
        Me.rbtA.TabIndex = 42
        Me.rbtA.TabStop = True
        Me.rbtA.Text = "A"
        Me.rbtA.UseVisualStyleBackColor = True
        '
        'rbtWomen
        '
        Me.rbtWomen.AutoSize = True
        Me.rbtWomen.Location = New System.Drawing.Point(52, 8)
        Me.rbtWomen.Name = "rbtWomen"
        Me.rbtWomen.Size = New System.Drawing.Size(43, 19)
        Me.rbtWomen.TabIndex = 43
        Me.rbtWomen.TabStop = True
        Me.rbtWomen.Text = "女"
        Me.rbtWomen.UseVisualStyleBackColor = True
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.AutoSize = True
        Me.lblUpdateDate.Location = New System.Drawing.Point(332, 510)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(67, 15)
        Me.lblUpdateDate.TabIndex = 44
        Me.lblUpdateDate.Text = "更新日時"
        '
        'lblResistDate
        '
        Me.lblResistDate.AutoSize = True
        Me.lblResistDate.Location = New System.Drawing.Point(332, 465)
        Me.lblResistDate.Name = "lblResistDate"
        Me.lblResistDate.Size = New System.Drawing.Size(67, 15)
        Me.lblResistDate.TabIndex = 45
        Me.lblResistDate.Text = "登録日時"
        '
        'lblUpdater
        '
        Me.lblUpdater.AutoSize = True
        Me.lblUpdater.Location = New System.Drawing.Point(83, 510)
        Me.lblUpdater.Name = "lblUpdater"
        Me.lblUpdater.Size = New System.Drawing.Size(52, 15)
        Me.lblUpdater.TabIndex = 46
        Me.lblUpdater.Text = "更新者"
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.Location = New System.Drawing.Point(414, 507)
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.Size = New System.Drawing.Size(100, 22)
        Me.txtUpdateDate.TabIndex = 47
        '
        'txtResistDate
        '
        Me.txtResistDate.Location = New System.Drawing.Point(414, 462)
        Me.txtResistDate.Name = "txtResistDate"
        Me.txtResistDate.Size = New System.Drawing.Size(100, 22)
        Me.txtResistDate.TabIndex = 48
        '
        'txtUpdater
        '
        Me.txtUpdater.Location = New System.Drawing.Point(152, 507)
        Me.txtUpdater.Name = "txtUpdater"
        Me.txtUpdater.Size = New System.Drawing.Size(100, 22)
        Me.txtUpdater.TabIndex = 49
        '
        'txtRegister
        '
        Me.txtRegister.Location = New System.Drawing.Point(152, 462)
        Me.txtRegister.Name = "txtRegister"
        Me.txtRegister.Size = New System.Drawing.Size(100, 22)
        Me.txtRegister.TabIndex = 50
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(311, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(148, 25)
        Me.lblTitle.TabIndex = 51
        Me.lblTitle.Text = "得意先マスタ"
        '
        'btnRegist
        '
        Me.btnRegist.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRegist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegist.Location = New System.Drawing.Point(577, 519)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(75, 23)
        Me.btnRegist.TabIndex = 52
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(678, 519)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 53
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cboPrefectures
        '
        Me.cboPrefectures.FormattingEnabled = True
        Me.cboPrefectures.Location = New System.Drawing.Point(196, 226)
        Me.cboPrefectures.Name = "cboPrefectures"
        Me.cboPrefectures.Size = New System.Drawing.Size(80, 23)
        Me.cboPrefectures.TabIndex = 54
        '
        'pnlGender
        '
        Me.pnlGender.Controls.Add(Me.rbtMen)
        Me.pnlGender.Controls.Add(Me.rbtWomen)
        Me.pnlGender.Location = New System.Drawing.Point(520, 254)
        Me.pnlGender.Name = "pnlGender"
        Me.pnlGender.Size = New System.Drawing.Size(129, 31)
        Me.pnlGender.TabIndex = 55
        '
        'pnlBloodType
        '
        Me.pnlBloodType.Controls.Add(Me.rbtA)
        Me.pnlBloodType.Controls.Add(Me.rbtAB)
        Me.pnlBloodType.Controls.Add(Me.rbtO)
        Me.pnlBloodType.Controls.Add(Me.rbtB)
        Me.pnlBloodType.Location = New System.Drawing.Point(519, 291)
        Me.pnlBloodType.Name = "pnlBloodType"
        Me.pnlBloodType.Size = New System.Drawing.Size(200, 33)
        Me.pnlBloodType.TabIndex = 56
        '
        'lblManagerForm
        '
        Me.lblManagerForm.AutoSize = True
        Me.lblManagerForm.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblManagerForm.Location = New System.Drawing.Point(520, 78)
        Me.lblManagerForm.Name = "lblManagerForm"
        Me.lblManagerForm.Size = New System.Drawing.Size(98, 17)
        Me.lblManagerForm.TabIndex = 57
        Me.lblManagerForm.Text = "担当者情報"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 628)
        Me.Controls.Add(Me.lblManagerForm)
        Me.Controls.Add(Me.pnlBloodType)
        Me.Controls.Add(Me.pnlGender)
        Me.Controls.Add(Me.cboPrefectures)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtRegister)
        Me.Controls.Add(Me.txtUpdater)
        Me.Controls.Add(Me.txtResistDate)
        Me.Controls.Add(Me.txtUpdateDate)
        Me.Controls.Add(Me.lblUpdater)
        Me.Controls.Add(Me.lblResistDate)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtSign)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtManagerName)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtHonorificTitle)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBloodType)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblManagerName)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblHonorificTitle)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.lblMemo)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblCustmerNameKana)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.lblPrefectures)
        Me.Controls.Add(Me.lblMunicipalities)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtCustmerNameKana)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.txtMunicipalities)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtCustmerName)
        Me.Controls.Add(Me.lblCusttmerName)
        Me.Controls.Add(Me.txtCustmerCode)
        Me.Controls.Add(Me.lblCustmerCode)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "frmCustomer"
        Me.Text = "4"
        Me.pnlGender.ResumeLayout(False)
        Me.pnlGender.PerformLayout()
        Me.pnlBloodType.ResumeLayout(False)
        Me.pnlBloodType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustmerCode As Label
    Friend WithEvents txtCustmerCode As TextBox
    Friend WithEvents lblCusttmerName As Label
    Friend WithEvents txtCustmerName As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMunicipalities As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtCustmerNameKana As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblMunicipalities As Label
    Friend WithEvents lblPrefectures As Label
    Friend WithEvents lblPostCode As Label
    Friend WithEvents lblCustmerNameKana As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblMemo As Label
    Friend WithEvents txtMemo As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblHonorificTitle As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblManagerName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblBloodType As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblSign As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtHonorificTitle As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtManagerName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtSign As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents rbtMen As RadioButton
    Friend WithEvents rbtAB As RadioButton
    Friend WithEvents rbtO As RadioButton
    Friend WithEvents rbtB As RadioButton
    Friend WithEvents rbtA As RadioButton
    Friend WithEvents rbtWomen As RadioButton
    Friend WithEvents lblUpdateDate As Label
    Friend WithEvents lblResistDate As Label
    Friend WithEvents lblUpdater As Label
    Friend WithEvents txtUpdateDate As TextBox
    Friend WithEvents txtResistDate As TextBox
    Friend WithEvents txtUpdater As TextBox
    Friend WithEvents txtRegister As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRegist As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboPrefectures As ComboBox
    Friend WithEvents pnlGender As Panel
    Friend WithEvents pnlBloodType As Panel
    Friend WithEvents lblManagerForm As Label
End Class
