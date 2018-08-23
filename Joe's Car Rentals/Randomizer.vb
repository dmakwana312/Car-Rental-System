Public Module Randomizer

    'Function to generate rabdin by number
    Public Function randomInteger(ByVal rLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "0123456789".ToCharArray()
        Dim str As String = ""

        For i As Integer = 0 To rLength - 1
            str += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return str
    End Function
End Module
