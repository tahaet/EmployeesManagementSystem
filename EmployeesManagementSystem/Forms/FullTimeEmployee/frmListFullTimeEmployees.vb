Imports Microsoft.IdentityModel.Tokens

Public Class frmListFullTimeEmployees
    Private _employees As List(Of FullTimeEmployee) = FullTimeEmployeesData.GetAllEmployees()
    Private Sub frmListFullTimeEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshEmployees()


    End Sub
    Private Sub RefreshEmployees()
        _employees = FullTimeEmployeesData.GetAllEmployees()
        dgvFullTimeEmployees.DataSource = Nothing
        dgvFullTimeEmployees.DataSource = _employees
        dgvFullTimeEmployees.DataSource = _employees
        dgvFullTimeEmployees.Columns("Id").DisplayIndex = 0
        dgvFullTimeEmployees.Columns("Name").DisplayIndex = 1
        dgvFullTimeEmployees.Columns("Salary").DisplayIndex = 2

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As frmAddUpdateFullTimeEmployee = New frmAddUpdateFullTimeEmployee()
        frm.ShowDialog()
        Me.Refresh()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim id As Integer = Convert.ToInt32(dgvFullTimeEmployees.CurrentRow.Cells("Id").Value)
        Dim frm As frmAddUpdateFullTimeEmployee = New frmAddUpdateFullTimeEmployee(id)
        frm.ShowDialog()
        Me.RefreshEmployees()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show($"Are you sure you want to delete Employee [{dgvFullTimeEmployees.CurrentRow.Cells("Id").Value}]", "Confirm Delete",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            FullTimeEmployeesData.DeleteEmployee(Convert.ToInt32(dgvFullTimeEmployees.CurrentRow.Cells("Id").Value))

            Me.RefreshEmployees()

        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub ShowStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowStripMenuItem.Click
        Dim id As Integer = Convert.ToInt32(dgvFullTimeEmployees.CurrentRow.Cells("Id").Value)
        Dim frm As frmShowPartTimeEmployeeInfo = New frmShowPartTimeEmployeeInfo(id)
        frm.ShowDialog()
    End Sub

    Private Sub GetDetailsStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDetailsStripMenuItem.Click
        Dim employee = FullTimeEmployeesData.GetEmployeeById(Convert.ToInt32(dgvFullTimeEmployees.CurrentRow.Cells("Id").Value))
        employee.GetDetails()
    End Sub
End Class