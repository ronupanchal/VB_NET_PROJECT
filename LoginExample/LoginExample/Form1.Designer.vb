<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlLoginForm = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboThms = New System.Windows.Forms.ComboBox
        Me.picCancel = New System.Windows.Forms.PictureBox
        Me.picLogin = New System.Windows.Forms.PictureBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.pnlLoginForm.SuspendLayout()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.pnlLoginForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 432)
        Me.Panel1.TabIndex = 0
        '
        'pnlLoginForm
        '
        Me.pnlLoginForm.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoginForm.BackgroundImage = Global.LoginExample.My.Resources.Resources.Bg002
        Me.pnlLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLoginForm.Controls.Add(Me.Label3)
        Me.pnlLoginForm.Controls.Add(Me.cboThms)
        Me.pnlLoginForm.Controls.Add(Me.picCancel)
        Me.pnlLoginForm.Controls.Add(Me.picLogin)
        Me.pnlLoginForm.Controls.Add(Me.TextBox2)
        Me.pnlLoginForm.Controls.Add(Me.Label2)
        Me.pnlLoginForm.Controls.Add(Me.TextBox1)
        Me.pnlLoginForm.Controls.Add(Me.Label1)
        Me.pnlLoginForm.Location = New System.Drawing.Point(12, 3)
        Me.pnlLoginForm.Name = "pnlLoginForm"
        Me.pnlLoginForm.Size = New System.Drawing.Size(573, 414)
        Me.pnlLoginForm.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(77, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Themes"
        '
        'cboThms
        '
        Me.cboThms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThms.FormattingEnabled = True
        Me.cboThms.Items.AddRange(New Object() {"Group", "Single", "Comman"})
        Me.cboThms.Location = New System.Drawing.Point(81, 321)
        Me.cboThms.Name = "cboThms"
        Me.cboThms.Size = New System.Drawing.Size(151, 21)
        Me.cboThms.TabIndex = 6
        '
        'picCancel
        '
        Me.picCancel.BackgroundImage = Global.LoginExample.My.Resources.Resources.Cancel
        Me.picCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCancel.Location = New System.Drawing.Point(389, 309)
        Me.picCancel.Name = "picCancel"
        Me.picCancel.Size = New System.Drawing.Size(134, 48)
        Me.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCancel.TabIndex = 5
        Me.picCancel.TabStop = False
        '
        'picLogin
        '
        Me.picLogin.BackgroundImage = Global.LoginExample.My.Resources.Resources.Login
        Me.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogin.Location = New System.Drawing.Point(238, 309)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(134, 48)
        Me.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogin.TabIndex = 4
        Me.picLogin.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.TextBox2.Location = New System.Drawing.Point(257, 265)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(246, 26)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(253, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.Location = New System.Drawing.Point(257, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(253, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 432)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Gainsboro
        Me.Panel1.ResumeLayout(False)
        Me.pnlLoginForm.ResumeLayout(False)
        Me.pnlLoginForm.PerformLayout()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlLoginForm As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents picLogin As System.Windows.Forms.PictureBox
    Friend WithEvents picCancel As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboThms As System.Windows.Forms.ComboBox

End Class
