<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnPurchasingList = New System.Windows.Forms.Button()
        Me.btnSalesList = New System.Windows.Forms.Button()
        Me.btnPurchasing = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnItemList = New System.Windows.Forms.Button()
        Me.btnEmployeeList = New System.Windows.Forms.Button()
        Me.btnCustomerList = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.lblMaster = New System.Windows.Forms.Label()
        Me.lblEveryday = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPurchasingList
        '
        Me.btnPurchasingList.Location = New System.Drawing.Point(640, 229)
        Me.btnPurchasingList.Name = "btnPurchasingList"
        Me.btnPurchasingList.Size = New System.Drawing.Size(102, 29)
        Me.btnPurchasingList.TabIndex = 25
        Me.btnPurchasingList.Text = "仕入一覧"
        Me.btnPurchasingList.UseVisualStyleBackColor = True
        '
        'btnSalesList
        '
        Me.btnSalesList.Location = New System.Drawing.Point(513, 229)
        Me.btnSalesList.Name = "btnSalesList"
        Me.btnSalesList.Size = New System.Drawing.Size(102, 29)
        Me.btnSalesList.TabIndex = 24
        Me.btnSalesList.Text = "売上一覧"
        Me.btnSalesList.UseVisualStyleBackColor = True
        '
        'btnPurchasing
        '
        Me.btnPurchasing.Location = New System.Drawing.Point(640, 176)
        Me.btnPurchasing.Name = "btnPurchasing"
        Me.btnPurchasing.Size = New System.Drawing.Size(102, 29)
        Me.btnPurchasing.TabIndex = 23
        Me.btnPurchasing.Text = "仕入"
        Me.btnPurchasing.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(513, 176)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(102, 29)
        Me.btnSales.TabIndex = 22
        Me.btnSales.Text = "売上"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnItemList
        '
        Me.btnItemList.Location = New System.Drawing.Point(283, 229)
        Me.btnItemList.Name = "btnItemList"
        Me.btnItemList.Size = New System.Drawing.Size(102, 29)
        Me.btnItemList.TabIndex = 21
        Me.btnItemList.Text = "商品一覧"
        Me.btnItemList.UseVisualStyleBackColor = True
        '
        'btnEmployeeList
        '
        Me.btnEmployeeList.Location = New System.Drawing.Point(165, 229)
        Me.btnEmployeeList.Name = "btnEmployeeList"
        Me.btnEmployeeList.Size = New System.Drawing.Size(102, 29)
        Me.btnEmployeeList.TabIndex = 20
        Me.btnEmployeeList.Text = "社員一覧"
        Me.btnEmployeeList.UseVisualStyleBackColor = True
        '
        'btnCustomerList
        '
        Me.btnCustomerList.Location = New System.Drawing.Point(48, 229)
        Me.btnCustomerList.Name = "btnCustomerList"
        Me.btnCustomerList.Size = New System.Drawing.Size(102, 29)
        Me.btnCustomerList.TabIndex = 19
        Me.btnCustomerList.Text = "得意先一覧"
        Me.btnCustomerList.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Location = New System.Drawing.Point(283, 176)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(102, 29)
        Me.btnItem.TabIndex = 18
        Me.btnItem.Text = "商品マスタ"
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(165, 176)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(102, 29)
        Me.btnEmployee.TabIndex = 17
        Me.btnEmployee.Text = "社員マスタ"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(48, 176)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(102, 29)
        Me.btnCustomer.TabIndex = 16
        Me.btnCustomer.Text = "得意先マスタ"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'lblMaster
        '
        Me.lblMaster.AutoSize = True
        Me.lblMaster.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMaster.Location = New System.Drawing.Point(161, 118)
        Me.lblMaster.Name = "lblMaster"
        Me.lblMaster.Size = New System.Drawing.Size(89, 19)
        Me.lblMaster.TabIndex = 15
        Me.lblMaster.Text = "マスタ管理"
        '
        'lblEveryday
        '
        Me.lblEveryday.AutoSize = True
        Me.lblEveryday.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblEveryday.Location = New System.Drawing.Point(585, 118)
        Me.lblEveryday.Name = "lblEveryday"
        Me.lblEveryday.Size = New System.Drawing.Size(85, 19)
        Me.lblEveryday.TabIndex = 14
        Me.lblEveryday.Text = "日常業務"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(379, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(85, 25)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "メニュー"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPurchasingList)
        Me.Controls.Add(Me.btnSalesList)
        Me.Controls.Add(Me.btnPurchasing)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnItemList)
        Me.Controls.Add(Me.btnEmployeeList)
        Me.Controls.Add(Me.btnCustomerList)
        Me.Controls.Add(Me.btnItem)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.lblMaster)
        Me.Controls.Add(Me.lblEveryday)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMenu"
        Me.Text = "メニュー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPurchasingList As Button
    Friend WithEvents btnSalesList As Button
    Friend WithEvents btnPurchasing As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnItemList As Button
    Friend WithEvents btnEmployeeList As Button
    Friend WithEvents btnCustomerList As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents lblMaster As Label
    Friend WithEvents lblEveryday As Label
    Friend WithEvents lblTitle As Label
End Class
