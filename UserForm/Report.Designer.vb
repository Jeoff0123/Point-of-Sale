<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_SRCH = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUDEL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCNCL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuprntrpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnupulst = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrytalReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUFIRST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNYNEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPREV = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNULAST = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgrpt = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnm23 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldistotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgrpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1450, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_SRCH, Me.MNUDEL, Me.MNUCNCL, Me.mnuprntrpt, Me.MNUCLOSE})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'MNU_SRCH
        '
        Me.MNU_SRCH.Image = CType(resources.GetObject("MNU_SRCH.Image"), System.Drawing.Image)
        Me.MNU_SRCH.Name = "MNU_SRCH"
        Me.MNU_SRCH.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MNU_SRCH.Size = New System.Drawing.Size(290, 36)
        Me.MNU_SRCH.Text = "Search"
        '
        'MNUDEL
        '
        Me.MNUDEL.Image = CType(resources.GetObject("MNUDEL.Image"), System.Drawing.Image)
        Me.MNUDEL.Name = "MNUDEL"
        Me.MNUDEL.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.MNUDEL.Size = New System.Drawing.Size(290, 36)
        Me.MNUDEL.Text = "Delete"
        '
        'MNUCNCL
        '
        Me.MNUCNCL.Image = CType(resources.GetObject("MNUCNCL.Image"), System.Drawing.Image)
        Me.MNUCNCL.Name = "MNUCNCL"
        Me.MNUCNCL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MNUCNCL.Size = New System.Drawing.Size(290, 36)
        Me.MNUCNCL.Text = "Refresh"
        '
        'mnuprntrpt
        '
        Me.mnuprntrpt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnupulst, Me.CrytalReportToolStripMenuItem})
        Me.mnuprntrpt.Image = CType(resources.GetObject("mnuprntrpt.Image"), System.Drawing.Image)
        Me.mnuprntrpt.Name = "mnuprntrpt"
        Me.mnuprntrpt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuprntrpt.ShowShortcutKeys = False
        Me.mnuprntrpt.Size = New System.Drawing.Size(290, 36)
        Me.mnuprntrpt.Text = "Print"
        '
        'mnupulst
        '
        Me.mnupulst.Image = CType(resources.GetObject("mnupulst.Image"), System.Drawing.Image)
        Me.mnupulst.Name = "mnupulst"
        Me.mnupulst.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnupulst.Size = New System.Drawing.Size(431, 36)
        Me.mnupulst.Text = "Excel"
        '
        'CrytalReportToolStripMenuItem
        '
        Me.CrytalReportToolStripMenuItem.Image = CType(resources.GetObject("CrytalReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CrytalReportToolStripMenuItem.Name = "CrytalReportToolStripMenuItem"
        Me.CrytalReportToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.CrytalReportToolStripMenuItem.Size = New System.Drawing.Size(431, 36)
        Me.CrytalReportToolStripMenuItem.Text = "Crytal Report"
        '
        'MNUCLOSE
        '
        Me.MNUCLOSE.Image = CType(resources.GetObject("MNUCLOSE.Image"), System.Drawing.Image)
        Me.MNUCLOSE.Name = "MNUCLOSE"
        Me.MNUCLOSE.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MNUCLOSE.Size = New System.Drawing.Size(290, 36)
        Me.MNUCLOSE.Text = "Close"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUFIRST, Me.MNYNEXT, Me.MNUPREV, Me.MNULAST})
        Me.NavigationToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.NavigationToolStripMenuItem.Image = CType(resources.GetObject("NavigationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(187, 36)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'MNUFIRST
        '
        Me.MNUFIRST.Image = CType(resources.GetObject("MNUFIRST.Image"), System.Drawing.Image)
        Me.MNUFIRST.Name = "MNUFIRST"
        Me.MNUFIRST.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.MNUFIRST.Size = New System.Drawing.Size(300, 36)
        Me.MNUFIRST.Text = "BOF"
        '
        'MNYNEXT
        '
        Me.MNYNEXT.Image = CType(resources.GetObject("MNYNEXT.Image"), System.Drawing.Image)
        Me.MNYNEXT.Name = "MNYNEXT"
        Me.MNYNEXT.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.MNYNEXT.Size = New System.Drawing.Size(300, 36)
        Me.MNYNEXT.Text = "Next"
        '
        'MNUPREV
        '
        Me.MNUPREV.Image = CType(resources.GetObject("MNUPREV.Image"), System.Drawing.Image)
        Me.MNUPREV.Name = "MNUPREV"
        Me.MNUPREV.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.MNUPREV.Size = New System.Drawing.Size(300, 36)
        Me.MNUPREV.Text = "Prev"
        '
        'MNULAST
        '
        Me.MNULAST.Image = CType(resources.GetObject("MNULAST.Image"), System.Drawing.Image)
        Me.MNULAST.Name = "MNULAST"
        Me.MNULAST.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.MNULAST.Size = New System.Drawing.Size(300, 36)
        Me.MNULAST.Text = "BOL"
        '
        'dgrpt
        '
        Me.dgrpt.AllowUserToAddRows = False
        Me.dgrpt.AllowUserToDeleteRows = False
        Me.dgrpt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrpt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrpt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrpt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgrpt.EnableHeadersVisualStyles = False
        Me.dgrpt.Location = New System.Drawing.Point(34, 364)
        Me.dgrpt.Name = "dgrpt"
        Me.dgrpt.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgrpt.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgrpt.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dgrpt.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgrpt.RowTemplate.Height = 24
        Me.dgrpt.Size = New System.Drawing.Size(1324, 505)
        Me.dgrpt.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblnm23)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbldistotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.dgrpt)
        Me.Panel1.Location = New System.Drawing.Point(30, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1392, 923)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 874)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 36)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Supervisor Name:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1099, 872)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 36)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Date"
        '
        'lblnm23
        '
        Me.lblnm23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnm23.AutoSize = True
        Me.lblnm23.BackColor = System.Drawing.Color.Transparent
        Me.lblnm23.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm23.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnm23.Location = New System.Drawing.Point(321, 873)
        Me.lblnm23.Name = "lblnm23"
        Me.lblnm23.Size = New System.Drawing.Size(101, 37)
        Me.lblnm23.TabIndex = 25
        Me.lblnm23.Text = "Name"
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldate.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldate.Location = New System.Drawing.Point(242, 200)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(1116, 78)
        Me.lbldate.TabIndex = 23
        Me.lbldate.Text = "Date"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 62)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TOTAL SALES:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldistotal
        '
        Me.lbldistotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldistotal.BackColor = System.Drawing.Color.Transparent
        Me.lbldistotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldistotal.Location = New System.Drawing.Point(215, 293)
        Me.lbldistotal.Name = "lbldistotal"
        Me.lbldistotal.Size = New System.Drawing.Size(790, 68)
        Me.lbldistotal.TabIndex = 7
        Me.lbldistotal.Text = "TOTAL SALES:"
        Me.lbldistotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1116, 78)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DAILY SALES REPORT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1116, 78)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MINAS BOARD-TAP STORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(34, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 234)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Timer5
        '
        '
        'Timer1
        '
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1450, 1004)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgrpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNU_SRCH As ToolStripMenuItem
    Friend WithEvents MNUDEL As ToolStripMenuItem
    Friend WithEvents MNUCNCL As ToolStripMenuItem
    Friend WithEvents mnuprntrpt As ToolStripMenuItem
    Friend WithEvents mnupulst As ToolStripMenuItem
    Friend WithEvents CrytalReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUCLOSE As ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUFIRST As ToolStripMenuItem
    Friend WithEvents MNYNEXT As ToolStripMenuItem
    Friend WithEvents MNUPREV As ToolStripMenuItem
    Friend WithEvents MNULAST As ToolStripMenuItem
    Friend WithEvents dgrpt As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbldistotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblnm23 As Label
    Friend WithEvents Timer1 As Timer
End Class
