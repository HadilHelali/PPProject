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
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Date_Naissance = New System.Windows.Forms.DateTimePicker()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Prenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Titre_Emploi = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sexe = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LieuResidence = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Num_Tel = New System.Windows.Forms.TextBox()
        Me.Coordonnees_Perso = New System.Windows.Forms.GroupBox()
        Me.Position = New System.Windows.Forms.GroupBox()
        Me.Date_Emploi = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Coordonnees_Perso.SuspendLayout()
        Me.Position.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.PowderBlue
        Me.SaveButton.Location = New System.Drawing.Point(296, 362)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(211, 55)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Date_Naissance
        '
        Me.Date_Naissance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Naissance.Location = New System.Drawing.Point(343, 76)
        Me.Date_Naissance.Name = "Date_Naissance"
        Me.Date_Naissance.Size = New System.Drawing.Size(102, 27)
        Me.Date_Naissance.TabIndex = 1
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(83, 32)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(134, 27)
        Me.Nom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom"
        '
        'Prenom
        '
        Me.Prenom.Location = New System.Drawing.Point(298, 32)
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(147, 27)
        Me.Prenom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prénom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Titre d'emploi"
        '
        'Titre_Emploi
        '
        Me.Titre_Emploi.FormattingEnabled = True
        Me.Titre_Emploi.Location = New System.Drawing.Point(132, 36)
        Me.Titre_Emploi.Name = "Titre_Emploi"
        Me.Titre_Emploi.Size = New System.Drawing.Size(169, 28)
        Me.Titre_Emploi.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sexe"
        '
        'Sexe
        '
        Me.Sexe.FormattingEnabled = True
        Me.Sexe.Location = New System.Drawing.Point(83, 76)
        Me.Sexe.Name = "Sexe"
        Me.Sexe.Size = New System.Drawing.Size(114, 28)
        Me.Sexe.TabIndex = 11
        Me.Sexe.Text = "Femme"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Date de naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(452, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Lieu de résidence"
        '
        'LieuResidence
        '
        Me.LieuResidence.Location = New System.Drawing.Point(582, 32)
        Me.LieuResidence.Name = "LieuResidence"
        Me.LieuResidence.Size = New System.Drawing.Size(147, 27)
        Me.LieuResidence.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(452, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Numéro de Tel"
        '
        'Num_Tel
        '
        Me.Num_Tel.Location = New System.Drawing.Point(582, 76)
        Me.Num_Tel.Name = "Num_Tel"
        Me.Num_Tel.Size = New System.Drawing.Size(147, 27)
        Me.Num_Tel.TabIndex = 16
        '
        'Coordonnees_Perso
        '
        Me.Coordonnees_Perso.Controls.Add(Me.Num_Tel)
        Me.Coordonnees_Perso.Controls.Add(Me.LieuResidence)
        Me.Coordonnees_Perso.Controls.Add(Me.Label7)
        Me.Coordonnees_Perso.Controls.Add(Me.Label8)
        Me.Coordonnees_Perso.Controls.Add(Me.Prenom)
        Me.Coordonnees_Perso.Controls.Add(Me.Label2)
        Me.Coordonnees_Perso.Controls.Add(Me.Label6)
        Me.Coordonnees_Perso.Controls.Add(Me.Date_Naissance)
        Me.Coordonnees_Perso.Controls.Add(Me.Label5)
        Me.Coordonnees_Perso.Controls.Add(Me.Label1)
        Me.Coordonnees_Perso.Controls.Add(Me.Sexe)
        Me.Coordonnees_Perso.Controls.Add(Me.Nom)
        Me.Coordonnees_Perso.Location = New System.Drawing.Point(21, 79)
        Me.Coordonnees_Perso.Name = "Coordonnees_Perso"
        Me.Coordonnees_Perso.Size = New System.Drawing.Size(752, 123)
        Me.Coordonnees_Perso.TabIndex = 16
        Me.Coordonnees_Perso.TabStop = False
        Me.Coordonnees_Perso.Text = "Coordonnées Personnelles"
        '
        'Position
        '
        Me.Position.Controls.Add(Me.Date_Emploi)
        Me.Position.Controls.Add(Me.Label3)
        Me.Position.Controls.Add(Me.Titre_Emploi)
        Me.Position.Controls.Add(Me.Label4)
        Me.Position.Location = New System.Drawing.Point(21, 214)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(752, 125)
        Me.Position.TabIndex = 17
        Me.Position.TabStop = False
        Me.Position.Text = "Position"
        '
        'Date_Emploi
        '
        Me.Date_Emploi.Location = New System.Drawing.Point(457, 37)
        Me.Date_Emploi.Name = "Date_Emploi"
        Me.Date_Emploi.Size = New System.Drawing.Size(272, 27)
        Me.Date_Emploi.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Date d'emploi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Coordonnees_Perso)
        Me.Controls.Add(Me.SaveButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Coordonnees_Perso.ResumeLayout(False)
        Me.Coordonnees_Perso.PerformLayout()
        Me.Position.ResumeLayout(False)
        Me.Position.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveButton As Button
    Friend WithEvents Date_Naissance As DateTimePicker
    Friend WithEvents Nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Prenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Titre_Emploi As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Sexe As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LieuResidence As TextBox
    Friend WithEvents Num_Tel As TextBox
    Friend WithEvents Coordonnees_Perso As GroupBox
    Friend WithEvents Position As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Emploi As DateTimePicker
End Class
