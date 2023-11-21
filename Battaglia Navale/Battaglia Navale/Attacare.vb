Public Class Attacare

    Public Shared Sub Turni()
        Dim turno As Short = 0


    End Sub

    Public Shared Function Attack(x As Integer, y As Integer, receiver(,) As Short)
        If receiver(x, y) = 1 Then 'Se è piena
            receiver(x, y) = 2 'Imposta la casella a distrutta
            Player.UpdatePlayer()
            Nemico.UpdateEnemy()
        ElseIf receiver(x, y) = 0 Then 'Se è vuota
            receiver(x, y) = 3 'Imposta la casella a splash
        End If
        Return 0
    End Function


End Class
