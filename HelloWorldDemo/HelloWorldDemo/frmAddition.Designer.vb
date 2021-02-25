<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddition
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
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtV1 = New System.Windows.Forms.TextBox()
        Me.txtV2 = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMulty = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.lblv1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlus.Location = New System.Drawing.Point(97, 132)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(56, 60)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'txtV1
        '
        Me.txtV1.Location = New System.Drawing.Point(253, 41)
        Me.txtV1.Name = "txtV1"
        Me.txtV1.Size = New System.Drawing.Size(137, 27)
        Me.txtV1.TabIndex = 1
        '
        'txtV2
        '
        Me.txtV2.Location = New System.Drawing.Point(253, 92)
        Me.txtV2.Name = "txtV2"
        Me.txtV2.Size = New System.Drawing.Size(137, 27)
        Me.txtV2.TabIndex = 2
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMinus.Location = New System.Drawing.Point(175, 132)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(56, 60)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMulty
        '
        Me.btnMulty.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMulty.Location = New System.Drawing.Point(255, 132)
        Me.btnMulty.Name = "btnMulty"
        Me.btnMulty.Size = New System.Drawing.Size(56, 60)
        Me.btnMulty.TabIndex = 4
        Me.btnMulty.Text = "*"
        Me.btnMulty.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDivision.Location = New System.Drawing.Point(336, 132)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(56, 60)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'lblv1
        '
        Me.lblv1.AutoSize = True
        Me.lblv1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblv1.ForeColor = System.Drawing.Color.Blue
        Me.lblv1.Location = New System.Drawing.Point(88, 35)
        Me.lblv1.Name = "lblv1"
        Me.lblv1.Size = New System.Drawing.Size(159, 32)
        Me.lblv1.TabIndex = 6
        Me.lblv1.Text = "Enter Value1 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(88, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter Value2 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(106, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Result : "
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAnswer.ForeColor = System.Drawing.Color.Blue
        Me.lblAnswer.Location = New System.Drawing.Point(209, 223)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 32)
        Me.lblAnswer.TabIndex = 9
        '
        'frmAddition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 308)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblv1)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMulty)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.txtV2)
        Me.Controls.Add(Me.txtV1)
        Me.Controls.Add(Me.btnPlus)
        Me.Name = "frmAddition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlus As Button
    Friend WithEvents txtV1 As TextBox
    Friend WithEvents txtV2 As TextBox
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMulty As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents lblv1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAnswer As Label
End Class
