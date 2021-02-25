Public Class test
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = "Welcome, " & CType(Session("userid"), String)
    End Sub

End Class