
Module Functions

    Public StatusOnOff As String
    Public ctrA As Integer
    Public printBoy As Integer

    Public Candidates As Integer
    Public Judges As Integer
    Public NumberOfTopFinalists As Integer

    Public EventMaxScore As Double
    Public EventMinScore As Double

    Public EventMaxScoreInt As Double
    Public EventMinScoreInt As Double

    Public ExitMe As Integer
    Public FormStatus As String
    Public EventNumberValue As Integer

    Public variableTable, variableTableScore2 As String
    Public variableQuery As String
    Public variableField As String
    Public variableTableScore As String

    Public varSqlquery As String
    Public sqlquery As String

    Public variableEvent, theVariableField As String

    Public DefaultScoreDataGrid As Double

    Function CallAllEvents()
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_event_details"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            frmServer.cmbAllEvent.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    frmServer.cmbAllEvent.Items.Add(dr("eventName"))
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
        Return 0
    End Function


    Public Sub EventNumber(ByVal frm As Control)
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
                    'EventNumberValue is global
                    'To Declare Universally
                    EventNumberValue = dr("eventNumber")

                    'to view in Server Side
                    frmServer.lblEventNumber.Text = EventNumberValue
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
    End Sub
End Module
