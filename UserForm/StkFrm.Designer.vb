<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StkFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StkFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bckgrnd2 = New System.Windows.Forms.Panel()
        Me.lblnm3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbtxt = New System.Windows.Forms.GroupBox()
        Me.Txt_ItemID = New System.Windows.Forms.TextBox()
        Me.Txt_Crit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_SP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_BPR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Qnty = New System.Windows.Forms.TextBox()
        Me.Txt_PrNm = New System.Windows.Forms.TextBox()
        Me.Txt_Dsrp = New System.Windows.Forms.TextBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lnklbl2 = New System.Windows.Forms.LinkLabel()
        Me.idpic2 = New System.Windows.Forms.PictureBox()
        Me.gbdg2 = New System.Windows.Forms.GroupBox()
        Me.Dg2 = New System.Windows.Forms.DataGridView()
        Me.MNUStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUADD2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUSAVE2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUEDIT2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_SRCH2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUDEL2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCNCL2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPRNT2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPITLST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCrystal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUFIRST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNYNEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPREV = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNULAST = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD2 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Bckgrnd2.SuspendLayout()
        Me.gbtxt.SuspendLayout()
        CType(Me.idpic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdg2.SuspendLayout()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNUStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bckgrnd2
        '
        Me.Bckgrnd2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bckgrnd2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Bckgrnd2.BackColor = System.Drawing.Color.Azure
        Me.Bckgrnd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bckgrnd2.Controls.Add(Me.lblnm3)
        Me.Bckgrnd2.Controls.Add(Me.Label8)
        Me.Bckgrnd2.Controls.Add(Me.gbtxt)
        Me.Bckgrnd2.Controls.Add(Me.lbltime)
        Me.Bckgrnd2.Controls.Add(Me.lnklbl2)
        Me.Bckgrnd2.Controls.Add(Me.idpic2)
        Me.Bckgrnd2.Controls.Add(Me.gbdg2)
        Me.Bckgrnd2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bckgrnd2.Location = New System.Drawing.Point(71, 86)
        Me.Bckgrnd2.Margin = New System.Windows.Forms.Padding(4)
        Me.Bckgrnd2.Name = "Bckgrnd2"
        Me.Bckgrnd2.Size = New System.Drawing.Size(1489, 782)
        Me.Bckgrnd2.TabIndex = 15
        '
        'lblnm3
        '
        Me.lblnm3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnm3.AutoSize = True
        Me.lblnm3.BackColor = System.Drawing.Color.Transparent
        Me.lblnm3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm3.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnm3.Location = New System.Drawing.Point(307, 733)
        Me.lblnm3.Name = "lblnm3"
        Me.lblnm3.Size = New System.Drawing.Size(83, 31)
        Me.lblnm3.TabIndex = 18
        Me.lblnm3.Text = "Name"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 733)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Stock Clerk Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'gbtxt
        '
        Me.gbtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbtxt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbtxt.BackColor = System.Drawing.Color.SkyBlue
        Me.gbtxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbtxt.Controls.Add(Me.Txt_ItemID)
        Me.gbtxt.Controls.Add(Me.Txt_Crit)
        Me.gbtxt.Controls.Add(Me.Label7)
        Me.gbtxt.Controls.Add(Me.Txt_SP)
        Me.gbtxt.Controls.Add(Me.Label6)
        Me.gbtxt.Controls.Add(Me.Txt_BPR)
        Me.gbtxt.Controls.Add(Me.Label5)
        Me.gbtxt.Controls.Add(Me.Label4)
        Me.gbtxt.Controls.Add(Me.Label3)
        Me.gbtxt.Controls.Add(Me.Label2)
        Me.gbtxt.Controls.Add(Me.Label1)
        Me.gbtxt.Controls.Add(Me.Txt_Qnty)
        Me.gbtxt.Controls.Add(Me.Txt_PrNm)
        Me.gbtxt.Controls.Add(Me.Txt_Dsrp)
        Me.gbtxt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbtxt.Location = New System.Drawing.Point(10, 19)
        Me.gbtxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbtxt.Name = "gbtxt"
        Me.gbtxt.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbtxt.Size = New System.Drawing.Size(1062, 281)
        Me.gbtxt.TabIndex = 25
        Me.gbtxt.TabStop = False
        '
        'Txt_ItemID
        '
        Me.Txt_ItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ItemID.Location = New System.Drawing.Point(253, 22)
        Me.Txt_ItemID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_ItemID.Name = "Txt_ItemID"
        Me.Txt_ItemID.Size = New System.Drawing.Size(285, 38)
        Me.Txt_ItemID.TabIndex = 0
        '
        'Txt_Crit
        '
        Me.Txt_Crit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Crit.Location = New System.Drawing.Point(741, 187)
        Me.Txt_Crit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Crit.Name = "Txt_Crit"
        Me.Txt_Crit.Size = New System.Drawing.Size(302, 38)
        Me.Txt_Crit.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(545, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 32)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Critical :"
        '
        'Txt_SP
        '
        Me.Txt_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SP.Location = New System.Drawing.Point(741, 124)
        Me.Txt_SP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_SP.Name = "Txt_SP"
        Me.Txt_SP.Size = New System.Drawing.Size(302, 38)
        Me.Txt_SP.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(545, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 32)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Selling Price :"
        '
        'Txt_BPR
        '
        Me.Txt_BPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BPR.Location = New System.Drawing.Point(741, 58)
        Me.Txt_BPR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_BPR.Name = "Txt_BPR"
        Me.Txt_BPR.Size = New System.Drawing.Size(302, 38)
        Me.Txt_BPR.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 32)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Item Description :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 32)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ItemID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(545, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 32)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Buying Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 32)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Quantity:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Item Name :"
        '
        'Txt_Qnty
        '
        Me.Txt_Qnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Qnty.Location = New System.Drawing.Point(253, 216)
        Me.Txt_Qnty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Qnty.Name = "Txt_Qnty"
        Me.Txt_Qnty.Size = New System.Drawing.Size(285, 38)
        Me.Txt_Qnty.TabIndex = 24
        '
        'Txt_PrNm
        '
        Me.Txt_PrNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PrNm.Location = New System.Drawing.Point(253, 81)
        Me.Txt_PrNm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_PrNm.Name = "Txt_PrNm"
        Me.Txt_PrNm.Size = New System.Drawing.Size(285, 38)
        Me.Txt_PrNm.TabIndex = 22
        '
        'Txt_Dsrp
        '
        Me.Txt_Dsrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Dsrp.Location = New System.Drawing.Point(253, 147)
        Me.Txt_Dsrp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Dsrp.MaxLength = 1000000
        Me.Txt_Dsrp.Name = "Txt_Dsrp"
        Me.Txt_Dsrp.Size = New System.Drawing.Size(285, 38)
        Me.Txt_Dsrp.TabIndex = 23
        Me.Txt_Dsrp.WordWrap = False
        '
        'lbltime
        '
        Me.lbltime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(1338, 733)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(68, 31)
        Me.lbltime.TabIndex = 17
        Me.lbltime.Text = "Date"
        '
        'lnklbl2
        '
        Me.lnklbl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnklbl2.AutoSize = True
        Me.lnklbl2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl2.Location = New System.Drawing.Point(1189, 304)
        Me.lnklbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnklbl2.Name = "lnklbl2"
        Me.lnklbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lnklbl2.Size = New System.Drawing.Size(175, 31)
        Me.lnklbl2.TabIndex = 16
        Me.lnklbl2.TabStop = True
        Me.lnklbl2.Text = "Browse Image"
        '
        'idpic2
        '
        Me.idpic2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.idpic2.BackgroundImage = CType(resources.GetObject("idpic2.BackgroundImage"), System.Drawing.Image)
        Me.idpic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.idpic2.ImageLocation = ""
        Me.idpic2.Location = New System.Drawing.Point(1079, 4)
        Me.idpic2.Margin = New System.Windows.Forms.Padding(4)
        Me.idpic2.Name = "idpic2"
        Me.idpic2.Size = New System.Drawing.Size(393, 296)
        Me.idpic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpic2.TabIndex = 15
        Me.idpic2.TabStop = False
        '
        'gbdg2
        '
        Me.gbdg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdg2.BackColor = System.Drawing.Color.White
        Me.gbdg2.Controls.Add(Me.Dg2)
        Me.gbdg2.Location = New System.Drawing.Point(39, 342)
        Me.gbdg2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbdg2.Name = "gbdg2"
        Me.gbdg2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbdg2.Size = New System.Drawing.Size(1412, 389)
        Me.gbdg2.TabIndex = 21
        Me.gbdg2.TabStop = False
        '
        'Dg2
        '
        Me.Dg2.AllowUserToAddRows = False
        Me.Dg2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Dg2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dg2.BackgroundColor = System.Drawing.Color.White
        Me.Dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.Dg2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dg2.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dg2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg2.EnableHeadersVisualStyles = False
        Me.Dg2.GridColor = System.Drawing.Color.DimGray
        Me.Dg2.Location = New System.Drawing.Point(3, 17)
        Me.Dg2.Margin = New System.Windows.Forms.Padding(4)
        Me.Dg2.Name = "Dg2"
        Me.Dg2.ReadOnly = True
        Me.Dg2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.Dg2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dg2.RowHeadersVisible = False
        Me.Dg2.RowHeadersWidth = 30
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Dg2.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dg2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Dg2.RowTemplate.DividerHeight = 2
        Me.Dg2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg2.Size = New System.Drawing.Size(1406, 370)
        Me.Dg2.TabIndex = 11
        '
        'MNUStrip1
        '
        Me.MNUStrip1.BackColor = System.Drawing.Color.Azure
        Me.MNUStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNUStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MNUStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MNUStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MNUStrip1.Name = "MNUStrip1"
        Me.MNUStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MNUStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MNUStrip1.Size = New System.Drawing.Size(1624, 39)
        Me.MNUStrip1.TabIndex = 16
        Me.MNUStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUADD2, Me.MNUSAVE2, Me.MNUEDIT2, Me.MNU_SRCH2, Me.MNUDEL2, Me.MNUCNCL2, Me.MNUPRNT2, Me.MNUCLOSE2})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(89, 35)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'MNUADD2
        '
        Me.MNUADD2.Image = CType(resources.GetObject("MNUADD2.Image"), System.Drawing.Image)
        Me.MNUADD2.Name = "MNUADD2"
        Me.MNUADD2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MNUADD2.Size = New System.Drawing.Size(308, 36)
        Me.MNUADD2.Text = "New Item"
        '
        'MNUSAVE2
        '
        Me.MNUSAVE2.Image = CType(resources.GetObject("MNUSAVE2.Image"), System.Drawing.Image)
        Me.MNUSAVE2.Name = "MNUSAVE2"
        Me.MNUSAVE2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MNUSAVE2.Size = New System.Drawing.Size(308, 36)
        Me.MNUSAVE2.Text = "Save"
        '
        'MNUEDIT2
        '
        Me.MNUEDIT2.Image = CType(resources.GetObject("MNUEDIT2.Image"), System.Drawing.Image)
        Me.MNUEDIT2.Name = "MNUEDIT2"
        Me.MNUEDIT2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.MNUEDIT2.Size = New System.Drawing.Size(308, 36)
        Me.MNUEDIT2.Text = "Edit"
        '
        'MNU_SRCH2
        '
        Me.MNU_SRCH2.Image = CType(resources.GetObject("MNU_SRCH2.Image"), System.Drawing.Image)
        Me.MNU_SRCH2.Name = "MNU_SRCH2"
        Me.MNU_SRCH2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MNU_SRCH2.Size = New System.Drawing.Size(308, 36)
        Me.MNU_SRCH2.Text = "Search"
        '
        'MNUDEL2
        '
        Me.MNUDEL2.Image = CType(resources.GetObject("MNUDEL2.Image"), System.Drawing.Image)
        Me.MNUDEL2.Name = "MNUDEL2"
        Me.MNUDEL2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.MNUDEL2.Size = New System.Drawing.Size(308, 36)
        Me.MNUDEL2.Text = "Delete"
        '
        'MNUCNCL2
        '
        Me.MNUCNCL2.Image = CType(resources.GetObject("MNUCNCL2.Image"), System.Drawing.Image)
        Me.MNUCNCL2.Name = "MNUCNCL2"
        Me.MNUCNCL2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MNUCNCL2.Size = New System.Drawing.Size(308, 36)
        Me.MNUCNCL2.Text = "Cancel"
        '
        'MNUPRNT2
        '
        Me.MNUPRNT2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUPITLST, Me.MNUCrystal})
        Me.MNUPRNT2.Image = CType(resources.GetObject("MNUPRNT2.Image"), System.Drawing.Image)
        Me.MNUPRNT2.Name = "MNUPRNT2"
        Me.MNUPRNT2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MNUPRNT2.ShowShortcutKeys = False
        Me.MNUPRNT2.Size = New System.Drawing.Size(308, 36)
        Me.MNUPRNT2.Text = "Print"
        '
        'MNUPITLST
        '
        Me.MNUPITLST.Image = CType(resources.GetObject("MNUPITLST.Image"), System.Drawing.Image)
        Me.MNUPITLST.Name = "MNUPITLST"
        Me.MNUPITLST.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MNUPITLST.Size = New System.Drawing.Size(414, 36)
        Me.MNUPITLST.Text = "Excel"
        '
        'MNUCrystal
        '
        Me.MNUCrystal.Image = CType(resources.GetObject("MNUCrystal.Image"), System.Drawing.Image)
        Me.MNUCrystal.Name = "MNUCrystal"
        Me.MNUCrystal.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MNUCrystal.Size = New System.Drawing.Size(414, 36)
        Me.MNUCrystal.Text = "Crystal Report"
        '
        'MNUCLOSE2
        '
        Me.MNUCLOSE2.Image = CType(resources.GetObject("MNUCLOSE2.Image"), System.Drawing.Image)
        Me.MNUCLOSE2.Name = "MNUCLOSE2"
        Me.MNUCLOSE2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MNUCLOSE2.Size = New System.Drawing.Size(308, 36)
        Me.MNUCLOSE2.Text = "Close"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUFIRST, Me.MNYNEXT, Me.MNUPREV, Me.MNULAST})
        Me.NavigationToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationToolStripMenuItem.Image = CType(resources.GetObject("NavigationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(175, 35)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'MNUFIRST
        '
        Me.MNUFIRST.Image = CType(resources.GetObject("MNUFIRST.Image"), System.Drawing.Image)
        Me.MNUFIRST.Name = "MNUFIRST"
        Me.MNUFIRST.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.MNUFIRST.Size = New System.Drawing.Size(280, 36)
        Me.MNUFIRST.Text = "BOF"
        '
        'MNYNEXT
        '
        Me.MNYNEXT.Image = CType(resources.GetObject("MNYNEXT.Image"), System.Drawing.Image)
        Me.MNYNEXT.Name = "MNYNEXT"
        Me.MNYNEXT.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.MNYNEXT.Size = New System.Drawing.Size(280, 36)
        Me.MNYNEXT.Text = "Next"
        '
        'MNUPREV
        '
        Me.MNUPREV.Image = CType(resources.GetObject("MNUPREV.Image"), System.Drawing.Image)
        Me.MNUPREV.Name = "MNUPREV"
        Me.MNUPREV.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.MNUPREV.Size = New System.Drawing.Size(280, 36)
        Me.MNUPREV.Text = "Prev"
        '
        'MNULAST
        '
        Me.MNULAST.Image = CType(resources.GetObject("MNULAST.Image"), System.Drawing.Image)
        Me.MNULAST.Name = "MNULAST"
        Me.MNULAST.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.MNULAST.Size = New System.Drawing.Size(280, 36)
        Me.MNULAST.Text = "BOL"
        '
        'OFD2
        '
        Me.OFD2.FileName = "OFD2"
        '
        'Timer4
        '
        '
        'StkFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1624, 918)
        Me.ControlBox = False
        Me.Controls.Add(Me.MNUStrip1)
        Me.Controls.Add(Me.Bckgrnd2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StkFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Bckgrnd2.ResumeLayout(False)
        Me.Bckgrnd2.PerformLayout()
        Me.gbtxt.ResumeLayout(False)
        Me.gbtxt.PerformLayout()
        CType(Me.idpic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdg2.ResumeLayout(False)
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNUStrip1.ResumeLayout(False)
        Me.MNUStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bckgrnd2 As Panel
    Friend WithEvents lnklbl2 As LinkLabel
    Friend WithEvents idpic2 As PictureBox
    Friend WithEvents gbdg2 As GroupBox
    Friend WithEvents Dg2 As DataGridView
    Friend WithEvents Txt_Qnty As TextBox
    Friend WithEvents Txt_Dsrp As TextBox
    Friend WithEvents Txt_PrNm As TextBox
    Friend WithEvents MNUStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUADD2 As ToolStripMenuItem
    Friend WithEvents MNUSAVE2 As ToolStripMenuItem
    Friend WithEvents MNUEDIT2 As ToolStripMenuItem
    Friend WithEvents MNU_SRCH2 As ToolStripMenuItem
    Friend WithEvents MNUDEL2 As ToolStripMenuItem
    Friend WithEvents MNUCNCL2 As ToolStripMenuItem
    Friend WithEvents MNUPRNT2 As ToolStripMenuItem
    Friend WithEvents MNUCLOSE2 As ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUFIRST As ToolStripMenuItem
    Friend WithEvents MNYNEXT As ToolStripMenuItem
    Friend WithEvents MNUPREV As ToolStripMenuItem
    Friend WithEvents MNULAST As ToolStripMenuItem
    Friend WithEvents gbtxt As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_BPR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Crit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_SP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OFD2 As OpenFileDialog
    Friend WithEvents Txt_ItemID As TextBox
    Friend WithEvents MNUPITLST As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents lblnm3 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents MNUCrystal As ToolStripMenuItem
End Class
