Public Class Main

    Dim CurrentFont As New Font()
    Dim SerialConnected As Boolean = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker_Serial.RunWorkerAsync()
    End Sub

#Region "Components"
    Private Sub Timer_Clock_Tick(sender As Object, e As EventArgs) Handles Timer_Clock.Tick
        SendText(Date.Now.Hour.ToString.PadLeft(2, "0") & ":" & Date.Now.Minute.ToString.PadLeft(2, "0") & ":" & Date.Now.Second.ToString.PadLeft(2, "0"), True)
    End Sub
#End Region

#Region "Functions"
    Private Function Reverse(ByVal Tmp As Byte) As Byte
        Dim c As Byte = Tmp
        c = ((c >> 1) And &H55) Or ((c << 1) And &HAA)
        c = ((c >> 2) And &H33) Or ((c << 2) And &HCC)
        c = (c >> 4) Or (c << 4)
        Return c
    End Function

    Private Sub Transmit(ByVal Bytes As Byte())
        If SerialPort.IsOpen() Then
            SerialPort.Write(Bytes, 0, Bytes.Length)
        End If
    End Sub

    Private Sub SetBrightness(ByVal Brightness As Integer)
        Dim TX(35) As Byte
        TX(0) = 25
        TX(1) = 1
        TX(2) = Brightness
        TX(34) = 128
        Transmit(TX)
    End Sub

    Private Sub SendText(ByVal Text As String, ByVal Optional Center As Boolean = False)
        If CheckBox_Preview.Checked Then
            ShowText(Text, Center)
        End If
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
                    TX(Pos) = If(CheckBox_HUD.Checked, Reverse(Column), Column)
                    Pos += 1
                Next
                Pos += 1
            Next
            Transmit(TX)
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
#End Region

#Region "GUI"
    Private Sub BackgroundWorker_Serial_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Serial.DoWork
        Dim Connection As Boolean = EnhancedSerial.ConnectSerial(SerialPort, 97, {96, 134}, 250000, My.Settings.LastPort)
        If Connection Then
            My.Settings.LastPort = SerialPort.PortName
            My.Settings.Save()
            My.Settings.Reload()
            SerialConnected = True
        Else
            SerialConnected = False
        End If
    End Sub

    Private Sub Timer_GUI_Tick(sender As Object, e As EventArgs) Handles Timer_GUI.Tick
        If SerialConnected Then
            StatusLabel_Serial.Text = "Connected"
            StatusLabel_Serial.ForeColor = Color.Green
            If Not SerialPort.IsOpen Then
                SerialConnected = False
            End If
        Else
            If BackgroundWorker_Serial.IsBusy Then
                StatusLabel_Serial.Text = "Searching..."
                StatusLabel_Serial.ForeColor = Color.DarkOrange
            Else
                StatusLabel_Serial.Text = "Not Found. Retry"
                StatusLabel_Serial.ForeColor = Color.Firebrick
            End If
        End If

    End Sub
#End Region

#Region "Controls"
    Private Sub Button_Preview_Click(sender As Object, e As EventArgs) Handles Button_Preview.Click
        ShowText(TextBox_Message.Text, CheckBox_Center.Checked)
    End Sub

    Private Sub Button_Transmit_Click(sender As Object, e As EventArgs) Handles Button_Transmit.Click
        SendText(TextBox_Message.Text, CheckBox_Center.Checked)
    End Sub

    Private Sub Button_FontEditor_Click(sender As Object, e As EventArgs) Handles Button_FontEditor.Click
        FontDesigner.ShowDialog()
    End Sub

    Private Sub Button_SetBrightness_Click(sender As Object, e As EventArgs)
        SetBrightness(TrackBar_Brightness.Value)
    End Sub

    Private Sub TrackBar_Brightness_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Brightness.Scroll
        If TrackBar_Brightness.Value = -1 Then
            If CheckBox_Enabled.Checked = False Then
                CheckBox_Enabled.Checked = True
            End If
        Else
            If CheckBox_Enabled.Checked Then
                CheckBox_Enabled.Checked = False
            End If
            SetBrightness(TrackBar_Brightness.Value)
        End If
    End Sub

    Private Sub Button_LoadFont_Click(sender As Object, e As EventArgs) Handles Button_LoadFont.Click
        OpenFileDialog.ShowDialog()
        If IO.File.Exists(OpenFileDialog.FileName) Then
            Try
                Dim TempFont As New Font(OpenFileDialog.FileName)
                CurrentFont = TempFont
                Label_CurrentFont.Text = "Loaded"
            Catch ex As Exception
                MsgBox("Font loading failed", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub StatusLabel_Serial_Click(sender As Object, e As EventArgs) Handles StatusLabel_Serial.Click
        If Not SerialConnected And Not BackgroundWorker_Serial.IsBusy Then
            BackgroundWorker_Serial.RunWorkerAsync()
        End If
    End Sub

#End Region

End Class