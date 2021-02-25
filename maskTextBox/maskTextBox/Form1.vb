Public Class Form1

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripContainer1.TopToolStripPanel.Click

    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        NotifyIcon1.ShowBalloonTip(2000)

    End Sub
End Class
