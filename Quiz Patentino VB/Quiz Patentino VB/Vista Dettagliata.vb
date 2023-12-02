Public Class VistaDettagliata
    Dim questionFileLine() As String = System.IO.File.ReadAllLines(Application.StartupPath & "Resources\Domande.txt", System.Text.Encoding.ASCII)
    Dim currentQuestion = 1
    Private Sub VistaDettagliata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGraphics()
    End Sub

    Public Sub UpdateGraphics()
        Dim fastQuestionMenu() As Button = {B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, B16, B17, B18, B19, B20}

        Dim questionText As Short = Quiz.questions(currentQuestion) * 4 + 1

        QuestionL.Text = questionFileLine(questionText) 'Le domande sono a +1 rispetto all'identificatore
        ConvertAnswersToString(UserResponseL, Quiz.userAnswers)
        ConvertAnswersToString(RealResponseL, Quiz.realAnswers)

        QuestionNumberL.Text = currentQuestion

        For i = 0 To 19
            If Quiz.userAnswers(i) = Quiz.realAnswers(i) Then
                fastQuestionMenu(i).BackColor = Color.Green
            ElseIf Quiz.userAnswers(i) <> Quiz.realAnswers(i) Then
                fastQuestionMenu(i).BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub ConvertAnswersToString(label As Label, answerArray() As Short)
        If answerArray(currentQuestion - 1) = 1 Then
            label.Text = "Vero"
        ElseIf answerArray(currentQuestion - 1) = 0 Then
            label.Text = "Falso"
        Else
            label.Text = "Nulla"
        End If
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

End Class