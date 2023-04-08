<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        StartButton = New Button()
        TitleTxt = New Label()
        RulesButton = New Button()
        FacileBtn = New Button()
        MedioBtn = New Button()
        DiffBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' StartButton
        ' 
        StartButton.Font = New Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        StartButton.Location = New Point(12, 106)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(253, 83)
        StartButton.TabIndex = 0
        StartButton.Text = "Inizia!"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' TitleTxt
        ' 
        TitleTxt.AutoSize = True
        TitleTxt.BackColor = Color.Transparent
        TitleTxt.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TitleTxt.ForeColor = Color.Gray
        TitleTxt.Location = New Point(23, 9)
        TitleTxt.Name = "TitleTxt"
        TitleTxt.Size = New Size(514, 81)
        TitleTxt.TabIndex = 1
        TitleTxt.Text = "Parallax Memory"
        ' 
        ' RulesButton
        ' 
        RulesButton.Font = New Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        RulesButton.Location = New Point(284, 106)
        RulesButton.Name = "RulesButton"
        RulesButton.Size = New Size(253, 83)
        RulesButton.TabIndex = 2
        RulesButton.Text = "Regole"
        RulesButton.UseVisualStyleBackColor = True
        ' 
        ' FacileBtn
        ' 
        FacileBtn.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        FacileBtn.Location = New Point(5, 254)
        FacileBtn.Name = "FacileBtn"
        FacileBtn.Size = New Size(179, 83)
        FacileBtn.TabIndex = 3
        FacileBtn.Text = "Facile"
        FacileBtn.UseVisualStyleBackColor = True
        ' 
        ' MedioBtn
        ' 
        MedioBtn.Enabled = False
        MedioBtn.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        MedioBtn.Location = New Point(187, 254)
        MedioBtn.Name = "MedioBtn"
        MedioBtn.Size = New Size(179, 83)
        MedioBtn.TabIndex = 4
        MedioBtn.Text = "Medio"
        MedioBtn.UseVisualStyleBackColor = False
        ' 
        ' DiffBtn
        ' 
        DiffBtn.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        DiffBtn.Location = New Point(368, 254)
        DiffBtn.Name = "DiffBtn"
        DiffBtn.Size = New Size(179, 83)
        DiffBtn.TabIndex = 5
        DiffBtn.Text = "Difficile"
        DiffBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(171, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 54)
        Label1.TabIndex = 6
        Label1.Text = "Difficoltà"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(12, 340)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 38)
        Label2.TabIndex = 7
        Label2.Text = "Punti 0.5x"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(187, 340)
        Label3.Name = "Label3"
        Label3.Size = New Size(179, 38)
        Label3.TabIndex = 8
        Label3.Text = "Punti 1x"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(368, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 38)
        Label4.TabIndex = 9
        Label4.Text = "Punti 2x"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        ClientSize = New Size(552, 383)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DiffBtn)
        Controls.Add(MedioBtn)
        Controls.Add(FacileBtn)
        Controls.Add(RulesButton)
        Controls.Add(TitleTxt)
        Controls.Add(StartButton)
        Name = "Form1"
        Text = "Start"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents TitleTxt As Label
    Friend WithEvents RulesButton As Button
    Friend WithEvents FacileBtn As Button
    Friend WithEvents MedioBtn As Button
    Friend WithEvents DiffBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
