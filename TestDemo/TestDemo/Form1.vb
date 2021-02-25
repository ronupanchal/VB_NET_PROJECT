Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Try
        If txtUserName.Text = "ronak" And txtPassword.Text = "panchal" Then
            MessageBox.Show("Login Successfull...")
            'Welcome.Show()
            Shell(My.Application.Info.DirectoryPath + "\calc.exe")
            Me.Hide()

        Else
            MessageBox.Show("Invalid User Name and Password...")
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' End Try



    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
