Public Class frmMain

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        General.MenuAction(Me, frmMenu, txbName.Text)
    End Sub

    Private Sub txbName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbName.KeyDown
        If e.KeyCode = Keys.Return Then
            e.Handled = True
            General.MenuAction(Me, frmMenu, txbName.Text)
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtVersion.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & " | " & My.Application.Info.Description
    End Sub
End Class
