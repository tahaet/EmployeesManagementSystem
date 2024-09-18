
Public MustInherit Class Person : Implements IGetDetails

    Private _Id As Integer
    Private _name As String
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set

    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, name As String)
        _Id = id
        _name = name
    End Sub
    Public MustOverride Sub GetDetails() Implements IGetDetails.GetDetails
End Class
