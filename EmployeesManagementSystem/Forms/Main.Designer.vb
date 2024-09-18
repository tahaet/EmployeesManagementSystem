<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        MenuStrip1 = New MenuStrip()
        ManageEmployeesToolStripMenuItem = New ToolStripMenuItem()
        FullTimeEmployeesToolStripMenuItem = New ToolStripMenuItem()
        ManageFullTimeEmployeesToolStripMenuItem = New ToolStripMenuItem()
        PartTimeEmployeesToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManageEmployeesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 54)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ManageEmployeesToolStripMenuItem
        ' 
        ManageEmployeesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FullTimeEmployeesToolStripMenuItem})
        ManageEmployeesToolStripMenuItem.Font = New Font("Segoe UI", 20F)
        ManageEmployeesToolStripMenuItem.Name = "ManageEmployeesToolStripMenuItem"
        ManageEmployeesToolStripMenuItem.Size = New Size(364, 50)
        ManageEmployeesToolStripMenuItem.Text = "Content Management"
        ' 
        ' FullTimeEmployeesToolStripMenuItem
        ' 
        FullTimeEmployeesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManageFullTimeEmployeesToolStripMenuItem, PartTimeEmployeesToolStripMenuItem})
        FullTimeEmployeesToolStripMenuItem.Font = New Font("Segoe UI", 18F)
        FullTimeEmployeesToolStripMenuItem.Name = "FullTimeEmployeesToolStripMenuItem"
        FullTimeEmployeesToolStripMenuItem.Size = New Size(256, 46)
        FullTimeEmployeesToolStripMenuItem.Text = "Employees"
        ' 
        ' ManageFullTimeEmployeesToolStripMenuItem
        ' 
        ManageFullTimeEmployeesToolStripMenuItem.Name = "ManageFullTimeEmployeesToolStripMenuItem"
        ManageFullTimeEmployeesToolStripMenuItem.Size = New Size(386, 46)
        ManageFullTimeEmployeesToolStripMenuItem.Text = "Full Time Employees"
        ' 
        ' PartTimeEmployeesToolStripMenuItem
        ' 
        PartTimeEmployeesToolStripMenuItem.Name = "PartTimeEmployeesToolStripMenuItem"
        PartTimeEmployeesToolStripMenuItem.Size = New Size(386, 46)
        PartTimeEmployeesToolStripMenuItem.Text = "Part Time Employees"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        Text = "Main"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullTimeEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageFullTimeEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartTimeEmployeesToolStripMenuItem As ToolStripMenuItem
End Class
