﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gioco
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Carta = New System.Windows.Forms.PictureBox()
        Me.NestrattoL = New System.Windows.Forms.Label()
        Me.NeL = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.Label()
        Me.C2 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.Label()
        Me.C4 = New System.Windows.Forms.Label()
        Me.C5 = New System.Windows.Forms.Label()
        Me.C6 = New System.Windows.Forms.Label()
        Me.C7 = New System.Windows.Forms.Label()
        Me.C8 = New System.Windows.Forms.Label()
        Me.C9 = New System.Windows.Forms.Label()
        Me.C10 = New System.Windows.Forms.Label()
        Me.C11 = New System.Windows.Forms.Label()
        Me.C12 = New System.Windows.Forms.Label()
        Me.C13 = New System.Windows.Forms.Label()
        Me.C14 = New System.Windows.Forms.Label()
        Me.C15 = New System.Windows.Forms.Label()
        Me.C16 = New System.Windows.Forms.Label()
        Me.C17 = New System.Windows.Forms.Label()
        Me.C18 = New System.Windows.Forms.Label()
        Me.C19 = New System.Windows.Forms.Label()
        Me.C20 = New System.Windows.Forms.Label()
        Me.C21 = New System.Windows.Forms.Label()
        Me.C22 = New System.Windows.Forms.Label()
        Me.C23 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.C24 = New System.Windows.Forms.Label()
        Me.C25 = New System.Windows.Forms.Label()
        Me.C26 = New System.Windows.Forms.Label()
        Me.C27 = New System.Windows.Forms.Label()
        Me.EstraiB = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AmboL = New System.Windows.Forms.Label()
        Me.QuartinaL = New System.Windows.Forms.Label()
        Me.TerzinaL = New System.Windows.Forms.Label()
        Me.CinquinaL = New System.Windows.Forms.Label()
        Me.WinL = New System.Windows.Forms.Label()
        Me.RicominciaB = New System.Windows.Forms.Button()
        CType(Me.Carta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Carta
        '
        Me.Carta.BackColor = System.Drawing.Color.Transparent
        Me.Carta.BackgroundImage = Global.Tombolona.My.Resources.Resources.Cartelle_Tombola1
        Me.Carta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Carta.Location = New System.Drawing.Point(501, 446)
        Me.Carta.Name = "Carta"
        Me.Carta.Size = New System.Drawing.Size(838, 459)
        Me.Carta.TabIndex = 0
        Me.Carta.TabStop = False
        '
        'NestrattoL
        '
        Me.NestrattoL.BackColor = System.Drawing.Color.Transparent
        Me.NestrattoL.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NestrattoL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NestrattoL.Location = New System.Drawing.Point(501, 69)
        Me.NestrattoL.Name = "NestrattoL"
        Me.NestrattoL.Size = New System.Drawing.Size(838, 90)
        Me.NestrattoL.TabIndex = 1
        Me.NestrattoL.Text = "Ultimo Numero Estratto"
        Me.NestrattoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NeL
        '
        Me.NeL.BackColor = System.Drawing.Color.Transparent
        Me.NeL.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NeL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NeL.Location = New System.Drawing.Point(501, 159)
        Me.NeL.Name = "NeL"
        Me.NeL.Size = New System.Drawing.Size(838, 165)
        Me.NeL.TabIndex = 2
        Me.NeL.Text = "__"
        Me.NeL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'C1
        '
        Me.C1.BackColor = System.Drawing.Color.White
        Me.C1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C1.Location = New System.Drawing.Point(517, 552)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(85, 102)
        Me.C1.TabIndex = 3
        Me.C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C2
        '
        Me.C2.BackColor = System.Drawing.Color.White
        Me.C2.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C2.Location = New System.Drawing.Point(608, 552)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(85, 102)
        Me.C2.TabIndex = 4
        Me.C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C3
        '
        Me.C3.BackColor = System.Drawing.Color.White
        Me.C3.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C3.Location = New System.Drawing.Point(699, 552)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(85, 102)
        Me.C3.TabIndex = 5
        Me.C3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.White
        Me.C4.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C4.Location = New System.Drawing.Point(790, 552)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(85, 102)
        Me.C4.TabIndex = 6
        Me.C4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C5
        '
        Me.C5.BackColor = System.Drawing.Color.White
        Me.C5.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C5.Location = New System.Drawing.Point(881, 552)
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(85, 102)
        Me.C5.TabIndex = 7
        Me.C5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C6
        '
        Me.C6.BackColor = System.Drawing.Color.White
        Me.C6.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C6.Location = New System.Drawing.Point(972, 552)
        Me.C6.Name = "C6"
        Me.C6.Size = New System.Drawing.Size(85, 102)
        Me.C6.TabIndex = 8
        Me.C6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C7
        '
        Me.C7.BackColor = System.Drawing.Color.White
        Me.C7.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C7.Location = New System.Drawing.Point(1063, 552)
        Me.C7.Name = "C7"
        Me.C7.Size = New System.Drawing.Size(85, 102)
        Me.C7.TabIndex = 9
        Me.C7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C8
        '
        Me.C8.BackColor = System.Drawing.Color.White
        Me.C8.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C8.Location = New System.Drawing.Point(1154, 552)
        Me.C8.Name = "C8"
        Me.C8.Size = New System.Drawing.Size(85, 102)
        Me.C8.TabIndex = 10
        Me.C8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C9
        '
        Me.C9.BackColor = System.Drawing.Color.White
        Me.C9.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C9.Location = New System.Drawing.Point(1242, 552)
        Me.C9.Name = "C9"
        Me.C9.Size = New System.Drawing.Size(85, 102)
        Me.C9.TabIndex = 11
        Me.C9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C10
        '
        Me.C10.BackColor = System.Drawing.Color.White
        Me.C10.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C10.Location = New System.Drawing.Point(517, 664)
        Me.C10.Name = "C10"
        Me.C10.Size = New System.Drawing.Size(85, 102)
        Me.C10.TabIndex = 12
        Me.C10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C11
        '
        Me.C11.BackColor = System.Drawing.Color.White
        Me.C11.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C11.Location = New System.Drawing.Point(608, 664)
        Me.C11.Name = "C11"
        Me.C11.Size = New System.Drawing.Size(85, 102)
        Me.C11.TabIndex = 13
        Me.C11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C12
        '
        Me.C12.BackColor = System.Drawing.Color.White
        Me.C12.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C12.Location = New System.Drawing.Point(699, 664)
        Me.C12.Name = "C12"
        Me.C12.Size = New System.Drawing.Size(85, 102)
        Me.C12.TabIndex = 14
        Me.C12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C13
        '
        Me.C13.BackColor = System.Drawing.Color.White
        Me.C13.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C13.Location = New System.Drawing.Point(790, 664)
        Me.C13.Name = "C13"
        Me.C13.Size = New System.Drawing.Size(85, 102)
        Me.C13.TabIndex = 15
        Me.C13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C14
        '
        Me.C14.BackColor = System.Drawing.Color.White
        Me.C14.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C14.Location = New System.Drawing.Point(881, 664)
        Me.C14.Name = "C14"
        Me.C14.Size = New System.Drawing.Size(85, 102)
        Me.C14.TabIndex = 16
        Me.C14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C15
        '
        Me.C15.BackColor = System.Drawing.Color.White
        Me.C15.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C15.Location = New System.Drawing.Point(972, 664)
        Me.C15.Name = "C15"
        Me.C15.Size = New System.Drawing.Size(85, 102)
        Me.C15.TabIndex = 17
        Me.C15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C16
        '
        Me.C16.BackColor = System.Drawing.Color.White
        Me.C16.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C16.Location = New System.Drawing.Point(1063, 664)
        Me.C16.Name = "C16"
        Me.C16.Size = New System.Drawing.Size(85, 102)
        Me.C16.TabIndex = 18
        Me.C16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C17
        '
        Me.C17.BackColor = System.Drawing.Color.White
        Me.C17.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C17.Location = New System.Drawing.Point(1154, 664)
        Me.C17.Name = "C17"
        Me.C17.Size = New System.Drawing.Size(85, 102)
        Me.C17.TabIndex = 19
        Me.C17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C18
        '
        Me.C18.BackColor = System.Drawing.Color.White
        Me.C18.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C18.Location = New System.Drawing.Point(1242, 664)
        Me.C18.Name = "C18"
        Me.C18.Size = New System.Drawing.Size(85, 102)
        Me.C18.TabIndex = 20
        Me.C18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C19
        '
        Me.C19.BackColor = System.Drawing.Color.White
        Me.C19.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C19.Location = New System.Drawing.Point(517, 779)
        Me.C19.Name = "C19"
        Me.C19.Size = New System.Drawing.Size(85, 102)
        Me.C19.TabIndex = 21
        Me.C19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C20
        '
        Me.C20.BackColor = System.Drawing.Color.White
        Me.C20.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C20.Location = New System.Drawing.Point(608, 779)
        Me.C20.Name = "C20"
        Me.C20.Size = New System.Drawing.Size(85, 102)
        Me.C20.TabIndex = 22
        Me.C20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C21
        '
        Me.C21.BackColor = System.Drawing.Color.White
        Me.C21.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C21.Location = New System.Drawing.Point(699, 779)
        Me.C21.Name = "C21"
        Me.C21.Size = New System.Drawing.Size(85, 102)
        Me.C21.TabIndex = 23
        Me.C21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C22
        '
        Me.C22.BackColor = System.Drawing.Color.White
        Me.C22.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C22.Location = New System.Drawing.Point(790, 779)
        Me.C22.Name = "C22"
        Me.C22.Size = New System.Drawing.Size(85, 102)
        Me.C22.TabIndex = 24
        Me.C22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C23
        '
        Me.C23.BackColor = System.Drawing.Color.White
        Me.C23.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C23.Location = New System.Drawing.Point(881, 779)
        Me.C23.Name = "C23"
        Me.C23.Size = New System.Drawing.Size(85, 102)
        Me.C23.TabIndex = 25
        Me.C23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(972, 779)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 102)
        Me.Label23.TabIndex = 26
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C24
        '
        Me.C24.BackColor = System.Drawing.Color.White
        Me.C24.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C24.Location = New System.Drawing.Point(972, 779)
        Me.C24.Name = "C24"
        Me.C24.Size = New System.Drawing.Size(85, 102)
        Me.C24.TabIndex = 27
        Me.C24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C25
        '
        Me.C25.BackColor = System.Drawing.Color.White
        Me.C25.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C25.Location = New System.Drawing.Point(1063, 779)
        Me.C25.Name = "C25"
        Me.C25.Size = New System.Drawing.Size(85, 102)
        Me.C25.TabIndex = 28
        Me.C25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C26
        '
        Me.C26.BackColor = System.Drawing.Color.White
        Me.C26.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C26.Location = New System.Drawing.Point(1154, 779)
        Me.C26.Name = "C26"
        Me.C26.Size = New System.Drawing.Size(85, 102)
        Me.C26.TabIndex = 29
        Me.C26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C27
        '
        Me.C27.BackColor = System.Drawing.Color.White
        Me.C27.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.C27.Location = New System.Drawing.Point(1242, 779)
        Me.C27.Name = "C27"
        Me.C27.Size = New System.Drawing.Size(85, 102)
        Me.C27.TabIndex = 30
        Me.C27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstraiB
        '
        Me.EstraiB.BackColor = System.Drawing.Color.Transparent
        Me.EstraiB.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EstraiB.Location = New System.Drawing.Point(107, 640)
        Me.EstraiB.Name = "EstraiB"
        Me.EstraiB.Size = New System.Drawing.Size(256, 256)
        Me.EstraiB.TabIndex = 31
        Me.EstraiB.Text = "Estrai Numero"
        Me.EstraiB.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'AmboL
        '
        Me.AmboL.BackColor = System.Drawing.Color.Transparent
        Me.AmboL.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AmboL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AmboL.Location = New System.Drawing.Point(35, 59)
        Me.AmboL.Name = "AmboL"
        Me.AmboL.Size = New System.Drawing.Size(400, 100)
        Me.AmboL.TabIndex = 32
        Me.AmboL.Text = "Ambo"
        Me.AmboL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuartinaL
        '
        Me.QuartinaL.BackColor = System.Drawing.Color.Transparent
        Me.QuartinaL.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.QuartinaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuartinaL.Location = New System.Drawing.Point(35, 317)
        Me.QuartinaL.Name = "QuartinaL"
        Me.QuartinaL.Size = New System.Drawing.Size(400, 100)
        Me.QuartinaL.TabIndex = 33
        Me.QuartinaL.Text = "Quartina"
        Me.QuartinaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TerzinaL
        '
        Me.TerzinaL.BackColor = System.Drawing.Color.Transparent
        Me.TerzinaL.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TerzinaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TerzinaL.Location = New System.Drawing.Point(35, 185)
        Me.TerzinaL.Name = "TerzinaL"
        Me.TerzinaL.Size = New System.Drawing.Size(400, 100)
        Me.TerzinaL.TabIndex = 34
        Me.TerzinaL.Text = "Terzina"
        Me.TerzinaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CinquinaL
        '
        Me.CinquinaL.BackColor = System.Drawing.Color.Transparent
        Me.CinquinaL.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CinquinaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CinquinaL.Location = New System.Drawing.Point(35, 446)
        Me.CinquinaL.Name = "CinquinaL"
        Me.CinquinaL.Size = New System.Drawing.Size(400, 100)
        Me.CinquinaL.TabIndex = 35
        Me.CinquinaL.Text = "Cinquina"
        Me.CinquinaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WinL
        '
        Me.WinL.BackColor = System.Drawing.Color.Transparent
        Me.WinL.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.WinL.ForeColor = System.Drawing.Color.Lime
        Me.WinL.Location = New System.Drawing.Point(376, 204)
        Me.WinL.Name = "WinL"
        Me.WinL.Size = New System.Drawing.Size(499, 100)
        Me.WinL.TabIndex = 36
        Me.WinL.Text = "Hai Vinto!"
        Me.WinL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.WinL.Visible = False
        '
        'RicominciaB
        '
        Me.RicominciaB.BackColor = System.Drawing.Color.Transparent
        Me.RicominciaB.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RicominciaB.Location = New System.Drawing.Point(485, 327)
        Me.RicominciaB.Name = "RicominciaB"
        Me.RicominciaB.Size = New System.Drawing.Size(256, 76)
        Me.RicominciaB.TabIndex = 37
        Me.RicominciaB.Text = "Esci"
        Me.RicominciaB.UseVisualStyleBackColor = False
        Me.RicominciaB.Visible = False
        '
        'Gioco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tombolona.My.Resources.Resources.BGjpg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1361, 949)
        Me.Controls.Add(Me.RicominciaB)
        Me.Controls.Add(Me.WinL)
        Me.Controls.Add(Me.CinquinaL)
        Me.Controls.Add(Me.TerzinaL)
        Me.Controls.Add(Me.QuartinaL)
        Me.Controls.Add(Me.AmboL)
        Me.Controls.Add(Me.EstraiB)
        Me.Controls.Add(Me.C27)
        Me.Controls.Add(Me.C26)
        Me.Controls.Add(Me.C25)
        Me.Controls.Add(Me.C24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.C23)
        Me.Controls.Add(Me.C22)
        Me.Controls.Add(Me.C21)
        Me.Controls.Add(Me.C20)
        Me.Controls.Add(Me.C19)
        Me.Controls.Add(Me.C18)
        Me.Controls.Add(Me.C17)
        Me.Controls.Add(Me.C16)
        Me.Controls.Add(Me.C15)
        Me.Controls.Add(Me.C14)
        Me.Controls.Add(Me.C13)
        Me.Controls.Add(Me.C12)
        Me.Controls.Add(Me.C11)
        Me.Controls.Add(Me.C10)
        Me.Controls.Add(Me.C9)
        Me.Controls.Add(Me.C8)
        Me.Controls.Add(Me.C7)
        Me.Controls.Add(Me.C6)
        Me.Controls.Add(Me.C5)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.NeL)
        Me.Controls.Add(Me.NestrattoL)
        Me.Controls.Add(Me.Carta)
        Me.Name = "Gioco"
        Me.Text = "Gioco"
        CType(Me.Carta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Carta As PictureBox
    Friend WithEvents NestrattoL As Label
    Friend WithEvents NeL As Label
    Friend WithEvents C1 As Label
    Friend WithEvents C2 As Label
    Friend WithEvents C3 As Label
    Friend WithEvents C4 As Label
    Friend WithEvents C5 As Label
    Friend WithEvents C6 As Label
    Friend WithEvents C7 As Label
    Friend WithEvents C8 As Label
    Friend WithEvents C9 As Label
    Friend WithEvents C10 As Label
    Friend WithEvents C11 As Label
    Friend WithEvents C12 As Label
    Friend WithEvents C13 As Label
    Friend WithEvents C14 As Label
    Friend WithEvents C15 As Label
    Friend WithEvents C16 As Label
    Friend WithEvents C17 As Label
    Friend WithEvents C18 As Label
    Friend WithEvents C19 As Label
    Friend WithEvents C20 As Label
    Friend WithEvents C21 As Label
    Friend WithEvents C22 As Label
    Friend WithEvents C23 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents C24 As Label
    Friend WithEvents C25 As Label
    Friend WithEvents C26 As Label
    Friend WithEvents C27 As Label
    Friend WithEvents EstraiB As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AmboL As Label
    Friend WithEvents QuartinaL As Label
    Friend WithEvents TerzinaL As Label
    Friend WithEvents CinquinaL As Label
    Friend WithEvents WinL As Label
    Friend WithEvents RicominciaB As Button
End Class
