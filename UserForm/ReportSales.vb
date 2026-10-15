Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportSales
    Dim crystal As ReportDocument = Nothing
    Dim rpt As New CrystalReport5


    Private Sub ReportSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reportfrm()
        MNUStrip1.Enabled = True


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

    Sub ReportLoadShow()


        Try

            crystal = New ReportDocument()
            crystal.Load(Application.StartupPath & "\Reports\CrystalReport5.rpt")
            crystal.PrintOptions.NoPrinter = True

            CrystalReportViewer1.ReportSource = crystal
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        Finally
            If crystal IsNot Nothing Then
                crystal.Close()

            End If
        End Try
    End Sub

    Private Sub MNUPntVw_Click(sender As Object, e As EventArgs) Handles MNUPntVw.Click



        reportfrm()

    End Sub

    Private Sub MNUCLOSE4_Click(sender As Object, e As EventArgs) Handles MNUCLOSE4.Click

        If xpriv = "Admin" Then
            Report.Show()
            Crystal_Report.Show()
            Me.Close()
        ElseIf xpriv = "User" Then
            Cashier.Show()
            Me.Close()

        End If




    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Dim z As String
        z = InputBox("Enter Transaction Date Or Cashier Name to Search").Trim()

        If String.IsNullOrEmpty(z) Then ' Check for empty search string
            MsgBox("Please enter a valid text to search.", MsgBoxStyle.Information)
            Return ' Exit the function
        End If

        LoadReport(z)

    End Sub
    Private Sub LoadReport(Optional ByVal searchItem As String = "")
        Try


            If String.IsNullOrEmpty(searchItem) Then
                rpt.RecordSelectionFormula = ""
            Else
                rpt.RecordSelectionFormula = "{Trans.Time Transaction} Like '*" & searchItem & "*' OR {Trans.Cashier Name} Like '*" & searchItem & "*'"



            End If

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception

        End Try
    End Sub




    Sub reportfrm()
        Try
            crystal = New ReportDocument()
            crystal.Load(Application.StartupPath & "\Reports\CrystalReport5.rpt")
            SetDatabaseLogon(crystal, Application.StartupPath & "\DataBase2\JeoffDB.mdb", "", "", "")
            crystal.PrintOptions.NoPrinter = True

            CrystalReportViewer1.ReportSource = crystal
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        Finally
            If crystal IsNot Nothing Then
                crystal.Close()

            End If
        End Try
    End Sub

    Private Sub ReportSales_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        reportfrm()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub
End Class