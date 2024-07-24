<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choixniveau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choixniveau))
        Me.btnfacile = New System.Windows.Forms.Button()
        Me.btnmoyen = New System.Windows.Forms.Button()
        Me.btndifficile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnfacile
        '
        Me.btnfacile.BackColor = System.Drawing.Color.Transparent
        Me.btnfacile.BackgroundImage = CType(resources.GetObject("btnfacile.BackgroundImage"), System.Drawing.Image)
        Me.btnfacile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnfacile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfacile.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfacile.Location = New System.Drawing.Point(286, 82)
        Me.btnfacile.Name = "btnfacile"
        Me.btnfacile.Size = New System.Drawing.Size(163, 71)
        Me.btnfacile.TabIndex = 0
        Me.btnfacile.Text = "Facile"
        Me.btnfacile.UseVisualStyleBackColor = False
        '
        'btnmoyen
        '
        Me.btnmoyen.BackColor = System.Drawing.Color.Transparent
        Me.btnmoyen.BackgroundImage = CType(resources.GetObject("btnmoyen.BackgroundImage"), System.Drawing.Image)
        Me.btnmoyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnmoyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmoyen.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmoyen.Location = New System.Drawing.Point(286, 197)
        Me.btnmoyen.Name = "btnmoyen"
        Me.btnmoyen.Size = New System.Drawing.Size(163, 67)
        Me.btnmoyen.TabIndex = 1
        Me.btnmoyen.Text = "Moyen"
        Me.btnmoyen.UseVisualStyleBackColor = False
        '
        'btndifficile
        '
        Me.btndifficile.BackColor = System.Drawing.Color.Transparent
        Me.btndifficile.BackgroundImage = CType(resources.GetObject("btndifficile.BackgroundImage"), System.Drawing.Image)
        Me.btndifficile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndifficile.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndifficile.Location = New System.Drawing.Point(286, 321)
        Me.btndifficile.Name = "btndifficile"
        Me.btndifficile.Size = New System.Drawing.Size(163, 71)
        Me.btndifficile.TabIndex = 2
        Me.btndifficile.Text = "Difficile"
        Me.btndifficile.UseVisualStyleBackColor = False
        '
        'Choixniveau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btndifficile)
        Me.Controls.Add(Me.btnmoyen)
        Me.Controls.Add(Me.btnfacile)
        Me.Name = "Choixniveau"
        Me.Text = "Choixniveau"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnfacile As Button
    Friend WithEvents btnmoyen As Button
    Friend WithEvents btndifficile As Button
End Class
