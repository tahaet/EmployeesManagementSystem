Public Class ctrlPerson : Inherits UserControl
    Private _person As Person

    Public Property Person()
        Get
            Return _person
        End Get

        Set(value)
            _person = value
        End Set
    End Property

    Public Sub Reset()
        lblId.Text = "[?????]"
        lblName.Text = "[?????]"
    End Sub
    Public Sub FillPersnInfo()

        lblId.Text = _person.Id.ToString()
        lblName.Text = _person.Name
    End Sub
End Class
