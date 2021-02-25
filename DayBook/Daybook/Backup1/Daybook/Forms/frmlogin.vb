Public Class frmlogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please give Proper UserName and Password", "Error")
            Exit Sub
        ElseIf ChkLog(UsernameTextBox.Text, PasswordTextBox.Text) Then
            UserId = UsernameTextBox.Text
            Me.Hide()
            'Me.Close()
            frmMain.Show()
        Else
            MessageBox.Show("Please give Proper UserName and Password", "Error")
            Exit Sub
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Function ChkLog(ByVal usr As String, ByVal Pwd As String) As Boolean
        Dim b As Boolean
        b = False
        If conn.State = 1 Then conn.Close()
        conn.Open()
        Dim qry As String
        qry = "select * from LogMast where UserName = '" & usr & "' and Passwrd = '" & Pwd & "'"
        cmd.CommandText = qry
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        If dt.Rows.Count > 0 Then
            b = True
        Else
            b = False
        End If
        Return b
    End Function
End Class
