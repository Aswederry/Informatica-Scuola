Public Class Gioco 'Dove non metto commenti è dove non c'è niente da cambiare
#Region "Variabili"
    Dim image() As Image = {My.Resources.Back, My.Resources.Cloth, My.Resources.Granite, My.Resources.Grass, My.Resources.Lava, My.Resources.Legno, My.Resources.Navicella, My.Resources.Paint, My.Resources.Roccia, My.Resources.Titanium, My.Resources.Zolfo} 'Basta cambiare My.Resources è mettere il nome delle immagini, Il primo è sempre il didietro della carta.

    Dim checks(10) As Integer

    Dim pick() As PictureBox = {PlaceHolder1, PlaceHolder2}
    Dim picked As Boolean = False

    Dim random As New Random

    Dim counter As Short = 0

    Dim score As Short = 0
    Dim moves As Short = 20 'Mosse consentite.

    Dim yesCard As Boolean = False
#End Region

#Region "Subs"
    Private Sub Gioco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cards() As PictureBox = {C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20}

        For i = 1 To 20
            CardProperties(cards(counter))
            counter += 1
        Next

    End Sub

    Private Sub Hint_Tick(sender As Object, e As EventArgs) Handles Hint.Tick
        If yesCard = True Then
            score += 1

            pick(0).Visible = False
            pick(1).Visible = False

            AudioPlayer(4)
        Else
            pick(0).BackgroundImage = image(0)
            pick(1).BackgroundImage = image(0)
        End If
        moves -= 1

        PunteggioTxt.Text = score
        MovesTxt.Text = moves

        pick(0) = PlaceHolder1
        pick(1) = PlaceHolder2

        StopInput(False)
        ConditionCheck()

        yesCard = False

        Hint.Enabled = False
    End Sub

    Private Sub ConditionCheck()
        If score = 10 Then
            WinTxt.Visible = True
            AudioPlayer(2)
        End If

        If moves < 0 Then 'Se vuoi cambiare il testo di quando perdi lo puoì fare da qua.
            WinTxt.Text = "Hai perso!"
            WinTxt.ForeColor = Color.Red
            WinTxt.Visible = True
            StopInput(True)
            AudioPlayer(3)
        End If
    End Sub
#End Region

#Region "Funzioni"
    Public Function CardProperties(x As PictureBox) As PictureBox
        Do

            Dim a As Short = random.Next(1, 11)

            If checks(a) < 2 Then
                x.Tag = a
                checks(a) += 1
                Exit Do
            End If

        Loop

        Return x
    End Function

    Public Function Compare(x As PictureBox, y As PictureBox) As PictureBox

        If x.Tag = y.Tag Then
            yesCard = True
            Hint.Enabled = True
        Else
            Hint.Enabled = True
        End If

        StopInput(True)

        Return x
        Return y
    End Function

    Public Function Picker(x As PictureBox) As PictureBox
        If picked = False Then
            pick(0) = x
            picked = True
        Else
            pick(1) = x
            picked = False

            Compare(pick(0), pick(1))
        End If

        AudioPlayer(1)

        Return x
    End Function

    Public Function StopInput(x As Boolean)
        Dim cards() As PictureBox = {C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16, C17, C18, C19, C20}

        If x = True Then
            For i = 1 To 20
                cards(i - 1).Enabled = False
            Next
        Else
            For i = 1 To 20
                cards(i - 1).Enabled = True
            Next
        End If

        Return x
    End Function

    Public Function AudioPlayer(x As Short) As Short 'Basta Cambiare My.Resources per cambiare audio
        If x = 1 Then
            My.Computer.Audio.Play(My.Resources.FlipS, AudioPlayMode.Background) 'Quando si cliccano le carte.
        ElseIf x = 2 Then
            My.Computer.Audio.Play(My.Resources.WinS, AudioPlayMode.Background) 'Quando si vince
        ElseIf x = 3 Then
            My.Computer.Audio.Play(My.Resources.LoseS, AudioPlayMode.Background) 'Quando si perde
        ElseIf x = 4 Then
            My.Computer.Audio.Play(My.Resources.PointsS, AudioPlayMode.Background) 'Quando si ottiene un punto
        ElseIf x = 5 Then
            My.Computer.Audio.Play(My.Resources.ClickS, AudioPlayMode.Background) 'Quando si clicca un button nei menù
        End If

        Return x
    End Function

#End Region

#Region "Clicks"
    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        C1.BackgroundImage = image(C1.Tag)
        Picker(C1)
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        C2.BackgroundImage = image(C2.Tag)
        Picker(C2)
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        C3.BackgroundImage = image(C3.Tag)
        Picker(C3)
    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click
        C4.BackgroundImage = image(C4.Tag)
        Picker(C4)
    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click
        C5.BackgroundImage = image(C5.Tag)
        Picker(C5)
    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click
        C6.BackgroundImage = image(C6.Tag)
        Picker(C6)
    End Sub

    Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click
        C7.BackgroundImage = image(C7.Tag)
        Picker(C7)
    End Sub

    Private Sub C8_Click(sender As Object, e As EventArgs) Handles C8.Click
        C8.BackgroundImage = image(C8.Tag)
        Picker(C8)
    End Sub

    Private Sub C9_Click(sender As Object, e As EventArgs) Handles C9.Click
        C9.BackgroundImage = image(C9.Tag)
        Picker(C9)
    End Sub

    Private Sub C10_Click(sender As Object, e As EventArgs) Handles C10.Click
        C10.BackgroundImage = image(C10.Tag)
        Picker(C10)
    End Sub

    Private Sub C11_Click(sender As Object, e As EventArgs) Handles C11.Click
        C11.BackgroundImage = image(C11.Tag)
        Picker(C11)
    End Sub

    Private Sub C12_Click(sender As Object, e As EventArgs) Handles C12.Click
        C12.BackgroundImage = image(C12.Tag)
        Picker(C12)
    End Sub

    Private Sub C13_Click(sender As Object, e As EventArgs) Handles C13.Click
        C13.BackgroundImage = image(C13.Tag)
        Picker(C13)
    End Sub

    Private Sub C14_Click(sender As Object, e As EventArgs) Handles C14.Click
        C14.BackgroundImage = image(C14.Tag)
        Picker(C14)
    End Sub

    Private Sub C15_Click(sender As Object, e As EventArgs) Handles C15.Click
        C15.BackgroundImage = image(C15.Tag)
        Picker(C15)
    End Sub

    Private Sub C16_Click(sender As Object, e As EventArgs) Handles C16.Click
        C16.BackgroundImage = image(C16.Tag)
        Picker(C16)
    End Sub

    Private Sub C17_Click(sender As Object, e As EventArgs) Handles C17.Click
        C17.BackgroundImage = image(C17.Tag)
        Picker(C17)
    End Sub

    Private Sub C18_Click(sender As Object, e As EventArgs) Handles C18.Click
        C18.BackgroundImage = image(C18.Tag)
        Picker(C18)
    End Sub

    Private Sub C19_Click(sender As Object, e As EventArgs) Handles C19.Click
        C19.BackgroundImage = image(C19.Tag)
        Picker(C19)
    End Sub

    Private Sub C20_Click(sender As Object, e As EventArgs) Handles C20.Click
        C20.BackgroundImage = image(C20.Tag)
        Picker(C20)
    End Sub


#End Region

End Class