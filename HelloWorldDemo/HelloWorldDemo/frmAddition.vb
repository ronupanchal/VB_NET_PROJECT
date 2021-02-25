Public Class frmAddition


    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim a As Integer = txtV1.Text
        lblAnswer.Text = a + Val(txtV2.Text)

        MsgBox("Output : " & lblAnswer.Text)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        lblAnswer.Text = Val(txtV1.Text) - Val(txtV2.Text)
    End Sub

    Private Sub btnMulty_Click(sender As Object, e As EventArgs) Handles btnMulty.Click
        lblAnswer.Text = Val(txtV1.Text) * Val(txtV2.Text)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        lblAnswer.Text = Val(txtV1.Text) / Val(txtV2.Text)
    End Sub
End Class