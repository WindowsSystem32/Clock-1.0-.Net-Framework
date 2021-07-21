Imports System.Windows.Forms

Public Class About

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Shell("explorer.exe https://github.com/WindowsSystem32")
    End Sub
End Class
