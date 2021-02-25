Public Class WebForm10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim plist As New ArrayList

        Dim p1 As New ProdEntity
        p1.PID = 101
        p1.PName = "Modem"
        p1.Price = 300
        p1.Qty = 3
        p1.Pics = "~\\Images\\it-consultant.jpg"
        plist.Add(p1)

        Dim p2 As New ProdEntity
        p2.PID = 102
        p2.PName = "CPU"
        p2.Price = 400
        p2.Qty = 2
        p2.Pics = "~\\Images\\1.jpg"
        plist.Add(p2)

        DataList1.DataSource = plist
        DataList1.DataBind()

    End Sub
End Class