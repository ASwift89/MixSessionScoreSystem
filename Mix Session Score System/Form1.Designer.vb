<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSongTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBPM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnSaveSession = New System.Windows.Forms.Button()
        Me.chkVocalsEdited = New System.Windows.Forms.CheckBox()
        Me.chkLevelIsBalanced = New System.Windows.Forms.CheckBox()
        Me.chkEQCleanup = New System.Windows.Forms.CheckBox()
        Me.chkCompression = New System.Windows.Forms.CheckBox()
        Me.chkDeBreath = New System.Windows.Forms.CheckBox()
        Me.chkDeEssing = New System.Windows.Forms.CheckBox()
        Me.chkExportSettings = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Song Title"
        '
        'txtSongTitle
        '
        Me.txtSongTitle.Location = New System.Drawing.Point(66, 3)
        Me.txtSongTitle.Name = "txtSongTitle"
        Me.txtSongTitle.Size = New System.Drawing.Size(100, 23)
        Me.txtSongTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BPM"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(66, 40)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(100, 23)
        Me.txtArtist.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Key"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(65, 77)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(100, 23)
        Me.txtKey.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Artist"
        '
        'txtBPM
        '
        Me.txtBPM.Location = New System.Drawing.Point(65, 115)
        Me.txtBPM.Name = "txtBPM"
        Me.txtBPM.Size = New System.Drawing.Size(100, 23)
        Me.txtBPM.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-1, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(66, 175)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(354, 91)
        Me.txtNotes.TabIndex = 10
        '
        'btnSaveSession
        '
        Me.btnSaveSession.Location = New System.Drawing.Point(189, 328)
        Me.btnSaveSession.Name = "btnSaveSession"
        Me.btnSaveSession.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveSession.TabIndex = 11
        Me.btnSaveSession.Text = "Save Session"
        Me.btnSaveSession.UseVisualStyleBackColor = True
        '
        'chkVocalsEdited
        '
        Me.chkVocalsEdited.AutoSize = True
        Me.chkVocalsEdited.Location = New System.Drawing.Point(504, 5)
        Me.chkVocalsEdited.Name = "chkVocalsEdited"
        Me.chkVocalsEdited.Size = New System.Drawing.Size(95, 19)
        Me.chkVocalsEdited.TabIndex = 12
        Me.chkVocalsEdited.Text = "Vocals Edited" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkVocalsEdited.UseVisualStyleBackColor = True
        '
        'chkLevelIsBalanced
        '
        Me.chkLevelIsBalanced.AutoSize = True
        Me.chkLevelIsBalanced.Location = New System.Drawing.Point(504, 42)
        Me.chkLevelIsBalanced.Name = "chkLevelIsBalanced"
        Me.chkLevelIsBalanced.Size = New System.Drawing.Size(150, 19)
        Me.chkLevelIsBalanced.TabIndex = 13
        Me.chkLevelIsBalanced.Text = "Gain Staging COmplete"
        Me.chkLevelIsBalanced.UseVisualStyleBackColor = True
        '
        'chkEQCleanup
        '
        Me.chkEQCleanup.AutoSize = True
        Me.chkEQCleanup.Location = New System.Drawing.Point(504, 81)
        Me.chkEQCleanup.Name = "chkEQCleanup"
        Me.chkEQCleanup.Size = New System.Drawing.Size(143, 19)
        Me.chkEQCleanup.TabIndex = 14
        Me.chkEQCleanup.Text = "EQ Cleanup Complete"
        Me.chkEQCleanup.UseVisualStyleBackColor = True
        '
        'chkCompression
        '
        Me.chkCompression.AutoSize = True
        Me.chkCompression.Location = New System.Drawing.Point(504, 121)
        Me.chkCompression.Name = "chkCompression"
        Me.chkCompression.Size = New System.Drawing.Size(140, 19)
        Me.chkCompression.TabIndex = 15
        Me.chkCompression.Text = "Compression Applied"
        Me.chkCompression.UseVisualStyleBackColor = True
        '
        'chkDeBreath
        '
        Me.chkDeBreath.AutoSize = True
        Me.chkDeBreath.Location = New System.Drawing.Point(504, 159)
        Me.chkDeBreath.Name = "chkDeBreath"
        Me.chkDeBreath.Size = New System.Drawing.Size(151, 19)
        Me.chkDeBreath.TabIndex = 16
        Me.chkDeBreath.Text = "De-Breathing Complete"
        Me.chkDeBreath.UseVisualStyleBackColor = True
        '
        'chkDeEssing
        '
        Me.chkDeEssing.AutoSize = True
        Me.chkDeEssing.Location = New System.Drawing.Point(504, 196)
        Me.chkDeEssing.Name = "chkDeEssing"
        Me.chkDeEssing.Size = New System.Drawing.Size(123, 19)
        Me.chkDeEssing.TabIndex = 17
        Me.chkDeEssing.Text = "De-Essing Comple"
        Me.chkDeEssing.UseVisualStyleBackColor = True
        '
        'chkExportSettings
        '
        Me.chkExportSettings.AutoSize = True
        Me.chkExportSettings.Location = New System.Drawing.Point(504, 232)
        Me.chkExportSettings.Name = "chkExportSettings"
        Me.chkExportSettings.Size = New System.Drawing.Size(153, 19)
        Me.chkExportSettings.TabIndex = 18
        Me.chkExportSettings.Text = "Export Settings Checked"
        Me.chkExportSettings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkExportSettings)
        Me.Controls.Add(Me.chkDeEssing)
        Me.Controls.Add(Me.chkDeBreath)
        Me.Controls.Add(Me.chkCompression)
        Me.Controls.Add(Me.chkEQCleanup)
        Me.Controls.Add(Me.chkLevelIsBalanced)
        Me.Controls.Add(Me.chkVocalsEdited)
        Me.Controls.Add(Me.btnSaveSession)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBPM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSongTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mix Session TM Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSongTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBPM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnSaveSession As Button
    Friend WithEvents chkVocalsEdited As CheckBox
    Friend WithEvents chkLevelIsBalanced As CheckBox
    Friend WithEvents chkEQCleanup As CheckBox
    Friend WithEvents chkCompression As CheckBox
    Friend WithEvents chkDeBreath As CheckBox
    Friend WithEvents chkDeEssing As CheckBox
    Friend WithEvents chkExportSettings As CheckBox
End Class
