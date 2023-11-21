<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
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
        ImageView = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        QuestionL = New Label()
        Label5 = New Label()
        QuestionNumberL = New Label()
        TrueB = New Button()
        FalseB = New Button()
        NextB = New Button()
        B1 = New Button()
        B2 = New Button()
        B4 = New Button()
        B3 = New Button()
        B8 = New Button()
        B7 = New Button()
        B6 = New Button()
        B5 = New Button()
        B18 = New Button()
        B17 = New Button()
        B16 = New Button()
        B15 = New Button()
        B14 = New Button()
        B13 = New Button()
        B12 = New Button()
        B11 = New Button()
        B20 = New Button()
        B19 = New Button()
        B10 = New Button()
        B9 = New Button()
        Label7 = New Label()
        SendButton = New Button()
        CType(ImageView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImageView
        ' 
        ImageView.BackgroundImageLayout = ImageLayout.Center
        ImageView.Location = New Point(508, 100)
        ImageView.Margin = New Padding(1)
        ImageView.Name = "ImageView"
        ImageView.Size = New Size(405, 369)
        ImageView.TabIndex = 0
        ImageView.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(2, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(929, 25)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(473, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 601)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(2, 444)
        Label3.Name = "Label3"
        Label3.Size = New Size(503, 25)
        Label3.TabIndex = 3
        Label3.Text = "Label3"
        ' 
        ' QuestionL
        ' 
        QuestionL.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        QuestionL.Location = New Point(12, 112)
        QuestionL.Name = "QuestionL"
        QuestionL.Size = New Size(455, 322)
        QuestionL.TabIndex = 4
        QuestionL.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" & vbCrLf & vbCrLf
        QuestionL.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(579, 472)
        Label5.Name = "Label5"
        Label5.Size = New Size(264, 95)
        Label5.TabIndex = 5
        Label5.Text = "Domanda:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' QuestionNumberL
        ' 
        QuestionNumberL.Font = New Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point)
        QuestionNumberL.Location = New Point(624, 556)
        QuestionNumberL.Name = "QuestionNumberL"
        QuestionNumberL.Size = New Size(180, 116)
        QuestionNumberL.TabIndex = 6
        QuestionNumberL.Text = "30"
        QuestionNumberL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TrueB
        ' 
        TrueB.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        TrueB.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        TrueB.ForeColor = Color.Black
        TrueB.Location = New Point(12, 483)
        TrueB.Name = "TrueB"
        TrueB.Size = New Size(174, 137)
        TrueB.TabIndex = 7
        TrueB.Text = "Vero"
        TrueB.UseVisualStyleBackColor = False
        ' 
        ' FalseB
        ' 
        FalseB.BackColor = Color.Red
        FalseB.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        FalseB.Location = New Point(192, 483)
        FalseB.Name = "FalseB"
        FalseB.Size = New Size(174, 137)
        FalseB.TabIndex = 8
        FalseB.Text = "Falso"
        FalseB.UseVisualStyleBackColor = False
        ' 
        ' NextB
        ' 
        NextB.BackColor = Color.DarkOrange
        NextB.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        NextB.Location = New Point(372, 483)
        NextB.Name = "NextB"
        NextB.Size = New Size(95, 137)
        NextB.TabIndex = 9
        NextB.Text = "Prossima"
        NextB.UseVisualStyleBackColor = False
        ' 
        ' B1
        ' 
        B1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B1.Location = New Point(215, 7)
        B1.Margin = New Padding(1)
        B1.Name = "B1"
        B1.Size = New Size(69, 29)
        B1.TabIndex = 10
        B1.Text = "1"
        B1.UseVisualStyleBackColor = True
        ' 
        ' B2
        ' 
        B2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B2.Location = New Point(286, 7)
        B2.Margin = New Padding(1)
        B2.Name = "B2"
        B2.Size = New Size(69, 29)
        B2.TabIndex = 11
        B2.Text = "2"
        B2.UseVisualStyleBackColor = True
        ' 
        ' B4
        ' 
        B4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B4.Location = New Point(428, 7)
        B4.Margin = New Padding(1)
        B4.Name = "B4"
        B4.Size = New Size(69, 29)
        B4.TabIndex = 13
        B4.Text = "4"
        B4.UseVisualStyleBackColor = True
        ' 
        ' B3
        ' 
        B3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B3.Location = New Point(357, 7)
        B3.Margin = New Padding(1)
        B3.Name = "B3"
        B3.Size = New Size(69, 29)
        B3.TabIndex = 12
        B3.Text = "3"
        B3.UseVisualStyleBackColor = True
        ' 
        ' B8
        ' 
        B8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B8.Location = New Point(712, 7)
        B8.Margin = New Padding(1)
        B8.Name = "B8"
        B8.Size = New Size(69, 29)
        B8.TabIndex = 17
        B8.Text = "8"
        B8.UseVisualStyleBackColor = True
        ' 
        ' B7
        ' 
        B7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B7.Location = New Point(641, 7)
        B7.Margin = New Padding(1)
        B7.Name = "B7"
        B7.Size = New Size(69, 29)
        B7.TabIndex = 16
        B7.Text = "7"
        B7.UseVisualStyleBackColor = True
        ' 
        ' B6
        ' 
        B6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B6.Location = New Point(570, 7)
        B6.Margin = New Padding(1)
        B6.Name = "B6"
        B6.Size = New Size(69, 29)
        B6.TabIndex = 15
        B6.Text = "6"
        B6.UseVisualStyleBackColor = True
        ' 
        ' B5
        ' 
        B5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B5.Location = New Point(499, 7)
        B5.Margin = New Padding(1)
        B5.Name = "B5"
        B5.Size = New Size(69, 29)
        B5.TabIndex = 14
        B5.Text = "5"
        B5.UseVisualStyleBackColor = True
        ' 
        ' B18
        ' 
        B18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B18.Location = New Point(712, 38)
        B18.Margin = New Padding(1)
        B18.Name = "B18"
        B18.Size = New Size(69, 29)
        B18.TabIndex = 25
        B18.Text = "18"
        B18.UseVisualStyleBackColor = True
        ' 
        ' B17
        ' 
        B17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B17.Location = New Point(641, 38)
        B17.Margin = New Padding(1)
        B17.Name = "B17"
        B17.Size = New Size(69, 29)
        B17.TabIndex = 24
        B17.Text = "17"
        B17.UseVisualStyleBackColor = True
        ' 
        ' B16
        ' 
        B16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B16.Location = New Point(570, 38)
        B16.Margin = New Padding(1)
        B16.Name = "B16"
        B16.Size = New Size(69, 29)
        B16.TabIndex = 23
        B16.Text = "16"
        B16.UseVisualStyleBackColor = True
        ' 
        ' B15
        ' 
        B15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B15.Location = New Point(499, 38)
        B15.Margin = New Padding(1)
        B15.Name = "B15"
        B15.Size = New Size(69, 29)
        B15.TabIndex = 22
        B15.Text = "15"
        B15.UseVisualStyleBackColor = True
        ' 
        ' B14
        ' 
        B14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B14.Location = New Point(428, 38)
        B14.Margin = New Padding(1)
        B14.Name = "B14"
        B14.Size = New Size(69, 29)
        B14.TabIndex = 21
        B14.Text = "14"
        B14.UseVisualStyleBackColor = True
        ' 
        ' B13
        ' 
        B13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B13.Location = New Point(357, 38)
        B13.Margin = New Padding(1)
        B13.Name = "B13"
        B13.Size = New Size(69, 29)
        B13.TabIndex = 20
        B13.Text = "13"
        B13.UseVisualStyleBackColor = True
        ' 
        ' B12
        ' 
        B12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B12.Location = New Point(286, 38)
        B12.Margin = New Padding(1)
        B12.Name = "B12"
        B12.Size = New Size(69, 29)
        B12.TabIndex = 19
        B12.Text = "12"
        B12.UseVisualStyleBackColor = True
        ' 
        ' B11
        ' 
        B11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B11.Location = New Point(215, 38)
        B11.Margin = New Padding(1)
        B11.Name = "B11"
        B11.Size = New Size(69, 29)
        B11.TabIndex = 18
        B11.Text = "11"
        B11.UseVisualStyleBackColor = True
        ' 
        ' B20
        ' 
        B20.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B20.Location = New Point(854, 38)
        B20.Margin = New Padding(1)
        B20.Name = "B20"
        B20.Size = New Size(69, 29)
        B20.TabIndex = 29
        B20.Text = "20"
        B20.UseVisualStyleBackColor = True
        ' 
        ' B19
        ' 
        B19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B19.Location = New Point(783, 38)
        B19.Margin = New Padding(1)
        B19.Name = "B19"
        B19.Size = New Size(69, 29)
        B19.TabIndex = 28
        B19.Text = "19"
        B19.UseVisualStyleBackColor = True
        ' 
        ' B10
        ' 
        B10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B10.Location = New Point(854, 7)
        B10.Margin = New Padding(1)
        B10.Name = "B10"
        B10.Size = New Size(69, 29)
        B10.TabIndex = 27
        B10.Text = "10"
        B10.UseVisualStyleBackColor = True
        ' 
        ' B9
        ' 
        B9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        B9.Location = New Point(783, 7)
        B9.Margin = New Padding(1)
        B9.Name = "B9"
        B9.Size = New Size(69, 29)
        B9.TabIndex = 26
        B9.Text = "9"
        B9.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(2, 5)
        Label7.Name = "Label7"
        Label7.Size = New Size(209, 60)
        Label7.TabIndex = 30
        Label7.Text = "Vai Avanti"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SendButton
        ' 
        SendButton.BackColor = Color.Cyan
        SendButton.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        SendButton.ForeColor = Color.Black
        SendButton.Location = New Point(12, 626)
        SendButton.Name = "SendButton"
        SendButton.Size = New Size(455, 62)
        SendButton.TabIndex = 31
        SendButton.Text = "Consegna"
        SendButton.UseVisualStyleBackColor = False
        ' 
        ' Quiz
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(934, 700)
        Controls.Add(SendButton)
        Controls.Add(Label7)
        Controls.Add(B20)
        Controls.Add(B19)
        Controls.Add(B10)
        Controls.Add(B9)
        Controls.Add(B18)
        Controls.Add(B17)
        Controls.Add(B16)
        Controls.Add(B15)
        Controls.Add(B14)
        Controls.Add(B13)
        Controls.Add(B12)
        Controls.Add(B11)
        Controls.Add(B8)
        Controls.Add(B7)
        Controls.Add(B6)
        Controls.Add(B5)
        Controls.Add(B4)
        Controls.Add(B3)
        Controls.Add(B2)
        Controls.Add(B1)
        Controls.Add(NextB)
        Controls.Add(FalseB)
        Controls.Add(TrueB)
        Controls.Add(QuestionNumberL)
        Controls.Add(Label5)
        Controls.Add(QuestionL)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ImageView)
        Name = "Quiz"
        Text = "Quiz"
        CType(ImageView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ImageView As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuestionL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents QuestionNumberL As Label
    Friend WithEvents TrueB As Button
    Friend WithEvents FalseB As Button
    Friend WithEvents NextB As Button
    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B18 As Button
    Friend WithEvents B17 As Button
    Friend WithEvents B16 As Button
    Friend WithEvents B15 As Button
    Friend WithEvents B14 As Button
    Friend WithEvents B13 As Button
    Friend WithEvents B12 As Button
    Friend WithEvents B11 As Button
    Friend WithEvents B20 As Button
    Friend WithEvents B19 As Button
    Friend WithEvents B10 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents SendButton As Button
End Class
