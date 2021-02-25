Public Class Employee_Datail
    Dim empDB As New EmployeeDB
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim eobj As New EmployeeEntity
        eobj.Emp_ID = CInt(txtID.Text)
        eobj.Emp_Name = txtName.Text
        eobj.Emp_DOJ = Convert.ToDateTime(txtDOJ.Text)
        empDB.SaveEmpDB(eobj)
        ListBox1.Items.Add(eobj.Emp_ID & "--" & eobj.Emp_Name & "--" & eobj.Emp_DOJ)
        txtID.Clear()
        txtName.Clear()
        txtDOJ.Clear()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim empList As EmployeeEntity() = empDB.DisplayEmpData()
        ComboBox1.Items.Clear()
        For Each emp In empList
            If (Not emp Is Nothing) Then
                ComboBox1.Items.Add(emp.Emp_ID & "--" & emp.Emp_Name & "--" & emp.Emp_DOJ)
            End If
        Next
    End Sub
End Class
