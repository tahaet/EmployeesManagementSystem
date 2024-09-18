<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUpdateFullTimeEmployee
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
        Label3 = New Label()
        txtSalary = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        btnCancel = New Button()
        btnSave = New Button()
        txtName = New TextBox()
        Label4 = New Label()
        lblId = New Label()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F)
        Label3.Location = New Point(35, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 37)
        Label3.TabIndex = 2
        Label3.Text = "Salary:"
        ' 
        ' txtSalary
        ' 
        txtSalary.Font = New Font("Segoe UI", 16F)
        txtSalary.Location = New Point(135, 226)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(279, 43)
        txtSalary.TabIndex = 2
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 16F)
        btnCancel.ForeColor = Color.Red
        btnCancel.Location = New Point(83, 350)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 50)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 16F)
        btnSave.ForeColor = SystemColors.InfoText
        btnSave.Location = New Point(274, 350)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 50)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 16F)
        txtName.Location = New Point(144, 125)
        txtName.Name = "txtName"
        txtName.Size = New Size(279, 43)
        txtName.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F)
        Label4.Location = New Point(44, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 37)
        Label4.TabIndex = 13
        Label4.Text = "Name:"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Font = New Font("Segoe UI", 16F)
        lblId.ForeColor = Color.Red
        lblId.Location = New Point(222, 58)
        lblId.Name = "lblId"
        lblId.Size = New Size(72, 37)
        lblId.TabIndex = 12
        lblId.Text = "N /A"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(173, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 37)
        Label1.TabIndex = 11
        Label1.Text = "Id: "
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmAddUpdateFullTimeEmployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 430)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(lblId)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtSalary)
        Controls.Add(Label3)
        Name = "frmAddUpdateFullTimeEmployee"
        Text = "Add / Update Full Time Employee"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
