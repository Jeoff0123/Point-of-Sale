Imports CrystalDecisions.CrystalReports.Engine

Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opentransdb()
        sqltransquery()


        dgrpt.DataSource = transds.Tables("Trans")
        DisplayTotal()

        Timer5.Interval = 1000
        Timer5.Start()

        Timer1.Interval = 1000
        Timer1.Start()

        lblnm23.Text = xname



    End Sub

    Private Sub DisplayTotal()
        ' Initialize total sales to 0
        Dim totalSales As Long = 0

        ' Iterate through each row in the "Trans" table and sum the "Total" column
        For Each row As DataRow In transds.Tables("Trans").Rows
            Dim rowTotal As Long
            If Long.TryParse(row("Total").ToString(), rowTotal) Then
                totalSales = totalSales + rowTotal ' this loop the total until it reach the last data in the last row
            Else
                MsgBox("There is an error in the database.", MsgBoxStyle.Critical, "Error")
            End If
        Next

        ' Display the total sales in the label
        lbldistotal.Text = Format(totalSales, "C2") ' Display as a number in decimal

    End Sub



    Private Sub mnupulst_Click(sender As Object, e As EventArgs) Handles mnupulst.Click
        Export_to_Excel.Show()

    End Sub

    Private Sub MNUCLOSE_Click(sender As Object, e As EventArgs) Handles MNUCLOSE.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close the window?", MsgBoxStyle.YesNo, "Closing...")

        If Result = MsgBoxResult.Yes Then



            Me.Hide()
            Category.Show()




        End If

    End Sub

    Private Sub MNYNEXT_Click(sender As Object, e As EventArgs) Handles MNYNEXT.Click
        If recpoint < trec Then
            dgrpt.Rows(recpoint).Selected = False
            recpoint = recpoint + 1

            dgrpt.Rows(recpoint).Selected = True
            dgrpt.FirstDisplayedScrollingRowIndex = recpoint

        End If
    End Sub

    Private Sub MNU_SRCH_Click(sender As Object, e As EventArgs) Handles MNU_SRCH.Click
        Dim z As String
        z = InputBox("Enter Transaction date to Search", "Search").Trim()

        If String.IsNullOrEmpty(z) Then ' Check for empty search string
            MsgBox("Please enter a Item Name to search.", MsgBoxStyle.Information)
            Return ' Exit the function
        End If

        Try
            conn.Open()

            trns = New OleDb.OleDbDataAdapter("SELECT [Item ID],[Item Name],[Quantity],[UnitPrice],[Total],[Time Transaction],[Cashier Name] FROM  Trans WHERE [Time Transaction] LIKE @ItemName", conn)
            trns.SelectCommand.Parameters.AddWithValue("@Itemname", "%" & z & "%")

            transds = New DataSet
            trns.Fill(transds, "Trans")

            If transds.Tables("Trans").Rows.Count > 0 Then
                recpoint = 0
                trec = transds.Tables("Trans").Rows.Count - 1
                dgrpt.DataSource = transds.Tables("Trans")


                DisplayTotal()

            Else
                MsgBox("No records found for the specified Item Name in database.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()  ' Close connection even on errors
        End Try

    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        lbldate.Text = Format(Now, "dd MMMM, yyyy")
    End Sub

    Private Sub MNUCNCL_Click(sender As Object, e As EventArgs) Handles MNUCNCL.Click
        sqltransquery()
        dgrpt.DataSource = transds.Tables("Trans")
        DisplayTotal()

    End Sub

    Private Sub CrytalReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrytalReportToolStripMenuItem.Click
        Crystal_Report.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now, "dd MMMM, yyyy hh:mm:ss tt")
    End Sub

    Private Sub MNUPREV_Click(sender As Object, e As EventArgs) Handles MNUPREV.Click
        If recpoint > 0 Then
            dgrpt.Rows(recpoint).Selected = False
            recpoint = recpoint - 1

            dgrpt.Rows(recpoint).Selected = True

            dgrpt.FirstDisplayedScrollingRowIndex = recpoint
        End If
    End Sub

    Private Sub MNUDEL_Click(sender As Object, e As EventArgs) Handles MNUDEL.Click
        Try

            If MsgBox(" The item will be deleted permanently! Do you want to delete this item?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
                conn.Open()
                cm = New OleDb.OleDbCommand("DELETE FROM Trans", conn)
                cm.ExecuteNonQuery()

                transds.Tables("Trans").Clear()
                dgrpt.DataSource = transds.Tables("Trans")
                DisplayTotal()
            End If
            MsgBox("The data has been deleted in the database successfully...", MsgBoxStyle.Information, "Deleted")
        Catch ex As Exception
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub MnuUserList_Click(sender As Object, e As EventArgs)
        Dim xport As New Cashierprnt()
        xport.ExportCashierAndOpenExcel("C:\Users\Jeoff\Documents\PoinOfSale\PoinOfSale\PoinOfSale\UserForm\UserForm\bin\Debug\Excel\Sales.xlsx", "MINAS BOARD-TAP STORE ", "DAILY SALES REPORT")
    End Sub

    Private Sub Report_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub lbldistotal_Click(sender As Object, e As EventArgs) Handles lbldistotal.Click

    End Sub
End Class