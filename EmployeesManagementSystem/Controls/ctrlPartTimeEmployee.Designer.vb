<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPartTimeEmployee
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
        Label1 = New Label()
        lblHourRate = New Label()
        lblWorkedHours = New Label()
        Label3 = New Label()
        CtrlPerson1 = New ctrlPerson()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(75, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 41)
        Label1.TabIndex = 1
        Label1.Text = "Rate Per Hour:"
        ' 
        ' lblHourRate
        ' 
        lblHourRate.AutoSize = True
        lblHourRate.Font = New Font("Segoe UI", 18F)
        lblHourRate.ForeColor = Color.Red
        lblHourRate.Location = New Point(289, 178)
        lblHourRate.Name = "lblHourRate"
        lblHourRate.Size = New Size(101, 41)
        lblHourRate.TabIndex = 2
        lblHourRate.Text = "[?????]"
        ' 
        ' lblWorkedHours
        ' 
        lblWorkedHours.AutoSize = True
        lblWorkedHours.Font = New Font("Segoe UI", 18F)
        lblWorkedHours.ForeColor = Color.Red
        lblWorkedHours.Location = New Point(289, 236)
        lblWorkedHours.Name = "lblWorkedHours"
        lblWorkedHours.Size = New Size(101, 41)
        lblWorkedHours.TabIndex = 4
        lblWorkedHours.Text = "[?????]"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.Location = New Point(75, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 41)
        Label3.TabIndex = 3
        Label3.Text = "Worked Hours"
        ' 
        ' CtrlPerson1
        ' 
        CtrlPerson1.Location = New Point(0, 3)
        CtrlPerson1.Name = "CtrlPerson1"
        CtrlPerson1.Person = Nothing
        CtrlPerson1.Size = New Size(422, 175)
        CtrlPerson1.TabIndex = 5
        ' 
        ' ctrlPartTimeEmployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CtrlPerson1)
        Controls.Add(lblWorkedHours)
        Controls.Add(Label3)
        Controls.Add(lblHourRate)
        Controls.Add(Label1)
        Name = "ctrlPartTimeEmployee"
        Size = New Size(552, 334)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHourRate As Label
    Friend WithEvents lblWorkedHours As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CtrlPerson1 As ctrlPerson

End Class
