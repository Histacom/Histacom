<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formnotepad
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
        Me.program = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.notepadtextbox = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoCtrlZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutCtrlXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyCtrlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteDelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TimeDateF5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FindNextF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpTopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutNotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.outsideprogramtopbar = New System.Windows.Forms.Panel
        Me.programtopbar = New System.Windows.Forms.Panel
        Me.maximizebutton = New System.Windows.Forms.PictureBox
        Me.minimizebutton = New System.Windows.Forms.PictureBox
        Me.programname = New System.Windows.Forms.Label
        Me.closebutton = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.program.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.outsideprogramtopbar.SuspendLayout()
        Me.programtopbar.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.program.Controls.Add(Me.Panel1)
        Me.program.Controls.Add(Me.outsideprogramtopbar)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(412, 349)
        Me.program.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.notepadtextbox)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 320)
        Me.Panel1.TabIndex = 2
        '
        'notepadtextbox
        '
        Me.notepadtextbox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.notepadtextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.notepadtextbox.Location = New System.Drawing.Point(0, 24)
        Me.notepadtextbox.Multiline = True
        Me.notepadtextbox.Name = "notepadtextbox"
        Me.notepadtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.notepadtextbox.Size = New System.Drawing.Size(408, 296)
        Me.notepadtextbox.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SearchToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(408, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup..."
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoCtrlZToolStripMenuItem, Me.CutCtrlXToolStripMenuItem, Me.CopyCtrlCToolStripMenuItem, Me.PasteCtrlVToolStripMenuItem, Me.DeleteDelToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.TimeDateF5ToolStripMenuItem, Me.WordWrapToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoCtrlZToolStripMenuItem
        '
        Me.UndoCtrlZToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem"
        Me.UndoCtrlZToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UndoCtrlZToolStripMenuItem.Text = "Undo          Ctrl+Z"
        '
        'CutCtrlXToolStripMenuItem
        '
        Me.CutCtrlXToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem"
        Me.CutCtrlXToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CutCtrlXToolStripMenuItem.Text = "Cut             Ctrl+X"
        '
        'CopyCtrlCToolStripMenuItem
        '
        Me.CopyCtrlCToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem"
        Me.CopyCtrlCToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopyCtrlCToolStripMenuItem.Text = "Copy          Ctrl+C"
        '
        'PasteCtrlVToolStripMenuItem
        '
        Me.PasteCtrlVToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.PasteCtrlVToolStripMenuItem.Name = "PasteCtrlVToolStripMenuItem"
        Me.PasteCtrlVToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PasteCtrlVToolStripMenuItem.Text = "Paste          Ctrl+V"
        '
        'DeleteDelToolStripMenuItem
        '
        Me.DeleteDelToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.DeleteDelToolStripMenuItem.Name = "DeleteDelToolStripMenuItem"
        Me.DeleteDelToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DeleteDelToolStripMenuItem.Text = "Delete         Del"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'TimeDateF5ToolStripMenuItem
        '
        Me.TimeDateF5ToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.TimeDateF5ToolStripMenuItem.Name = "TimeDateF5ToolStripMenuItem"
        Me.TimeDateF5ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TimeDateF5ToolStripMenuItem.Text = "Time/Date F5"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem1, Me.FindNextF3ToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'FindToolStripMenuItem1
        '
        Me.FindToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1"
        Me.FindToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.FindToolStripMenuItem1.Text = "Find..."
        '
        'FindNextF3ToolStripMenuItem
        '
        Me.FindNextF3ToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.FindNextF3ToolStripMenuItem.Name = "FindNextF3ToolStripMenuItem"
        Me.FindNextF3ToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FindNextF3ToolStripMenuItem.Text = "Find Next     F3"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpTopicsToolStripMenuItem, Me.AboutNotepadToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'HelpTopicsToolStripMenuItem
        '
        Me.HelpTopicsToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.HelpTopicsToolStripMenuItem.Name = "HelpTopicsToolStripMenuItem"
        Me.HelpTopicsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HelpTopicsToolStripMenuItem.Text = "Help Topics"
        '
        'AboutNotepadToolStripMenuItem
        '
        Me.AboutNotepadToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.AboutNotepadToolStripMenuItem.Name = "AboutNotepadToolStripMenuItem"
        Me.AboutNotepadToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AboutNotepadToolStripMenuItem.Text = "About Notepad"
        '
        'outsideprogramtopbar
        '
        Me.outsideprogramtopbar.Controls.Add(Me.programtopbar)
        Me.outsideprogramtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.outsideprogramtopbar.Location = New System.Drawing.Point(0, 0)
        Me.outsideprogramtopbar.Name = "outsideprogramtopbar"
        Me.outsideprogramtopbar.Size = New System.Drawing.Size(408, 25)
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
        Me.programtopbar.Size = New System.Drawing.Size(402, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.windows_95.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(368, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.windows_95.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(352, 2)
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
        Me.programname.Size = New System.Drawing.Size(55, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Notepad"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.windows_95.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(385, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'look
        '
        '
        'formnotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 349)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formnotepad"
        Me.Text = "notepad"
        Me.TopMost = True
        Me.program.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.outsideprogramtopbar.ResumeLayout(False)
        Me.programtopbar.ResumeLayout(False)
        Me.programtopbar.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents notepadtextbox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoCtrlZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutCtrlXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCtrlCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteCtrlVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteDelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeDateF5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindNextF3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpTopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutNotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents outsideprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents look As System.Windows.Forms.Timer
End Class
