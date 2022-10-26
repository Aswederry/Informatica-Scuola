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
        Me.SuspendLayout()
        '
        'Titolo
        '
        Me.Titolo.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Titolo.Location = New System.Drawing.Point(12, 9)
        Me.Titolo.Name = "Titolo"
        Me.Titolo.Size = New System.Drawing.Size(776, 83)
        Me.Titolo.TabIndex = 2
        Me.Titolo.Text = "Seleziona Colore Sfondo"
        Me.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(776, 66)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Torna Indietro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RossoB
        '
        Me.RossoB.BackColor = System.Drawing.Color.Red
        Me.RossoB.Location = New System.Drawing.Point(85, 119)
        Me.RossoB.Name = "RossoB"
        Me.RossoB.Size = New System.Drawing.Size(152, 96)
        Me.RossoB.TabIndex = 7
        Me.RossoB.UseVisualStyleBackColor = False
        '
        'BluB
        '
        Me.BluB.BackColor = System.Drawing.Color.Aqua
        Me.BluB.Location = New System.Drawing.Point(401, 119)
        Me.BluB.Name = "BluB"
        Me.BluB.Size = New System.Drawing.Size(152, 96)
        Me.BluB.TabIndex = 8
        Me.BluB.UseVisualStyleBackColor = False
        '
        'GialloB
        '
        Me.GialloB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GialloB.Location = New System.Drawing.Point(243, 119)
        Me.GialloB.Name = "GialloB"
        Me.GialloB.Size = New System.Drawing.Size(152, 96)
        Me.GialloB.TabIndex = 9
        Me.GialloB.UseVisualStyleBackColor = False
        '
        'VerdeB
        '
        Me.VerdeB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VerdeB.Location = New System.Drawing.Point(559, 119)
        Me.VerdeB.Name = "VerdeB"
        Me.VerdeB.Size = New System.Drawing.Size(152, 96)
        Me.VerdeB.TabIndex = 10
        Me.VerdeB.UseVisualStyleBackColor = False
        '
        'BiancoB
        '
        Me.BiancoB.BackColor = System.Drawing.Color.White
        Me.BiancoB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BiancoB.Location = New System.Drawing.Point(85, 232)
        Me.BiancoB.Name = "BiancoB"
        Me.BiancoB.Size = New System.Drawing.Size(626, 96)
        Me.BiancoB.TabIndex = 11
        Me.BiancoB.Text = "Resetta il colore"
        Me.BiancoB.UseVisualStyleBackColor = False
        '
        'Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BiancoB)
        Me.Controls.Add(Me.VerdeB)
        Me.Controls.Add(Me.GialloB)
        Me.Controls.Add(Me.BluB)
        Me.Controls.Add(Me.RossoB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Titolo)
        Me.Name = "Impostazioni"
        Me.Text = "Impostazioni"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titolo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RossoB As Button
    Friend WithEvents BluB As Button
    Friend WithEvents GialloB As Button
    Friend WithEvents VerdeB As Button
    Friend WithEvents BiancoB As Button
End Class
