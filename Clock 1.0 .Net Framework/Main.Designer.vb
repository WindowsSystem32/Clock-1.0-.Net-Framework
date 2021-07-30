<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_upd = New System.Windows.Forms.Button()
        Me.currentVer = New System.Windows.Forms.Label()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_debug = New System.Windows.Forms.Button()
        Me.chk_useImg = New System.Windows.Forms.CheckBox()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb
        '
        Me.pb.BackColor = System.Drawing.Color.Black
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(800, 426)
        Me.pb.TabIndex = 0
        Me.pb.TabStop = False
        '
        'tmr1
        '
        Me.tmr1.Interval = 1
        '
        'btn_upd
        '
        Me.btn_upd.BackColor = System.Drawing.Color.Black
        Me.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upd.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upd.ForeColor = System.Drawing.Color.Lime
        Me.btn_upd.Location = New System.Drawing.Point(75, 426)
        Me.btn_upd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_upd.Name = "btn_upd"
        Me.btn_upd.Size = New System.Drawing.Size(141, 23)
        Me.btn_upd.TabIndex = 2
        Me.btn_upd.Text = "Check for updates"
        Me.btn_upd.UseVisualStyleBackColor = False
        '
        'currentVer
        '
        Me.currentVer.AutoSize = True
        Me.currentVer.Location = New System.Drawing.Point(216, 430)
        Me.currentVer.Name = "currentVer"
        Me.currentVer.Size = New System.Drawing.Size(175, 14)
        Me.currentVer.TabIndex = 3
        Me.currentVer.Text = "Current version: -.-.-.-"
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.Black
        Me.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_about.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.ForeColor = System.Drawing.Color.Lime
        Me.btn_about.Location = New System.Drawing.Point(0, 426)
        Me.btn_about.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(75, 23)
        Me.btn_about.TabIndex = 1
        Me.btn_about.Text = "About"
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'btn_setting
        '
        Me.btn_setting.BackColor = System.Drawing.Color.Black
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setting.ForeColor = System.Drawing.Color.Lime
        Me.btn_setting.Location = New System.Drawing.Point(391, 426)
        Me.btn_setting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(75, 23)
        Me.btn_setting.TabIndex = 4
        Me.btn_setting.Text = "Setting"
        Me.btn_setting.UseVisualStyleBackColor = False
        '
        'btn_debug
        '
        Me.btn_debug.BackColor = System.Drawing.Color.Black
        Me.btn_debug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_debug.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_debug.ForeColor = System.Drawing.Color.Lime
        Me.btn_debug.Location = New System.Drawing.Point(466, 426)
        Me.btn_debug.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_debug.Name = "btn_debug"
        Me.btn_debug.Size = New System.Drawing.Size(75, 23)
        Me.btn_debug.TabIndex = 5
        Me.btn_debug.Text = "Debug"
        Me.btn_debug.UseVisualStyleBackColor = False
        '
        'chk_useImg
        '
        Me.chk_useImg.AutoSize = True
        Me.chk_useImg.Location = New System.Drawing.Point(541, 429)
        Me.chk_useImg.Name = "chk_useImg"
        Me.chk_useImg.Size = New System.Drawing.Size(89, 18)
        Me.chk_useImg.TabIndex = 6
        Me.chk_useImg.Text = "Use image"
        Me.chk_useImg.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.chk_useImg)
        Me.Controls.Add(Me.btn_debug)
        Me.Controls.Add(Me.btn_setting)
        Me.Controls.Add(Me.currentVer)
        Me.Controls.Add(Me.btn_upd)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.pb)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(688, 222)
        Me.Name = "Main"
        Me.Text = "Clock 1.0 (.NET Framework 4.8) by WindowsSystem32"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb As PictureBox
    Friend WithEvents tmr1 As Timer
    Friend WithEvents btn_upd As Button
    Friend WithEvents currentVer As Label
    Friend WithEvents btn_about As Button
    Friend WithEvents btn_setting As Button
    Friend WithEvents btn_debug As Button
    Friend WithEvents chk_useImg As CheckBox
End Class
