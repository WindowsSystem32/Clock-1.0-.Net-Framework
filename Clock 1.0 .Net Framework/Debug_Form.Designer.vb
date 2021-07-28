<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug_Form
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug_Form))
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtb
        '
        Me.rtb.BackColor = System.Drawing.Color.Black
        Me.rtb.ForeColor = System.Drawing.Color.Lime
        Me.rtb.Location = New System.Drawing.Point(0, 0)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(800, 449)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'Debug_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.rtb)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(688, 222)
        Me.Name = "Debug_Form"
        Me.Text = "Debug"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtb As RichTextBox
End Class
