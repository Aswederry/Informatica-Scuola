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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        ClientSize = New Size(552, 210)
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
End Class
