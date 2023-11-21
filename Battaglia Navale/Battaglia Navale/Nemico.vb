Public Class Nemico
    Public naviNemico() As Short = {2, 2, 1, 1} '1° = 1 casella; 2° = 2 caselle; 3° = 3 caselle; 4° = 4 caselle.
    Public grigliaNemico(4, 4) As Short '0 = vuoto; 1 = pieno; 2 = Colpito
    Public caselle As PictureBox(,) = New PictureBox(,) {{a1, a2, a3, a4, a5}, {a6, a7, a8, a9, a10}, {a11, a12, a13, a14, a15}, {a16, a17, a18, a19, a20}, {a21, a22, a23, a24, a25}}

    Dim cordX As Integer
    Dim cordY As Integer

    Dim tentativiMax As Integer = 13 ' Imposta il numero massimo di tentativi per posizionare le navi
    Dim tentativi As Integer = 0 ' Conta il numero di tentativi effettuati
    Dim piazzato As Boolean ' Indica se una nave è stata posizionata
    Dim indice As Integer = 0 ' Indica l'indice dell'array naviNemico
    Dim lunghezza As Integer ' Indica la lunghezza della nave
    Dim orientazione As String ' Indica l'orientamento della nave
    Dim x As Integer ' Indica la coordinata x 
    Dim y As Integer ' Indica la coordinata y 


    Private Sub Nemico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While indice <= naviNemico.Length And tentativi < tentativiMax ' Finché ci sono navi da posizionare e non si supera il limite di tentativi
            piazzato = False ' Inizializza piazzato a False
            lunghezza = naviNemico(indice) ' Prende la lunghezza della nave corrente dall'array naviNemico
            orientazione = ChooseRandomorientazione() ' Sceglie un orientamento casuale tra "H" e "V"
            x = ChooseRandomCoordinate()
            y = ChooseRandomCoordinate()

            piazzato = Player.PlaceShip(lunghezza, orientazione, x, y, Me.grigliaNemico) ' Prova a posizionare la nave nella griglia

            If piazzato Then ' Se la nave è stata posizionata con successo
                indice += 1 ' Passa alla prossima nave nell'array ships
            End If

            tentativi += 1

        End While

        UpdateEnemy()
    End Sub

    Function ChooseRandomorientazione() As String
        Dim rnd As New Random() ' Crea un oggetto Random per generare numeri casuali
        Dim num As Integer = rnd.Next(1, 3) ' Genera un numero casuale tra 1 e 2

        If num = 1 Then
            Return "H" ' Restituisce "H" come orientamento orizzontale
        Else
            Return "V" ' Restituisce "V" come orientamento verticale
        End If

    End Function

    Function ChooseRandomCoordinate() As Integer
        Dim rnd As New Random()
        Dim num As Integer = rnd.Next(0, 5)

        Return num ' Restituisce il numero come coordinata

    End Function



    Public Sub UpdateEnemy() 'Aggiorna la grafica e le variabili del giocatore ogni volta che viene chiamato
        Dim caselle As PictureBox(,) = New PictureBox(,) {{a1, a2, a3, a4, a5}, {a6, a7, a8, a9, a10}, {a11, a12, a13, a14, a15}, {a16, a17, a18, a19, a20}, {a21, a22, a23, a24, a25}}

        For i = 0 To 4
            For j = 0 To 4
                If grigliaNemico(i, j) = 1 Then
                    caselle(i, j).BackColor = Color.Red
                ElseIf grigliaNemico(i, j) = 2 Then
                    caselle(i, j).BackColor = Color.Blue
                    caselle(i, j).Enabled = False
                End If
            Next
        Next
    End Sub

    Public Sub ComunicateAttack()
        Attacare.Attack(cordX, cordY, Me.grigliaNemico)
    End Sub

#Region "Click"
    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        cordY = 0
        cordX = 0

        ComunicateAttack()
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        cordY = 1
        cordX = 0

        ComunicateAttack()
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        cordY = 2
        cordX = 0

        ComunicateAttack()
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        cordY = 3
        cordX = 0

        ComunicateAttack()
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        cordY = 4
        cordX = 0

        ComunicateAttack()
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        cordY = 0
        cordX = 1

        ComunicateAttack()
    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        cordY = 1
        cordX = 1

        ComunicateAttack()
    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        cordY = 2
        cordX = 1

        ComunicateAttack()
    End Sub

    Private Sub a9_Click(sender As Object, e As EventArgs) Handles a9.Click
        cordY = 3
        cordX = 1

        ComunicateAttack()
    End Sub

    Private Sub a10_Click(sender As Object, e As EventArgs) Handles a10.Click
        cordY = 4
        cordX = 1

        ComunicateAttack()
    End Sub

    Private Sub a11_Click(sender As Object, e As EventArgs) Handles a11.Click
        cordY = 0
        cordX = 2

        ComunicateAttack()
    End Sub

    Private Sub a12_Click(sender As Object, e As EventArgs) Handles a12.Click
        cordY = 1
        cordX = 2

        ComunicateAttack()
    End Sub

    Private Sub a13_Click(sender As Object, e As EventArgs) Handles a13.Click
        cordY = 2
        cordX = 2

        ComunicateAttack()
    End Sub

    Private Sub a14_Click(sender As Object, e As EventArgs) Handles a14.Click
        cordY = 3
        cordX = 2

        ComunicateAttack()
    End Sub

    Private Sub a15_Click(sender As Object, e As EventArgs) Handles a15.Click
        cordY = 4
        cordX = 2

        ComunicateAttack()
    End Sub

    Private Sub a16_Click(sender As Object, e As EventArgs) Handles a16.Click
        cordY = 0
        cordX = 3

        ComunicateAttack()
    End Sub

    Private Sub a17_Click(sender As Object, e As EventArgs) Handles a17.Click
        cordY = 1
        cordX = 3

        ComunicateAttack()
    End Sub

    Private Sub a18_Click(sender As Object, e As EventArgs) Handles a18.Click
        cordY = 2
        cordX = 3

        ComunicateAttack()
    End Sub

    Private Sub a19_Click(sender As Object, e As EventArgs) Handles a19.Click
        cordY = 3
        cordX = 3

        ComunicateAttack()
    End Sub

    Private Sub a20_Click(sender As Object, e As EventArgs) Handles a20.Click
        cordY = 4
        cordX = 3

        ComunicateAttack()
    End Sub

    Private Sub a21_Click(sender As Object, e As EventArgs) Handles a21.Click
        cordY = 0
        cordX = 4

        ComunicateAttack()
    End Sub

    Private Sub a22_Click(sender As Object, e As EventArgs) Handles a22.Click
        cordY = 1
        cordX = 4

        ComunicateAttack()
    End Sub

    Private Sub a23_Click(sender As Object, e As EventArgs) Handles a23.Click
        cordY = 2
        cordX = 4

        ComunicateAttack()
    End Sub

    Private Sub a24_Click(sender As Object, e As EventArgs) Handles a24.Click
        cordY = 3
        cordX = 4

        ComunicateAttack()
    End Sub

    Private Sub a25_Click(sender As Object, e As EventArgs) Handles a25.Click
        cordY = 4
        cordX = 4

        ComunicateAttack()
    End Sub
#End Region

End Class