Option Strict Off
Option Explicit On
Friend Class Form1
  Inherits System.Windows.Forms.Form
  Dim start As Integer
  Const AddHeight As Integer = 7

  '--------------------------------------
  'フォームロード
  '--------------------------------------
  Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    start = 0
    tbxForce.Enabled = False
    chkForceDisable.Enabled = True
    Me.Text = "ＨＴＭＬエンティティ変換 Ver " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
  End Sub
  '--------------------------------------
  'チェックボックス変更
  '--------------------------------------
  Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged
    Dim Index As Integer = Check1.GetIndex(eventSender)
    Dim i As Integer
    Dim flag As Integer
    flag = 0

    For i = 0 To 1
      If Check1(i).CheckState = 1 Then
        flag = flag + 1
      End If
    Next i

    If flag < 1 Then
      Label1(5).Visible = True
      btnConvert.Enabled = False
    Else
      Label1(5).Visible = False
      btnConvert.Enabled = True
    End If

  End Sub
  '--------------------------------------
  '「変換」ボタン
  '--------------------------------------
  Private Sub btnConvert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnConvert.Click
    Dim buf_str As String
    Dim n As Integer
    Text2.Text = ""
    buf_str = Combo1.Text
    n = Len(buf_str)
    Label1(4).Text = CStr(n)
    start = 0

    '出力処理
    Call convert(Option1(0).Checked, n, buf_str)

  End Sub
  '--------------------------------------
  '「クリップボードにコピー」ボタン
  '--------------------------------------
  Private Sub btnCopyClipboard_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCopyClipboard.Click
    My.Computer.Clipboard.SetText((Text2.Text))
  End Sub
  '--------------------------------------
  'ＨＴＭＬエンティティ変換の終了(&X)
  '--------------------------------------
  Public Sub mnu_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu_close.Click
    End
  End Sub
  '--------------------------------------
  'readme.txt(&R)
  '--------------------------------------
  Public Sub mnu_readme_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu_readme.Click
    frm_readme.Visible = True
  End Sub
  '--------------------------------------
  'バージョン情報(&A)
  '--------------------------------------
  Public Sub mnu_ver_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu_ver.Click
    frmAbout.Visible = True
  End Sub
  '--------------------------------------
  '変換処理
  '--------------------------------------
  Function convert(ByRef bool As Boolean, ByRef n As Short, ByRef buf_str As String) As Object
    If Check1(0).CheckState = 1 And Check1(1).CheckState = 1 Then
      '10,16進数
      If bool = True Then
        Call convert_rnd(n, buf_str, 1)
      Else
        Call convert_all(n, buf_str, 1)
      End If
    ElseIf Check1(0).CheckState = 1 Then
      '10進数
      If bool = True Then
        Call convert_rnd(n, buf_str, 2)
      Else
        Call convert_all(n, buf_str, 2)
      End If
    Else
      '16進数
      If bool = True Then
        Call convert_rnd(n, buf_str, 3)
      Else
        Call convert_all(n, buf_str, 3)
      End If
    End If
  End Function
  '--------------------------------------
  '変換処理：全て
  '--------------------------------------
  Function convert_all(ByRef n As Integer, ByRef buf_str As String, ByRef op As Integer) As Short
    Dim i As Integer
    Dim flag As Integer
    Dim canvas As New Bitmap(PictureBox1.Width, PictureBox1.Height)
    Dim g As Graphics = Graphics.FromImage(canvas)
    Dim fnt As New Font("MS Pゴシック", 9)

    Randomize()
    For i = 1 To n
      flag = Int(Rnd() * 2)
      Select Case op
        Case 1
          If flag = 0 Then
            Call color_bar(2, Mid(buf_str, i, 1), fnt, g)
            Text2.Text = Text2.Text & "&#x" & Hex(Asc(Mid(buf_str, i, 1))) & ";"
          Else
            Call color_bar(1, Mid(buf_str, i, 1), fnt, g)
            Text2.Text = Text2.Text & "&#" & Asc(Mid(buf_str, i, 1)) & ";"
          End If
        Case 2
          Call color_bar(1, Mid(buf_str, i, 1), fnt, g)
          Text2.Text = Text2.Text & "&#" & Asc(Mid(buf_str, i, 1)) & ";"
        Case 3
          Call color_bar(2, Mid(buf_str, i, 1), fnt, g)
          Text2.Text = Text2.Text & "&#x" & Hex(Asc(Mid(buf_str, i, 1))) & ";"
      End Select
    Next i

    fnt.Dispose()
    g.Dispose()
    PictureBox1.Image = canvas
  End Function
  '--------------------------------------
  '変換処理：ランダム
  '--------------------------------------
  Function convert_rnd(ByRef n As Short, ByRef buf_str As String, ByRef op As Integer) As Short
    Dim i As Integer
    Dim j As Integer
    Dim flag As Integer
    Dim flag2 As Integer
    Dim canvas As New Bitmap(PictureBox1.Width, PictureBox1.Height)
    Dim g As Graphics = Graphics.FromImage(canvas)
    Dim fnt As New Font("MS Pゴシック", 9, FontStyle.Regular)
    Dim forceConvertString As String

    '※面倒なので直接テキストボックスから
    forceConvertString = tbxForce.Text

    Randomize()
    For i = 1 To n
      flag = Int(Rnd() * 2)
      flag2 = Int(Rnd() * 2)

      If chkForceDisable.Checked = False Then
        '強制変換文字列がある場合はflag=0強制セット
        For j = 0 To forceConvertString.Length - 1
          If Mid(buf_str, i, 1) = forceConvertString(j) Then
            flag = 0
          End If
        Next
      End If

      Select Case op
        Case 1
          If flag2 = 0 Then
            If flag = 0 Then
              Call color_bar(2, Mid(buf_str, i, 1), fnt, g)
              Text2.Text = Text2.Text & "&#x" & Hex(Asc(Mid(buf_str, i, 1))) & ";"
            Else
              Call color_bar(3, Mid(buf_str, i, 1), fnt, g)
              Text2.Text = Text2.Text & Mid(buf_str, i, 1)
            End If
          Else
            If flag = 0 Then
              Call color_bar(1, Mid(buf_str, i, 1), fnt, g)
              Text2.Text = Text2.Text & "&#" & Asc(Mid(buf_str, i, 1)) & ";"
            Else
              Call color_bar(3, Mid(buf_str, i, 1), fnt, g)
              Text2.Text = Text2.Text & Mid(buf_str, i, 1)
            End If
          End If
        Case 2
          If flag = 0 Then
            Call color_bar(1, Mid(buf_str, i, 1), fnt, g)
            Text2.Text = Text2.Text & "&#" & Asc(Mid(buf_str, i, 1)) & ";"
          Else
            Call color_bar(3, Mid(buf_str, i, 1), fnt, g)
            Text2.Text = Text2.Text & Mid(buf_str, i, 1)
          End If
        Case 3
          If flag = 0 Then
            Call color_bar(2, Mid(buf_str, i, 1), fnt, g)
            Text2.Text = Text2.Text & "&#x" & Hex(Asc(Mid(buf_str, i, 1))) & ";"
          Else
            Call color_bar(3, Mid(buf_str, i, 1), fnt, g)
            Text2.Text = Text2.Text & Mid(buf_str, i, 1)
          End If
      End Select
    Next i

    fnt.Dispose()
    g.Dispose()
    PictureBox1.Image = canvas
  End Function
  '--------------------------------------
  '変換部位グラフィカル表示
  '--------------------------------------
  Function color_bar(ByRef n As Integer, ByRef buf As String, ByVal fnt As Font, ByVal g As Graphics) As Object
    Dim stringSize As SizeF = g.MeasureString(buf, fnt, PictureBox1.Width)
    '適用部分処理
    Select Case n
      Case 1 '10進部分
        Dim brash As New SolidBrush(Color.FromArgb(255, 128, 128, 255))
        g.FillRectangle(brash, start, 0, stringSize.Width, stringSize.Height + AddHeight)
        g.DrawString(buf, fnt, Brushes.Black, start, 0)
        start = start + stringSize.Width
      Case 2 '16進部分
        Dim brash As New SolidBrush(Color.FromArgb(255, 128, 255, 128))
        g.FillRectangle(brash, start, 0, stringSize.Width, stringSize.Height + AddHeight)
        g.DrawString(buf, fnt, Brushes.Black, start, 0)
        start = start + stringSize.Width
      Case 3
        Dim brash As New SolidBrush(Me.PictureBox1.BackColor)
        g.FillRectangle(brash, start, 0, stringSize.Width, stringSize.Height + AddHeight)
        g.DrawString(buf, fnt, Brushes.Black, start, 0)
        start = start + stringSize.Width
    End Select
  End Function
  '--------------------------------------
  '強制変換無効
  '--------------------------------------
  Private Sub chkForceDisable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForceDisable.CheckedChanged
    If chkForceDisable.Checked Then
      tbxForce.Enabled = False
    Else
      tbxForce.Enabled = True
    End If
  End Sub
End Class