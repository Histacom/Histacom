<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Webchat
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Webchat))
        Me.program = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.login = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtscreenname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.typechat = New System.Windows.Forms.TextBox
        Me.history = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.outsideprogramtopbar = New System.Windows.Forms.Panel
        Me.programtopbar = New System.Windows.Forms.Panel
        Me.maximizebutton = New System.Windows.Forms.PictureBox
        Me.minimizebutton = New System.Windows.Forms.PictureBox
        Me.programname = New System.Windows.Forms.Label
        Me.closebutton = New System.Windows.Forms.PictureBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.Chat = New System.Windows.Forms.Timer(Me.components)
        Me.program.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.login.SuspendLayout()
        Me.outsideprogramtopbar.SuspendLayout()
        Me.programtopbar.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.program.Controls.Add(Me.Label7)
        Me.program.Controls.Add(Me.Label6)
        Me.program.Controls.Add(Me.Panel1)
        Me.program.Controls.Add(Me.Button4)
        Me.program.Controls.Add(Me.Button3)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.login)
        Me.program.Controls.Add(Me.typechat)
        Me.program.Controls.Add(Me.history)
        Me.program.Controls.Add(Me.Label1)
        Me.program.Controls.Add(Me.outsideprogramtopbar)
        Me.program.Controls.Add(Me.ListBox1)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(703, 467)
        Me.program.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(389, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "To Speak Just type a message in the bottom textbox then press the speak button"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(483, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "File Sharing"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(483, 409)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 51)
        Me.Panel1.TabIndex = 16
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(97, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Download"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Skindows 95"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(195, 429)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Bill"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(109, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Paul"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(401, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Speak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.login.Controls.Add(Me.TextBox1)
        Me.login.Controls.Add(Me.Label4)
        Me.login.Controls.Add(Me.Label3)
        Me.login.Controls.Add(Me.Button1)
        Me.login.Controls.Add(Me.txtscreenname)
        Me.login.Controls.Add(Me.Label2)
        Me.login.Location = New System.Drawing.Point(83, 121)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(497, 251)
        Me.login.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 159)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Chat Room Rules"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Welcome To Webchat"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtscreenname
        '
        Me.txtscreenname.Location = New System.Drawing.Point(331, 181)
        Me.txtscreenname.Name = "txtscreenname"
        Me.txtscreenname.Size = New System.Drawing.Size(151, 20)
        Me.txtscreenname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Type in a Screen Name"
        '
        'typechat
        '
        Me.typechat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.typechat.Location = New System.Drawing.Point(9, 431)
        Me.typechat.Name = "typechat"
        Me.typechat.Size = New System.Drawing.Size(385, 20)
        Me.typechat.TabIndex = 9
        '
        'history
        '
        Me.history.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.history.Location = New System.Drawing.Point(11, 56)
        Me.history.Multiline = True
        Me.history.Name = "history"
        Me.history.ReadOnly = True
        Me.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.history.Size = New System.Drawing.Size(461, 369)
        Me.history.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Users Logged In"
        '
        'outsideprogramtopbar
        '
        Me.outsideprogramtopbar.Controls.Add(Me.programtopbar)
        Me.outsideprogramtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.outsideprogramtopbar.Location = New System.Drawing.Point(0, 0)
        Me.outsideprogramtopbar.Name = "outsideprogramtopbar"
        Me.outsideprogramtopbar.Size = New System.Drawing.Size(699, 25)
        Me.outsideprogramtopbar.TabIndex = 5
        '
        'programtopbar
        '
        Me.programtopbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.programtopbar.BackColor = System.Drawing.Color.DarkBlue
        Me.programtopbar.Controls.Add(Me.maximizebutton)
        Me.programtopbar.Controls.Add(Me.minimizebutton)
        Me.programtopbar.Controls.Add(Me.programname)
        Me.programtopbar.Controls.Add(Me.closebutton)
        Me.programtopbar.Location = New System.Drawing.Point(3, 3)
        Me.programtopbar.Name = "programtopbar"
        Me.programtopbar.Size = New System.Drawing.Size(693, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.windows_95.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(659, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.windows_95.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(643, 2)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(16, 14)
        Me.minimizebutton.TabIndex = 5
        Me.minimizebutton.TabStop = False
        '
        'programname
        '
        Me.programname.AutoSize = True
        Me.programname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programname.ForeColor = System.Drawing.Color.White
        Me.programname.Location = New System.Drawing.Point(3, 2)
        Me.programname.Name = "programname"
        Me.programname.Size = New System.Drawing.Size(63, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Web Chat"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.windows_95.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(676, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(483, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(195, 329)
        Me.ListBox1.TabIndex = 12
        '
        'look
        '
        '
        'Chat
        '
        Me.Chat.Interval = 15000
        '
        'Webchat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 467)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Webchat"
        Me.Text = "Webchat"
        Me.TopMost = True
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.login.ResumeLayout(False)
        Me.login.PerformLayout()
        Me.outsideprogramtopbar.ResumeLayout(False)
        Me.programtopbar.ResumeLayout(False)
        Me.programtopbar.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents outsideprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents history As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents typechat As System.Windows.Forms.TextBox
    Friend WithEvents login As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtscreenname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Chat As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
