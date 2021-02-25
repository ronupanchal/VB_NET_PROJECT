Public Class WebForm9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim appPath As String = Request.PhysicalApplicationPath
        If FileUpload1.HasFile Then

            Dim strextensionName1 As String = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower()
            If String.Compare(strextensionName1, ".jpg") = 0 Then
                Dim savePath As String = appPath + "\UploadFile\" + Server.HtmlEncode(FileUpload1.FileName)
                FileUpload1.SaveAs(savePath)
                Image1.ImageUrl = "~\\UploadFile\\" + FileUpload1.FileName
                lblStatus.Text = FileUpload1.FileName + " File is Uploaded Success fully with size is " + FileUpload1.PostedFile.ContentLength.ToString() + "KB"
            Else
                lblStatus.Text = "please select jpg file only"
            End If

        Else
            lblStatus.Text = "File is not Upload Success fully"
        End If
    End Sub
End Class