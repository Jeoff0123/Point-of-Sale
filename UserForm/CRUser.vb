Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class CRUser

    Dim rpt As New CrystalReport3

    Private Sub CRUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportShow()

    End Sub
    Private Sub SetDatabaseLogon(report As ReportDocument, serverName As String, dbName As String, userID As String, password As String)
        Dim logonInfo As TableLogOnInfo
        Dim connectionInfo As New ConnectionInfo

        connectionInfo.ServerName = serverName
        connectionInfo.DatabaseName = dbName
        connectionInfo.UserID = userID
        connectionInfo.Password = password

        For Each table As Table In report.Database.Tables
            logonInfo = table.LogOnInfo
            logonInfo.ConnectionInfo = connectionInfo
            table.ApplyLogOnInfo(logonInfo)
        Next

        For Each section As Section In report.ReportDefinition.Sections
            For Each reportObject As ReportObject In section.ReportObjects
                If reportObject.Kind = ReportObjectKind.SubreportObject Then
                    Dim subReport As SubreportObject = CType(reportObject, SubreportObject)
                    Dim subreportDocument As ReportDocument = subReport.OpenSubreport(subReport.SubreportName)

                    For Each subTable As Table In subreportDocument.Database.Tables
                        logonInfo = subTable.LogOnInfo
                        logonInfo.ConnectionInfo = connectionInfo
                        subTable.ApplyLogOnInfo(logonInfo)
                    Next

                End If
            Next

        Next

    End Sub

    Sub ReportShow()
        Dim crystal As ReportDocument = Nothing ' Declare outside Try block
        Try
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            crystal = New ReportDocument()
            crystal.Load(Application.StartupPath & "\Reports\CrystalReport3.rpt")
            SetDatabaseLogon(crystal, Application.StartupPath & "\DataBase2\JeoffDB.mdb", "", "", "")
            CrystalReportViewer1.ReportSource = crystal
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        Finally
            ' Check if crystal is not null before attempting to close or dispose
            If crystal IsNot Nothing Then
                crystal.Close()

            End If
        End Try
    End Sub

    Private Sub MNUPntVw_Click(sender As Object, e As EventArgs) Handles MNUPntVw.Click
        ReportShow()


    End Sub

    Private Sub MNUCLOSE4_Click(sender As Object, e As EventArgs) Handles MNUCLOSE4.Click
        If xpriv = "Admin" Then
            Report.Show()
            Crystal_Report.Show()
            Me.Close()
        Else
            UsFrm.Show()
            Me.Close()

        End If
    End Sub

    Private Sub menusearch_Click(sender As Object, e As EventArgs) Handles menusearch.Click
        Dim z As String
        z = InputBox("Enter term to Search", "Search").Trim()

        If String.IsNullOrEmpty(z) Then ' Check for empty search string
            MsgBox("Please enter a valid text to search.", MsgBoxStyle.Information)
            Return ' Exit the function
        End If

        SearchReport(z)
    End Sub
    Private Sub LoadReport()
        Try
            Dim position As String = ComboBox2.SelectedItem?.ToString() ' Position ComboBox
            Dim privilege As String = ComboBox1.SelectedItem?.ToString() ' Privilege ComboBox

            ' Construct the RecordSelectionFormula based on ComboBox selections
            Dim selectionFormula As String = Nothing

            ' Apply filtering by Position if selected
            If Not String.IsNullOrEmpty(position) AndAlso privilege <> "Both" Then
                selectionFormula = "{DataBaseTB.Position} = '" & position & "'"
            Else

            End If

            ' Apply filtering by Privilege if selected and "All"
            If Not String.IsNullOrEmpty(privilege) AndAlso privilege <> "Both" Then
                ' If Position filter exists, append the Privilege filter with AND
                If Not String.IsNullOrEmpty(selectionFormula) Then
                    selectionFormula &= " AND "
                End If
                selectionFormula &= "{DataBaseTB.Privilege} = '" & privilege & "'"
            End If

            ' Apply the selection formula if any filters were set
            If Not String.IsNullOrEmpty(selectionFormula) Then
                rpt.RecordSelectionFormula = selectionFormula
            Else
                rpt.RecordSelectionFormula = Nothing ' No filters, show all records
            End If

            ' Set the report source and refresh the report
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            ' Handle any potential errors
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rpt.Close()

        End Try
    End Sub

    Private Sub DispalyFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispalyFilterToolStripMenuItem.Click
        LoadReport()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub SearchReport(Optional ByVal searchItem As String = "")
        Try
            If String.IsNullOrEmpty(searchItem) Then
                rpt.RecordSelectionFormula = ""
            Else
                rpt.RecordSelectionFormula = "{DataBaseTB.Position} Like '*" & searchItem & "*' OR {DataBaseTB.Privilege} Like '*" & searchItem & "*'"
            End If

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rpt.Close()


        End Try
    End Sub
    Private Sub cbPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        LoadReport()

    End Sub

    Private Sub cbPrivilege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadReport()

    End Sub

    Private Sub MnuUserFrm_Click(sender As Object, e As EventArgs) Handles MnuUserFrm.Click
        Me.Close()
        Report.Close()

        UsFrm.Show()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub
End Class