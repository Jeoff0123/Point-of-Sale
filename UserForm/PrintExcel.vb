Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports System.Data.OleDb

Public Class PrintExcel
    Public Sub ExportUserListAndOpenExcel(filePath As String, Name As String, rptname As String)
        Dim excelApp As Excel.Application = Nothing
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing
        Dim dr As OleDbDataReader = Nothing

        Try
            excelApp = New Excel.Application()
            workbook = excelApp.Workbooks.Open(filePath)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

            With worksheet.Cells(3, 3)
                .Value = rptname
                .Font.Size = 22
                .Font.Bold = True
                .Font.Name = "Microsoft YaHei UI"
            End With

            With worksheet.Cells(2, 3)
                .Value = Name
                .Font.Bold = True
                .Font.Size = 22
                .Font.Name = "Microsoft YaHei UI"
            End With

            Dim row As Integer = 6
            conn.Open()

            cm = New OleDbCommand("SELECT [UserID],[UserName],[Position],[Password],[Privilege] FROM DataBaseTB", conn)
            dr = cm.ExecuteReader()



            Dim header As String() = {"User ID", "User Name", "Position", "Password", "Privilege"}
            worksheet.Range("B6:F6").Value = header
            With worksheet.Range("B6:F6")
                .Font.Bold = True
                .Font.Size = 14
                .Interior.Color = Excel.XlRgbColor.rgbLightSkyBlue
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            End With

            Dim data As New List(Of Object())
            While dr.Read()
                Dim rowData As Object() = {
                    dr("UserID").ToString(),
                    dr("UserName").ToString(),
                    dr("Position").ToString(),
                    dr("Password").ToString(),
                    dr("Privilege").ToString()
                }
                data.Add(rowData)
            End While

            Dim dataArray(,) As Object = New Object(data.Count - 1, 4) {}
            For i As Integer = 0 To data.Count - 1
                For j As Integer = 0 To 4
                    dataArray(i, j) = data(i)(j)
                Next
            Next

            ' Writing to Excel range in bulk
            Dim startCell As Excel.Range = worksheet.Cells(row + 1, 2)
            Dim endCell As Excel.Range = worksheet.Cells(row + data.Count, 6)
            worksheet.Range(startCell, endCell).Value = dataArray

            ' Formatting the cells
            worksheet.Range(startCell, endCell).Font.Size = 14
            worksheet.Cells(row, 2).NumberFormat = """JLM-""0000"
            worksheet.Cells(row, 5).NumberFormat = "0000"

            workbook.Save()
            excelApp.Visible = True
            excelApp.WindowState = Excel.XlWindowState.xlMaximized
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            conn.Close()

            Marshal.ReleaseComObject(worksheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(excelApp)

            worksheet = Nothing
            workbook = Nothing
            excelApp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub


End Class
