Public Class Letter
    Public Shared Key As String
    Public Shared Value() As Integer
    Public Shared Width As Integer

    Public Sub New(ByVal Name As String, ByVal Bytes As Integer(), ByVal Length As Integer)
        Key = Name
        Value = Bytes
        Width = Length
    End Sub
End Class
Public Class Font
    Public Shared Letters As New Dictionary(Of Char, Letter)
End Class
