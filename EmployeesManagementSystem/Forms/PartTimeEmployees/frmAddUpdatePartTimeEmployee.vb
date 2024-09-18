Imports EmployeesManagementSystem.SD

Public Class frmAddUpdatePartTimeEmployee
    Private _mode = Mode.Update
    Private _id As Integer
    Private _employee As PartTimeEmployee = New PartTimeEmployee()
    Public Sub New(Optional id As Integer? = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        If id Is Nothing Then
            _mode = Mode.Add

        Else
            _mode = Mode.Add
            _id = id
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadData()
        _employee = PartTimeEmployeesData.GetEmployeeById(_id)

        If _employee Is Nothing Then
            MessageBox.Show("No Person with ID = " & _id, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            Return
        End If

        lblId.Text = _employee.Id.ToString()
        txtName.Text = _employee.Name
        txtRatePerHour.Text = _employee.RatePerHour.ToString()
        txtWorkedHours.Text = _employee.WorkedHours.ToString()

    End Sub
    Private Sub frmAddUpdatePartTimeEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()

        If _mode = Mode.Update Then
            Reset()
            LoadData()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not Me.ValidateChildren() Then
            MessageBox.Show("Some fields are not valid!,
                put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        _employee.Name = txtName.Text.Trim()
        _employee.RatePerHour = Convert.ToDecimal(txtRatePerHour.Text)
        _employee.WorkedHours = Convert.ToDecimal(txtWorkedHours.Text)

        If _mode = Mode.Add Then

            PartTimeEmployeesData.AddEmployee(_employee)
            lblId.Text = _employee.Id.ToString()
        Else

            PartTimeEmployeesData.UpdateEmployee(_employee)
        End If




    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtRatePerHour_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRatePerHour.Validating
        If String.IsNullOrEmpty(txtRatePerHour.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtRatePerHour, "Field Can't be Empty")
        Else
            ErrorProvider1.SetError(txtRatePerHour, Nothing)

        End If
    End Sub

    Private Sub txtWorkedHours_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtWorkedHours.Validating
        If String.IsNullOrEmpty(txtWorkedHours.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtWorkedHours, "Field Can't be Empty")
        Else
            ErrorProvider1.SetError(txtWorkedHours, Nothing)

        End If
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        If String.IsNullOrEmpty(txtName.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtName, "Field Can't be Empty")
        Else
            ErrorProvider1.SetError(txtName, Nothing)

        End If
    End Sub

    Private Sub txtRatePerHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRatePerHour.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "."c Then
            If e.KeyChar = "."c And txtRatePerHour.Text.Contains("."c) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtWorkedHours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWorkedHours.KeyPress
          If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "."c Then
            If e.KeyChar = "."c And txtRatePerHour.Text.Contains("."c) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
  
    End Sub
End Class