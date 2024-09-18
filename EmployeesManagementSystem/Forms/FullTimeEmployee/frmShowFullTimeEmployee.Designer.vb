<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowFullTimeEmployee
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
        CtrlFullTimeEmployee1 = New ctrlFullTimeEmployee()
        btnCLose = New Button()
        SuspendLayout()
        ' 
        ' CtrlFullTimeEmployee1
        ' 
        CtrlFullTimeEmployee1.Location = New Point(0, 0)
        CtrlFullTimeEmployee1.Name = "CtrlFullTimeEmployee1"
        CtrlFullTimeEmployee1.Size = New Size(360, 345)
        CtrlFullTimeEmployee1.TabIndex = 0
        ' 
        ' btnCLose
        ' 
        btnCLose.Font = New Font("Segoe UI", 16F)
        btnCLose.ForeColor = SystemColors.InfoText
        btnCLose.Location = New Point(118, 364)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(110, 50)
        btnCLose.TabIndex = 2
        btnCLose.Text = "Close"
        btnCLose.UseVisualStyleBackColor = True
        ' 
        ' frmShowFullTimeEmployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 450)
        Controls.Add(btnCLose)
        Controls.Add(CtrlFullTimeEmployee1)
        Name = "frmShowFullTimeEmployee"
        Text = "Show"
        ResumeLayout(False)
    End Sub

    Friend WithEvents CtrlFullTimeEmployee1 As ctrlFullTimeEmployee
    Friend WithEvents btnCLose As Button
End Class
