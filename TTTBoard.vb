Public Class TTTBoard
    'Public boardsize As Integer = 9
    Private Const Boardsize As Integer = 9
    'Create an array to represent spaces on theb oard
    Private board(Boardsize - 1) As String

    'board look
    '0 1 2
    '3 4 5 
    '6 7 8 



    'Default Constructor - It is called when new Board() is used in calling code
    Public Sub New()
        ResetBoard()
    End Sub

    ''' <summary>
    ''' Resets the board so that all spaces hold their numeric place (no Xs or Os)
    ''' </summary>
    Public Sub ResetBoard()
        For i As Integer = 0 To Boardsize - 1
            board(i) = i.ToString
        Next
    End Sub

    Public Overrides Function ToString() As String
        Return board(0) & "|" & board(1) & "|" & board(2) & vbNewLine &
            "-----" & vbNewLine &
            board(3) & "|" & board(4) & "|" & board(5) & vbNewLine &
            "-----" & vbNewLine &
            board(6) & "|" & board(7) & "|" & board(8)

    End Function


    ''' <summary>
    ''' Accepts and index on the board, verifies it is open and then if "X" or "O" is passed in, makes the mover 
    ''' </summary>
    ''' <param name="spaceIndex">Index on the board</param>
    ''' <param name="XorO">An X or O</param>
    ''' <returns>true if successfully placed, false otherwise</returns>
    Public Function UseSpace(spaceIndex As Integer, XorO As String) As Boolean
        XorO = XorO.ToUpper.Trim
        If XorO <> "X" AndAlso XorO <> "O" Then
            Return False
        End If
        'within range?
        If spaceIndex < 0 OrElse spaceIndex >= board.Length Then
            Return False
        End If

        'Is the space still availiable?
        If board(spaceIndex) <> spaceIndex.ToString Then
            Return False
        End If
        board(spaceIndex) = XorO
        Return True
    End Function
End Class
