Public Class mainMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelezionaNave.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player.Show()
        Nemico.Show()
    End Sub
End Class
