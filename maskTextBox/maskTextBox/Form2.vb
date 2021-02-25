Public Class Form2

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        NotifyIcon1.ShowBalloonTip(2000)
    End Sub
End Class