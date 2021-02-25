Public Class WebForm18
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack = False Then
            Dim p1 As New Furniture("Royal Sofa", "Best Funiture", 2000)
            Dim p2 As New Furniture("Pioneer Table", "Sisodrawala", 3500)
            Dim p3 As New Furniture("Dressing Wall", "Green Funiture", 4000)

            Session("F1") = p1
            Session("F2") = p2
            Session("F3") = p3

            ListBox1.Items.Add(p1.Name)
            ListBox1.Items.Add(p2.Name)
            ListBox1.Items.Add(p3.Name)

            'Display 
            Label1.Text = "Session ID : " & Session.SessionID
            Label1.Text &= "<br />Number of Object : " & Session.Count.ToString()
            Label1.Text &= "<br />Mode : " & Session.Mode.ToString()
            Label1.Text &= "<br />Is Cookieless : " & Session.IsCookieless.ToString()
            Label1.Text &= "<br />Is New : " & Session.IsNewSession.ToString()
            Label1.Text &= "<br />Time out (minutes): " & Session.Timeout.ToString()

        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            Label2.Text = "No item Selected"
        Else
            Dim key As String
            key = "F" & (ListBox1.SelectedIndex + 1).ToString()
            Dim pf As Furniture = CType(Session(key), Furniture)
            Label2.Text = "<br />Name : " & pf.Name
            Label2.Text &= "<br />Manufacturer : " & pf.Description
            Label2.Text &= "<br />Cost : " & pf.Cost.ToString("c")

        End If
    End Sub
End Class