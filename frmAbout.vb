Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmAbout
  Inherits System.Windows.Forms.Form
  '--------------------------------------
  'フォームロード
  '--------------------------------------
  Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    Me.Top = Form1.Top
    Me.Left = Form1.Left
    lblVersion.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
  End Sub
  '--------------------------------------
  '「OK」ボタン
  '--------------------------------------
  Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
    Me.Close()
  End Sub
End Class