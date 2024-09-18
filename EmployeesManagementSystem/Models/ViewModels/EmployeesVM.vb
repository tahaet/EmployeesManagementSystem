Public Class EmployeeVM
    Private _fullTimeEmployees As List(Of FullTimeEmployee)
    Private _partTimeEmployees As List(Of PartTimeEmployee)
    Public Property FullTimeEmployees() As List(Of FullTimeEmployee)
        Get
            Return _fullTimeEmployees
        End Get
        Set(value As List(Of FullTimeEmployee))
            _fullTimeEmployees = value
        End Set
    End Property

    Public Property PartTimeEmployees As List(Of PartTimeEmployee)
        Get
            Return _partTimeEmployees
        End Get
        Set(value As List(Of PartTimeEmployee))
            _partTimeEmployees = value
        End Set
    End Property
End Class
