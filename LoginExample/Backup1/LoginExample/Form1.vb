Public Class Form1

    Private Sub picLogin_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLogin.MouseDown
        picLogin.BackgroundImage = My.Resources.Login1
    End Sub

    Private Sub picLogin_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLogin.MouseUp
        picLogin.BackgroundImage = My.Resources.Login
    End Sub
    
    Private Sub picCancel_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCancel.MouseUp
        picCancel.BackgroundImage = My.Resources.Cancel
    End Sub

    Private Sub picCancel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCancel.MouseDown
        picCancel.BackgroundImage = My.Resources.Cancel1
    End Sub

    Private Sub picCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.Click
        Me.Close()
    End Sub

    Private Sub cboThms_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboThms.SelectedValueChanged
        Select Case cboThms.Text

        End Select
    End Sub

    Private Sub cboThms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboThms.SelectedIndexChanged
        Select Case cboThms.Text
            Case "Group"
                pnlLoginForm.BackgroundImage = My.Resources.Bg003
            Case "Single"
                pnlLoginForm.BackgroundImage = My.Resources.Bg004
            Case "Comman"
                pnlLoginForm.BackgroundImage = My.Resources.Bg002
            Case Else
                pnlLoginForm.BackgroundImage = My.Resources.Bg004
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboThms.SelectedIndex = 0
    End Sub

    Private Sub picLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogin.Click

    End Sub
End Class
