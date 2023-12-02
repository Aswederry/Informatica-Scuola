<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        ResultL = New Label()
        Face = New PictureBox()
        NumberL = New Label()
        DetailL = New Button()
        MenuB = New Button()
        CType(Face, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ResultL
        ' 
        ResultL.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        ResultL.ForeColor = Color.Red
        ResultL.Location = New Point(12, 216)
        ResultL.Name = "ResultL"
        ResultL.Size = New Size(458, 176)
        ResultL.TabIndex = 0
        ResultL.Text = "Bocciato"
        ResultL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Face
        ' 
        Face.BackgroundImage = My.Resources.Resources.sad
        Face.BackgroundImageLayout = ImageLayout.Stretch
        Face.Location = New Point(140, 6)
        Face.Name = "Face"
        Face.Size = New Size(200, 200)
        Face.TabIndex = 1
        Face.TabStop = False
        ' 
        ' NumberL
        ' 
        NumberL.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        NumberL.ForeColor = Color.Red
        NumberL.Location = New Point(12, 392)
        NumberL.Name = "NumberL"
        NumberL.Size = New Size(458, 176)
        NumberL.TabIndex = 2
        NumberL.Text = "1/20"
        NumberL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DetailL
        ' 
        DetailL.BackColor = Color.YellowGreen
        DetailL.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        DetailL.Location = New Point(245, 624)
        DetailL.Name = "DetailL"
        DetailL.Size = New Size(225, 117)
        DetailL.TabIndex = 4
        DetailL.Text = "Vista Dettagliata"
        DetailL.UseVisualStyleBackColor = False
        ' 
        ' MenuB
        ' 
        MenuB.BackColor = Color.Orange
        MenuB.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        MenuB.Location = New Point(12, 624)
        MenuB.Name = "MenuB"
        MenuB.Size = New Size(225, 117)
        MenuB.TabIndex = 5
        MenuB.Text = "Menù Principale"
        MenuB.UseVisualStyleBackColor = False
        ' 
        ' Results
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 753)
        Controls.Add(MenuB)
        Controls.Add(DetailL)
        Controls.Add(NumberL)
        Controls.Add(Face)
        Controls.Add(ResultL)
        Name = "Results"
        Text = "Risultati"
        CType(Face, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ResultL As Label
    Friend WithEvents Face As PictureBox
    Friend WithEvents NumberL As Label
    Friend WithEvents DetailL As Button
    Friend WithEvents MenuB As Button
End Class
