Public Class frmMain
    Dim SelId As Integer
    Dim fn As String
    Dim oFile As System.IO.File
    Dim oFs As System.IO.FileStream
    Dim oRead As System.IO.StreamReader
    Dim oWrite As System.IO.StreamWriter


    Private Sub NewDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDayToolStripMenuItem.Click

        dtpAdDt.Value = Now.Date
        rtxtRemark.Text = ""
        txtAdDyAmt.Text = ""

        If Not gbAddNewDay.Visible Then gbAddNewDay.Visible = True
        If Not gbAddNewDay.Enabled Then gbAddNewDay.Enabled = True

        gbAddNewExp.Visible = False
        gbEditDay.Visible = False
        gbEdEx.Visible = False

        gbAddNewExp.Enabled = False
        gbEditDay.Enabled = False
        gbEdEx.Enabled = False

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        rtxtNote.Text = ""
        fn = ""
        rtxtNote.Focus()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Wellcome User " & UserId
        gbAddNewDay.Visible = False
        gbAddNewExp.Visible = False
        gbEditDay.Visible = False
        gbEdEx.Visible = False

        gbAddNewDay.Enabled = False
        gbAddNewExp.Enabled = False
        gbEditDay.Enabled = False
        gbEdEx.Enabled = False

        frmlogin.Close()

    End Sub
    Private Sub GetAllExpData()
        Dim i As Integer
        i = 0
        cboExpList.Items.Clear()
        If conn.State = 1 Then conn.Close()
        conn.Open()
        cmd.CommandText = "select Expense from ExpMaster"
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        While i <= dt.Rows.Count - 1
            cboExpList.Items.Add(dt.Rows(i).Item("Expense").ToString)
            i = i + 1
        End While
    End Sub '' Getting all the expense in combobox

    Private Sub cboExpList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboExpList.Click
        '     lblExpid.Text = "Expense  : " & cboExpList.SelectedText
    End Sub

    Private Sub cboExpList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboExpList.KeyDown
        If (e.KeyValue = 38 Or e.KeyValue = 40 Or e.KeyValue = 13) Then
            lblExpid.Text = "Expense  : " & cboExpList.SelectedText
        End If
    End Sub
    Private Sub cboExpList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboExpList.KeyUp
        If (e.KeyValue = 38 Or e.KeyValue = 40 Or e.KeyValue = 13) Then
            lblExpid.Text = "Expense  : " & cboExpList.SelectedText
        End If
    End Sub

    Private Sub btnAdDyNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdDyNew.Click
        If gbAdDyDtls.Enabled = False Then gbAdDyDtls.Enabled = True

        GetAllExpData()

        btnAdDyNew.Enabled = False
        btnAdDyCancel.Enabled = True
        btnAdDySave.Enabled = True
    End Sub

    Private Sub btnAdDyCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdDyCancel.Click
        btnAdDyCancel.Enabled = False
        txtAdDyAmt.Text = ""
        btnAdDySave.Enabled = False
        btnAdDyNew.Enabled = True
        gbAdDyDtls.Enabled = False
    End Sub

    Private Sub btnAdDySave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdDySave.Click
        If txtAdDyAmt.Text = "" Or cboExpList.Text = "" Or cboPayMode.Text = "" Then
            MessageBox.Show("Please, Select Proper Expense or Pay mode or invalid Amount", "not good Values")
        Else
            If conn.State = 1 Then conn.Close()
            conn.Open()
            cmd.CommandText = "insert into DayMast(Expense,PMode,Amount,TrDt,Remark,CrBy) values('" & cboExpList.Text & "','" & cboPayMode.Text & _
                              "'," & Val(txtAdDyAmt.Text) & ",'" & mk_dt_fmt(dtpAdDt.Value) & "','" + rtxtRemark.Text + "','" + UserId + "')"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Entry Inserted", MsgBoxStyle.Information, "Success")
            btnAdDySave.Enabled = False
            btnAdDyCancel.Enabled = False
            btnAdDyNew.Enabled = True
            gbAdDyDtls.Enabled = False
        End If
    End Sub

    Private Sub cboExpList_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboExpList.LostFocus
        lblExpid.Text = cboExpList.Text
    End Sub

    Private Sub cboPayMode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPayMode.LostFocus
        lblPaymode.Text = cboPayMode.Text
    End Sub

    Private Sub txtAdDyAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdDyAmt.TextChanged
        lblRs.Text = Val(txtAdDyAmt.Text) & " Rupees"
    End Sub

    Private Sub DayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayToolStripMenuItem.Click

        If Not gbEditDay.Visible Then gbEditDay.Visible = True
        If Not gbEditDay.Enabled Then gbEditDay.Enabled = True

        gbAddNewDay.Visible = False
        gbAddNewExp.Visible = False
        gbEdEx.Visible = False

        gbAddNewDay.Enabled = False
        gbAddNewExp.Enabled = False
        gbEdEx.Enabled = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim i As Integer
        i = 0
        dtpEdDt.Value = Now.Date
        cboEdExpList.Items.Clear()
        If conn.State = 1 Then conn.Close()
        conn.Open()
        cmd.CommandText = "select Expense from ExpMaster"
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        While i <= dt.Rows.Count - 1
            cboEdExpList.Items.Add(dt.Rows(i).Item("Expense").ToString)
            i = i + 1
        End While
        cboEdExpList.Items.Add("")

        cboEdPyMd.Items.Clear()
        cboEdPyMd.Items.Add("")
        cboEdPyMd.Items.Add("Cash")
        cboEdPyMd.Items.Add("Chq")
        cboEdPyMd.Items.Add("Credit card")

        txtEdAmt.Text = ""
        cboEdExpList.Text = ""
        cboEdPyMd.Text = ""
        rtxtEdRemark.Text = ""

        If Not gbEdDyDtls.Enabled Then gbEdDyDtls.Enabled = True
        If Not btnUpdate.Enabled Then btnUpdate.Enabled = True
        If Not btnEdCancel.Enabled Then btnEdCancel.Enabled = True
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim i As Integer
        i = 0
        If conn.State = 1 Then conn.Close()
        lstEdDtLst.Items.Clear()
        txtEdAmt.Text = ""
        cboEdExpList.Text = ""
        cboEdPyMd.Text = ""
        conn.Open()
        cmd.CommandText = "select TrID from DayMast where TrDt = #" & mk_dt_fmt(dtpEdDt.Value) & "#"
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        While i <= dt.Rows.Count - 1
            lstEdDtLst.Items.Add(dt.Rows(i).Item("TrID").ToString)
            i = i + 1
        End While

        txtEdAmt.Text = ""
        cboEdExpList.Text = ""
        cboEdPyMd.Text = ""
        rtxtEdRemark.Text = ""
    End Sub

    Private Sub lstEdDtLst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEdDtLst.SelectedIndexChanged
        If conn.State = 1 Then conn.Close()
        conn.Open()
        cmd.CommandText = "select Expense,PMode,Amount,Remark from DayMast where TrID =" & Val(lstEdDtLst.SelectedItem.ToString)
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        cboEdExpList.Text = dt.Rows(0).Item("Expense")
        cboEdPyMd.Text = dt.Rows(0).Item("PMode")
        txtEdAmt.Text = dt.Rows(0).Item("Amount")
        rtxtEdRemark.Text = dt.Rows(0).Item("Remark")
    End Sub

    Private Sub btnEdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdCancel.Click
        gbEdDyDtls.Enabled = False

        btnUpdate.Enabled = False
        btnEdCancel.Enabled = False
        btnEdit.Enabled = True
        rtxtEdRemark.Text = ""
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cboEdExpList.Text.Equals("") = False And cboEdPyMd.Text.Equals("") = False Or txtEdAmt.Text.Equals("") = False Then
            If MsgBox("ID :" & lstEdDtLst.SelectedItem.ToString & Chr(13) & _
            "Trans Date :" & mk_dt_fmt(dtpEdDt.Value) & Chr(13) & "Expense : " & cboEdExpList.Text & _
            Chr(13) & "Pay Mode :" & cboEdPyMd.Text & Chr(13) & "Amount :" & txtEdAmt.Text & _
            Chr(13) & "Remark : " & rtxtEdRemark.Text & Chr(13) & "Do you Want to Update ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Allow Updation") = MsgBoxResult.Yes Then
                If conn.State = 1 Then conn.Close()
                conn.Open()
                Dim qry As String
                qry = "update DayMast set Expense = '" & cboEdExpList.Text & "',PMode='" & cboEdPyMd.Text & "',Amount=" & _
                                                    Val(txtEdAmt.Text) & ", TrDt= #" & mk_dt_fmt(dtpEdDt.Value) & _
                                                    "#,Remark='" & rtxtEdRemark.Text & "',CrBy='" & UserId & _
                                                    "' where TrID = " & Val(lstEdDtLst.SelectedItem.ToString)
                cmd.CommandText = qry
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Entry Updated", MsgBoxStyle.Information, "Success")
            End If
        Else
            MessageBox.Show("Please, Select Proper Expense or Pay mode or invalid Amount", "not good Values to update")
        End If
    End Sub

    Private Sub TotalDayExpenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDayExpenceToolStripMenuItem.Click
        Dim r As DayWise
        r = New Daybook.DayWise
        r.SetDatabaseLogon("", "", "", ConStr)
        frmRep.crvView.ReportSource = r
        frmRep.Show()
    End Sub

    Private Sub ExcepnseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcepnseToolStripMenuItem.Click

        If Not gbAddNewExp.Visible Then gbAddNewExp.Visible = True
        If Not gbAddNewExp.Enabled Then gbAddNewExp.Enabled = True

        gbAddNewDay.Visible = False
        gbEditDay.Visible = False
        gbEdEx.Visible = False

        gbAddNewDay.Enabled = False
        gbEditDay.Enabled = False
        gbEdEx.Enabled = False
    End Sub

    Private Sub ExpenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenceToolStripMenuItem.Click

        If Not gbEdEx.Visible Then gbEdEx.Visible = True
        If Not gbEdEx.Enabled Then gbEdEx.Enabled = True

        FillExpNames()

        gbAddNewDay.Visible = False
        gbEditDay.Visible = False
        gbAddNewExp.Visible = False

        gbAddNewDay.Enabled = False
        gbEditDay.Enabled = False
        gbAddNewExp.Enabled = False

        btnEdDelEx.Enabled = False
        btnEdCnlEx.Enabled = False

        gbEditExDtls.Enabled = False

    End Sub

    Private Sub btnAddNewEx_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNewEx.Click
        If Not gbAddExDtls.Enabled Then gbAddExDtls.Enabled = True

        txtAdExNm.Text = ""
        rtxtAdExDesc.Text = ""

        btnAddNewEx.Enabled = False
        btnAddSavEx.Enabled = True
        btnAddCnlEx.Enabled = True

    End Sub

    Private Sub btnAddCnlEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCnlEx.Click

        txtAdExNm.Text = ""
        rtxtAdExDesc.Text = ""

        If gbAddExDtls.Enabled Then gbAddExDtls.Enabled = False

        btnAddNewEx.Enabled = True
        btnAddSavEx.Enabled = False
        btnAddCnlEx.Enabled = False
        
    End Sub

    Private Sub btnAddSavEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSavEx.Click
        If txtAdExNm.Text.Equals("") Then
            MsgBox("Please, Give Proper Expense Name and Details", MsgBoxStyle.Information, "Invalid Expense Name")
        Else
            If conn.State = 1 Then conn.Close()
            conn.Open()
            cmd.CommandText = "insert into ExpMaster(Expense,Details) values('" & txtAdExNm.Text & "','" & rtxtAdExDesc.Text + "')"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Entry Inserted", MsgBoxStyle.Information, "Success")

            txtAdExNm.Text = ""
            rtxtAdExDesc.Text = ""

            If gbAddExDtls.Enabled Then gbAddExDtls.Enabled = False

            btnAddNewEx.Enabled = True
            btnAddSavEx.Enabled = False
            btnAddCnlEx.Enabled = False
        End If
    End Sub
    Private Sub FillExpNames()
        Dim i As Integer
        i = 0
        lstExpNm.Items.Clear()
        If conn.State = 1 Then conn.Close()
        conn.Open()
        cmd.CommandText = "select Expense from ExpMaster"
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        While i <= dt.Rows.Count - 1
            lstExpNm.Items.Add(dt.Rows(i).Item("Expense").ToString)
            i = i + 1
        End While
    End Sub

    Private Sub btnEdExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdExp.Click
        If btnEdExp.Text = "Edit" Then
            btnEdExp.Text = "Modify"

            btnEdDelEx.Enabled = True
            btnEdCnlEx.Enabled = True

            gbEditExDtls.Enabled = True

        Else

            If txtEdExNm.Text.Equals("") Then
                MsgBox("Please, Select Proper Expence Name", MsgBoxStyle.Critical, "Invalid Expense Selection")
            Else
                If conn.State = 1 Then conn.Close()
                conn.Open()
                Dim qry As String
                qry = "update ExpMaster set Details = '" & rtxtEdExDesc.Text & "' where  Expense= '" & txtEdExNm.Text & "'"
                cmd.CommandText = qry
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
                conn.Close()

                MsgBox("Entry Updated", MsgBoxStyle.Information, "Success")

                btnEdExp.Text = "Edit"
                btnEdDelEx.Enabled = False
                btnEdCnlEx.Enabled = False

                gbEditExDtls.Enabled = False

            End If
        End If
    End Sub

    Private Sub lstExpNm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstExpNm.SelectedIndexChanged
        If conn.State = 1 Then conn.Close()
        conn.Open()
        cmd.CommandText = "select * from ExpMaster where Expense ='" & lstExpNm.SelectedItem.ToString & "'"
        cmd.Connection = conn
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        dt = ds.Tables(0)
        conn.Close()
        txtEdExNm.Text = dt.Rows(0).Item("Expense")
        rtxtEdExDesc.Text = dt.Rows(0).Item("Details")
    End Sub

    Private Sub btnEdCnlEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdCnlEx.Click
        txtEdExNm.Text = ""
        rtxtEdExDesc.Text = ""

        gbEditExDtls.Enabled = False

        btnEdExp.Text = "Edit"
        btnEdDelEx.Enabled = False
        btnEdCnlEx.Enabled = False

    End Sub

    Private Sub btnEdDelEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdDelEx.Click
        If txtEdExNm.Text.Equals("") Then
            MsgBox("Please, Select Proper Expence Name", MsgBoxStyle.Critical, "Invalid Expense Selection")
        Else
            If (MsgBox("Expense : " & txtEdExNm.Text & Chr(13) & "Details :" & rtxtEdExDesc.Text & _
            Chr(13) & "Do u want to Delete ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Attention") = MsgBoxResult.No) Then Exit Sub
            If conn.State = 1 Then conn.Close()
            conn.Open()
            Dim qry As String
            qry = "delete from ExpMaster where  Expense= '" & txtEdExNm.Text & "'"
            cmd.CommandText = qry
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Entry Deleted", MsgBoxStyle.Information, "Success")

            btnEdExp.Text = "Edit"
            btnEdDelEx.Enabled = False
            btnEdCnlEx.Enabled = False

            txtEdExNm.Text = ""
            rtxtEdExDesc.Text = ""

            gbEditExDtls.Enabled = False

        End If
    End Sub

    Private Sub TotalExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalExpensesToolStripMenuItem.Click
        Dim r As ExpenceWise
        r = New Daybook.ExpenceWise
        r.SetDatabaseLogon("", "", "", ConStr)
        frmRep.crvView.ReportSource = r
        frmRep.Show()
    End Sub

    Private Sub ExpenseWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenseWiseToolStripMenuItem.Click
        Dim r As ItemWise
        r = New Daybook.ItemWise
        r.SetDatabaseLogon("", "", "", ConStr)
        frmRep.crvView.ReportSource = r
        frmRep.Show()
    End Sub

    Private Sub picCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCalc.Click
        Shell("calc7.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub OenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OenToolStripMenuItem.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Title = "Open Day Book Notes"
            .DefaultExt = "*.dbn"
            .FileName = ""
            .Filter = "DayBookNotes|*.dbn|AllFiles|*.*"
            .ShowDialog()
            fn = .FileName
        End With
        If fn <> "" Then

            oRead = IO.File.OpenText(fn)
            rtxtNote.Text = oRead.ReadToEnd

        Else
        End If
    End Sub
  
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        On Error GoTo ex

        If (fn = "") Then
            With SaveFileDialog1
                .InitialDirectory = "C:\"
                .Title = "Save Day Book Notes"
                .DefaultExt = "*.dbn"
                .FileName = ""
                .Filter = "DayBookNotes|*.dbn|AllFiles|*.*"
                .ShowDialog()
                fn = .FileName
            End With

            oWrite = IO.File.CreateText(fn)
            oWrite.Write(rtxtNote.Text)
            oWrite.Close()
        End If
ex:
    End Sub

    Private Sub UserWiseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserWiseReportToolStripMenuItem.Click
        Dim r As UserWise
        r = New Daybook.UserWise
        frmRep.crvView.ReportSource = r
        r.SetDatabaseLogon("", "", "", ConStr)
        frmRep.crvView.SelectionFormula = "{DayMast.CrBy} = '" & UserId & "'"
        frmRep.crvView.Refresh()
        frmRep.Show()
    End Sub

    Private Sub picAbtMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAbtMe.Click
        '' Intro of mine
        Dim intro As String

        intro = "       DayBook is created by Hiren Mistry" & _
                Chr(13) & "-----------------------------------------------------" & _
                Chr(13) & "If you have any Queries or Suggestion then" & _
                Chr(13) & "       Call Me : (+91) - 999 - 821- 8369"

        MessageBox.Show(intro, "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click

    End Sub
End Class
