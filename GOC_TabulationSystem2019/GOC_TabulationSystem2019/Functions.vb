﻿
Module Functions

    Public StatusOnOff As String
    Public ctrA As Integer
    Public printBoy As Integer

    Public Candidates As Integer
    Public Judges As Integer = 9
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

    Function CallNumberEvents()
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_event_details"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            frmServer.cmbEvent.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    frmServer.cmbEvent.Items.Add(dr("event"))
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, vbCritical, "Message")
        End Try
        Return 0
    End Function

    'Load Score in the Listview scores depends in the selection
    Function LoadList(ByVal AllList As ListView, variableTable As String)
        Try
            Dim sql As String
            sql = String.Concat("SELECT * FROM " & variableTable & " ORDER BY can_no")
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            AllList.Items.Clear()

            If dr.HasRows Then
                While dr.Read()
                    AllList.Items.Add(dr("can_no"))
                    With AllList.Items(AllList.Items.Count - 1).SubItems
                        .Add(dr("J1"))
                        .Add(dr("J2"))
                        .Add(dr("J3"))
                        .Add(dr("J4"))
                        .Add(dr("J5"))
                        .Add(dr("J6"))
                        .Add(dr("J7"))
                        .Add(dr("J8"))
                        .Add(dr("J9"))
                        .Add(dr("total"))
                    End With
                End While

            End If

            dbClose()

        Catch ex As Exception
            MsgBox("Error" & ex.Message, "Message")
        End Try
        Return 0
    End Function

    'Compute events depends in the selection -// 90 percent Generic for 9 judges
    Function ComputeEvent(ByVal AllList As ListView, variableTableEvent As String, variableFieldEvent As String)
        With AllList
            For x = 0 To .Items.Count - 1
                .Items(x).SubItems(10).Text = FormatNumber((Val(.Items(x).SubItems(1).Text) + Val(.Items(x).SubItems(2).Text) _
                                             + Val(.Items(x).SubItems(3).Text) + Val(.Items(x).SubItems(4).Text) _
                                             + Val(.Items(x).SubItems(5).Text) + Val(.Items(x).SubItems(6).Text) _
                                             + Val(.Items(x).SubItems(7).Text) + Val(.Items(x).SubItems(8).Text) _
                                             + Val(.Items(x).SubItems(9).Text)) / Val(Judges), 2)
            Next
        End With

        For x = 0 To AllList.Items.Count - 1
            Try
                Dim sql As String
                sql = String.Concat("UPDATE " & variableTableEvent & " SET total = '" & AllList.Items(x).SubItems(10).Text & "' WHERE can_no = '" & AllList.Items(x).Text & "'")

                dbConnect()

                With cmd
                    .Connection = cn
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                dbClose()

            Catch ex As Exception
                MsgBox("Error" & ex.Message.ToString, "Message")
            End Try
        Next


        For x = 0 To AllList.Items.Count - 1
            Try
                Dim sql As String
                sql = String.Concat("UPDATE  tbl_elimination SET " & variableFieldEvent & " = '" & AllList.Items(x).SubItems(10).Text & "' WHERE can_no = '" & AllList.Items(x).Text & "'")

                dbConnect()

                With cmd
                    .Connection = cn
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                dbClose()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message.ToString, vbCritical + vbOKOnly, "Message")
            End Try
        Next
        Return 0
    End Function

    'Sort Scores Computed from Server
    Function SortEvent(ByVal AllList As ListView, variableTable As String)
        Try
            Dim sql As String
            sql = String.Concat("SELECT * FROM " & variableTable & " ORDER BY total DESC")
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            AllList.Items.Clear()

            If dr.HasRows Then
                While dr.Read()
                    AllList.Items.Add(dr("can_no"))
                    With AllList.Items(AllList.Items.Count - 1).SubItems
                        .Add(dr("J1"))
                        .Add(dr("J2"))
                        .Add(dr("J3"))
                        .Add(dr("J4"))
                        .Add(dr("J5"))
                        .Add(dr("J6"))
                        .Add(dr("J7"))
                        .Add(dr("J8"))
                        .Add(dr("J9"))
                        .Add(dr("total"))
                    End With
                End While
            End If

            dbClose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message, "Message")
        End Try
        MsgBox("Score successfully COMPUTED and SORTED", vbInformation)
        Return 0
    End Function


    Function CallEliminationScores(ByVal lvElim As ListView)
        Try
            Dim sql As String
            sql = "SELECT * FROM tbl_elimination ORDER BY can_no"
            dbConnect()
            With cmd
                .Connection = cn
                .CommandText = sql
                dr = .ExecuteReader
            End With

            lvElim.Items.Clear()

            If dr.HasRows Then
                While dr.Read()
                    lvElim.Items.Add(dr("can_no"))
                    With lvElim.Items(lvElim.Items.Count - 1).SubItems
                        .Add(dr("total"))
                        .Add(dr("first"))
                        .Add(dr("second"))
                    End With
                End While

            End If

            dbClose()

        Catch ex As Exception
            MsgBox("Error" & ex.Message, "Message")
        End Try
        Return 0
    End Function
End Module
