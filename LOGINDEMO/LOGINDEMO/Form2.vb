Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Select Case ComboBox1.Text
            Case "+"
                Label3.Text = "My Result : " & CInt(TextBox1.Text) + CInt(TextBox2.Text)
            Case "-"
                Label3.Text = "My Result : " & CInt(TextBox1.Text) - CInt(TextBox2.Text)
            Case "*"
                Label3.Text = "My Result : " & CInt(TextBox1.Text) * CInt(TextBox2.Text)
            Case "/"
                Label3.Text = "My Result : " & CInt(TextBox1.Text) / CInt(TextBox2.Text)
            Case Else
                Label3.Text = "Invalid"
        End Select




    End Sub
End Class