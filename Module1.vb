Module Module1

    Sub Main()
        Dim memID As String
        Dim memName As String
        Dim more As Char
        memID = ""
        memName = ""
        more = ""
        FileOpen(1, "C:\Users\Abubakar\Documents.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, memName)
            Input(1, memID)
            Console.WriteLine("membername :" & memName)
            Console.WriteLine("memid :" & memID)

        End While
            FileClose(1)

        Console.ReadKey()

    End Sub

End Module
