Public Class Form3

    Private Sub PrimeNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimeNoToolStripMenuItem.Click
       

    End Sub

    Private Sub OddEvenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OddEvenToolStripMenuItem.Click
        If TextBox1.Text Mod 2 = 0 Then
            MsgBox("no is even")
        Else

            MsgBox("no is odd")
        End If
    End Sub
End Class