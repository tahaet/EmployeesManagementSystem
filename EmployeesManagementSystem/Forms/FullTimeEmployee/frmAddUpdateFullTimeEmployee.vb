Imports System.Diagnostics.Eventing.Reader
Imports EmployeesManagementSystem.SD
Public Class frmAddUpdateFullTimeEmployee

    Private _mode As String = Mode.Update
    Private _id As Integer
    Private _employee As FullTimeEmployee = New FullTimeEmployee()
    Public Sub New(Optional id As Integer? = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        If id Is Nothing Then
            _mode = Mode.Add

        Else
            _mode = Mode.Update
            _id = id
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadData()
        _employee = FullTimeEmployeesData.GetEmployeeById(_id)

        If _employee Is Nothing Then
            MessageBox.Show("No Person with ID = " & _id, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            Return
        End If

        lblId.Text = _employee.Id.ToString()
        txtName.Text = _employee.Name
        txtSalary.Text = _employee.Salary.ToString()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not Me.ValidateChildren() Then
            MessageBox.Show("Some fields are not valid!,
                put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        _employee.Name = txtName.Text.Trim()
        _employee.Salary = Convert.ToDecimal(txtSalary.Text)

        If _mode = Mode.Add Then

            FullTimeEmployeesData.AddEmployee(_employee)
            lblId.Text = _employee.Id.ToString()
        Else

            FullTimeEmployeesData.UpdateEmployee(_employee)
        End If




    End Sub
    Private Sub Reset()
        lblId.Text = "N / A"
        txtName.Text = ""
        txtSalary.Text = ""
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddUpdateFullTimeEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()

        If _mode = Mode.Update Then
            Reset()
            LoadData()
        End If
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        If String.IsNullOrEmpty(txtName.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtName, "Name Can't be null")
        Else
            ErrorProvider1.SetError(txtName, Nothing)
        End If

    End Sub

    Private Sub txtSalary_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSalary.Validating
        If String.IsNullOrEmpty(txtSalary.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtSalary, "Salary Can't be null")
        Else
            ErrorProvider1.SetError(txtSalary, Nothing)

        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "."c Then
            If e.KeyChar = "."c And txtSalary.Text.Contains("."c) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub

End Class