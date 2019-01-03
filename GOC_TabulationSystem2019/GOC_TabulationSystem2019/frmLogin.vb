Public Class frmLogin

    'FOR DEFAULTS Scores
    Public Sub LoadJudges(ByVal frm As Control)
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_load_number_of_judges"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            'Clear all the combo
            ClearAllCombo(frm)

            If dr.HasRows Then
                While dr.Read()

                    'load all Combobox in a form
                    For Each cmb In frm.Controls.OfType(Of ComboBox)()
                        cmb.Items.Add(dr("loadJudges"))
                    Next

                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub

    Public Sub CheckEvent()
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_events_status"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            If dr.HasRows Then
                While dr.Read()
                    'EventChecker Global variable
                    EventChecker = dr("eventNumber")
                End While
            End If

            dbClose()

        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try

    End Sub

    Function LoadTheEvent()
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_event_details WHERE event =" + EventChecker + ""
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            'frmAllEventServer.cmbAllEvent.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    'If dr("eventName") = 3 Then
                    '    'frmFinalEvent.lblEventName.Font = New Font(FontFamily.GenericSansSerif, 24.0F, FontStyle.Bold)
                    '    'frmFinalEvent.lblEventName.Location = New Point(550, 10)
                    '    frmFinalEvent.ShowDialog()
                    '    Exit Function
                    'Else
                    frmAllEvents.lblEventName.Text = dr("eventName")
                    'design for the Event Title
                    ' frmAllEvents.lblEventName.Font = New Font(FontFamily.GenericSansSerif, 24.0F, FontStyle.Bold)
                    frmAllEvents.lblEventName.Location = New Point(550, 10)

                    ' End If
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
        Return 0
    End Function

    Public Sub VariableTableScoreLoadCombo(ByVal frm As Control, tbl As String, fieldName As String)
        Try
            Dim sql As String
            dbConnect()

            'variableQuery = String.Concat("SELECT * FROM  " & tbl & " ORDER BY " & fieldName & " DESC")
            variableQuery = String.Concat("SELECT * FROM  " & tbl & " ORDER BY 1 DESC")
            sql = variableQuery
            'MessageBox.Show(variableQuery)
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            'Clear all the combo
            ClearAllCombo(frm)
            'MessageBox.Show(variableQuery)
            If dr.HasRows Then
                While dr.Read()

                    'load all Combobox in a form
                    For Each cmb In frm.Controls.OfType(Of ComboBox)()
                        cmb.Items.Add(dr(String.Concat("" & fieldName & "")))
                    Next
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub

    Public Sub PassJudgeto()
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_load_number_of_judges WHERE loadJudges ='" + cboJudge.SelectedItem + "'"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With
            'cboJudge.Items.Clear()
            variableField = 0
            'frmServer.cmbEvent.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    frmAllEvents.lblJudgeNo.Text = dr("loadJudges")
                    For x = 1 To Judges
                        If dr("loadJudges") = String.Concat("J" & x & "") Then

                            variableTable = String.Concat("tbl_max_min_1")
                            variableField = 1

                            ' MessageBox.Show(variableTable + " " + variableField)
                            VariableTableScoreLoadCombo(frmAllEvents, variableTable, variableField)
                            dbClose()
                            Exit Sub
                        End If
                    Next
                End While
            End If
            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub

    Public Sub PassJudgeToBI()
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_load_number_of_judges WHERE loadJudges ='" + cboJudge.SelectedItem + "'"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With
            'cboJudge.Items.Clear()
            variableField = 0
            'frmServer.cmbEvent.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    frmFinalEvent.lblJno.Text = dr("loadJudges")

                End While
            End If
            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJudges(Me)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CheckEvent()
        If EventChecker = 3 Then
            PassJudgeToBI()
            frmFinalEvent.ShowDialog()
        Else


            LoadTheEvent()
            PassJudgeto()
            frmAllEvents.Show()
        End If




    End Sub

    Private Sub cboJudge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJudge.SelectedIndexChanged

    End Sub

    Private Sub cboJudge_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboJudge.SelectedValueChanged


    End Sub
End Class