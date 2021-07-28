Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports Microsoft.Win32

Public Class Main
    Dim f1 As Color = Color.FromArgb(0, 255, 0)
    Dim b1 As Color = Color.FromArgb(0, 0, 0)
    Dim f2 As Color = Color.FromArgb(255, 0, 255)
    Dim b2 As Color = Color.FromArgb(255, 255, 255)
    Dim lev As Integer = 5
    Dim num As Integer() = New Integer(5) {0, 0, 0, 0, 0, 0}
    Dim chkUpd As String = "https://raw.githubusercontent.com/WindowsSystem32/Clock-1.0-.Net-Framework/main/ver.md"
    Dim downloadUpd As String = "https://github.com/WindowsSystem32/Clock-1.0-.Net-Framework/raw/main/Clock%201.0%20.Net%20Framework/bin/Debug/Clock_1._0.Net_Framework.exe"
    Dim chkUpdAtStartup As Integer = 0
    Private WithEvents wc As WebClient
    Dim sP As String
    Dim sF As String
    Dim reg1 As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        chk_reg()
        If chkUpdAtStartup = 1 Then
            CheckForUpdates()
        End If
        setTime(2)
        tmr1.Start()
        currentVer.Text = "Current version: " & Application.ProductVersion
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        tmr1.Stop()
    End Sub

    Private Function setLev(ms As Integer)
        Dim out As Integer
        If ms <= 75 Then
            out = 0
        ElseIf ms <= 150 Then
            out = 1
        ElseIf ms <= 225 Then
            out = 2
        ElseIf ms <= 300 Then
            out = 3
        ElseIf ms <= 375 Then
            out = 4
        Else
            out = 5
        End If
        Return out
    End Function

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        If btn_debug.Text = "Stop" Then
            Debug_Form.rtb.Text = "lev: " & lev & "," & vbCrLf & "num: {" & num(0) & ", " & num(1) & ", " & num(2) & ", " & num(3) & ", " & num(4) & ", " & num(5) & "}," & vbCrLf & "chkUpd: " & chkUpd & "," & vbCrLf & "downloadUpd: " & downloadUpd & "," & vbCrLf & "chkUpdAtStartup: " & chkUpdAtStartup
        End If
        If lev >= 5 Then
            setTime(1)
            Do Until Not (num(2) = num(5))
                setTime(0)
            Loop
        End If
        Dim ms As Integer = DateTime.Now.Millisecond
        Dim lev2 As Integer = setLev(ms)
        If Not (lev = lev2) Then
            lev = lev2
            clear()
            Dim h1 As Integer
            Dim h2 As Integer
            Dim h3 As Integer
            Dim h4 As Integer
            Dim m1 As Integer
            Dim m2 As Integer
            Dim m3 As Integer
            Dim m4 As Integer
            Dim s1 As Integer
            Dim s2 As Integer
            Dim s3 As Integer
            Dim s4 As Integer
            h2 = num(3) Mod 10
            h1 = (num(3) - h2) / 10
            h4 = num(0) Mod 10
            h3 = (num(0) - h4) / 10
            m2 = num(4) Mod 10
            m1 = (num(4) - m2) / 10
            m4 = num(1) Mod 10
            m3 = (num(1) - m4) / 10
            s2 = num(5) Mod 10
            s1 = (num(5) - s2) / 10
            s4 = num(2) Mod 10
            s3 = (num(2) - s4) / 10
            seg(New Point(-292, 0), h3, h1, lev)
            seg(New Point(-188, 0), h4, h2, lev)
            If num(5) Mod 2 = 0 Then
                fillEllip(f1, -120, -36, 16, 16, 100)
                fillEllip(f1, -120, 36, 16, 16, 100)
            End If
            seg(New Point(-52, 0), m3, m1, lev)
            seg(New Point(52, 0), m4, m2, lev)
            If num(5) Mod 2 = 0 Then
                fillEllip(f1, 120, -36, 16, 16, 100)
                fillEllip(f1, 120, 36, 16, 16, 100)
            End If
            seg(New Point(188, 0), s3, s1, lev)
            seg(New Point(292, 0), s4, s2, lev)
        End If
    End Sub

    Private Sub fillRect(col As Color, x As Integer, y As Integer, wid As Integer, hei As Integer, n1 As Integer)
        Dim wid2 As Integer = wid * (n1 / 100)
        Dim hei2 As Integer = hei * (n1 / 100)
        Dim half_wid2 As Integer = wid2 / 2
        Dim half_hei2 As Integer = hei2 / 2
        Dim half_pbwid As Integer = pb.Size.Width / 2
        Dim half_pbhei As Integer = pb.Size.Height / 2
        pb.CreateGraphics.FillRectangle(New SolidBrush(col), half_pbwid - half_wid2 + x, half_pbhei - half_hei2 + y, wid2, hei2)
    End Sub

    Private Sub fillEllip(col As Color, x As Integer, y As Integer, wid As Integer, hei As Integer, sz As Integer)
        Dim wid2 As Integer = wid * (sz / 100)
        Dim hei2 As Integer = hei * (sz / 100)
        Dim half_wid2 As Integer = wid2 / 2
        Dim half_hei2 As Integer = hei2 / 2
        Dim half_pbwid As Integer = pb.Size.Width / 2
        Dim half_pbhei As Integer = pb.Size.Height / 2
        pb.CreateGraphics.FillEllipse(New SolidBrush(col), half_pbwid - half_wid2 + x, half_pbhei - half_hei2 + y, wid2, hei2)
    End Sub

    Private Sub drawImg(img As Image, x As Integer, y As Integer, wid As Integer, hei As Integer, sz As Integer)
        Dim wid2 As Integer = wid * (sz / 100)
        Dim hei2 As Integer = hei * (sz / 100)
        Dim half_wid2 As Integer = wid2 / 2
        Dim half_hei2 As Integer = hei2 / 2
        Dim half_pbwid As Integer = pb.Size.Width / 2
        Dim half_pbhei As Integer = pb.Size.Height / 2
        pb.CreateGraphics.DrawImage(img, half_pbwid - half_wid2 + x, half_pbhei - half_hei2 + y, wid2, hei2)
    End Sub

    Private Sub drawLine(col As Color, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim half_pbwid As Integer = pb.Size.Width / 2
        Dim half_pbhei As Integer = pb.Size.Height / 2
        pb.CreateGraphics.DrawLine(New Pen(col), half_pbwid + x1, half_pbhei + y1, half_pbwid + x2, half_pbhei + y2)
    End Sub

    Private Sub clear()
        pb.CreateGraphics.Clear(b1)
    End Sub

    Private Sub seg(loc As Point, inf1 As Integer, inf2 As Integer, lev As Integer) 'wid: 88, hei: 160'
        '_A_'
        'B_C'
        '_D_'
        'E_F'
        '_G_'
        Dim sx As Integer = loc.X
        Dim sy As Integer = loc.Y
        Dim sz1 As Integer()
        Dim sz2 As Integer()
        Dim sz3 As Integer()
        sz1 = segf1(inf1)
        sz2 = segf1(inf2)
        sz3 = segc2(sz1, sz2, lev)
        'sz3 = sz1'
        fillRect(f1, 0 + sx, -72 + sy + sz3(7), 56, 16, sz3(0)) 'A'
        fillRect(f1, -36 + sx + sz3(8), -36 + sy, 16, 56, sz3(1)) 'B'
        fillRect(f1, 36 + sx + sz3(9), -36 + sy, 16, 56, sz3(2)) 'C'
        fillRect(f1, 0 + sx, 0 + sy, 56, 16, sz3(3)) 'D'
        fillRect(f1, -36 + sx + sz3(10), 36 + sy, 16, 56, sz3(4)) 'E'
        fillRect(f1, 36 + sx + sz3(11), 36 + sy, 16, 56, sz3(5)) 'F'
        fillRect(f1, 0 + sx, 72 + sy + sz3(12), 56, 16, sz3(6)) 'G'
    End Sub

    Private Function segf1(input As Integer)
        Dim num1 As Integer = 25
        Dim num2 As Integer = 100
        Dim output As Integer() = New Integer(12) {num2, num2, num2, num2, num2, num2, num2, 0, 0, 0, 0, 0, 0} 'wid1: 56, hei1: 16 | wid2: 14, hei2: 4'
        If input = 0 Or input = 2 Or input = 3 Or input = 5 Or input = 6 Or input = 7 Or input = 8 Or input = 9 Then 'A'
            output(0) = num2
        Else
            output(0) = num1
            output(7) = 25
        End If
        If input = 0 Or input = 4 Or input = 5 Or input = 6 Or input = 8 Or input = 9 Then 'B'
            output(1) = num2
        Else
            output(1) = num1
            output(8) = 25
        End If
        If input = 0 Or input = 1 Or input = 2 Or input = 3 Or input = 4 Or input = 7 Or input = 8 Or input = 9 Then 'C'
            output(2) = num2
        Else
            output(2) = num1
            output(9) = -25
        End If
        If input = 2 Or input = 3 Or input = 4 Or input = 5 Or input = 6 Or input = 8 Or input = 9 Then 'D'
            output(3) = num2
        Else
            output(3) = num1
        End If
        If input = 2 Or input = 6 Or input = 8 Or input = 0 Then 'E'
            output(4) = num2
        Else
            output(4) = num1
            output(10) = 25
        End If
        If input = 0 Or input = 1 Or input = 3 Or input = 4 Or input = 5 Or input = 6 Or input = 7 Or input = 8 Or input = 9 Then 'F'
            output(5) = num2
        Else
            output(5) = num1
            output(11) = -25
        End If
        If input = 0 Or input = 2 Or input = 3 Or input = 5 Or input = 6 Or input = 8 Or input = 9 Then 'G'
            output(6) = num2
        Else
            output(6) = num1
            output(12) = -25
        End If
        Return output
    End Function

    Private Function segc2(input1() As Integer, input2() As Integer, lev As Integer)
        Dim output As Integer() = New Integer(12) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} 'wid1: 56, hei1: 16 | wid2: 14, hei2: 4'
        If input1.Length = 13 And input2.Length = 13 Then
            For i = 0 To 6
                If input1(i) = input2(i) Then
                    output(i) = input1(i)
                Else
                    output(i) = ((input2(i) - input1(i)) / 5) * lev + input1(i)
                End If
            Next
            For i = 7 To 12
                If input1(i) = input2(i) Then
                    output(i) = input1(i)
                Else
                    output(i) = ((input2(i) - input1(i)) / 5) * lev + input1(i)
                End If
            Next
        End If
        Return output
    End Function

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pb.Size = New Size(Size.Width - 16, Size.Height - 62)
        btn_about.Location = New Point(0, Size.Height - 62)
        btn_upd.Location = New Point(75, Size.Height - 62)
        currentVer.Location = New Point(216, Size.Height - 58)
        btn_setting.Location = New Point(216 + currentVer.Size.Width, Size.Height - 62)
        btn_debug.Location = New Point(291 + currentVer.Size.Width, Size.Height - 62)
    End Sub

    Private Sub setTime(n As Integer)
        Dim h As Integer = DateTime.Now.Hour
        Dim m As Integer = DateTime.Now.Minute
        Dim s As Integer = DateTime.Now.Second
        If n = 0 Then
            num(3) = h
            num(4) = m
            num(5) = s
        ElseIf n = 1 Then
            num(0) = h
            num(1) = m
            num(2) = s
        Else
            num(0) = h
            num(1) = m
            num(2) = s
            num(3) = h
            num(4) = m
            num(5) = s
        End If
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        About.ShowDialog()
    End Sub

    Private Sub btn_upd_Click(sender As Object, e As EventArgs) Handles btn_upd.Click
        CheckForUpdates()
    End Sub

    Private Sub CheckForUpdates()
        Try
            Dim req As HttpWebRequest = HttpWebRequest.Create(chkUpd)
            Dim res As HttpWebResponse = req.GetResponse()
            Dim sr As StreamReader = New StreamReader(res.GetResponseStream)
            Dim cv As String = Application.ProductVersion.ToString
            Dim nv As String = sr.ReadToEnd.ToString.Trim
            If nv > cv Then
                If MsgBox("Updates are available. Do you want to update now? (" & cv & " -> " & nv & ")", vbQuestion + vbYesNo, "") = vbYes Then
                    Dim rn As New Random()
                    sP = Application.StartupPath & "\" & rn.Next(100000, 999999)
                    sF = "Clock 1.0 (" & nv & ").exe"
                    If Not (Directory.Exists(sP)) Then
                        Directory.CreateDirectory(sP)
                    ElseIf File.Exists(sP & "\" & sF) Then
                        If File.Exists(sP & "\" & sF) Then
                            sP = Application.StartupPath & "\" & rn.Next(100000, 999999)
                        End If
                    End If
                    Try
                        While File.Exists(sP & "\" & sF)
                            If Not (Directory.Exists(sP)) Then
                                Directory.CreateDirectory(sP)
                            ElseIf File.Exists(sP & "\" & sF) Then
                                If File.Exists(sP & "\" & sF) Then
                                    sP = Application.StartupPath & "\" & rn.Next(100000, 999999)
                                End If
                            End If
                        End While
                        tmr1.Stop()
                        wc = New WebClient
                        wc.DownloadFileAsync(New Uri(downloadUpd), sP & "\" & sF)
                    Catch ex As Exception
                        If ex.GetType.ToString = "System.Net.WebException" Then
                            MsgBox("Please check your Internet connection!", vbCritical, "")
                        Else
                            MsgBox("There was a problem downloading updates!" & vbCrLf & " - Error type: " & ex.GetType.ToString & vbCrLf & " - HResult:  " & ex.HResult, vbCritical, "")
                        End If
                    End Try
                End If
            Else
                MsgBox("This program is already up to date. (" & cv & ")", vbInformation, "")
            End If
        Catch ex As Exception
            If ex.GetType.ToString = "System.Net.WebException" Then
                MsgBox("Please check your Internet connection!", vbCritical, "")
            Else
                MsgBox("There was a problem checking for updates!" & vbCrLf & " - Error type: " & ex.GetType.ToString & vbCrLf & " - HResult:  " & ex.HResult, vbCritical, "")
            End If
        End Try
    End Sub

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        Dim cmd As String = "cmd /C timeout -t 1 && move " & Chr(34) & sP & "\" & sF & Chr(34) & " " & Chr(34) & Application.ExecutablePath & Chr(34) & " && rmdir /s /q " & Chr(34) & sP & Chr(34) & " && " & Chr(34) & Application.ExecutablePath & Chr(34) & " && exit"
        'MsgBox("Command: " & cmd)'
        If File.Exists(sP & "\" & sF) Then
            Shell(cmd, AppWinStyle.Hide)
            Close()
        Else
            MsgBox("There was a problem downloading updates!", vbCritical, "")
        End If
    End Sub

    Private Sub wc_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        Dim TotalBytesToReceive As Integer = e.TotalBytesToReceive
        Dim BytesReceived1 As Integer = e.BytesReceived
        Dim BytesReceived2 As Integer = ((e.BytesReceived / e.TotalBytesToReceive) * 200)
        If btn_debug.Text = "Stop" Then
            Debug_Form.rtb.Text = "lev: " & lev & "," & vbCrLf & "num: {" & num(0) & ", " & num(1) & ", " & num(2) & ", " & num(3) & ", " & num(4) & ", " & num(5) & "}," & vbCrLf & "chkUpd: " & chkUpd & "," & vbCrLf & "downloadUpd: " & downloadUpd & "," & vbCrLf & "chkUpdAtStartup: " & chkUpdAtStartup & "," & vbCrLf & "sP: " & sP & "," & vbCrLf & "sF: " & sF & "," & vbCrLf & "TotalBytesToReceive: " & TotalBytesToReceive & "," & vbCrLf & "BytesReceived: " & BytesReceived1 & "(" & BytesReceived2 & "%)"
        End If
        clear()
        fillEllip(f1, -100, 0, 5, 5, 100)
        drawLine(f1, -100, 0, -100 + BytesReceived2, 0)
        fillEllip(f1, 100, 0, 5, 5, 100)
    End Sub

    Private Sub chk_reg()
        If Not (reg1.GetSubKeyNames.Contains("Clock-1.0")) Then
            reg1.CreateSubKey("Clock-1.0")
        End If
        Dim reg2 As RegistryKey = reg1.OpenSubKey("Clock-1.0", True)
        If reg2.GetValue("chk") = Nothing Then
            reg2.SetValue("chk", chkUpd)
        Else
            chkUpd = reg2.GetValue("chk").ToString.Trim
        End If
        If reg2.GetValue("download") = Nothing Then
            reg2.SetValue("download", downloadUpd)
        Else
            downloadUpd = reg2.GetValue("download").ToString.Trim
        End If
        If reg2.GetValue("chkUpdAtStartup") = Nothing Then
            reg2.SetValue("chkUpdAtStartup", chkUpdAtStartup)
        Else
            Try
                chkUpdAtStartup = Int(reg2.GetValue("chkUpdAtStartup").ToString.Trim)
            Catch ex As Exception
                reg2.SetValue("chkUpdAtStartup", chkUpdAtStartup)
            End Try
        End If
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Setting.chkUpd.Text = chkUpd
        Setting.downloadUpd.Text = downloadUpd
        Setting.chkUpdAtStartup.Checked = (chkUpdAtStartup = 1)
        If Setting.ShowDialog = DialogResult.OK Then
            chkUpd = Setting.chkUpd.Text
            downloadUpd = Setting.downloadUpd.Text
            If Setting.chkUpdAtStartup.Checked Then
                chkUpdAtStartup = 1
            Else
                chkUpdAtStartup = 0
            End If
            Dim reg2 As RegistryKey = reg1.OpenSubKey("Clock-1.0", True)
            reg2.SetValue("chk", chkUpd)
            reg2.SetValue("download", downloadUpd)
            reg2.SetValue("chkUpdAtStartup", chkUpdAtStartup)
        End If
    End Sub

    Private Sub btn_debug_Click(sender As Object, e As EventArgs) Handles btn_debug.Click
        If btn_debug.Text = "Debug" Then
            Debug_Form.Show()
            btn_debug.Text = "Stop"
        Else
            Debug_Form.Close()
            btn_debug.Text = "Debug"
        End If
    End Sub
End Class