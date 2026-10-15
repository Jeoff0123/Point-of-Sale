<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_cash = New System.Windows.Forms.Button()
        Me.Btn_stck = New System.Windows.Forms.Button()
        Me.Btn_User = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnm1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_report = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.mnuAccount})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1532, 44)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(159, 40)
        Me.CloseToolStripMenuItem.Text = "Log Out"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Timer2
        '
        '
        'btn_cash
        '
        Me.btn_cash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cash.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cash.BackgroundImage = CType(resources.GetObject("btn_cash.BackgroundImage"), System.Drawing.Image)
        Me.btn_cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cash.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cash.ForeColor = System.Drawing.Color.Transparent
        Me.btn_cash.Location = New System.Drawing.Point(732, 44)
        Me.btn_cash.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cash.Name = "btn_cash"
        Me.btn_cash.Size = New System.Drawing.Size(325, 551)
        Me.btn_cash.TabIndex = 2
        Me.btn_cash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_cash.UseVisualStyleBackColor = False
        '
        'Btn_stck
        '
        Me.Btn_stck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_stck.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_stck.BackgroundImage = CType(resources.GetObject("Btn_stck.BackgroundImage"), System.Drawing.Image)
        Me.Btn_stck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_stck.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_stck.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_stck.Location = New System.Drawing.Point(388, 44)
        Me.Btn_stck.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_stck.Name = "Btn_stck"
        Me.Btn_stck.Size = New System.Drawing.Size(325, 551)
        Me.Btn_stck.TabIndex = 1
        Me.Btn_stck.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_stck.UseVisualStyleBackColor = False
        '
        'Btn_User
        '
        Me.Btn_User.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_User.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_User.BackgroundImage = CType(resources.GetObject("Btn_User.BackgroundImage"), System.Drawing.Image)
        Me.Btn_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_User.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_User.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_User.Location = New System.Drawing.Point(43, 44)
        Me.Btn_User.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_User.Name = "Btn_User"
        Me.Btn_User.Size = New System.Drawing.Size(325, 551)
        Me.Btn_User.TabIndex = 0
        Me.Btn_User.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_User.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 627)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 36)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "User Name:"
        '
        'lblnm1
        '
        Me.lblnm1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblnm1.AutoSize = True
        Me.lblnm1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm1.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblnm1.Location = New System.Drawing.Point(219, 628)
        Me.lblnm1.Name = "lblnm1"
        Me.lblnm1.Size = New System.Drawing.Size(95, 36)
        Me.lblnm1.TabIndex = 7
        Me.lblnm1.Text = "Name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(618, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 36)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date"
        '
        'Btn_report
        '
        Me.Btn_report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_report.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_report.BackgroundImage = CType(resources.GetObject("Btn_report.BackgroundImage"), System.Drawing.Image)
        Me.Btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_report.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_report.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_report.Location = New System.Drawing.Point(1078, 44)
        Me.Btn_report.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(325, 551)
        Me.Btn_report.TabIndex = 3
        Me.Btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_report.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btn_report)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblnm1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Btn_User)
        Me.Panel1.Controls.Add(Me.Btn_stck)
        Me.Panel1.Controls.Add(Me.btn_cash)
        Me.Panel1.Location = New System.Drawing.Point(41, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1448, 682)
        Me.Panel1.TabIndex = 9
        '
        'mnuAccount
        '
        Me.mnuAccount.Image = CType(resources.GetObject("mnuAccount.Image"), System.Drawing.Image)
        Me.mnuAccount.Name = "mnuAccount"
        Me.mnuAccount.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAccount.Size = New System.Drawing.Size(147, 40)
        Me.mnuAccount.Text = "Acount"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1532, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btn_cash As Button
    Friend WithEvents Btn_stck As Button
    Friend WithEvents Btn_User As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblnm1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_report As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnuAccount As ToolStripMenuItem
End Class
