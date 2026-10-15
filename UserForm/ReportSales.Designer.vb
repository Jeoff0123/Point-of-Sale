<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSales))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport54 = New UserForm.CrystalReport5()
        Me.CrystalReport53 = New UserForm.CrystalReport5()
        Me.MNUStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPntVw = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReport52 = New UserForm.CrystalReport5()
        Me.CrystalReport51 = New UserForm.CrystalReport5()
        Me.MNUStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 42)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport54
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1517, 726)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.MNUStrip1.Size = New System.Drawing.Size(1517, 39)
        Me.MNUStrip1.TabIndex = 20
        Me.MNUStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToolStripMenuItem, Me.MNUPntVw, Me.MNUCLOSE4})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(89, 35)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Image = CType(resources.GetObject("ReturnToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(371, 36)
        Me.ReturnToolStripMenuItem.Text = "Search"
        '
        'MNUPntVw
        '
        Me.MNUPntVw.Image = CType(resources.GetObject("MNUPntVw.Image"), System.Drawing.Image)
        Me.MNUPntVw.Name = "MNUPntVw"
        Me.MNUPntVw.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MNUPntVw.Size = New System.Drawing.Size(371, 36)
        Me.MNUPntVw.Text = "Print View"
        '
        'MNUCLOSE4
        '
        Me.MNUCLOSE4.Image = CType(resources.GetObject("MNUCLOSE4.Image"), System.Drawing.Image)
        Me.MNUCLOSE4.Name = "MNUCLOSE4"
        Me.MNUCLOSE4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MNUCLOSE4.Size = New System.Drawing.Size(371, 36)
        Me.MNUCLOSE4.Text = "Close"
        '
        'ReportSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 765)
        Me.ControlBox = False
        Me.Controls.Add(Me.MNUStrip1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "ReportSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MNUStrip1.ResumeLayout(False)
        Me.MNUStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport51 As CrystalReport5
    Friend WithEvents CrystalReport52 As CrystalReport5
    Friend WithEvents MNUStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUPntVw As ToolStripMenuItem
    Friend WithEvents MNUCLOSE4 As ToolStripMenuItem
    Friend WithEvents CrystalReport53 As CrystalReport5
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrystalReport54 As CrystalReport5
End Class
