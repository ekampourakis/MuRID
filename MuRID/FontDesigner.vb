Public Class FontDesigner

    Dim Bytes(8, 8) As Boolean
    Dim CurrentFont As New Font()
    Dim Changed As Boolean = False

    Private Sub FontDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateImage()
        UpdateResult()
        Dim DialogResult As Integer = MessageBox.Show("You have not loaded fonts. Do you want to open one?", "Notice", MessageBoxButtons.YesNo)
        If DialogResult = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf DialogResult = Windows.Forms.DialogResult.Yes Then
            Button_LoadFont_Click(Button_LoadFont, Nothing)
        End If
    End Sub

    Private Sub PictureBox_Letter_Click(sender As Object, e As MouseEventArgs) Handles PictureBox_Letter.MouseClick
        Dim X As Integer = Math.Floor(e.X / 32)
        Dim Y As Integer = Math.Floor(e.Y / 32)
        Bytes(X, Y) = Not Bytes(X, Y)
        UpdateImage()
        UpdateResult()
    End Sub

    Private Sub UpdateImage()
        Dim Temp As New FastPixel(New Bitmap(8, 8))
        Temp.Lock()
        For X As Integer = 0 To 7
            For Y As Integer = 0 To 7
                If Bytes(X, Y) Then
                    Temp.SetPixel(X, Y, Color.Red)
                Else
                    Temp.SetPixel(X, Y, Color.Black)
                End If
            Next
        Next
        Temp.Unlock(True)
        PictureBox_Letter.Image = Pixels.ResizeImage(Temp.Bitmap, 32)
    End Sub

    Private Sub UpdateResult()
        Dim Result As Integer() = GetBytes()
        TextBox_Result.Text = "{"
        For Each N As Integer In Result
            TextBox_Result.Text &= N & ","
        Next
        If TextBox_Result.Text <> "{" Then
            TextBox_Result.Text = TextBox_Result.Text.Substring(0, TextBox_Result.Text.Length - 1)
        End If
        TextBox_Result.Text &= "}"
    End Sub

    Private Sub Button_Copy_Click(sender As Object, e As EventArgs)
        Clipboard.SetText(TextBox_Result.Text)
    End Sub

    Private Sub CheckBox_ClipEmpty_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ClipEmpty.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub CheckBox_IncludeWidth_CheckedChanged(sender As Object, e As EventArgs)
        UpdateResult()
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ReDim Bytes(8, 8)
        TextBox_Character.Text = ""
        UpdateImage()
        UpdateResult()
    End Sub

    Private Sub CheckBox_RawEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_RawEnabled.CheckedChanged
        TextBox_Raw.Enabled = CheckBox_RawEnabled.Checked
    End Sub

    Private Sub Button_LoadFont_Click(sender As Object, e As EventArgs) Handles Button_LoadFont.Click
        OpenFileDialog.ShowDialog()
        If IO.File.Exists(OpenFileDialog.FileName) Then
            Try
                If Changed Then
                    Dim DialogResult As Integer = MessageBox.Show("You have unsaved changes. Do you want to save previous work?", "Warning", MessageBoxButtons.YesNoCancel)
                    If DialogResult = Windows.Forms.DialogResult.Cancel Then
                        Exit Sub
                    ElseIf DialogResult = Windows.Forms.DialogResult.Yes Then
                        ' Save work here and the continue
                    End If
                End If
                Dim TempFont As New Font(OpenFileDialog.FileName)
                CurrentFont = TempFont
                Changed = False

                ' Clear all controls
                TextBox_Raw.Text = IO.File.ReadAllText(OpenFileDialog.FileName)

                UpdateList()
            Catch ex As Exception
                MsgBox("Font loading failed", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub ListBox_Letters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Letters.SelectedIndexChanged
        If ListBox_Letters.SelectedItem <> "" Then
            Dim Pos As Integer = 0
            Dim Letter As Integer() = CurrentFont.Letter(ListBox_Letters.SelectedItem)
            TextBox_Character.Text = ListBox_Letters.SelectedItem
            For Each Column As Integer In Letter
                Dim Bits(8) As Boolean
                Dim Tmp As Integer = Column
                For Index As Integer = 7 To 0 Step -1
                    If Tmp >= 2 ^ Index Then
                        Tmp -= 2 ^ Index
                        Bits(Index) = True
                        Bytes(Pos, Index) = True
                    Else
                        Bytes(Pos, Index) = False
                    End If
                Next
                Pos += 1
            Next
            While Pos < 8
                For Index As Integer = 0 To 7
                    Bytes(Pos, Index) = False
                Next
                Pos += 1
            End While
            UpdateImage()
            UpdateResult()
        End If
    End Sub

    Private Sub Button_ExportFont_Click(sender As Object, e As EventArgs) Handles Button_ExportFont.Click
        SaveFileDialog.ShowDialog()
        If SaveFileDialog.FileName <> "" Then
            CurrentFont.ExportFont(SaveFileDialog.FileName)
        End If
    End Sub

    Private Function GetBytes() As Integer()
        Dim Temp(8) As Integer
        For X As Integer = 0 To 7
            Dim Sum As Integer = 0
            For Y As Integer = 0 To 7
                If Bytes(X, Y) Then
                    Sum += (2 ^ Y)
                End If
            Next
            Temp(X) = Sum
        Next
        Dim StartPos As Integer = 0
        Dim EndPos As Integer = 7
        If CheckBox_ClipEmpty.Checked Then
            StartPos = -1
            EndPos = 0
            For Index As Integer = 0 To 7
                If StartPos = -1 And Temp(Index) <> 0 Then
                    StartPos = Index
                End If
                If Temp(Index) <> 0 Then
                    EndPos = Index
                End If
            Next
            If StartPos = -1 Then
                StartPos = 0
            End If
        End If
        Dim Result(EndPos - StartPos) As Integer
        Dim Pos As Integer = 0
        For Index As Integer = StartPos To EndPos
            Result(Pos) = Temp(Index)
            Pos += 1
        Next
        Return Result
    End Function

    Private Sub UpdateList()
        ListBox_Letters.Items.Clear()
        For Each CharKey As Char In CurrentFont.Keys()
            ListBox_Letters.Items.Add(CharKey)
        Next
    End Sub

    Private Sub Button_Push_Click(sender As Object, e As EventArgs) Handles Button_Push.Click
        Dim Flag As Boolean = True
        If CurrentFont.Exists(TextBox_Character.Text) And Not CheckBox_Override.Checked Then
            Dim DialogResult As Integer = MessageBox.Show("The key you are trying to add already exists. Do you want to replace?", "Warning", MessageBoxButtons.YesNoCancel)
            If DialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf DialogResult = Windows.Forms.DialogResult.No Then
                Flag = False
            End If
        End If
        If Flag Then
            Dim Bytes As Integer() = GetBytes()
            CurrentFont.ReplaceLetter(TextBox_Character.Text, Bytes)
            UpdateList()
        End If
    End Sub

    Private Sub TextBox_Character_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Character.TextChanged
        If TextBox_Character.Text.Length > 1 Then
            TextBox_Character.Text = TextBox_Character.Text.Substring(0, 1)
        End If
    End Sub

    Private Sub Shift(ByVal Dir As Direction, ByVal Optional Preserve As Boolean = True)
        Select Case Dir
            Case Direction.Up
                ShiftUp(Preserve)
            Case Direction.Down
                ShiftDown(Preserve)
            Case Direction.Left
                ShiftLeft(Preserve)
            Case Direction.Right
                ShiftRight(Preserve)
        End Select
        UpdateImage()
        UpdateResult()
    End Sub

    Private Sub ShiftUp(ByVal Preserve As Boolean)
        For X As Integer = 0 To 7
            Dim Temp As Boolean = If(Preserve, Bytes(X, 0), False)
            For Y As Integer = 1 To 7
                Bytes(X, Y - 1) = Bytes(X, Y)
            Next
            Bytes(X, 7) = Temp
        Next
    End Sub

    Private Sub ShiftDown(ByVal Preserve As Boolean)
        For X As Integer = 0 To 7
            Dim Temp As Boolean = If(Preserve, Bytes(X, 7), False)
            For Y As Integer = 7 To 1 Step -1
                Bytes(X, Y) = Bytes(X, Y - 1)
            Next
            Bytes(X, 0) = Temp
        Next
    End Sub

    Private Sub ShiftLeft(ByVal Preserve As Boolean)
        For Y As Integer = 0 To 7
            Dim Temp As Boolean = If(Preserve, Bytes(0, Y), False)
            For X As Integer = 1 To 7
                Bytes(X - 1, Y) = Bytes(X, Y)
            Next
            Bytes(7, Y) = Temp
        Next
    End Sub

    Private Sub ShiftRight(ByVal Preserve As Boolean)
        For Y As Integer = 0 To 7
            Dim Temp As Boolean = If(Preserve, Bytes(7, Y), False)
            For X As Integer = 7 To 1 Step -1
                Bytes(X, Y) = Bytes(X - 1, Y)
            Next
            Bytes(0, Y) = Temp
        Next
    End Sub

    Private Sub Button_ShiftUp_Click(sender As Object, e As EventArgs) Handles Button_ShiftUp.Click
        Shift(Direction.Up, CheckBox_Preserve.Checked)
    End Sub

    Private Sub Button_ShiftDown_Click(sender As Object, e As EventArgs) Handles Button_ShiftDown.Click
        Shift(Direction.Down, CheckBox_Preserve.Checked)
    End Sub

    Private Sub Button_ShiftLeft_Click(sender As Object, e As EventArgs) Handles Button_ShiftLeft.Click
        Shift(Direction.Left, CheckBox_Preserve.Checked)
    End Sub

    Private Sub Button_ShiftRight_Click(sender As Object, e As EventArgs) Handles Button_ShiftRight.Click
        Shift(Direction.Right, CheckBox_Preserve.Checked)
    End Sub

End Class