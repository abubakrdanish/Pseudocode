Module Module1

    Sub Main()
        Dim str1 As String
        Dim flag As Boolean
        Dim count As Integer
        Dim nextchar As Char
        str1 = ""
        flag = True
        count = 0


        Console.WriteLine("Input a string in aaaa-999-AAA")


        Console.Write("str1")



        If Len(str1) <> 12 Then
            flag = False


        End If
        //fixed characters
        If Mid(str1,5,1)<> '-' and mid (str1,9,1)<>'-'
            then 
            flag = False
        End If
        //check first group
        For count = 1 To 4
            nextchar = Mid(str1, count, 1)
            If nextchar<'a' or nextchar>'2'
                then
                flag = False
            End If
        Next
        // check second group
        For count = 6 To 8
            nextchar = Mid(str1, count, 1)
            If nextchar <'0' or nextchar>'9'

 Then
                flag = False

            End If
        Next
        // check third group
        For count = 10 To 12
            nextchar = Mid(str1, count, 1)
            If nextchar <'A'or nextchar >'2'
then

                flag = False


            End If

        Next
        If flag = True Then
            Console.WriteLine("valid")
        Else
            Console.WriteLine("invalid")



        End If
        Console.ReadKey()










    End Sub

End Module
