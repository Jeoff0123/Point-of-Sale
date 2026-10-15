Public Class Category
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = AutoScaleMode.Dpi

        lblnm1.Text = xname
        Timer2.Interval = 1000 ' update every 1 second
        Timer2.Start()


        If xpriv = "User" And xpost = "Cashier" Then
            Btn_User.Enabled = False
            Btn_stck.Enabled = False
            btn_cash.Enabled = True
            Btn_report.Enabled = False


        End If


        If xpriv = "User" And xpost = "Stockman" Then
            Btn_User.Enabled = False
            Btn_stck.Enabled = True
            btn_cash.Enabled = False
            Btn_report.Enabled = False

        End If

        If xpriv = "Admin" AndAlso (xpost = "Manager" OrElse xpost = "Supervisor") Then
            Btn_User.Enabled = True
            Btn_stck.Enabled = True
            btn_cash.Enabled = False
            Btn_report.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = Format(Now, "dd MMMM, yyyy hh:mm:ss tt")
    End Sub
    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        UsFrm.Show()
        Me.Hide()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dim Result As MsgBoxResult = MsgBox("Do you want to close this window?" + vbCrLf + "The next user will be required to log in. Do you want to proceed?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Log Off Confirmation")

        If Result = MsgBoxResult.Yes Then
            Me.Close()
            Loginfrm.Show()
            Loginfrm.Txt_Un.Focus()
        Else
            Exit Sub
        End If


    End Sub



    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn_stck.Click
        StkFrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        Cashier.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        Me.Hide()
        Report.Show()

    End Sub




    Private Sub mnuAccount_Click(sender As Object, e As EventArgs) Handles mnuAccount.Click
        If MsgBox("Do you want to reset your password?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Account Recovery") = MsgBoxResult.Yes Then
            With Form5
                .ShowDialog()
                .Close()

            End With
        Else
            Exit Sub
        End If



    End Sub
End Class