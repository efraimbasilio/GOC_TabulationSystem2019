Public Class frmLogin

    'FOR DEFAULTS Scores
    Public Sub DefaultScoreLoad(ByVal frm As Control)
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
                    MessageBox.Show(EventChecker)
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
                    frmAllEvents.lblEventName.Text = dr("eventName")
                    frmAllEvents.lblEventName.Font = New Font(FontFamily.GenericSansSerif, 24.0F, FontStyle.Bold)
                    frmAllEvents.lblEventName.Location = New Point(550, 10)
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
        Return 0
    End Function


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CheckEvent()
        LoadTheEvent()

        frmAllEvents.Show()
    End Sub
End Class