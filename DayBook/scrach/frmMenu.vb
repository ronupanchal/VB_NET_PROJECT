#Region "Import Namespaces"
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System
Imports CrystalDecisions.ReportAppServer.ReportClientDocumentWrapper
#End Region
Public Class frmMenu
#Region "Declarations"
    Private mouseOffset As Point
#End Region
#Region "Click efect and Opening Documents"
    Private Sub lblNewPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmNewPat.Show()
    End Sub
    Private Sub lblImgVdo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmInsVdImg.Show()
    End Sub
    Private Sub lblDispIV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmDisp.Show()
    End Sub
    Private Sub lblPDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmDel.Show()
    End Sub
    Private Sub lblPtdtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmDispPat.Show()
    End Sub
    Private Sub lblPHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmPatHist.Show()
    End Sub
    Private Sub lblPPric_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmPrec.Show()
    End Sub
    Private Sub lblChgPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmEdLog.Show()
    End Sub
    Private Sub lblDischrgCrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmDischrgCard.Show()
    End Sub
    Private Sub lblPatBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmBill.Show()
    End Sub
    Private Sub lblNet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lblNewDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmNewDoc.Show()
    End Sub
    Private Sub btnAbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbt.Click
        frmAbout.Show()
    End Sub
    Private Sub lblIPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmIPDRec.Show()
    End Sub

    Private Sub lblOutdoor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmOPD.Show()
    End Sub
#End Region
#Region "Mouse Over Effects"
    Private Sub lblPat_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPat.MouseHover
        lblPat.ForeColor = Color.Red
    End Sub
    Private Sub lblDoc_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDoc.MouseHover
        lblDoc.ForeColor = Color.Red
    End Sub
    Private Sub lblImVdo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblImVdo.MouseHover
        lblImVdo.ForeColor = Color.Red
    End Sub
    Private Sub lblTools_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTools.MouseHover
        lblTools.ForeColor = Color.Red
    End Sub
    Private Sub lblReports_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblReports.MouseHover
        lblReports.ForeColor = Color.Red
    End Sub
    Private Sub lblBkRs_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBkRs.MouseHover
        lblBkRs.ForeColor = Color.Red
    End Sub
    Private Sub lblAdmin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAdmin.MouseHover
        lblAdmin.ForeColor = Color.Red
    End Sub
    Private Sub lblhelp_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblhelp.MouseHover
        lblhelp.ForeColor = Color.Red
    End Sub
#End Region
#Region "Mouse Leave Effects"
    Private Sub lblPat_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPat.MouseLeave
        lblPat.ForeColor = Color.Black
    End Sub
    Private Sub lblDoc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDoc.MouseLeave
        lblDoc.ForeColor = Color.Black
    End Sub
    Private Sub lblImVdo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblImVdo.MouseLeave
        lblImVdo.ForeColor = Color.Black
    End Sub
    Private Sub lblTools_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTools.MouseLeave
        lblTools.ForeColor = Color.Black
    End Sub
    Private Sub lblReports_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblReports.MouseLeave
        lblReports.ForeColor = Color.Black
    End Sub
    Private Sub lblBkRs_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBkRs.MouseLeave
        lblBkRs.ForeColor = Color.Black
    End Sub
    Private Sub lblAdmin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAdmin.MouseLeave
        lblAdmin.ForeColor = Color.Black
    End Sub
    Private Sub lblhelp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblhelp.MouseLeave
        lblhelp.ForeColor = Color.Black
    End Sub
#End Region
#Region "Form Events"
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Directory.Exists(My.Application.Info.DirectoryPath & "\PatRec") Then Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\PatRec")
    End Sub
    Private Sub btnCngScn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCngScn.Click
        frmSkinChg.Owner = Me
        frmSkinChg.Show()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Call DisConn()
        Call clearAllDatas()
        Call EncryptDatabase()
        Me.Close()
        frmSplashScreen.Close()
    End Sub
