Imports System.IO

Module CodeJeu
    Dim path As String
    Dim sol() As String = {"./sol1.txt", "./sol2.txt", "./sol3.txt", "./sol4.txt"}
    Dim elementAleatoire As String

    Function choixSol() As String
        elementAleatoire = sol(New Random().Next(sol.Length))
        Return elementAleatoire
    End Function
    Sub ajout(File As File, t(,) As Jeu.Sudoku, chemin As String)
        Dim lignes() As String = File.ReadLines(chemin).ToArray()
        Dim rows As Integer = t.GetLength(0)
        Dim cols As Integer = t.GetLength(1)
        Dim cpt As Integer = 0

        For i As Integer = 0 To lignes.Length - 1
            If i < rows Then
                For j As Integer = 0 To cols - 1
                    t(j, i).Text = lignes(cpt)
                    t(j, i).ReadOnly = True
                    cpt = cpt + 1
                Next
            End If
        Next
    End Sub

    Sub SupprimerCasesAleatoires(t(,) As Jeu.Sudoku, ByVal nbCases As Integer)
        Dim random As New Random()
        Dim totalCases As Integer = t.GetLength(0) * t.GetLength(1)
        Dim casessupp As Integer = 0
        While casessupp < nbCases

            Dim l As Integer = random.Next(t.GetLength(0))
            Dim c As Integer = random.Next(t.GetLength(1))


            If t(l, c).Text <> "" Then

                t(l, c).Text = ""
                t(l, c).ReadOnly = False
                casessupp += 1
            End If
        End While
    End Sub

    Sub Verif(tab(,) As Jeu.Sudoku, tb As Jeu.Sudoku, x As Integer, y As Integer)
        ' Vérification des lignes et colonnes'
        Dim var As Boolean = False
        For i As Integer = 0 To 8
            If i <> x Then
                If tab(i, y).Text = tab(x, y).Text Then
                    var = True
                    Exit For
                End If

            End If
        Next
        For z As Integer = 0 To 8
            If z <> y Then
                If tab(x, z).Text = tab(x, y).Text Then
                    var = True
                    Exit For
                End If
            End If

        Next
        Dim startRow As Integer = (x \ 3) * 3
        Dim startCol As Integer = (y \ 3) * 3

        ' Vérification de la sous-grille 3x3
        For i As Integer = startRow To startRow + 2
            For j As Integer = startCol To startCol + 2
                If i <> x Or j <> y Then
                    If tab(i, j).Text = tab(x, y).Text Then
                        var = True
                        Exit For
                    End If
                End If
            Next
            If var Then Exit For
        Next
        If var = False Then
            tb.ForeColor = Color.Black

        Else
            tb.ForeColor = Color.Red

        End If

    End Sub




    Sub Aider(tab(,) As Jeu.Sudoku, tb As Jeu.Sudoku, x As Integer, y As Integer)
        ' Réinitialiser les couleurs de fond
        For i As Integer = 0 To 8
            tab(i, y).BackColor = Color.White
            tab(x, i).BackColor = Color.White
        Next
        For i As Integer = (x \ 3) * 3 To (x \ 3) * 3 + 2
            For j As Integer = (y \ 3) To (y \ 3) * 3 + 2
                tab(i, j).BackColor = Color.White
            Next
        Next

        ' Vérification des lignes et colonnes
        Dim var As Boolean = False
        For i As Integer = 0 To 8
            If i <> x AndAlso tab(i, y).Text = tab(x, y).Text Then
                var = True
                tab(i, y).BackColor = Color.Red
                tb.BackColor = Color.Red
            End If
        Next
        For z As Integer = 0 To 8
            If z <> y AndAlso tab(x, z).Text = tab(x, y).Text Then
                var = True
                tab(x, z).BackColor = Color.Red
                tb.BackColor = Color.Red
            End If
        Next

        ' Vérification de la sous-grille 3x3
        Dim startRow As Integer = (x \ 3) * 3
        Dim startCol As Integer = (y \ 3) * 3
        For i As Integer = startRow To startRow + 2
            For j As Integer = startCol To startCol + 2
                If (i <> x OrElse j <> y) AndAlso tab(i, j).Text = tab(x, y).Text Then
                    var = True
                    tab(i, j).BackColor = Color.Red
                    tb.BackColor = Color.Red
                End If
            Next
        Next
        If Not var Then
            tb.BackColor = Color.White
        End If
    End Sub

    Function FinJeu(tab(,) As Jeu.Sudoku) As Boolean
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If tab(i, j).Text = "" OrElse tab(i, j).ForeColor = Color.Red Then
                    Return False

                End If
            Next

        Next
        Return True
    End Function




End Module