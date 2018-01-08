<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
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
  Public WithEvents picIcon As System.Windows.Forms.PictureBox
  Public WithEvents btnOK As System.Windows.Forms.Button
  Public WithEvents Label2 As System.Windows.Forms.Label
  Public WithEvents Label1 As System.Windows.Forms.Label
  Public WithEvents lblDescription As System.Windows.Forms.Label
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents lblVersion As System.Windows.Forms.Label
  'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
  'Windows フォーム デザイナを使って変更できます。
  'コード エディタを使用して、変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
    Me.picIcon = New System.Windows.Forms.PictureBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblDescription = New System.Windows.Forms.Label()
    Me.lblTitle = New System.Windows.Forms.Label()
    Me.lblVersion = New System.Windows.Forms.Label()
    Me.Label_H = New System.Windows.Forms.Label()
    CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picIcon
    '
    Me.picIcon.BackColor = System.Drawing.SystemColors.Control
    Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picIcon.Cursor = System.Windows.Forms.Cursors.Default
    Me.picIcon.ForeColor = System.Drawing.SystemColors.WindowText
    Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
    Me.picIcon.Location = New System.Drawing.Point(16, 16)
    Me.picIcon.Name = "picIcon"
    Me.picIcon.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.picIcon.Size = New System.Drawing.Size(34, 34)
    Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picIcon.TabIndex = 1
    Me.picIcon.TabStop = False
    '
    'btnOK
    '
    Me.btnOK.BackColor = System.Drawing.SystemColors.Control
    Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnOK.Location = New System.Drawing.Point(296, 16)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnOK.Size = New System.Drawing.Size(76, 27)
    Me.btnOK.TabIndex = 0
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.SystemColors.Control
    Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label2.Location = New System.Drawing.Point(72, 96)
    Me.Label2.Name = "Label2"
    Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label2.Size = New System.Drawing.Size(140, 12)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "mailto:hatotank@gmail.com"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.SystemColors.Control
    Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.Location = New System.Drawing.Point(72, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label1.Size = New System.Drawing.Size(139, 12)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "(C) 2004,2018 by hatotank"
    '
    'lblDescription
    '
    Me.lblDescription.AutoSize = True
    Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
    Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblDescription.ForeColor = System.Drawing.Color.Black
    Me.lblDescription.Location = New System.Drawing.Point(72, 80)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblDescription.Size = New System.Drawing.Size(101, 12)
    Me.lblDescription.TabIndex = 2
    Me.lblDescription.Text = "http://hatotank.net"
    '
    'lblTitle
    '
    Me.lblTitle.AutoSize = True
    Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
    Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblTitle.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.lblTitle.ForeColor = System.Drawing.Color.Black
    Me.lblTitle.Location = New System.Drawing.Point(72, 16)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblTitle.Size = New System.Drawing.Size(186, 17)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "ＨＴＭＬエンティティ変換"
    '
    'lblVersion
    '
    Me.lblVersion.AutoSize = True
    Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
    Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVersion.Location = New System.Drawing.Point(72, 40)
    Me.lblVersion.Name = "lblVersion"
    Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVersion.Size = New System.Drawing.Size(44, 12)
    Me.lblVersion.TabIndex = 4
    Me.lblVersion.Text = "Version"
    '
    'Label_H
    '
    Me.Label_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label_H.Location = New System.Drawing.Point(74, 74)
    Me.Label_H.Name = "Label_H"
    Me.Label_H.Size = New System.Drawing.Size(298, 1)
    Me.Label_H.TabIndex = 8
    '
    'frmAbout
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.CancelButton = Me.btnOK
    Me.ClientSize = New System.Drawing.Size(377, 123)
    Me.Controls.Add(Me.Label_H)
    Me.Controls.Add(Me.picIcon)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblDescription)
    Me.Controls.Add(Me.lblTitle)
    Me.Controls.Add(Me.lblVersion)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Location = New System.Drawing.Point(156, 129)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAbout"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "ﾊﾞｰｼﾞｮﾝ情報"
    CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label_H As System.Windows.Forms.Label
#End Region 
End Class