Public Class FullTimeEmployee : Inherits Employee
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, name As String, salary As Decimal)
        MyBase.New(id, name, salary)

    End Sub
    Public Overrides Sub GetDetails()
        MessageBox.Show($"------------Employee details------------
                        Id: {Me.Id}
                        Name: {Me.Name}
                        Annual Salary: {Me.Salary * 12}
                        ")
    End Sub

End Class
