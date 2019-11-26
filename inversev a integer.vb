Module Module1

    Sub Main()
        Dim count As Integer
        Dim ch As Char
        Dim str, rstr As String

        count = 0
        ch = ""



        str = ""
        rstr = ""


        Console.WriteLine("enter a string:")
        For count = Len(str) To 1 Step -1
            ch = Mid(str, count, 1)
            rstr = rstr & ch



        Next count
        Console.Write("rstr")
        Console.ReadLine()











    End Sub

End Module
