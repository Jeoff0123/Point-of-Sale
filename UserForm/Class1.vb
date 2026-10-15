Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports System.Data.OleDb


Public Class Class1
    Public Sub ExportItemListAndOpenExcel(filePath As String, ownerName As String, report As String)
        Dim appexcel As Excel.Application = Nothing
        Dim wbook As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing
        Dim rd As OleDbDataReader = Nothing

        Try
            appexcel = New Excel.Application
            wbook = appexcel.Workbooks.Open(filePath)

            sheet = CType(wbook.Sheets(1), Excel.Worksheet)

            With sheet.Cells(5, 3)
                .Value = report
                .Font.Bold = True
                .Font.Size = 22
                .Font.Name = "Microsoft YaHei UI"
            End With

            With sheet.Cells(4, 3)
                .Value = ownerName
                .Font.Bold = True
                .Font.Size = 22
                .Font.Name = "Microsoft YaHei UI"
            End With



            Dim rw As Integer = 6
            conn.Open()

            cm = New OleDb.OleDbCommand("SELECT [ItemID],[ItemName],[ItemDescription],[Quantity],[BuyingPrice],[SellingPrice],[Critical] FROM TblStock ", conn)
            rd = cm.ExecuteReader()


            Dim stockheader As String() = {"Item ID", "Item Name", "Item Description", "Quantity", "Buying Price", "Selling Price", "Critical"}
            sheet.Range("B6:H6").Value = stockheader


            With sheet.Range("B6:H6")
                .Font.Bold = True
                .Font.Size = 14
                .Interior.Color = Excel.XlRgbColor.rgbLightSkyBlue
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous

            End With


            Dim data As New List(Of Object())

            While rd.Read()
                Dim row As Object() = {
                    rd("ItemID").ToString(),
                    rd("ItemName").ToString(),
                    rd("ItemDescription").ToString(),
                    rd("Quantity").ToString(),
                    rd("BuyingPrice").ToString(),
                    rd("SellingPrice").ToString(),
                    rd("Critical").ToString()
                }
                data.Add(row)
            End While

            Dim dataArray(,) As Object = New Object(data.Count - 1, 6) {}
            For i As Integer = 0 To data.Count - 1
                For j As Integer = 0 To 6
                    dataArray(i, j) = data(i)(j)
                Next

            Next

            Dim start As Excel.Range = sheet.Cells(rw + 1, 2)
            Dim endcells As Excel.Range = sheet.Cells(rw + data.Count, 8)
            sheet.Range(start, endcells).Value = dataArray

            sheet.Range(start, endcells).Font.Size = 14

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
