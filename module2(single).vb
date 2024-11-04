Module Module1
    Sub Main()
        Dim dog As New Dog()
        dog.Eat()  ' Inherited from Animal
        dog.Bark() ' Defined in Dog

        Console.WriteLine("Press Enter to exit...")
        Console.ReadLine()
    End Sub

    Public Class Animal
        Public Sub Eat()
            Console.WriteLine("Eating...")
        End Sub
    End Class

    Public Class Dog
        Inherits Animal

        Public Sub Bark()
            Console.WriteLine("Barking...")
        End Sub
    End Class
End Module




