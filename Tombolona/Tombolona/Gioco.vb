Public Class Gioco

    Dim NumeriEstratti(90) As Integer



    Private Sub EstraiB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstraiB.Click

        NeL.Text = NumeroEstratto()

    End Sub

    Private Function NumeroEstratto() As Integer
        Dim r As New Random
        Dim fatto As Boolean = False
        NumeroEstratto = 0

        While fatto = False

            NumeroEstratto = r.Next(1, 91)
            If NumeroEstratto = NumeriEstratti(NumeroEstratto - 1) Then
                fatto = False
            Else
                fatto = True
                NumeriEstratti(NumeroEstratto - 1) = NumeroEstratto
            End If

        End While

        Return NumeroEstratto
    End Function

    Private Sub Gioco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class