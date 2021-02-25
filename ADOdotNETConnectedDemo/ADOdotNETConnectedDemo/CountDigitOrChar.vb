Public Class CountDigitOrChar

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        Dim i, cntd, tot, cnts As Integer
        Dim str As String = txtInput.Text
        Dim ch As Char
        For i = 0 To Len(str) - 1
            ch = str.Substring(i, 1)
            If Char.IsDigit(ch) = True Then
                cntd = cntd + 1
                tot = tot + Val(ch)
            ElseIf Char.IsLetter(ch) = True Then
                cnts = cnts + 1
            End If

        Next
        
        MessageBox.Show("Digit = " & cntd & "character = " & cnts & " Digit totol is : " & tot)
    End Sub
End Class