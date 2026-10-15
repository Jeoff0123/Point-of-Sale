<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export_to_Excel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Export_to_Excel))
        Me.MNUStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUserList = New System.Windows.Forms.Button()
        Me.BtnStckList = New System.Windows.Forms.Button()
        Me.BtnSalesRpt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MNUStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MNUStrip1
        '
        Me.MNUStrip1.BackColor = System.Drawing.Color.Azure
        Me.MNUStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNUStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MNUStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MNUStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MNUStrip1.Name = "MNUStrip1"
        Me.MNUStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MNUStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MNUStrip1.Size = New System.Drawing.Size(573, 39)
        Me.MNUStrip1.TabIndex = 20
        Me.MNUStrip1.Text = "MenuStrip1"
        Me.MNUStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUCLOSE4})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(89, 35)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'MNUCLOSE4
        '
        Me.MNUCLOSE4.Image = CType(resources.GetObject("MNUCLOSE4.Image"), System.Drawing.Image)
        Me.MNUCLOSE4.Name = "MNUCLOSE4"
        Me.MNUCLOSE4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MNUCLOSE4.Size = New System.Drawing.Size(251, 36)
        Me.MNUCLOSE4.Text = "Close"
        '
        'BtnUserList
        '
        Me.BtnUserList.BackgroundImage = CType(resources.GetObject("BtnUserList.BackgroundImage"), System.Drawing.Image)
        Me.BtnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUserList.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUserList.Location = New System.Drawing.Point(12, 37)
        Me.BtnUserList.Name = "BtnUserList"
        Me.BtnUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUserList.Size = New System.Drawing.Size(161, 209)
        Me.BtnUserList.TabIndex = 21
        Me.BtnUserList.UseVisualStyleBackColor = True
        '
        'BtnStckList
        '
        Me.BtnStckList.BackgroundImage = CType(resources.GetObject("BtnStckList.BackgroundImage"), System.Drawing.Image)
        Me.BtnStckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnStckList.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStckList.Location = New System.Drawing.Point(196, 37)
        Me.BtnStckList.Name = "BtnStckList"
        Me.BtnStckList.Size = New System.Drawing.Size(161, 209)
        Me.BtnStckList.TabIndex = 22
        Me.BtnStckList.UseVisualStyleBackColor = True
        '
        'BtnSalesRpt
        '
        Me.BtnSalesRpt.BackgroundImage = CType(resources.GetObject("BtnSalesRpt.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalesRpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSalesRpt.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalesRpt.Location = New System.Drawing.Point(387, 37)
        Me.BtnSalesRpt.Name = "BtnSalesRpt"
        Me.BtnSalesRpt.Size = New System.Drawing.Size(161, 209)
        Me.BtnSalesRpt.TabIndex = 23
        Me.BtnSalesRpt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "User List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 31)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Stock List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(391, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 31)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Sales Report"
        '
        'Export_to_Excel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(583, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalesRpt)
        Me.Controls.Add(Me.BtnStckList)
        Me.Controls.Add(Me.BtnUserList)
        Me.Controls.Add(Me.MNUStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Export_to_Excel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Excel"
        Me.MNUStrip1.ResumeLayout(False)
        Me.MNUStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MNUStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUCLOSE4 As ToolStripMenuItem
    Friend WithEvents BtnUserList As Button
    Friend WithEvents BtnStckList As Button
    Friend WithEvents BtnSalesRpt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
