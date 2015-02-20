Public Class frmTime
    Dim generator As New Random
    Dim varNumber As Integer = generator.Next(0, 48)
    Dim varTime As Date
    Dim varAnswer As Date
    Dim varType As Integer = generator.Next(0, 4)
    Dim varCorrect As Boolean = False

    Dim varMinuteMod As Integer = varNumber Mod 4
    Dim varMinute As Integer
    Dim varHour As Integer = varNumber \ 4

    Dim varNumber1 As Integer = generator.Next(0, 48)
    Dim varMinuteMod1 As Integer = varNumber1 Mod 4
    Dim varMinute1 As Integer
    Dim varHour1 As Integer = varNumber1 \ 4
    Dim varTime1 As Date

    Dim varNumber2 As Integer = generator.Next(0, 48)
    Dim varMinuteMod2 As Integer = varNumber2 Mod 4
    Dim varMinute2 As Integer
    Dim varHour2 As Integer = varNumber2 \ 4
    Dim varTime2 As Date

    Dim varNumber3 As Integer = generator.Next(0, 48)
    Dim varMinuteMod3 As Integer = varNumber3 Mod 4
    Dim varMinute3 As Integer
    Dim varHour3 As Integer = varNumber3 \ 4
    Dim varTime3 As Date

    Dim varNumber4 As Integer = generator.Next(0, 48)
    Dim varMinuteMod4 As Integer = varNumber4 Mod 4
    Dim varMinute4 As Integer
    Dim varHour4 As Integer = varNumber4 \ 4
    Dim varTime4 As Date

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWelcome.Text = "Hello " + General.Name + " please answer the time questions"
        Select Case varMinuteMod
            Case 0
                varMinute = 0
            Case 1
                varMinute = 15
            Case 2
                varMinute = 30
            Case 3
                varMinute = 45
            Case Else
                varMinute = 0
        End Select
        Select Case varHour
            Case 0
                varHour = 12
            Case Else
                varHour = varHour
        End Select

        Select Case varMinuteMod1
            Case 0
                varMinute1 = 0
            Case 1
                varMinute1 = 15
            Case 2
                varMinute1 = 30
            Case 3
                varMinute1 = 45
            Case Else
                varMinute1 = 0
        End Select
        Select Case varHour1
            Case 0
                varHour1 = 12
            Case Else
                varHour1 = varHour1
        End Select

        Select Case varMinuteMod2
            Case 0
                varMinute2 = 0
            Case 1
                varMinute2 = 15
            Case 2
                varMinute2 = 30
            Case 3
                varMinute2 = 45
            Case Else
                varMinute2 = 0
        End Select
        Select Case varHour2
            Case 0
                varHour2 = 12
            Case Else
                varHour2 = varHour2
        End Select

        Select Case varMinuteMod3
            Case 0
                varMinute3 = 0
            Case 1
                varMinute3 = 15
            Case 2
                varMinute3 = 30
            Case 3
                varMinute3 = 45
            Case Else
                varMinute3 = 0
        End Select
        Select Case varHour3
            Case 0
                varHour3 = 12
            Case Else
                varHour3 = varHour3
        End Select

        Select Case varMinuteMod4
            Case 0
                varMinute4 = 0
            Case 1
                varMinute4 = 15
            Case 2
                varMinute4 = 30
            Case 3
                varMinute4 = 45
            Case Else
                varMinute4 = 0
        End Select
        Select Case varHour4
            Case 0
                varHour4 = 12
            Case Else
                varHour4 = varHour4
        End Select

        'pbTime.Image = imgTime.Images(varNumber)
        txtTime.Text = varHour & ":" & varMinute
        Date.TryParse(varHour & ":" & varMinute, aClock.Time)
        Date.TryParse(varHour & ":" & varMinute, varTime)
        Date.TryParse(varHour1 & ":" & varMinute1, varTime1)
        Date.TryParse(varHour2 & ":" & varMinute2, varTime2)
        Date.TryParse(varHour3 & ":" & varMinute3, varTime3)
        Date.TryParse(varHour4 & ":" & varMinute4, varTime4)
        txtCount.Text = General.Answered + 1 & " of " & General.MaxQuestion + 1
        Select Case varType
            Case 0
                time1.Text = varTime.ToString("hh:mm")
                time2.Text = varTime2.ToString("hh:mm")
                time3.Text = varTime3.ToString("hh:mm")
                time4.Text = varTime4.ToString("hh:mm")
            Case 1
                time1.Text = varTime1.ToString("hh:mm")
                time2.Text = varTime.ToString("hh:mm")
                time3.Text = varTime3.ToString("hh:mm")
                time4.Text = varTime4.ToString("hh:mm")
            Case 2
                time1.Text = varTime1.ToString("hh:mm")
                time2.Text = varTime2.ToString("hh:mm")
                time3.Text = varTime.ToString("hh:mm")
                time4.Text = varTime4.ToString("hh:mm")
            Case 3
                time1.Text = varTime1.ToString("hh:mm")
                time2.Text = varTime2.ToString("hh:mm")
                time3.Text = varTime3.ToString("hh:mm")
                time4.Text = varTime.ToString("hh:mm")
        End Select
        'General.Answered = General.Answered + 1
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        General.ClearResults()
        General.MenuAction(Me, frmMenu)
    End Sub

    Private Sub CheckAns(ByVal sender As Object)
        varAnswer = Convert.ToDateTime(sender.Text)
        If (varTime = varAnswer) Then
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
        Select Case sender.Name
            Case "time1"
            Case "time2"
            Case "time3"
            Case "time4"
            Case Else
        End Select
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If General.Answered <> General.MaxQuestion Then
            imgDetails.Visible = False
            txtDetails.Visible = False
            General.Generate()
            varNumber = generator.Next(0, 48)
            varMinuteMod = varNumber Mod 4
            varHour = varNumber \ 4
            varType = generator.Next(0, 4)

            varNumber1 = generator.Next(0, 48)
            varMinuteMod1 = varNumber1 Mod 4
            varHour1 = varNumber1 \ 4
            varNumber2 = generator.Next(0, 48)
            varMinuteMod2 = varNumber2 Mod 4
            varHour2 = varNumber2 \ 4
            varNumber3 = generator.Next(0, 48)
            varMinuteMod3 = varNumber3 Mod 4
            varHour3 = varNumber3 \ 4
            varNumber4 = generator.Next(0, 48)
            varMinuteMod4 = varNumber4 Mod 4
            varHour4 = varNumber4 \ 4

            Select Case varMinuteMod
                Case 0
                    varMinute = 0
                Case 1
                    varMinute = 15
                Case 2
                    varMinute = 30
                Case 3
                    varMinute = 45
                Case Else
                    varMinute = 0
            End Select
            Select Case varHour
                Case 0
                    varHour = 12
                Case Else
                    varHour = varHour
            End Select
            Select Case varMinuteMod1
                Case 0
                    varMinute1 = 0
                Case 1
                    varMinute1 = 15
                Case 2
                    varMinute1 = 30
                Case 3
                    varMinute1 = 45
                Case Else
                    varMinute1 = 0
            End Select
            Select Case varHour1
                Case 0
                    varHour1 = 12
                Case Else
                    varHour1 = varHour1
            End Select

            Select Case varMinuteMod2
                Case 0
                    varMinute2 = 0
                Case 1
                    varMinute2 = 15
                Case 2
                    varMinute2 = 30
                Case 3
                    varMinute2 = 45
                Case Else
                    varMinute2 = 0
            End Select
            Select Case varHour2
                Case 0
                    varHour2 = 12
                Case Else
                    varHour2 = varHour2
            End Select

            Select Case varMinuteMod3
                Case 0
                    varMinute3 = 0
                Case 1
                    varMinute3 = 15
                Case 2
                    varMinute3 = 30
                Case 3
                    varMinute3 = 45
                Case Else
                    varMinute3 = 0
            End Select
            Select Case varHour3
                Case 0
                    varHour3 = 12
                Case Else
                    varHour3 = varHour3
            End Select

            Select Case varMinuteMod4
                Case 0
                    varMinute4 = 0
                Case 1
                    varMinute4 = 15
                Case 2
                    varMinute4 = 30
                Case 3
                    varMinute4 = 45
                Case Else
                    varMinute4 = 0
            End Select
            Select Case varHour4
                Case 0
                    varHour4 = 12
                Case Else
                    varHour4 = varHour4
            End Select
            'pbTime.Image = imgTime.Images(varNumber)
            txtTime.Text = varHour & ":" & varMinute
            Date.TryParse(varHour & ":" & varMinute, aClock.Time)
            Date.TryParse(varHour & ":" & varMinute, varTime)
            Date.TryParse(varHour1 & ":" & varMinute1, varTime1)
            Date.TryParse(varHour2 & ":" & varMinute2, varTime2)
            Date.TryParse(varHour3 & ":" & varMinute3, varTime3)
            Date.TryParse(varHour4 & ":" & varMinute4, varTime4)
            Select Case varType
                Case 0
                    time1.Text = varTime.ToString("hh:mm")
                    time2.Text = varTime2.ToString("hh:mm")
                    time3.Text = varTime3.ToString("hh:mm")
                    time4.Text = varTime4.ToString("hh:mm")
                Case 1
                    time1.Text = varTime1.ToString("hh:mm")
                    time2.Text = varTime.ToString("hh:mm")
                    time3.Text = varTime3.ToString("hh:mm")
                    time4.Text = varTime4.ToString("hh:mm")
                Case 2
                    time1.Text = varTime1.ToString("hh:mm")
                    time2.Text = varTime2.ToString("hh:mm")
                    time3.Text = varTime.ToString("hh:mm")
                    time4.Text = varTime4.ToString("hh:mm")
                Case 3
                    time1.Text = varTime1.ToString("hh:mm")
                    time2.Text = varTime2.ToString("hh:mm")
                    time3.Text = varTime3.ToString("hh:mm")
                    time4.Text = varTime.ToString("hh:mm")
            End Select
            varCorrect = False
            General.Answered = General.Answered + 1
            txtCount.Text = General.Answered + 1 & " of " & General.MaxQuestion + 1
        Else
            General.Topic = "Time"
            General.MenuAction(Me, frmAward)
        End If
    End Sub

    Private Sub time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time1.Click, time2.Click, time3.Click, time4.Click
        CheckAns(sender)
    End Sub
End Class
