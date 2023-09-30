<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainMenu
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
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(225, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 53)
        Button1.TabIndex = 0
        Button1.Text = "Inizia"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(225, 308)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 53)
        Button2.TabIndex = 1
        Button2.Text = "Impostazioni"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' mainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.MainMenu
        ClientSize = New Size(622, 433)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "mainMenu"
        Text = "Menù Principale"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
