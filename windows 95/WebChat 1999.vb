Public Class WebChat_1999
    Dim waiting As Boolean
    Dim waiting2 As Boolean = False
    Dim con As Integer
    Dim ran As New Random
    Dim abletoclose As Boolean = True
    Dim username As String
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        If abletoclose Then
            Me.Close()
        End If
    End Sub

    Private Sub me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
        Button5.Hide()
        Label5.Hide()
        abletoclose = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        username = txtscreenname.Text
        login.Hide()
        Chat.Start()
        ListBox1.Items.Add(username)
        history.Text += (username & " Has Logged On" & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If waiting = True Then
            mainname = typechat.Text
            waiting = False
            history.Text += (username & ": " & typechat.Text & Environment.NewLine)
            typechat.Text = ""
            history.Focus()
            history.SelectionStart = 999999
            history.ScrollToCaret()
            typechat.Focus()
        Else
            history.Text += (username & ": " & typechat.Text & Environment.NewLine)
            typechat.Text = ""
            typechat.Focus()
            history.SelectionStart = 999999
            history.ScrollToCaret()
        End If
        
    End Sub

    Private Sub Chat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chat.Tick
    	Select Case con
	        Case 67
	            If waitfor02download Then
	                Chat.Stop()
	            Else
	                Chat.Start()
	                history.Text += ("12padams: Ok I got a message that you just started the timer " & mainname & Environment.NewLine)
	            End If
	        Case 66
	            history.Text += ("The Hidden Hacker: I Hope this works..." & Environment.NewLine)
	            Chat.Interval = 3000
	            count.Start()
	            waitfor02download = True
	            Chat.Stop()
	        Case 65
	            history.Text += ("12padams: Ok " & mainname & " download it now and we will wait for you" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 64
	            Label5.Show()
	            Button5.Show()
	        Case 63
	            history.Text += ("12padams: We will start right now. Ill send 0.2 of time distorter and " & mainname & " can download it" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 62
	            history.Text += ("The Hidden Hacker: Ok then when do we start?" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 61
	            history.Text += ("12padams: Nothings going to go wrong I think i Got this" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 60
	            history.Text += ("The Hidden Hacker: But what If something goes wrong and " & mainname & " doesn't get to the year 2000 properly?" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 59
	            history.Text += ("12padams: Ok I want you to look out for " & mainname & " so that in 1 year you can tell me when he comes back" & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 58
	            history.Text += ("The Hidden Hacker: Ok but what do you want me to do?" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 57
	            history.Text += ("12padams: But It has to be done... you need to help me, guys... please" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 56
	            history.Text += ("The Hidden Hacker: 12padams thats too risky" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 55
	            history.Text += ("12padams: This could serriously impact my time travel software." & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 54
	            history.Text += ("12padams: Computer dates may stuff up and display 1900 instead of 2000" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 53
	            history.Text += ("12padams: Well basically I wrote an article on the year 2000 bug AKA y2k" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 52
	            history.Text += ("12padams: haha sorry I forgot about that" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 51
	            history.Text += ("The Hidden Hacker: no since I am blocked from using your website" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 50
	            history.Text += ("12padams: no... Its not accually. Didn't you read the article on my website?" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 49
	            history.Text += ("The Hidden Hacker: Why does he need to try it out??? its gunna work just like 0.1 did" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 48
	            history.Text += ("12padams: " & mainname & "... I will need you to try this out again" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 47
	            history.Text += ("12padams: well not much different... it works the same except it works in all time periods and it takes you to 2000" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 46
	            history.Text += ("12padams: 0.2 is much different however" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 45
	            history.Text += ("12padams: Well anyway... 0.1 is now useless since it only works if the year is 1998 and it will only take you to 1999" & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 44
	            history.Text += ("12padams: oh woops yea oh cause you would" & Environment.NewLine)
	            Chat.Interval = 8000
	        Case 43
	            history.Text += ("The Hidden Hacker: Of cause I remember that..." & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 42
	            history.Text += ("12padams: Remember time distorter 0.1?" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 41
	            history.Text += ("12padams: Oh right I forgot to tell you both" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 40
	            history.Text += ("The Hidden Hacker: Wait A sec... you mean we are going to time travel again?" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 39
	            history.Text += ("12padams: Ok I know... you can track the time travels so you can see when " & mainname & " gets to a new time period you say whats going on..." & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 38
	            history.Text += ("12padams: I am not really sure accually... um let me think" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 37
	            history.Text += ("The Hidden Hacker: Um what do you mean by guider?" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 36
	            history.Text += ("12padams: And The Hidden Hacker... you can be the um... Guider" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 35
	            history.Text += ("12padams: " & mainname & " you can be the tester for my time travel software" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 34
	            history.Text += ("12padams: Well I am the coder who will be working on the time travel software" & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 33
	            history.Text += ("The Hidden Hacker: Wait what do you mean by 'a team'" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 32
	            history.Text += ("12padams: Look Since you both know about this whole time travel thing... I want us to be a team " & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 31
	            history.Text += ("12padams: Well anyway I have something very important I now have to say to you both " & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 30
	            history.Text += ("The Hidden Hacker: Lol its good you now have a name " & mainname & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 29
	            history.Text += ("12padams: Ok from now on we will call you " & mainname & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 28
				if mainname == "" Then
					con -= 1
				End If
	            Chat.Interval = 3000
	        Case 27
	            history.Text += ("12padams: Um whats your name 'windows 98 user' just type it in the chat now. I recommend less then 10 letters" & Environment.NewLine)
	            Chat.Interval = 6000
	            waiting = True
	        Case 26
	            history.Text += ("12padams: Ok just to let you know... the only thing thats getting me 'angrey' right now is not knowing what this windows 98 users name is " & Environment.NewLine)
	            Chat.Interval = 9000
	        Case 25
	            history.Text += ("The Hidden Hacker: Well thats a relief... um whatever your name is... " & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 24
	            history.Text += ("12padams: So I just wanna say thanks :) both of you... " & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 23
	            history.Text += ("12padams: Liston... If you had not hacked my emails and taken my software and tried it out I would never have tested my software. " & Environment.NewLine)
	            Chat.Interval = 9000
	        Case 22
	            history.Text += ("12padams: Yea I'm not angrey at any of you..." & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 21
	            history.Text += ("The Hidden Hacker: What???" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 20
	            history.Text += ("12padams: Oh for goodness sake what's wrong with you 2... I am not angrey" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 19
	            history.Text += ("The Hidden Hacker: Crap the close button is not working!!!" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 18
	            history.Text += ("12padams: Come on guys..." & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 17
	            history.Text += ("The Hidden Hacker: Log off... um whatever your name is wh owns that windows 98 computer!!!!" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 16
	            history.Text += ("The Hidden Hacker: Oh CRAP!!!" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 15
	            history.Text += ("12padams: Yea and you have not done a good job of hidding" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 14
	            history.Text += ("12padams Has Logged On" & Environment.NewLine)
	            Chat.Interval = 2000
	            abletoclose = False
	        Case 13
	            history.Text += ("The Hidden Hacker: since then I have been hiding so 12padams could not get me" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 12
	            history.Text += ("The Hidden Hacker: after you left 1998 12padams tried to attack and well..." & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 11
	            history.Text += ("The Hidden Hacker: Ok well heres what happened while you were gone." & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 10
	            history.Text += ("The Hidden Hacker: Finally your here." & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 9
	            history.Text += ("The Hidden Hacker: For 1 whole year I have been waiting to see if that time travel software worked" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 8
	            history.Text += ("[The Known Checker] has changed his display name to [The Hidden Hacker]" & Environment.NewLine)
	            ListBox1.Items.Remove("The Known Checker")
	            ListBox1.Items.Add("The Hidden Hacker")
	            Chat.Interval = 6000
	        Case 7
	            history.Text += ("The Known Checker: Wait sorry i am using a fake name... Just wait a sec" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 6
	            history.Text += ("The Known Checker: Yes!!! Its YOU!!!!!" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 5
	            history.Text += ("Scan Complete!" & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 4
	            history.Text += ("The Known Checker is: Scanning IP..." & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 3
	            history.Text += ("The Known Checker: Wait I'll quickly do an ip scan..." & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 2
	            history.Text += ("The Known Checker: Hi um I know this is going to sound weird but do you know about some software called time distorter?" & Environment.NewLine)
	            Chat.Interval = 8000
	        Case 1
	            history.Text += ("The Known Checker: OMG I think I found you!!!" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 0
	            ListBox1.Items.Add("The Known Checker")
	            Chat.Interval = 5000
		End Select
        con += 1
        history.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
        typechat.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Time Distorter 0.2"
    End Sub
    Dim moveable As Boolean = True
    Dim mexlocation, meylocation As Integer
    Dim mewidth, meheight As Integer
    Dim maximize As Boolean

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles programtopbar.MouseDown
        If moveable Then
            If e.Button = MouseButtons.Left Then
                programtopbar.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        End If
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

    Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseDown
        pullside.Start()
    End Sub

    Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseUp
        pullside.Stop()
    End Sub

    Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseDown
        pullbottom.Start()
    End Sub

    Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseUp
        pullbottom.Stop()
    End Sub

    Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseDown
        pullbs.Start()
    End Sub

    Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseUp
        pullbs.Stop()
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click
        If Not maximize Then
            meylocation = Windows95.desktopicons.Height - Me.Height
            mexlocation = Windows95.desktopicons.Width - Me.Width
            mewidth = Me.Width
            meheight = Me.Height
            toprightcorner.Hide()
            topleftcorner.Hide()
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            left.Hide()
            top.Hide()
            bottom.Hide()
            right.Hide()
            Dim w, h As Integer
            w = Windows95.desktopicons.Width
            h = Windows95.desktopicons.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Size(w, h)
            moveable = False
            maximizebutton.Image = My.Resources.unmaximizebutton
            maximize = True
        Else
            toprightcorner.Show()
            topleftcorner.Show()
            bottomrightcorner.Show()
            bottomleftcorner.Show()
            left.Show()
            top.Show()
            bottom.Show()
            right.Show()
            Me.Location = New Point(mexlocation, meylocation)
            Me.Size = New Size(mewidth, meheight)
            moveable = True
            maximizebutton.Image = My.Resources.Maximize
            maximize = False
        End If
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click

    End Sub

    Private Sub waitingdownload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitingdownload.Tick
        If Not waitfor02download Then
            Chat.Start()
            waitingdownload.Stop()
        End If
    End Sub

    Private Sub count_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles count.Tick
    	Select Case count2000
	        Case -8
	            Me.BackColor = Color.Black
	            history.BackColor = Color.Black
	            history.ForeColor = Color.White
	            Me.Close()
	            count.Stop()
	        Case -7
	            Me.BackColor = Color.Black
	            history.BackColor = Color.White
	            history.ForeColor = Color.Black
	        Case -6
	            Me.BackColor = Color.Black
	            history.BackColor = Color.Black
	            history.ForeColor = Color.White
	        Case -5
	            Me.BackColor = Color.Black
	            history.BackColor = Color.White
	            history.ForeColor = Color.Black
	        Case -4
	            Me.BackColor = Color.Black
	            history.BackColor = Color.Black
	            history.ForeColor = Color.White
	        Case -3
	            Me.BackColor = Color.Black
	            history.BackColor = Color.White
	            history.ForeColor = Color.Black
	        Case -2
	            Me.BackColor = Color.Black
	            history.BackColor = Color.Black
	            history.ForeColor = Color.White
	        Case -1
	            Me.BackColor = Color.Black
	            history.BackColor = Color.White
	            history.ForeColor = Color.Black
	            count.Interval = 100
	            Me.Close()
	        Case 4
	            count.Interval = 100
	            history.Text += ("12padams: Oh " & mainname & " just remember to watch the year incase something goes wrong... have a good trip :)" & Environment.NewLine)
	        Case 8
	            history.Text += ("The Hidden Hacker: Ok cool thanks for that" & Environment.NewLine)
	        Case 13
	            history.Text += ("12padams: well when " & mainname & " gets back ill let you go as well on the next one" & Environment.NewLine)
	        Case 17
	            history.Text += ("The Hidden Hacker: not really... I just wish I got to time travel myself" & Environment.NewLine)
	        Case 22
	            history.Text += ("12padams: Is there anything you want to say to " & mainname & " now just before " & mainname & " is gone?" & Environment.NewLine)
	        Case 27
	            history.Text += ("12padams: yea me too but it needs to be done..." & Environment.NewLine)
	        Case 33
	            history.Text += ("The Hidden Hacker: Yea... I just wish It didn't take so long :(" & Environment.NewLine)
	        Case 37
	            history.Text += ("12padams: Ok well here we go again... another test which will show interesting and powerful results" & Environment.NewLine)
	        Case 42
	            history.Text += ("The Hidden Hacker: Don't worry I will tell you strait away I promise" & Environment.NewLine)
	        Case 48
	            history.Text += ("12padams: Ok get just remeber as soon as " & mainname & " gets the the year 2000 you need to tell me strait away" & Environment.NewLine)
	        Case 53
	            history.Text += ("The Hidden Hacker: Well I guess I trust you then" & Environment.NewLine)
	        Case 57
	            history.Text += ("12padams: don't worry nothings gunna happen" & Environment.NewLine)
	        Case 62
	            history.Text += ("The Hidden Hacker: Well I hope nothing goes wrong..." & Environment.NewLine)
	        Case 86
	            history.Text += ("12padams: No it can't thats why i have coded it so if it does show 1900 it will jump forward in time back the the year 2000" & Environment.NewLine)
	        Case 72
	            history.Text += ("The Hidden Hacker: wait are you saying that this software can accually take someone back that far?" & Environment.NewLine)
	        Case 78
	            history.Text += ("12padams: Well apon the numbers switching to 2000 it may instead switch to 1900" & Environment.NewLine)
	        Case 82
	            history.Text += ("The Hidden Hacker: Ok but can you tell me what will happen?" & Environment.NewLine)
	        Case 87
	            history.Text += ("12padams: Well I am just worried about when he goes past the year 2000 during travel..." & Environment.NewLine)
	        Case 91
	            history.Text += ("The Hidden Hacker: I know that but what could happen?" & Environment.NewLine)
	        Case 96
	            history.Text += ("12padams: Well There may be the slight chance of YK2 interference" & Environment.NewLine)
	        Case 100
	            history.Text += ("The Hidden Hacker: I need to know what could go wrong." & Environment.NewLine)
	        Case 104
	        	history.Text += ("12padams: What do you need to know?" & Environment.NewLine)
	        Case 108
	            history.Text += ("The Hidden Hacker: I just have a few questions..." & Environment.NewLine)
	        Case 111
	            history.Text += ("The Hidden Hacker: Don't Worry... I will" & Environment.NewLine)
	        Case 115
	            history.Text += ("12padams: You just have to make sure you tell me ok..." & Environment.NewLine)
	        Case 120
	            history.Text += ("12padams: I want you to tell me as soon as he ges the the year 2000 then we will start another chat." & Environment.NewLine)
	        Case 124
	            history.Text += ("12padams: wow good job... ok heres what we will do" & Environment.NewLine)
	        Case 130
	            history.Text += ("The Hidden Hacker: Hey I got tracking software which will alert me as soon as the time travel is over... I developed it after a year of waiting." & Environment.NewLine)
	        Case 135
	            history.Text += ("12padams: The most important thing now is preparing for when " & mainname & " gets to the year 2000" & Environment.NewLine)
	        Case 140
	            history.Text += ("12padams: Now we have to stop chatting about who gets to do what now " & Environment.NewLine)
	        Case 144
	            history.Text += ("The Hidden Hacker: Hmm I would prefere to be me then..." & Environment.NewLine)
	        Case 149
	            history.Text += ("12padams: Well accually " & mainname & " will need to go back to 1998 after experiencing all the future tech so..." & Environment.NewLine)
	        Case 155
	            history.Text += ("The Hidden Hacker: Ok... " & mainname & " you should feel happy that you don't have to wait a whole year for results " & Environment.NewLine)
	        Case 160
	            history.Text += ("12padams: Hey hidden hacker... if your doing tests like this they take time... just be patient " & Environment.NewLine)
	        Case 166
	            history.Text += ("The Hidden Hacker: Oh great not another whole year :( " & Environment.NewLine)
	        Case 170
	            history.Text += ("12padams: your wrong... 3 minutes for " & mainname & " and 1 year for us..." & Environment.NewLine)
	        Case 175
	            history.Text += ("The Hidden Hacker: Hmm 3 minutes and we get to see the results to this test " & Environment.NewLine)
		    Case Else 'Probably a better way to do this
		        If count2000 < 175 Then
		            history.Focus()
		            history.SelectionStart = 999999
		            history.ScrollToCaret()
		            typechat.Focus()
		        End If
		End Select
    End Sub
End Class