<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListFullTimeEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        dgvFullTimeEmployees = New DataGridView()
        btnAdd = New Button()
        cmsFullTimeEmployee = New ContextMenuStrip(components)
        EditToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        ShowStripMenuItem = New ToolStripMenuItem()
        GetDetailsStripMenuItem = New ToolStripMenuItem()
        btnBack = New Button()
        CType(dgvFullTimeEmployees, ComponentModel.ISupportInitialize).BeginInit()
        cmsFullTimeEmployee.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvFullTimeEmployees
        ' 
        dgvFullTimeEmployees.AllowUserToAddRows = False
        dgvFullTimeEmployees.AllowUserToDeleteRows = False
        dgvFullTimeEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFullTimeEmployees.Dock = DockStyle.Top
        dgvFullTimeEmployees.Location = New Point(0, 0)
        dgvFullTimeEmployees.Name = "dgvFullTimeEmployees"
        dgvFullTimeEmployees.ReadOnly = True
        dgvFullTimeEmployees.RowHeadersWidth = 51
        dgvFullTimeEmployees.Size = New Size(800, 380)
        dgvFullTimeEmployees.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.Control
        btnAdd.Font = New Font("Segoe UI", 16F)
        btnAdd.Location = New Point(641, 402)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(147, 58)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' cmsFullTimeEmployee
        ' 
        cmsFullTimeEmployee.Font = New Font("Segoe UI", 16F)
        cmsFullTimeEmployee.ImageScalingSize = New Size(20, 20)
        cmsFullTimeEmployee.Items.AddRange(New ToolStripItem() {EditToolStripMenuItem, DeleteToolStripMenuItem, ShowStripMenuItem, GetDetailsStripMenuItem})
        cmsFullTimeEmployee.Name = "cmsFullTimeEmployee"
        cmsFullTimeEmployee.Size = New Size(225, 200)
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(224, 42)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(224, 42)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' ShowStripMenuItem
        ' 
        ShowStripMenuItem.Name = "ShowStripMenuItem"
        ShowStripMenuItem.Size = New Size(224, 42)
        ShowStripMenuItem.Text = "Show"
        ' 
        ' GetDetailsStripMenuItem
        ' 
        GetDetailsStripMenuItem.Name = "GetDetailsStripMenuItem"
        GetDetailsStripMenuItem.Size = New Size(224, 42)
        GetDetailsStripMenuItem.Text = "Get Details"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.Control
        btnBack.Font = New Font("Segoe UI", 16F)
        btnBack.Location = New Point(30, 402)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(147, 58)
        btnBack.TabIndex = 2
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmListFullTimeEmployees
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 472)
        ContextMenuStrip = cmsFullTimeEmployee
        Controls.Add(btnBack)
        Controls.Add(btnAdd)
        Controls.Add(dgvFullTimeEmployees)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "frmListFullTimeEmployees"
        StartPosition = FormStartPosition.CenterParent
        Text = "List Full Time Employees"
        CType(dgvFullTimeEmployees, ComponentModel.ISupportInitialize).EndInit()
        cmsFullTimeEmployee.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvFullTimeEmployees As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmsFullTimeEmployee As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnBack As Button
    Friend WithEvents ShowStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetDetailsStripMenuItem As ToolStripMenuItem
End Class
