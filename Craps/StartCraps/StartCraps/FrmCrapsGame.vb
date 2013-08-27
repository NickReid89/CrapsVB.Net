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


    Private Sub btnPlay_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnPlay.Click
        ' initialize variables for game
        Dim myPoint As Integer ' total point
        Dim sum As Integer, rollCount As Integer = 1
        Dim status As GameStatus = GameStatus.ROLLAGAIN
        myPoint = 0
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
            txtGameStatus.Text &= "Lost in " & rollCount & " rolls." & vbCrLf
        Else
            txtGameStatus.Text &= "Won in " & rollCount & " rolls." & vbCrLf
        End If
    End Sub ' btnPlay_Click


    ' generate random die rolls
    Function RollDice() As Integer
        Dim myDie1 As Integer ' die1 face
        Dim myDie2 As Integer ' die2 face
        Static randomObject As New Random() ' generate random number
        ' determine random integer
        myDie1 = randomObject.Next(1, 7)
        myDie2 = randomObject.Next(1, 7)
        Return myDie1 + myDie2 ' return sum
    End Function ' RollDice


    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class ' FrmCrapsGame

