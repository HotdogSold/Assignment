Module Module1
    Sub Main()
        Dim person1 As New Person()
        person1.DisplayInfo()

        Dim person2 As New Person("Alice", 30)
        person2.DisplayInfo()

        ' Keep the console window open
        Console.WriteLine("Press Enter to exit...")
        Console.ReadLine()
    End Sub

    Public Class Person
        Public Property Name As String
        Public Property Age As Integer

        Public Sub New()
            Name = "Unknown"
            Age = 0
        End Sub

        Public Sub New(ByVal name As String, ByVal age As Integer)
            Me.Name = name
            Me.Age = age
        End Sub

        Public Sub DisplayInfo()
            Console.WriteLine($"Name: {Name}, Age: {Age}")
        End Sub
    End Class
End Module




