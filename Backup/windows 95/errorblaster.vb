Public Class errorblaster
    Dim ran As New Random
    Dim chosenerror As Integer
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Me.Close()
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


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim openerror As New windows95messagebox
        chosenerror = ran.Next(1, 9)
        If chosenerror = 1 Then
            openerror.infomessage.Text = "Your Computer Is Infected"
        End If
        If chosenerror = 2 Then
            openerror.infomessage.Text = "Virus Detected"
        End If
        If chosenerror = 3 Then
            openerror.infomessage.Text = "You need to uninfect your computer"
        End If
        If chosenerror = 4 Then
            openerror.infomessage.Text = "your computer is at risk download some program now to fix your comptuer"
        End If
        If chosenerror = 5 Then
            openerror.infomessage.Text = "Your computer is going to explode you need to save all changed now and then take it apart"
        End If
        If chosenerror = 6 Then
            openerror.infomessage.Text = "download an antivirus program now to save your computer"
        End If
        If chosenerror = 7 Then
            openerror.infomessage.Text = "Windows has detected a virus"
        End If
        If chosenerror = 8 Then
            openerror.infomessage.Text = "Your computer is going to be completly taken over if you do not right now downlaod antivirus software"
        End If
        openerror.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub

    Private Sub errorblaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        look.Start()

    End Sub
End Class