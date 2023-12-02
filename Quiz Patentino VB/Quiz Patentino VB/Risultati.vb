Public Class Results
    Dim rightQuestions As Short = 0
    Dim hasSucceded As Boolean = False
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResults()
        SuccededCheck()
        UiUpdate()
    End Sub

    Private Sub LoadResults()
        For i = 0 To 19
            If Quiz.userAnswers(i) = Quiz.realAnswers(i) Then
                rightQuestions += 1
            End If
        Next
    End Sub

    Private Sub SuccededCheck()
        If rightQuestions >= 17 Then
            hasSucceded = True
        End If
    End Sub

    Private Sub UiUpdate()
        NumberL.Text = CStr(rightQuestions) + "/20"

        If hasSucceded = True Then
            Face.Image = My.Resources.Happy
            ResultL.ForeColor = Color.Green
            ResultL.Text = "Passato"
        End If
    End Sub

    Private Sub MenuB_Click(sender As Object, e As EventArgs) Handles MenuB.Click
        Form1.Show()
        Quiz.Close()
        Me.Close()
    End Sub

    Private Sub DetailL_Click(sender As Object, e As EventArgs) Handles DetailL.Click
        Me.Hide()
        VistaDettagliata.Show()
    End Sub
End Class