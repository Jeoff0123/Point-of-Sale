Public Class Crystal_Report
    Private Sub MNUCLOSE4_Click(sender As Object, e As EventArgs) Handles MNUCLOSE4.Click
        Me.Close()
        MNUStrip1.Enabled = True

    End Sub

    Private Sub BtnUserList_Click(sender As Object, e As EventArgs) Handles BtnUserList.Click
        CRUser.Show()
        Me.Close()
    End Sub

    Private Sub BtnSalesRpt_Click(sender As Object, e As EventArgs) Handles BtnSalesRpt.Click

        ReportSales.Show()
        Me.Close()
    End Sub

    Private Sub BtnStckList_Click(sender As Object, e As EventArgs) Handles BtnStckList.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Crystal_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class