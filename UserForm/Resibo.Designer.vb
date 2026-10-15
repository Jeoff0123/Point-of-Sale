<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resibo))
        Me.MNUStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPntVw = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCLOSE4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport25 = New UserForm.CrystalReport2()
        Me.CrystalReport24 = New UserForm.CrystalReport2()
        Me.CrystalReport21 = New UserForm.CrystalReport2()
        Me.CrystalReport22 = New UserForm.CrystalReport2()
        Me.CrystalReport23 = New UserForm.CrystalReport2()
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
        Me.MNUStrip1.Size = New System.Drawing.Size(624, 39)
        Me.MNUStrip1.TabIndex = 20
        Me.MNUStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUPntVw, Me.MNUCLOSE4})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(89, 35)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'MNUPntVw
        '
        Me.MNUPntVw.Name = "MNUPntVw"
        Me.MNUPntVw.Size = New System.Drawing.Size(247, 36)
        Me.MNUPntVw.Text = "Print View"
        '
        'MNUCLOSE4
        '
        Me.MNUCLOSE4.Image = CType(resources.GetObject("MNUCLOSE4.Image"), System.Drawing.Image)
        Me.MNUCLOSE4.Name = "MNUCLOSE4"
        Me.MNUCLOSE4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MNUCLOSE4.Size = New System.Drawing.Size(247, 36)
        Me.MNUCLOSE4.Text = "Close"
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\UserForm" &
    "\CrystalReport2.rpt"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport25
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(621, 761)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Resibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(624, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.MNUStrip1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Resibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MNUStrip1.ResumeLayout(False)
        Me.MNUStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As CrystalReport2
    Friend WithEvents MNUStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUPntVw As ToolStripMenuItem
    Friend WithEvents MNUCLOSE4 As ToolStripMenuItem
    Friend WithEvents CrystalReport23 As CrystalReport2
    Friend WithEvents CrystalReport22 As CrystalReport2
    Friend WithEvents CrystalReport24 As CrystalReport2
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents CrystalReport25 As CrystalReport2
End Class
