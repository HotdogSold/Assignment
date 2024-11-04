Module Module1
    Sub Main()
        Dim puppy As New Puppy()
        puppy.Eat()  ' Inherited from Animal
        puppy.Bark() ' Inherited from Dog
        puppy.Weep() ' Defined in Puppy

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

    Public Class Puppy
        Inherits Dog

        Public Sub Weep()
            Console.WriteLine("Weeping...")
        End Sub
    End Class
End Module



