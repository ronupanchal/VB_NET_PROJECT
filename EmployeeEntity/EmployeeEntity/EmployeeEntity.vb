Public Class EmployeeEntity

    Private _eID As Integer
    Public Property Emp_ID() As Integer
        Get
            Return _eID
        End Get
        Set(ByVal value As Integer)
            _eID = value
        End Set
    End Property

    Private _eName As String
    Public Property Emp_Name() As String
        Get
            Return _eName
        End Get
        Set(ByVal value As String)
            _eName = value
        End Set
    End Property

    Private _eDOJ As DateTime
    Public Property Emp_DOJ() As DateTime
        Get
            Return _eDOJ
        End Get
        Set(ByVal value As DateTime)
            _eDOJ = value
        End Set
    End Property
End Class
