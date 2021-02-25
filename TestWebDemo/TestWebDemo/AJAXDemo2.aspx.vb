Public Class AJAXDemo2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        System.Threading.Thread.Sleep(7000)
        lblGreeting.Text = "WELCOME ,...." & TextBox1.Text
    End Sub
End Class