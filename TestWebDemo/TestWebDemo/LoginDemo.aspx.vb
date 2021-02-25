Public Class LoginDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Login1_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Login1.Authenticate
        If Login1.UserName = "Ronny" And Login1.Password = "panchal" Then
            'e.Authenticated = True
            Session("userid") = Login1.UserName

            Response.Redirect("Home.aspx")
        Else
            ' Login1. Login1.FailureText
        End If
    End Sub
End Class