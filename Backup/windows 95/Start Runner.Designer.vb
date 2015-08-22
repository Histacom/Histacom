<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Runner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start_Runner))
        Me.Label1 = New System.Windows.Forms.Label
        Me.program = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.outsideprogramtopbar = New System.Windows.Forms.Panel
        Me.programtopbar = New System.Windows.Forms.Panel
        Me.maximizebutton = New System.Windows.Forms.PictureBox
        Me.minimizebutton = New System.Windows.Forms.PictureBox
        Me.programname = New System.Windows.Forms.Label
        Me.closebutton = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.program.SuspendLayout()
        Me.outsideprogramtopbar.SuspendLayout()
        Me.programtopbar.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To Start Runner!!!!!"
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.program.Controls.Add(Me.Label2)
        Me.program.Controls.Add(Me.Button3)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.Button1)
        Me.program.Controls.Add(Me.outsideprogramtopbar)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(434, 275)
        Me.program.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(425, 156)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(335, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 27)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 27)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Infect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'outsideprogramtopbar
        '
        Me.outsideprogramtopbar.Controls.Add(Me.programtopbar)
        Me.outsideprogramtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.outsideprogramtopbar.Location = New System.Drawing.Point(0, 0)
        Me.outsideprogramtopbar.Name = "outsideprogramtopbar"
        Me.outsideprogramtopbar.Size = New System.Drawing.Size(430, 25)
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
        Me.programtopbar.Size = New System.Drawing.Size(424, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.windows_95.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(390, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.windows_95.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(374, 2)
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
        Me.programname.Size = New System.Drawing.Size(79, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Start Runner"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.windows_95.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(407, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'Timer1
        '
        '
        'look
        '
        '
        'Start_Runner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 275)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Start_Runner"
        Me.Text = "Start_Runner"
        Me.TopMost = True
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.outsideprogramtopbar.ResumeLayout(False)
        Me.programtopbar.ResumeLayout(False)
        Me.programtopbar.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents outsideprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents look As System.Windows.Forms.Timer
End Class
