Public Class windows95messagebox
    Dim chosenx As Integer
    Dim choseny As Integer
    Dim desktopx As Integer
    Dim desktopy As Integer
    Dim yran As New Random
    Dim xran As New Random
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub windows95messagebox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Hide()
        Label1.Hide()
        Label2.Hide()
        desktopy = Windows95.desktopicons.Size.Height
        desktopx = Windows95.desktopicons.Size.Width
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        look.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        choseny = yran.Next(1, desktopy)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        chosenx = xran.Next(1, desktopx)
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Show()
        Label1.Text = chosenx
        Label2.Text = choseny
        Me.Location = New Point(Label1.Text, Label2.Text)
        Timer3.Stop()
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub
End Class