Module Module1
    Sub Main()
        ' Create a Dictionary
        Dim dictionary As New Dictionary(Of Integer, String)()

        ' Add elements to the Dictionary
        dictionary.Add(1, "One")
        dictionary.Add(2, "Two")
        dictionary.Add(3, "Three")

        ' Access elements in the Dictionary
        For Each kvp As KeyValuePair(Of Integer, String) In dictionary
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}")
        Next

        Console.WriteLine("Press Enter to exit...")
        Console.ReadLine()
    End Sub
End Module

