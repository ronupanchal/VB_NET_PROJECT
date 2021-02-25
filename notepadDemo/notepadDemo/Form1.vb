Imports System.IO

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'New File
        'If Me.Text <> "notepadDemo" Then
        '    RichTextBox1.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
        '    MsgBox("Your file is saved", MsgBoxStyle.Information, "Notepad")
        '    Me.Text = "Notepad"
        '    RichTextBox1.Clear()
        'Else
        'End If
        RichTextBox1.Text = " "
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'open file
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            RichTextBox1.Text = sr.ReadToEnd
            sr.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim Filename As String
        Dim sw As StreamWriter

        Filename = SaveFileDialog1.FileName
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|" & "All   files|*.*"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Filename = SaveFileDialog1.FileName()
            sw = New StreamWriter(Filename)
            sw.Write(RichTextBox1.Text)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim Filename As String
        Dim sw As StreamWriter

        Filename = SaveFileDialog1.FileName
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|" & "All   files|*.*"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Filename = SaveFileDialog1.FileName()
            sw = New StreamWriter(Filename)
            sw.Write(RichTextBox1.Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Dispose()
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        'RichTextBox1.SelectionStart = 0
        'RichTextBox1.SelectionLength = RichTextBox1.Text.Length
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'font
        With FontDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = .Font
            End If
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = .Color
            End If
        End With
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BulletToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulletToolStripMenuItem.Click
        RichTextBox1.BulletIndent = 2
        RichTextBox1.SelectionBullet = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.ZoomFactor = 2
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        RichTextBox1.ZoomFactor = 5
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        RichTextBox1.ZoomFactor = 10
    End Sub
End Class
