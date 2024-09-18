Public Class frmMain
    Private Sub ManageFullTimeEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageFullTimeEmployeesToolStripMenuItem.Click
        Dim frm As frmListFullTimeEmployees = New frmListFullTimeEmployees()
        frm.ShowDialog()
    End Sub

    Private Sub PartTimeEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartTimeEmployeesToolStripMenuItem.Click
        Dim frm As frmListPartTimeEmployees = New frmListPartTimeEmployees()
        frm.ShowDialog()
    End Sub
End Class