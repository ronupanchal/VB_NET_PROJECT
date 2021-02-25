Public Class ListboxDemo
    Inherits System.Web.UI.Page

    Protected Sub btnDisp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisp.Click
        Dim ct, fr, hb, cs As String
        ct = lstCountries.SelectedItem.Text
        fr = ddlFruits.SelectedItem.Text
        For Each lstitm As ListItem In cblHobbies.Items

            If lstitm.Selected = True Then
                hb = hb + lstitm.Text
                hb = hb + ""
            End If
        Next
        cs = rblCourse.SelectedItem.Text
        MsgBox("Your Selected County : " + ct + vbCrLf + "Fruit" + fr + vbCrLf + "Hobbies :" + hb + vbCrLf + "Course : " + cs, MsgBoxStyle.Information, "info")
    End Sub

End Class