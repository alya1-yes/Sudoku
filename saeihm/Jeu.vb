Imports System.IO

Public Class Jeu
    Public nbcase As Integer
    Public targetTime As DateTime
    Dim click As Integer = 0
    Dim pauseTime As DateTime

    Public Class Sudoku
        Inherits TextBox

        Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
            MyBase.OnKeyPress(e)
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = " " Or e.KeyChar = ChrW(8) Then

                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub



    End Class

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim timeLeft As TimeSpan = targetTime - DateTime.Now
        lbl_temps.Text = timeLeft.ToString("mm\:ss")
        Dim var As Boolean = CodeJeu.FinJeu(cell)
        EnregistrementJ.enregistrerVal(var, timeLeft)


        ' Vérifie si le temps est écoulé
        If timeLeft.TotalSeconds <= 0 Then
            Timer1.Enabled = False
            lbl_temps.Text = "Temps ecoule!"
            MsgBox("Vous avez perdu !")

        End If

        If timeLeft.Minutes <= 1 Then
            lbl_temps.ForeColor = Color.DarkRed
        End If

    End Sub

    Dim cell(0 To 8, 0 To 8) As Sudoku
    Dim tableausol(0 To 8, 0 To 8) As Sudoku

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbl_nj.Text = Acceuil.cb_nomjouer.Text

        For x As Integer = 0 To 8
            Dim xmax As Integer = 0
            Dim ymax As Integer = 0

            For y As Integer = 0 To 8
                cell(x, y) = New Sudoku()
                tableausol(x, y) = New Sudoku()
                cell(x, y).Name = $"cell_{x}_{y}" ' Assigner un nom unique à chaque cellule
                cell(x, y).Text = ""
                cell(x, y).Width = 20
                cell(x, y).Height = 20
                cell(x, y).MaxLength = 1
                cell(x, y).TextAlign = HorizontalAlignment.Center
                tableausol(x, y).Text = ""
                tableausol(x, y).Width = 80
                tableausol(x, y).Height = 80
                tableausol(x, y).MaxLength = 1
                AddHandler cell(x, y).TextChanged, AddressOf Cell_TextChanged

                If x > 2 Then
                    xmax = 4
                End If
                If x > 5 Then
                    xmax = 8
                End If

                If y > 2 Then
                    ymax = 4
                End If
                If y > 5 Then
                    ymax = 8
                End If
                cell(x, y).Location = New Point(250 + x * 20 + xmax, 80 + y * 20 + ymax)

                Me.Controls.Add(cell(x, y))

            Next
        Next

        Dim Fichier As File
        Dim i As String = choixSol()
        CodeJeu.ajout(Fichier, cell, i)
        CodeJeu.ajout(Fichier, tableausol, i)
        CodeJeu.SupprimerCasesAleatoires(cell, nbcase)
    End Sub

    Private Sub Cell_TextChanged(sender As Object, e As EventArgs)
        ' Convertit l'expéditeur en objet Sudoku
        Dim tb As Sudoku = DirectCast(sender, Sudoku)

        ' Récupère la position x et y à partir du nom de la cellule (supposé formaté comme "cell_x_y")
        Dim pos() As String = tb.Name.Split("_"c)
        Dim x As Integer = Convert.ToInt32(pos(1))
        Dim y As Integer = Convert.ToInt32(pos(2))

        CodeJeu.Verif(cell, tb, x, y)

    End Sub

    Private Sub btn_abondon_Click(sender As Object, e As EventArgs) Handles btn_abondon.Click
        Dim m As MsgBoxResult = MsgBox("Voulez-vous vraiment abandonner ?", MsgBoxStyle.YesNo)
        If m = vbYes Then
            Me.Close()
            Acceuil.Show()
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click

        Dim pause As TimeSpan

        click += 1
        If click Mod 2 = 0 Then
            Timer1.Stop()
            btnPause.Text = "| |"
            Dim pauseDuration As TimeSpan = DateTime.Now - pauseTime
            targetTime = targetTime.Add(pauseDuration)
        Else
            pauseTime = DateTime.Now
            Timer1.Start()
            btnPause.Text = "ᐅ"

        End If

    End Sub

    Private Sub btnaide_Click(sender As Object, e As EventArgs) Handles btnaide.Click
        ' Convertit l'expéditeur en objet Sudoku

        For I As Integer = 0 To 8
            For J As Integer = 0 To 8
                CodeJeu.Aider(cell, cell(I, J), I, J)
            Next
        Next

    End Sub

End Class
