Public Class windows_explorer



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

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        ListView1.Items.Clear()
        Dim childamount As TreeNodeCollection
        childamount = TreeView1.SelectedNode.Nodes
        lblamountofobjects.Text = (childamount.Count & " objects(s)")
        For Each TreeNode In TreeView1.SelectedNode.Nodes
            If TreeNode.tag = "file" Then
                TreeNode.forecolor = TreeView1.BackColor
            End If
            ListView1.Items.Add(TreeNode.text)
        Next

    End Sub

    Private Sub windows_explorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblamountofobjects.Text = "0 objects"
        look.Start()
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub
End Class