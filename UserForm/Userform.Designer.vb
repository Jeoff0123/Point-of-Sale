<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUFIRST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUNEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPREV = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNULAST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCHANGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUSEARCH = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUDEL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUCANCEL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Id = New System.Windows.Forms.TextBox()
        Me.Txt_UserName = New System.Windows.Forms.TextBox()
        Me.Txt_Position = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmb_Privilage = New System.Windows.Forms.ComboBox()
        Me.DatabaseKimDataSet = New UserForm.DatabaseKimDataSet()
        Me.DATAbaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATAbaseTableAdapter = New UserForm.DatabaseKimDataSetTableAdapters.DATAbaseTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseKimDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATAbaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUFIRST, Me.MNUNEXT, Me.MNUPREV, Me.MNULAST, Me.MNUADD, Me.MNUCHANGE, Me.MNUSEARCH, Me.MNUDEL, Me.MNUCANCEL})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'MNUFIRST
        '
        Me.MNUFIRST.Name = "MNUFIRST"
        Me.MNUFIRST.Size = New System.Drawing.Size(115, 22)
        Me.MNUFIRST.Text = "First"
        '
        'MNUNEXT
        '
        Me.MNUNEXT.Name = "MNUNEXT"
        Me.MNUNEXT.Size = New System.Drawing.Size(115, 22)
        Me.MNUNEXT.Text = "Next"
        '
        'MNUPREV
        '
        Me.MNUPREV.Name = "MNUPREV"
        Me.MNUPREV.Size = New System.Drawing.Size(115, 22)
        Me.MNUPREV.Text = "Prev"
        '
        'MNULAST
        '
        Me.MNULAST.Name = "MNULAST"
        Me.MNULAST.Size = New System.Drawing.Size(115, 22)
        Me.MNULAST.Text = "Last"
        '
        'MNUADD
        '
        Me.MNUADD.Name = "MNUADD"
        Me.MNUADD.Size = New System.Drawing.Size(115, 22)
        Me.MNUADD.Text = "Add"
        '
        'MNUCHANGE
        '
        Me.MNUCHANGE.Name = "MNUCHANGE"
        Me.MNUCHANGE.Size = New System.Drawing.Size(115, 22)
        Me.MNUCHANGE.Text = "Change"
        '
        'MNUSEARCH
        '
        Me.MNUSEARCH.Name = "MNUSEARCH"
        Me.MNUSEARCH.Size = New System.Drawing.Size(115, 22)
        Me.MNUSEARCH.Text = "Search"
        '
        'MNUDEL
        '
        Me.MNUDEL.Name = "MNUDEL"
        Me.MNUDEL.Size = New System.Drawing.Size(115, 22)
        Me.MNUDEL.Text = "Delete"
        '
        'MNUCANCEL
        '
        Me.MNUCANCEL.Name = "MNUCANCEL"
        Me.MNUCANCEL.Size = New System.Drawing.Size(115, 22)
        Me.MNUCANCEL.Text = "Cancel"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(437, 262)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(402, 156)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Position"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Privilage"
        Me.Column4.Name = "Column4"
        '
        'Txt_Id
        '
        Me.Txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Id.Location = New System.Drawing.Point(134, 163)
        Me.Txt_Id.Name = "Txt_Id"
        Me.Txt_Id.Size = New System.Drawing.Size(136, 20)
        Me.Txt_Id.TabIndex = 2
        '
        'Txt_UserName
        '
        Me.Txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_UserName.Location = New System.Drawing.Point(134, 211)
        Me.Txt_UserName.Name = "Txt_UserName"
        Me.Txt_UserName.Size = New System.Drawing.Size(136, 20)
        Me.Txt_UserName.TabIndex = 3
        '
        'Txt_Position
        '
        Me.Txt_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Position.Location = New System.Drawing.Point(134, 262)
        Me.Txt_Position.Name = "Txt_Position"
        Me.Txt_Position.Size = New System.Drawing.Size(136, 20)
        Me.Txt_Position.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'Cmb_Privilage
        '
        Me.Cmb_Privilage.FormattingEnabled = True
        Me.Cmb_Privilage.Items.AddRange(New Object() {"User", "Admin"})
        Me.Cmb_Privilage.Location = New System.Drawing.Point(134, 307)
        Me.Cmb_Privilage.Name = "Cmb_Privilage"
        Me.Cmb_Privilage.Size = New System.Drawing.Size(136, 21)
        Me.Cmb_Privilage.TabIndex = 10
        '
        'DatabaseKimDataSet
        '
        Me.DatabaseKimDataSet.DataSetName = "DatabaseKimDataSet"
        Me.DatabaseKimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATAbaseBindingSource
        '
        Me.DATAbaseBindingSource.DataMember = "DATAbase"
        Me.DATAbaseBindingSource.DataSource = Me.DatabaseKimDataSet
        '
        'DATAbaseTableAdapter
        '
        Me.DATAbaseTableAdapter.ClearBeforeFill = True
        '
        'UsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1016, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cmb_Privilage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Position)
        Me.Controls.Add(Me.Txt_UserName)
        Me.Controls.Add(Me.Txt_Id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseKimDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATAbaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNUFIRST As ToolStripMenuItem
    Friend WithEvents MNUNEXT As ToolStripMenuItem
    Friend WithEvents MNUPREV As ToolStripMenuItem
    Friend WithEvents MNULAST As ToolStripMenuItem
    Friend WithEvents MNUADD As ToolStripMenuItem
    Friend WithEvents MNUCHANGE As ToolStripMenuItem
    Friend WithEvents MNUSEARCH As ToolStripMenuItem
    Friend WithEvents MNUDEL As ToolStripMenuItem
    Friend WithEvents MNUCANCEL As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Id As TextBox
    Friend WithEvents Txt_UserName As TextBox
    Friend WithEvents Txt_Position As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cmb_Privilage As ComboBox
    Friend WithEvents DatabaseKimDataSet As DatabaseKimDataSet
    Friend WithEvents DATAbaseBindingSource As BindingSource
    Friend WithEvents DATAbaseTableAdapter As DatabaseKimDataSetTableAdapters.DATAbaseTableAdapter
End Class
