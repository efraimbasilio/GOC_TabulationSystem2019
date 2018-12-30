Public Class frmAllEvents
    Private Sub frmAllEvents_LostFocus(sender As Object, e As EventArgs)

        EventNumber(Me)
        EventMinimumAndMaximumScore(Me)
        ValidateComboMaxMinParam(Me, EventMaxScore, EventMinScore)
    End Sub

    Private Sub frmAllEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddDefaultCombo(Me)
        EventNumber(Me)

        cmbScore1.Focus()
    End Sub
End Class