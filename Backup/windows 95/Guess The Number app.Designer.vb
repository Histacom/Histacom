<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guess_The_Number_app
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
        Me.program = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.higherorlower = New System.Windows.Forms.Label
        Me.txtGuessedNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.outsideprogramtopbar = New System.Windows.Forms.Panel
        Me.programtopbar = New System.Windows.Forms.Panel
        Me.maximizebutton = New System.Windows.Forms.PictureBox
        Me.minimizebutton = New System.Windows.Forms.PictureBox
        Me.closebutton = New System.Windows.Forms.PictureBox
        Me.programname = New System.Windows.Forms.Label
        Me.flasher = New System.Windows.Forms.Timer(Me.components)
        Me.selector = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.program.SuspendLayout()
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
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.Label3)
        Me.program.Controls.Add(Me.Button1)
        Me.program.Controls.Add(Me.higherorlower)
        Me.program.Controls.Add(Me.txtGuessedNumber)
        Me.program.Controls.Add(Me.Label2)
        Me.program.Controls.Add(Me.Label1)
        Me.program.Controls.Add(Me.outsideprogramtopbar)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(281, 160)
        Me.program.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 27)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Restart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "then press check"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'higherorlower
        '
        Me.higherorlower.AutoSize = True
        Me.higherorlower.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.higherorlower.Location = New System.Drawing.Point(43, 91)
        Me.higherorlower.Name = "higherorlower"
        Me.higherorlower.Size = New System.Drawing.Size(78, 18)
        Me.higherorlower.TabIndex = 9
        Me.higherorlower.Text = "Unknown"
        '
        'txtGuessedNumber
        '
        Me.txtGuessedNumber.Location = New System.Drawing.Point(131, 60)
        Me.txtGuessedNumber.Name = "txtGuessedNumber"
        Me.txtGuessedNumber.Size = New System.Drawing.Size(32, 20)
        Me.txtGuessedNumber.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Type your guess here:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "I am thinking of a number between 1-100"
        '
        'outsideprogramtopbar
        '
        Me.outsideprogramtopbar.Controls.Add(Me.programtopbar)
        Me.outsideprogramtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.outsideprogramtopbar.Location = New System.Drawing.Point(0, 0)
        Me.outsideprogramtopbar.Name = "outsideprogramtopbar"
        Me.outsideprogramtopbar.Size = New System.Drawing.Size(277, 25)
        Me.outsideprogramtopbar.TabIndex = 5
        '
        'programtopbar
        '
        Me.programtopbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.programtopbar.BackColor = System.Drawing.Color.DarkBlue
        Me.programtopbar.Controls.Add(Me.maximizebutton)
        Me.programtopbar.Controls.Add(Me.minimizebutton)
        Me.programtopbar.Controls.Add(Me.closebutton)
        Me.programtopbar.Controls.Add(Me.programname)
        Me.programtopbar.Location = New System.Drawing.Point(3, 3)
        Me.programtopbar.Name = "programtopbar"
        Me.programtopbar.Size = New System.Drawing.Size(271, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.windows_95.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(237, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.windows_95.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(221, 2)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(16, 14)
        Me.minimizebutton.TabIndex = 5
        Me.minimizebutton.TabStop = False
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.windows_95.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(254, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'programname
        '
        Me.programname.AutoSize = True
        Me.programname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programname.ForeColor = System.Drawing.Color.White
        Me.programname.Location = New System.Drawing.Point(3, 2)
        Me.programname.Name = "programname"
        Me.programname.Size = New System.Drawing.Size(115, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Guess The Number"
        '
        'flasher
        '
        '
        'selector
        '
        Me.selector.Interval = 1000
        '
        'look
        '
        '
        'Guess_The_Number_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 160)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Guess_The_Number_app"
        Me.Text = "Guess_The_Number_app"
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

    End Sub
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents outsideprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents higherorlower As System.Windows.Forms.Label
    Friend WithEvents txtGuessedNumber As System.Windows.Forms.TextBox
    Friend WithEvents flasher As System.Windows.Forms.Timer
    Friend WithEvents selector As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents look As System.Windows.Forms.Timer
End Class
