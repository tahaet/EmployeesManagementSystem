<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListPartTimeEmployees
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
        btnAdd = New Button()
        dgvPartTimeEmployees = New DataGridView()
        cmsPartTimeEmployee = New ContextMenuStrip(components)
        EditToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        ShowToolStripMenuItem = New ToolStripMenuItem()
        GetDetailsToolStripMenuItem = New ToolStripMenuItem()
        btnBack = New Button()
        CType(dgvPartTimeEmployees, ComponentModel.ISupportInitialize).BeginInit()
        cmsPartTimeEmployee.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.Control
        btnAdd.Font = New Font("Segoe UI", 16F)
        btnAdd.Location = New Point(641, 397)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(147, 58)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dgvPartTimeEmployees
        ' 
        dgvPartTimeEmployees.AllowUserToAddRows = False
        dgvPartTimeEmployees.AllowUserToDeleteRows = False
        dgvPartTimeEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPartTimeEmployees.Dock = DockStyle.Top
        dgvPartTimeEmployees.Location = New Point(0, 0)
        dgvPartTimeEmployees.Name = "dgvPartTimeEmployees"
        dgvPartTimeEmployees.ReadOnly = True
        dgvPartTimeEmployees.RowHeadersWidth = 51
        dgvPartTimeEmployees.Size = New Size(800, 380)
        dgvPartTimeEmployees.TabIndex = 2
        ' 
        ' cmsPartTimeEmployee
        ' 
        cmsPartTimeEmployee.Font = New Font("Segoe UI", 16F)
        cmsPartTimeEmployee.ImageScalingSize = New Size(20, 20)
        cmsPartTimeEmployee.Items.AddRange(New ToolStripItem() {EditToolStripMenuItem, DeleteToolStripMenuItem, ShowToolStripMenuItem, GetDetailsToolStripMenuItem})
        cmsPartTimeEmployee.Name = "cmsFullTimeEmployee"
        cmsPartTimeEmployee.Size = New Size(225, 172)
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
        ' ShowToolStripMenuItem
        ' 
        ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        ShowToolStripMenuItem.Size = New Size(224, 42)
        ShowToolStripMenuItem.Text = "Show"
        ' 
        ' GetDetailsToolStripMenuItem
        ' 
        GetDetailsToolStripMenuItem.Name = "GetDetailsToolStripMenuItem"
        GetDetailsToolStripMenuItem.Size = New Size(224, 42)
        GetDetailsToolStripMenuItem.Text = "Get Details"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.Control
        btnBack.Font = New Font("Segoe UI", 16F)
        btnBack.Location = New Point(36, 397)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(147, 58)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmListPartTimeEmployees
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 482)
        ContextMenuStrip = cmsPartTimeEmployee
        Controls.Add(btnBack)
        Controls.Add(btnAdd)
        Controls.Add(dgvPartTimeEmployees)
        Name = "frmListPartTimeEmployees"
        Text = "frmListPartTimeEmployees"
        CType(dgvPartTimeEmployees, ComponentModel.ISupportInitialize).EndInit()
        cmsPartTimeEmployee.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvPartTimeEmployees As DataGridView
    Friend WithEvents cmsPartTimeEmployee As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnBack As Button
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetDetailsToolStripMenuItem As ToolStripMenuItem
End Class
