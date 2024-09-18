Public Class PartTimeEmployee : Inherits Person
    Private _ratePerHour As Decimal
    Private _workedHours As Single

    Public Property RatePerHour() As Decimal
        Get
            Return _ratePerHour
        End Get
        Set(value As Decimal)
            _ratePerHour = value
        End Set
    End Property

    Public Property WorkedHours() As Single
        Get
            Return _workedHours
        End Get
        Set(value As Single)
            _workedHours = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, name As String, ratePerHour As Decimal, workedHours As Single)
        MyBase.New(id, name)
        _ratePerHour = ratePerHour
        _workedHours = workedHours
    End Sub


    Public Overrides Sub GetDetails()
        MessageBox.Show($"------------Employee details------------ 
                        Id: {Me.Id}
                        Name: {Me.Name}
                        Horly Rate: {Me.RatePerHour}
                        Worked Hours: {Me.WorkedHours}")
    End Sub

End Class
