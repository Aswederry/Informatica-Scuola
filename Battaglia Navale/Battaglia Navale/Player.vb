﻿Public Class Player
#Region "Variabili"
    Public Navi() As Short = {2, 2, 1, 1} '1° = 1 casella; 2° = 2 caselle; 3° = 3 caselle; 4° = 4 caselle.
    Public griglia(4, 4) As Short '0 = Vuoto; 1 = Pieno; 2 = Colpito
    Public caselle As PictureBox(,) = New PictureBox(,) {{a1, a2, a3, a4, a5}, {a6, a7, a8, a9, a10}, {a11, a12, a13, a14, a15}, {a16, a17, a18, a19, a20}, {a21, a22, a23, a24, a25}}
#End Region

#Region "Variabili Per Posizionamento Navi"
    Public lunghezza As Integer ' Massimo 4; Minimo 1
    Public orientazione As String = "naN" 'H = horizzontale; V = Verticale
    Public cordX As Integer 'Iniziano da 0 e arriva a 4
    Public cordY As Integer
#End Region

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inizializza a false
        For i = 0 To 4
            For j = 0 To 4
                griglia(i, j) = False
            Next
        Next

        Attacare.Turni()
    End Sub

    Public Function PlaceShip(lunghezza As Integer, orientazione As String, x As Integer, y As Integer, griglia(,) As Short) As Boolean
        If lunghezza < 1 Or lunghezza > 5 Then 'Check se la lunghezza è possibile
            Return False
            If orientazione <> “H” And orientazione <> “V” Then 'Check se l'orientazione è possibile
                Return False
                If x < 0 Or x > 4 Or y < 0 Or y > 4 Then 'Check se le coordinate sono possibili
                    Return False
                End If
            End If
        End If

        If orientazione = "H" Then ' Se la nave è orizzontale
            If x + lunghezza - 1 > 4 Then Return False ' Check se la nave esce dal bordo destro
            For i = x To x + lunghezza - 1 ' Per ogni casella della nave
                If griglia(i, y) = 1 Then Return False ' Check se la casella è già occupata da un'altra nave
            Next
        Else ' Se la nave è verticale
            If y + lunghezza - 1 > 4 Then Return False ' Check se la nave esce dal bordo inferiore
            For i = y To y + lunghezza - 1 ' Per ogni casella della nave
                If griglia(x, i) = 1 Then Return False ' Check se la casella è già occupata da un'altra nave
            Next
        End If

        ' Imposta a True le celle corrispondenti alla nave
        If orientazione = "H" Then ' Se la nave è orizzontale
            For i = x To x + lunghezza - 1 ' Per ogni casella della nave
                griglia(i, y) = 1
            Next
        Else ' Se la nave è verticale
            For i = y To y + lunghezza - 1 ' Per ogni casella della nave
                griglia(x, i) = 1
            Next
        End If



    End Function

    Public Sub UpdatePlayer() 'Aggiorna la grafica e le variabili del giocatore ogni volta che viene chiamato
        Dim caselle As PictureBox(,) = New PictureBox(,) {{a1, a2, a3, a4, a5}, {a6, a7, a8, a9, a10}, {a11, a12, a13, a14, a15}, {a16, a17, a18, a19, a20}, {a21, a22, a23, a24, a25}}

        For i = 0 To 4
            For j = 0 To 4
                If griglia(i, j) = 1 Then
                    caselle(i, j).BackColor = Color.Red
                    caselle(i, j).Enabled = False
                End If
            Next
        Next

        orientazione = "naN"
    End Sub

#Region "Click"
    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        SelezionaNave.Show()
        cordY = 0
        cordX = 0
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        SelezionaNave.Show()
        cordY = 1
        cordX = 0
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        SelezionaNave.Show()
        cordY = 2
        cordX = 0
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        SelezionaNave.Show()
        cordY = 3
        cordX = 0
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        SelezionaNave.Show()
        cordY = 4
        cordX = 0
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        SelezionaNave.Show()
        cordY = 0
        cordX = 1
    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        SelezionaNave.Show()
        cordY = 1
        cordX = 1
    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        SelezionaNave.Show()
        cordY = 2
        cordX = 1
    End Sub

    Private Sub a9_Click(sender As Object, e As EventArgs) Handles a9.Click
        SelezionaNave.Show()
        cordY = 3
        cordX = 1
    End Sub

    Private Sub a10_Click(sender As Object, e As EventArgs) Handles a10.Click
        SelezionaNave.Show()
        cordY = 4
        cordX = 1
    End Sub

    Private Sub a11_Click(sender As Object, e As EventArgs) Handles a11.Click
        SelezionaNave.Show()
        cordY = 0
        cordX = 2
    End Sub

    Private Sub a12_Click(sender As Object, e As EventArgs) Handles a12.Click
        SelezionaNave.Show()
        cordY = 1
        cordX = 2
    End Sub

    Private Sub a13_Click(sender As Object, e As EventArgs) Handles a13.Click
        SelezionaNave.Show()
        cordY = 2
        cordX = 2
    End Sub

    Private Sub a14_Click(sender As Object, e As EventArgs) Handles a14.Click
        SelezionaNave.Show()
        cordY = 3
        cordX = 2
    End Sub

    Private Sub a15_Click(sender As Object, e As EventArgs) Handles a15.Click
        SelezionaNave.Show()
        cordY = 4
        cordX = 2
    End Sub

    Private Sub a16_Click(sender As Object, e As EventArgs) Handles a16.Click
        SelezionaNave.Show()
        cordY = 0
        cordX = 3
    End Sub

    Private Sub a17_Click(sender As Object, e As EventArgs) Handles a17.Click
        SelezionaNave.Show()
        cordY = 1
        cordX = 3
    End Sub

    Private Sub a18_Click(sender As Object, e As EventArgs) Handles a18.Click
        SelezionaNave.Show()
        cordY = 2
        cordX = 3
    End Sub

    Private Sub a19_Click(sender As Object, e As EventArgs) Handles a19.Click
        SelezionaNave.Show()
        cordY = 3
        cordX = 3
    End Sub

    Private Sub a20_Click(sender As Object, e As EventArgs) Handles a20.Click
        SelezionaNave.Show()
        cordY = 4
        cordX = 3
    End Sub

    Private Sub a21_Click(sender As Object, e As EventArgs) Handles a21.Click
        SelezionaNave.Show()
        cordY = 0
        cordX = 4
    End Sub

    Private Sub a22_Click(sender As Object, e As EventArgs) Handles a22.Click
        SelezionaNave.Show()
        cordY = 1
        cordX = 4
    End Sub

    Private Sub a23_Click(sender As Object, e As EventArgs) Handles a23.Click
        SelezionaNave.Show()
        cordY = 2
        cordX = 4
    End Sub

    Private Sub a24_Click(sender As Object, e As EventArgs) Handles a24.Click
        SelezionaNave.Show()
        cordY = 3
        cordX = 4
    End Sub

    Private Sub a25_Click(sender As Object, e As EventArgs) Handles a25.Click
        SelezionaNave.Show()
        cordY = 4
        cordX = 4
    End Sub
#End Region
End Class