#End Region
#Region "Form being moved"
    ''--------------------------
    ''Make window moveable
    ''--------------------------
    Private Sub Me_MouseDown(ByVal sender As Object, _
        ByVal e As MouseEventArgs) _
        Handles MyBase.MouseDown

        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, _
        ByVal e As MouseEventArgs) _
        Handles MyBase.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
#End Region
#Region "Label Clicked"
    Private Sub lblPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPat.Click
        CMSPat.Show(Windows.Forms.Cursor.Position)
    End Sub
    Private Sub lblDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDoc.Click
        CMSDoc.Show(Windows.Forms.Cursor.Position)
    End Sub
    Private Sub lblImVdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblImVdo.Click
        CMSImgVdo.Show(Windows.Forms.Cursor.Position)
    End Sub
    Private Sub lblTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTools.Click
        CMSTools.Show(Windows.Forms.Cursor.Position)
    End Sub
    Private Sub lblReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReports.Click
        CMSRep.Show(Windows.Forms.Cursor.Position)
    End Sub
    Private Sub lblAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAdmin.Click
        CMSAdmin.Show(Windows.Forms.Cursor.Position)
    End Sub
    Private Sub lblBkRs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBkRs.Click
        Me.Hide()
        frmBkpRst.Show()
    End Sub
    Private Sub lblhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhelp.Click
        Shell("Help.exe", AppWinStyle.NormalFocus)
    End Sub
#End Region
#Region "Patient"
    Private Sub PatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem.Click
        Me.Hide()
        frmIPDRec.Show()
    End Sub
    Private Sub OutdoorPatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutdoorPatientToolStripMenuItem1.Click
        Me.Hide()
        frmOPD.Show()
    End Sub
    Private Sub DetailsToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem5.Click
        Me.Hide()
        frmNewPat.Show()
    End Sub
    Private Sub HistoryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem2.Click
        Me.Hide()
        frmPatHist.Show()
    End Sub
    Private Sub ListOfAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfAllToolStripMenuItem.Click
        Me.Hide()
        frmPatList.Show()
    End Sub
    Private Sub PrescriptionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrescriptionToolStripMenuItem1.Click
        Me.Hide()
        frmPrec.Show()
    End Sub
    Private Sub DischargeCardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargeCardToolStripMenuItem1.Click
        Me.Hide()
        frmDischrgCard.Show()
    End Sub
    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        Me.Hide()
        frmBill.Show()
    End Sub
#End Region
#Region "Doctor"
    Private Sub DetailsToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem4.Click
        Me.Hide()
        frmNewDoc.Show()
    End Sub
    Private Sub DisplayAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayAllToolStripMenuItem.Click
        Me.Hide()
        frmDocList.btnSel.Text = "Just E&xit"
        frmDocList.flg = False
        frmDocList.Show()
    End Sub
#End Region
#Region "Img and vdo"
    Private Sub ImageAndVideoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageAndVideoToolStripMenuItem.Click
        Me.Hide()
        frmInsVdImg.Show()
    End Sub
    Private Sub DisplayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem1.Click
        Me.Hide()
        frmDisp.Show()
    End Sub
