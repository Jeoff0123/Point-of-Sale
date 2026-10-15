<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginfrm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_Un = New System.Windows.Forms.TextBox()
        Me.Txt_Pw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnuclose = New System.Windows.Forms.PictureBox()
        Me.mnulogin = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuclose0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnklblGuestMode = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnulogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 614)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Txt_Un
        '
        Me.Txt_Un.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Un.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Un.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Un.Location = New System.Drawing.Point(430, 242)
        Me.Txt_Un.Name = "Txt_Un"
        Me.Txt_Un.Size = New System.Drawing.Size(286, 37)
        Me.Txt_Un.TabIndex = 1
        '
        'Txt_Pw
        '
        Me.Txt_Pw.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Pw.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pw.Location = New System.Drawing.Point(430, 333)
        Me.Txt_Pw.Name = "Txt_Pw"
        Me.Txt_Pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pw.Size = New System.Drawing.Size(286, 37)
        Me.Txt_Pw.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Azure
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'mnuclose
        '
        Me.mnuclose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mnuclose.BackColor = System.Drawing.Color.Azure
        Me.mnuclose.BackgroundImage = CType(resources.GetObject("mnuclose.BackgroundImage"), System.Drawing.Image)
        Me.mnuclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mnuclose.Location = New System.Drawing.Point(586, 433)
        Me.mnuclose.Name = "mnuclose"
        Me.mnuclose.Size = New System.Drawing.Size(130, 145)
        Me.mnuclose.TabIndex = 6
        Me.mnuclose.TabStop = False
        '
        'mnulogin
        '
        Me.mnulogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mnulogin.BackColor = System.Drawing.Color.Azure
        Me.mnulogin.BackgroundImage = CType(resources.GetObject("mnulogin.BackgroundImage"), System.Drawing.Image)
        Me.mnulogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mnulogin.Location = New System.Drawing.Point(430, 433)
        Me.mnulogin.Name = "mnulogin"
        Me.mnulogin.Size = New System.Drawing.Size(133, 145)
        Me.mnulogin.TabIndex = 7
        Me.mnulogin.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuclose0})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'mnuclose0
        '
        Me.mnuclose0.Name = "mnuclose0"
        Me.mnuclose0.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuclose0.Size = New System.Drawing.Size(57, 24)
        Me.mnuclose0.Text = "Close"
        Me.mnuclose0.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lnklblGuestMode)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.mnulogin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Txt_Pw)
        Me.Panel1.Controls.Add(Me.Txt_Un)
        Me.Panel1.Controls.Add(Me.mnuclose)
        Me.Panel1.Location = New System.Drawing.Point(67, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 614)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Azure
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(414, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 65)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "WELCOME!"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnklblGuestMode
        '
        Me.lnklblGuestMode.AutoSize = True
        Me.lnklblGuestMode.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblGuestMode.Location = New System.Drawing.Point(501, 373)
        Me.lnklblGuestMode.Name = "lnklblGuestMode"
        Me.lnklblGuestMode.Size = New System.Drawing.Size(129, 27)
        Me.lnklblGuestMode.TabIndex = 9
        Me.lnklblGuestMode.TabStop = True
        Me.lnklblGuestMode.Text = "Guest Mode"
        '
        'Loginfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Loginfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnulogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_Un As TextBox
    Friend WithEvents Txt_Pw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mnuclose As PictureBox
    Friend WithEvents mnulogin As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuclose0 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lnklblGuestMode As LinkLabel
End Class
