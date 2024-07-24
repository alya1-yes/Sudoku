<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceuil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceuil))
        Me.cb_nomjouer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_lancer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_quiter = New System.Windows.Forms.Button()
        Me.btn_score = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_nomjouer
        '
        Me.cb_nomjouer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_nomjouer.FormattingEnabled = True
        Me.cb_nomjouer.Location = New System.Drawing.Point(405, 217)
        Me.cb_nomjouer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_nomjouer.Name = "cb_nomjouer"
        Me.cb_nomjouer.Size = New System.Drawing.Size(245, 32)
        Me.cb_nomjouer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 40.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(261, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 82)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SUDOKU"
        '
        'btn_lancer
        '
        Me.btn_lancer.Font = New System.Drawing.Font("ROG Fonts", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lancer.Location = New System.Drawing.Point(275, 359)
        Me.btn_lancer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_lancer.Name = "btn_lancer"
        Me.btn_lancer.Size = New System.Drawing.Size(273, 52)
        Me.btn_lancer.TabIndex = 2
        Me.btn_lancer.Text = "JOUER"
        Me.btn_lancer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(143, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saisissez votre nom :"
        '
        'btn_quiter
        '
        Me.btn_quiter.Font = New System.Drawing.Font("ROG Fonts", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quiter.Location = New System.Drawing.Point(665, 348)
        Me.btn_quiter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_quiter.Name = "btn_quiter"
        Me.btn_quiter.Size = New System.Drawing.Size(113, 23)
        Me.btn_quiter.TabIndex = 5
        Me.btn_quiter.Text = "QUITTER"
        Me.btn_quiter.UseVisualStyleBackColor = True
        '
        'btn_score
        '
        Me.btn_score.Font = New System.Drawing.Font("ROG Fonts", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_score.Location = New System.Drawing.Point(665, 389)
        Me.btn_score.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_score.Name = "btn_score"
        Me.btn_score.Size = New System.Drawing.Size(113, 23)
        Me.btn_score.TabIndex = 6
        Me.btn_score.Text = "SCORE"
        Me.btn_score.UseVisualStyleBackColor = True
        '
        'Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1007, 478)
        Me.Controls.Add(Me.btn_score)
        Me.Controls.Add(Me.btn_quiter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_lancer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_nomjouer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Acceuil"
        Me.Text = "Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_nomjouer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_lancer As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_quiter As Button
    Friend WithEvents btn_score As Button
End Class
