Public Class Classifica
    Dim scoresFile() As String = System.IO.File.ReadAllLines(Application.StartupPath & "Resources\Classifica.txt", System.Text.Encoding.ASCII)

    Dim namesArray(10) As String
    Dim namesArrayControl() As Label = {N1, N2, N3, N4, N5, N6, N7, N8, N9, N10}
    Dim scoreArray(10) As Integer
    Dim scoreArrayControl() As Label = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10}
    Private Sub Classifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadScores()
        UpdateUi()
    End Sub


    Private Sub LoadScores()
        For i = 1 To 10
            scoreArray(i - 1) = scoresFile(i)
            namesArray(i - 1) = scoresFile(i * 2)
        Next

        BubbleSort(scoreArray)
    End Sub

    Private Sub UpdateUi()
        Dim scoreArrayControl() As Label = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10}
        For i = 0 To 9
            scoreArrayControl(i).Text = scoreArray(i)
        Next
    End Sub

    Private Sub BubbleSort(a() As Integer)
        Dim c As New Integer

        For i = 0 To a.Length - 2
            For j = i + 1 To a.Length - 1
                If a(i) < a(j) Then
                    c = a(i)
                    a(i) = a(j)
                    a(j) = c
                End If
            Next
        Next
    End Sub
End Class