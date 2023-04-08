Public Class Form1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Gioco.Show()
        Me.Hide()
        Gioco.AudioPlayer(5)
    End Sub

    Private Sub RulesButton_Click(sender As Object, e As EventArgs) Handles RulesButton.Click
        Rules.Show()
        Me.Hide()
        Gioco.AudioPlayer(5)
    End Sub

    Private Sub FacileBtn_Click(sender As Object, e As EventArgs) Handles FacileBtn.Click
        Gioco.moves = 25
        Gioco.difficulty = 1

        FacileBtn.UseVisualStyleBackColor = False
        MedioBtn.UseVisualStyleBackColor = True
        DiffBtn.UseVisualStyleBackColor = True

        FacileBtn.Enabled = False
        MedioBtn.Enabled = True
        DiffBtn.Enabled = True
        Gioco.AudioPlayer(5)
    End Sub

    Private Sub MedioBtn_Click(sender As Object, e As EventArgs) Handles MedioBtn.Click
        Gioco.moves = 20
        Gioco.difficulty = 2

        FacileBtn.UseVisualStyleBackColor = True
        MedioBtn.UseVisualStyleBackColor = False
        DiffBtn.UseVisualStyleBackColor = True

        FacileBtn.Enabled = True
        MedioBtn.Enabled = False
        DiffBtn.Enabled = True
        Gioco.AudioPlayer(5)
    End Sub

    Private Sub DiffBtn_Click(sender As Object, e As EventArgs) Handles DiffBtn.Click
        Gioco.moves = 15
        Gioco.difficulty = 3

        FacileBtn.UseVisualStyleBackColor = True
        MedioBtn.UseVisualStyleBackColor = True
        DiffBtn.UseVisualStyleBackColor = False

        FacileBtn.Enabled = True
        MedioBtn.Enabled = True
        DiffBtn.Enabled = False
        Gioco.AudioPlayer(5)
    End Sub
End Class
