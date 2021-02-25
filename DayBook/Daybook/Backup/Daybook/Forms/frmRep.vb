
Public Class frmRep
    Dim dfrom As Date
    Dim dto As Date
    Private Sub frmRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Reports for User " & UserId
        dtpFrom.Value = Now
        dtpTo.Value = Now
        LoadUserList()
    End Sub

    Private Sub btnShowRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRpt.Click
        dfrom = dtpFrom.Value
        dto = dtpTo.Value
        If rdoDay.Checked Then
            Dim r As DayWise
            r = New Daybook.DayWise
            Me.crvView.SelectionFormula = "{DayMast.TrDt} >= #" & mk_dt_fmt(dfrom) & "# and {DayMast.TrDt} <= #" & mk_dt_fmt(dto) & "#"
            Me.crvView.ReportSource = r
            Me.crvView.Refresh()
        ElseIf rdoExp.Checked Then
            Dim r As ExpenceWise
            r = New Daybook.ExpenceWise
            Me.crvView.ReportSource = r
            Me.crvView.SelectionFormula = "{DayMast.TrDt} >= #" & mk_dt_fmt(dfrom) & "# and {DayMast.TrDt} <= #" & mk_dt_fmt(dto) & "#"
            Me.crvView.Refresh()
        ElseIf rdoItem.Checked Then
            Dim r As ItemWise
            r = New Daybook.ItemWise
            Me.crvView.ReportSource = r
            ''Me.crvView.SelectionFormula = "TrDt>=#" & dfrom & "# and TrDt <= #" & dto & "#"
            Me.crvView.SelectionFormula = "{DayMast.TrDt} >= #" & mk_dt_fmt(dfrom) & "# and {DayMast.TrDt} <= #" & mk_dt_fmt(dto) & "#"
            Me.crvView.Refresh()
        ElseIf rdoUser.Checked Then
            ''MsgBox(cboUsr.Text)
            Dim r As UserWise
            r = New Daybook.UserWise
            Me.crvView.ReportSource = r
            Me.crvView.SelectionFormula = "{DayMast.CrBy} = '" & cboUsr.Text & "' and ( {DayMast.TrDt} >= #" & mk_dt_fmt(dfrom) & "# and {DayMast.TrDt} <= #" & mk_dt_fmt(dto) & "#)"
            Me.crvView.Refresh()
        End If
    End Sub
    Public Sub LoadUserList()
        Dim i As Integer
        i = 0
        cboUsr.Items.Clear()
        If conn.State = 1 Then conn.Close()
        conn.Open()
        cmd.CommandText = "select UserName from LogMast"
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        While i <= dt.Rows.Count - 1
            cboUsr.Items.Add(dt.Rows(i).Item("UserName").ToString)
            i = i + 1
        End While
    End Sub

    Private Sub rdoUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUser.CheckedChanged
        If rdoUser.Checked Then
            cboUsr.Enabled = True
        Else
            cboUsr.Enabled = False
        End If
    End Sub
End Class