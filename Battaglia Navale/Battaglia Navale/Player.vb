Public Class Player

    Public Navi() As Short = {2, 2, 1, 1} '1° = 1 casella; 2° = 2 caselle; 3° = 3 caselle; 4° = 4 caselle.

    Dim intCaselle(5, 5) As Integer
    Dim caselle = New Object(,) {{a1, a2, a3, a4, a5}, {a6, a7, a8, a9, a10}, {a11, a12, a13, a14, a15}, {a16, a17, a18, a19, a20}, {a21, a22, a23, a24, a25}}
    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Function PiazzaNavi(Posizione As Short)


        Return Posizione
    End Function
End Class