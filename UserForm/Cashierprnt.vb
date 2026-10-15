Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports System.Data.OleDb

Public Class Cashierprnt
    Public Sub ExportCashierAndOpenExcel(filePath As String, Name As String, saleName As String)

        Dim appexcel As Excel.Application = Nothing
        Dim wbook As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing
        Dim rd As OleDbDataReader = Nothing

        Try
            appexcel = New Excel.Application
            wbook = appexcel.Workbooks.Open(filePath)

            sheet = CType(wbook.Sheets(1), Excel.Worksheet)

            With sheet.Cells(3, 2)
                .Value = saleName
                .Font.Size = 22
                .Font.Bold = True
                .Font.Name = "Microsoft YaHei UI"
            End With

            With sheet.Cells(2, 2)
                .Value = Name
                .Font.Size = 22
                .Font.Bold = True
                .Font.Name = "Microsoft YaHei UI"
            End With
            Dim rw As Integer = 6
            conn.Open()

            cm = New OleDb.OleDbCommand("SELECT [Item ID],[Item Name],[Quantity],[UnitPrice],[Total],[Time Transaction],[Cashier Name] FROM Trans ", conn)
            rd = cm.ExecuteReader()

            Dim salesheader As String() = {"Item ID", "Item Name", "Quantity", "UnitPrice", "Total", "Date and Time Transaction", "Cashier Name"}
            sheet.Range("A6:G6").Value = salesheader


            With sheet.Range("A6:G6")
                .Font.Bold = True
                .Font.Size = 14
                .Interior.Color = Excel.XlRgbColor.rgbLightSkyBlue
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            End With

            Dim data As New List(Of Object())
            While rd.Read()
                Dim cellrw As Object() = {
                    rd("Item ID").ToString(),
                         rd("Item Name").ToString(),
                              rd("Quantity").ToString(),
                                   rd("UnitPrice").ToString(),
                                        rd("Total").ToString(),
                                             rd("Time Transaction").ToString(),
                                                  rd("Cashier Name").ToString()
                    }
                data.Add(cellrw)
            End While

            Dim DataArray(,) As Object = New Object(data.Count - 1, 6) {}
            For i As Integer = 0 To data.Count - 1
                For j As Integer = 0 To 6
                    DataArray(i, j) = data(i)(j)
                Next

            Next

            Dim Cellstart As Excel.Range = sheet.Cells(rw + 1, 1)
            Dim endcells As Excel.Range = sheet.Cells(rw + data.Count, 7)
            sheet.Range(Cellstart, endcells).Value = DataArray

            sheet.Range(Cellstart, endcells).Font.Size = 14

            wbook.Save()
            appexcel.Visible = True
            appexcel.WindowState = Excel.XlWindowState.xlMaximized

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally

            If rd IsNot Nothing AndAlso Not rd.IsClosed Then
                rd.Close()
            End If

            conn.Close()

            Marshal.ReleaseComObject(sheet)
            Marshal.ReleaseComObject(wbook)
            Marshal.ReleaseComObject(appexcel)

            sheet = Nothing
            wbook = Nothing
            appexcel = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub


End Class
