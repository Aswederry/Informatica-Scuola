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
        Me.Inizio = New System.Windows.Forms.Button()
        Me.Titolo = New System.Windows.Forms.Label()
        Me.RegoleB = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Inizio
        '
        Me.Inizio.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inizio.Location = New System.Drawing.Point(298, 130)
        Me.Inizio.Name = "Inizio"
        Me.Inizio.Size = New System.Drawing.Size(173, 66)
        Me.Inizio.TabIndex = 0
        Me.Inizio.Text = "Gioca"
        Me.Inizio.UseVisualStyleBackColor = True
        '
        'Titolo
        '
        Me.Titolo.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Titolo.Location = New System.Drawing.Point(128, 9)
        Me.Titolo.Name = "Titolo"
        Me.Titolo.Size = New System.Drawing.Size(520, 83)
        Me.Titolo.TabIndex = 1
        Me.Titolo.Text = "Gioco Dell'oca"
        Me.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegoleB
        '
        Me.RegoleB.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegoleB.Location = New System.Drawing.Point(298, 233)
        Me.RegoleB.Name = "RegoleB"
        Me.RegoleB.Size = New System.Drawing.Size(173, 66)
        Me.RegoleB.TabIndex = 2
        Me.RegoleB.Text = "Regole"
        Me.RegoleB.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 268)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(560, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 268)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(298, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 66)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Sfondo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RegoleB)
        Me.Controls.Add(Me.Titolo)
        Me.Controls.Add(Me.Inizio)
        Me.Name = "Form1"
        Me.Text = "Menù principale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Inizio As Button
    Friend WithEvents Titolo As Label
    Friend WithEvents RegoleB As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
