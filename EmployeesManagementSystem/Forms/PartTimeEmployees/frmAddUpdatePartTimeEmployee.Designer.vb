<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUpdatePartTimeEmployee
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
        txtRatePerHour = New TextBox()
        Label3 = New Label()
        txtName = New TextBox()
        Label4 = New Label()
        lblId = New Label()
        Label1 = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        txtWorkedHours = New TextBox()
        Label2 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRatePerHour
        ' 
        txtRatePerHour.Font = New Font("Segoe UI", 16F)
        txtRatePerHour.Location = New Point(200, 254)
        txtRatePerHour.Name = "txtRatePerHour"
        txtRatePerHour.Size = New Size(279, 43)
        txtRatePerHour.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F)
        Label3.Location = New Point(14, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 37)
        Label3.TabIndex = 16
        Label3.Text = "Rate Per Hour:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 16F)
        txtName.Location = New Point(123, 159)
        txtName.Name = "txtName"
        txtName.Size = New Size(279, 43)
        txtName.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F)
        Label4.Location = New Point(23, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 37)
        Label4.TabIndex = 21
        Label4.Text = "Name:"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Font = New Font("Segoe UI", 16F)
        lblId.ForeColor = Color.Red
        lblId.Location = New Point(226, 86)
        lblId.Name = "lblId"
        lblId.Size = New Size(72, 37)
        lblId.TabIndex = 20
        lblId.Text = "N /A"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(177, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 37)
        Label1.TabIndex = 19
        Label1.Text = "Id: "
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 16F)
        btnCancel.ForeColor = Color.Red
        btnCancel.Location = New Point(87, 453)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 50)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 16F)
        btnSave.ForeColor = SystemColors.InfoText
        btnSave.Location = New Point(278, 453)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 50)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtWorkedHours
        ' 
        txtWorkedHours.Font = New Font("Segoe UI", 16F)
        txtWorkedHours.Location = New Point(215, 326)
        txtWorkedHours.Name = "txtWorkedHours"
        txtWorkedHours.Size = New Size(279, 43)
        txtWorkedHours.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F)
        Label2.Location = New Point(17, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 37)
        Label2.TabIndex = 23
        Label2.Text = "Worked Hours:"
        ' 
        ' frmAddUpdatePartTimeEmployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(545, 515)
        Controls.Add(txtWorkedHours)
        Controls.Add(Label2)
        Controls.Add(txtRatePerHour)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(lblId)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Name = "frmAddUpdatePartTimeEmployee"
        Text = "frmAddUpdatePartTimeEmployee"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRatePerHour As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtWorkedHours As TextBox
    Friend WithEvents Label2 As Label
End Class
