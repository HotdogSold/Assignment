Module Module1
    Sub Main()
        Dim dog As New Dog()
        dog.Eat()
        dog.Play()

        Console.WriteLine("Press Enter to exit...")
        Console.ReadLine()
    End Sub

    Interface IAnimal
        Sub Eat()
    End Interface

    Interface IPet
        Sub Play()
    End Interface

    Public Class Dog
        Implements IAnimal, IPet

        Public Sub Eat() Implements IAnimal.Eat
            Console.WriteLine("Dog is eating.")
        End Sub

        Public Sub Play() Implements IPet.Play
            Console.WriteLine("Dog is playing.")
        End Sub
    End Class
End Module
