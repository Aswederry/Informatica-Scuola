Public Class Gioco

    Dim dado As New Integer
    Dim dadoR As New Random
    Dim n As New Integer

    Dim volte = 1


    Dim turno = 1


    Dim cordCaselle = {New Point(65, 731), New Point(173, 733), New Point(283, 732), New Point(393, 732), New Point(499, 733), New Point(609, 733), New Point(721, 731), New Point(830, 734), New Point(941, 732), New Point(1050, 730), New Point(1161, 734), New Point(1269, 730), New Point(1272, 635), New Point(1271, 537), New Point(1273, 439), New Point(1272, 340), New Point(1269, 247), New Point(1272, 149), New Point(1271, 51), New Point(1164, 48), New Point(1052, 48), New Point(938, 46), New Point(832, 48), New Point(722, 50), New Point(612, 49), New Point(500, 48), New Point(393, 50), New Point(282, 47), New Point(172, 47), New Point(64, 46), New Point(62, 146), New Point(62, 243), New Point(62, 339), New Point(62, 438), New Point(62, 535), New Point(172, 536), New Point(284, 537), New Point(393, 539), New Point(498, 534), New Point(615, 537), New Point(720, 535), New Point(829, 534), New Point(940, 536), New Point(1051, 538), New Point(1052, 443), New Point(1049, 339), New Point(1049, 247), New Point(940, 241)}

    Dim casella As New Integer
    Dim casella2 = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer2.Enabled = True

        My.Computer.Audio.Play(My.Resources.DadoS, AudioPlayMode.Background)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If casella = 48 Then
            Win()
        End If

        If casella2 = 48 Then
            Perso()
        End If

        If turno = 1 Then
            TurnoL.Text = "è il turno di P1"
        ElseIf turno = 2 Then
            TurnoL.Text = "è il turno di P2"
        End If

        If casella = 0 Then
                Giocatore1.Location = cordCaselle(0)
            ElseIf casella = 1 Then
                Giocatore1.Location = cordCaselle(1)
            ElseIf casella = 2 Then
                Giocatore1.Location = cordCaselle(1)
            ElseIf casella = 3 Then
                Giocatore1.Location = cordCaselle(2)
            ElseIf casella = 4 Then
                Giocatore1.Location = cordCaselle(3)
            ElseIf casella = 5 Then
                Giocatore1.Location = cordCaselle(4)
            CasPlus()
        ElseIf casella = 6 Then
                Giocatore1.Location = cordCaselle(5)
            CasMin()
        ElseIf casella = 7 Then
                Giocatore1.Location = cordCaselle(6)
            ElseIf casella = 8 Then
                Giocatore1.Location = cordCaselle(7)
            ElseIf casella = 9 Then
            Giocatore1.Location = cordCaselle(8)
            CasPlus()
        ElseIf casella = 10 Then
                Giocatore1.Location = cordCaselle(9)
            ElseIf casella = 11 Then
                Giocatore1.Location = cordCaselle(10)
            ElseIf casella = 12 Then
                Giocatore1.Location = cordCaselle(11)
            ElseIf casella = 13 Then
                Giocatore1.Location = cordCaselle(12)
            ElseIf casella = 14 Then
                Giocatore1.Location = cordCaselle(13)
            CasPlus()
        ElseIf casella = 15 Then
                Giocatore1.Location = cordCaselle(14)
            ElseIf casella = 16 Then
                Giocatore1.Location = cordCaselle(15)
            ElseIf casella = 17 Then
                Giocatore1.Location = cordCaselle(16)
            ElseIf casella = 18 Then
                Giocatore1.Location = cordCaselle(17)
            CasPlus()
        ElseIf casella = 19 Then
                Giocatore1.Location = cordCaselle(18)
            CasMin()
        ElseIf casella = 20 Then
                Giocatore1.Location = cordCaselle(19)
            ElseIf casella = 21 Then
                Giocatore1.Location = cordCaselle(20)
            ElseIf casella = 22 Then
                Giocatore1.Location = cordCaselle(21)
            ElseIf casella = 23 Then
                Giocatore1.Location = cordCaselle(22)
            CasPlus()
        ElseIf casella = 24 Then
                Giocatore1.Location = cordCaselle(23)
            ElseIf casella = 25 Then
                Giocatore1.Location = cordCaselle(24)
            ElseIf casella = 26 Then
                Giocatore1.Location = cordCaselle(25)
            ElseIf casella = 27 Then
                Giocatore1.Location = cordCaselle(26)
            CasPlus()
        ElseIf casella = 28 Then
                Giocatore1.Location = cordCaselle(27)
            ElseIf casella = 29 Then
                Giocatore1.Location = cordCaselle(28)
            ElseIf casella = 30 Then
                Giocatore1.Location = cordCaselle(29)
            ElseIf casella = 31 Then
                Giocatore1.Location = cordCaselle(30)
            CasPlus()
        ElseIf casella = 32 Then
                Giocatore1.Location = cordCaselle(31)
            CasMin()
        ElseIf casella = 33 Then
                Giocatore1.Location = cordCaselle(32)
            ElseIf casella = 34 Then
                Giocatore1.Location = cordCaselle(33)
            ElseIf casella = 35 Then
                Giocatore1.Location = cordCaselle(34)
            ElseIf casella = 36 Then
                Giocatore1.Location = cordCaselle(35)
                casella = 0
                My.Computer.Audio.Play(My.Resources.DeadS, AudioPlayMode.Background)
            ElseIf casella = 37 Then
                Giocatore1.Location = cordCaselle(36)
            ElseIf casella = 38 Then
                Giocatore1.Location = cordCaselle(37)
            ElseIf casella = 39 Then
                Giocatore1.Location = cordCaselle(38)
            ElseIf casella = 40 Then
                Giocatore1.Location = cordCaselle(39)
            ElseIf casella = 41 Then
                Giocatore1.Location = cordCaselle(40)
            CasPlus()
        ElseIf casella = 42 Then
                Giocatore1.Location = cordCaselle(41)
            CasMin()
        ElseIf casella = 43 Then
                Giocatore1.Location = cordCaselle(42)
            ElseIf casella = 44 Then
                Giocatore1.Location = cordCaselle(43)
            ElseIf casella = 45 Then
                Giocatore1.Location = cordCaselle(44)
            CasPlus()
        ElseIf casella = 46 Then
                Giocatore1.Location = cordCaselle(45)
            ElseIf casella = 47 Then
                Giocatore1.Location = cordCaselle(46)
            ElseIf casella = 48 Then
                Giocatore1.Location = cordCaselle(47)
                My.Computer.Audio.Play(My.Resources.WinS, AudioPlayMode.Background)
            End If





        If casella2 = 0 Then
                Giocatore2.Location = cordCaselle(0)
            ElseIf casella2 = 1 Then
                Giocatore2.Location = cordCaselle(1)
            ElseIf casella2 = 2 Then
                Giocatore2.Location = cordCaselle(1)
            ElseIf casella2 = 3 Then
                Giocatore2.Location = cordCaselle(2)
            ElseIf casella2 = 4 Then
                Giocatore2.Location = cordCaselle(3)
            ElseIf casella2 = 5 Then
                Giocatore2.Location = cordCaselle(4)
            CasPlus()
        ElseIf casella2 = 6 Then
                Giocatore2.Location = cordCaselle(5)
            CasMin()
        ElseIf casella2 = 7 Then
                Giocatore2.Location = cordCaselle(6)
            ElseIf casella2 = 8 Then
                Giocatore2.Location = cordCaselle(7)
            ElseIf casella2 = 9 Then
                Giocatore2.Location = cordCaselle(8)
            CasPlus()
        ElseIf casella2 = 10 Then
                Giocatore2.Location = cordCaselle(9)
            ElseIf casella2 = 11 Then
                Giocatore2.Location = cordCaselle(10)
            ElseIf casella2 = 12 Then
                Giocatore2.Location = cordCaselle(11)
            ElseIf casella2 = 13 Then
                Giocatore2.Location = cordCaselle(12)
            ElseIf casella2 = 14 Then
                Giocatore2.Location = cordCaselle(13)
            CasPlus()
        ElseIf casella2 = 15 Then
                Giocatore2.Location = cordCaselle(14)
            ElseIf casella2 = 16 Then
                Giocatore2.Location = cordCaselle(15)
            ElseIf casella2 = 17 Then
                Giocatore2.Location = cordCaselle(16)
            ElseIf casella2 = 18 Then
                Giocatore2.Location = cordCaselle(17)
            CasPlus()
        ElseIf casella2 = 19 Then
                Giocatore2.Location = cordCaselle(18)
            CasMin()
        ElseIf casella2 = 20 Then
                Giocatore2.Location = cordCaselle(19)
            ElseIf casella2 = 21 Then
                Giocatore2.Location = cordCaselle(20)
            ElseIf casella2 = 22 Then
                Giocatore2.Location = cordCaselle(21)
            ElseIf casella2 = 23 Then
                Giocatore2.Location = cordCaselle(22)
            CasPlus()
        ElseIf casella2 = 24 Then
                Giocatore2.Location = cordCaselle(23)
            ElseIf casella2 = 25 Then
                Giocatore2.Location = cordCaselle(24)
            ElseIf casella2 = 26 Then
                Giocatore2.Location = cordCaselle(25)
            ElseIf casella2 = 27 Then
                Giocatore2.Location = cordCaselle(26)
            CasPlus()
        ElseIf casella2 = 28 Then
                Giocatore2.Location = cordCaselle(27)
            ElseIf casella2 = 29 Then
                Giocatore2.Location = cordCaselle(28)
            ElseIf casella2 = 30 Then
                Giocatore2.Location = cordCaselle(29)
            ElseIf casella2 = 31 Then
                Giocatore2.Location = cordCaselle(30)
            CasPlus()
        ElseIf casella2 = 32 Then
                Giocatore2.Location = cordCaselle(31)
            CasMin()
        ElseIf casella2 = 33 Then
                Giocatore2.Location = cordCaselle(32)
            ElseIf casella2 = 34 Then
                Giocatore2.Location = cordCaselle(33)
            ElseIf casella2 = 35 Then
                Giocatore2.Location = cordCaselle(34)
            ElseIf casella2 = 36 Then
                Giocatore2.Location = cordCaselle(35)
                casella2 = 0
                My.Computer.Audio.Play(My.Resources.DeadS, AudioPlayMode.Background)
            ElseIf casella2 = 37 Then
                Giocatore2.Location = cordCaselle(36)
            ElseIf casella2 = 38 Then
                Giocatore2.Location = cordCaselle(37)
            ElseIf casella2 = 39 Then
                Giocatore2.Location = cordCaselle(38)
            ElseIf casella2 = 40 Then
                Giocatore2.Location = cordCaselle(39)
            ElseIf casella2 = 41 Then
                Giocatore2.Location = cordCaselle(40)
            CasPlus()
        ElseIf casella2 = 42 Then
                Giocatore2.Location = cordCaselle(41)
            CasMin()
        ElseIf casella2 = 43 Then
                Giocatore2.Location = cordCaselle(42)
            ElseIf casella2 = 44 Then
                Giocatore2.Location = cordCaselle(43)
            ElseIf casella2 = 45 Then
                Giocatore2.Location = cordCaselle(44)
            CasPlus()
        ElseIf casella2 = 46 Then
                Giocatore2.Location = cordCaselle(45)
            ElseIf casella2 = 47 Then
                Giocatore2.Location = cordCaselle(46)
            ElseIf casella2 = 48 Then
                Giocatore2.Location = cordCaselle(47)
                My.Computer.Audio.Play(My.Resources.WinS, AudioPlayMode.Background)
            End If


    End Sub

    Private Sub Gioco_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Impostazioni.colore = 0 Then
            Me.BackColor = Color.White
        ElseIf Impostazioni.colore = 1 Then
            Me.BackColor = Color.Red
        ElseIf Impostazioni.colore = 2 Then
            Me.BackColor = Color.Yellow
        ElseIf Impostazioni.colore = 3 Then
            Me.BackColor = Color.Aqua
        ElseIf Impostazioni.colore = 4 Then
            Me.BackColor = Color.Green
        End If

        If Impostazioni.pedina = 0 Then
            Giocatore1.BackgroundImage = My.Resources.oca3
        ElseIf Impostazioni.pedina = 1 Then
            Giocatore1.BackgroundImage = My.Resources.oca4
        ElseIf Impostazioni.pedina = 2 Then
            Giocatore1.BackgroundImage = My.Resources.oca5
        ElseIf Impostazioni.pedina = 3 Then
            Giocatore1.BackgroundImage = My.Resources.oca6
        End If

    End Sub

    Public Sub Win()
        Button1.Enabled = False
        WinL.Visible = True
        RestartB.Visible = True



        d1.Visible = False
        d2.Visible = False
        d3.Visible = False
        d4.Visible = False
        d5.Visible = False
        d6.Visible = False
    End Sub

    Private Sub RestartB_Click(sender As Object, e As EventArgs) Handles RestartB.Click
        casella = 0
        casella2 = 0
        Button1.Enabled = True

        WinL.Visible = False
        PersoL.Visible = False
        RestartB.Visible = False

    End Sub

    Private Sub CasPlus()
        If turno = 2 Then
            casella += 2
            turno = 2
        ElseIf turno = 1 Then
            casella2 += 2
            turno = 1
        End If

        My.Computer.Audio.Play(My.Resources.QuackS, AudioPlayMode.Background)
    End Sub
    Private Sub CasMin()
        If turno = 2 Then
            casella -= 4
            turno = 2
        ElseIf turno = 1 Then
            casella2 -= 4
            turno = 1
        End If

        My.Computer.Audio.Play(My.Resources.CrashS, AudioPlayMode.Background)
    End Sub

    Private Sub Perso()
        My.Computer.Audio.Play(My.Resources.BooS, AudioPlayMode.Background)
        Button1.Enabled = False
        PersoL.Visible = True
        RestartB.Visible = True


        d1.Visible = False
        d2.Visible = False
        d3.Visible = False
        d4.Visible = False
        d5.Visible = False
        d6.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        d1.Visible = False
        d2.Visible = False
        d3.Visible = False
        d4.Visible = False
        d5.Visible = False
        d6.Visible = False



        If volte < 10 Then


            dado = dadoR.Next(1, 7)

            If dado = 1 Then
                d1.Visible = True
            ElseIf dado = 2 Then
                d2.Visible = True
            ElseIf dado = 3 Then
                d3.Visible = True
            ElseIf dado = 4 Then
                d4.Visible = True
            ElseIf dado = 5 Then
                d5.Visible = True
            ElseIf dado = 6 Then
                d6.Visible = True
            End If

            volte += 1

        Else
            Timer3.Enabled = True
            Timer2.Enabled = False

            volte = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick



        Timer3.Enabled = False

        If dado = 1 Then
            d1.Visible = True
        ElseIf dado = 2 Then
            d2.Visible = True
        ElseIf dado = 3 Then
            d3.Visible = True
        ElseIf dado = 4 Then
            d4.Visible = True
        ElseIf dado = 5 Then
            d5.Visible = True
        ElseIf dado = 6 Then
            d6.Visible = True
        End If

        If turno = 1 Then

            casella += dado

            If casella > 48 Then
                n = casella - (dado * 2)
                casella = n
            End If

            turno = 2
            dado = 0

        ElseIf turno = 2 Then
            casella2 += dado

            If casella2 > 48 Then
                n = casella2 - (dado * 2)
                casella2 = n
            End If

            turno = 1
            dado = 0
        End If
    End Sub
End Class
