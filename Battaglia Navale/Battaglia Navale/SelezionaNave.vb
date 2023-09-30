Public Class SelezionaNave
    Private Sub SelezionaNave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim buttons As Button() = {b1, b2, b3, b4}

        qt1.Text = "x " + CStr(Player.Navi(0))
        qt2.Text = "x " + CStr(Player.Navi(1))
        qt3.Text = "x " + CStr(Player.Navi(2))
        qt4.Text = "x " + CStr(Player.Navi(3))

        For i = 0 To buttons.Length - 1
            If Player.Navi(i) = 0 Then
                buttons(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click

    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click

    End Sub
End Class