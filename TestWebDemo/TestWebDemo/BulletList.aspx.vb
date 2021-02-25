Public Class BulletList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged



        If CheckBox1.Checked = True Then

            TextBox1.TextMode = TextBoxMode.SingleLine
            ViewState("pw") = TextBox1.Text
        Else
            TextBox1.Text = Convert.ToString(ViewState("pw"))
            TextBox1.TextMode = TextBoxMode.Password
        End If
    End Sub
End Class