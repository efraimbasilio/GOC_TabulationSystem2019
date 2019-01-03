<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalEvent
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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.pnlInt = New System.Windows.Forms.Panel()
        Me.cmbIntel1 = New System.Windows.Forms.ComboBox()
        Me.cmbBeauty1 = New System.Windows.Forms.ComboBox()
        Me.pnlBeauty = New System.Windows.Forms.Panel()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.lblJno = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvTopScore = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlInt.SuspendLayout()
        Me.pnlBeauty.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNumber.Font = New System.Drawing.Font("Monotype Corsiva", 25.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(317, 699)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(0, 41)
        Me.lblNumber.TabIndex = 204
        '
        'pnlInt
        '
        Me.pnlInt.Controls.Add(Me.cmbIntel1)
        Me.pnlInt.Location = New System.Drawing.Point(1021, 277)
        Me.pnlInt.Name = "pnlInt"
        Me.pnlInt.Size = New System.Drawing.Size(187, 62)
        Me.pnlInt.TabIndex = 203
        '
        'cmbIntel1
        '
        Me.cmbIntel1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIntel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbIntel1.FormattingEnabled = True
        Me.cmbIntel1.Location = New System.Drawing.Point(1, 11)
        Me.cmbIntel1.Name = "cmbIntel1"
        Me.cmbIntel1.Size = New System.Drawing.Size(184, 41)
        Me.cmbIntel1.TabIndex = 3
        '
        'cmbBeauty1
        '
        Me.cmbBeauty1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBeauty1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbBeauty1.FormattingEnabled = True
        Me.cmbBeauty1.Location = New System.Drawing.Point(1, 11)
        Me.cmbBeauty1.Name = "cmbBeauty1"
        Me.cmbBeauty1.Size = New System.Drawing.Size(184, 41)
        Me.cmbBeauty1.TabIndex = 2
        '
        'pnlBeauty
        '
        Me.pnlBeauty.Controls.Add(Me.cmbBeauty1)
        Me.pnlBeauty.Location = New System.Drawing.Point(1020, 166)
        Me.pnlBeauty.Name = "pnlBeauty"
        Me.pnlBeauty.Size = New System.Drawing.Size(187, 62)
        Me.pnlBeauty.TabIndex = 201
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.BackColor = System.Drawing.Color.Transparent
        Me.lblEventName.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblEventName.Location = New System.Drawing.Point(93, 50)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(354, 79)
        Me.lblEventName.TabIndex = 199
        Me.lblEventName.Text = "Top 5 Finalist"
        '
        'lblJno
        '
        Me.lblJno.AutoSize = True
        Me.lblJno.BackColor = System.Drawing.Color.Transparent
        Me.lblJno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJno.ForeColor = System.Drawing.Color.Black
        Me.lblJno.Location = New System.Drawing.Point(126, 9)
        Me.lblJno.Name = "lblJno"
        Me.lblJno.Size = New System.Drawing.Size(78, 24)
        Me.lblJno.TabIndex = 191
        Me.lblJno.Text = "Label1"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(507, 425)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(477, 46)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Scores"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(81, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 552)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 200
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Intelligence"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 72
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(501, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(495, 33)
        Me.Label20.TabIndex = 198
        Me.Label20.Text = "Note:   Please click the Candidate Number to score"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1128, 384)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 35)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(1023, 384)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(99, 35)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1010, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 23)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Beauty (Minimum 15 - Maximum 25)"
        '
        'lvTopScore
        '
        Me.lvTopScore.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lvTopScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvTopScore.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTopScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lvTopScore.FullRowSelect = True
        Me.lvTopScore.GridLines = True
        Me.lvTopScore.Location = New System.Drawing.Point(507, 131)
        Me.lvTopScore.Name = "lvTopScore"
        Me.lvTopScore.Size = New System.Drawing.Size(477, 288)
        Me.lvTopScore.TabIndex = 1
        Me.lvTopScore.UseCompatibleStateImageBehavior = False
        Me.lvTopScore.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Beauty "
        Me.ColumnHeader2.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 192
        Me.Label1.Text = "Judge No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1010, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 23)
        Me.Label3.TabIndex = 205
        Me.Label3.Text = "Intelligence (Minimum 15 - Maximum 25)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(144, 704)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 33)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Candidate No. :"
        '
        'frmFinalEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.pnlInt)
        Me.Controls.Add(Me.pnlBeauty)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.lblJno)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvTopScore)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFinalEvent"
        Me.Text = "frmFinalEvent"
        Me.pnlInt.ResumeLayout(False)
        Me.pnlBeauty.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents pnlInt As Panel
    Friend WithEvents cmbIntel1 As ComboBox
    Friend WithEvents cmbBeauty1 As ComboBox
    Friend WithEvents pnlBeauty As Panel
    Friend WithEvents lblEventName As Label
    Friend WithEvents lblJno As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label20 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lvTopScore As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
