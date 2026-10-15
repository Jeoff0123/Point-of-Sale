<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_ItemName = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.dgcash = New System.Windows.Forms.DataGridView()
        Me.gbpay = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbldisplay1 = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.txtIid = New System.Windows.Forms.Label()
        Me.Txtamt = New System.Windows.Forms.TextBox()
        Me.Txtsp = New System.Windows.Forms.Label()
        Me.gbtrans = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtItId = New System.Windows.Forms.TextBox()
        Me.Txtqnty = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.TxtQnt = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnupulstcash = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CachedCrystalReport11 = New UserForm.CachedCrystalReport1()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgcash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpay.SuspendLayout()
        Me.gbtrans.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.lblnm)
        Me.Panel1.Controls.Add(Me.dgcash)
        Me.Panel1.Controls.Add(Me.gbpay)
        Me.Panel1.Controls.Add(Me.gbtrans)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(28, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1522, 1073)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1166, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(358, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(802, 52)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "NAGBUNGA, CASTILLEJOS, ZAMBALES"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(468, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(570, 52)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MINAS BOARD-TAP STORE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(197, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 1014)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 36)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cashier Name:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 1015)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Azure
        Me.GroupBox2.Controls.Add(Me.lbl_ItemName)
        Me.GroupBox2.Controls.Add(Me.lbldesc)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(26, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(947, 318)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ITEM DESCRIPTION"
        '
        'lbl_ItemName
        '
        Me.lbl_ItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ItemName.BackColor = System.Drawing.Color.White
        Me.lbl_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ItemName.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemName.Location = New System.Drawing.Point(6, 57)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(935, 95)
        Me.lbl_ItemName.TabIndex = 9
        Me.lbl_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldesc
        '
        Me.lbldesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldesc.BackColor = System.Drawing.Color.White
        Me.lbldesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldesc.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(6, 162)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(935, 153)
        Me.lbldesc.TabIndex = 8
        '
        'lblnm
        '
        Me.lblnm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnm.AutoSize = True
        Me.lblnm.BackColor = System.Drawing.Color.Transparent
        Me.lblnm.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnm.Location = New System.Drawing.Point(297, 1015)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.Size = New System.Drawing.Size(101, 37)
        Me.lblnm.TabIndex = 4
        Me.lblnm.Text = "Name"
        '
        'dgcash
        '
        Me.dgcash.AllowUserToAddRows = False
        Me.dgcash.AllowUserToDeleteRows = False
        Me.dgcash.AllowUserToResizeColumns = False
        Me.dgcash.AllowUserToResizeRows = False
        Me.dgcash.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgcash.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgcash.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgcash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgcash.ColumnHeadersHeight = 36
        Me.dgcash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgcash.EnableHeadersVisualStyles = False
        Me.dgcash.Location = New System.Drawing.Point(26, 390)
        Me.dgcash.Name = "dgcash"
        Me.dgcash.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgcash.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgcash.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgcash.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgcash.RowTemplate.Height = 24
        Me.dgcash.Size = New System.Drawing.Size(941, 586)
        Me.dgcash.TabIndex = 4
        '
        'gbpay
        '
        Me.gbpay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbpay.BackColor = System.Drawing.Color.Azure
        Me.gbpay.Controls.Add(Me.Label9)
        Me.gbpay.Controls.Add(Me.Label8)
        Me.gbpay.Controls.Add(Me.Label7)
        Me.gbpay.Controls.Add(Me.Label11)
        Me.gbpay.Controls.Add(Me.lbldisplay1)
        Me.gbpay.Controls.Add(Me.lblchange)
        Me.gbpay.Controls.Add(Me.txtIid)
        Me.gbpay.Controls.Add(Me.Txtamt)
        Me.gbpay.Controls.Add(Me.Txtsp)
        Me.gbpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbpay.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpay.Location = New System.Drawing.Point(973, 510)
        Me.gbpay.Name = "gbpay"
        Me.gbpay.Size = New System.Drawing.Size(516, 466)
        Me.gbpay.TabIndex = 2
        Me.gbpay.TabStop = False
        Me.gbpay.Text = "PAYMENT:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(64, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 57)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "₱"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 57)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "₱"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(64, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 57)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "₱"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 52)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Change:"
        '
        'lbldisplay1
        '
        Me.lbldisplay1.BackColor = System.Drawing.Color.White
        Me.lbldisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldisplay1.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisplay1.Location = New System.Drawing.Point(51, 123)
        Me.lbldisplay1.Name = "lbldisplay1"
        Me.lbldisplay1.Size = New System.Drawing.Size(424, 71)
        Me.lbldisplay1.TabIndex = 7
        Me.lbldisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblchange
        '
        Me.lblchange.BackColor = System.Drawing.Color.White
        Me.lblchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblchange.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.Red
        Me.lblchange.Location = New System.Drawing.Point(51, 363)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(424, 67)
        Me.lblchange.TabIndex = 11
        Me.lblchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIid
        '
        Me.txtIid.AutoSize = True
        Me.txtIid.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIid.Location = New System.Drawing.Point(10, 66)
        Me.txtIid.Name = "txtIid"
        Me.txtIid.Size = New System.Drawing.Size(161, 52)
        Me.txtIid.TabIndex = 0
        Me.txtIid.Text = "TOTAL:"
        '
        'Txtamt
        '
        Me.Txtamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtamt.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtamt.ForeColor = System.Drawing.Color.Green
        Me.Txtamt.Location = New System.Drawing.Point(51, 238)
        Me.Txtamt.Name = "Txtamt"
        Me.Txtamt.Size = New System.Drawing.Size(424, 67)
        Me.Txtamt.TabIndex = 6
        Me.Txtamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtsp
        '
        Me.Txtsp.AutoSize = True
        Me.Txtsp.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsp.Location = New System.Drawing.Point(10, 182)
        Me.Txtsp.Name = "Txtsp"
        Me.Txtsp.Size = New System.Drawing.Size(188, 52)
        Me.Txtsp.TabIndex = 1
        Me.Txtsp.Text = "Amount:"
        '
        'gbtrans
        '
        Me.gbtrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbtrans.BackColor = System.Drawing.Color.Azure
        Me.gbtrans.Controls.Add(Me.Label6)
        Me.gbtrans.Controls.Add(Me.Label1)
        Me.gbtrans.Controls.Add(Me.Label2)
        Me.gbtrans.Controls.Add(Me.TxtItId)
        Me.gbtrans.Controls.Add(Me.Txtqnty)
        Me.gbtrans.Controls.Add(Me.lbltotal)
        Me.gbtrans.Controls.Add(Me.TxtQnt)
        Me.gbtrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbtrans.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtrans.Location = New System.Drawing.Point(973, 166)
        Me.gbtrans.Name = "gbtrans"
        Me.gbtrans.Size = New System.Drawing.Size(516, 458)
        Me.gbtrans.TabIndex = 1
        Me.gbtrans.TabStop = False
        Me.gbtrans.Text = "TRANSACTION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 57)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "₱"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 52)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 52)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Price:"
        '
        'TxtItId
        '
        Me.TxtItId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItId.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItId.Location = New System.Drawing.Point(51, 113)
        Me.TxtItId.Name = "TxtItId"
        Me.TxtItId.Size = New System.Drawing.Size(424, 70)
        Me.TxtItId.TabIndex = 4
        Me.TxtItId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtqnty
        '
        Me.Txtqnty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtqnty.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtqnty.Location = New System.Drawing.Point(51, 237)
        Me.Txtqnty.Name = "Txtqnty"
        Me.Txtqnty.Size = New System.Drawing.Size(424, 70)
        Me.Txtqnty.TabIndex = 5
        Me.Txtqnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.White
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltotal.Location = New System.Drawing.Point(51, 367)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(424, 72)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtQnt
        '
        Me.TxtQnt.AutoSize = True
        Me.TxtQnt.BackColor = System.Drawing.Color.Transparent
        Me.TxtQnt.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQnt.Location = New System.Drawing.Point(10, 182)
        Me.TxtQnt.Name = "TxtQnt"
        Me.TxtQnt.Size = New System.Drawing.Size(200, 52)
        Me.TxtQnt.TabIndex = 2
        Me.TxtQnt.Text = "Quantity:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1581, 33)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.MNUCLOSE3, Me.DeleteToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnupulstcash, Me.CrystalReportsToolStripMenuItem})
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'mnupulstcash
        '
        Me.mnupulstcash.Image = CType(resources.GetObject("mnupulstcash.Image"), System.Drawing.Image)
        Me.mnupulstcash.Name = "mnupulstcash"
        Me.mnupulstcash.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnupulstcash.Size = New System.Drawing.Size(354, 30)
        Me.mnupulstcash.Text = "Excel"
        '
        'CrystalReportsToolStripMenuItem
        '
        Me.CrystalReportsToolStripMenuItem.Name = "CrystalReportsToolStripMenuItem"
        Me.CrystalReportsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.CrystalReportsToolStripMenuItem.Size = New System.Drawing.Size(354, 30)
        Me.CrystalReportsToolStripMenuItem.Text = "Crystal Reports"
        '
        'MNUCLOSE3
        '
        Me.MNUCLOSE3.Image = CType(resources.GetObject("MNUCLOSE3.Image"), System.Drawing.Image)
        Me.MNUCLOSE3.Name = "MNUCLOSE3"
        Me.MNUCLOSE3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MNUCLOSE3.Size = New System.Drawing.Size(230, 30)
        Me.MNUCLOSE3.Text = "Close"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NextToolStripMenuItem, Me.PrevToolStripMenuItem})
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(116, 29)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(226, 28)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'PrevToolStripMenuItem
        '
        Me.PrevToolStripMenuItem.Name = "PrevToolStripMenuItem"
        Me.PrevToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.PrevToolStripMenuItem.Size = New System.Drawing.Size(226, 28)
        Me.PrevToolStripMenuItem.Text = "Prev"
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1581, 1100)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgcash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpay.ResumeLayout(False)
        Me.gbpay.PerformLayout()
        Me.gbtrans.ResumeLayout(False)
        Me.gbtrans.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents gbpay As GroupBox
    Friend WithEvents lbldisplay1 As Label
    Friend WithEvents txtIid As Label
    Friend WithEvents Txtamt As TextBox
    Friend WithEvents Txtsp As Label
    Friend WithEvents gbtrans As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtItId As TextBox
    Friend WithEvents Txtqnty As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents TxtQnt As Label
    Friend WithEvents lbldesc As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgcash As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents lblnm As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnupulstcash As ToolStripMenuItem
    Friend WithEvents MNUCLOSE3 As ToolStripMenuItem
    Friend WithEvents lbl_ItemName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrevToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CachedCrystalReport11 As CachedCrystalReport1
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrystalReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblchange As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
