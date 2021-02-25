Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text Mod 2 = 0 Then
            Label1.Text = "No is Even"
        Else
            Label1.Text = "No is ODD"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New DateTimePickerDemo
        f.Show()
    End Sub
End Class