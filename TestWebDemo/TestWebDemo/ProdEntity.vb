Public Class ProdEntity

    Private _pid As Integer
    Public Property PID() As Integer
        Get
            Return _pid
        End Get
        Set(ByVal value As Integer)
            _pid = value
        End Set
    End Property


    Private _PName As String
    Public Property PName() As String
        Get
            Return _PName
        End Get
        Set(ByVal value As String)
            _PName = value
        End Set
    End Property


    Private _Qty As Integer
    Public Property Qty() As Integer
        Get
            Return _Qty
        End Get
        Set(ByVal value As Integer)
            _Qty = value
        End Set
    End Property


    Private _Price As Integer
    Public Property Price() As Integer
        Get
            Return _Price
        End Get
        Set(ByVal value As Integer)
            _Price = value
        End Set
    End Property


    Private _Pic As String
    Public Property Pics() As String
        Get
            Return _Pic
        End Get
        Set(ByVal value As String)
            _Pic = value
        End Set
    End Property



End Class
