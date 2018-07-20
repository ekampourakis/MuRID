Public Class Font
    Private Letters As New Dictionary(Of Char, Integer())
    Private LoadedFilename As String = ""
    Private LoadedFontName As String = "null" 'unnamed
    Public Sub New(ByVal Optional Filename As String = "")
        If Filename <> "" Then LoadFont(Filename)
    End Sub
    Public Sub LoadFont(ByVal Filename As String)
        Letters.Clear()
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
            AddLetter(Name, Bytes)
        Next
        LoadedFilename = Filename
    End Sub
    Public Sub ReloadFont()
        LoadFont(LoadedFilename)
    End Sub
    Public Sub ExportFont(ByVal Filename As String)
        Dim Writer As New IO.StreamWriter(Filename)
        For Index As Integer = 0 To Letters.Count - 1
            Writer.Write(Letters.Keys(Index) & "{")
            Dim Letter As Integer() = Letters.Item(Letters.Keys(Index))
            For Index2 As Integer = 0 To Letter.Count - 1
                Writer.Write(Letter(Index2) & If(Index2 < Letter.Count - 1, ",", "}"))
            Next
            Writer.Write(If(Index < Letters.Count - 1, vbNewLine, ""))
        Next
        Writer.Close()
    End Sub
    Public Sub AddLetter(ByVal Key As String, ByVal Values As Integer())
        If Not Letters.ContainsKey(Key) Then Letters.Add(Key, Values)
    End Sub
    Public Sub RemoveLetter(ByVal Key As String)
        If Letters.ContainsKey(Key) Then Letters.Remove(Key)
    End Sub
    Public Sub ReplaceLetter(ByVal Key As String, ByVal Values As Integer())
        RemoveLetter(Key)
        AddLetter(Key, Values)
    End Sub
    Public Function Exists(ByVal Key As String)
        Return Letters.ContainsKey(Key)
    End Function
    Public Function Letter(ByVal Key As String) As Integer()
        Dim NotFound As Integer() = {240, 176, 208, 240}
        If Letters.ContainsKey(Key) Then Return Letters.Item(Key) Else Return NotFound
    End Function
    Public Function Keys()
        Return Letters.Keys()
    End Function
End Class
