

Public Class Impostazioni

    Public colore As Integer
    Public pedina As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RossoB_Click(sender As Object, e As EventArgs) Handles RossoB.Click
        colore = 1

        RossoB.Enabled = False
        GialloB.Enabled = True
        BluB.Enabled = True
        VerdeB.Enabled = True
        BiancoB.Enabled = True
    End Sub

    Private Sub GialloB_Click(sender As Object, e As EventArgs) Handles GialloB.Click
        colore = 2

        RossoB.Enabled = True
        GialloB.Enabled = False
        BluB.Enabled = True
        VerdeB.Enabled = True
        BiancoB.Enabled = True
    End Sub

    Private Sub BluB_Click(sender As Object, e As EventArgs) Handles BluB.Click
        colore = 3

        RossoB.Enabled = True
        GialloB.Enabled = True
        BluB.Enabled = False
        VerdeB.Enabled = True
        BiancoB.Enabled = True
    End Sub

    Private Sub VerdeB_Click(sender As Object, e As EventArgs) Handles VerdeB.Click
        colore = 4

        RossoB.Enabled = True
        GialloB.Enabled = True
        BluB.Enabled = True
        VerdeB.Enabled = False
        BiancoB.Enabled = True
    End Sub

    Private Sub BiancoB_Click(sender As Object, e As EventArgs) Handles BiancoB.Click
        colore = 0

        RossoB.Enabled = True
        GialloB.Enabled = True
        BluB.Enabled = True
        VerdeB.Enabled = True
        BiancoB.Enabled = False
    End Sub

    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Pedina1_Click(sender As Object, e As EventArgs) Handles Pedina1.Click
        pedina = 0

        Pedina1.Enabled = False
        Pedina2.Enabled = True
        Pedina3.Enabled = True
        Pedina4.Enabled = True
    End Sub

    Private Sub Pedina2_Click(sender As Object, e As EventArgs) Handles Pedina2.Click
        pedina = 1

        Pedina1.Enabled = True
        Pedina2.Enabled = False
        Pedina3.Enabled = True
        Pedina4.Enabled = True
    End Sub

    Private Sub Pedina3_Click(sender As Object, e As EventArgs) Handles Pedina3.Click
        pedina = 2

        Pedina1.Enabled = True
        Pedina2.Enabled = True
        Pedina3.Enabled = False
        Pedina4.Enabled = True
    End Sub

    Private Sub Pedina4_Click(sender As Object, e As EventArgs) Handles Pedina4.Click
        pedina = 3

        Pedina1.Enabled = True
        Pedina2.Enabled = True
        Pedina3.Enabled = True
        Pedina4.Enabled = False
    End Sub
End Class