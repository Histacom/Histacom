Public Class Start_Runner
    Dim beginlocation As System.Drawing.Point
    Dim randnumb As New Random
    Dim taskbarlenght As Integer
    Dim ylocation As Integer
    Dim xlocation As Integer
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Windows95.startbutton.Location = beginlocation
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Windows95.startbutton.Location = beginlocation
        Me.Close()
    End Sub

    Private Sub Start_Runner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        beginlocation = Windows95.startbutton.Location
        taskbarlenght = Windows95.taskbar.Size.Width
        look.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        xlocation = randnumb.Next(1, taskbarlenght)
        Windows95.startbutton.Location = New Point(xlocation, Windows95.startbutton.Location.Y)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Windows95.startbutton.Location = beginlocation
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub
End Class