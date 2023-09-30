<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelezionaNave
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
        Label1 = New Label()
        b1 = New Button()
        b2 = New Button()
        b4 = New Button()
        b3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        qt4 = New Label()
        qt3 = New Label()
        qt2 = New Label()
        qt1 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(113, -7)
        Label1.Name = "Label1"
        Label1.Size = New Size(541, 81)
        Label1.TabIndex = 0
        Label1.Text = "Seleziona La Nave"
        ' 
        ' b1
        ' 
        b1.Location = New Point(12, 115)
        b1.Name = "b1"
        b1.Size = New Size(180, 180)
        b1.TabIndex = 1
        b1.UseVisualStyleBackColor = True
        ' 
        ' b2
        ' 
        b2.Location = New Point(211, 115)
        b2.Name = "b2"
        b2.Size = New Size(180, 180)
        b2.TabIndex = 2
        b2.UseVisualStyleBackColor = True
        ' 
        ' b4
        ' 
        b4.Location = New Point(608, 115)
        b4.Name = "b4"
        b4.Size = New Size(180, 180)
        b4.TabIndex = 4
        b4.UseVisualStyleBackColor = True
        ' 
        ' b3
        ' 
        b3.Location = New Point(411, 115)
        b3.Name = "b3"
        b3.Size = New Size(180, 180)
        b3.TabIndex = 3
        b3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 298)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 25)
        Label2.TabIndex = 5
        Label2.Text = "1 Casella"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(211, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 25)
        Label3.TabIndex = 6
        Label3.Text = "2 Caselle"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(411, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 25)
        Label4.TabIndex = 7
        Label4.Text = "3 Caselle"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(608, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 25)
        Label5.TabIndex = 8
        Label5.Text = "4 Caselle"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' qt4
        ' 
        qt4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        qt4.Location = New Point(608, 87)
        qt4.Name = "qt4"
        qt4.Size = New Size(180, 25)
        qt4.TabIndex = 12
        qt4.Text = "4 Caselle"
        qt4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' qt3
        ' 
        qt3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        qt3.Location = New Point(411, 87)
        qt3.Name = "qt3"
        qt3.Size = New Size(180, 25)
        qt3.TabIndex = 11
        qt3.Text = "3 Caselle"
        qt3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' qt2
        ' 
        qt2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        qt2.Location = New Point(211, 87)
        qt2.Name = "qt2"
        qt2.Size = New Size(180, 25)
        qt2.TabIndex = 10
        qt2.Text = "2 Caselle"
        qt2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' qt1
        ' 
        qt1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        qt1.Location = New Point(12, 87)
        qt1.Name = "qt1"
        qt1.Size = New Size(180, 25)
        qt1.TabIndex = 9
        qt1.Text = "x1"
        qt1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' SelezionaNave
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 335)
        Controls.Add(qt4)
        Controls.Add(qt3)
        Controls.Add(qt2)
        Controls.Add(qt1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(b4)
        Controls.Add(b3)
        Controls.Add(b2)
        Controls.Add(b1)
        Controls.Add(Label1)
        Name = "SelezionaNave"
        Text = "SelezionaNave"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents qt4 As Label
    Friend WithEvents qt3 As Label
    Friend WithEvents qt2 As Label
    Friend WithEvents qt1 As Label
End Class
