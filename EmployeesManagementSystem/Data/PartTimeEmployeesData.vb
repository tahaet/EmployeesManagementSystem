Public NotInheritable Class PartTimeEmployeesData

    Private Shared ReadOnly _employees As New List(Of PartTimeEmployee)

    Shared Sub New()
        _employees.Add(New PartTimeEmployee With {
            .Id = 1,
            .Name = "Alice Johnson",
            .RatePerHour = 20D,
            .WorkedHours = 120D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 2,
            .Name = "Bob Smith",
            .RatePerHour = 22D,
            .WorkedHours = 130D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 3,
            .Name = "Charlie Brown",
            .RatePerHour = 18D,
            .WorkedHours = 110D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 4,
            .Name = "Diana Prince",
            .RatePerHour = 25D,
            .WorkedHours = 140D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 5,
            .Name = "Edward Elric",
            .RatePerHour = 19D,
            .WorkedHours = 115D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 6,
            .Name = "Fiona Apple",
            .RatePerHour = 21D,
            .WorkedHours = 125D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 7,
            .Name = "George Harrison",
            .RatePerHour = 23D,
            .WorkedHours = 135D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 8,
            .Name = "Helen Keller",
            .RatePerHour = 24D,
            .WorkedHours = 145D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 9,
            .Name = "Ian Malcolm",
            .RatePerHour = 26D,
            .WorkedHours = 150D
        })

        _employees.Add(New PartTimeEmployee With {
            .Id = 10,
            .Name = "Jack Sparrow",
            .RatePerHour = 27D,
            .WorkedHours = 155D
        })

    End Sub

    Public Shared Sub AddEmployee(employee As PartTimeEmployee)
        employee.Id = _employees.Count + 1
        _employees.Add(employee)
    End Sub

    Public Shared Function GetAllEmployees() As List(Of PartTimeEmployee)
        Return _employees
    End Function

    Public Shared Function GetEmployeeById(id As Integer) As PartTimeEmployee
        Return _employees.FirstOrDefault(Function(e) e.Id = id)
    End Function

    Public Shared Sub UpdateEmployee(employee As PartTimeEmployee)
        Dim existingEmployee = GetEmployeeById(employee.Id)
        If existingEmployee IsNot Nothing Then
            existingEmployee.Name = employee.Name
            existingEmployee.RatePerHour = employee.RatePerHour
            existingEmployee.WorkedHours = employee.WorkedHours
        End If
    End Sub

    Public Shared Sub DeleteEmployee(id As Integer)
        Dim employee = GetEmployeeById(id)
        If employee IsNot Nothing Then
            _employees.Remove(employee)
        End If
    End Sub

End Class
