Option Strict On
Option Explicit On

Module ProgramFlowExamples

    Sub Main()
        Dim userResponse As String
        Dim userNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        Dim isValidNumber As Boolean = True

        Do
            Console.WriteLine("Please enter a whole number.")
            userResponse = Console.ReadLine()
            Console.WriteLine($"You entered {userResponse}")



            Try
                userNumber = CInt(userResponse)

                isValidNumber = True
            Catch
                isValidNumber = False
            End Try

        Loop While isValidNumber = False
        result = userNumber + secondNumber

        Console.WriteLine($"result: {userNumber} + {secondNumber} = {result}")
        Console.Read()
    End Sub

End Module
