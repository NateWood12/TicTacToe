Module Module1
    'Nathan Woodring
    '10/26/2022
    'Using a class for tic tac toe 
    Sub Main()
        Console.WriteLine("Tic Tac Toe by Nathan Woodring!")
        Dim myBoard As New TTTBoard
        myBoard.ResetBoard()
        Dim gameover As Boolean = False
        Do
            Dim valid As Boolean = False
            Dim input As String
            Dim userMove As Integer
            'Single Turn 
            Do
                PrintBoard(myBoard)
                Console.Write("Enter the space you want to play -> ")
                input = Console.ReadLine
                If (Integer.TryParse(input, userMove)) Then
                    valid = myBoard.UseSpace(userMove, "X")
                    If Not valid Then
                        Console.WriteLine("Ivalid Move")
                    End If
                Else
                    Console.WriteLine("Please enter an integer")
                End If
            Loop While Not Valid
        Loop While Not gameover
    End Sub

    Sub PrintBoard(theBoard As TTTBoard)
        Console.WriteLine(theBoard.ToString())
        'Console.WriteLine("{0}|{1}|{2}", theBoard.board(0), theBoard.board(1), theBoard.board(2))
        'Console.WriteLine("----- ")
        'Console.WriteLine("{0}|{1}|{2}", theBoard.board(3), theBoard.board(4), theBoard.board(5))
        'Console.WriteLine("----- ")
        'Console.WriteLine("{0}|{1}|{2}", theBoard.board(6), theBoard.board(7), theBoard.board(8))
    End Sub

End Module
