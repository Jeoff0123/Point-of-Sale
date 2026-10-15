Public Class Loginfrm



    Public a As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles mnuclose.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close the window?", MsgBoxStyle.YesNo, "Closing...")

        If Result = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Me.Focus()

        End If


    End Sub

    Private Sub mnulogin_Click(sender As Object, e As EventArgs) Handles mnulogin.Click

        Dim failSafeUser As String = "guest"      ' Fail-safe username
        Dim failSafePass As String = "admin123"   ' Fail-safe password

        ' Check for Fail-Safe Account Login
        If Txt_Un.Text.Trim = failSafeUser AndAlso Txt_Pw.Text.Trim = failSafePass Then
            ' Grant access to fail-safe account
            Me.Visible = False
            Txt_Un.Clear()
            Txt_Pw.Clear()
            Cashier.Show()
            MsgBox("Fail-safe login successful. Administrative access granted.", MsgBoxStyle.Information, "Fail-Safe Login")
            Return ' Exit the subroutine to bypass regular login logic
        End If

        opendb()

        abs = New OleDb.OleDbDataAdapter("SELECT [Position],[Privilege],[UserName] FROM  DataBaseTB WHERE [UserName] = @UserName AND [Password] = @Pass", conn)
        abs.SelectCommand.Parameters.AddWithValue("@UserName", Txt_Un.Text.Trim)
        abs.SelectCommand.Parameters.AddWithValue("@Pass", Txt_Pw.Text.Trim)
        ds = New DataSet()
        abs.Fill(ds, "DataBaseTB")
        trec = ds.Tables("DataBaseTB").Rows.Count


        If trec > 0 Then
            xname = ds.Tables("DataBaseTB").Rows(0).Item("UserName")
            xpost = ds.Tables("DataBaseTB").Rows(0).Item("Position")
            xpriv = ds.Tables("DataBaseTB").Rows(0).Item("Privilege")
            Me.Visible = False
            Txt_Un.Clear()
            Txt_Pw.Clear()
            Category.Show()
        Else
            MsgBox("The password you entered does not match the username. Please try again.")

            xtry = xtry + 1

            If xtry = 5 Then
                Me.Close()
                MsgBox("You have reached the limit of attempts(5). The application will now close.")

            End If
            Txt_Un.Clear()
            Txt_Pw.Clear()
            Txt_Un.Focus()
        End If


    End Sub




    Private Sub Txt_Pw_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Pw.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Try
                Dim failSafeUser As String = "guest"      ' Fail-safe username
                Dim failSafePass As String = "admin123"   ' Fail-safe password

                ' Check for Fail-Safe Account Login
                If Txt_Un.Text.Trim = failSafeUser AndAlso Txt_Pw.Text.Trim = failSafePass Then
                    ' Grant access to fail-safe account
                    Me.Visible = False
                    Txt_Un.Clear()
                    Txt_Pw.Clear()
                    Cashier.Show()
                    MsgBox("Fail-safe login successful.", MsgBoxStyle.Information, "Fail-Safe Login")
                    Return ' Exit the subroutine to bypass regular login logic
                End If

                opendb()

                abs = New OleDb.OleDbDataAdapter("SELECT [Position],[Privilege],[UserName] FROM  DataBaseTB WHERE [UserName] = @UserName AND [Password] = @Pass", conn)
                abs.SelectCommand.Parameters.AddWithValue("@UserName", Txt_Un.Text.Trim)
                abs.SelectCommand.Parameters.AddWithValue("@Pass", Txt_Pw.Text.Trim)
                ds = New DataSet()
                abs.Fill(ds, "DataBaseTB")
                trec = ds.Tables("DataBaseTB").Rows.Count

                If trec > 0 Then
                    xname = ds.Tables("DataBaseTB").Rows(0).Item("UserName")
                    xpost = ds.Tables("DataBaseTB").Rows(0).Item("Position")
                    xpriv = ds.Tables("DataBaseTB").Rows(0).Item("Privilege")
                    Me.Visible = False
                    Txt_Un.Clear()
                    Txt_Pw.Clear()
                    Category.Show()
                Else
                    MsgBox("The password you entered does not match the username. Please try again.")

                    xtry = xtry + 1

                    If xtry = 3 Then
                        Me.Close()
                        MsgBox("You have reached the limit of attempts(5). The application will now close.")

                    End If
                    Txt_Un.Clear()
                    Txt_Pw.Clear()
                    Txt_Un.Focus()
                End If

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")

            End Try
            Exit Sub

        End If
    End Sub

    Private Sub mnuclose0_Click(sender As Object, e As EventArgs) Handles mnuclose0.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close the window?", MsgBoxStyle.YesNo, "Closing...")

        If Result = MsgBoxResult.Yes Then


            Me.Close()
        Else

            Txt_Un.Focus()




        End If

    End Sub

    Private Sub Loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Txt_Un.Focus()

    End Sub


    Private Sub Txt_Un_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Un.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Txt_Pw.Focus()
        End If




    End Sub

    Private Sub lnklblGuestMode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblGuestMode.LinkClicked
        If MsgBox("NOTE: This mode only for Temporary Access of the system." + vbCrLf + "Please contact our admin for account recovery." + vbCrLf + "Thank You!", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            MsgBox("This mode only available for Cashier Position.", MsgBoxStyle.Exclamation)
            a = InputBox("What is your position in the company?", "Question")

            If String.IsNullOrEmpty(a) Then
                MsgBox("Please enter valid data to proceed. ")
                Return

            End If

            If a = "Cashier" Or a = "CASHIER" Then
                xname = "Guest"
                Category.Show()
                Category.Btn_User.Enabled = False
                Category.Btn_stck.Enabled = False
                Category.btn_cash.Enabled = True
                Category.Btn_report.Enabled = False
                xname = "Guest"
                MsgBox("You are now in Guest Mode.", MsgBoxStyle.Information, "Welcome!")

            End If
        Else
            MsgBox("Reminder: This mode only available for Cashier Position.", MsgBoxStyle.Exclamation, "Warning!")
            Exit Sub
        End If

    End Sub
End Class