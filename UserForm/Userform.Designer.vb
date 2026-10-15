<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUSAVE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUEDIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_SRCH = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUDEL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCNCL = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnupulst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnucr = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUFIRST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNYNEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPREV = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNULAST = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.gbIdUn = New System.Windows.Forms.GroupBox()
        Me.LBL_Txt = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_UserName = New System.Windows.Forms.TextBox()
        Me.Txt_Position = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbdg = New System.Windows.Forms.GroupBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.idpic = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbPw = New System.Windows.Forms.GroupBox()
        Me.cmb_txt1 = New System.Windows.Forms.ComboBox()
        Me.Txt_rpw = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Txt_pw = New System.Windows.Forms.TextBox()
        Me.Txt_Pr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bckgrnd = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.gbIdUn.SuspendLayout()
        Me.gbdg.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPw.SuspendLayout()
        Me.Bckgrnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUADD, Me.MNUSAVE, Me.MNUEDIT, Me.MNU_SRCH, Me.MNUDEL, Me.MNUCNCL, Me.PrintToolStripMenuItem, Me.MNUCLOSE})
        resources.ApplyResources(Me.MenuToolStripMenuItem, "MenuToolStripMenuItem")
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        '
        'MNUADD
        '
        resources.ApplyResources(Me.MNUADD, "MNUADD")
        Me.MNUADD.Name = "MNUADD"
        '
        'MNUSAVE
        '
        resources.ApplyResources(Me.MNUSAVE, "MNUSAVE")
        Me.MNUSAVE.Name = "MNUSAVE"
        '
        'MNUEDIT
        '
        resources.ApplyResources(Me.MNUEDIT, "MNUEDIT")
        Me.MNUEDIT.Name = "MNUEDIT"
        '
        'MNU_SRCH
        '
        resources.ApplyResources(Me.MNU_SRCH, "MNU_SRCH")
        Me.MNU_SRCH.Name = "MNU_SRCH"
        '
        'MNUDEL
        '
        resources.ApplyResources(Me.MNUDEL, "MNUDEL")
        Me.MNUDEL.Name = "MNUDEL"
        '
        'MNUCNCL
        '
        resources.ApplyResources(Me.MNUCNCL, "MNUCNCL")
        Me.MNUCNCL.Name = "MNUCNCL"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnupulst, Me.mnucr})
        resources.ApplyResources(Me.PrintToolStripMenuItem, "PrintToolStripMenuItem")
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        '
        'mnupulst
        '
        resources.ApplyResources(Me.mnupulst, "mnupulst")
        Me.mnupulst.Name = "mnupulst"
        '
        'mnucr
        '
        resources.ApplyResources(Me.mnucr, "mnucr")
        Me.mnucr.Name = "mnucr"
        '
        'MNUCLOSE
        '
        resources.ApplyResources(Me.MNUCLOSE, "MNUCLOSE")
        Me.MNUCLOSE.Name = "MNUCLOSE"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUFIRST, Me.MNYNEXT, Me.MNUPREV, Me.MNULAST})
        resources.ApplyResources(Me.NavigationToolStripMenuItem, "NavigationToolStripMenuItem")
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        '
        'MNUFIRST
        '
        resources.ApplyResources(Me.MNUFIRST, "MNUFIRST")
        Me.MNUFIRST.Name = "MNUFIRST"
        '
        'MNYNEXT
        '
        resources.ApplyResources(Me.MNYNEXT, "MNYNEXT")
        Me.MNYNEXT.Name = "MNYNEXT"
        '
        'MNUPREV
        '
        resources.ApplyResources(Me.MNUPREV, "MNUPREV")
        Me.MNUPREV.Name = "MNUPREV"
        '
        'MNULAST
        '
        resources.ApplyResources(Me.MNULAST, "MNULAST")
        Me.MNULAST.Name = "MNULAST"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'Timer3
        '
        '
        'gbIdUn
        '
        resources.ApplyResources(Me.gbIdUn, "gbIdUn")
        Me.gbIdUn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gbIdUn.Controls.Add(Me.LBL_Txt)
        Me.gbIdUn.Controls.Add(Me.Lbl)
        Me.gbIdUn.Controls.Add(Me.Label1)
        Me.gbIdUn.Controls.Add(Me.Label9)
        Me.gbIdUn.Controls.Add(Me.Txt_UserName)
        Me.gbIdUn.Controls.Add(Me.Txt_Position)
        Me.gbIdUn.Controls.Add(Me.Label3)
        Me.gbIdUn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbIdUn.Name = "gbIdUn"
        Me.gbIdUn.TabStop = False
        '
        'LBL_Txt
        '
        Me.LBL_Txt.BackColor = System.Drawing.Color.White
        Me.LBL_Txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.LBL_Txt, "LBL_Txt")
        Me.LBL_Txt.Name = "LBL_Txt"
        '
        'Lbl
        '
        Me.Lbl.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Lbl, "Lbl")
        Me.Lbl.Name = "Lbl"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Name = "Label9"
        '
        'Txt_UserName
        '
        resources.ApplyResources(Me.Txt_UserName, "Txt_UserName")
        Me.Txt_UserName.Name = "Txt_UserName"
        '
        'Txt_Position
        '
        resources.ApplyResources(Me.Txt_Position, "Txt_Position")
        Me.Txt_Position.Name = "Txt_Position"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'gbdg
        '
        resources.ApplyResources(Me.gbdg, "gbdg")
        Me.gbdg.BackColor = System.Drawing.Color.Transparent
        Me.gbdg.Controls.Add(Me.Dg)
        Me.gbdg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbdg.Name = "gbdg"
        Me.gbdg.TabStop = False
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.Dg, "Dg")
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Format = "0000"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dg.EnableHeadersVisualStyles = False
        Me.Dg.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dg.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = """JLM-""0000"
        Me.Dg.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dg.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Dg.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'idpic
        '
        resources.ApplyResources(Me.idpic, "idpic")
        Me.idpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.idpic.Name = "idpic"
        Me.idpic.TabStop = False
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'lbldate
        '
        resources.ApplyResources(Me.lbldate, "lbldate")
        Me.lbldate.Name = "lbldate"
        '
        'lblnm
        '
        resources.ApplyResources(Me.lblnm, "lblnm")
        Me.lblnm.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnm.Name = "lblnm"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'gbPw
        '
        resources.ApplyResources(Me.gbPw, "gbPw")
        Me.gbPw.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gbPw.Controls.Add(Me.cmb_txt1)
        Me.gbPw.Controls.Add(Me.Txt_rpw)
        Me.gbPw.Controls.Add(Me.Label4)
        Me.gbPw.Controls.Add(Me.label6)
        Me.gbPw.Controls.Add(Me.Txt_pw)
        Me.gbPw.Controls.Add(Me.Txt_Pr)
        Me.gbPw.Controls.Add(Me.Label5)
        Me.gbPw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbPw.Name = "gbPw"
        Me.gbPw.TabStop = False
        '
        'cmb_txt1
        '
        resources.ApplyResources(Me.cmb_txt1, "cmb_txt1")
        Me.cmb_txt1.FormattingEnabled = True
        Me.cmb_txt1.Items.AddRange(New Object() {resources.GetString("cmb_txt1.Items"), resources.GetString("cmb_txt1.Items1")})
        Me.cmb_txt1.Name = "cmb_txt1"
        '
        'Txt_rpw
        '
        resources.ApplyResources(Me.Txt_rpw, "Txt_rpw")
        Me.Txt_rpw.Name = "Txt_rpw"
        Me.Txt_rpw.UseSystemPasswordChar = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'label6
        '
        resources.ApplyResources(Me.label6, "label6")
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Name = "label6"
        '
        'Txt_pw
        '
        resources.ApplyResources(Me.Txt_pw, "Txt_pw")
        Me.Txt_pw.Name = "Txt_pw"
        Me.Txt_pw.UseSystemPasswordChar = True
        '
        'Txt_Pr
        '
        Me.Txt_Pr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        resources.ApplyResources(Me.Txt_Pr, "Txt_Pr")
        Me.Txt_Pr.Name = "Txt_Pr"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'Bckgrnd
        '
        resources.ApplyResources(Me.Bckgrnd, "Bckgrnd")
        Me.Bckgrnd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bckgrnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bckgrnd.Controls.Add(Me.gbPw)
        Me.Bckgrnd.Controls.Add(Me.Label10)
        Me.Bckgrnd.Controls.Add(Me.lblnm)
        Me.Bckgrnd.Controls.Add(Me.lbldate)
        Me.Bckgrnd.Controls.Add(Me.LinkLabel1)
        Me.Bckgrnd.Controls.Add(Me.idpic)
        Me.Bckgrnd.Controls.Add(Me.gbdg)
        Me.Bckgrnd.Controls.Add(Me.gbIdUn)
        Me.Bckgrnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bckgrnd.Name = "Bckgrnd"
        '
        'UsFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bckgrnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UsFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbIdUn.ResumeLayout(False)
        Me.gbIdUn.PerformLayout()
        Me.gbdg.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPw.ResumeLayout(False)
        Me.gbPw.PerformLayout()
        Me.Bckgrnd.ResumeLayout(False)
        Me.Bckgrnd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUCLOSE As ToolStripMenuItem
    Friend WithEvents MNUADD As ToolStripMenuItem
    Friend WithEvents MNUSAVE As ToolStripMenuItem
    Friend WithEvents MNUEDIT As ToolStripMenuItem
    Friend WithEvents MNU_SRCH As ToolStripMenuItem
    Friend WithEvents MNUDEL As ToolStripMenuItem
    Friend WithEvents MNUCNCL As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnupulst As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents gbIdUn As GroupBox
    Friend WithEvents LBL_Txt As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_UserName As TextBox
    Friend WithEvents Txt_Position As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbdg As GroupBox
    Friend WithEvents Dg As DataGridView
    Friend WithEvents idpic As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbldate As Label
    Friend WithEvents lblnm As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents gbPw As GroupBox
    Friend WithEvents cmb_txt1 As ComboBox
    Friend WithEvents Txt_rpw As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents Txt_pw As TextBox
    Friend WithEvents Txt_Pr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Bckgrnd As Panel
    Friend WithEvents mnucr As ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUFIRST As ToolStripMenuItem
    Friend WithEvents MNYNEXT As ToolStripMenuItem
    Friend WithEvents MNUPREV As ToolStripMenuItem
    Friend WithEvents MNULAST As ToolStripMenuItem
End Class
