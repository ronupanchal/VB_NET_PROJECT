Public Class DateTimePickerDemo
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        MessageBox.Show(DateTimePicker1.Value)
        Label1.Text = "Selected Date is : " & DateTimePicker1.Value
    End Sub

    Private Sub DateTimePickerDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "---SELECT COUNTRY--"
    End Sub
End Class