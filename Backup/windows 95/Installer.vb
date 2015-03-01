Public Class Installer
    Dim programtoinstall As String
    Private Sub Installer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        welcome.Show()
        programtoinstall = installname.Text
        installname.Hide()
        programname.Text = ("Installing " & programtoinstall)
        Label1.Text = ("Welcome To " & programtoinstall)
        Label2.Text = ("You are about to install " & programtoinstall)
        Label3.Text = ("Click Next to continue installing " & programtoinstall)
        Label7.Text = ("Ready to start installing " & programtoinstall)
        Label9.Text = (programtoinstall)
        Label11.Text = ("C:\Program Files\ " & programtoinstall)
        Label13.Text = ("Installing " & programtoinstall & "...")
        Label14.Text = ("Currently Installing " & programtoinstall)
        Label16.Text = (programtoinstall & " was successfully installed.")
        finishinstallimage.Image = installimage.Image
        look.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Finish" Then
            If programtoinstall = "Guess The Number" Then
                Me.Close()
                Windows95.GuessTheNumberToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Start Runner" Then
                Me.Close()
                Windows95.StartRunnerToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Error Blaster" Then
                Me.Close()
                Windows95.ErrorBlasterToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Skindows 95" Then
                Me.Close()
                Windows95.SkindowsToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Web Chat" Then
                Me.Close()
                Windows95.WebChatToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Time Distorter" Then
                Me.Close()
                Windows95.TimeDistorterToolStripMenuItem.Visible = True
            End If
        End If
        If summary.Visible = True And licenseagreement.Visible = False Then
            summary.Hide()
            Button3.Hide()
            Timer1.Start()
        End If
        If licenseagreement.Visible = True And welcome.Visible = False Then
            licenseagreement.Hide()
        End If
        If welcome.Visible = True Then
            welcome.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value = 100 Then
            Button3.Show()
            installerproccess.Hide()
            Button3.Text = "Finish"
            Timer1.Stop()
        End If
    End Sub

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles programtopbar.MouseDown
        If e.Button = MouseButtons.Left Then
            programtopbar.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = _
                Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                    New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub
End Class