<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloader
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.program = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.outsideprogramtopbar = New System.Windows.Forms.Panel
        Me.programtopbar = New System.Windows.Forms.Panel
        Me.maximizebutton = New System.Windows.Forms.PictureBox
        Me.minimizebutton = New System.Windows.Forms.PictureBox
        Me.programname = New System.Windows.Forms.Label
        Me.closebutton = New System.Windows.Forms.PictureBox
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
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Downloaded 0kb /0kb"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 48)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(458, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.program.Controls.Add(Me.Label4)
        Me.program.Controls.Add(Me.Label3)
        Me.program.Controls.Add(Me.Label2)
        Me.program.Controls.Add(Me.outsideprogramtopbar)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(485, 130)
        Me.program.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Downloading To: Desktop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Transfer: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'outsideprogramtopbar
        '
        Me.outsideprogramtopbar.Controls.Add(Me.programtopbar)
        Me.outsideprogramtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.outsideprogramtopbar.Location = New System.Drawing.Point(0, 0)
        Me.outsideprogramtopbar.Name = "outsideprogramtopbar"
        Me.outsideprogramtopbar.Size = New System.Drawing.Size(481, 25)
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
        Me.programtopbar.Size = New System.Drawing.Size(475, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.windows_95.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(441, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.windows_95.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(425, 2)
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
        Me.programname.Size = New System.Drawing.Size(87, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "File Download"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.windows_95.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(458, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'look
        '
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 130)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Downloader"
        Me.Text = "Downloader"
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
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents outsideprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents look As System.Windows.Forms.Timer
End Class
