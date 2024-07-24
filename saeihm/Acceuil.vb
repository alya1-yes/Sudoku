Public Class Acceuil

    Private Sub btn_quiter_Click(sender As Object, e As EventArgs) Handles btn_quiter.Click
        Dim m As MsgBoxResult = MsgBox("Etes vous sur ?", MsgBoxStyle.YesNo)
        If m = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub btn_lancer_Click(sender As Object, e As EventArgs) Handles btn_lancer.Click

        If cb_nomjouer.Text.Equals("") Then
            MsgBox("Entrez un nom pour continuez", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.Hide()
        Choixniveau.Show()

    End Sub

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_score_Click(sender As Object, e As EventArgs) Handles btn_score.Click
        For i As Integer = 0 To nbPers - 1
            If (Recapitulatifvb.lb_nom.Items.Contains(EnregistrementJ.TabJ(i).Nom) = False) Then
                Recapitulatifvb.lb_nom.Items.Add(EnregistrementJ.TabJ(i).Nom)
                Recapitulatifvb.lb_score.Items.Add(EnregistrementJ.TabJ(i).MeilleurTmp)
                Recapitulatifvb.cb_rech.Items.Add(EnregistrementJ.TabJ(i).Nom)
            End If
        Next
        Me.Hide()
        Recapitulatifvb.Show()
    End Sub


End Class