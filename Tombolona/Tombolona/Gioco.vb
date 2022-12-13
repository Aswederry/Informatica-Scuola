Public Class Gioco

    Dim NumeriEstratti(90) As Integer
    Dim NumeriEstratti2(90) As Integer

    Dim NumeriCasella(27) As Integer

    Dim Riga1Bool(9) As Boolean
    Dim riga1Int As Integer
    Dim Riga2Bool(9) As Boolean
    Dim riga2Int As Integer
    Dim Riga3Bool(9) As Boolean
    Dim riga3Int As Integer

    Dim ambo As Boolean = False
    Dim terzina As Boolean = False
    Dim quartina As Boolean = False
    Dim cinquina As Boolean = False
    Dim tombola As Boolean = False

    Dim win As Boolean = False

    Dim a As Integer
    Dim volteArray As Integer = 0

    Dim rC As New Random
    Dim b As New Integer
    Dim z As Integer




    Private Sub EstraiB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstraiB.Click

        z = NumeroEstratto()

        NeL.Text = z

        Timer1.Enabled = True

        My.Computer.Audio.Play(My.Resources.EstrazioneS, AudioPlayMode.Background)

    End Sub



    Private Sub Gioco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 27

            b = rC.Next(1, 4)

            If b < 3 Then

                a = NumeroEstratto2()

                NumeriCasella(volteArray) = a

                volteArray += 1

                a = 0

            ElseIf b = 3 Then

                volteArray += 1

                NumeriCasella(volteArray) = Nothing

            End If

        Next

        C1.Text = NumeriCasella(0)
        C2.Text = NumeriCasella(1)
        C3.Text = NumeriCasella(2)
        C4.Text = NumeriCasella(3)
        C5.Text = NumeriCasella(4)
        C6.Text = NumeriCasella(5)
        C7.Text = NumeriCasella(6)
        C8.Text = NumeriCasella(7)
        C9.Text = NumeriCasella(8)
        C10.Text = NumeriCasella(9)
        C11.Text = NumeriCasella(10)
        C12.Text = NumeriCasella(11)
        C13.Text = NumeriCasella(12)
        C14.Text = NumeriCasella(13)
        C15.Text = NumeriCasella(14)
        C16.Text = NumeriCasella(15)
        C17.Text = NumeriCasella(16)
        C18.Text = NumeriCasella(17)
        C19.Text = NumeriCasella(18)
        C20.Text = NumeriCasella(19)
        C21.Text = NumeriCasella(20)
        C22.Text = NumeriCasella(21)
        C23.Text = NumeriCasella(22)
        C24.Text = NumeriCasella(23)
        C25.Text = NumeriCasella(24)
        C26.Text = NumeriCasella(25)
        C27.Text = NumeriCasella(26)

        My.Computer.Audio.Play(My.Resources.BS, AudioPlayMode.Background)

    End Sub

    Private Function NumeroEstratto() As Integer
        Dim r As New Random
        Dim fatto As Boolean = False
        NumeroEstratto = 0

        While fatto = False

            NumeroEstratto = r.Next(1, 91)

            If NumeroEstratto = NumeriEstratti(NumeroEstratto - 1) Then
                fatto = False
            Else
                fatto = True
                NumeriEstratti(NumeroEstratto - 1) = NumeroEstratto
            End If

        End While

        Return NumeroEstratto

    End Function

    Private Function NumeroEstratto2() As Integer
        Dim r2 As New Random
        Dim fatto2 As Boolean = False
        NumeroEstratto2 = 0

        While fatto2 = False

            NumeroEstratto2 = r2.Next(1, 91)

            If NumeroEstratto2 = NumeriEstratti2(NumeroEstratto2 - 1) Then
                fatto2 = False
            Else
                fatto2 = True
                NumeriEstratti2(NumeroEstratto2 - 1) = NumeroEstratto2
            End If

        End While

        Return NumeroEstratto2

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If z = NumeriCasella(0) Then
            C1.BackColor = Color.Cyan
            Riga1Bool(0) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(1) Then
            C2.BackColor = Color.Cyan
            Riga1Bool(1) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(2) Then
            C3.BackColor = Color.Cyan
            Riga1Bool(2) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(3) Then
            C4.BackColor = Color.Cyan
            Riga1Bool(3) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(4) Then
            C5.BackColor = Color.Cyan
            Riga1Bool(4) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(5) Then
            C6.BackColor = Color.Cyan
            Riga1Bool(5) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(6) Then
            C7.BackColor = Color.Cyan
            Riga1Bool(6) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(7) Then
            C8.BackColor = Color.Cyan
            Riga1Bool(7) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(8) Then
            C9.BackColor = Color.Cyan
            Riga1Bool(8) = True
            riga1Int += 1
        ElseIf z = NumeriCasella(9) Then
            C10.BackColor = Color.Cyan
            Riga2Bool(0) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(10) Then
            C11.BackColor = Color.Cyan
            Riga2Bool(1) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(11) Then
            C12.BackColor = Color.Cyan
            Riga2Bool(2) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(12) Then
            C13.BackColor = Color.Cyan
            Riga2Bool(3) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(13) Then
            C14.BackColor = Color.Cyan
            Riga2Bool(4) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(14) Then
            C15.BackColor = Color.Cyan
            Riga2Bool(5) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(15) Then
            C16.BackColor = Color.Cyan
            Riga2Bool(6) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(16) Then
            C17.BackColor = Color.Cyan
            Riga2Bool(7) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(17) Then
            C18.BackColor = Color.Cyan
            Riga2Bool(8) = True
            riga2Int += 1
        ElseIf z = NumeriCasella(18) Then
            C19.BackColor = Color.Cyan
            Riga3Bool(0) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(19) Then
            C20.BackColor = Color.Cyan
            Riga3Bool(1) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(20) Then
            C21.BackColor = Color.Cyan
            Riga3Bool(2) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(21) Then
            C22.BackColor = Color.Cyan
            Riga3Bool(3) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(22) Then
            C23.BackColor = Color.Cyan
            Riga3Bool(4) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(23) Then
            C24.BackColor = Color.Cyan
            Riga3Bool(5) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(24) Then
            C25.BackColor = Color.Cyan
            Riga3Bool(6) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(25) Then
            C26.BackColor = Color.Cyan
            Riga3Bool(7) = True
            riga3Int += 1
        ElseIf z = NumeriCasella(26) Then
            C27.BackColor = Color.Cyan
            Riga3Bool(8) = True
            riga3Int += 1
        End If




        If riga1Int > 1 Or riga2Int > 1 Or riga3Int > 1 Then
            ambo = True
        End If

        If riga1Int > 2 Or riga2Int > 2 Or riga3Int > 2 Then
            terzina = True
        End If

        If riga1Int > 3 Or riga2Int > 3 Or riga3Int > 3 Then
            quartina = True
        End If

        If riga1Int > 4 Or riga2Int > 4 Or riga3Int > 4 Then
            cinquina = True
        End If

        If ambo = True Then
            AmboL.Image = My.Resources.xRossa
        End If

        If terzina = True Then
            TerzinaL.Image = My.Resources.xRossa
        End If

        If quartina = True Then
            QuartinaL.Image = My.Resources.xRossa
        End If

        If cinquina = True Then
            CinquinaL.Image = My.Resources.xRossa
            win = True
        End If

        If win = True Then
            WinL.Visible = True
            RicominciaB.Visible = True

            EstraiB.Enabled = False
        End If


        Timer1.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RicominciaB.Click
        End
    End Sub
End Class