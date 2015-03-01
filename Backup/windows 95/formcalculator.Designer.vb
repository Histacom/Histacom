<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formcalculator
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
        Me.calculator = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyCtrlCToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteCtrlVToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpTopicsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.outsideprogramtopbar = New System.Windows.Forms.Panel
        Me.programtopbar = New System.Windows.Forms.Panel
        Me.maximizebutton = New System.Windows.Forms.PictureBox
        Me.minimizebutton = New System.Windows.Forms.PictureBox
        Me.programname = New System.Windows.Forms.Label
        Me.closebutton = New System.Windows.Forms.PictureBox
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.program.SuspendLayout()
        Me.calculator.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
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
        Me.program.Controls.Add(Me.calculator)
        Me.program.Controls.Add(Me.outsideprogramtopbar)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(290, 280)
        Me.program.TabIndex = 3
        '
        'calculator
        '
        Me.calculator.BackColor = System.Drawing.Color.Silver
        Me.calculator.Controls.Add(Me.TextBox1)
        Me.calculator.Controls.Add(Me.Button27)
        Me.calculator.Controls.Add(Me.Button26)
        Me.calculator.Controls.Add(Me.Button25)
        Me.calculator.Controls.Add(Me.Button21)
        Me.calculator.Controls.Add(Me.Button22)
        Me.calculator.Controls.Add(Me.Button23)
        Me.calculator.Controls.Add(Me.Button24)
        Me.calculator.Controls.Add(Me.Button17)
        Me.calculator.Controls.Add(Me.Button18)
        Me.calculator.Controls.Add(Me.Button19)
        Me.calculator.Controls.Add(Me.Button20)
        Me.calculator.Controls.Add(Me.Button14)
        Me.calculator.Controls.Add(Me.Button15)
        Me.calculator.Controls.Add(Me.Button16)
        Me.calculator.Controls.Add(Me.Button11)
        Me.calculator.Controls.Add(Me.Button12)
        Me.calculator.Controls.Add(Me.Button13)
        Me.calculator.Controls.Add(Me.Button8)
        Me.calculator.Controls.Add(Me.Button9)
        Me.calculator.Controls.Add(Me.Button10)
        Me.calculator.Controls.Add(Me.Button5)
        Me.calculator.Controls.Add(Me.Button6)
        Me.calculator.Controls.Add(Me.Button7)
        Me.calculator.Controls.Add(Me.Button4)
        Me.calculator.Controls.Add(Me.Button3)
        Me.calculator.Controls.Add(Me.Button2)
        Me.calculator.Controls.Add(Me.Button1)
        Me.calculator.Controls.Add(Me.MenuStrip2)
        Me.calculator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calculator.Location = New System.Drawing.Point(0, 25)
        Me.calculator.Name = "calculator"
        Me.calculator.Size = New System.Drawing.Size(286, 251)
        Me.calculator.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 28)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button27
        '
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.Firebrick
        Me.Button27.Location = New System.Drawing.Point(165, 65)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(53, 30)
        Me.Button27.TabIndex = 26
        Me.Button27.Text = "CE"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.Firebrick
        Me.Button26.Location = New System.Drawing.Point(223, 65)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(53, 30)
        Me.Button26.TabIndex = 25
        Me.Button26.Text = "C"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.Color.Firebrick
        Me.Button25.Location = New System.Drawing.Point(106, 65)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(53, 30)
        Me.Button25.TabIndex = 24
        Me.Button25.Text = "Back"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button21.Location = New System.Drawing.Point(238, 208)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(38, 30)
        Me.Button21.TabIndex = 23
        Me.Button21.Text = "="
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button22.Location = New System.Drawing.Point(238, 101)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(38, 30)
        Me.Button22.TabIndex = 22
        Me.Button22.Text = "sqrt"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button23.Location = New System.Drawing.Point(238, 173)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(38, 30)
        Me.Button23.TabIndex = 21
        Me.Button23.Text = "1/x"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button24.Location = New System.Drawing.Point(238, 137)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(38, 30)
        Me.Button24.TabIndex = 20
        Me.Button24.Text = "%"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Red
        Me.Button17.Location = New System.Drawing.Point(194, 208)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(38, 30)
        Me.Button17.TabIndex = 19
        Me.Button17.Text = "+"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Red
        Me.Button18.Location = New System.Drawing.Point(194, 101)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(38, 30)
        Me.Button18.TabIndex = 18
        Me.Button18.Text = "/"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Red
        Me.Button19.Location = New System.Drawing.Point(194, 173)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(38, 30)
        Me.Button19.TabIndex = 17
        Me.Button19.Text = "-"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.Red
        Me.Button20.Location = New System.Drawing.Point(194, 137)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(38, 30)
        Me.Button20.TabIndex = 16
        Me.Button20.Text = "x"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Blue
        Me.Button14.Location = New System.Drawing.Point(150, 208)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(38, 30)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "."
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Blue
        Me.Button15.Location = New System.Drawing.Point(106, 208)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(38, 30)
        Me.Button15.TabIndex = 14
        Me.Button15.Text = "+/-"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Blue
        Me.Button16.Location = New System.Drawing.Point(62, 208)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(38, 30)
        Me.Button16.TabIndex = 13
        Me.Button16.Text = "0"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Blue
        Me.Button11.Location = New System.Drawing.Point(150, 101)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(38, 30)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "9"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Blue
        Me.Button12.Location = New System.Drawing.Point(150, 173)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(38, 30)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "3"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Blue
        Me.Button13.Location = New System.Drawing.Point(150, 137)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(38, 30)
        Me.Button13.TabIndex = 10
        Me.Button13.Text = "6"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Blue
        Me.Button8.Location = New System.Drawing.Point(106, 101)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 30)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Blue
        Me.Button9.Location = New System.Drawing.Point(106, 173)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 30)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "2"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Blue
        Me.Button10.Location = New System.Drawing.Point(106, 137)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(38, 30)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "5"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Blue
        Me.Button5.Location = New System.Drawing.Point(62, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 30)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "7"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Blue
        Me.Button6.Location = New System.Drawing.Point(62, 173)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 30)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "1"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Blue
        Me.Button7.Location = New System.Drawing.Point(62, 137)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 30)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "4"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(9, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "MC"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(9, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "MS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(9, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "M+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(9, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.HelpToolStripMenuItem2, Me.HelpToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(286, 24)
        Me.MenuStrip2.TabIndex = 28
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyCtrlCToolStripMenuItem1, Me.PasteCtrlVToolStripMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'CopyCtrlCToolStripMenuItem1
        '
        Me.CopyCtrlCToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.CopyCtrlCToolStripMenuItem1.Name = "CopyCtrlCToolStripMenuItem1"
        Me.CopyCtrlCToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.CopyCtrlCToolStripMenuItem1.Text = "Copy       Ctrl+C"
        '
        'PasteCtrlVToolStripMenuItem1
        '
        Me.PasteCtrlVToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.PasteCtrlVToolStripMenuItem1.Name = "PasteCtrlVToolStripMenuItem1"
        Me.PasteCtrlVToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.PasteCtrlVToolStripMenuItem1.Text = "Paste       Ctrl+V"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScientificToolStripMenuItem, Me.StandardToolStripMenuItem})
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem2.Text = "Veiw"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'HelpToolStripMenuItem3
        '
        Me.HelpToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpTopicsToolStripMenuItem1, Me.AboutCalculatorToolStripMenuItem})
        Me.HelpToolStripMenuItem3.Name = "HelpToolStripMenuItem3"
        Me.HelpToolStripMenuItem3.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem3.Text = "Help"
        '
        'HelpTopicsToolStripMenuItem1
        '
        Me.HelpTopicsToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.HelpTopicsToolStripMenuItem1.Name = "HelpTopicsToolStripMenuItem1"
        Me.HelpTopicsToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.HelpTopicsToolStripMenuItem1.Text = "Help Topics"
        '
        'AboutCalculatorToolStripMenuItem
        '
        Me.AboutCalculatorToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.AboutCalculatorToolStripMenuItem.Name = "AboutCalculatorToolStripMenuItem"
        Me.AboutCalculatorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AboutCalculatorToolStripMenuItem.Text = "About Calculator"
        '
        'outsideprogramtopbar
        '
        Me.outsideprogramtopbar.Controls.Add(Me.programtopbar)
        Me.outsideprogramtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.outsideprogramtopbar.Location = New System.Drawing.Point(0, 0)
        Me.outsideprogramtopbar.Name = "outsideprogramtopbar"
        Me.outsideprogramtopbar.Size = New System.Drawing.Size(286, 25)
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
        Me.programtopbar.Size = New System.Drawing.Size(280, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.windows_95.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(246, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.windows_95.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(230, 2)
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
        Me.programname.Size = New System.Drawing.Size(64, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Calculator"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.windows_95.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(263, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'look
        '
        '
        'formcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 280)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formcalculator"
        Me.Text = "formcalculator"
        Me.TopMost = True
        Me.program.ResumeLayout(False)
        Me.calculator.ResumeLayout(False)
        Me.calculator.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.outsideprogramtopbar.ResumeLayout(False)
        Me.programtopbar.ResumeLayout(False)
        Me.programtopbar.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents calculator As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCtrlCToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteCtrlVToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpTopicsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents outsideprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents look As System.Windows.Forms.Timer
End Class
