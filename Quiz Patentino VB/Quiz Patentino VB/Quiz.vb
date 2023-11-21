Public Class Quiz
    Dim currentQuestion As Short


    Dim questionFileLine() As String = System.IO.File.ReadAllLines(Application.StartupPath & "Resources\Domande.txt", System.Text.Encoding.ASCII)

    Public userAnswers(20) As Short 'La differenza tra questi due e che uno tiene conto delle risposte degli utenti l'altro tiene conto delle risposte delle domande nel file.
    Public realAnswers(20) As Short

    Dim allQuestions(40) As Short 'La differenza tra questi due e che il primo mantiene il valore di tutte le domande, anche se non sono prese, mentre il secondo tiene conto delle domande che sono state scelte.
    Public questions(20) As Short

    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllQuestions()
        StartupSelection()
        LoadAllAnswers()

        currentQuestion = 1
        UpdateGraphics()
    End Sub


    Public Sub LoadAllQuestions() 'carica incrementalmente +1 all'array, cosi si può identificare con il sistema che c'è dopo
        For i = 0 To allQuestions.Length - 1
            allQuestions(i) = i
        Next
    End Sub

    Public Sub StartupSelection()
        For i = 0 To 19
            While True
                Dim a As Short
                Dim b As Random = New Random

                a = b.Next(0, allQuestions.Length)

                If (allQuestions(a) <> -1) Then
                    questions(i) = allQuestions(a)
                    allQuestions(a) = -1
                    Exit While
                End If
            End While
        Next
    End Sub

    Public Sub LoadAllAnswers()
        For i = 0 To 19
            Dim holder As Short = questions(i) * 4 + 2

            realAnswers(i) = CShort(questionFileLine(holder)) 'Questo serve a caricare nell'array delle risposte vere, le risposte vere, per farlo deve prendere il numero identificativo e moltiplicarlo per 4, poi per le risposte bisogna addizionare 2.
        Next

        For i = 0 To 19
            userAnswers(i) = -1
        Next
    End Sub

    Public Sub UpdateGraphics()
        Dim fastQuestionMenu() As Button = {B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, B16, B17, B18, B19, B20}

        Dim questionText As Short = questions(currentQuestion) * 4 + 1
        Dim questionImage As Short = questions(currentQuestion) * 4 + 3

        QuestionL.Text = questionFileLine(questionText) 'Le domande sono a +1 rispetto all'identificatore
        ImageView.Image = Image.FromFile(questionFileLine(questionImage)) 'Le immagini sono a +3 rispetto all'identificatore, che mi sono appena accorto che non serve a niente pero lo tengo perchè dovrei rifarmi la matematica.

        QuestionNumberL.Text = currentQuestion

        For i = 0 To 19
            If userAnswers(i) = 1 Then
                fastQuestionMenu(i).BackColor = Color.Green
            ElseIf userAnswers(i) = 0 Then
                fastQuestionMenu(i).BackColor = Color.Red
            Else
                fastQuestionMenu(i).BackColor = Color.DarkOrange
            End If
        Next
    End Sub


#Region "Skip Question Buttons"
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        currentQuestion = 1
        UpdateGraphics()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        currentQuestion = 2
        UpdateGraphics()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        currentQuestion = 3
        UpdateGraphics()
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        currentQuestion = 4
        UpdateGraphics()
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        currentQuestion = 5
        UpdateGraphics()
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        currentQuestion = 6
        UpdateGraphics()
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        currentQuestion = 7
        UpdateGraphics()
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        currentQuestion = 8
        UpdateGraphics()
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        currentQuestion = 9
        UpdateGraphics()
    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        currentQuestion = 10
        UpdateGraphics()
    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        currentQuestion = 11
        UpdateGraphics()
    End Sub

    Private Sub B12_Click(sender As Object, e As EventArgs) Handles B12.Click
        currentQuestion = 12
        UpdateGraphics()
    End Sub

    Private Sub B13_Click(sender As Object, e As EventArgs) Handles B13.Click
        currentQuestion = 13
        UpdateGraphics()
    End Sub

    Private Sub B14_Click(sender As Object, e As EventArgs) Handles B14.Click
        currentQuestion = 14
        UpdateGraphics()
    End Sub

    Private Sub B15_Click(sender As Object, e As EventArgs) Handles B15.Click
        currentQuestion = 15
        UpdateGraphics()
    End Sub

    Private Sub B16_Click(sender As Object, e As EventArgs) Handles B16.Click
        currentQuestion = 16
        UpdateGraphics()
    End Sub

    Private Sub B17_Click(sender As Object, e As EventArgs) Handles B17.Click
        currentQuestion = 17
        UpdateGraphics()
    End Sub
    Private Sub B18_Click(sender As Object, e As EventArgs) Handles B18.Click
        currentQuestion = 18
        UpdateGraphics()
    End Sub
    Private Sub B19_Click(sender As Object, e As EventArgs) Handles B19.Click
        currentQuestion = 19
        UpdateGraphics()
    End Sub
    Private Sub B20_Click(sender As Object, e As EventArgs) Handles B20.Click
        currentQuestion = 20
        UpdateGraphics()
    End Sub

#End Region

#Region "HUD Buttons"
    Private Sub TrueB_Click(sender As Object, e As EventArgs) Handles TrueB.Click
        userAnswers(currentQuestion - 1) = 1
        UpdateGraphics()
    End Sub

    Private Sub FalseB_Click(sender As Object, e As EventArgs) Handles FalseB.Click
        userAnswers(currentQuestion - 1) = 0
        UpdateGraphics()
    End Sub

    Private Sub NextB_Click(sender As Object, e As EventArgs) Handles NextB.Click
        If currentQuestion < 20 Then
            currentQuestion += 1
            UpdateGraphics()
        Else
            If MsgBox("Sicuro Che Vuoi Consegnare?", MsgBoxStyle.YesNo, "Consegnare?") = 6 Then

            End If
        End If
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        If MsgBox("Sicuro Che Vuoi Consegnare?", MsgBoxStyle.YesNo, "Consegnare?") = 6 Then

        End If
    End Sub
#End Region
End Class