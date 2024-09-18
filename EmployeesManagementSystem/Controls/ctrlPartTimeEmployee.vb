Public Class ctrlPartTimeEmployee : Inherits UserControl
    Private _partTimeEmployee As PartTimeEmployee
    Public Sub LoadEmployeeInfo(id As Integer)

        _partTimeEmployee = PartTimeEmployeesData.GetEmployeeById(id)

        If _partTimeEmployee Is Nothing Then

            CtrlPerson1.Reset()
            Me.Reset()

        End If
        CtrlPerson1.Person = _partTimeEmployee
        CtrlPerson1.FillPersnInfo()
        Me.FillPartTimeEmployeeInfo()
    End Sub
    Public Sub Reset()
        lblHourRate.Text = "[?????]"
        lblHourRate.Text = "[?????]"
    End Sub

    Public Sub FillPartTimeEmployeeInfo()
        lblHourRate.Text = _partTimeEmployee.RatePerHour.ToString()
        lblWorkedHours.Text = _partTimeEmployee.WorkedHours.ToString()
    End Sub
End Class
