Public Class Welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Panel1.Visible = False

    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles submit.Click
        Panel1.Visible = True
        Label12.Text = txtfname.Text
        lbl19.Text = txtmname.Text
        lbl20.Text = txtlname.Text


        Label15.Text = RadioButtonList1.SelectedItem.Text


        Label18.Text = DropDownList1.Text

    End Sub
End Class