Option Strict Off
Option Explicit On
Friend Class frm_readme
  Inherits System.Windows.Forms.Form
  Const CLLF As String = vbCrLf
  '--------------------------------------
  'フォームロード
  '--------------------------------------
  Private Sub frm_readme_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    Dim txtall As String
    Dim txtline As String

    Me.Top = Form1.Top
    Me.Left = Form1.Left

    On Error GoTo error_end

    FileOpen(1, My.Application.Info.DirectoryPath & "\" & "readme.txt", OpenMode.Input, OpenAccess.Read)
    txtall = ""
    Do Until EOF(1)
      txtline = LineInput(1)
      txtall = txtall & txtline & CLLF
    Loop

    Text1.Text = txtall

    FileClose(1)
    Exit Sub
error_end:
    Text1.Text = "readme.txtが存在しません"
  End Sub
  '--------------------------------------
  '「閉じる」ボタン
  '--------------------------------------
  Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub
End Class