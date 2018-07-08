Public Class Main

    Dim CurrentFont As New Font("C:\Users\Manos\Documents\GitHub\MuRID\Font.txt")

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

    Private Sub ShowText(ByVal Text As String, ByVal Optional Center As Boolean = False)
        Dim s As New Stopwatch
        s.Start()
        Dim Width As Integer = 0
        Dim Chars As Integer = 0
        Dim Letters As New List(Of Integer())
        For Each C As Char In Text
            Dim Current As Integer() = CurrentFont.Letter(C)
            Letters.Add(Current)
            Width += Current.Length + 1
            Chars += 1
        Next
        Width -= 1
        s.Stop()
        Label1.Text = s.ElapsedMilliseconds
        If Width <= 32 Then
            Dim Image As New Bitmap(32, 8)
            Dim Pos As Integer = 0
            If Center Then
                Pos = (32 - Width) / 2
            End If
            For Each Letter As Integer() In Letters
                For Each Column As Integer In Letter
                    ' decompress integer 
                    Dim Bits(8) As Boolean
                    Dim Tmp As Integer = Column
                    For Index As Integer = 7 To 0 Step -1
                        If Tmp >= 2 ^ Index Then
                            Tmp -= 2 ^ Index
                            Bits(Index) = True
                            Image.SetPixel(Pos, Index, Color.Red)
                        Else
                            Image.SetPixel(Pos, Index, Color.Black)
                        End If
                    Next
                    Pos += 1
                Next
                Pos += 1
            Next
            Matrix.Image = ResizeImage(Image, 32)
        Else
            ShowText("Too long")
        End If


        s.Stop()
        Label1.Text = s.ElapsedMilliseconds
        Dim x = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowText(TextBox1.Text, CheckBox1.Checked)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentFont.ExportFont("C:\Users\Manos\Desktop\Temp.txt")
    End Sub
End Class
