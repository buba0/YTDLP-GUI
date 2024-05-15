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
        Me.LinkBox = New System.Windows.Forms.TextBox()
        Me.LinkPaste = New System.Windows.Forms.Button()
        Me.MediaTypeAudio = New System.Windows.Forms.RadioButton()
        Me.MediaTypeVideo = New System.Windows.Forms.RadioButton()
        Me.FileTypeMP3 = New System.Windows.Forms.RadioButton()
        Me.FileTypeWAV = New System.Windows.Forms.RadioButton()
        Me.FileTypeOGG = New System.Windows.Forms.RadioButton()
        Me.FileTypeFLAC = New System.Windows.Forms.RadioButton()
        Me.FileTypeMP4 = New System.Windows.Forms.RadioButton()
        Me.FileTypeFLV = New System.Windows.Forms.RadioButton()
        Me.FileTypeMKV = New System.Windows.Forms.RadioButton()
        Me.FileTypeAVI = New System.Windows.Forms.RadioButton()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.MediaGroupBox = New System.Windows.Forms.GroupBox()
        Me.AudioFileTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.VideoFileTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.QualityGroupBox = New System.Windows.Forms.GroupBox()
        Me.QualityWorst = New System.Windows.Forms.RadioButton()
        Me.QualityBest = New System.Windows.Forms.RadioButton()
        Me.MediaGroupBox.SuspendLayout()
        Me.AudioFileTypeGroupBox.SuspendLayout()
        Me.VideoFileTypeGroupBox.SuspendLayout()
        Me.QualityGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkBox
        '
        Me.LinkBox.Location = New System.Drawing.Point(12, 45)
        Me.LinkBox.Multiline = True
        Me.LinkBox.Name = "LinkBox"
        Me.LinkBox.Size = New System.Drawing.Size(331, 40)
        Me.LinkBox.TabIndex = 0
        '
        'LinkPaste
        '
        Me.LinkPaste.Location = New System.Drawing.Point(361, 45)
        Me.LinkPaste.Name = "LinkPaste"
        Me.LinkPaste.Size = New System.Drawing.Size(75, 40)
        Me.LinkPaste.TabIndex = 1
        Me.LinkPaste.Text = "Paste from clipboard"
        Me.LinkPaste.UseVisualStyleBackColor = True
        '
        'MediaTypeAudio
        '
        Me.MediaTypeAudio.AutoSize = True
        Me.MediaTypeAudio.Location = New System.Drawing.Point(11, 19)
        Me.MediaTypeAudio.Name = "MediaTypeAudio"
        Me.MediaTypeAudio.Size = New System.Drawing.Size(52, 17)
        Me.MediaTypeAudio.TabIndex = 2
        Me.MediaTypeAudio.TabStop = True
        Me.MediaTypeAudio.Text = "Audio"
        Me.MediaTypeAudio.UseVisualStyleBackColor = True
        '
        'MediaTypeVideo
        '
        Me.MediaTypeVideo.AutoSize = True
        Me.MediaTypeVideo.Location = New System.Drawing.Point(106, 19)
        Me.MediaTypeVideo.Name = "MediaTypeVideo"
        Me.MediaTypeVideo.Size = New System.Drawing.Size(52, 17)
        Me.MediaTypeVideo.TabIndex = 3
        Me.MediaTypeVideo.TabStop = True
        Me.MediaTypeVideo.Text = "Video"
        Me.MediaTypeVideo.UseVisualStyleBackColor = True
        '
        'FileTypeMP3
        '
        Me.FileTypeMP3.AutoSize = True
        Me.FileTypeMP3.Location = New System.Drawing.Point(6, 19)
        Me.FileTypeMP3.Name = "FileTypeMP3"
        Me.FileTypeMP3.Size = New System.Drawing.Size(47, 17)
        Me.FileTypeMP3.TabIndex = 6
        Me.FileTypeMP3.TabStop = True
        Me.FileTypeMP3.Text = "MP3"
        Me.FileTypeMP3.UseVisualStyleBackColor = True
        '
        'FileTypeWAV
        '
        Me.FileTypeWAV.AutoSize = True
        Me.FileTypeWAV.Location = New System.Drawing.Point(6, 42)
        Me.FileTypeWAV.Name = "FileTypeWAV"
        Me.FileTypeWAV.Size = New System.Drawing.Size(50, 17)
        Me.FileTypeWAV.TabIndex = 7
        Me.FileTypeWAV.TabStop = True
        Me.FileTypeWAV.Text = "WAV"
        Me.FileTypeWAV.UseVisualStyleBackColor = True
        '
        'FileTypeOGG
        '
        Me.FileTypeOGG.AutoSize = True
        Me.FileTypeOGG.Location = New System.Drawing.Point(6, 65)
        Me.FileTypeOGG.Name = "FileTypeOGG"
        Me.FileTypeOGG.Size = New System.Drawing.Size(49, 17)
        Me.FileTypeOGG.TabIndex = 8
        Me.FileTypeOGG.TabStop = True
        Me.FileTypeOGG.Text = "OGG"
        Me.FileTypeOGG.UseVisualStyleBackColor = True
        '
        'FileTypeFLAC
        '
        Me.FileTypeFLAC.AutoSize = True
        Me.FileTypeFLAC.Location = New System.Drawing.Point(6, 88)
        Me.FileTypeFLAC.Name = "FileTypeFLAC"
        Me.FileTypeFLAC.Size = New System.Drawing.Size(51, 17)
        Me.FileTypeFLAC.TabIndex = 9
        Me.FileTypeFLAC.TabStop = True
        Me.FileTypeFLAC.Text = "FLAC"
        Me.FileTypeFLAC.UseVisualStyleBackColor = True
        '
        'FileTypeMP4
        '
        Me.FileTypeMP4.AutoSize = True
        Me.FileTypeMP4.Location = New System.Drawing.Point(6, 19)
        Me.FileTypeMP4.Name = "FileTypeMP4"
        Me.FileTypeMP4.Size = New System.Drawing.Size(47, 17)
        Me.FileTypeMP4.TabIndex = 10
        Me.FileTypeMP4.TabStop = True
        Me.FileTypeMP4.Text = "MP4"
        Me.FileTypeMP4.UseVisualStyleBackColor = True
        '
        'FileTypeFLV
        '
        Me.FileTypeFLV.AutoSize = True
        Me.FileTypeFLV.Location = New System.Drawing.Point(6, 42)
        Me.FileTypeFLV.Name = "FileTypeFLV"
        Me.FileTypeFLV.Size = New System.Drawing.Size(44, 17)
        Me.FileTypeFLV.TabIndex = 11
        Me.FileTypeFLV.TabStop = True
        Me.FileTypeFLV.Text = "FLV"
        Me.FileTypeFLV.UseVisualStyleBackColor = True
        '
        'FileTypeMKV
        '
        Me.FileTypeMKV.AutoSize = True
        Me.FileTypeMKV.Location = New System.Drawing.Point(6, 65)
        Me.FileTypeMKV.Name = "FileTypeMKV"
        Me.FileTypeMKV.Size = New System.Drawing.Size(48, 17)
        Me.FileTypeMKV.TabIndex = 12
        Me.FileTypeMKV.TabStop = True
        Me.FileTypeMKV.Text = "MKV"
        Me.FileTypeMKV.UseVisualStyleBackColor = True
        '
        'FileTypeAVI
        '
        Me.FileTypeAVI.AutoSize = True
        Me.FileTypeAVI.Location = New System.Drawing.Point(6, 88)
        Me.FileTypeAVI.Name = "FileTypeAVI"
        Me.FileTypeAVI.Size = New System.Drawing.Size(42, 17)
        Me.FileTypeAVI.TabIndex = 13
        Me.FileTypeAVI.TabStop = True
        Me.FileTypeAVI.Text = "AVI"
        Me.FileTypeAVI.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(22, 222)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(437, 23)
        Me.DownloadButton.TabIndex = 14
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'MediaGroupBox
        '
        Me.MediaGroupBox.Controls.Add(Me.MediaTypeAudio)
        Me.MediaGroupBox.Controls.Add(Me.MediaTypeVideo)
        Me.MediaGroupBox.Location = New System.Drawing.Point(11, 91)
        Me.MediaGroupBox.Name = "MediaGroupBox"
        Me.MediaGroupBox.Size = New System.Drawing.Size(200, 49)
        Me.MediaGroupBox.TabIndex = 15
        Me.MediaGroupBox.TabStop = False
        Me.MediaGroupBox.Text = "Media Type"
        '
        'AudioFileTypeGroupBox
        '
        Me.AudioFileTypeGroupBox.Controls.Add(Me.FileTypeFLAC)
        Me.AudioFileTypeGroupBox.Controls.Add(Me.FileTypeOGG)
        Me.AudioFileTypeGroupBox.Controls.Add(Me.FileTypeWAV)
        Me.AudioFileTypeGroupBox.Controls.Add(Me.FileTypeMP3)
        Me.AudioFileTypeGroupBox.Location = New System.Drawing.Point(218, 91)
        Me.AudioFileTypeGroupBox.Name = "AudioFileTypeGroupBox"
        Me.AudioFileTypeGroupBox.Size = New System.Drawing.Size(64, 113)
        Me.AudioFileTypeGroupBox.TabIndex = 17
        Me.AudioFileTypeGroupBox.TabStop = False
        Me.AudioFileTypeGroupBox.Text = "Audio"
        '
        'VideoFileTypeGroupBox
        '
        Me.VideoFileTypeGroupBox.Controls.Add(Me.FileTypeAVI)
        Me.VideoFileTypeGroupBox.Controls.Add(Me.FileTypeMP4)
        Me.VideoFileTypeGroupBox.Controls.Add(Me.FileTypeFLV)
        Me.VideoFileTypeGroupBox.Controls.Add(Me.FileTypeMKV)
        Me.VideoFileTypeGroupBox.Location = New System.Drawing.Point(289, 91)
        Me.VideoFileTypeGroupBox.Name = "VideoFileTypeGroupBox"
        Me.VideoFileTypeGroupBox.Size = New System.Drawing.Size(65, 113)
        Me.VideoFileTypeGroupBox.TabIndex = 18
        Me.VideoFileTypeGroupBox.TabStop = False
        Me.VideoFileTypeGroupBox.Text = "Video"
        '
        'QualityGroupBox
        '
        Me.QualityGroupBox.Controls.Add(Me.QualityWorst)
        Me.QualityGroupBox.Controls.Add(Me.QualityBest)
        Me.QualityGroupBox.Location = New System.Drawing.Point(12, 145)
        Me.QualityGroupBox.Name = "QualityGroupBox"
        Me.QualityGroupBox.Size = New System.Drawing.Size(199, 48)
        Me.QualityGroupBox.TabIndex = 16
        Me.QualityGroupBox.TabStop = False
        Me.QualityGroupBox.Text = "Quality"
        '
        'QualityWorst
        '
        Me.QualityWorst.AutoSize = True
        Me.QualityWorst.Location = New System.Drawing.Point(10, 19)
        Me.QualityWorst.Name = "QualityWorst"
        Me.QualityWorst.Size = New System.Drawing.Size(53, 17)
        Me.QualityWorst.TabIndex = 4
        Me.QualityWorst.TabStop = True
        Me.QualityWorst.Text = "Worst"
        Me.QualityWorst.UseVisualStyleBackColor = True
        '
        'QualityBest
        '
        Me.QualityBest.AutoSize = True
        Me.QualityBest.Location = New System.Drawing.Point(105, 19)
        Me.QualityBest.Name = "QualityBest"
        Me.QualityBest.Size = New System.Drawing.Size(46, 17)
        Me.QualityBest.TabIndex = 5
        Me.QualityBest.TabStop = True
        Me.QualityBest.Text = "Best"
        Me.QualityBest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 268)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.LinkPaste)
        Me.Controls.Add(Me.LinkBox)
        Me.Controls.Add(Me.MediaGroupBox)
        Me.Controls.Add(Me.QualityGroupBox)
        Me.Controls.Add(Me.AudioFileTypeGroupBox)
        Me.Controls.Add(Me.VideoFileTypeGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MediaGroupBox.ResumeLayout(False)
        Me.MediaGroupBox.PerformLayout()
        Me.AudioFileTypeGroupBox.ResumeLayout(False)
        Me.AudioFileTypeGroupBox.PerformLayout()
        Me.VideoFileTypeGroupBox.ResumeLayout(False)
        Me.VideoFileTypeGroupBox.PerformLayout()
        Me.QualityGroupBox.ResumeLayout(False)
        Me.QualityGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkBox As TextBox
    Friend WithEvents LinkPaste As Button
    Friend WithEvents MediaTypeAudio As RadioButton
    Friend WithEvents MediaTypeVideo As RadioButton
    Friend WithEvents FileTypeMP3 As RadioButton
    Friend WithEvents FileTypeWAV As RadioButton
    Friend WithEvents FileTypeOGG As RadioButton
    Friend WithEvents FileTypeFLAC As RadioButton
    Friend WithEvents FileTypeMP4 As RadioButton
    Friend WithEvents FileTypeFLV As RadioButton
    Friend WithEvents FileTypeMKV As RadioButton
    Friend WithEvents FileTypeAVI As RadioButton
    Friend WithEvents DownloadButton As Button
    Friend WithEvents MediaGroupBox As GroupBox
    Friend WithEvents AudioFileTypeGroupBox As GroupBox
    Friend WithEvents VideoFileTypeGroupBox As GroupBox
    Friend WithEvents QualityGroupBox As GroupBox
    Friend WithEvents QualityWorst As RadioButton
    Friend WithEvents QualityBest As RadioButton
End Class
