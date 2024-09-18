<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPartTimeEmployeeInfo
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
        CtrlPartTimeEmployee1 = New ctrlPartTimeEmployee()
        btnCLose = New Button()
        SuspendLayout()
        ' 
        ' CtrlPartTimeEmployee1
        ' 
        CtrlPartTimeEmployee1.Location = New Point(0, 2)
        CtrlPartTimeEmployee1.Name = "CtrlPartTimeEmployee1"
        CtrlPartTimeEmployee1.Size = New Size(409, 303)
        CtrlPartTimeEmployee1.TabIndex = 0
        ' 
        ' btnCLose
        ' 
        btnCLose.Font = New Font("Segoe UI", 16F)
        btnCLose.ForeColor = SystemColors.InfoText
        btnCLose.Location = New Point(163, 321)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(110, 50)
        btnCLose.TabIndex = 1
        btnCLose.Text = "Close"
        btnCLose.UseVisualStyleBackColor = True
        ' 
        ' frmShowPartTimeEmployeeInfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 405)
        Controls.Add(btnCLose)
        Controls.Add(CtrlPartTimeEmployee1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmShowPartTimeEmployeeInfo"
        Text = "Employee Info"
        ResumeLayout(False)
    End Sub

    Friend WithEvents CtrlPartTimeEmployee1 As ctrlPartTimeEmployee
    Friend WithEvents btnCLose As Button
End Class
