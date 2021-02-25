Public Class WebForm13
    Inherits System.Web.UI.Page

    Private c As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack Then
            c = CType(ViewState("Text"), String)
        End If
    End Sub


    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        ViewState("Text") = c
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        c &= TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        TextBox1.Text = c
    End Sub
End Class