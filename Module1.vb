Module Module1

    Sub Main()
        Dim more As Char
        Dim memID As String
        Dim memName As String
        more = ""
        memID = ""
        memName = ""
        FileOpen(1, "C:\Users\Abubakar\Documents.txt", OpenMode.Output)
        Do
            Console.WriteLine("enter member name")
            memName = Console.ReadLine
            Console.WriteLine("enter member id")
            memID = Console.ReadLine
            WriteLine(1, memName)
            WriteLine(1, memID)
            Console.WriteLine("do you want to enter more then press y")
            more = Console.ReadLine

        Loop Until more = "n" Or more = "N"
        FileClose(1)


    End Sub

End Module
