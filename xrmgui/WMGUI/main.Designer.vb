<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.pwbox = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.intens = New System.Windows.Forms.TextBox()
        Me.wsize = New System.Windows.Forms.TextBox()
        Me.cpulist = New System.Windows.Forms.ListBox()
        Me.gpulist = New System.Windows.Forms.ListBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.poolbox = New System.Windows.Forms.TextBox()
        Me.portbox = New System.Windows.Forms.TextBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.cpunum = New System.Windows.Forms.TrackBar()
        Me.gpunum = New System.Windows.Forms.TrackBar()
        Me.cslid = New System.Windows.Forms.Label()
        Me.gslid = New System.Windows.Forms.Label()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.cpunum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpunum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 320)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(856, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(68, 17)
        Me.status.Text = "Not Mining"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(486, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Threads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(486, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "GPU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CPU"
        '
        'userbox
        '
        Me.userbox.Location = New System.Drawing.Point(68, 47)
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(100, 20)
        Me.userbox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "User/wallet"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(175, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "UseWallet"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'pwbox
        '
        Me.pwbox.Enabled = False
        Me.pwbox.Location = New System.Drawing.Point(68, 103)
        Me.pwbox.Name = "pwbox"
        Me.pwbox.Size = New System.Drawing.Size(100, 20)
        Me.pwbox.TabIndex = 14
        Me.pwbox.Text = "x"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(175, 106)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "None"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(749, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(271, 49)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox3.TabIndex = 18
        Me.CheckBox3.Text = "Nicehash"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(271, 72)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox4.TabIndex = 19
        Me.CheckBox4.Text = "Webstats"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(348, 49)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox5.TabIndex = 20
        Me.CheckBox5.Text = "Intensity"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(348, 72)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox6.TabIndex = 21
        Me.CheckBox6.Text = "Worksize"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Enabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(271, 95)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox7.TabIndex = 22
        Me.CheckBox7.Text = "Dual"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'intens
        '
        Me.intens.Enabled = False
        Me.intens.Location = New System.Drawing.Point(419, 49)
        Me.intens.Name = "intens"
        Me.intens.Size = New System.Drawing.Size(60, 20)
        Me.intens.TabIndex = 23
        Me.intens.Text = "512"
        '
        'wsize
        '
        Me.wsize.Enabled = False
        Me.wsize.Location = New System.Drawing.Point(419, 72)
        Me.wsize.Name = "wsize"
        Me.wsize.Size = New System.Drawing.Size(60, 20)
        Me.wsize.TabIndex = 24
        Me.wsize.Text = "64"
        '
        'cpulist
        '
        Me.cpulist.FormattingEnabled = True
        Me.cpulist.Items.AddRange(New Object() {"Aeon", "Monero", "Zcash"})
        Me.cpulist.Location = New System.Drawing.Point(677, 103)
        Me.cpulist.Name = "cpulist"
        Me.cpulist.Size = New System.Drawing.Size(120, 17)
        Me.cpulist.TabIndex = 26
        '
        'gpulist
        '
        Me.gpulist.FormattingEnabled = True
        Me.gpulist.Items.AddRange(New Object() {"Aeon", "Monero", "Zcash"})
        Me.gpulist.Location = New System.Drawing.Point(677, 45)
        Me.gpulist.Name = "gpulist"
        Me.gpulist.Size = New System.Drawing.Size(120, 17)
        Me.gpulist.TabIndex = 27
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(348, 95)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox8.TabIndex = 28
        Me.CheckBox8.Text = "Show Miner"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'poolbox
        '
        Me.poolbox.Location = New System.Drawing.Point(68, 159)
        Me.poolbox.Name = "poolbox"
        Me.poolbox.Size = New System.Drawing.Size(208, 20)
        Me.poolbox.TabIndex = 29
        '
        'portbox
        '
        Me.portbox.Location = New System.Drawing.Point(282, 159)
        Me.portbox.Name = "portbox"
        Me.portbox.Size = New System.Drawing.Size(60, 20)
        Me.portbox.TabIndex = 30
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(348, 119)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox9.TabIndex = 31
        Me.CheckBox9.Text = "Powersave"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(271, 119)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox10.TabIndex = 32
        Me.CheckBox10.Text = "Prefetch"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'cpunum
        '
        Me.cpunum.Location = New System.Drawing.Point(538, 91)
        Me.cpunum.Maximum = 8
        Me.cpunum.Minimum = 1
        Me.cpunum.Name = "cpunum"
        Me.cpunum.Size = New System.Drawing.Size(104, 45)
        Me.cpunum.TabIndex = 33
        Me.cpunum.Value = 1
        '
        'gpunum
        '
        Me.gpunum.Location = New System.Drawing.Point(538, 27)
        Me.gpunum.Maximum = 6
        Me.gpunum.Minimum = 1
        Me.gpunum.Name = "gpunum"
        Me.gpunum.Size = New System.Drawing.Size(104, 45)
        Me.gpunum.TabIndex = 34
        Me.gpunum.Value = 1
        '
        'cslid
        '
        Me.cslid.AutoSize = True
        Me.cslid.Location = New System.Drawing.Point(648, 103)
        Me.cslid.Name = "cslid"
        Me.cslid.Size = New System.Drawing.Size(13, 13)
        Me.cslid.TabIndex = 35
        Me.cslid.Text = "1"
        '
        'gslid
        '
        Me.gslid.AutoSize = True
        Me.gslid.Location = New System.Drawing.Point(648, 45)
        Me.gslid.Name = "gslid"
        Me.gslid.Size = New System.Drawing.Size(13, 13)
        Me.gslid.TabIndex = 36
        Me.gslid.Text = "1"
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(677, 13)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox11.TabIndex = 37
        Me.CheckBox11.Text = "AMD"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(734, 13)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox12.TabIndex = 38
        Me.CheckBox12.Text = "Nvidia"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Pool"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(348, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Port"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 342)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.gslid)
        Me.Controls.Add(Me.cslid)
        Me.Controls.Add(Me.gpunum)
        Me.Controls.Add(Me.cpunum)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.portbox)
        Me.Controls.Add(Me.poolbox)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.gpulist)
        Me.Controls.Add(Me.cpulist)
        Me.Controls.Add(Me.wsize)
        Me.Controls.Add(Me.intens)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.pwbox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.userbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMGUI .01"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.cpunum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpunum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents userbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents pwbox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents intens As System.Windows.Forms.TextBox
    Friend WithEvents wsize As System.Windows.Forms.TextBox
    Friend WithEvents cpulist As System.Windows.Forms.ListBox
    Friend WithEvents gpulist As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents poolbox As System.Windows.Forms.TextBox
    Friend WithEvents portbox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents cpunum As System.Windows.Forms.TrackBar
    Friend WithEvents gpunum As System.Windows.Forms.TrackBar
    Friend WithEvents cslid As System.Windows.Forms.Label
    Friend WithEvents gslid As System.Windows.Forms.Label
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
