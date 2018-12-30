<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvAllEvents = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAllEvent = New System.Windows.Forms.ComboBox()
        Me.lblEventNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvAllEvents
        '
        Me.lvAllEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvAllEvents.FullRowSelect = True
        Me.lvAllEvents.GridLines = True
        Me.lvAllEvents.Location = New System.Drawing.Point(674, 39)
        Me.lvAllEvents.Name = "lvAllEvents"
        Me.lvAllEvents.Size = New System.Drawing.Size(664, 301)
        Me.lvAllEvents.TabIndex = 2
        Me.lvAllEvents.UseCompatibleStateImageBehavior = False
        Me.lvAllEvents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 58
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "J1"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "J2"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "J3"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "J4"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "J5"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "J6"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "J7"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "J8"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "J9"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(1138, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Select Event"
        '
        'cmbAllEvent
        '
        Me.cmbAllEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAllEvent.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAllEvent.FormattingEnabled = True
        Me.cmbAllEvent.Location = New System.Drawing.Point(1217, 12)
        Me.cmbAllEvent.Name = "cmbAllEvent"
        Me.cmbAllEvent.Size = New System.Drawing.Size(121, 21)
        Me.cmbAllEvent.TabIndex = 41
        '
        'lblEventNumber
        '
        Me.lblEventNumber.AutoSize = True
        Me.lblEventNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEventNumber.Location = New System.Drawing.Point(752, 15)
        Me.lblEventNumber.Name = "lblEventNumber"
        Me.lblEventNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblEventNumber.TabIndex = 43
        Me.lblEventNumber.Text = "theEventNumber"
        Me.lblEventNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(671, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Current Event:"
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEventNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAllEvent)
        Me.Controls.Add(Me.lvAllEvents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvAllEvents As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAllEvent As ComboBox
    Friend WithEvents lblEventNumber As Label
    Friend WithEvents Label3 As Label
End Class
