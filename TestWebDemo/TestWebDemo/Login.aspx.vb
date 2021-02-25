Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text.Trim() = "omsai" And txtPassword.Text.Trim() = "sai123" Then
            LblStatus.Text = "<font color='red' size=3>Login successfully</font>"

            Response.Redirect("Welcome.aspx")
        Else
            LblStatus.Text = "<font color='red' size=3>Login Not successfully</font>"

        End If

    End Sub
End Class