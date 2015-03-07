﻿Public Class timedistorter0
    Dim timergo As Boolean
    Dim countdownnum As Integer
    Dim moveable As Boolean = True
    Dim mexlocation, meylocation As Integer
    Dim mewidth, meheight As Integer
    Dim maximize As Boolean

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles programtopbar.MouseDown
        If moveable = True Then
            If e.Button = MouseButtons.Left Then
                programtopbar.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        Else
        End If
    End Sub

    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click

        Me.Close()
    End Sub

    Private Sub pullside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullside.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
    End Sub

    Private Sub pullbottom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullbottom.Tick
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pullbs_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pullbs.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rightborder.MouseDown
        pullside.Start()
    End Sub

    Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rightborder.MouseUp
        pullside.Stop()
    End Sub

    Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomborder.MouseDown
        pullbottom.Start()
    End Sub

    Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomborder.MouseUp
        pullbottom.Stop()
    End Sub

    Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseDown
        pullbs.Start()
    End Sub

    Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseUp
        pullbs.Stop()
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click
        If maximize = False Then
            meylocation = Windows2000.desktopicons.Height - Me.Height
            mexlocation = Windows2000.desktopicons.Width - Me.Width
            mewidth = Me.Width
            meheight = Me.Height
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            leftborder.Hide()
            bottomborder.Hide()
            rightborder.Hide()
            Dim w, h As Integer
            w = Windows2000.desktopicons.Width
            h = Windows2000.desktopicons.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Size(w, h)
            moveable = False
            maximizebutton.Image = My.Resources.windowsxprestorebutton
            maximize = True
            toprightcorner.Hide()
            topleftcorner.Hide()
        Else
            bottomrightcorner.Show()
            bottomleftcorner.Show()
            leftborder.Show()
            bottomborder.Show()
            rightborder.Show()
            Me.Location = New Point(mexlocation, meylocation)
            Me.Size = New Size(mewidth, meheight)
            moveable = True
            maximizebutton.Image = My.Resources.windowsxpmaximizebutton
            maximize = False
            toprightcorner.Show()
            topleftcorner.Show()
        End If
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.topborder.BackColor = Windowsxp2002damaged.top.BackColor
        Me.topborder.BackgroundImage = Windowsxp2002damaged.top.BackgroundImage
        Me.programname.ForeColor = Windowsxp2002damaged.programname.ForeColor
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        countdownnum = 60
        timergo = True
        Countdownlabel.Location = New Point(312, 34)
        countdown.Location = New Point(337, 52)
        Label2.Show()
        Button1.Hide()
        Button2.Hide()
        countdowntimer.Start()
        waitfor02download = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim openerror As New windows2000messagebox
        openerror.infomessage.Text = "You are already in the year 2000"
        openerror.Show()
    End Sub

    Private Sub countdowntimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countdowntimer.Tick
        countdownnum = countdownnum - 1
        If countdownnum = -10 Then
            windows_me.Show()
            countdowntimer.Stop()
            time_travel_year_display.Hide()
            windows_me.BringToFront()
            Me.Close()
        End If
        If countdownnum = -9 Then
            time_travel_year_display.year.Show()
            Me.Hide()

        End If
        If countdownnum = -8 Then
            time_travel_year_display.year.Hide()
        End If
        If countdownnum = -6 Then
            time_travel_year_display.year.Text = "2001"
        End If
        If countdownnum = -2 Then
            time_travel_year_display.Show()
            time_travel_year_display.year.Text = "2000"
        End If
        If countdownnum = -1 Then
            Label2.Text = "Traveling"
            Countdownlabel.Text = "Year:"
            countdown.Text = "2002"
        End If
        If countdownnum = 59 Then
            countdown.Text = countdownnum
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Ok... you chose the year 2000." & Environment.NewLine)
        End If
        If timergo = True Then
            countdown.Text = countdownnum
        End If

        commandprompt2000.TextBox1.SelectionStart = 999999
        commandprompt2000.TextBox1.ScrollToCaret()
    End Sub
End Class