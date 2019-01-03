Public Class frmFinalEvent
    Dim pic As Integer
    Dim _intel As Integer
    Dim _beauty As Integer
    Sub AddDefaultCombo(ByVal frm As Panel)
        For Each cmb In frm.Controls.OfType(Of ComboBox)()
            cmb.Text = "0.00"
        Next
    End Sub
    Public Sub NumberOfJudges(ByVal frm As Control)
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_number_of_judges"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            If dr.HasRows Then
                While dr.Read()
                    Judges = dr("NumberOfJudge")
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub

    Function LoadListBI(ByVal lvtop As ListView, lblJudge As Label)

        Try
            Dim sql As String
            'sql = String.Concat("SELECT * FROM " & variableTable & "")
            variableTable = "tbl_top_finalist"
            sql = String.Concat("SELECT * FROM " & variableTable & "")
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            lvtop.Items.Clear()

            If dr.HasRows Then
                While dr.Read
                    Dim x As Integer
                    For x = 1 To Judges
                        If lblJudge.Text = String.Concat("J" & x & "") Then
                            lvtop.Items.Add(dr("can_no"))
                            With lvtop.Items(lvtop.Items.Count - 1).SubItems
                                .Add(dr(String.Concat("b" & x & "")))
                                .Add(dr(String.Concat("i" & x & "")))
                            End With
                        End If
                    Next
                End While
            End If

            dbClose()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical + vbOKOnly, "Message")
        End Try
        Return 0
    End Function

    Function Picturepic()
        pic = lvTopScore.SelectedItems(lvTopScore.SelectedItems.Count - 1).SubItems(0).Text

        'for boys
        If pic = 1 Then
            PictureBox1.Image = My.Resources._1
        ElseIf pic = 2 Then
            PictureBox1.Image = My.Resources._2
        ElseIf pic = 3 Then
            PictureBox1.Image = My.Resources._3
        ElseIf pic = 4 Then
            PictureBox1.Image = My.Resources._4
        ElseIf pic = 5 Then
            PictureBox1.Image = My.Resources._5
        ElseIf pic = 6 Then
            PictureBox1.Image = My.Resources._6
        ElseIf pic = 7 Then
            PictureBox1.Image = My.Resources._7
        ElseIf pic = 8 Then
            PictureBox1.Image = My.Resources._8
        ElseIf pic = 9 Then
            PictureBox1.Image = My.Resources._9
        ElseIf pic = 10 Then
            PictureBox1.Image = My.Resources._10
        ElseIf pic = 11 Then
            PictureBox1.Image = My.Resources._11
        ElseIf pic = 12 Then
            PictureBox1.Image = My.Resources._12
        ElseIf pic = 13 Then
            PictureBox1.Image = My.Resources._13
        ElseIf pic = 14 Then
            PictureBox1.Image = My.Resources._14
        ElseIf pic = 15 Then
            PictureBox1.Image = My.Resources._15
        End If

        Return 0
    End Function
    Public Sub Beauty(ByVal FieldName As Integer)

        Try
            Dim sql As String
            sql = String.Concat("SELECT * FROM tbl_event_details WHERE event = " & FieldName & "")
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            If dr.HasRows Then
                While dr.Read()
                    EventMaxScore = dr("maxScore")
                    EventMinScore = dr("minScore")

                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub

    Function SubmitScore(ByVal lvScore As ListView, lblJudge As Label, JudgeNo As Integer)
        Dim sql As String
        Try
            sql = ""
            For i = 0 To lvScore.Items.Count - 1
                For x = 1 To JudgeNo
                    If lblJudge.Text = String.Concat("j" & x & "") Then
                        sql = String.Concat("UPDATE " & variableTable & " SET " & ("b" & x) & " = '" & lvScore.Items(i).SubItems(1).Text & "', " & ("i" & x) & " = '" & lvScore.Items(i).SubItems(2).Text & "' WHERE can_no = '" & lvScore.Items(i).Text & "'")
                    End If
                Next x

                dbConnect()
                With cmd
                    .Connection = cn
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
            Next i

            dbClose()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical + vbOKOnly, "Message")
        End Try

        Return 0
    End Function

    Public Sub ValidateComboMaxMinParamBI(ByRef frm As Panel, ByVal eventMaximum As Double, ByVal eventMinimum As Double)

        For Each cmb In frm.Controls.OfType(Of ComboBox)()
            If cmb.Text = "" Then
                cmb.Text = 0
            End If

            If cmb.Text.Contains("..") = True Then
                cmb.Text = String.Format("{0:0.00}", Val(cmb.Text))

            Else
                cmb.Text = String.Format("{0:0.00}", Val(cmb.Text))
            End If

            If cmb.Text >= eventMinimum And cmb.Text <= eventMaximum Then
                cmb.Text = String.Format("{0:0.00}", Val(cmb.Text))
            Else
                Dim a As String = "0.00"
                cmb.Text = String.Format("{0:0.00}", Val(a))
            End If
        Next
    End Sub

    Public Sub ValidateComboMaxMinParamINTEL(ByRef frm As Panel, ByVal eventMaximum As Double, ByVal eventMinimum As Double)

        For Each cmb In frm.Controls.OfType(Of ComboBox)()
            If cmb.Text = "" Then
                cmb.Text = 0
            End If

            If cmb.Text.Contains("..") = True Then
                cmb.Text = String.Format("{0:0.00}", Val(cmb.Text))

            Else
                cmb.Text = String.Format("{0:0.00}", Val(cmb.Text))
            End If

            If cmb.Text >= eventMinimum And cmb.Text <= eventMaximum Then
                cmb.Text = String.Format("{0:0.00}", Val(cmb.Text))
            Else
                Dim a As String = "0.00"
                cmb.Text = String.Format("{0:0.00}", Val(a))
            End If
        Next
    End Sub

    Private Sub frmFinalEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddDefaultCombo(pnlBeauty)
        AddDefaultCombo(pnlInt)

        '' EventNumber(Me)
        NumberOfCandidates()
        NumberOfJudges(Me)

        cmbBeauty1.Enabled = False
        cmbIntel1.Enabled = False
        btnConfirm.Enabled = False
        btnCancel.Enabled = False

        lvTopScore.Enabled = True

        LoadListBI(lvTopScore, lblJno)
    End Sub

    Private Sub lvTopScore_Click(sender As Object, e As EventArgs) Handles lvTopScore.Click
        Picturepic()

        With lvTopScore.SelectedItems(lvTopScore.SelectedItems.Count - 1)
            lblNumber.Text = .SubItems(0).Text
            cmbBeauty1.Text = .SubItems(1).Text
            cmbIntel1.Text = .SubItems(2).Text

            cmbBeauty1.Enabled = True
            cmbIntel1.Enabled = True

            cmbBeauty1.Focus()
            cmbBeauty1.SelectAll()

            btnConfirm.Enabled = True
            btnCancel.Enabled = True

            lvTopScore.Enabled = False

        End With
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        For k = 0 To lvTopScore.Items.Count - 1
            If lvTopScore.Items(k).SubItems(1).Text = "0.00" Or lvTopScore.Items(k).SubItems(2).Text = "0.00" Then
                MsgBox("Plese score all the candidates", vbCritical, "Message")
                Exit Sub
            End If
        Next

        If MsgBox("Are you sure you want to submit your scores", vbQuestion + vbYesNo, "Message") = vbNo Then Exit Sub

        SubmitScore(lvTopScore, lblJno, Judges)

        MsgBox("Score successfully submitted", vbInformation)

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cmbBeauty1.Text = "0.00"
        cmbIntel1.Text = "0.00"

        cmbBeauty1.Enabled = False
        cmbIntel1.Enabled = False
        btnConfirm.Enabled = False
        btnCancel.Enabled = False

        lvTopScore.Enabled = True

        pic = 0
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        For x = 0 To lvTopScore.Items.Count - 1
            If lvTopScore.Items(x).Text = lvTopScore.SelectedItems(lvTopScore.SelectedItems.Count - 1).SubItems(0).Text Then
                lvTopScore.Items(x).SubItems(1).Text = cmbBeauty1.Text
                lvTopScore.Items(x).SubItems(2).Text = cmbIntel1.Text
            End If
        Next

        cmbBeauty1.Text = "0.00"
        cmbIntel1.Text = "0.00"

        cmbBeauty1.Enabled = False
        cmbIntel1.Enabled = False
        btnConfirm.Enabled = False
        btnCancel.Enabled = False

        lvTopScore.Enabled = True
    End Sub

    Private Sub pnlBeauty_LostFocus(sender As Object, e As EventArgs) Handles cmbBeauty1.LostFocus
        _beauty = 3
        Beauty(_beauty)
        ValidateComboMaxMinParamBI(pnlBeauty, EventMaxScore, EventMinScore)

    End Sub

    Private Sub pnlInt_LostFocus(sender As Object, e As EventArgs) Handles cmbIntel1.LostFocus
        _intel = 3
        Beauty(_intel)
        ValidateComboMaxMinParamINTEL(pnlInt, EventMaxScore, EventMinScore)
    End Sub
End Class