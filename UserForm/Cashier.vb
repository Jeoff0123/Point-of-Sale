

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class Cashier
    Private amtValue As Decimal = 0D
    Private displayValue As Decimal = 0D
    Private displayChange As Decimal = 0D
    Private adminpass As String

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi



        opendbtemp()
        sqlquerytemp()

        ClearCashierTB()

        SetUpPriv()

        dgcash.DataSource = tempds.Tables("CashierTB")
        dgcash.Enabled = False

        TxtItId.Focus()
        gbpay.Visible = False

        xGTotal = 0
        lblnm.Text = xname
        Timer1.Interval = 1000 ' update every 1 second
        Timer1.Start()
        Txtqnty.Text = "0"

    End Sub
    Sub SetUpPriv()
        If xpriv = "Admin" AndAlso (xpost = "Supervisor" OrElse xpost = "Manager") Then
            gbpay.Visible = True
            gbpay.Enabled = False
            gbtrans.Visible = True
            gbtrans.Enabled = False
        End If

    End Sub

    Sub ClearCashierTB()
        Try
            conn.Open()
            cm = New OleDb.OleDbCommand("DELETE FROM CashierTB", conn)
            cm.ExecuteNonQuery()

            tempds.Tables("CashierTB").Clear()
        Catch ex As Exception
            MsgBox("An error occurred while clearing records: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, "dd MMMM, yyyy hh:mm:ss tt")
    End Sub
    Private Sub TxtItId_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItId.KeyDown
        If e.KeyCode = Keys.F2 Then
            e.SuppressKeyPress = True
            gbpay.Visible = True
            Txtamt.Focus()
            gbtrans.Visible = True
            Exit Sub
        End If
        If e.KeyCode = Keys.F5 Then
            Dim itemlist As New ItemLst()
            itemlist.Owner = Me
            itemlist.ShowDialog()
        End If
        If e.KeyCode = 27 Then
            e.SuppressKeyPress = True
            Dim Result As MsgBoxResult = MsgBox("Do you want to close this window? The next user will be required to log in. Do you want to proceed?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Log Off Confirmation")

            If Result = MsgBoxResult.Yes Then
                If xpriv = "User" And xpost = "Cashier" Then

                    Me.Close()
                    Category.Close()
                    Loginfrm.Show()
                Else
                    Me.Close()
                    Category.Close()
                    Loginfrm.Show()

                End If

                Exit Sub
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                stck = New OleDb.OleDbDataAdapter("SELECT [ItemID],[ItemName],[ItemDescription],[Quantity],[BuyingPrice],[SellingPrice],[Critical] FROM  TblStock WHERE [ItemID] like  @ItemID", conn)
                stck.SelectCommand.Parameters.AddWithValue("@ItemID", TxtItId.Text.Trim())
                ds = New DataSet()
                stck.Fill(ds, "TblStock")

                If ds.Tables("TblStock").Rows.Count > 0 Then
                    xUP = ds.Tables("TblStock").Rows(0).Item("SellingPrice")
                    lbldisplay1.Text = Format(xUP, "Standard")
                    xDesc = ds.Tables("TblStock").Rows(0).Item("ItemDescription")
                    lbldesc.Text = ds.Tables("TblStock").Rows(0).Item("ItemDescription")
                    xItemName = ds.Tables("TblStock").Rows(0).Item("ItemName")
                    lbl_ItemName.Text = ds.Tables("TblStock").Rows(0).Item("ItemName")


                    Stcklvl()


                    temp = New OleDb.OleDbDataAdapter("SELECT [Item ID],[ItemDescription],[Quantity],[UnitPrice],[Total] FROM  CashierTB  WHERE [Item ID] like @ItemID", conn)
                    temp.SelectCommand.Parameters.AddWithValue("@ItemID", TxtItId.Text.Trim)
                    tempds = New DataSet()
                    temp.Fill(tempds, "CashierTB")

                    If tempds.Tables("CashierTB").Rows().Count > 0 Then
                        If MsgBox("This item is already on your list, Would you like to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            xtempq = tempds.Tables("CashierTB").Rows(0).Item("Quantity")
                            Txtqnty.Focus()
                            sw = False
                        Else
                            TxtItId.Clear()
                            lbldisplay1.Text = ""
                            Exit Sub
                        End If



                    Else
                        sw = True
                        Txtqnty.Focus()

                    End If
                Else
                    MessageBox.Show("The item you entered does not exist in our records." + vbCrLf + " Please check the Stock No. and try again.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    TxtItId.Clear()
                    TxtItId.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
        If e.KeyCode = Keys.F3 Then

            Dim result As MsgBoxResult = MsgBox("Are you sure you want to deduct this item?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Deduction")

            If result = MsgBoxResult.Yes Then
                Txtqnty.Focus()
            Else
                MsgBox("Deduction cancelled.", MsgBoxStyle.Information)
            End If


        End If

    End Sub

    Sub Stcklvl()
        Dim Stocksqty As String = ds.Tables("TblStock").Rows(0).Item("Quantity")
        Dim CritLev As String = ds.Tables("TblStock").Rows(0).Item("Critical")

        If Convert.ToInt64(Stocksqty) <= Convert.ToInt64(CritLev) Then

            If Stocksqty <= 0 Then
                MessageBox.Show("Out of Stocks!" + vbCrLf + "Please Re-Stock Immediately!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtItId.Clear()
                Txtqnty.Clear()
                lbltotal.Text = ""
                lbldisplay1.Text = ""

                Return
            Else

                Dim result As DialogResult = MessageBox.Show("We currently in low stocks" + vbCrLf + "Do you still want to continue the Transaction?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then


                    MsgBox("Sorry for invconvenience. Please have a nice day!!", MsgBoxStyle.Information)
                    TxtItId.Focus()
                Else
                    TxtItId.Clear()
                    Txtqnty.Clear()
                    lbltotal.Text = ""
                    lbldisplay1.Text = ""

                    Return
                End If

            End If

        End If
    End Sub

    Private Sub Txtqnty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtqnty.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ' Ensure quantity is entered
            Dim quantity As Single

            ' Validate the quantity before proceeding
            If Not CheckQnty(quantity) Then
                MsgBox("Insertion aborted due to invalid quantity.", MsgBoxStyle.Exclamation, "Invalid Quantity")
                Exit Sub
            End If


            ' Calculate the total price for the item
            xGTotal = CDbl(xUP) * CSng(Txtqnty.Text)
            lbltotal.Text = Format(xGTotal, "Standard")

            dgcash.Focus()

            If conn.State = ConnectionState.Closed Then conn.Open()


            InsertItem()


            ' Refresh DataGridView
            sqlquerytemp()
            dgcash.DataSource = tempds.Tables("CashierTB")

            ' Clear input fields for next entry

            Txtqnty.Focus()
            Txtqnty.Clear()


            ' Fetch and display the sum of the total column
            temp = New OleDb.OleDbDataAdapter("SELECT SUM([Total]) AS xt FROM CashierTB", conn)
            tempds = New DataSet()
            temp.Fill(tempds, "CashierTB")

            DisplaySum()


            TxtItId.Focus()  ' Set focus back to Item ID input for next item
        End If

        If e.KeyCode = Keys.F3 Then


            Dim result2 As MsgBoxResult = MsgBox("This action requires administrative privilege for security purposes." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Admin Privilege")

            ' If the user chooses to continue (Yes)
            If result2 = MsgBoxResult.Yes Then

                Dim passWord As New Form4()

                If passWord.ShowDialog = DialogResult.OK Then

                    Dim enteredPass As String = passWord.Password

                    ' Initialize a list to hold admin passwords
                    Dim adminPasswords As New List(Of String)

                    Try

                        conn.Open()

                        cm = New OleDbCommand("SELECT [Password] FROM DataBaseTB WHERE [Privilege] = 'Admin' ", conn)

                        Dim reader As OleDbDataReader = cm.ExecuteReader
                        While reader.Read()
                            ' Add each admin's password to the list
                            adminPasswords.Add(reader("Password").ToString())
                        End While
                        reader.Close()

                    Catch ex As Exception
                        MessageBox.Show("An error occurred while accessing the database: " & ex.Message, "Error")

                    Finally
                        ' Ensure the connection is closed, whether the operation succeeds or fails
                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If
                    End Try


                    If adminPasswords.Contains(enteredPass) Then
                        ' If the entered password matches, continue with the action
                        Dim inputItemID As String = TxtItId.Text

                        ' Fill tempds with data from the CashierTB based on the Item ID
                        temp = New OleDb.OleDbDataAdapter("SELECT * FROM CashierTB WHERE [Item ID] = @ItemID", conn)
                        temp.SelectCommand.Parameters.AddWithValue("@ItemID", inputItemID)
                        tempds = New DataSet()
                        temp.Fill(tempds, "CashierTB")

                        ' Check if the item exists
                        If tempds.Tables("CashierTB").Rows.Count = 0 Then
                            MsgBox("This item does not exist. Please check the Item ID and try again.", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If

                        ' Item exists; retrieve the existing quantity
                        trec = CInt(tempds.Tables("CashierTB").Rows(0).Item("Quantity"))


                        ' Ensure the quantity input is valid
                        If Not IsNumeric(Txtqnty.Text.Trim) Then
                            Txtqnty.Focus()
                            Exit Sub
                        End If

                        ' Calculate the new quantity and total

                        xtempq = trec - Txtqnty.Text
                        Dim newTotal As Double = xtempq * CSng(xUP)

                        ' Validate that xtempq does not go below zero
                        If xtempq < 0 Then
                            MsgBox("Stock quantity cannot be negative.", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If

                        ' Open database connection and update the values
                        Try
                            conn.Open()
                            cm = New OleDb.OleDbCommand("UPDATE CashierTB SET [Quantity] = @Quantity, [Total] = @Total WHERE [Item ID] = @ItemID", conn)
                            cm.Parameters.AddWithValue("@Quantity", CInt(xtempq))
                            cm.Parameters.AddWithValue("@Total", CDbl(newTotal))
                            cm.Parameters.AddWithValue("@ItemID", inputItemID)

                            ' Execute the command
                            cm.ExecuteNonQuery()
                            sqlquerytemp()
                            dgcash.DataSource = tempds.Tables("CashierTB")

                            ' Update the total from the CashierTB
                            temp = New OleDb.OleDbDataAdapter("SELECT SUM([Total]) AS xt FROM CashierTB", conn)
                            tempds = New DataSet()
                            temp.Fill(tempds, "CashierTB")

                            DisplaySum()

                            ' Notify the user of a successful update
                            MsgBox("Stock updated successfully.", MsgBoxStyle.Information)

                        Catch ex As Exception
                            ' Provide a polite and user-friendly error message
                            MsgBox("An error occurred while updating the stock. Please try again later." & vbCrLf & "Error Details: " & ex.Message, MsgBoxStyle.Critical)
                        Finally
                            ' Ensure the connection is closed
                            If conn.State = ConnectionState.Open Then
                                conn.Close()
                            End If
                            ' Reset the item ID confirmation flag after the update
                            sw = False

                            Txtqnty.Clear()
                            TxtItId.Focus()
                        End Try
                    Else
                        MsgBox("Incorrect password! Please try again.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                Else
                    TxtItId.Focus()
                    MsgBox("Deduction canceled.", MsgBoxStyle.Information)
                    Exit Sub
                End If



            End If

        End If

    End Sub

    Function CheckQnty(ByRef quantity As Single) As Boolean
        ' Check if the quantity text is empty, not numeric, or less than or equal to zero
        If String.IsNullOrEmpty(Txtqnty.Text) OrElse Not Single.TryParse(Txtqnty.Text, quantity) OrElse quantity <= 0 Then
            Txtqnty.Focus()
            Return False ' Invalid quantity
        End If
        Return True ' Valid quantity
    End Function
    Sub DisplaySum()
        ' Check if there are any rows in the DataSet
        If tempds.Tables("CashierTB").Rows.Count > 0 Then
            ' Iterate over each DataRow in the DataTable
            For Each row As DataRow In tempds.Tables("CashierTB").Rows
                ' Retrieve the sum from the current row
                Dim sumValue As Object = row("xt")

                ' Check if the value is DBNull and set the label accordingly
                If IsDBNull(sumValue) Then
                    lbldisplay1.Text = "0.00"
                Else
                    lbldisplay1.Text = Format(CDec(sumValue), "Standard")
                End If
            Next
        Else
            ' No rows in the DataSet, set the label to "0.00"
            lbldisplay1.Text = "0.00"
        End If
    End Sub

    Sub InsertItem()

        Try
            If sw = True Then




                ' Insert the new item
                cm = New OleDb.OleDbCommand("INSERT INTO CashierTB([Item ID],[ItemName],[ItemDescription],[Quantity],[UnitPrice],[Total],[Date and Time Transaction], [Cashier Name],[Amount],[Change]) VALUES (@ItemID,@ItemName,@Description, @Quantity, @UnitPrice, @Total,@DateTrans,@CashierName,@Amount,@Change)", conn)
                cm.Parameters.AddWithValue("@ItemID", TxtItId.Text.Trim)
                cm.Parameters.AddWithValue("@ItemName", xItemName)
                cm.Parameters.AddWithValue("@Description", xDesc)
                cm.Parameters.AddWithValue("@Quantity", Txtqnty.Text.Trim)
                cm.Parameters.AddWithValue("@UnitPrice", xUP)
                cm.Parameters.AddWithValue("@Total", xGTotal)
                cm.Parameters.AddWithValue("DateTrans", Format(Now, "dd MMMM, yyyy hh:mm:ss tt"))
                cm.Parameters.AddWithValue("@CashierName", xname)
                cm.Parameters.AddWithValue("@Amount", amtValue)
                cm.Parameters.AddWithValue("@Change", displayChange)




            Else
                ' Update the existing item quantity and total

                xtempq = xtempq + CSng(Txtqnty.Text.Trim)

                Dim newTotal As Double = xtempq * CSng(xUP)
                cm = New OleDb.OleDbCommand("UPDATE CashierTB SET [Quantity] = @Quantity, [Total] = @Total WHERE [Item ID] = @ItemID", conn)
                cm.Parameters.AddWithValue("@Quantity", CInt(xtempq))
                cm.Parameters.AddWithValue("@Total", CDbl(newTotal))
                cm.Parameters.AddWithValue("@ItemID", TxtItId.Text.Trim)
            End If


            cm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Txtamt_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtamt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If String.IsNullOrWhiteSpace(Txtamt.Text) OrElse Not IsNumeric(Txtamt.Text) OrElse Txtamt.Text <= 0 Then
                MsgBox("Please enter a valid amount for this item. Thank you.", MsgBoxStyle.Exclamation, "Valid Amount Required")
                Txtamt.Focus()

                Exit Sub
            End If

            CheckAmt()

            subtractAmt()

            InsertTrans()

        End If
        If e.KeyCode = Keys.F1 Then
            e.SuppressKeyPress = True
            gbpay.Visible = False
            gbtrans.Visible = True
            Txtqnty.Clear()
            TxtItId.Focus()

            Try
                opendbtemp()  ' Assuming this opens the connection; if not, it should be placed before this line
                sqlquerytemp() ' Ensure this is the correct method call for your scenario

                conn.Open()
                cm = New OleDb.OleDbCommand("DELETE FROM CashierTB", conn)
                cm.ExecuteNonQuery()

                ' Refresh the DataSet and DataGridView to reflect the deletion

                dgcash.DataSource = tempds.Tables("CashierTB")
                tempds.Tables("CashierTB").Clear()

                ' Reset totals and inputs
                ResetForm()


            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

            Exit Sub
        End If

    End Sub
    Sub ResetForm()
        xGTotal = 0
        TxtItId.Clear()
        lbldisplay1.Text = ""
        lbltotal.Text = ""
        Txtamt.Clear()
        Txtamt.Text = "0.00"
        lblchange.Text = ""
        lbldesc.Text = ""
        lbl_ItemName.Text = ""
    End Sub
    Sub CheckAmt()
        ' Attempt to convert Txtamt.Text to Decimal
        If Not Decimal.TryParse(Txtamt.Text.Trim(), amtValue) Then
            MsgBox("Please enter a valid amount.", MsgBoxStyle.Exclamation, "Invalid Input")
            Txtamt.Focus()
            Exit Sub
        End If

        ' Attempt to convert lbldisplay1.Text to Decimal
        If Not Decimal.TryParse(lbldisplay1.Text.Trim(), displayValue) Then
            MsgBox("The displayed value is not valid.", MsgBoxStyle.Exclamation, "Invalid Display Value")
            Exit Sub
        End If

        ' Compare values now that they are confirmed as valid decimals
        If amtValue < displayValue Then
            MsgBox("It seems the amount entered is insufficient for this item. Please try again.", MsgBoxStyle.Exclamation, "Insufficient Amount")
            Txtamt.Text = ""
            Txtamt.Focus()

            Exit Sub
        End If

    End Sub

    Sub subtractAmt()

        ' Proceed with further operations
        Try
            lblchange.Text = (amtValue - displayValue).ToString("N2") ' Calculate 
            displayChange = lblchange.Text
            Txtamt.Text = Format(amtValue, "Standard")
            lbldisplay1.Text = Format(displayValue, "Standard")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub InsertTrans()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            temp = New OleDb.OleDbDataAdapter("SELECT [Item ID],[ItemName],[Quantity],[UnitPrice],[Total] FROM  CashierTB", conn)
            tempds = New DataSet()
            temp.Fill(tempds, "CashierTB")
            trec = tempds.Tables("CashierTB").Rows.Count - 1
            recpoint = 0

            ' Loop through each item in CashierTB and update the stock in TblStock
            ' Import data in Trans
            For Each row As DataRow In tempds.Tables("CashierTB").Rows

                xin = row("Item ID").ToString()
                xDesc = row("ItemName").ToString()
                xqty = row("Quantity").ToString()
                xUP = row("UnitPrice").ToString()
                xtotal = row("Total").ToString()
                xtime = Format(Now, "dd MMMM, yyyy hh:mm:ss tt")


                cm = New OleDbCommand("UPDATE CashierTB SET [Amount] = @Amount, [Change] = @Change WHERE [Item ID] = @ItemID", conn)
                cm.Parameters.AddWithValue("@Amount", amtValue)
                cm.Parameters.AddWithValue("@Change", displayChange)
                cm.Parameters.AddWithValue("@ItemID", xin)
                cm.ExecuteNonQuery()

                ' Insert data into Trans table
                cm = New OleDb.OleDbCommand("INSERT INTO Trans ([Item ID],[Item Name],[Quantity],[UnitPrice],[Total],[Time Transaction],[Cashier Name]) VALUES (@ItemID,@ItemName,@Quantity,@UnitPrice,@Total,@TimeTrans,@CashierName)", conn)
                cm.Parameters.AddWithValue("@ItemID", xin)
                cm.Parameters.AddWithValue("@ItemName", xDesc)
                cm.Parameters.AddWithValue("@Quantity", xqty)
                cm.Parameters.AddWithValue("@UnitPrice", xUP)
                cm.Parameters.AddWithValue("@Total", xtotal)
                cm.Parameters.AddWithValue("@TimeTrans", xtime)
                cm.Parameters.AddWithValue("@CashierName", xname)
                cm.ExecuteNonQuery()





                ' Retrieve stock quantity from TblStock
                abs = New OleDb.OleDbDataAdapter("SELECT [Quantity] FROM TblStock WHERE [ItemID] = @ItemID", conn)
                abs.SelectCommand.Parameters.AddWithValue("@ItemID", xin)
                ds = New DataSet()
                abs.Fill(ds, "TblStock")

                If ds.Tables("TblStock").Rows.Count > 0 Then
                    stocksqty = Convert.ToInt32(ds.Tables("TblStock").Rows(0)("Quantity"))
                    stocksqty = stocksqty - xqty

                    'Checking quantity if exceeds the available stocks
                    If stocksqty < 0 Then
                        MsgBox("Insufficient stock! The requested quantity exceeds available stock.", MsgBoxStyle.Exclamation, "Stock Warning")
                        lbldisplay1.Text = ""
                        Txtamt.Text = ""
                        lblchange.Text = ""
                        Exit Sub
                    Else


                        ' Update stock quantity in TblStock
                        cm = New OleDb.OleDbCommand("UPDATE TblStock SET [Quantity] = @NewQty WHERE [ItemID] = @ItemID", conn)
                        cm.Parameters.AddWithValue("@NewQty", stocksqty)
                        cm.Parameters.AddWithValue("@ItemID", xin)
                        cm.ExecuteNonQuery()
                    End If
                End If



            Next

            ' Notify the user of a successful transaction
            MsgBox("Transaction successful!", MsgBoxStyle.Information, "Success")
            Resibo.Show()






            ' Refresh stock display after the transaction
            sqlstckquery()

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub
    Private Sub Txtamt_TextChanged(sender As Object, e As EventArgs) Handles Txtamt.TextChanged
        lblchange.Text = "0.00"

        ' Attempt to convert Txtamt.Text to Decimal
        If Not Decimal.TryParse(Txtamt.Text.Trim(), amtValue) Then
            Return
        End If

        ' Attempt to convert lbldisplay1.Text to Decimal
        If Not Decimal.TryParse(lbldisplay1.Text.Trim(), displayValue) Then
            lblchange.Text = "0.00" ' Reset change if display value is invalid
            Return
        End If

        ' Compare values 
        If amtValue < displayValue Then
            ' If the amount entered is insufficient, show a default change of "0.00"
            lblchange.Text = "0.00"
            Return
        End If
        lblchange.Text = (amtValue - displayValue).ToString("N2")
        displayChange = lblchange.Text
        Txtamt.Text = Format(amtValue, "Standard")
        lbldisplay1.Text = Format(displayValue, "Standard")
    End Sub
    Private Sub mnupulstcash_Click(sender As Object, e As EventArgs) Handles mnupulstcash.Click
        Dim xport As New Cashierprnt()
        xport.ExportCashierAndOpenExcel(Application.StartupPath & "\Excel\Sales.xlsx", "MINAS BOARD-TAP STORE ", "DAILY SALES REPORT")
    End Sub

    Private Sub MNUCLOSE3_Click(sender As Object, e As EventArgs) Handles MNUCLOSE3.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close this window? The next user will be required to log in. Do you want to proceed?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Log Off Confirmation")

        If Result = MsgBoxResult.Yes Then
            If xpriv = "User" And xpost = "Cashier" Then
                Me.Close()
                Category.Close()
                Loginfrm.Show()
                Loginfrm.Txt_Un.Focus()

            Else
                Me.Close()
                Category.Show()

            End If

            Exit Sub
        End If
    End Sub
    Sub report()
        Try


            Dim crystal As CrystalReport2 = Nothing
            Try
                crystal = New CrystalReport2()
                crystal.Load(Application.StartupPath & "\Reports\CrystalReport2.rpt")
                SetDatabaseLogon(crystal, Application.StartupPath & "\DataBase2\JeoffDB.mdb", "", "", "")

                crystal.PrintOptions.NoPrinter = True ' Prevent page break due to printer settings

                crystal.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                crystal.PrintToPrinter(1, False, 0, 0)
                Resibo.CrystalReportViewer1.ReportSource = crystal
                Resibo.CrystalReportViewer1.RefreshReport()

            Catch ex As Exception
                MessageBox.Show("Error loading report: " & ex.Message)
            Finally
                ' Check if crystal is not null before attempting to close or disposes
                If crystal IsNot Nothing Then
                    crystal.Close()

                End If
            End Try
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)

        End Try
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

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If recpoint < dgcash.Rows.Count - 1 Then
            ' Deselect the current row
            dgcash.Rows(recpoint).Selected = False

            ' Move to the next row
            recpoint += 1

            ' Select the next row
            dgcash.Rows(recpoint).Selected = True

            ' Ensure the selected row is visible
            dgcash.FirstDisplayedScrollingRowIndex = recpoint

            lbl_ItemName.Text = dgcash.Rows(recpoint).Cells("ItemName").Value.ToString()

            TxtItId.Text = dgcash.Rows(recpoint).Cells("Item ID").Value.ToString()
        Else
            MessageBox.Show("No more records to navigate.", "End of Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevToolStripMenuItem.Click
        If recpoint > 0 Then
            ' Deselect the current row
            dgcash.Rows(recpoint).Selected = False

            ' Move to the previous row
            recpoint -= 1

            ' Select the previous row
            dgcash.Rows(recpoint).Selected = True

            ' Ensure the selected row is visible
            dgcash.FirstDisplayedScrollingRowIndex = recpoint

            lbl_ItemName.Text = dgcash.Rows(recpoint).Cells("ItemName").Value.ToString()

            TxtItId.Text = dgcash.Rows(recpoint).Cells("Item ID").Value.ToString()

        Else
            MessageBox.Show("You are already at the first record.", "Beginning of Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try

            If MsgBox(" The item will be deleted permanently! Do you want to delete this item?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
                conn.Open()
                cm = New OleDb.OleDbCommand("DELETE * FROM CashierTB WHERE [Item ID] = @ItemID ", conn)
                cm.Parameters.AddWithValue("@ItemID", TxtItId.Text.Trim)
                cm.ExecuteNonQuery()

                temp = New OleDb.OleDbDataAdapter("SELECT SUM([Total]) AS xt FROM CashierTB", conn)
                tempds = New DataSet()
                temp.Fill(tempds, "CashierTB")

                DisplaySum()


                sqlquerytemp()
                dgcash.DataSource = tempds.Tables("CashierTB")
           

            End If
            MsgBox("The data has been deleted in the database successfully...", MsgBoxStyle.Information, "Deleted")
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Txtqnty_TextChanged(sender As Object, e As EventArgs) Handles Txtqnty.TextChanged
        Dim quantity As Single

        Try
            ' Attempt to parse the quantity from the text input
            If Single.TryParse(Txtqnty.Text.Trim(), quantity) Then
                xGTotal = CDbl(xUP) * quantity
                lbltotal.Text = Format(xGTotal, "Standard")
            Else
                ' If parsing fails, reset the total or display an appropriate message
                lbltotal.Text = "0.00" ' or keep it empty
            End If
        Catch ex As Exception
            ' Optional: log the exception or handle it in some way
            lbltotal.Text = "0.00" ' or keep it empty
        End Try
    End Sub

    Private Sub CrystalReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrystalReportsToolStripMenuItem.Click
        With ReportSales

            .ShowDialog()
        End With



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgcash_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcash.CellContentClick

    End Sub

    Private Sub TxtItId_TextChanged(sender As Object, e As EventArgs) Handles TxtItId.TextChanged

    End Sub
End Class
