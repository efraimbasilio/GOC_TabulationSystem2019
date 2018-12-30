Public Class frmServer
    Private Sub frmServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load events to Select Events
        CallAllEvents()
        'load the current event in the server
        EventNumber(Me)

    End Sub
End Class