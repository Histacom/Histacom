Public Class Downloader
    Dim amounttodownload As Integer
    Dim downloadspeed As Integer
    Dim amountdownloaded As Integer


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

    Private Sub Downloader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        amountdownloaded = 0
        downloadspeed = 8
        amounttodownload = 100
        Timer1.Start()
        Label3.Text = ("Transfer Speed: " & downloadspeed & " Kilobytes per Second")
        look.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        amountdownloaded = amountdownloaded + downloadspeed
        If downloadspeed > amounttodownload - amountdownloaded Then
            ProgressBar1.Value = 100
            Label1.Text = ("Downloaded " & amountdownloaded & " kb out of " & amounttodownload & " kb")
            If Label2.Text = "Downloading: Guess The Number" Then
                Windows95.desktopicons.Items.Add("Guess The Number Setup", imageIndex:=8)
            End If
            If Label2.Text = "Downloading: Start Runner" Then
                Windows95.desktopicons.Items.Add("Start Runner Setup", imageIndex:=9)
            End If
            If Label2.Text = "Downloading: Error Blaster" Then
                Windows95.desktopicons.Items.Add("Error Blaster Setup", imageIndex:=10)
            End If
            If Label2.Text = "Downloading: Skindows 95" Then
                Windows95.desktopicons.Items.Add("Skindows 95 Setup", imageIndex:=12)
            End If
            If Label2.Text = "Downloading: Web Chat" Then
                Windows95.desktopicons.Items.Add("Web Chat Setup", imageIndex:=11)
            End If
            If Label2.Text = "Downloading: hwcv.exe" Then
                Windows95.desktopicons.Items.Add("hwcv.exe", imageIndex:=11)
            End If
            If Label2.Text = "Downloading: Time Distorter" Then
                Windows95.desktopicons.Items.Add("Time Distorter Setup", imageIndex:=13)
            End If
            Me.Close()
            Timer1.Stop()
        Else
            ProgressBar1.Maximum = amounttodownload
            ProgressBar1.Value = amountdownloaded
        End If
        Label1.Text = ("Downloaded " & amountdownloaded & " kb out of " & amounttodownload)

    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub
End Class