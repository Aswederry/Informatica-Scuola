Public Class Form1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Gioco.Show()
        Me.Hide()
    End Sub

    Private Sub RulesButton_Click(sender As Object, e As EventArgs) Handles RulesButton.Click
        Rules.Show()
        Me.Hide()
    End Sub
End Class
