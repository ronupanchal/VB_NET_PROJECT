<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountDigitOrChar
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(22, 51)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(37, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input :"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(89, 51)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(89, 99)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(100, 23)
        Me.btnCount.TabIndex = 2
        Me.btnCount.Text = "CLick Me!!!"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'CountDigitOrChar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 149)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "CountDigitOrChar"
        Me.Text = "CountDigitOrChar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCount As System.Windows.Forms.Button
End Class
