Public Class frmServer
    Private Sub frmServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load events to Select Events
        CallAllEvents()
        'load the current event in the server
        EventNumber(Me)
        'load all event number
        CallNumberEvents()
    End Sub

    Private Sub cmbAllEvent_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbAllEvent.SelectedValueChanged

        If cmbAllEvent.SelectedItem = "Swimsuit Competition" Then
            variableEvent = "tbl_first_event"
            theVariableField = "First"

            'Load Score in the Listview scores depends in the selection
            LoadList(lvAllEvents, variableEvent)

            ComputeEvent(lvAllEvents, variableEvent, theVariableField)
            SortEvent(lvAllEvents, variableEvent)

            CallEliminationScores(lvElimination)

        ElseIf cmbAllEvent.SelectedItem = "Evening Gown Competition" Then
            variableEvent = "tbl_second_event"
            theVariableField = "Second"

            'Load Score in the Listview scores depends in the selection
            LoadList(lvAllEvents, variableEvent)
            ComputeEvent(lvAllEvents, variableEvent, theVariableField)
            SortEvent(lvAllEvents, variableEvent)

            CallEliminationScores(lvElimination)
        End If
    End Sub

    Private Sub cmbEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEvent.SelectedIndexChanged
        Try
            Dim sql As String
            sql = "UPDATE tbl_events_status SET eventNumber = '" & cmbEvent.Text & "'"
            dbConnect()

            With cmd
                .Connection = cn
                .CommandText = sql
                .ExecuteNonQuery()
            End With

            dbClose()
            MsgBox("Form activated updated", vbInformation, "Message")

        Catch ex As Exception
            MsgBox("Error" & ex.Message.ToString, vbCritical, "Message")
        End Try

        EventNumber(Me)
    End Sub
End Class