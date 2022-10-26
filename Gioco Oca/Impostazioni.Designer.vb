<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impostazioni
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Titolo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RossoB = New System.Windows.Forms.Button()
        Me.BluB = New System.Windows.Forms.Button()
        Me.GialloB = New System.Windows.Forms.Button()
        Me.VerdeB = New System.Windows.Forms.Button()
        Me.BiancoB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pedina1 = New System.Windows.Forms.PictureBox()
        Me.Pedina2 = New System.Windows.Forms.PictureBox()
        Me.Pedina3 = New System.Windows.Forms.PictureBox()
        Me.Pedina4 = New System.Windows.Forms.PictureBox()
        CType(Me.Pedina1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedina2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedina3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedina4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titolo
        '
        Me.Titolo.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Titolo.Location = New System.Drawing.Point(12, 9)
        Me.Titolo.Name = "Titolo"
        Me.Titolo.Size = New System.Drawing.Size(565, 79)
        Me.Titolo.TabIndex = 2
        Me.Titolo.Text = "Seleziona Colore Sfondo"
        Me.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(565, 66)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Torna Indietro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RossoB
        '
        Me.RossoB.BackColor = System.Drawing.Color.Red
        Me.RossoB.Location = New System.Drawing.Point(12, 91)
        Me.RossoB.Name = "RossoB"
        Me.RossoB.Size = New System.Drawing.Size(91, 42)
        Me.RossoB.TabIndex = 7
        Me.RossoB.UseVisualStyleBackColor = False
        '
        'BluB
        '
        Me.BluB.BackColor = System.Drawing.Color.Aqua
        Me.BluB.Location = New System.Drawing.Point(328, 91)
        Me.BluB.Name = "BluB"
        Me.BluB.Size = New System.Drawing.Size(91, 42)
        Me.BluB.TabIndex = 8
        Me.BluB.UseVisualStyleBackColor = False
        '
        'GialloB
        '
        Me.GialloB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GialloB.Location = New System.Drawing.Point(170, 91)
        Me.GialloB.Name = "GialloB"
        Me.GialloB.Size = New System.Drawing.Size(91, 42)
        Me.GialloB.TabIndex = 9
        Me.GialloB.UseVisualStyleBackColor = False
        '
        'VerdeB
        '
        Me.VerdeB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VerdeB.Location = New System.Drawing.Point(486, 91)
        Me.VerdeB.Name = "VerdeB"
        Me.VerdeB.Size = New System.Drawing.Size(91, 42)
        Me.VerdeB.TabIndex = 10
        Me.VerdeB.UseVisualStyleBackColor = False
        '
        'BiancoB
        '
        Me.BiancoB.BackColor = System.Drawing.Color.White
        Me.BiancoB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BiancoB.Location = New System.Drawing.Point(12, 154)
        Me.BiancoB.Name = "BiancoB"
        Me.BiancoB.Size = New System.Drawing.Size(565, 42)
        Me.BiancoB.TabIndex = 11
        Me.BiancoB.Text = "Resetta il colore"
        Me.BiancoB.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 79)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Seleziona Pedina"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pedina1
        '
        Me.Pedina1.BackColor = System.Drawing.Color.Transparent
        Me.Pedina1.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca3
        Me.Pedina1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pedina1.Location = New System.Drawing.Point(12, 301)
        Me.Pedina1.Name = "Pedina1"
        Me.Pedina1.Size = New System.Drawing.Size(91, 90)
        Me.Pedina1.TabIndex = 13
        Me.Pedina1.TabStop = False
        '
        'Pedina2
        '
        Me.Pedina2.BackColor = System.Drawing.Color.Transparent
        Me.Pedina2.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca4
        Me.Pedina2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pedina2.Location = New System.Drawing.Point(170, 301)
        Me.Pedina2.Name = "Pedina2"
        Me.Pedina2.Size = New System.Drawing.Size(91, 90)
        Me.Pedina2.TabIndex = 14
        Me.Pedina2.TabStop = False
        '
        'Pedina3
        '
        Me.Pedina3.BackColor = System.Drawing.Color.Transparent
        Me.Pedina3.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca5
        Me.Pedina3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pedina3.Location = New System.Drawing.Point(328, 301)
        Me.Pedina3.Name = "Pedina3"
        Me.Pedina3.Size = New System.Drawing.Size(91, 90)
        Me.Pedina3.TabIndex = 15
        Me.Pedina3.TabStop = False
        '
        'Pedina4
        '
        Me.Pedina4.BackColor = System.Drawing.Color.Transparent
        Me.Pedina4.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca6
        Me.Pedina4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pedina4.Location = New System.Drawing.Point(486, 301)
        Me.Pedina4.Name = "Pedina4"
        Me.Pedina4.Size = New System.Drawing.Size(91, 90)
        Me.Pedina4.TabIndex = 16
        Me.Pedina4.TabStop = False
        '
        'Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 554)
        Me.Controls.Add(Me.Pedina4)
        Me.Controls.Add(Me.Pedina3)
        Me.Controls.Add(Me.Pedina2)
        Me.Controls.Add(Me.Pedina1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BiancoB)
        Me.Controls.Add(Me.VerdeB)
        Me.Controls.Add(Me.GialloB)
        Me.Controls.Add(Me.BluB)
        Me.Controls.Add(Me.RossoB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Titolo)
        Me.Name = "Impostazioni"
        Me.Text = "Impostazioni"
        CType(Me.Pedina1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedina2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedina3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedina4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titolo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RossoB As Button
    Friend WithEvents BluB As Button
    Friend WithEvents GialloB As Button
    Friend WithEvents VerdeB As Button
    Friend WithEvents BiancoB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Pedina1 As PictureBox
    Friend WithEvents Pedina2 As PictureBox
    Friend WithEvents Pedina3 As PictureBox
    Friend WithEvents Pedina4 As PictureBox
End Class
