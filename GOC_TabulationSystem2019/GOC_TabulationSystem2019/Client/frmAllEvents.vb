Public Class frmAllEvents
    Private Sub frmAllEvents_LostFocus(sender As Object, e As EventArgs) Handles _
        cmbScore1.LostFocus, cmbScore2.LostFocus, cmbScore3.LostFocus, cmbScore4.LostFocus, cmbScore5.LostFocus, cmbScore6.LostFocus, cmbScore7.LostFocus,
        cmbScore8.LostFocus, cmbScore9.LostFocus, cmbScore10.LostFocus, cmbScore11.LostFocus, cmbScore12.LostFocus,
        cmbScore13.LostFocus, cmbScore14.LostFocus, cmbScore15.LostFocus

        EventNumber(Me) 'get the current event
        EventMinimumAndMaximumScore(Me) 'set the max and min score
        ValidateComboMaxMinParam(Me, EventMaxScore, EventMinScore) 'load the max and min score in all combobox
    End Sub

    Private Sub frmAllEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddDefaultCombo(Me) 'add default score 0.00
        EventNumber(Me) 'get the current event

        cmbScore1.Focus() 'point to the 1st combobox
    End Sub
    Private Sub frmAllEvents_GotFocus(sender As Object, e As EventArgs) Handles _
         cmbScore1.GotFocus, cmbScore2.GotFocus, cmbScore3.GotFocus, cmbScore4.GotFocus, cmbScore5.GotFocus, cmbScore6.GotFocus, cmbScore7.GotFocus,
         cmbScore8.GotFocus, cmbScore9.GotFocus, cmbScore10.GotFocus, cmbScore11.GotFocus, cmbScore12.GotFocus,
         cmbScore13.GotFocus, cmbScore14.GotFocus, cmbScore15.GotFocus

        If cmbScore1.Focused Then
            PictureBox1.Image = My.Resources._1
            lblNumber.Text = "1"
        ElseIf cmbScore2.Focused Then
            PictureBox1.Image = My.Resources._2
            lblNumber.Text = "2"
        ElseIf cmbScore3.Focused Then
            PictureBox1.Image = My.Resources._3
            lblNumber.Text = "3"
        ElseIf cmbScore4.Focused Then
            PictureBox1.Image = My.Resources._4
            lblNumber.Text = "4"
        ElseIf cmbScore5.Focused Then
            PictureBox1.Image = My.Resources._5
            lblNumber.Text = "5"
        ElseIf cmbScore6.Focused Then
            PictureBox1.Image = My.Resources._6
            lblNumber.Text = "6"
        ElseIf cmbScore7.Focused Then
            PictureBox1.Image = My.Resources._7
            lblNumber.Text = "7"
        ElseIf cmbScore8.Focused Then
            PictureBox1.Image = My.Resources._8
            lblNumber.Text = "8"
        ElseIf cmbScore9.Focused Then
            PictureBox1.Image = My.Resources._9
            lblNumber.Text = "9"
        ElseIf cmbScore10.Focused Then
            PictureBox1.Image = My.Resources._10
            lblNumber.Text = "10"
        ElseIf cmbScore11.Focused Then
            PictureBox1.Image = My.Resources._11
            lblNumber.Text = "11"
        ElseIf cmbScore12.Focused Then
            PictureBox1.Image = My.Resources._12
            lblNumber.Text = "12"
        ElseIf cmbScore13.Focused Then
            PictureBox1.Image = My.Resources._13
            lblNumber.Text = "13"
        ElseIf cmbScore14.Focused Then
            PictureBox1.Image = My.Resources._14
            lblNumber.Text = "14"
        ElseIf cmbScore15.Focused Then
            PictureBox1.Image = My.Resources._15
            lblNumber.Text = "15"
        End If
    End Sub
    Private Sub frmAllEvents_KeyDown(sender As Object, e As KeyEventArgs) Handles _
         cmbScore1.KeyDown, cmbScore2.KeyDown, cmbScore3.KeyDown, cmbScore4.KeyDown, cmbScore5.KeyDown, cmbScore6.KeyDown, cmbScore7.KeyDown,
         cmbScore8.KeyDown, cmbScore9.KeyDown, cmbScore10.KeyDown, cmbScore11.KeyDown, cmbScore12.KeyDown,
         cmbScore13.KeyDown, cmbScore14.KeyDown, cmbScore15.KeyDown

        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            e.Handled = True
        End If

        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmAllEvents_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        cmbScore1.KeyPress, cmbScore2.KeyPress, cmbScore3.KeyPress, cmbScore4.KeyPress, cmbScore5.KeyPress, cmbScore6.KeyPress, cmbScore7.KeyPress,
        cmbScore8.KeyPress, cmbScore9.KeyPress, cmbScore10.KeyPress, cmbScore11.KeyPress, cmbScore12.KeyPress,
        cmbScore13.KeyPress, cmbScore14.KeyPress, cmbScore15.KeyPress


        If Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub btnSubmitScore_Click(sender As Object, e As EventArgs) Handles btnSubmitScore.Click
        ValidateComboZeroScore(Me)

        If ExitMe = 1 Then
            Exit Sub
        Else
            If MsgBox("Are you sure you want to submit your score?", vbQuestion + vbYesNo, "Message") = vbNo Then Exit Sub

            If EventChecker = 1 Then
                variableTableScore2 = "tbl_first_event"
                SubmitScoreVariable2(Me, variableTableScore2)

                MsgBox("Score successfully submitted.", vbInformation, "Message")
                Me.Dispose()

            ElseIf EventChecker = 2 Then
                variableTableScore2 = "tbl_second_event"
                SubmitScoreVariable2(Me, variableTableScore2)

                MsgBox("Score successfully submitted.", vbInformation, "Message")
                Me.Dispose()
            End If



        End If
    End Sub

    Private Sub lblJudgeNo_Click(sender As Object, e As EventArgs) Handles lblJudgeNo.Click

    End Sub
End Class