#End Region
#Region "Tools"
    Private Sub DocSoftCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocSoftCaptureToolStripMenuItem.Click
        Shell("JPG_capture.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub IntercommunicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntercommunicationToolStripMenuItem.Click
        Try
            Dim l As String
            l = UCase(My.Computer.Info.OSFullName)
            If l.IndexOf("VISTA") > -1 Then
                Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Windows Collaboration\WinCollab.exe", AppWinStyle.NormalFocus)
            ElseIf l.IndexOf("VISTA") < 0 Then
                Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\NetMeeting\Conf.exe", AppWinStyle.NormalFocus)
            End If
        Catch ex As Exception
            MessageBox.Show("Your Operating System is " + My.Computer.Info.OSFullName + vbCrLf & _
                            "It Do Not Support This facility", "Abort Operation", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
    Private Sub BurnCDDVDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BurnCDDVDToolStripMenuItem.Click
        Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\BurnAware Free Edition\burnaware.exe", AppWinStyle.NormalFocus)
    End Sub
#End Region
#Region "Reports"
    '' Patients
    Private Sub DetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem1.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptPatList.rpt"
        frmReport.Show()
    End Sub
    Private Sub HistoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem1.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptPatHist.rpt"
        frmReport.Show()
    End Sub
    Private Sub IndoorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndoorToolStripMenuItem.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptIPDDtl.rpt"
        frmReport.Show()
    End Sub
    Private Sub OutdoorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutdoorToolStripMenuItem.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptOPDDtl.rpt"
        frmReport.Show()
    End Sub
    Private Sub PrescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrescriptionToolStripMenuItem.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptPrec.rpt"
        frmReport.Show()
    End Sub
    Private Sub DischargeCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargeCardToolStripMenuItem.Click
        Dim sp As String = "'"
        sp = InputBox("Enter Patient Id", "Selection report")
        If sp = "" Then
            msgBx("Please, Give Patient Id", "Err", "No walue to Display?")
            Exit Sub
        End If
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptDisCard.rpt"
        frmReport.CrystalReportViewer1.SelectionFormula = "{PatDischrg.PID}='" & sp & "'"
        frmReport.Show()
    End Sub
    Private Sub ImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        Me.Hide()
        frmImgPnt.Show()
    End Sub
    ''Doctors
    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptDocList.rpt"
        frmReport.Show()
    End Sub
    Private Sub DetailsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem2.Click
        Dim sp As String = ""
        sp = InputBox("Enter Name", "Detail Report")
        If sp = "" Then
            msgBx("Please, Give Name ", "Err", "No walue to Display?")
            Exit Sub
        End If
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptDocList.rpt"
        frmReport.CrystalReportViewer1.SelectionFormula = "{DocDt.DocName} Like ('" & sp & "*')"
        frmReport.Show()
    End Sub
    Private Sub SpecialityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialityToolStripMenuItem.Click
        Dim sp As String = ""
        sp = InputBox("Enter Speciality", "Specialized Report")
        If sp = "" Then
            msgBx("Please, Give Speciality type", "Err", "No walue to Display?")
            Exit Sub
        End If
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptDocList.rpt"
        frmReport.CrystalReportViewer1.SelectionFormula = "{DocDt.Qualification}= '" & sp & "'"
        frmReport.Show()
    End Sub
    ''Bill
    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        Dim sp As String = ""
        'Dim rptobj As New rptBillDtl
        sp = InputBox("Bill No", "Bill Report")
        If sp = "" Then
            msgBx("Please, Give Single Bill No", "Err", "No walue to Display?")
            Exit Sub
        End If
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptBillDtl.rpt"
        frmReport.CrystalReportViewer1.SelectionFormula = "{BillData.BillNo}= " & Val(sp)
        frmReport.Show()
    End Sub

    Private Sub ListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem1.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptBillList.rpt"
        frmReport.Show()
    End Sub
    Private Sub DetailsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem3.Click
        frmReport.CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath & "\reports\rptBillDtl.rpt"
        frmReport.Show()
    End Sub
#End Region
#Region "Admin"
    '' Delete
    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        Me.Hide()
        frmDelUsr.Show()
    End Sub
    Private Sub PatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem1.Click
        Me.Hide()
        frmDel.Show()
    End Sub
    Private Sub DoctorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem.Click
        Me.Hide()
        frmDelDoc.Show()
    End Sub
    '' Edit
    Private Sub UserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem1.Click
        Me.Hide()
        frmEdLog.Show()
    End Sub
    Private Sub PatientToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem3.Click
        Me.Hide()
        frmDispPat.Show()
    End Sub
    Private Sub DoctorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem2.Click
        Me.Hide()
        frmNewDoc.Show()
    End Sub
#End Region
End Class