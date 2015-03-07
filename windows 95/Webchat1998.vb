Public Class Webchat1998
    Dim con As Integer
    Dim ran As New Random
    Dim abletoclose As Boolean
    Dim correct As Boolean
    Dim username As String
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        If abletoclose Then
            Me.Close()
        End If
    End Sub

    Private Sub me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
        Button3.Hide()
        Button4.Hide()
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
        history.Text += (username & ": " & typechat.Text & Environment.NewLine)
        typechat.Text = ""
        typechat.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
    End Sub

    Private Sub Chat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chat.Tick
        Select Case con
            Case 144
                Title_Screen.Close()
            Case 143
                history.Text = (Environment.NewLine & "Game Over... You lose because you are using MS-DOS from the early 1980's and its 1998... Serriously what were you thinking??" & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 142
                history.Text += ("" & Environment.NewLine)
                history.Text += ("" & Environment.NewLine)
                history.Text += ("C:\>")
                Chat.Interval = 10000
                history.ReadOnly = False
                con += 1
            Case 141
                history.Text = "Starting MS-DOS..."
                Chat.Interval = 4000
                history.ReadOnly = True
                con += 1
            Case 140
                history.Text = ""
                Chat.Interval = 2000
                history.ReadOnly = True
                con += 1
            Case 139
                history.Text += ("12padams: Oh last of all here is one hint... DOS IS USLESS... ITS JUST TEXT. NEXTTIME DON'T PIRATE SOFTWARE" & Environment.NewLine)
                Chat.Interval = 6000
                history.ReadOnly = False
                con += 1
            Case 138
                history.Text += ("12padams: Ok see ya... You have learned two leasons today... 1. don't pirtae software,    2. you learnt about old operating systems." & Environment.NewLine)
                Chat.Interval = 10000
                history.ReadOnly = False
                con += 1
            Case 137
                history.ForeColor = Color.Silver
                Chat.Interval = 2000
                history.ReadOnly = False
                con += 1
            Case 136
                history.Text += ("12padams: In DOS the computer had grey text not white text i just gotta modify it first." & Environment.NewLine)
                Chat.Interval = 4000
                history.ReadOnly = False
                con += 1
            Case 135
                history.Text += ("12padams: Ok I just need to do one last setup for DOS" & Environment.NewLine)
                Chat.Interval = 4000
                history.ReadOnly = False
                con += 1
            Case 133
                history.Text += ("12padams: Your computer now needs MS-DOS this will disconnect you from the convasation." & Environment.NewLine)
                Chat.Interval = 7000
                history.ReadOnly = False
                con = con + 2
            Case 131
                history.Text += ("12padams: Hmm i am being to kind.... I think i gotta go now." & Environment.NewLine)
                Chat.Interval = 6000
                history.ReadOnly = False
                con = con + 2
            Case 130
                history.Text += ("12padams: Ok there you go you can now type... Happy now?" & Environment.NewLine)
                Chat.Interval = 8000
                history.ReadOnly = False
                con += 1
            Case 129
                history.Text += ("12padams: Lol for once i am giving you a feature..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 128
                history.Text += ("12padams: Ok Well lol woops you can't type... thats a big mistake!!!!" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 127
                history.Text += ("12padams: Good now thats gone. I really gotta think for a little while at what to do next." & Environment.NewLine)
                Chat.Interval = 10000
                con += 1
            Case 126
                program.BorderStyle = BorderStyle.None
                history.BorderStyle = BorderStyle.None
                top.Hide()
                left.Hide()
                bottom.Hide()
                right.Hide()
                toprightcorner.Hide()
                topleftcorner.Hide()
                bottomrightcorner.Hide()
                bottomleftcorner.Hide()
                Chat.Interval = 3000
                con += 1
            Case 125
                history.Text += ("12padams: Ok ill remove it now." & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 124
                history.Text += ("12padams: Oh and the the white border around your screen i can't forget to remove that..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 123
                history.Text += ("12padams: mouse removed..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
                Cursor.Hide()
            Case 122
                history.Text += ("12padams: 1" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 121
                history.Text += ("12padams: 2" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 120
                history.Text += ("12padams: 3 " & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 119
                history.Text += ("12padams: 4" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 118
                history.Text += ("12padams: 5" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 117
                history.Text += ("12padams: 6" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 116
                history.Text += ("12padams: 7" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 115
                history.Text += ("12padams: 8" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 114
                history.Text += ("12padams: 9" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 113
                history.Text += ("12padams: Ok removing in 10..." & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 112
                history.Text += ("12padams: Ok enjoy the mouse while you can because I am just about to remove it..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 111
                history.Text += ("12padams: How could i forget to remove then mouse..." & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 110
                history.Text += ("12padams: Ok this is imbarrissing... I forgot to remove something thats really noticable that didn't exist." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 109
                history.Text += ("12padams: Hmm... I seem to be making quite a good theme... I really should add this to skindows..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 108
                history.ScrollBars = ScrollBars.None
                Chat.Interval = 4000
                con += 1
            Case 107
                history.Text += ("12padams: Ill just remove it now..." & Environment.NewLine)
                Chat.Interval = 2000
                con += 1
            Case 106
                history.Text += ("12padams: I see the scroll bar at the side of the screen... that didn't exist early 1980's" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 105
                history.Text += ("12padams: hmm theres still something missing..." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 104
                history.Text += ("12padams: Wow your computers looking good... I should be a programmer since i did such a godo job..." & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 103
                history.Dock = DockStyle.Fill
                Chat.Interval = 3000
                con += 1
            Case 102
                history.Text += ("12padams: Hmm yes Thats whats missing I gotta make the text full screen..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 101
                history.Text += ("12padams: I Think I almost got your computer converted... early 1980's should be enough of a punishment..." & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 100
                history.ForeColor = Color.White
                history.BackColor = Color.Black
                Chat.Interval = 6000
                con += 1
            Case 99
                Me.BackColor = Color.Black
                Chat.Interval = 5000
                con += 1
            Case 98
                history.Text += ("12padams: Ok I hope Your not Scared Of the dark!" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 97
                history.Text += ("12padams: Hmm ok this is gunna be tricky..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 96
                history.Text += ("12padams: Oh and we didn't have backgrounds... or even color for the matter..." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 95
                Chat.Interval = 3000
                con += 1
                Label6.Hide()
                Label1.Hide()
                Label7.Hide()
            Case 94
                history.Text += ("12padams: First of all we didn't have labels... so ill remove labels now" & Environment.NewLine)
                Chat.Interval = 2000
                con += 1
            Case 93
                history.Text += ("12padams: Well let me give you a little lesson on the history of computers..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 92
                history.Text += ("12padams: This is good now i can teach you and punish you at the same time lol :) " & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 91
                history.Text += ("12padams: Hey you must be new to computers... " & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 90
                history.Text += ("12padams: Hmm your new... Infact I have scanned your system and your using windwos 95 which you just got very recenty... " & Environment.NewLine)
                Chat.Interval = 10000
                con += 1
            Case 89
                history.Text += ("12padams: Oh thats Right you dont even talk so your problably don't even know its gone... " & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 88
                history.Text += ("12padams: Lol your problably saying WHY CAN'T I TALK... " & Environment.NewLine)
                Chat.Interval = 4000
                typechat.Hide()
                Button2.Hide()
                con += 1
            Case 87
                history.Text += ("12padams: Since you never talk i guess you won't be needing this..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 86
                history.Text += ("12padams: " & username & "? I don't remeber you... Oh right your the silent one... " & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 85
                history.Text += ("12padams: Now We are just left with... um wait who was it again..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 84
                history.Text += ("SkyHigh Has Logged Off" & Environment.NewLine)
                ListBox1.Items.Remove("SkyHigh")
                Chat.Interval = 5000
                con += 1
            Case 83
                history.Text += ("12padams: Oh Don't you know how to? here ill do it for you..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 82
                history.Text += ("SkyHigh: But I can't!!!" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 81
                history.Text += ("12padams: Stop? you both have been able to stop this the whole time... just turn off your computer..." & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 80
                history.Text += ("SkyHigh: Please Stop!!!" & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 79
                history.Text += ("12padams: Ok now that thats removed i Can deal with your punishments" & Environment.NewLine)
                Chat.Interval = 5000
                Panel1.Hide()
                con += 1
            Case 78
                history.Text += ("12padams: No because i got rid of him... oh woops and talking about getting rid of things lol i forgot to remove the illegal file he uploaded which has been here all along..." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 77
                history.Text += ("12padams: Exactly and rain49 uploaded the skindows and do you see him now?" & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 76
                history.Text += ("SkyHigh: I thought its only illegal to upload stuff..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 75
                history.Text += ("SkyHigh: Please Thats It!!! STOP. Me and " & username & " didn't accually do the uploading..." & Environment.NewLine)
                Chat.Interval = 9000
                con += 1
            Case 74
                history.Text += ("SkyHigh: Damn IT!!! what are we supposed to do now " & username & "... he got rid of the top bar with the close button and maximize and all the..." & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 73
                programtopbar.Hide()
                Chat.Interval = 3000
                con += 1
            Case 72
                history.Text += ("12padams: What I have done everything...? What about this?" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 71
                history.Text += ("SkyHigh: NOOOOOOO please this is enough you have done everything. I won't illegally download your software again" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 70
                Chat.Interval = 4000
                con += 1
                Windows95.Hide()
                Me.WindowState = FormWindowState.Maximized
            Case 69
                history.Text += ("12padams: Well first I need your full attention..." & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
                Dim FontName As String = "Arial"
                Dim FontSize As Integer = 11
                Dim FS As New Font(FontName, FontSize, FontStyle.Regular)
                history.Font = FS
            Case 68
                history.Text += ("SkyHigh: Please Let Me and " & username & " go and just forget this happened!!!!" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 67
                history.Text += ("12padams: You wanna Know how to Stop this?!!!!" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 66
                history.Text += ("SkyHigh: Please Stop!!!!" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 65
                history.Text += ("12padams: Oh yea and your icons are infected so you don't need them" & Environment.NewLine)
                Chat.Interval = 8000
                Windows95.desktopicons.Hide()
                con += 1
            Case 64
                history.Text += ("12padams: Oh but you said to the remove viruses and your taskbar was infected... it had no start button" & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 63
                history.Text += ("SkyHigh: Hey What the hell give me back my taskbar!!!" & Environment.NewLine)
                Chat.Interval = 9000
                con += 1
            Case 62
                history.Text += ("12padams: Hmm the taskbar was made by microsoft for windows 95...." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
                Windows95.taskbar.Hide()
            Case 61
                history.Text += ("12padams: Hmm I see a Taskbar at the bottom of the screen..." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 60
                history.Text += ("12padams: Well the whole of windows 95 is a virus so hmm where do we begin..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 59
                history.Text += ("12padams: Get Rid of the viruses did you say???" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 58
                history.Text += ("SkyHigh: What the Hell??? just get rid of these viruses now!!!" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 57
                history.Text += ("12padams: Anyway SkyHigh you are asking to many questions... Its time I unleash my next virus" & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 56
                history.Text += ("12padams: Well It causes your computer to have all its funtions disabled" & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 55
                history.Text += ("SkyHigh: Whats the virus do?" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 54
                history.Text += ("12padams: Your both experienceing a lethal virus which i like to call (death)" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 53
                history.Text += ("12padams: I told you that you were gunna be punished...." & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 52
                history.Text += ("SkyHigh: Hey what i can't open anything?" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 51
                history.Text += ("SkyHigh: Don't worry " & username & " ill look online for help" & Environment.NewLine)
                Chat.Interval = 4000
                Windows95.Enabled = False
                con += 1
            Case 50
                history.Text += ("12padams: Hey trying to fight back are we...? well ill punish you both!" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 49
                history.Text += ("SkyHigh: Stop it!!! Let me and " & username & " go!" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 48
                history.Text += ("12padams: Oh yea thats right... Now we had two left. We have SkyHigh and " & username & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 47
                history.Text += ("12padams: anyway... where were we?" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 46
                history.Text += ("12padams: lol All your Computers are infected with a virus which makes them unable to boot." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 45
                history.Text += ("rain49 Has Logged Out" & Environment.NewLine)
                ListBox1.Items.Remove("rain49")
                Chat.Interval = 7000
                con += 1
            Case 44
                history.Text += ("rain49: Oh yea... just watch" & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 43
                history.Text += ("12padams: I would not do that if i were you..." & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 42
                history.Text += ("rain49: No... because i can just turn my computer off at the powerpoint... " & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 41
                history.Text += ("12padams: ... scared Yet?" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 40
                history.Text += ("rain49: Omg 12padams disabled it..." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 39
                history.Text += ("SkyHigh: What the Hell!!!! wheres my startbutton." & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 38
                history.Text += ("12padams: Ha Ha Ha... nobodys turning off their computer???" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 37
                history.Text += ("12padams: Yea Guys I Will definatly unban you if you do that..." & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
                Windows95.startbutton.Hide()
            Case 36
                history.Text += ("rain49: Guys Quickly go to start and turn off your computer!!!" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 35
                history.Text += ("12padams: Now that I Have you... We are gunna have a bit of fun..." & Environment.NewLine)
                Chat.Interval = 10000
                con += 1
            Case 34
                history.Text += ("12padams: I Have Caught you!!!" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 33
                history.Text += ("SkyHigh: I can't the x button is not working!!!!" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 32
                history.Text += ("rain49: CRAP 12padams logged on... Quickly SkyHigh and " & username & " LOGOUT!!!" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 31
                history.Text += ("12padams Has Logged On" & Environment.NewLine)
                ListBox1.Items.Add("12padams")
                Chat.Interval = 4000
                con += 1
                abletoclose = False
            Case 30
                history.Text += ("SkyHigh: OMG THIS IS AWESOME.... I like the fire theme :0" & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 29
                history.Text += ("rain49: ok have fun then..." & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 28
                history.Text += ("SkyHigh: YAY! Download Finished... Ill install it now :)" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 27
                history.Text += ("rain49: lol ok... hey " & username & " you can download it as well :)" & Environment.NewLine)
                Chat.Interval = 9000
                con += 1
            Case 26
                history.Text += ("SkyHigh: Yay Thanks rain49!!! Ill download it now" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 25
                history.Text += ("rain49: Its now added to the file sharing section at the bottom right of the screen" & Environment.NewLine)
                Chat.Interval = 4000
                Label5.Show()
                Button5.Show()
                con += 1
            Case 24
                history.Text += ("rain49: Ok just wait a sec..." & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 23
                history.Text += ("SkyHigh: I think thats enough time... SEND IT NOW!!!!" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 22
                history.Text += ("rain49: Wait ill just give " & username & " a few moments to quit this chat just incase..." & Environment.NewLine)
                Chat.Interval = 10000
                con += 1
            Case 21
                history.Text += ("SkyHigh: Come on send it now..." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 20
                history.Text += ("SkyHigh: Yea and rain 49 is gunna send it to us through Webchat :)" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 19
                history.Text += ("rain49: Anyway on the 12padams site there is a really cool piece of software called skindows95" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 18
                history.Text += ("rain49: If I were you i would log out right now... otherwise you will probably be banned" & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 17
                history.Text += ("rain49: Ok " & username & " we are going to be breaking the chat rules..." & Environment.NewLine)
                Chat.Interval = 8000
                con += 1
            Case 16
                history.Text += ("rain49: Ill Have to tell " & username & " then..." & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 15
                history.Text += ("SkyHigh: Oh woops I forgot to to warn " & username & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 14
                history.Text += ("rain49: Oh ok... Does " & username & " know?" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 13
                history.Text += ("SkyHigh: Oh " & username & " is just some new person who just logged on for the first time today" & Environment.NewLine)
                Chat.Interval = 6000
                con += 1
            Case 12
                history.Text += ("rain49: Hey Who's " & username & Environment.NewLine)
                Chat.Interval = 7000
                con += 1
            Case 11
                history.Text += ("rain49: lol... hi SkyHigh" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 10
                history.Text += ("SkyHigh: rain49 is finally on :) !!!!!!" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 9
                history.Text += ("SkyHigh: Yay" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 8
                history.Text += ("rain49 Has Logged On" & Environment.NewLine)
                ListBox1.Items.Add("rain49")
                Chat.Interval = 4000
                con += 1
            Case 7
                If correct Then
                    history.Text += ("SkyHigh: Yay You got it :)" & Environment.NewLine)
                    Button4.Hide()
                    Button3.Hide()
                    typechat.Show()
                    con += 1
                ElseIf Not correct Then
                    history.Text += ("SkyHigh: Sorry My Name was Bill :(" & Environment.NewLine)
                    Button4.Hide()
                    Button3.Hide()
                    typechat.Show()
                    con += 1
                End If
            Case 6
                history.Text += ("SkyHigh: Ill make 2 buttons appear at the bottom of your screen and you click to guess" & Environment.NewLine)
                Chat.Interval = 500
                con += 1
                Button3.Show()
                Button4.Show()
                typechat.Hide()
                Chat.Stop()
            Case 5
                history.Text += ("SkyHigh: Ok Guess What my Name is" & Environment.NewLine)
                Chat.Interval = 3000
                con += 1
            Case 4
                history.Text += ("SkyHigh: " & username & " We can play a game while we wait for rain49 to login" & Environment.NewLine)
                Chat.Interval = 4000
                con += 1
            Case 3
                history.Text += ("SkyHigh: But wait!" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 2
                history.Text += ("SkyHigh: Sorry I thought my friend rain49 was gunna be on..." & Environment.NewLine)
                Chat.Interval = 1000
                con += 1
            Case 1
                history.Text += ("SkyHigh: Damn" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
            Case 0
                ListBox1.Items.Add("SkyHigh")
                history.Text += ("SkyHigh Has Logged On" & Environment.NewLine)
                Chat.Interval = 5000
                con += 1
        End Select
        history.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
        typechat.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con = 7
        correct = False
        Chat.Start()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con = 7
        correct = True
        Chat.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Skindows 95"
    End Sub
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
        Me.Hide()
    End Sub

End Class