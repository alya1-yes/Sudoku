<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.btn_abondon = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_temps = New System.Windows.Forms.Label()
        Me.lbl_nj = New System.Windows.Forms.Label()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnaide = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_abondon
        '
        Me.btn_abondon.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abondon.Location = New System.Drawing.Point(346, 395)
        Me.btn_abondon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_abondon.Name = "btn_abondon"
        Me.btn_abondon.Size = New System.Drawing.Size(214, 39)
        Me.btn_abondon.TabIndex = 85
        Me.btn_abondon.Text = "ABANDONNER"
        Me.btn_abondon.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbl_temps
        '
        Me.lbl_temps.AutoSize = True
        Me.lbl_temps.BackColor = System.Drawing.Color.Transparent
        Me.lbl_temps.Font = New System.Drawing.Font("ROG Fonts", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temps.Location = New System.Drawing.Point(370, 41)
        Me.lbl_temps.Name = "lbl_temps"
        Me.lbl_temps.Size = New System.Drawing.Size(0, 28)
        Me.lbl_temps.TabIndex = 86
        '
        'lbl_nj
        '
        Me.lbl_nj.AutoSize = True
        Me.lbl_nj.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nj.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nj.ForeColor = System.Drawing.Color.Peru
        Me.lbl_nj.Location = New System.Drawing.Point(83, 91)
        Me.lbl_nj.Name = "lbl_nj"
        Me.lbl_nj.Size = New System.Drawing.Size(100, 24)
        Me.lbl_nj.TabIndex = 87
        Me.lbl_nj.Text = "Label1"
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(764, 77)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(55, 60)
        Me.btnPause.TabIndex = 88
        Me.btnPause.Text = "ᐅ"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnaide
        '
        Me.btnaide.Location = New System.Drawing.Point(759, 414)
        Me.btnaide.Name = "btnaide"
        Me.btnaide.Size = New System.Drawing.Size(75, 23)
        Me.btnaide.TabIndex = 89
        Me.btnaide.Text = "?"
        Me.btnaide.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(783, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1007, 490)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnaide)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lbl_nj)
        Me.Controls.Add(Me.lbl_temps)
        Me.Controls.Add(Me.btn_abondon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_abondon As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_temps As Label
    Friend WithEvents lbl_nj As Label
    Friend WithEvents btnPause As Button
    Friend WithEvents btnaide As Button
    Friend WithEvents Button1 As Button
End Class
