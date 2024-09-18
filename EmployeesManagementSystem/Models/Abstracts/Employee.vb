
Public MustInherit Class Employee : Inherits Person
    Private _salary As Decimal

    Public Property Salary() As Decimal
        Get
            Return _salary
        End Get
        Set(value As Decimal)
            _salary = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, name As String, salary As Decimal)
        MyBase.New(id, name)
        _salary = salary
    End Sub
End Class
