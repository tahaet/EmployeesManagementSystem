<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlFullTimeEmployee
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        CtrlPerson1 = New ctrlPerson()
        Label1 = New Label()
        lblSalary = New Label()
        SuspendLayout()
        ' 
        ' CtrlPerson1
        ' 
        CtrlPerson1.Location = New Point(0, 0)
        CtrlPerson1.Name = "CtrlPerson1"
        CtrlPerson1.Person = Nothing
        CtrlPerson1.Size = New Size(395, 184)
        CtrlPerson1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(87, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 41)
        Label1.TabIndex = 1
        Label1.Text = "Salary:"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Segoe UI", 18F)
        lblSalary.ForeColor = Color.Red
        lblSalary.Location = New Point(196, 196)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(101, 41)
        lblSalary.TabIndex = 2
        lblSalary.Text = "[?????]"
        ' 
        ' ctrlFullTimeEmployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblSalary)
        Controls.Add(Label1)
        Controls.Add(CtrlPerson1)
        Name = "ctrlFullTimeEmployee"
        Size = New Size(586, 290)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CtrlPerson1 As ctrlPerson
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSalary As Label

End Class
