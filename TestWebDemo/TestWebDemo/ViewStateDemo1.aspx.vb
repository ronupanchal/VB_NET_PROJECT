Public Class ViewStateDemo1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim Counter As Integer
        If ViewState("Counter") Is Nothing Then
            Counter = 1
        Else
            Counter = CType(ViewState("Counter"), Integer) + 1
        End If
        ViewState("Counter") = Counter
        Label1.Text = "Counter : " & Counter.ToString()
    End Sub
End Class