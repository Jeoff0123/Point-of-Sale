

Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class UsFrm



    Private Sub UsFrm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        lblnm.Text = xname
        Timer3.Interval = 1000
        Timer3.Start()



        opendb()
        sqlquery()


        Dg.DataSource = ds.Tables("DataBaseTB")
        Dg.Enabled = False
        LinkLabel1.Visible = False
        cmb_txt1.Enabled = False
        Txt_Pr.Visible = True
        cmb_txt1.Visible = False
        LBL_Txt.Visible = True
        Lbl.Visible = False
        Txt_Pr.Enabled = False
        Txt_UserName.Focus()

        Txt_UserName.Focus()
        MNUSAVE.Enabled = False
        MNUDEL.Enabled = False
        MNU_SRCH.Enabled = True
        MNUEDIT.Enabled = False

        lock()


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lbldate.Text = Format(Now, "dd MMMM, yyyy hh:mm:ss tt")
    End Sub
    'For Disabling Variables'
    Sub TextDisabled()
        Txt_UserName.Enabled = False
        Txt_Position.Enabled = False
        Txt_Pr.Enabled = False
        Txt_pw.Enabled = False
        Txt_rpw.Enabled = False
        LBL_Txt.Enabled = False
        cmb_txt1.Enabled = False

    End Sub

    'For Enabling Variables
    Sub TxtEnabled()
        Txt_UserName.Enabled = True
        Txt_Position.Enabled = True
        Txt_Pr.Enabled = True
        Txt_pw.Enabled = True
        Txt_rpw.Enabled = True
        LBL_Txt.Enabled = True
        cmb_txt1.Enabled = True
    End Sub

    'For clearing textboxes
    Sub Txtclear()

        Txt_UserName.Text = ""
        Txt_Position.Text = ""
        Txt_Pr.Text = ""
        Txt_pw.Text = ""
        Txt_rpw.Text = ""
        cmb_txt1.Text = ""

    End Sub

    'For Read Only
    Sub lock()

        Txt_UserName.ReadOnly = True
        Txt_Position.ReadOnly = True
        Txt_Pr.ReadOnly = True
        Txt_pw.ReadOnly = True
        Txt_rpw.ReadOnly = True

    End Sub
    'For Unread Only
    Sub unlock()

        Txt_UserName.ReadOnly = False
        Txt_Position.ReadOnly = False
        Txt_Pr.ReadOnly = False
        Txt_pw.ReadOnly = False
        Txt_rpw.ReadOnly = False
    End Sub

    'For displaying the connected database in DataGridView
    Sub display()
        Try
            LBL_Txt.Text = CInt(ds.Tables("DataBaseTB").Rows(recpoint).Item("UserID")).ToString("D4")
            Txt_UserName.Text = ds.Tables("DataBaseTB").Rows(recpoint).Item("UserName")
            Txt_Position.Text = ds.Tables("DataBaseTB").Rows(recpoint).Item("Position")
            cmb_txt1.Text = ds.Tables("DataBaseTB").Rows(recpoint).Item("Privilege")
            Txt_Pr.Text = ds.Tables("DataBaseTB").Rows(recpoint).Item("Privilege")

        Catch ex As Exception
            MessageBox.Show("Error displaying data: " & ex.Message)
        End Try
    End Sub


    'This Close Function is for closing the window
    Private Sub MNUCLOSE_Click(sender As Object, e As EventArgs) Handles MNUCLOSE.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close the window?", MsgBoxStyle.YesNo, "Closing...")

        If Result = MsgBoxResult.Yes Then



            Me.Close()
            Category.Show()
            Report.Close()



        End If

    End Sub


    Private Sub MNUADD_Click(sender As Object, e As EventArgs) Handles MNUADD.Click
        sw = True
        conn.Close()
        TxtEnabled()
        LBL_Txt.Visible = True
        LBL_Txt.Text = CInt((ds.Tables("DataBaseTB").Rows(ds.Tables("DataBaseTB").Rows.Count - 1).Item("UserID")) + 1).ToString("D4")
        idpic.Image = Nothing
        Lbl.Visible = True
        cmb_txt1.Visible = True
        cmb_txt1.Enabled = True
        LinkLabel1.Visible = True
        Dg.Enabled = False
        MNUADD.Enabled = False
        MNUSAVE.Enabled = True
        MNUDEL.Enabled = False
        MNU_SRCH.Enabled = False
        MNUEDIT.Enabled = False

        unlock()
        Txt_UserName.Focus()
        Txtclear()

    End Sub

    Private Sub MNUEDIT_Click(sender As Object, e As EventArgs) Handles MNUEDIT.Click
        sw = False

        Txt_pw.Focus()
        Txt_UserName.Enabled = False
        Txt_Position.Enabled = False
        Txt_pw.ReadOnly = False
        Txt_rpw.ReadOnly = False
        Txt_pw.Clear()
        Txt_rpw.Clear()
        Txt_pw.Enabled = True
        Txt_rpw.Enabled = True
        gbPw.Visible = True
        Dg.Enabled = False

        MNUSAVE.Enabled = True
        MNU_SRCH.Enabled = False
        MNUEDIT.Enabled = False
        cmb_txt1.Visible = True
        cmb_txt1.Enabled = False
        gbIdUn.Visible = True
        LinkLabel1.Visible = False


    End Sub

    Private Sub Txt_Pr_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MNUFIRST_Click_1(sender As Object, e As EventArgs) Handles MNUFIRST.Click
        Dg.Rows(recpoint).Selected = False
        recpoint = 0

        Dg.Rows(recpoint).Selected = True
        Dg.FirstDisplayedScrollingRowIndex = recpoint
        LBL_Txt.Visible = True
        Lbl.Visible = True
        TextDisabled()
        display()
        Try
            idpic.ImageLocation = ""
            idpic.Refresh()
            idpic.ImageLocation = Application.StartupPath & "\images\" & Txt_UserName.Text.Trim & ".jpg"
            idpic.Load()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub MNYNEXT_Click(sender As Object, e As EventArgs) Handles MNYNEXT.Click
        If recpoint < trec Then
            Dg.Rows(recpoint).Selected = False
            recpoint = recpoint + 1

            Dg.Rows(recpoint).Selected = True
            Dg.FirstDisplayedScrollingRowIndex = recpoint
            LBL_Txt.Visible = True
            Lbl.Visible = True
            TextDisabled()
            display()
            Try
                idpic.ImageLocation = ""
                idpic.Refresh()
                idpic.ImageLocation = Application.StartupPath & "\images\" & Txt_UserName.Text.Trim & ".jpg"
                idpic.Load()


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MNUPREV_Click(sender As Object, e As EventArgs) Handles MNUPREV.Click
        If recpoint > 0 Then
            Dg.Rows(recpoint).Selected = False
            recpoint = recpoint - 1

            Dg.Rows(recpoint).Selected = True
            Dg.FirstDisplayedScrollingRowIndex = recpoint
            LBL_Txt.Visible = True
            Lbl.Visible = True
            TextDisabled()
            display()
            Try
                idpic.ImageLocation = ""
                idpic.Refresh()
                idpic.ImageLocation = Application.StartupPath & "\images\" & Txt_UserName.Text.Trim & ".jpg"
                idpic.Load()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MNULAST_Click(sender As Object, e As EventArgs) Handles MNULAST.Click
        Dg.Rows(recpoint).Selected = False
        recpoint = trec

        Dg.Rows(recpoint).Selected = True
        Dg.FirstDisplayedScrollingRowIndex = recpoint
        LBL_Txt.Visible = True
        Lbl.Visible = True
        TextDisabled()
        display()
        Try
            idpic.ImageLocation = ""
            idpic.Refresh()
            idpic.ImageLocation = Application.StartupPath & "\images\" & Txt_UserName.Text.Trim & ".jpg"

            idpic.Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MNUSAVE_Click(sender As Object, e As EventArgs) Handles MNUSAVE.Click

        'This if-statement is for to prevent the user to save an empty/blank table in database
        If String.IsNullOrEmpty(Txt_pw.Text.Trim) OrElse String.IsNullOrEmpty(Txt_rpw.Text.Trim) Then
            MsgBox("The form must be filled out first before inserting a data!", MsgBoxStyle.Critical)
            Return
        End If
        Try

            If Txt_pw.Text.Trim = Txt_rpw.Text.Trim Then




                If sw = True Then
                    If MsgBox("The data are now being stored in the database... Do you want to continue?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Saving...") = MsgBoxResult.Yes Then

                        conn.Open()

                        cm = New OleDb.OleDbCommand("INSERT INTO DataBaseTB([UserName],[Position],[Password],[Privilege]) VALUES (@UserName, @Password, @Position, @Privilege)", conn)
                        cm.Parameters.AddWithValue("@UserName", Txt_UserName.Text.Trim)
                        cm.Parameters.AddWithValue("@Position", Txt_Position.Text.Trim)
                        cm.Parameters.AddWithValue("@Password", Txt_pw.Text.Trim)
                        cm.Parameters.AddWithValue("@Privilege", cmb_txt1.Text.Trim)

                        cm.ExecuteNonQuery()
                        sqlquery()
                        lock()
                        gbPw.Visible = True
                        gbdg.Visible = True
                        Dg.Enabled = True
                        cmb_txt1.Enabled = False
                        Dg.DataSource = ds.Tables("DataBaseTB")

                        MsgBox("The data has been stored in the database successfully...", MsgBoxStyle.Information, "Saved")

                    Else
                        Txt_UserName.Focus()


                    End If
                End If



                If sw = False Then

                    If MsgBox("Do you want to save the changes you made to its database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                        conn.Open()


                        cm = New OleDb.OleDbCommand("UPDATE DataBaseTB SET [Password] = @Password WHERE [UserID] = @UserID", conn)
                        cm.Parameters.AddWithValue("@Password", Txt_pw.Text.Trim)
                        cm.Parameters.AddWithValue("@UserID", LBL_Txt.Text.Trim)



                        cm.ExecuteNonQuery()
                        sqlquery()
                        lock()

                        gbPw.Visible = True
                        gbdg.Visible = True
                        Dg.Enabled = True
                        cmb_txt1.Enabled = False
                        LinkLabel1.Visible = False
                        Dg.DataSource = ds.Tables("DataBaseTB")

                        MsgBox("The data has been stored in the databas successfully...", MsgBoxStyle.Information, "Saved")

                    End If
                    gbPw.Focus()
                End If

            Else
                MsgBox("Please re-type your password correctly!!!", , "reminder!!!")
                Txt_pw.Focus()
                Txt_pw.Clear()
                Txt_rpw.Clear()
            End If
        Catch ex As Exception

            MsgBox("Error saving data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()

        End Try
    End Sub
    Private Sub MNUCNCL_Click(sender As Object, e As EventArgs) Handles MNUCNCL.Click
        gbIdUn.Visible = True
        gbPw.Visible = True
        gbdg.Visible = True


        lock()


        MNUADD.Enabled = True
        MNUDEL.Enabled = True
        MNU_SRCH.Enabled = True
        MNUEDIT.Enabled = True
        MNUSAVE.Enabled = False
        cmb_txt1.Visible = False
        cmb_txt1.Enabled = False
        Txt_Pr.Visible = False
        cmb_txt1.Visible = True
        LinkLabel1.Visible = False


        sqlquery()
        Dg.DataSource = ds.Tables("DataBaseTB")
        Dg.Enabled = True
        Txtclear()
    End Sub



    Private Sub MNU_SRCH_Click(sender As Object, e As EventArgs) Handles MNU_SRCH.Click

        Dim z As String
        z = InputBox("Enter User ID to Search")

        If String.IsNullOrEmpty(z) Then ' Check for empty search string
            MsgBox("Please enter a user ID to search.", MsgBoxStyle.Information)
            Return ' Exit the function
        End If

        If z.Length > 1 Then
            Try
                conn.Open()

                abs = New OleDb.OleDbDataAdapter("SELECT [UserID],[UserName],[Position],[Privilege] FROM DataBaseTB WHERE [UserID] = @UserID", conn)
                abs.SelectCommand.Parameters.AddWithValue("@UserID", z)

                ds = New DataSet
                abs.Fill(ds, "DataBaseTB")

                If ds.Tables("DataBaseTB").Rows.Count > 0 Then
                    recpoint = 0
                    trec = ds.Tables("DataBaseTB").Rows.Count - 1
                    Dg.DataSource = ds.Tables("DataBaseTB")
                Else
                    MsgBox("No records found for the specified User ID.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()  ' Close connection even on errors
            End Try
        End If

    End Sub

    Private Sub MNUDEL_Click(sender As Object, e As EventArgs) Handles MNUDEL.Click
        If MsgBox(" The file on the DataBaseTB will be deleted permanently! Do you want to delete this file?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
            conn.Open()
            cm = New OleDb.OleDbCommand("DELETE FROM DataBaseTB WHERE [UserID] = @UserID ", conn)
            cm.Parameters.AddWithValue("@UserID", LBL_Txt.Text.Trim)
            cm.ExecuteNonQuery()
            sqlquery()
            Dg.DataSource = ds.Tables("DataBaseTB")
            Txtclear()



        End If
        MsgBox("The data has been deleted in the database successfully...", MsgBoxStyle.Information, "Deleted")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Txt_UserName.Text.Trim.Length > 0 Then
            idpic.Image = Nothing
            OFD.FileName = Nothing




            If OFD.ShowDialog = DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(OFD.FileName, Application.StartupPath & "\images\" & Trim(Txt_UserName.Text) & ".jpg", True)
                    idpic.ImageLocation = Application.StartupPath & "\images\" & Txt_UserName.Text.Trim & ".jpg"


                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            End If

        Else
            MsgBox("Please enter a User Name!.", MsgBoxStyle.Information, "Reminder!!!")
        End If


    End Sub

    Private Sub Dg_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dg.RowEnter
        recpoint = e.RowIndex
        display()
        Try
            idpic.ImageLocation = ""
            idpic.Refresh()
            idpic.ImageLocation = Application.StartupPath & "\images\" & Txt_UserName.Text.Trim & ".jpg"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mnupulst_Click(sender As Object, e As EventArgs) Handles mnupulst.Click
        Dim exporter As New PrintExcel()
        exporter.ExportUserListAndOpenExcel(Application.StartupPath & "\Excel\Listofuser.xlsx", "MINAS BOARD-TAP STORE", "USER LIST REPORT")

    End Sub

    Private Sub CrytalReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnucr.Click
        CRUser.Show()
        Me.Hide()




    End Sub



    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub lblnm_Click(sender As Object, e As EventArgs) Handles lblnm.Click

    End Sub
End Class