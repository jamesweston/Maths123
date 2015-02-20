Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWelcome.Text = "Welcome " + General.Name + " please select your topic for today"
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        General.MenuAction(Me, frmMain, Nothing)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s.Click
        General.ApplicationExit()
    End Sub

    Private Sub btnAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddition.Click
        General.MenuAction(Me, frmAddition)
    End Sub

    Private Sub btnSubtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtraction.Click
        General.MenuAction(Me, frmSubtraction)
    End Sub

    Private Sub btnMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplication.Click
        General.MenuAction(Me, frmMultiplication)
    End Sub

    Private Sub btnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        General.MenuAction(Me, frmDivision)
    End Sub

    Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click
        General.MenuAction(Me, frmTime)
    End Sub

    Private Sub btnMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoney.Click
        General.MenuAction(Me, frmMoney)
    End Sub

    Private Sub btnOrdering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdering.Click
        General.MenuAction(Me, frmData)
    End Sub
End Class
