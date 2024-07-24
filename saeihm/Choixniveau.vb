Public Class Choixniveau
    Private Sub btnfacile_Click(sender As Object, e As EventArgs) Handles btnfacile.Click
        Jeu.nbcase = 44
        Me.Close()
        Jeu.Show()
        Jeu.Timer1.Start()
        Jeu.targetTime = DateTime.Now.AddMinutes(7)
        Jeu.lbl_nj.Text = Acceuil.cb_nomjouer.Text
    End Sub


    Private Sub btnmoyen_Click(sender As Object, e As EventArgs) Handles btnmoyen.Click
        Jeu.nbcase = 52
        Me.Close()
        Jeu.Show()
        Jeu.Timer1.Start()
        Jeu.targetTime = DateTime.Now.AddMinutes(7)
        Jeu.lbl_nj.Text = Acceuil.cb_nomjouer.Text
    End Sub

    Private Sub btndifficile_Click(sender As Object, e As EventArgs) Handles btndifficile.Click
        Jeu.nbcase = 56
        Me.Close()
        Jeu.Show()
        Jeu.Timer1.Start()
        Jeu.targetTime = DateTime.Now.AddMinutes(7)
        Jeu.lbl_nj.Text = Acceuil.cb_nomjouer.Text
    End Sub


End Class