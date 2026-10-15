<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crystal_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crystal_Report))
        Me.MNUStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalesRpt = New System.Windows.Forms.Button()
        Me.BtnStckList = New System.Windows.Forms.Button()
        Me.BtnUserList = New System.Windows.Forms.Button()
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
        Me.MNUStrip1.Size = New System.Drawing.Size(596, 39)
        Me.MNUStrip1.TabIndex = 27
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
        Me.MNUCLOSE4.Size = New System.Drawing.Size(247, 36)
        Me.MNUCLOSE4.Text = "Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 31)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Sales Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 31)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Stock List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "User List"
        '
        'BtnSalesRpt
        '
        Me.BtnSalesRpt.BackgroundImage = CType(resources.GetObject("BtnSalesRpt.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalesRpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSalesRpt.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalesRpt.Location = New System.Drawing.Point(404, 23)
        Me.BtnSalesRpt.Name = "BtnSalesRpt"
        Me.BtnSalesRpt.Size = New System.Drawing.Size(161, 209)
        Me.BtnSalesRpt.TabIndex = 30
        Me.BtnSalesRpt.UseVisualStyleBackColor = True
        '
        'BtnStckList
        '
        Me.BtnStckList.BackgroundImage = CType(resources.GetObject("BtnStckList.BackgroundImage"), System.Drawing.Image)
        Me.BtnStckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnStckList.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStckList.Location = New System.Drawing.Point(213, 23)
        Me.BtnStckList.Name = "BtnStckList"
        Me.BtnStckList.Size = New System.Drawing.Size(161, 209)
        Me.BtnStckList.TabIndex = 29
        Me.BtnStckList.UseVisualStyleBackColor = True
        '
        'BtnUserList
        '
        Me.BtnUserList.BackgroundImage = CType(resources.GetObject("BtnUserList.BackgroundImage"), System.Drawing.Image)
        Me.BtnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUserList.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUserList.Location = New System.Drawing.Point(29, 23)
        Me.BtnUserList.Name = "BtnUserList"
        Me.BtnUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUserList.Size = New System.Drawing.Size(161, 209)
        Me.BtnUserList.TabIndex = 28
        Me.BtnUserList.UseVisualStyleBackColor = True
        '
        'Crystal_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(596, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.MNUStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalesRpt)
        Me.Controls.Add(Me.BtnStckList)
        Me.Controls.Add(Me.BtnUserList)
        Me.Name = "Crystal_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crystal_Report"
        Me.MNUStrip1.ResumeLayout(False)
        Me.MNUStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MNUStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUCLOSE4 As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalesRpt As Button
    Friend WithEvents BtnStckList As Button
    Friend WithEvents BtnUserList As Button
End Class
