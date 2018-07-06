Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFont("C:\Users\Manos\Desktop\Font.txt")
    End Sub

    Private Function ResizeImage(ByVal Image As Bitmap, ByVal Scale As Integer)
        Dim Temp As Bitmap = New Bitmap(Image.Size.Width * Scale, Image.Size.Height * Scale)
        For x As Integer = 0 To Image.Size.Width - 1
            For y As Integer = 0 To Image.Size.Height - 1
                For h As Integer = y * Scale To y * Scale + Scale - 1
                    For w As Integer = x * Scale To x * Scale + Scale - 1
                        Temp.SetPixel(w, h, Image.GetPixel(x, y))
                    Next
                Next
            Next
        Next
        Return Temp
    End Function

    Private Sub LoadFont(ByVal Filename As String)
        Dim Font As New Font
        Dim Lines() As String = IO.File.ReadAllLines(Filename)
        For Each Line As String In Lines
            Dim Name As String = Line.Substring(0, 1)
            Dim Data() As String = Line.Substring(1).Replace("{", "").Replace("}", "").Split(",")
            Dim Length As Integer = 0
            Dim Bytes(Data.Length - 1) As Integer
            For Each Item As String In Data
                Bytes(Length) = CInt(Item)
                Length += 1
            Next
            Font.Letters.Add(Name, Bytes)
        Next
    End Sub

    Private Sub InitFont(ByRef Font As Font)

    End Sub

End Class
