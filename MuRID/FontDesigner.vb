Public Class FontDesigner

    Dim Bytes(8, 8) As Boolean
    Dim CurrentFont As New Font()

    Private Sub FontDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateImage()
        UpdateResult()
    End Sub

    Private Sub PictureBox_Letter_Click(sender As Object, e As MouseEventArgs) Handles PictureBox_Letter.MouseClick
        Dim X As Integer = Math.Floor(e.X / 32)
        Dim Y As Integer = Math.Floor(e.Y / 32)
        Bytes(X, Y) = Not Bytes(X, Y)
        UpdateImage()
        UpdateResult()
    End Sub

    Private Sub UpdateImage()
        Dim Temp As Bitmap = New Bitmap(8, 8)
        For X As Integer = 0 To 7
            For Y As Integer = 0 To 7
                If Bytes(X, Y) Then
                    Temp.SetPixel(X, Y, Color.Red)
                Else
                    Temp.SetPixel(X, Y, Color.Black)
                End If
            Next
        Next
        PictureBox_Letter.Image = ResizeImage(Temp, 32)
    End Sub

    Private Sub UpdateResult()
        Dim Result(8) As Integer
        For X As Integer = 0 To 7
            Dim Sum As Integer = 0
            For Y As Integer = 0 To 7
                If Bytes(X, Y) Then
                    Sum += (2 ^ Y)
                End If
            Next
            Result(X) = Sum
        Next
        Dim StartPos As Integer = 0
        Dim EndPos As Integer = 7
        If CheckBox_ClipEmpty.Checked Then
            StartPos = -1
            EndPos = 0
            For Index As Integer = 0 To 7
                If StartPos = -1 And Result(Index) <> 0 Then
                    StartPos = Index
                End If
                If Result(Index) <> 0 Then
                    EndPos = Index
                End If
            Next
            If StartPos = -1 Then
                StartPos = 0
            End If
        End If
        TextBox_Result.Text = "{"
        For Index As Integer = StartPos To EndPos
            TextBox_Result.Text &= Result(Index) & ","
        Next
        If TextBox_Result.Text <> "{" Then
            TextBox_Result.Text = TextBox_Result.Text.Substring(0, TextBox_Result.Text.Length - 1)
        End If
        If CheckBox_IncludeWidth.Checked Then
            TextBox_Result.Text &= ";" & ((EndPos - StartPos) + 1)
        End If
        TextBox_Result.Text &= "}"
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

    Private Sub Button_Copy_Click(sender As Object, e As EventArgs) Handles Button_Copy.Click
        Clipboard.SetText(TextBox_Result.Text)
    End Sub

    Private Sub CheckBox_ClipEmpty_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ClipEmpty.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub CheckBox_IncludeWidth_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_IncludeWidth.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ReDim Bytes(8, 8)
        UpdateImage()
        UpdateResult()
    End Sub

    Private Sub CheckBox_RawEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_RawEnabled.CheckedChanged
        TextBox_Raw.Enabled = CheckBox_RawEnabled.Checked
    End Sub
End Class