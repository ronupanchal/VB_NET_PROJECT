Public Class Student

    Private _sid As Integer
    Public Property SID() As Integer
        Get
            Return _sid
        End Get
        Set(ByVal value As Integer)
            _sid = value
        End Set
    End Property


    Private _sName As String
    Public Property SNAME() As String
        Get
            Return _sName
        End Get
        Set(ByVal value As String)
            _sName = value
        End Set
    End Property

    ''' <summary>
    ''' No Parameter funcation
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Display() As String
        SID = 10
        SNAME = "SAI"
        Return SID & " --- " & SNAME
    End Function
    ''' <summary>
    ''' Two Paramater function
    ''' </summary>
    ''' <param name="std_id"></param>
    ''' <param name="std_name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Display(ByVal std_id As Integer, ByVal std_name As String) As String


        Return SID & " --- " & SNAME
    End Function


End Class
