Public MustInherit Class Employee

    Private _id As Integer
    Private _name As String
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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
    Public MustOverride Sub GetDetails()
End Class

Public Class FullTimeEmployee : Inherits Employee
    Private _salary As Decimal
    Public Property Salary() As Decimal
        Get
            Return _salary
        End Get
        Set(value As Decimal)
            _salary = value
        End Set
    End Property
    Public Overrides Sub GetDetails()

    End Sub
End Class
