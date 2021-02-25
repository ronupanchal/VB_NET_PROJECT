Public Class WebForm15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim prevPage As WebForm14
        'prevPage = TryCast(PreviousPage, WebForm14)
        If PreviousPage IsNot Nothing Then
            Label1.Text = "You came from  a page title " & PreviousPage.Title & "<br /> Full Name : " & PreviousPage.FullName


        End If
    End Sub

End Class