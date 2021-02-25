Public Class EmployeeDB
    Private emp As EmployeeEntity() = New EmployeeEntity(10 - 1) {}
    Private cnt As Integer = 0
    Public Sub SaveEmpDB(ByRef empEntity As EmployeeEntity)
        emp(cnt) = empEntity
        cnt += 1
    End Sub
    Public Function DisplayEmpData() As EmployeeEntity()
        Return emp
    End Function
End Class
