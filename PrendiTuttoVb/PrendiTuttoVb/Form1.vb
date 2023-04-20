Public Class Form1
    Dim Images As Image(,) = New Image(,) {{My.Resources.Asso1}, {My.Resources.Asso2}, {My.Resources.Asso3}, {My.Resources.Asso4}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As New Random
        Dim b As Integer

        b = a.Next(0, 4)

        test.BackgroundImage = Images(b, 0)
    End Sub
End Class
