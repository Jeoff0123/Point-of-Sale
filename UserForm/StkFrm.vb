Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class StkFrm
    Private Sub StkFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        lblnm3.Text = xname
        Timer4.Interval = 1000
        Timer4.Start()

        openstckdb()
        sqlstckquery()

        Dg2.DataSource = ds.Tables("TblStock")

        lnklbl2.Visible = False


        MNUSAVE2.Enabled = False
        MNUDEL2.Enabled = False
        MNU_SRCH2.Enabled = True
        MNUEDIT2.Enabled = True
        Txt_Disabled()
        Txt_Lock()

        Dg2.Enabled = False
        'GetPrivilege()

    End Sub

    Sub GetPrivilege()
        If Loginfrm.a = "Stockman" Or Loginfrm.a = "STOCKMAN" Then
            MNUADD2.Enabled = False
            MNUDEL2.Enabled = False
            MNUEDIT2.Enabled = False

        End If
    End Sub

    Sub Txt_Clear()
        Txt_Qnty.Text = ""
        Txt_BPR.Text = ""
        Txt_SP.Text = ""
        Txt_Crit.Text = ""

    End Sub

    Sub Txt_Lock()
        Txt_ItemID.ReadOnly = True
        Txt_PrNm.ReadOnly = True
        Txt_Dsrp.ReadOnly = True
        Txt_Qnty.ReadOnly = True
        Txt_BPR.ReadOnly = True
        Txt_SP.ReadOnly = True
        Txt_Crit.ReadOnly = True

    End Sub

    Sub Txt_UnLock()
        Txt_ItemID.ReadOnly = False
        Txt_PrNm.ReadOnly = False
        Txt_Dsrp.ReadOnly = False
        Txt_Qnty.ReadOnly = False
        Txt_BPR.ReadOnly = False
        Txt_SP.ReadOnly = False
        Txt_Crit.ReadOnly = False

    End Sub

    Sub Txt_Enabled()
        Txt_ItemID.Enabled = True
        Txt_PrNm.Enabled = True
        Txt_Dsrp.Enabled = True
        Txt_Qnty.Enabled = True
        Txt_BPR.Enabled = True
        Txt_SP.Enabled = True
        Txt_Crit.Enabled = True
    End Sub

    Sub Txt_Disabled()
        Txt_ItemID.Enabled = False
        Txt_PrNm.Enabled = False
        Txt_Dsrp.Enabled = False
        Txt_Qnty.Enabled = False
        Txt_BPR.Enabled = False
        Txt_SP.Enabled = False
        Txt_Crit.Enabled = False
    End Sub

    Private Sub MNUADD2_Click(sender As Object, e As EventArgs) Handles MNUADD2.Click
        sw = True
        conn.Close()
        Txt_Enabled()
        Txt_ItemID.Focus()
        Txt_UnLock()
        Txt_Clear()
        Txt_ItemID.Clear()
        Txt_PrNm.Clear()
        Txt_Dsrp.Clear()
        lnklbl2.Visible = True
        MNUADD2.Enabled = False
        MNUSAVE2.Enabled = True
        MNUDEL2.Enabled = False
        MNU_SRCH2.Enabled = False
        MNUEDIT2.Enabled = False
        idpic2.Image = Nothing



    End Sub

    Sub TxtDisplay()
        Try
            Txt_ItemID.Text = ds.Tables("TblStock").Rows(recpoint).Item("ItemID")
            Txt_PrNm.Text = ds.Tables("TblStock").Rows(recpoint).Item("ItemName")
            Txt_Dsrp.Text = ds.Tables("TblStock").Rows(recpoint).Item("ItemDescription")
            Txt_Qnty.Text = ds.Tables("TblStock").Rows(recpoint).Item("Quantity")
            Txt_BPR.Text = ds.Tables("TblStock").Rows(recpoint).Item("BuyingPrice")
            Txt_SP.Text = ds.Tables("TblStock").Rows(recpoint).Item("SellingPrice")
            Txt_Crit.Text = ds.Tables("TblStock").Rows(recpoint).Item("Critical")


            If Convert.ToInt64(Txt_Qnty.Text) <= Convert.ToInt64(Txt_Crit.Text) Then

                If Txt_Qnty.Text = 0 Then
                    MessageBox.Show("Out of Stocks!" + vbCrLf + "Please Re-Stocks Immediately!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else

                    MessageBox.Show("Low in Stocks!" + vbCrLf + "Please Re-Stocks as soon as possible!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

            End If


        Catch ex As Exception
            MessageBox.Show("Error displaying data: " & ex.Message)
        End Try
    End Sub


    Private Sub MNUSAVE2_Click(sender As Object, e As EventArgs) Handles MNUSAVE2.Click


        If Not IsNumeric(Txt_Qnty.Text.Trim) OrElse Not IsNumeric(Txt_BPR.Text.Trim) OrElse Not IsNumeric(Txt_SP.Text.Trim) Then
            MsgBox("Please enter a valid Item ID. Thank you.", MsgBoxStyle.Exclamation, "Valid Item ID Required")
            Txt_Qnty.Clear()
            Txt_SP.Clear()
            Txt_BPR.Clear()
            Txt_Qnty.Focus()
            Return
        End If

        Try
            If sw = True Then

                If MsgBox("The data are now being stored in the database...", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                    conn.Open()
                    cm = New OleDb.OleDbCommand("INSERT INTO TblStock([ItemID],[ItemName],[ItemDescription],[Quantity],[BuyingPrice],[SellingPrice],[Critical]) VALUES (@ItemID,@ItemName,@ItemDescription,@Quantity,@BuyingPrice,@SellingPrice,@Critical)", conn)
                    cm.Parameters.AddWithValue("@ItemID", Txt_ItemID.Text.Trim)
                    cm.Parameters.AddWithValue("@ItemName", Txt_PrNm.Text.Trim)
                    cm.Parameters.AddWithValue("@ItemDescription", Txt_Dsrp.Text.Trim)
                    cm.Parameters.AddWithValue("@Quantity", Txt_Qnty.Text.Trim)
                    cm.Parameters.AddWithValue("@BuyingPrice", Txt_BPR.Text.Trim)
                    cm.Parameters.AddWithValue("@SellingPrice", Txt_SP.Text.Trim)
                    cm.Parameters.AddWithValue("@Critical", Txt_Crit.Text.Trim)

                    cm.ExecuteNonQuery()
                    sqlstckquery()
                    Txt_Lock()
                    gbdg2.Visible = True
                    Dg2.Enabled = True
                    Dg2.DataSource = ds.Tables("TblStock")
                Else
                    Txt_PrNm.Focus()
                End If
            End If

            If sw = False Then
                If MsgBox("Do you want to save the changes you made to the database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                    conn.Open()

                    cm = New OleDb.OleDbCommand("UPDATE TblStock SET [Quantity] = @Quantity, [BuyingPrice] = @BuyingPrice, [SellingPrice] = @SellingPrice, [Critical] = @Critical WHERE [ItemID] = @ItemID", conn)
                    cm.Parameters.AddWithValue("@Quantity", Txt_Qnty.Text.Trim)
                    cm.Parameters.AddWithValue("@BuyingPrice", Txt_BPR.Text.Trim)
                    cm.Parameters.AddWithValue("@SellingPrice", Txt_SP.Text.Trim)
                    cm.Parameters.AddWithValue("@Critical", Txt_Crit.Text.Trim)
                    cm.Parameters.AddWithValue("@ItemID", Txt_ItemID.Text.Trim)

                    cm.ExecuteNonQuery()
                    sqlstckquery()
                    Txt_Lock()
                    gbdg2.Visible = True
                    Dg2.Enabled = True
                    Dg2.DataSource = ds.Tables("TblStock")
                Else
                    Txt_ItemID.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error saving data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub MNUEDIT2_Click(sender As Object, e As EventArgs) Handles MNUEDIT2.Click
        sw = False
        Txt_Enabled()
        Txt_UnLock()
        Txt_Clear()
        Txt_ItemID.Enabled = False
        Txt_PrNm.Enabled = False
        Txt_Dsrp.Enabled = False
        lnklbl2.Visible = True
        MNUSAVE2.Enabled = True
        MNU_SRCH2.Enabled = False
        MNUEDIT2.Enabled = False

    End Sub

    Private Sub MNUFIRST_Click(sender As Object, e As EventArgs) Handles MNUFIRST.Click
        Dg2.Rows(recpoint).Selected = False
        recpoint = 0

        Dg2.Rows(recpoint).Selected = True
        Dg2.FirstDisplayedScrollingRowIndex = recpoint
        Txt_Disabled()
        TxtDisplay()
        Try
            idpic2.ImageLocation = ""
            idpic2.Refresh()
            idpic2.ImageLocation = Application.StartupPath & "\Picture\" & Txt_PrNm.Text.Trim & ".jpg"
            idpic2.Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MNYNEXT_Click(sender As Object, e As EventArgs) Handles MNYNEXT.Click
        If recpoint < trec Then
            Dg2.Rows(recpoint).Selected = False
            recpoint = recpoint + 1

            Dg2.Rows(recpoint).Selected = True
            Dg2.FirstDisplayedScrollingRowIndex = recpoint
            Txt_Disabled()
            TxtDisplay()
            Try
                idpic2.ImageLocation = ""
                idpic2.Refresh()
                idpic2.ImageLocation = Application.StartupPath & "\Picture\" & Txt_PrNm.Text.Trim & ".jpg"
                idpic2.Load()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub MNUPREV_Click(sender As Object, e As EventArgs) Handles MNUPREV.Click
        If recpoint > 0 Then
            Dg2.Rows(recpoint).Selected = False
            recpoint = recpoint - 1

            Dg2.Rows(recpoint).Selected = True
            Dg2.FirstDisplayedScrollingRowIndex = recpoint
            Txt_Disabled()
            TxtDisplay()

            Try
                idpic2.ImageLocation = ""
                idpic2.Refresh()
                idpic2.ImageLocation = Application.StartupPath & "\Picture\" & Txt_PrNm.Text.Trim & ".jpg"
                idpic2.Load()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub MNULAST_Click(sender As Object, e As EventArgs) Handles MNULAST.Click
        Dg2.Rows(recpoint).Selected = False
        recpoint = trec

        Dg2.Rows(recpoint).Selected = True
        Dg2.FirstDisplayedScrollingRowIndex = recpoint
        Txt_Disabled()
        TxtDisplay()
        Try
            idpic2.ImageLocation = ""
            idpic2.Refresh()
            idpic2.ImageLocation = Application.StartupPath & "\Picture\" & Txt_PrNm.Text.Trim & ".jpg"
            idpic2.Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MNU_SRCH2_Click(sender As Object, e As EventArgs) Handles MNU_SRCH2.Click

        Dim z As String
        z = InputBox("Enter Item Name to Search")

        If String.IsNullOrEmpty(z) Then ' Check for empty search string
            MsgBox("Please enter a Item Name to search.", MsgBoxStyle.Information)
            Return ' Exit the function
        End If

        Try
            conn.Open()

            stck = New OleDb.OleDbDataAdapter("SELECT [ItemID],[ItemName],[ItemDescription],[Quantity],[BuyingPrice],[SellingPrice],[Critical] FROM TblStock WHERE [ItemName] LIKE @ItemName", conn)
            stck.SelectCommand.Parameters.AddWithValue("@ItemName", "%" & z & "%")

            ds = New DataSet
            stck.Fill(ds, "TblStock")

            If ds.Tables("TblStock").Rows.Count > 0 Then
                recpoint = 0
                trec = ds.Tables("TblStock").Rows.Count - 1
                Dg2.DataSource = ds.Tables("TblStock")
            Else
                MsgBox("No records found for the specified Item Name in database.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()  ' Close connection even on errors
        End Try


    End Sub

    Private Sub MNUDEL2_Click(sender As Object, e As EventArgs) Handles MNUDEL2.Click
        Try

            If MsgBox(" The file will be deleted permanently! Do you want to delete this file?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
                conn.Open()
                cm = New OleDb.OleDbCommand("DELETE FROM TblStock WHERE [ItemID] = @ItemID ", conn)
                cm.Parameters.AddWithValue("@ItemID", Txt_ItemID.Text.Trim)
                cm.ExecuteNonQuery()
                sqlstckquery()
                Dg2.DataSource = ds.Tables("TblStock")
                Txt_Clear()

            End If
            MsgBox("The data has been deleted in the database successfully...", MsgBoxStyle.Information, "Deleted")
        Catch ex As Exception


        End Try




    End Sub

    Private Sub MNUCNCL2_Click(sender As Object, e As EventArgs) Handles MNUCNCL2.Click
        gbtxt.Visible = True
        Dg2.Enabled = True
        Txt_Lock()
        MNUADD2.Enabled = True
        MNUDEL2.Enabled = True
        MNU_SRCH2.Enabled = True
        MNUEDIT2.Enabled = True
        MNUSAVE2.Enabled = False
        lnklbl2.Visible = False


        sqlstckquery()
        Dg2.DataSource = ds.Tables("TblStock")
        Dg2.Enabled = True
        Txt_Clear()
        Txt_ItemID.Clear()
        Txt_PrNm.Clear()
        Txt_Dsrp.Clear()
    End Sub

    Private Sub MNUCLOSE2_Click(sender As Object, e As EventArgs) Handles MNUCLOSE2.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close this window? The next user will be required to log in. Do you want to proceed?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Log Off Confirmation")

        If Result = MsgBoxResult.Yes Then
            If xpriv = "User" And xpost = "Stockman" Then
                Me.Close()
                Category.Close()
                Loginfrm.Show()
                Loginfrm.Txt_Un.Focus()
                lblnm3.Text = ""

            Else

                Me.Close()
                Category.Show()
                Report.Close()




            End If

        End If



    End Sub

    Private Sub lnklbl2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl2.LinkClicked
        If Txt_PrNm.Text.Trim.Length > 0 Then
            OFD2.FileName = ""
            idpic2.Image = Nothing

            If OFD2.ShowDialog = DialogResult.OK Then
                Try
                    ' Allow multiple image formats in the file dialog
                    OFD2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"

                    ' Ensure the Picture folder exists
                    Dim pictureFolder As String = Application.StartupPath & "\Picture\"
                    If Not IO.Directory.Exists(pictureFolder) Then
                        IO.Directory.CreateDirectory(pictureFolder)
                    End If

                    ' Get the original file's extension
                    Dim fileExt As String = IO.Path.GetExtension(OFD2.FileName)

                    ' Build the destination path with the correct extension
                    Dim destPath As String = IO.Path.Combine(pictureFolder, Txt_PrNm.Text.Trim & fileExt)

                    ' Copy the file and overwrite if it exists
                    My.Computer.FileSystem.CopyFile(OFD2.FileName, destPath, True)

                    ' Display the image in the PictureBox
                    idpic2.ImageLocation = destPath

                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If

        Else
            MsgBox("Please enter a Item Name!.", MsgBoxStyle.Information, "Reminder!!!")
        End If
    End Sub

    Private Sub Dg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg2.CellContentClick

    End Sub

    Private Sub Dg2_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dg2.RowEnter
        recpoint = e.RowIndex
        TxtDisplay()
        Try
            idpic2.ImageLocation = ""
            idpic2.Refresh()
            idpic2.ImageLocation = Application.StartupPath & "\Picture\" & Txt_PrNm.Text.Trim & ".jpg"
            idpic2.Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MNUPITLST_Click(sender As Object, e As EventArgs) Handles MNUPITLST.Click
        Dim xport As New Class1()
        xport.ExportItemListAndOpenExcel(Application.StartupPath & "\Excel\Itemlist.xlsx", "MINAS BOARD-TAP STORE ", "ITEM LIST REPORT")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        lbltime.Text = Format(Now, "dd MMMM, yyyy hh:mm:ss tt")
    End Sub

    Private Sub MNUCrystal_Click(sender As Object, e As EventArgs) Handles MNUCrystal.Click
        Form2.Show()
        Me.Close()



    End Sub


End Class