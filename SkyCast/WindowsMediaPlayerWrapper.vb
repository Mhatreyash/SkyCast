Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports AxWMPLib

Public Class WindowsMediaPlayerWrapper
    Inherits AxWindowsMediaPlayer
    Implements ISupportInitialize

    Private uiMode As String
    Private stretchToFit As Boolean

    Public Sub BeginInit() Implements ISupportInitialize.BeginInit
    End Sub

    Public Sub EndInit() Implements ISupportInitialize.EndInit
        uiMode = "none" ' Hide controls
        stretchToFit = True ' Stretch video to fill the control
    End Sub
End Class
