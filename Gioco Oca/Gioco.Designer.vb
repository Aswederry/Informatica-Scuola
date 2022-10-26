<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gioco
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
        Me.components = New System.ComponentModel.Container()
        Me.Giocatore1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.d1 = New System.Windows.Forms.PictureBox()
        Me.d2 = New System.Windows.Forms.PictureBox()
        Me.d3 = New System.Windows.Forms.PictureBox()
        Me.d4 = New System.Windows.Forms.PictureBox()
        Me.d5 = New System.Windows.Forms.PictureBox()
        Me.d6 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tentativi = New System.Windows.Forms.Label()
        Me.WinL = New System.Windows.Forms.Label()
        Me.RestartB = New System.Windows.Forms.Button()
        Me.PersoL = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Giocatore1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Giocatore1
        '
        Me.Giocatore1.BackColor = System.Drawing.Color.Transparent
        Me.Giocatore1.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca3
        Me.Giocatore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Giocatore1.Location = New System.Drawing.Point(61, 732)
        Me.Giocatore1.Name = "Giocatore1"
        Me.Giocatore1.Size = New System.Drawing.Size(63, 61)
        Me.Giocatore1.TabIndex = 0
        Me.Giocatore1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(239, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 118)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tira Il Dado"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'd1
        '
        Me.d1.BackColor = System.Drawing.Color.Transparent
        Me.d1.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources._1
        Me.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d1.Location = New System.Drawing.Point(509, 351)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(121, 118)
        Me.d1.TabIndex = 4
        Me.d1.TabStop = False
        '
        'd2
        '
        Me.d2.BackColor = System.Drawing.Color.Transparent
        Me.d2.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources._2
        Me.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d2.Location = New System.Drawing.Point(509, 351)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(121, 118)
        Me.d2.TabIndex = 5
        Me.d2.TabStop = False
        Me.d2.Visible = False
        '
        'd3
        '
        Me.d3.BackColor = System.Drawing.Color.Transparent
        Me.d3.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources._3
        Me.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d3.Location = New System.Drawing.Point(509, 351)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(121, 118)
        Me.d3.TabIndex = 6
        Me.d3.TabStop = False
        Me.d3.Visible = False
        '
        'd4
        '
        Me.d4.BackColor = System.Drawing.Color.Transparent
        Me.d4.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.Alea_4
        Me.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d4.Location = New System.Drawing.Point(509, 351)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(121, 118)
        Me.d4.TabIndex = 7
        Me.d4.TabStop = False
        Me.d4.Visible = False
        '
        'd5
        '
        Me.d5.BackColor = System.Drawing.Color.Transparent
        Me.d5.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources._5
        Me.d5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d5.Location = New System.Drawing.Point(509, 351)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(121, 118)
        Me.d5.TabIndex = 8
        Me.d5.TabStop = False
        Me.d5.Visible = False
        '
        'd6
        '
        Me.d6.BackColor = System.Drawing.Color.Transparent
        Me.d6.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources._6
        Me.d6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d6.Location = New System.Drawing.Point(509, 351)
        Me.d6.Name = "d6"
        Me.d6.Size = New System.Drawing.Size(121, 118)
        Me.d6.TabIndex = 9
        Me.d6.TabStop = False
        Me.d6.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Tentativi
        '
        Me.Tentativi.BackColor = System.Drawing.Color.Transparent
        Me.Tentativi.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Tentativi.Location = New System.Drawing.Point(172, 256)
        Me.Tentativi.Name = "Tentativi"
        Me.Tentativi.Size = New System.Drawing.Size(264, 39)
        Me.Tentativi.TabIndex = 10
        Me.Tentativi.Text = "Label1"
        '
        'WinL
        '
        Me.WinL.AutoSize = True
        Me.WinL.BackColor = System.Drawing.Color.White
        Me.WinL.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.WinL.ForeColor = System.Drawing.Color.Lime
        Me.WinL.Location = New System.Drawing.Point(346, 136)
        Me.WinL.Name = "WinL"
        Me.WinL.Size = New System.Drawing.Size(637, 159)
        Me.WinL.TabIndex = 11
        Me.WinL.Text = "Hai Vinto!"
        Me.WinL.Visible = False
        '
        'RestartB
        '
        Me.RestartB.BackColor = System.Drawing.Color.White
        Me.RestartB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RestartB.Location = New System.Drawing.Point(546, 351)
        Me.RestartB.Name = "RestartB"
        Me.RestartB.Size = New System.Drawing.Size(238, 118)
        Me.RestartB.TabIndex = 12
        Me.RestartB.Text = "Vuoi Ricominciare?"
        Me.RestartB.UseVisualStyleBackColor = False
        Me.RestartB.Visible = False
        '
        'PersoL
        '
        Me.PersoL.AutoSize = True
        Me.PersoL.BackColor = System.Drawing.Color.White
        Me.PersoL.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PersoL.ForeColor = System.Drawing.Color.Red
        Me.PersoL.Location = New System.Drawing.Point(346, 136)
        Me.PersoL.Name = "PersoL"
        Me.PersoL.Size = New System.Drawing.Size(640, 159)
        Me.PersoL.TabIndex = 13
        Me.PersoL.Text = "Hai Perso!"
        Me.PersoL.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Gioco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.tabbella1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 836)
        Me.Controls.Add(Me.PersoL)
        Me.Controls.Add(Me.RestartB)
        Me.Controls.Add(Me.WinL)
        Me.Controls.Add(Me.Tentativi)
        Me.Controls.Add(Me.d6)
        Me.Controls.Add(Me.d5)
        Me.Controls.Add(Me.d4)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Giocatore1)
        Me.DoubleBuffered = True
        Me.Name = "Gioco"
        Me.Text = "Gioco"
        CType(Me.Giocatore1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Giocatore1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents d1 As PictureBox
    Friend WithEvents d2 As PictureBox
    Friend WithEvents d3 As PictureBox
    Friend WithEvents d4 As PictureBox
    Friend WithEvents d5 As PictureBox
    Friend WithEvents d6 As PictureBox
    Private WithEvents Timer1 As Timer
    Friend WithEvents Tentativi As Label
    Friend WithEvents WinL As Label
    Friend WithEvents RestartB As Button
    Friend WithEvents PersoL As Label
    Friend WithEvents Timer2 As Timer
End Class
