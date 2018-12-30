Module FunctionUtilities
    Public Sub ClearAllCombo(ByRef frm As Control)
        For Each cmb In frm.Controls.OfType(Of ComboBox)()
            cmb.Items.Clear()
        Next
    End Sub
End Module
