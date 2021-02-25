Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Label1.Text = Nothing
        Label1.Text &= txtName.Text & " " & TextBox1.Text
        MessageBox.Show(Label1.Text)
    End Sub
End Class
