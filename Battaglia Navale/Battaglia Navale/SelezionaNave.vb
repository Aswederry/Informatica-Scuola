Public Class SelezionaNave
    Dim lunghezzaClick As Boolean = False

    Private Sub SelezionaNave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bottoni As Button() = {b1, b2, b3, b4}
        Dim testoQt As Label() = {qt1, qt2, qt3, qt4}

        For i = 0 To 3
            testoQt(i).Text = "x " + CStr(Player.Navi(i))
        Next

        For i = 0 To bottoni.Length - 1
            If Player.Navi(i) = 0 Then
                bottoni(i).Enabled = False
                bottoni(i).Text = "Navi Finite"
            End If
        Next
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Dim bottoni() As Button = {b1, b2, b3, b4}

        Player.lunghezza = 1
        If Player.orientazione <> "naN" Then
            Button1.Enabled = True
        End If
        lunghezzaClick = True

        b1.Enabled = False
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True

        For i = 0 To 3
            If Player.Navi(i) <= 0 Then
                bottoni(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Dim bottoni() As Button = {b1, b2, b3, b4}

        Player.lunghezza = 2
        If Player.orientazione <> "naN" Then
            Button1.Enabled = True
        End If
        lunghezzaClick = True

        b1.Enabled = True
        b2.Enabled = False
        b3.Enabled = True
        b4.Enabled = True

        For i = 0 To 3
            If Player.Navi(i) <= 0 Then
                bottoni(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Dim bottoni() As Button = {b1, b2, b3, b4}

        Player.lunghezza = 3
        If Player.orientazione <> "naN" Then
            Button1.Enabled = True
        End If
        lunghezzaClick = True

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = False
        b4.Enabled = True

        For i = 0 To 3
            If Player.Navi(i) <= 0 Then
                bottoni(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Dim bottoni() As Button = {b1, b2, b3, b4}

        Player.lunghezza = 4
        If Player.orientazione <> "naN" Then
            Button1.Enabled = True
        End If
        lunghezzaClick = True


        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = False

        For i = 0 To 3
            If Player.Navi(i) <= 0 Then
                bottoni(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub H_Click(sender As Object, e As EventArgs) Handles H.Click
        Player.orientazione = "V"
        H.Enabled = False
        V.Enabled = True

        If lunghezzaClick = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub V_Click(sender As Object, e As EventArgs) Handles V.Click
        Player.orientazione = "H"
        V.Enabled = False
        H.Enabled = True

        If lunghezzaClick = True Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player.PlaceShip(Player.lunghezza, Player.orientazione, Player.cordX, Player.cordY, Player.griglia)
        Player.UpdatePlayer()
        Player.Navi(Player.lunghezza - 1) -= 1

        Me.Close()
    End Sub
End Class