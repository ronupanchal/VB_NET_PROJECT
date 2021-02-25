
Imports ClassLibrary1
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1 As New Student()
        Const pi As Double = 3.14



        MessageBox.Show(s1.Display())

    End Sub
End Class