
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form2
    Dim crystal As ReportDocument  ' Declare outside Try block
    Dim rpt As New CrystalReport1
    Private Sub MNUCLOSE4_Click(sender As Object, e As EventArgs) Handles MNUCLOSE4.Click
        If xpriv = "User" Then
            StkFrm.Show()
            Me.Close()
        ElseIf xpriv = "Admin" Then
            Report.Show()
            Crystal_Report.Show()
            Me.Close()

        End If

    End Sub
    Sub LoadReportShow()
        Try
            crystal = New ReportDocument()
            crystal.Load(Application.StartupPath & "\Reports\CrystalReport1.rpt")
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
        LoadReportShow()





    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReportShow()



    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim z As String
        z = InputBox("Enter Item Name to Search").Trim()

        If String.IsNullOrEmpty(z) Then ' Check for empty search string
            MsgBox("Please enter a valid item name to search.", MsgBoxStyle.Information)
            Return ' Exit the function
        End If

        LoadReport(z)

    End Sub

    Private Sub mnustckfrm_Click(sender As Object, e As EventArgs) Handles mnustckfrm.Click
        Me.Close()
        ReportSales.Close()

        StkFrm.Show()
    End Sub

    Private Sub LoadReport(Optional ByVal searchItem As String = "")
        Try
            If String.IsNullOrEmpty(searchItem) Then
                rpt.RecordSelectionFormula = ""
            Else
                rpt.RecordSelectionFormula = "{TblStock.ItemName} Like '*" & searchItem & "*' OR {TblStock.Quantity} Like '*" & searchItem & "*'"



            End If

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
        Finally

        End Try
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadReportShow()

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

End Class