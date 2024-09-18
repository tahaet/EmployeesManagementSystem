Public Class ctrlFullTimeEmployee : Inherits UserControl

    Private _employee As FullTimeEmployee
    Public Sub LoadFullTimeEmployeeInfo(id As Integer)


        _employee = New FullTimeEmployeesData().GetEmployeeById(id)

        If _employee Is Nothing Then
            CtrlPerson1.Reset()
            Me.Reset()
        End If
        CtrlPerson1.Person = _employee
        CtrlPerson1.FillPersnInfo()
        Me.FillFullTimeEmployeeInfo()

    End Sub

    Public Sub Reset()
        lblSalary.Text = "[?????]"
    End Sub
    Public Sub FillFullTimeEmployeeInfo()
        lblSalary.Text = _employee.Salary.ToString()
    End Sub
End Class
