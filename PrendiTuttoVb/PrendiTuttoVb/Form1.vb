Public Class Form1
    Dim Images() As Image = {My.Resources.Back, My.Resources.Asso1, My.Resources.Denari1, My.Resources.Denari2, My.Resources.Denari3, My.Resources.Denari4, My.Resources.Denari5, My.Resources.Denari6, My.Resources.Denari7, My.Resources.Denari8, My.Resources.Denari9, My.Resources.Asso2, My.Resources.Coppe1, My.Resources.Coppe2, My.Resources.Coppe3, My.Resources.Coppe4, My.Resources.Coppe5, My.Resources.Coppe6, My.Resources.Coppe7, My.Resources.Coppe8, My.Resources.Coppe9, My.Resources.Asso3, My.Resources.Spade1, My.Resources.Spade2, My.Resources.Spade3, My.Resources.Spade4, My.Resources.Spade5, My.Resources.Spade7, My.Resources.Spade8, My.Resources.Spade9, My.Resources.Spade1, My.Resources.Asso4, My.Resources.Mazza1, My.Resources.Mazza2, My.Resources.Mazza3, My.Resources.Mazza4, My.Resources.Mazza5, My.Resources.Mazza6, My.Resources.Mazza7, My.Resources.Mazza8, My.Resources.Mazza9}
    Dim mazzo() As Short = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40}

    Dim playerDeck() As Short = {-1, -1, -1} : Dim playerNormalize(3) As Short : Dim playerUI() As PictureBox = {P1, P2, P3}
    Dim aiDeck() As Short = {-1, -1, -1} : Dim aiNormalize(3) As Short : Dim aiUI() As PictureBox = {A1, A2, A3}
    Dim centerDeck() As Short = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1} : Dim centerNormalize(10) As Short : Dim centerUI() As PictureBox = {C1, C2, C3, C4, C5, C6, C7, C8, C9, C10}

    Dim points As Short = 0
    Dim turno As Short = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 2
            PickCard(centerDeck)
            UI(centerDeck)
            Normalize(centerNormalize, centerDeck(i))

            PickCard(aiDeck)
            UI(aiDeck)
            Normalize(aiNormalize, aiDeck(i))

            PickCard(playerDeck)
            UI(playerDeck)
            Normalize(playerNormalize, playerDeck(i))
        Next

        Label1.Text = playerNormalize(0)
        Label2.Text = playerNormalize(1)
        Label3.Text = playerNormalize(2)
    End Sub

    Public Function PickCard(x() As Short)
        Dim a As New Random : Dim b As Integer
        For i = 0 To x.Length - 1

            b = a.Next(1, 41)
            If x(x.Length - 1) = -1 Then

                If x(i) = -1 And mazzo(b) <> -1 Then
                    x(i) = mazzo(b)
                    mazzo(b) = -1
                    Exit For
                ElseIf mazzo(b) = -1 Then
                    i -= 1
                End If

            Else
                MsgBox("Non c'è spazio")
                Exit For
            End If

        Next
        Return x
    End Function

    Public Function Normalize(normalizedArray() As Short, number As Short)
        While number > 10
            number -= 10
        End While

        For i = 0 To normalizedArray.Length - 1
            If normalizedArray(i) = 0 Then
                normalizedArray(i) = number
                Exit For
            End If
        Next

        Return number
    End Function

    Public Function UI(deck() As Short)
        Dim playerUI() As PictureBox = {P1, P2, P3}
        Dim aiUI() As PictureBox = {A1, A2, A3}
        Dim centerUI() As PictureBox = {C1, C2, C3, C4, C5, C6, C7, C8, C9, C10}

        For i = 0 To deck.Length - 1

            If deck Is playerDeck Then

                If deck(i) <> -1 Then
                    playerUI(i).BackgroundImage = Images(deck(i))
                    playerUI(i).Visible = True
                Else
                    playerUI(i).Visible = False
                End If

            ElseIf deck Is aiDeck Then

                If deck(i) = -1 Then
                    aiUI(i).Visible = False
                End If

            ElseIf deck Is centerDeck Then

                If deck(i) <> -1 Then
                    centerUI(i).BackgroundImage = Images(deck(i))
                    centerUI(i).Visible = True
                Else
                    centerUI(i).Visible = False
                End If

            End If
        Next
        Return deck
    End Function

    Public Function GiveCard(GiverDeck() As Short, number As Short)
        Dim i As Short = 0
        Dim normalizeDeckHolder As Array

        If GiverDeck Is playerDeck Then
            normalizeDeckHolder = playerNormalize
        ElseIf GiverDeck Is aiDeck Then
            normalizeDeckHolder = aiNormalize
        End If

        Do
            If centerDeck(i) <> -1 Then

                If normalizeDeckHolder(number) = centerNormalize(i) Then
                    normalizeDeckHolder(number) = -1 : playerDeck(number) = -1
                    centerDeck(i) = -1
                    UI(GiverDeck) : UI(centerDeck)
                    normalizeDeckHolder(i) = -1 : centerNormalize(i) = -1
                    Exit Do
                End If

            Else

                centerDeck(i) = GiverDeck(number)
                GiverDeck(number) = -1
                UI(centerDeck) : UI(GiverDeck)
                Exit Do

            End If
            i += 1

        Loop
        Return GiverDeck
    End Function

    Public Sub AI()
        Dim bestOption As Short = -1
        Dim a As Short : Dim b As New Random

        For i = 0 To 2
            If aiNormalize(i) = centerNormalize(i) And aiNormalize(i) <> -1 Then
                bestOption = i
                Exit For
            End If
        Next

        If bestOption = -1 Then

            For i = 0 To 2

                a = b.Next(0, 2)

                If bestOption <> -1 Then
                    bestOption = a
                    Exit For
                End If

            Next
        End If

        GiveCard(aiDeck, bestOption)

        AITimer.Enabled = False
        turno = 0
    End Sub

    Private Sub AItimerHandler()
        Dim a As Short : Dim b As New Random

        a = b.Next(1000, 3000)

        AITimer.Interval = a
        AITimer.Enabled = True
    End Sub
    Private Sub P1_Click(sender As Object, e As EventArgs) Handles P1.Click
        If playerDeck(0) <> -1 And turno = 0 Then
            GiveCard(playerDeck, 0)
        End If

        turno = 1
        AItimerHandler()
    End Sub

    Private Sub P2_Click(sender As Object, e As EventArgs) Handles P2.Click
        If playerDeck(1) <> -1 And turno = 0 Then
            GiveCard(playerDeck, 1)
        End If

        turno = 1
        AItimerHandler()
    End Sub

    Private Sub P3_Click(sender As Object, e As EventArgs) Handles P3.Click
        If playerDeck(2) <> -1 And turno = 0 Then
            GiveCard(playerDeck, 2)
        End If

        turno = 1
        AItimerHandler()
    End Sub

    Private Sub AITimer_Tick(sender As Object, e As EventArgs) Handles AITimer.Tick
        AI()
    End Sub
End Class
