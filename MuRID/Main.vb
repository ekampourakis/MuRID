Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub InitFont(ByRef Font As Font)
        Dim SmallA As Letter = New Letter("a", {}, 0)

        'Font.Letters.Add("a", )
    End Sub

End Class
