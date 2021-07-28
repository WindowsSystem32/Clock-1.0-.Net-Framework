Imports System.ComponentModel

Public Class Debug_Form
    Private Sub Debug_Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rtb.Size = New Size(Width - 16, Height - 39)
    End Sub

    Private Sub Debug_Form_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.btn_debug.Text = "Debug"
    End Sub
End Class