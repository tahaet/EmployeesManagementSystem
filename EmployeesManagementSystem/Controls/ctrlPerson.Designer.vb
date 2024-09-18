<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPerson
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
        label1 = New Label()
        lblId = New Label()
        lblName = New Label()
        Label3 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 18F)
        label1.Location = New Point(81, 53)
        label1.Name = "label1"
        label1.Size = New Size(59, 41)
        label1.TabIndex = 0
        label1.Text = "Id: "
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Font = New Font("Segoe UI", 18F)
        lblId.ForeColor = Color.Red
        lblId.Location = New Point(128, 53)
        lblId.Name = "lblId"
        lblId.Size = New Size(101, 41)
        lblId.TabIndex = 1
        lblId.Text = "[?????]"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 18F)
        lblName.ForeColor = Color.Red
        lblName.Location = New Point(175, 121)
        lblName.Name = "lblName"
        lblName.Size = New Size(101, 41)
        lblName.TabIndex = 3
        lblName.Text = "[?????]"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.Location = New Point(81, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 41)
        Label3.TabIndex = 2
        Label3.Text = "Name:"
        ' 
        ' ctrlPerson
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblName)
        Controls.Add(Label3)
        Controls.Add(lblId)
        Controls.Add(label1)
        Name = "ctrlPerson"
        Size = New Size(588, 200)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
