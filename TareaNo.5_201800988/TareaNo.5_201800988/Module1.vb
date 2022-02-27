Module Module1
    Sub Main()
        Dim num, x, i, m As Integer
        x = 1
        Console.WriteLine("Ingrese el numero que quiere factorial:")
        num = Console.ReadLine()
        If num > 0 Then
            For y = 1 To num
                x = x * y
            Next
        End If
        Console.WriteLine("El factorial es del numero seleccionado es: " + x.ToString())
        For i = 0 To x
            If (i Mod 4) Then
                m = m + 1
            End If
        Next
        Console.WriteLine("Tiene " + m.ToString() + " numeros multiplos de 4 desde 0 hasta " + x.ToString())
        Console.ReadLine()
    End Sub
End Module
