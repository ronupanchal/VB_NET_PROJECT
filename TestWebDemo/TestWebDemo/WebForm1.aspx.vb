Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Btnlogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btnlogin.Click
        txtans.Text = Txtfname.Text & " " & Txtlname.Text


    End Sub
End Class