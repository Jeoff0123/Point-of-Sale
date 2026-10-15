Public Class Export_to_Excel
    Private Sub MNUCLOSE4_Click(sender As Object, e As EventArgs) Handles MNUCLOSE4.Click
        Me.Close()
        Report.Show()

    End Sub

    Private Sub BtnUserList_Click(sender As Object, e As EventArgs) Handles BtnUserList.Click
        Dim exporter As New PrintExcel()
        exporter.ExportUserListAndOpenExcel(Application.StartupPath & "\Excel\Listofuser.xlsx", "MINAS BOARD-TAP STORE", "USER LIST REPORT")
    End Sub

    Private Sub BtnStckList_Click(sender As Object, e As EventArgs) Handles BtnStckList.Click
        Dim xport As New Class1()
        xport.ExportItemListAndOpenExcel(Application.StartupPath & "\Excel\Itemlist.xlsx", "MINAS BOARD-TAP STORE ", "ITEM LIST REPORT")
    End Sub

    Private Sub BtnSalesRpt_Click(sender As Object, e As EventArgs) Handles BtnSalesRpt.Click
        Dim xport As New Cashierprnt()
        xport.ExportCashierAndOpenExcel(Application.StartupPath & "\Excel\Sales.xlsx", "MINAS BOARD-TAP STORE ", "DAILY SALES REPORT")
    End Sub
End Class