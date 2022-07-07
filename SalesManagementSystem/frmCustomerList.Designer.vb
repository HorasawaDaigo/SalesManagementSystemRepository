<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerList
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgdList = New System.Windows.Forms.DataGridView()
        CType(Me.dgdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(55, 72)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(85, 15)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "得意先コード"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(55, 120)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "得意先名"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(168, 69)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 22)
        Me.txtCode.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(168, 117)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 22)
        Me.txtName.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(90, 168)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgdList
        '
        Me.dgdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdList.Location = New System.Drawing.Point(58, 210)
        Me.dgdList.Name = "dgdList"
        Me.dgdList.RowHeadersWidth = 51
        Me.dgdList.RowTemplate.Height = 24
        Me.dgdList.Size = New System.Drawing.Size(654, 228)
        Me.dgdList.TabIndex = 6
        '
        'frmCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgdList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCode)
        Me.Name = "frmCustomerList"
        Me.Text = "得意先一覧"
        CType(Me.dgdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCode As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgdList As DataGridView
End Class
