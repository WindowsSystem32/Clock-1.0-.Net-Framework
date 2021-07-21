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
        Me.btn_about = New System.Windows.Forms.Button()
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
        Me.tmr1.Interval = 10
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.pb)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(688, 246)
        Me.Name = "Main"
        Me.Text = "Clock 1.0 (.NET Framework 4.8) by WindowsSystem32"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb As PictureBox
    Friend WithEvents tmr1 As Timer
    Friend WithEvents btn_about As Button
End Class
