
Module Functions
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
End Module
