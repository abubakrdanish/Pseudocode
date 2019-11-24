Module Module1

    Sub Main()
        Dim str1, letter As String
        Dim counter, alphabit, Nonalphabit As Integer

        str1 = ""
        letter = ""
        counter = 0
        alphabit = 0
        Nonalphabit = 0


        Console.Write("input string ")
        str1 = Console.Read

        For counter = 1 To Len(str1)
            letter = Mid(str1, counter, 1)
            If LCase(letter) < "a" And LCase(letter) > "z" Then
                Nonalphabit = Nonalphabit + 1
            Else
                alphabit = alphabit + 1

            End If




        Next
        Console.WriteLine(Nonalphabit)
        Console.WriteLine(alphabit)
        Console.ReadKey()



    End Sub

End Module
