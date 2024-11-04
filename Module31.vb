Module Module1
    Sub Main()
        ' Create an ArrayList
        Dim arrayList As New ArrayList()

        ' Add elements to the ArrayList
        arrayList.Add(1)
        arrayList.Add("Hello")
        arrayList.Add(3.14)

        ' Access elements in the ArrayList
        For Each item In arrayList
            Console.WriteLine(item)
        Next

        Console.WriteLine("Press Enter to exit...")
        Console.ReadLine()
    End Sub
End Module

