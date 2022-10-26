Public Class Form1
    Private Sub Inizio_Click(sender As Object, e As EventArgs) Handles Inizio.Click
        Gioco.Show()
        Me.Hide()
    End Sub

    Private Sub RegoleB_Click(sender As Object, e As EventArgs) Handles RegoleB.Click
        Regole.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Impostazioni.Show()
    End Sub
End Class
