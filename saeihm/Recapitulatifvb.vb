Public Class Recapitulatifvb

    Private Sub synchroniser(index As Integer)
        lb_nom.SelectedIndex = index
        lb_score.SelectedIndex = index
        cb_rech.SelectedIndex = index
    End Sub

    Private Sub lb_nom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_nom.SelectedIndexChanged

        synchroniser(lb_nom.SelectedIndex)

    End Sub
    Private Sub lb_score_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_score.SelectedIndexChanged

        synchroniser(lb_score.SelectedIndex)

    End Sub
    Private Sub cb_rech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_rech.SelectedIndexChanged

        synchroniser(cb_rech.SelectedIndex)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Acceuil.Show()

    End Sub
End Class