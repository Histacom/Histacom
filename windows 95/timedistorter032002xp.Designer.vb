﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timedistorter032002xp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(timedistorter032002xp))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.program = New System.Windows.Forms.Panel()
        Me.countdown = New System.Windows.Forms.Label()
        Me.Countdownlabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.top = New System.Windows.Forms.Panel()
        Me.maximizebutton = New System.Windows.Forms.PictureBox()
        Me.minimizebutton = New System.Windows.Forms.PictureBox()
        Me.programname = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.PictureBox()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.bottom = New System.Windows.Forms.Panel()
        Me.right = New System.Windows.Forms.Panel()
        Me.left = New System.Windows.Forms.Panel()
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.countdowntimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.program.SuspendLayout()
        Me.top.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.Histacom.My.Resources.Resources.time_distorter_0_3_top
        Me.PictureBox1.Location = New System.Drawing.Point(4, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(407, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.OldLace
        Me.program.Controls.Add(Me.Label2)
        Me.program.Controls.Add(Me.countdown)
        Me.program.Controls.Add(Me.Countdownlabel)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.Button1)
        Me.program.Controls.Add(Me.Label1)
        Me.program.Controls.Add(Me.PictureBox1)
        Me.program.Controls.Add(Me.top)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Controls.Add(Me.bottom)
        Me.program.Controls.Add(Me.right)
        Me.program.Controls.Add(Me.left)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(415, 221)
        Me.program.TabIndex = 5
        '
        'countdown
        '
        Me.countdown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.countdown.AutoSize = True
        Me.countdown.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countdown.Location = New System.Drawing.Point(187, 78)
        Me.countdown.Name = "countdown"
        Me.countdown.Size = New System.Drawing.Size(45, 35)
        Me.countdown.TabIndex = 15
        Me.countdown.Text = "60"
        '
        'Countdownlabel
        '
        Me.Countdownlabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Countdownlabel.AutoSize = True
        Me.Countdownlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Countdownlabel.Location = New System.Drawing.Point(162, 55)
        Me.Countdownlabel.Name = "Countdownlabel"
        Me.Countdownlabel.Size = New System.Drawing.Size(89, 16)
        Me.Countdownlabel.TabIndex = 14
        Me.Countdownlabel.Text = "Count Down"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 39)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "2000"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(273, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "2001"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Please choose which year you would like to travel to:"
        '
        'top
        '
        Me.top.BackColor = System.Drawing.Color.Transparent
        Me.top.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxptopbarmiddle
        Me.top.Controls.Add(Me.maximizebutton)
        Me.top.Controls.Add(Me.minimizebutton)
        Me.top.Controls.Add(Me.programname)
        Me.top.Controls.Add(Me.closebutton)
        Me.top.Dock = System.Windows.Forms.DockStyle.Top
        Me.top.Location = New System.Drawing.Point(4, 0)
        Me.top.Name = "top"
        Me.top.Size = New System.Drawing.Size(407, 30)
        Me.top.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.Histacom.My.Resources.Resources.windowsxpmaximizebutton
        Me.maximizebutton.Location = New System.Drawing.Point(359, 5)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(21, 21)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.Histacom.My.Resources.Resources.windowsxpminimizebutton
        Me.minimizebutton.Location = New System.Drawing.Point(336, 5)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(21, 21)
        Me.minimizebutton.TabIndex = 5
        Me.minimizebutton.TabStop = False
        '
        'programname
        '
        Me.programname.AutoSize = True
        Me.programname.BackColor = System.Drawing.Color.Transparent
        Me.programname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programname.ForeColor = System.Drawing.Color.White
        Me.programname.Location = New System.Drawing.Point(5, 8)
        Me.programname.Name = "programname"
        Me.programname.Size = New System.Drawing.Size(108, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Time Distorter 0.3"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.Histacom.My.Resources.Resources.windowsxpclosebutton
        Me.closebutton.Location = New System.Drawing.Point(382, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(21, 21)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 217)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(5, 4)
        Me.bottomleftcorner.TabIndex = 10
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackColor = System.Drawing.Color.Magenta
        Me.toprightcorner.BackgroundImage = CType(resources.GetObject("toprightcorner.BackgroundImage"), System.Drawing.Image)
        Me.toprightcorner.Location = New System.Drawing.Point(409, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(6, 30)
        Me.toprightcorner.TabIndex = 9
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottomcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(411, 217)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'topleftcorner
        '
        Me.topleftcorner.BackColor = System.Drawing.Color.Magenta
        Me.topleftcorner.BackgroundImage = CType(resources.GetObject("topleftcorner.BackgroundImage"), System.Drawing.Image)
        Me.topleftcorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(7, 30)
        Me.topleftcorner.TabIndex = 8
        '
        'bottom
        '
        Me.bottom.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottom
        Me.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom.Location = New System.Drawing.Point(4, 217)
        Me.bottom.Name = "bottom"
        Me.bottom.Size = New System.Drawing.Size(407, 4)
        Me.bottom.TabIndex = 3
        '
        'right
        '
        Me.right.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxprightside
        Me.right.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.right.Dock = System.Windows.Forms.DockStyle.Right
        Me.right.Location = New System.Drawing.Point(411, 0)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(4, 221)
        Me.right.TabIndex = 2
        '
        'left
        '
        Me.left.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpleftside
        Me.left.Dock = System.Windows.Forms.DockStyle.Left
        Me.left.Location = New System.Drawing.Point(0, 0)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(4, 221)
        Me.left.TabIndex = 1
        '
        'look
        '
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Year 2000 Selected Preparing Time Travel:"
        Me.Label2.Visible = False
        '
        'countdowntimer
        '
        Me.countdowntimer.Interval = 1000
        '
        'timedistorter032002xp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 221)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "timedistorter032002xp"
        Me.Text = "timedistorter032002xp"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.top.ResumeLayout(False)
        Me.top.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents countdown As System.Windows.Forms.Label
    Friend WithEvents Countdownlabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents top As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
    Friend WithEvents bottom As System.Windows.Forms.Panel
    Friend WithEvents right As System.Windows.Forms.Panel
    Friend WithEvents left As System.Windows.Forms.Panel
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents pullbs As System.Windows.Forms.Timer
    Friend WithEvents pullbottom As System.Windows.Forms.Timer
    Friend WithEvents pullside As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents countdowntimer As System.Windows.Forms.Timer
End Class
