<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
  Public WithEvents mnu_close As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnu_file As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnu_readme As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnu_hr As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnu_ver As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnu_help As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
  Public WithEvents btnCopyClipboard As System.Windows.Forms.Button
  Public WithEvents tbxForce As System.Windows.Forms.TextBox
  Public WithEvents chkForceDisable As System.Windows.Forms.CheckBox
  Public WithEvents Frame3 As System.Windows.Forms.GroupBox
  Public WithEvents _Option1_1 As System.Windows.Forms.RadioButton
  Public WithEvents _Option1_0 As System.Windows.Forms.RadioButton
  Public WithEvents Frame2 As System.Windows.Forms.GroupBox
  Public WithEvents Text2 As System.Windows.Forms.TextBox
  Public WithEvents btnConvert As System.Windows.Forms.Button
  Public WithEvents _Check1_1 As System.Windows.Forms.CheckBox
  Public WithEvents _Check1_0 As System.Windows.Forms.CheckBox
  Public WithEvents Frame1 As System.Windows.Forms.GroupBox
  Public WithEvents _Label1_5 As System.Windows.Forms.Label
  Public WithEvents _Label1_4 As System.Windows.Forms.Label
  Public WithEvents _Label1_3 As System.Windows.Forms.Label
  Public WithEvents _Label2_1 As System.Windows.Forms.Label
  Public WithEvents _Label2_0 As System.Windows.Forms.Label
  Public WithEvents _Label1_2 As System.Windows.Forms.Label
  Public WithEvents _Label1_1 As System.Windows.Forms.Label
  Public WithEvents _Label1_0 As System.Windows.Forms.Label
  Public WithEvents Check1 As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
  Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
  Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
  Public WithEvents Option1 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
  'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
  'Windows フォーム デザイナを使って変更できます。
  'コード エディタを使用して、変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
    Me.mnu_file = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_close = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_help = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_readme = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_hr = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_ver = New System.Windows.Forms.ToolStripMenuItem()
    Me.Combo1 = New System.Windows.Forms.ComboBox()
    Me.btnCopyClipboard = New System.Windows.Forms.Button()
    Me.tbxForce = New System.Windows.Forms.TextBox()
    Me.Frame3 = New System.Windows.Forms.GroupBox()
    Me.chkForceDisable = New System.Windows.Forms.CheckBox()
    Me.Frame2 = New System.Windows.Forms.GroupBox()
    Me._Option1_1 = New System.Windows.Forms.RadioButton()
    Me._Option1_0 = New System.Windows.Forms.RadioButton()
    Me.Text2 = New System.Windows.Forms.TextBox()
    Me.btnConvert = New System.Windows.Forms.Button()
    Me.Frame1 = New System.Windows.Forms.GroupBox()
    Me._Check1_1 = New System.Windows.Forms.CheckBox()
    Me._Check1_0 = New System.Windows.Forms.CheckBox()
    Me._Label1_5 = New System.Windows.Forms.Label()
    Me._Label1_4 = New System.Windows.Forms.Label()
    Me._Label1_3 = New System.Windows.Forms.Label()
    Me._Label2_1 = New System.Windows.Forms.Label()
    Me._Label2_0 = New System.Windows.Forms.Label()
    Me._Label1_2 = New System.Windows.Forms.Label()
    Me._Label1_1 = New System.Windows.Forms.Label()
    Me._Label1_0 = New System.Windows.Forms.Label()
    Me.Check1 = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
    Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
    Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
    Me.Option1 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.MainMenu1.SuspendLayout()
    Me.Frame3.SuspendLayout()
    Me.Frame2.SuspendLayout()
    Me.Frame1.SuspendLayout()
    CType(Me.Check1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Option1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MainMenu1
    '
    Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_file, Me.mnu_help})
    Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
    Me.MainMenu1.Name = "MainMenu1"
    Me.MainMenu1.Size = New System.Drawing.Size(447, 24)
    Me.MainMenu1.TabIndex = 22
    '
    'mnu_file
    '
    Me.mnu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_close})
    Me.mnu_file.Name = "mnu_file"
    Me.mnu_file.Size = New System.Drawing.Size(66, 20)
    Me.mnu_file.Text = "ファイル(&F)"
    '
    'mnu_close
    '
    Me.mnu_close.Name = "mnu_close"
    Me.mnu_close.Size = New System.Drawing.Size(245, 22)
    Me.mnu_close.Text = "ＨＴＭＬエンティティ変換の終了(&X)"
    '
    'mnu_help
    '
    Me.mnu_help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_readme, Me.mnu_hr, Me.mnu_ver})
    Me.mnu_help.Name = "mnu_help"
    Me.mnu_help.Size = New System.Drawing.Size(65, 20)
    Me.mnu_help.Text = "ヘルプ(&H)"
    '
    'mnu_readme
    '
    Me.mnu_readme.Name = "mnu_readme"
    Me.mnu_readme.Size = New System.Drawing.Size(158, 22)
    Me.mnu_readme.Text = "readme.txt(&R)"
    '
    'mnu_hr
    '
    Me.mnu_hr.Name = "mnu_hr"
    Me.mnu_hr.Size = New System.Drawing.Size(155, 6)
    '
    'mnu_ver
    '
    Me.mnu_ver.Name = "mnu_ver"
    Me.mnu_ver.Size = New System.Drawing.Size(158, 22)
    Me.mnu_ver.Text = "バージョン情報(&A)"
    '
    'Combo1
    '
    Me.Combo1.BackColor = System.Drawing.SystemColors.Window
    Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
    Me.Combo1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Combo1.Location = New System.Drawing.Point(8, 48)
    Me.Combo1.Name = "Combo1"
    Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Combo1.Size = New System.Drawing.Size(345, 24)
    Me.Combo1.Sorted = True
    Me.Combo1.TabIndex = 12
    Me.Combo1.Text = "mailto:"
    '
    'btnCopyClipboard
    '
    Me.btnCopyClipboard.BackColor = System.Drawing.SystemColors.Control
    Me.btnCopyClipboard.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnCopyClipboard.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnCopyClipboard.Location = New System.Drawing.Point(360, 144)
    Me.btnCopyClipboard.Name = "btnCopyClipboard"
    Me.btnCopyClipboard.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnCopyClipboard.Size = New System.Drawing.Size(81, 49)
    Me.btnCopyClipboard.TabIndex = 9
    Me.btnCopyClipboard.Text = "クリップボードにコピー"
    Me.btnCopyClipboard.UseVisualStyleBackColor = False
    '
    'tbxForce
    '
    Me.tbxForce.AcceptsReturn = True
    Me.tbxForce.BackColor = System.Drawing.SystemColors.Window
    Me.tbxForce.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.tbxForce.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.tbxForce.ForeColor = System.Drawing.SystemColors.WindowText
    Me.tbxForce.Location = New System.Drawing.Point(296, 240)
    Me.tbxForce.MaxLength = 20
    Me.tbxForce.Name = "tbxForce"
    Me.tbxForce.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.tbxForce.Size = New System.Drawing.Size(137, 23)
    Me.tbxForce.TabIndex = 6
    Me.tbxForce.Text = "@:/"
    '
    'Frame3
    '
    Me.Frame3.BackColor = System.Drawing.SystemColors.Control
    Me.Frame3.Controls.Add(Me.chkForceDisable)
    Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Frame3.Location = New System.Drawing.Point(288, 200)
    Me.Frame3.Name = "Frame3"
    Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
    Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Frame3.Size = New System.Drawing.Size(153, 73)
    Me.Frame3.TabIndex = 7
    Me.Frame3.TabStop = False
    Me.Frame3.Text = "必ず変換する文字"
    '
    'chkForceDisable
    '
    Me.chkForceDisable.BackColor = System.Drawing.SystemColors.Control
    Me.chkForceDisable.Checked = True
    Me.chkForceDisable.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkForceDisable.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkForceDisable.ForeColor = System.Drawing.SystemColors.ControlText
    Me.chkForceDisable.Location = New System.Drawing.Point(8, 16)
    Me.chkForceDisable.Name = "chkForceDisable"
    Me.chkForceDisable.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkForceDisable.Size = New System.Drawing.Size(81, 17)
    Me.chkForceDisable.TabIndex = 8
    Me.chkForceDisable.Text = "無効にする"
    Me.chkForceDisable.UseVisualStyleBackColor = False
    '
    'Frame2
    '
    Me.Frame2.BackColor = System.Drawing.SystemColors.Control
    Me.Frame2.Controls.Add(Me._Option1_1)
    Me.Frame2.Controls.Add(Me._Option1_0)
    Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Frame2.Location = New System.Drawing.Point(152, 200)
    Me.Frame2.Name = "Frame2"
    Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
    Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Frame2.Size = New System.Drawing.Size(130, 73)
    Me.Frame2.TabIndex = 5
    Me.Frame2.TabStop = False
    Me.Frame2.Text = "エンティティ化"
    '
    '_Option1_1
    '
    Me._Option1_1.BackColor = System.Drawing.SystemColors.Control
    Me._Option1_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Option1_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Option1.SetIndex(Me._Option1_1, CType(1, Short))
    Me._Option1_1.Location = New System.Drawing.Point(8, 40)
    Me._Option1_1.Name = "_Option1_1"
    Me._Option1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Option1_1.Size = New System.Drawing.Size(97, 25)
    Me._Option1_1.TabIndex = 16
    Me._Option1_1.TabStop = True
    Me._Option1_1.Text = "全て"
    Me._Option1_1.UseVisualStyleBackColor = False
    '
    '_Option1_0
    '
    Me._Option1_0.BackColor = System.Drawing.SystemColors.Control
    Me._Option1_0.Checked = True
    Me._Option1_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Option1_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Option1.SetIndex(Me._Option1_0, CType(0, Short))
    Me._Option1_0.Location = New System.Drawing.Point(8, 16)
    Me._Option1_0.Name = "_Option1_0"
    Me._Option1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Option1_0.Size = New System.Drawing.Size(97, 25)
    Me._Option1_0.TabIndex = 15
    Me._Option1_0.TabStop = True
    Me._Option1_0.Text = "ランダム(推奨)"
    Me._Option1_0.UseVisualStyleBackColor = False
    '
    'Text2
    '
    Me.Text2.AcceptsReturn = True
    Me.Text2.BackColor = System.Drawing.SystemColors.Window
    Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text2.Location = New System.Drawing.Point(8, 144)
    Me.Text2.MaxLength = 0
    Me.Text2.Multiline = True
    Me.Text2.Name = "Text2"
    Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.Text2.Size = New System.Drawing.Size(345, 49)
    Me.Text2.TabIndex = 1
    '
    'btnConvert
    '
    Me.btnConvert.BackColor = System.Drawing.SystemColors.Control
    Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnConvert.Location = New System.Drawing.Point(360, 47)
    Me.btnConvert.Name = "btnConvert"
    Me.btnConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnConvert.Size = New System.Drawing.Size(81, 25)
    Me.btnConvert.TabIndex = 0
    Me.btnConvert.Text = "変換"
    Me.btnConvert.UseVisualStyleBackColor = False
    '
    'Frame1
    '
    Me.Frame1.BackColor = System.Drawing.SystemColors.Control
    Me.Frame1.Controls.Add(Me._Check1_1)
    Me.Frame1.Controls.Add(Me._Check1_0)
    Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Frame1.Location = New System.Drawing.Point(8, 200)
    Me.Frame1.Name = "Frame1"
    Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
    Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Frame1.Size = New System.Drawing.Size(138, 73)
    Me.Frame1.TabIndex = 2
    Me.Frame1.TabStop = False
    Me.Frame1.Text = "出力形式"
    '
    '_Check1_1
    '
    Me._Check1_1.BackColor = System.Drawing.SystemColors.Control
    Me._Check1_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Check1_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Check1.SetIndex(Me._Check1_1, CType(1, Short))
    Me._Check1_1.Location = New System.Drawing.Point(8, 40)
    Me._Check1_1.Name = "_Check1_1"
    Me._Check1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Check1_1.Size = New System.Drawing.Size(127, 25)
    Me._Check1_1.TabIndex = 14
    Me._Check1_1.Text = "16進数(＆#x形式)"
    Me._Check1_1.UseVisualStyleBackColor = False
    '
    '_Check1_0
    '
    Me._Check1_0.BackColor = System.Drawing.SystemColors.Control
    Me._Check1_0.Checked = True
    Me._Check1_0.CheckState = System.Windows.Forms.CheckState.Checked
    Me._Check1_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Check1_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Check1.SetIndex(Me._Check1_0, CType(0, Short))
    Me._Check1_0.Location = New System.Drawing.Point(8, 16)
    Me._Check1_0.Name = "_Check1_0"
    Me._Check1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Check1_0.Size = New System.Drawing.Size(113, 25)
    Me._Check1_0.TabIndex = 13
    Me._Check1_0.Text = "10進数(＆#形式)"
    Me._Check1_0.UseVisualStyleBackColor = False
    '
    '_Label1_5
    '
    Me._Label1_5.AutoSize = True
    Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_5.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me._Label1_5.ForeColor = System.Drawing.Color.Red
    Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
    Me._Label1_5.Location = New System.Drawing.Point(200, 80)
    Me._Label1_5.Name = "_Label1_5"
    Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_5.Size = New System.Drawing.Size(245, 13)
    Me._Label1_5.TabIndex = 21
    Me._Label1_5.Text = "※出力形式を１つ以上チェックして下さい"
    Me._Label1_5.Visible = False
    '
    '_Label1_4
    '
    Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
    Me._Label1_4.Location = New System.Drawing.Point(328, 32)
    Me._Label1_4.Name = "_Label1_4"
    Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_4.Size = New System.Drawing.Size(25, 17)
    Me._Label1_4.TabIndex = 20
    '
    '_Label1_3
    '
    Me._Label1_3.AutoSize = True
    Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_3.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
    Me._Label1_3.Location = New System.Drawing.Point(280, 32)
    Me._Label1_3.Name = "_Label1_3"
    Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_3.Size = New System.Drawing.Size(57, 13)
    Me._Label1_3.TabIndex = 19
    Me._Label1_3.Text = "文字数："
    '
    '_Label2_1
    '
    Me._Label2_1.AutoSize = True
    Me._Label2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me._Label2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label2_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
    Me._Label2_1.Location = New System.Drawing.Point(134, 76)
    Me._Label2_1.Margin = New System.Windows.Forms.Padding(0)
    Me._Label2_1.Name = "_Label2_1"
    Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label2_1.Size = New System.Drawing.Size(63, 20)
    Me._Label2_1.TabIndex = 18
    Me._Label2_1.Text = "16進(＆#x)"
    Me._Label2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me._Label2_1.UseCompatibleTextRendering = True
    '
    '_Label2_0
    '
    Me._Label2_0.AutoSize = True
    Me._Label2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me._Label2_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label2_0.ForeColor = System.Drawing.Color.Black
    Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
    Me._Label2_0.Location = New System.Drawing.Point(72, 76)
    Me._Label2_0.Margin = New System.Windows.Forms.Padding(0)
    Me._Label2_0.Name = "_Label2_0"
    Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label2_0.Size = New System.Drawing.Size(57, 20)
    Me._Label2_0.TabIndex = 17
    Me._Label2_0.Text = "10進(＆#)"
    Me._Label2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me._Label2_0.UseCompatibleTextRendering = True
    '
    '_Label1_2
    '
    Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
    Me._Label1_2.Location = New System.Drawing.Point(8, 80)
    Me._Label1_2.Name = "_Label1_2"
    Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_2.Size = New System.Drawing.Size(75, 21)
    Me._Label1_2.TabIndex = 11
    Me._Label1_2.Text = "適用部分"
    '
    '_Label1_1
    '
    Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
    Me._Label1_1.Location = New System.Drawing.Point(8, 126)
    Me._Label1_1.Name = "_Label1_1"
    Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_1.Size = New System.Drawing.Size(46, 21)
    Me._Label1_1.TabIndex = 10
    Me._Label1_1.Text = "出力"
    '
    '_Label1_0
    '
    Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_0.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
    Me._Label1_0.Location = New System.Drawing.Point(8, 32)
    Me._Label1_0.Name = "_Label1_0"
    Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_0.Size = New System.Drawing.Size(257, 17)
    Me._Label1_0.TabIndex = 3
    Me._Label1_0.Text = "変換したいメールアドレス又はＵＲＬを入力"
    '
    'Check1
    '
    '
    'PictureBox1
    '
    Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox1.Location = New System.Drawing.Point(8, 98)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(433, 25)
    Me.PictureBox1.TabIndex = 23
    Me.PictureBox1.TabStop = False
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(447, 280)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.Combo1)
    Me.Controls.Add(Me.btnCopyClipboard)
    Me.Controls.Add(Me.tbxForce)
    Me.Controls.Add(Me.Frame3)
    Me.Controls.Add(Me.Frame2)
    Me.Controls.Add(Me.Text2)
    Me.Controls.Add(Me.btnConvert)
    Me.Controls.Add(Me.Frame1)
    Me.Controls.Add(Me._Label1_5)
    Me.Controls.Add(Me._Label1_4)
    Me.Controls.Add(Me._Label1_3)
    Me.Controls.Add(Me._Label2_1)
    Me.Controls.Add(Me._Label2_0)
    Me.Controls.Add(Me._Label1_2)
    Me.Controls.Add(Me._Label1_1)
    Me.Controls.Add(Me._Label1_0)
    Me.Controls.Add(Me.MainMenu1)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Location = New System.Drawing.Point(11, 57)
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text = "ＨＴＭＬエンティティ変換"
    Me.MainMenu1.ResumeLayout(False)
    Me.MainMenu1.PerformLayout()
    Me.Frame3.ResumeLayout(False)
    Me.Frame2.ResumeLayout(False)
    Me.Frame1.ResumeLayout(False)
    CType(Me.Check1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Option1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
#End Region 
End Class