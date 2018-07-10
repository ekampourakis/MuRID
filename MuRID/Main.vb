Public Class Main

    Dim CurrentFont As New Font("C:\Users\Manos\Desktop\fONTtEMP.font")

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
    End Sub

    Private Sub SendText(ByVal Text As String, ByVal Optional Center As Boolean = False)
        Dim Width As Integer = 0
        Dim Chars As Integer = 0
        Dim TX(35) As Byte
        TX(0) = 24
        TX(1) = 1
        TX(34) = 128
        Dim Letters As New List(Of Integer())
        For Each C As Char In Text
            Dim Current As Integer() = CurrentFont.Letter(C)
            Letters.Add(Current)
            Width += Current.Length + 1
            Chars += 1
        Next
        Width -= 1
        If Width <= 32 Then
            Dim Pos As Integer = 2
            If Center Then
                Pos = (32 - Width) / 2 + 2
            End If
            For Each Letter As Integer() In Letters
                For Each Column As Integer In Letter
                    TX(Pos) = Column
                    Pos += 1
                Next
                Pos += 1
            Next
            ' send via serial
            SerialPort1.Write(TX, 0, 35)
        Else
            SendText("Too long")
        End If
    End Sub

    Private Sub ShowText(ByVal Text As String, ByVal Optional Center As Boolean = False)
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
            Matrix.Image = Pixels.ResizeImage(Image, 32)
        Else
            ShowText("Too long")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowText(TextBox1.Text, CheckBox1.Checked)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentFont.ExportFont("C:\Users\Manos\Desktop\Temp.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FontDesigner.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SendText(TextBox1.Text, CheckBox1.Checked)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim TX(35) As Byte
        TX(0) = 25
        TX(1) = 1
        TX(2) = TrackBar1.Value
        TX(34) = 128
        SerialPort1.Write(TX, 0, 35)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim TX(35) As Byte
        TX(0) = 26
        TX(1) = 1
        TX(2) = If(CheckBox2.Checked, 255, 0)
        TX(34) = 128
        SerialPort1.Write(TX, 0, 35)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendText(Date.Now.Hour.ToString.PadLeft(2, "0") & ":" & Date.Now.Minute.ToString.PadLeft(2, "0") & ":" & Date.Now.Second.ToString.PadLeft(2, "0"), True)
    End Sub
End Class
