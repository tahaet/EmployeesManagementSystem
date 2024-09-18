Public NotInheritable Class FullTimeEmployeesData

    Private Shared ReadOnly _employees As New List(Of FullTimeEmployee)

    Shared Sub New()
        _employees.Add(New FullTimeEmployee With {
            .Id = 1,
            .Name = "Alice Johnson",
            .Salary = 50000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 2,
            .Name = "Bob Smith",
            .Salary = 60000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 3,
            .Name = "Charlie Brown",
            .Salary = 55000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 4,
            .Name = "Diana Prince",
            .Salary = 65000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 5,
            .Name = "Edward Elric",
            .Salary = 70000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 6,
            .Name = "Fiona Apple",
            .Salary = 62000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 7,
            .Name = "George Harrison",
            .Salary = 57000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 8,
            .Name = "Helen Keller",
            .Salary = 69000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 9,
            .Name = "Ian Malcolm",
            .Salary = 72000D
        })

        _employees.Add(New FullTimeEmployee With {
            .Id = 10,
            .Name = "Jack Sparrow",
            .Salary = 63000D
        })

    End Sub

    Public Shared Sub AddEmployee(employee As FullTimeEmployee)
        employee.Id = _employees.Count + 1
        _employees.Add(employee)
    End Sub

    Public Shared Function GetAllEmployees() As List(Of FullTimeEmployee)
        Return _employees
    End Function

    Public Shared Function GetEmployeeById(id As Integer) As FullTimeEmployee
        Return _employees.FirstOrDefault(Function(e) e.Id = id)
    End Function

    Public Shared Sub UpdateEmployee(employee As FullTimeEmployee)
        Dim existingEmployee = GetEmployeeById(employee.Id)
        If existingEmployee IsNot Nothing Then
            existingEmployee.Name = employee.Name
            existingEmployee.Salary = employee.Salary
        End If
    End Sub

    Public Shared Sub DeleteEmployee(id As Integer)
        Dim employee = GetEmployeeById(id)
        If employee IsNot Nothing Then
            _employees.Remove(employee)
        End If
    End Sub
End Class
