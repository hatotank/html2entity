<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_readme
#Region "Windows フォーム デザイナによって生成されたコード "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'この呼び出しは、Windows フォーム デザイナで必要です。
		InitializeComponent()
	End Sub
	'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Windows フォーム デザイナで必要です。
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Text1 As System.Windows.Forms.TextBox
  Public WithEvents btnClose As System.Windows.Forms.Button
  'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
  'Windows フォーム デザイナを使って変更できます。
  'コード エディタを使用して、変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_readme))
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.Text1 = New System.Windows.Forms.TextBox
    Me.btnClose = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'Text1
    '
    Me.Text1.AcceptsReturn = True
    Me.Text1.BackColor = System.Drawing.SystemColors.Control
    Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text1.Location = New System.Drawing.Point(8, 8)
    Me.Text1.MaxLength = 0
    Me.Text1.Multiline = True
    Me.Text1.Name = "Text1"
    Me.Text1.ReadOnly = True
    Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.Text1.Size = New System.Drawing.Size(313, 193)
    Me.Text1.TabIndex = 1
    Me.Text1.Text = "Text1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    Me.Text1.WordWrap = False
    '
    'btnClose
    '
    Me.btnClose.BackColor = System.Drawing.SystemColors.Control
    Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnClose.Location = New System.Drawing.Point(128, 208)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnClose.Size = New System.Drawing.Size(73, 25)
    Me.btnClose.TabIndex = 0
    Me.btnClose.Text = "閉じる"
    Me.btnClose.UseVisualStyleBackColor = False
    '
    'frm_readme
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(330, 239)
    Me.Controls.Add(Me.Text1)
    Me.Controls.Add(Me.btnClose)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Location = New System.Drawing.Point(3, 29)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frm_readme"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text = "readme.txt表示"
    Me.ResumeLayout(False)

  End Sub
#End Region 
End Class