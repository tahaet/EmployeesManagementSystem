Public Class frmListPartTimeEmployees
    Private _employees As List(Of PartTimeEmployee) = PartTimeEmployeesData.GetAllEmployees()


    Private Sub frmListPartTimeEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshEmployees()

    End Sub

    Private Sub RefreshEmployees()
        dgvPartTimeEmployees.DataSource = Nothing
        dgvPartTimeEmployees.DataSource = _employees
        dgvPartTimeEmployees.Columns("Id").DisplayIndex = 0
        dgvPartTimeEmployees.Columns("Name").DisplayIndex = 1
        dgvPartTimeEmployees.Columns("RatePerHour").DisplayIndex = 2
        dgvPartTimeEmployees.Columns("WorkedHours").DisplayIndex = 3
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As frmAddUpdatePartTimeEmployee = New frmAddUpdatePartTimeEmployee()
        frm.ShowDialog()
        Me.RefreshEmployees()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim id As Integer = Convert.ToInt32(dgvPartTimeEmployees.CurrentRow.Cells("Id").Value)
        Dim frm As frmAddUpdatePartTimeEmployee = New frmAddUpdatePartTimeEmployee(id)
        frm.ShowDialog()
        Me.RefreshEmployees()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show($"Are you sure you want to delete Employee [{dgvPartTimeEmployees.CurrentRow.Cells("Id").Value}]", "Confirm Delete",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            PartTimeEmployeesData.DeleteEmployee(Convert.ToInt32(dgvPartTimeEmployees.CurrentRow.Cells("Id").Value))

            Me.RefreshEmployees()

        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Dim id As Integer = Convert.ToInt32(dgvPartTimeEmployees.CurrentRow.Cells("Id").Value)
        Dim frm As frmShowFullTimeEmployee = New frmShowFullTimeEmployee(id)
        frm.ShowDialog()
    End Sub

    Private Sub GetDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetDetailsToolStripMenuItem.Click
        Dim employee = PartTimeEmployeesData.GetEmployeeById(Convert.ToInt32(dgvPartTimeEmployees.CurrentRow.Cells("Id").Value))
        employee.GetDetails()
    End Sub
End Class