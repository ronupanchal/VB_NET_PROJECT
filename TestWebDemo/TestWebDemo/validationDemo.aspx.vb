Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Sub Length_Check(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Dim len As Integer = e.Value.Length
        If len = 10 Then
            e.IsValid = True
        Else
            e.IsValid = False
        End If
    End Sub

    Protected Sub txtEmail_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

    End Sub
End Class