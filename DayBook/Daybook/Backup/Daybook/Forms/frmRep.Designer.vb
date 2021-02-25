<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.gbCri = New System.Windows.Forms.GroupBox
        Me.btnShowRpt = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.gbRptType = New System.Windows.Forms.GroupBox
        Me.cboUsr = New System.Windows.Forms.ComboBox
        Me.rdoUser = New System.Windows.Forms.RadioButton
        Me.rdoItem = New System.Windows.Forms.RadioButton
        Me.rdoExp = New System.Windows.Forms.RadioButton
        Me.rdoDay = New System.Windows.Forms.RadioButton
        Me.gbCri.SuspendLayout()
        Me.gbRptType.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvView
        '
        Me.crvView.ActiveViewIndex = -1
        Me.crvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvView.Location = New System.Drawing.Point(0, 89)
        Me.crvView.Name = "crvView"
        Me.crvView.SelectionFormula = ""
        Me.crvView.Size = New System.Drawing.Size(934, 122)
        Me.crvView.TabIndex = 0
        Me.crvView.ViewTimeSelectionFormula = ""
        '
        'gbCri
        '
        Me.gbCri.BackColor = System.Drawing.Color.Transparent
        Me.gbCri.Controls.Add(Me.btnShowRpt)
        Me.gbCri.Controls.Add(Me.Label2)
        Me.gbCri.Controls.Add(Me.Label1)
        Me.gbCri.Controls.Add(Me.dtpTo)
        Me.gbCri.Controls.Add(Me.dtpFrom)
        Me.gbCri.Location = New System.Drawing.Point(145, 12)
        Me.gbCri.Name = "gbCri"
        Me.gbCri.Size = New System.Drawing.Size(276, 71)
        Me.gbCri.TabIndex = 1
        Me.gbCri.TabStop = False
        Me.gbCri.Text = "Criteria"
        '
        'btnShowRpt
        '
        Me.btnShowRpt.Location = New System.Drawing.Point(91, 45)
        Me.btnShowRpt.Name = "btnShowRpt"
        Me.btnShowRpt.Size = New System.Drawing.Size(107, 23)
        Me.btnShowRpt.TabIndex = 4
        Me.btnShowRpt.Text = "Show Report"
        Me.btnShowRpt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd-MMM-yy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(165, 19)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(90, 20)
        Me.dtpTo.TabIndex = 1
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd-MMM-yy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(42, 19)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(91, 20)
        Me.dtpFrom.TabIndex = 0
        '
        'gbRptType
        '
        Me.gbRptType.BackColor = System.Drawing.Color.Transparent
        Me.gbRptType.Controls.Add(Me.cboUsr)
        Me.gbRptType.Controls.Add(Me.rdoUser)
        Me.gbRptType.Controls.Add(Me.rdoItem)
        Me.gbRptType.Controls.Add(Me.rdoExp)
        Me.gbRptType.Controls.Add(Me.rdoDay)
        Me.gbRptType.Location = New System.Drawing.Point(462, 12)
        Me.gbRptType.Name = "gbRptType"
        Me.gbRptType.Size = New System.Drawing.Size(362, 71)
        Me.gbRptType.TabIndex = 2
        Me.gbRptType.TabStop = False
        Me.gbRptType.Text = "Report Type"
        '
        'cboUsr
        '
        Me.cboUsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsr.Enabled = False
        Me.cboUsr.FormattingEnabled = True
        Me.cboUsr.Location = New System.Drawing.Point(222, 44)
        Me.cboUsr.Name = "cboUsr"
        Me.cboUsr.Size = New System.Drawing.Size(121, 21)
        Me.cboUsr.TabIndex = 4
        '
        'rdoUser
        '
        Me.rdoUser.AutoSize = True
        Me.rdoUser.Location = New System.Drawing.Point(128, 45)
        Me.rdoUser.Name = "rdoUser"
        Me.rdoUser.Size = New System.Drawing.Size(74, 17)
        Me.rdoUser.TabIndex = 3
        Me.rdoUser.TabStop = True
        Me.rdoUser.Text = "User Wise"
        Me.rdoUser.UseVisualStyleBackColor = True
        '
        'rdoItem
        '
        Me.rdoItem.AutoSize = True
        Me.rdoItem.Location = New System.Drawing.Point(128, 21)
        Me.rdoItem.Name = "rdoItem"
        Me.rdoItem.Size = New System.Drawing.Size(72, 17)
        Me.rdoItem.TabIndex = 2
        Me.rdoItem.TabStop = True
        Me.rdoItem.Text = "Item Wise"
        Me.rdoItem.UseVisualStyleBackColor = True
        '
        'rdoExp
        '
        Me.rdoExp.AutoSize = True
        Me.rdoExp.Location = New System.Drawing.Point(19, 45)
        Me.rdoExp.Name = "rdoExp"
        Me.rdoExp.Size = New System.Drawing.Size(94, 17)
        Me.rdoExp.TabIndex = 1
        Me.rdoExp.TabStop = True
        Me.rdoExp.Text = "Expence Wise"
        Me.rdoExp.UseVisualStyleBackColor = True
        '
        'rdoDay
        '
        Me.rdoDay.AutoSize = True
        Me.rdoDay.Location = New System.Drawing.Point(19, 19)
        Me.rdoDay.Name = "rdoDay"
        Me.rdoDay.Size = New System.Drawing.Size(71, 17)
        Me.rdoDay.TabIndex = 0
        Me.rdoDay.TabStop = True
        Me.rdoDay.Text = "Day Wise"
        Me.rdoDay.UseVisualStyleBackColor = True
        '
        'frmRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Daybook.My.Resources.Resources.box_item
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 211)
        Me.Controls.Add(Me.gbRptType)
        Me.Controls.Add(Me.gbCri)
        Me.Controls.Add(Me.crvView)
        Me.Name = "frmRep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbCri.ResumeLayout(False)
        Me.gbCri.PerformLayout()
        Me.gbRptType.ResumeLayout(False)
        Me.gbRptType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents gbCri As System.Windows.Forms.GroupBox
    Friend WithEvents gbRptType As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShowRpt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoItem As System.Windows.Forms.RadioButton
    Friend WithEvents rdoExp As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDay As System.Windows.Forms.RadioButton
    Friend WithEvents cboUsr As System.Windows.Forms.ComboBox
    Friend WithEvents rdoUser As System.Windows.Forms.RadioButton
End Class
