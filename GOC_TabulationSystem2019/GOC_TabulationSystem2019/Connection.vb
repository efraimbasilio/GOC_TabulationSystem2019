Imports MySql.Data.MySqlClient
Module Connection
    Public cn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public Sub dbConnect()
        Try
            cn = New MySqlConnection
            cmd = New MySqlCommand

            With cn
                .ConnectionString = "Server=localhost; Database=db_tabulationdb; Userid=root; Password=;"
                .Open()
            End With

        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical + vbOKOnly, "Cannot Connect to database")
        End Try
    End Sub

    Public Sub dbClose()
        Try
            cmd.Parameters.Clear()
            cmd.Dispose()
            cn.Close()
            cn.Dispose()
        Catch ex As Exception
            dbClose()
            MsgBox("Error: " & ex.Message.ToString, vbCritical + vbOKOnly, "Cannot Connect to database")
        End Try
    End Sub
End Module
