Imports System.Data.SqlClient

Public Class WebForm22
    Inherits System.Web.UI.Page
    Dim cnstring As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Dim cn As New SqlConnection(cnstring)
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        da = New SqlDataAdapter("Select * from std_mst", cn)

        da.Fill(ds, "std_mst")
        
        GridView1.DataSource = ds
        GridView1.DataBind()



    End Sub

End Class