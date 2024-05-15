Imports System.Diagnostics

Public Class Form1

    ' Handle CheckedChanged event for Media type radio buttons
    Private Sub MediaType_CheckedChanged(sender As Object, e As EventArgs) Handles MediaTypeAudio.CheckedChanged, MediaTypeVideo.CheckedChanged
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)

        ' Disable file type radio buttons if the opposite media type is selected
        If radioButton.Checked Then
            If radioButton Is MediaTypeAudio Then
                EnableFileTypes(AudioFileTypeGroupBox, True)
                EnableFileTypes(VideoFileTypeGroupBox, False)
            ElseIf radioButton Is MediaTypeVideo Then
                EnableFileTypes(AudioFileTypeGroupBox, False)
                EnableFileTypes(VideoFileTypeGroupBox, True)
            End If
        End If
    End Sub

    ' Function to enable or disable radio buttons in a group box
    Private Sub EnableFileTypes(groupBox As GroupBox, enable As Boolean)
        For Each ctrl As Control In groupBox.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Enabled = enable
            End If
        Next
    End Sub

    ' Handle CheckedChanged event for Audio File type radio buttons
    Private Sub AudioFileType_CheckedChanged(sender As Object, e As EventArgs) Handles FileTypeMP3.CheckedChanged, FileTypeWAV.CheckedChanged, FileTypeOGG.CheckedChanged, FileTypeFLAC.CheckedChanged
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)

        ' Uncheck video file type radio buttons if an audio file type is selected
        If radioButton.Checked Then
            For Each ctrl As Control In VideoFileTypeGroupBox.Controls
                If TypeOf ctrl Is RadioButton Then
                    DirectCast(ctrl, RadioButton).Checked = False
                End If
            Next
        End If
    End Sub

    ' Handle CheckedChanged event for Video File type radio buttons
    Private Sub VideoFileType_CheckedChanged(sender As Object, e As EventArgs) Handles FileTypeMP4.CheckedChanged, FileTypeFLV.CheckedChanged, FileTypeMKV.CheckedChanged, FileTypeAVI.CheckedChanged
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)

        ' Uncheck audio file type radio buttons if a video file type is selected
        If radioButton.Checked Then
            For Each ctrl As Control In AudioFileTypeGroupBox.Controls
                If TypeOf ctrl Is RadioButton Then
                    DirectCast(ctrl, RadioButton).Checked = False
                End If
            Next
        End If
    End Sub

    ' Handle CheckedChanged event for Quality radio buttons
    Private Sub Quality_CheckedChanged(sender As Object, e As EventArgs) Handles QualityBest.CheckedChanged, QualityWorst.CheckedChanged
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)

        ' Uncheck other radio buttons in the same group box
        If radioButton.Checked Then
            For Each ctrl As Control In QualityGroupBox.Controls
                If TypeOf ctrl Is RadioButton AndAlso ctrl IsNot radioButton Then
                    DirectCast(ctrl, RadioButton).Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub LinkPaste_Click(sender As Object, e As EventArgs) Handles LinkPaste.Click
        ' Paste the link from clipboard to the LinkBox
        LinkBox.Text = Clipboard.GetText()
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        ' Construct the command for yt-dlp.exe based on user's selections
        Dim command As String = "yt-dlp.exe "

        ' Add the link from the LinkBox
        command &= LinkBox.Text & " "

        ' Add media type
        If MediaTypeAudio.Checked Then
            command &= "--extract-audio "
        ElseIf MediaTypeVideo.Checked Then
            command &= "--format bestvideo+bestaudio "
        End If

        ' Add file type
        If MediaTypeAudio.Checked Then
            If FileTypeMP3.Checked Then
                command &= "--audio-format mp3 "
            ElseIf FileTypeWAV.Checked Then
                command &= "--audio-format wav "
            ElseIf FileTypeOGG.Checked Then
                command &= "--audio-format ogg "
            ElseIf FileTypeFLAC.Checked Then
                command &= "--audio-format flac "
            End If
        ElseIf MediaTypeVideo.Checked Then
            If FileTypeMP4.Checked Then
                command &= "--merge-output-format mp4 "
            ElseIf FileTypeFLV.Checked Then
                command &= "--merge-output-format flv "
            ElseIf FileTypeMKV.Checked Then
                command &= "--merge-output-format mkv "
            ElseIf FileTypeAVI.Checked Then
                command &= "--merge-output-format avi "
            End If
        End If

        ' Start the process to run yt-dlp.exe
        Dim processInfo As New ProcessStartInfo("cmd.exe")
        processInfo.Arguments = "/k " & command ' /k keeps the window open after execution
        Process.Start(processInfo)
    End Sub
End Class
