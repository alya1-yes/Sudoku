Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Module EnregistrementJ

    Public Structure Joueur
        Dim Nom As String
        Dim MeilleurTmp As Integer
        Dim PartieJouees As Integer
        Dim Tmpscumule As Integer


    End Structure
    Public TabJ(nbPers) As Joueur
    Public nbPers As Integer = 0
    Public Sub ajout(Nom As String, Mt As Integer)

        Dim j As Joueur
            j.Nom = Nom
            j.PartieJouees = 0
            j.MeilleurTmp = Mt
            j.Tmpscumule = 0
            If nbPers <= UBound(TabJ) Then
                ReDim Preserve TabJ(nbPers + 5)
                TabJ(nbPers) = j
                nbPers += 1
                j.PartieJouees += 1
            End If

    End Sub



    Public Sub enregistrerVal(b As Boolean, timeLeft As TimeSpan)
        If b = True Then
            Jeu.Timer1.Stop()
            MsgBox("Bravo tu as gagné ! ")
            Dim tmps As Integer = 420 - timeLeft.TotalSeconds


            EnregistrementJ.ajout(Jeu.lbl_nj.Text, tmps)



            For i As Integer = 0 To nbPers - 1
                If TabJ(i).Nom = Jeu.lbl_nj.Text Then
                    If tmps < TabJ(i).MeilleurTmp Then
                        TabJ(i).MeilleurTmp = tmps

                    End If
                    TabJ(i).Tmpscumule = tmps + TabJ(i).Tmpscumule
                End If
            Next



            For i As Integer = 0 To nbPers - 1
                If (Acceuil.cb_nomjouer.Items.Contains(TabJ(i).Nom) = False) Then
                    Acceuil.cb_nomjouer.Items.Add(EnregistrementJ.TabJ(i).Nom)
                End If
            Next

            Jeu.Hide()
            Acceuil.Show()

        End If
    End Sub





End Module
