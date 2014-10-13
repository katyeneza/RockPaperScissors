Public Class Form1
    Dim intCompScore As Integer = 0
    Dim intPlayerScore As Integer = 0
    Dim intCompThrow As Integer


    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        'Dim intCompThrow As Integer

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        Select Case Me.rdoRock.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblAnswer.Text = " It's a tie."
                    Case 2
                        Me.lblAnswer.Text = "The computer chooses paper. Computer wins!"
                        intCompScore += 1
                    Case 3
                        Me.lblAnswer.Text = "Computer chooses scissors. You win!"
                        intPlayerScore += 1
                    Case Else
                End Select

            Case False
            Case Else
        End Select

        Select Case Me.rdoPaper.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblAnswer.Text = "You win! Computer chose rock."
                        intPlayerScore += 1
                    Case 2
                        Me.lblAnswer.Text = "It's a tie."
                    Case 3
                        Me.lblAnswer.Text = "The computer chooses scissors. Computer wins!"
                        intCompScore += 1
                    Case Else
                End Select

            Case False

            Case Else
        End Select

        Select Case Me.rdoScissors.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblAnswer.Text = "The computer chooses rock. Computer wins!"
                        intCompScore += 1
                    Case 2
                        Me.lblAnswer.Text = "You win!Computer chose paper."
                        intPlayerScore += 1
                    Case 3
                        Me.lblAnswer.Text = "It's a tie."
                    Case Else
                End Select

            Case False
            Case Else
        End Select
        Me.lblScore.Text = "Computer Score " & intCompScore & "Player Score " & intPlayerScore

    End Sub

    Private Sub btnShootIf_Click(sender As Object, e As EventArgs) Handles btnShootIf.Click
        Dim intCompScore As Integer = 0
        Dim intPlayerScore As Integer = 0
        Dim intCompThrow As Integer

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If intCompThrow = 1 And Me.rdoRock.Checked Then
            Me.lblAnswer.Text = "It's a tie."
        ElseIf intCompThrow = 2 And Me.rdoRock.Checked Then
            Me.lblAnswer.Text = " The computer chooses paper. Computer wins!"
        ElseIf intCompThrow = 3 And Me.rdoRock.Checked Then
            Me.lblAnswer.Text = " You win!Computer chose scissors."
        Else
        End If

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If intCompThrow = 1 And Me.rdoPaper.Checked Then
            Me.lblAnswer.Text = "You win! Computer chose rock!"
        ElseIf intCompThrow = 2 And Me.rdoPaper.Checked Then
            Me.lblAnswer.Text = "It's a tie."
        ElseIf intCompThrow = 3 And Me.rdoPaper.Checked Then
            Me.lblAnswer.Text = "The computer chooses scissors. Computer wins!"
        Else
        End If
        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)


        If intCompThrow = 1 And Me.rdoScissors.Checked Then
            Me.lblAnswer.Text = "The computer chooses rock. Computer wins!"
        ElseIf intCompThrow = 2 And Me.rdoScissors.Checked Then
            Me.lblAnswer.Text = "You win! Computer chose paper!"
        ElseIf intCompThrow = 3 And Me.rdoScissors.Checked Then
            Me.lblAnswer.Text = "It's a tie."
        Else
        End If

    End Sub
End Class
