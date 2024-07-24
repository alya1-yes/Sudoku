<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recapitulatifvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recapitulatifvb))
        Me.lb_nom = New System.Windows.Forms.ListBox()
        Me.lb_score = New System.Windows.Forms.ListBox()
        Me.cb_rech = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_nom
        '
        Me.lb_nom.FormattingEnabled = True
        Me.lb_nom.ItemHeight = 16
        Me.lb_nom.Location = New System.Drawing.Point(187, 178)
        Me.lb_nom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(179, 116)
        Me.lb_nom.TabIndex = 0
        '
        'lb_score
        '
        Me.lb_score.FormattingEnabled = True
        Me.lb_score.ItemHeight = 16
        Me.lb_score.Location = New System.Drawing.Point(383, 178)
        Me.lb_score.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lb_score.Name = "lb_score"
        Me.lb_score.Size = New System.Drawing.Size(183, 116)
        Me.lb_score.TabIndex = 1
        '
        'cb_rech
        '
        Me.cb_rech.FormattingEnabled = True
        Me.cb_rech.Location = New System.Drawing.Point(245, 89)
        Me.cb_rech.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_rech.Name = "cb_rech"
        Me.cb_rech.Size = New System.Drawing.Size(121, 24)
        Me.cb_rech.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Joueurs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Meilleurs temps en (s)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Acceui"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Recapitulatifvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_rech)
        Me.Controls.Add(Me.lb_score)
        Me.Controls.Add(Me.lb_nom)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Recapitulatifvb"
        Me.Text = "Recapitulatifvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_nom As ListBox
    Friend WithEvents lb_score As ListBox
    Friend WithEvents cb_rech As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
