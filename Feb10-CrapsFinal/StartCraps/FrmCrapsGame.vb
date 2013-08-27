' Fig 7.18: CrapsGame.vb - MODIFIED VERSION

Public Class FrmCrapsGame
    ' die-roll constants
    Enum DiceNames
        SNAKE_EYES = 2
        TREY = 3
        LUCKY_SEVEN = 7
        CRAPS = 7
        YO_LEVEN = 11
        BOX_CARS = 12
    End Enum

    Enum GameStatus
        LOSE
        WIN
        ROLLAGAIN
        'by not assigning any values they will be 0, 1 and 2 respectively
    End Enum
    Const ROLL_COUNTER As Integer = 15


    Private Sub btnPlay_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnPlay.Click
        ' initialize variables for game
        Dim myPoint As Integer ' total point
        Dim sum As Integer, rollCount As Integer
        Dim status As GameStatus = GameStatus.ROLLAGAIN
        Dim games As Integer
        Dim wins(ROLL_COUNTER) As Integer
        Dim losses(ROLL_COUNTER) As Integer
        'myPoint = 0
        games = Convert.ToInt32(txtGames.Text)
        For i = 1 To games
            rollCount = 1
            sum = RollDice() ' roll dice and calculate sum
            ' check die roll
            Select Case sum
                Case DiceNames.LUCKY_SEVEN, DiceNames.YO_LEVEN
                    status = GameStatus.WIN
                Case DiceNames.SNAKE_EYES, DiceNames.TREY, DiceNames.BOX_CARS
                    status = GameStatus.LOSE
                Case Else
                    status = GameStatus.ROLLAGAIN
                    myPoint = sum
            End Select
            While status = GameStatus.ROLLAGAIN
                sum = RollDice() ' roll dice and calculate sum
                rollCount += 1  ' add one to the number of rolls in this game
                ' check outcome of roll
                If sum = myPoint Then ' win
                    status = GameStatus.WIN
                ElseIf sum = DiceNames.CRAPS Then ' lose
                    status = GameStatus.LOSE
                End If
            End While
            If status = GameStatus.LOSE Then
                lstDetail.Items.Add("Lost in " & rollCount & " rolls.")
                If rollCount < ROLL_COUNTER Then
                    losses(rollCount) += 1
                ElseIf rollCount >= ROLL_COUNTER Then
                    losses(ROLL_COUNTER) += 1
                End If
                'lstDetail.Items.Insert(0, "Lost in " & rollCount & " rolls.")
                'txtGameStatus.Text &= "Lost in " & rollCount & " rolls." & vbCrLf 
            Else
                lstDetail.Items.Add("Won in " & rollCount & " rolls.")
                If rollCount < ROLL_COUNTER Then
                    wins(rollCount) += 1
                Else 'condion is irrelevant
                    wins(ROLL_COUNTER) += 1
                End If
                'lstDetail.Items.Insert(0, "Won in " & rollCount & " rolls.")
                'txtGameStatus.Text &= "Won in " & rollCount & " rolls." & vbCrLf
            End If
        Next
        Dim winCount As Integer = 0
        Dim lossCount As Integer = 0
        For j = 1 To wins.Length - 1
            winCount += wins(j)
            lossCount += losses(j)
            lstWinResults.Items.Add(j & "      " & wins(j))
            lstLossResults.Items.Add(j & "     " & losses(j))
        Next
        lstWinResults.Items.Add("Won " & winCount & " games")
        lstLossResults.Items.Add("Loss " & lossCount & " games")
    End Sub ' btnPlay_Click


    ' generate random die rolls
    Function RollDice() As Integer
        Dim myDie1 As Integer ' die1 face
        Dim myDie2 As Integer ' die2 face
        Static randomObject As New Random() ' generate random number
        ' determine random integer
        myDie1 = randomObject.Next(1, 7)
        myDie2 = randomObject.Next(1, 7)
        ' txtGameStatus.Text &= "Die1 = " & myDie1 & ", Die2 = " _
        '     & myDie2 & vbCrLf
        'lstDetail.Items.Add("     Die1 = " & myDie1 & ", Die2 = " _
        '& myDie2)
        'lstDetail.Items.Insert(0, "     Die1 = " & myDie1 & ", Die2 = " _
        '                 & myDie2)
        Return myDie1 + myDie2 ' return sum
    End Function ' RollDice


    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtGames.Clear()
        lstDetail.Items.Clear()
        lstLossResults.Items.Clear()
        lstWinResults.Items.Clear()
        txtGames.Focus()
    End Sub
End Class ' FrmCrapsGame

' **************************************************************************
' * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************
