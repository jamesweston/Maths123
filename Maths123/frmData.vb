Imports BarChart

Public Class frmData
    Dim generator As New Random
    Dim varNumber As Integer = generator.Next(0, 8)
    Dim varFirstCoin As Decimal
    Dim varSecondCoin As Decimal
    Dim varTotal As Decimal
    Dim varAnswer As Decimal
    Dim varCorrect As Boolean = False
    Dim varData As New ArrayList()
    Dim varQuestions() As String = {"Please select the day of the week with the highest traffic", "Please select the day of the week with the lowest traffic"}
    Dim varQuBit As Integer
    Dim varLarge As Integer
    Dim varSmall As Integer

    Private Sub frmData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWelcome.Text = "Hello " + General.Name + " please answer the data questions"
        txtCount.Text = General.Answered + 1 & " of " & General.MaxQuestion + 1
        HBarChart1.SizingMode = HBarChart.BarSizingMode.AutoScale
        DrawChart()
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        General.ClearResults()
        General.MenuAction(Me, frmMenu)
    End Sub

    Private Sub CheckAns(ByVal e As BarChart.BarEventArgs)
        Dim bar As HBarItem
        If varQuBit = 0 Then
            If HBarChart1.GetAt(e.BarIndex, bar) Then
                If bar.Value = FindLargest(varData) Then
                    imgDetails.Visible = True
                    txtDetails.Visible = True
                    txtDetails.Text = "Well Done"
                    imgDetails.Image = My.Resources.accept
                    If varCorrect = False Then
                        General.Correct = General.Correct + 1
                    End If
                    varCorrect = True
                    btnNext.Focus()
                Else
                    imgDetails.Visible = True
                    txtDetails.Visible = True
                    txtDetails.Text = "Try Again"
                    imgDetails.Image = My.Resources.delete
                End If
            End If
        ElseIf varQuBit = 1 Then
            If HBarChart1.GetAt(e.BarIndex, bar) Then
                If bar.Value = FindSmallest(varData) Then
                    imgDetails.Visible = True
                    txtDetails.Visible = True
                    txtDetails.Text = "Well Done"
                    imgDetails.Image = My.Resources.accept
                    If varCorrect = False Then
                        General.Correct = General.Correct + 1
                    End If
                    varCorrect = True
                    btnNext.Focus()
                Else
                    imgDetails.Visible = True
                    txtDetails.Visible = True
                    txtDetails.Text = "Try Again"
                    imgDetails.Image = My.Resources.delete
                End If
            End If
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If General.Answered <> General.MaxQuestion Then
            varCorrect = False
            imgDetails.Visible = False
            txtDetails.Visible = False
            DrawChart()
            General.Answered = General.Answered + 1
            txtCount.Text = General.Answered + 1 & " of " & General.MaxQuestion + 1
        Else
            General.Topic = "Data"
            General.MenuAction(Me, frmAward)
        End If
    End Sub

    Private Sub DrawChart()
        varData.Clear()
        For index As Integer = 0 To 4

            varData.Add(generator.Next(0, 50))
        Next
        Dim temp As Integer = generator.Next(0, 2)
        lblQu.Text = varQuestions(temp)
        varQuBit = temp
        HBarChart1.Items.Clear()
        HBarChart1.Items.Add(New HBarItem(varData(0), "Mon", Color.White))
        HBarChart1.Items.Add(New HBarItem(varData(1), "Tue", Color.Red))
        HBarChart1.Items.Add(New HBarItem(varData(2), "Wed", Color.Green))
        HBarChart1.Items.Add(New HBarItem(varData(3), "Thu", Color.Black))
        HBarChart1.Items.Add(New HBarItem(varData(4), "Fri", Color.Purple))
        HBarChart1.RedrawChart()
    End Sub

    Private Sub HBarChart1_BarClicked(ByVal sender As System.Object, ByVal e As BarChart.BarEventArgs) Handles HBarChart1.BarClicked
        CheckAns(e)
    End Sub

    Private Function FindLargest(ByVal array As ArrayList)
        Dim max As Integer = array(0)
        For Each i As Integer In array
            If max < i Then
                max = i
            End If
        Next

        Return max
    End Function

    Private Function FindSmallest(ByVal array As ArrayList)
        Dim small As Integer = array(0)
        For Each i As Integer In array
            If i < small Then
                small = i
            End If
        Next
        Return small
    End Function

End Class
