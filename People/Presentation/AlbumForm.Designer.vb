﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlbumForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.songsBox = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.artistBox = New System.Windows.Forms.TextBox()
        Me.releaseTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextbox = New System.Windows.Forms.TextBox()
        Me.artistLabel = New System.Windows.Forms.Label()
        Me.releaseDateLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.lengthLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'songsBox
        '
        Me.songsBox.FormattingEnabled = True
        Me.songsBox.Location = New System.Drawing.Point(43, 208)
        Me.songsBox.Name = "songsBox"
        Me.songsBox.Size = New System.Drawing.Size(256, 134)
        Me.songsBox.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(385, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 194)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'artistBox
        '
        Me.artistBox.Location = New System.Drawing.Point(174, 95)
        Me.artistBox.Name = "artistBox"
        Me.artistBox.Size = New System.Drawing.Size(100, 20)
        Me.artistBox.TabIndex = 13
        '
        'releaseTextBox
        '
        Me.releaseTextBox.Location = New System.Drawing.Point(174, 64)
        Me.releaseTextBox.Name = "releaseTextBox"
        Me.releaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.releaseTextBox.TabIndex = 12
        '
        'nameTextbox
        '
        Me.nameTextbox.Location = New System.Drawing.Point(174, 35)
        Me.nameTextbox.Name = "nameTextbox"
        Me.nameTextbox.Size = New System.Drawing.Size(100, 20)
        Me.nameTextbox.TabIndex = 11
        '
        'artistLabel
        '
        Me.artistLabel.AutoSize = True
        Me.artistLabel.Location = New System.Drawing.Point(95, 98)
        Me.artistLabel.Name = "artistLabel"
        Me.artistLabel.Size = New System.Drawing.Size(30, 13)
        Me.artistLabel.TabIndex = 10
        Me.artistLabel.Text = "Artist"
        '
        'releaseDateLabel
        '
        Me.releaseDateLabel.AutoSize = True
        Me.releaseDateLabel.Location = New System.Drawing.Point(95, 67)
        Me.releaseDateLabel.Name = "releaseDateLabel"
        Me.releaseDateLabel.Size = New System.Drawing.Size(72, 13)
        Me.releaseDateLabel.TabIndex = 9
        Me.releaseDateLabel.Text = "Release Date"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(95, 38)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Name"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(12, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(35, 22)
        Me.backButton.TabIndex = 16
        Me.backButton.Text = "<--"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'lengthTextBox
        '
        Me.lengthTextBox.Location = New System.Drawing.Point(174, 132)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lengthTextBox.TabIndex = 17
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(95, 135)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(40, 13)
        Me.lengthLabel.TabIndex = 18
        Me.lengthLabel.Text = "Length"
        '
        'AlbumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(665, 386)
        Me.Controls.Add(Me.lengthLabel)
        Me.Controls.Add(Me.lengthTextBox)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.songsBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.artistBox)
        Me.Controls.Add(Me.releaseTextBox)
        Me.Controls.Add(Me.nameTextbox)
        Me.Controls.Add(Me.artistLabel)
        Me.Controls.Add(Me.releaseDateLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "AlbumForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Songify"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents songsBox As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents artistBox As TextBox
    Friend WithEvents releaseTextBox As TextBox
    Friend WithEvents nameTextbox As TextBox
    Friend WithEvents artistLabel As Label
    Friend WithEvents releaseDateLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents backButton As Button
    Friend WithEvents lengthTextBox As TextBox
    Friend WithEvents lengthLabel As Label
End Class
