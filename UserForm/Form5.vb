Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        sqlquery()

        TxtNewPass.PasswordChar = "*"c
        TxtRetypepass.PasswordChar = "*"c

        txtDisabled()
        TxtUserId.Focus()

    End Sub

    Sub txtDisabled()
        TxtNewPass.Enabled = False
        TxtRetypepass.Enabled = False
        TxtUserName2.Enabled = False


    End Sub
    Sub txtEnabled()
        TxtNewPass.Enabled = True
        TxtRetypepass.Enabled = True
        TxtUserName2.Enabled = True
    End Sub

    Sub TxtClear()
        TxtUserId.Text = ""
        TxtUserName2.Text = ""
        TxtNewPass.Text = ""
        TxtRetypepass.Text = ""

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            If TxtNewPass.Text = TxtRetypepass.Text Then
                If MsgBox("Do you want to reset your password?", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                    conn.Open()


                    cm = New OleDb.OleDbCommand("UPDATE DataBaseTB SET [Password] = @Password, [UserName] = @UserName WHERE [UserID] = @UserID", conn)
                    cm.Parameters.AddWithValue("@Password", TxtNewPass.Text)
                    cm.Parameters.AddWithValue("@UserName", TxtUserName2.Text)
                    cm.Parameters.AddWithValue("@UserID", TxtUserId.Text)



                    cm.ExecuteNonQuery()
                    sqlquery()

                    MsgBox("Your password updated successfully...", MsgBoxStyle.Information, "Saved")
                    TxtClear()

                Else
                    TxtNewPass.Text = ""
                    TxtRetypepass.Text = ""
                End If

            Else
                MsgBox("Please re-type your password correctly!!!", , "reminder!!!")

            End If

        Catch ex As Exception
            MsgBox("Error saving data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub TxtUserName_TextChanged(sender As Object, e As EventArgs) Handles TxtUserId.TextChanged
        txtEnabled()

    End Sub

    Private Sub TxtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUserId.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            TxtUserName2.Focus()
            txtEnabled()

        End If
    End Sub

    Private Sub TxtUserName2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUserName2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TxtUserName2.Text) Then
                MsgBox("Please input a valid name to proceed.", MsgBoxStyle.Exclamation, "Reminder.")
                Return
            End If
            e.SuppressKeyPress = True
            TxtNewPass.Focus()


        End If
    End Sub



    Private Sub TxtNewPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNewPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            TxtRetypepass.Focus()


        End If
    End Sub



    Private Sub TxtRetypepass_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRetypepass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If TxtNewPass.Text = TxtRetypepass.Text Then
                    If MsgBox("Do you want to save your new password?", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                        conn.Open()


                        cm = New OleDb.OleDbCommand("UPDATE DataBaseTB SET [Password] = @Password, [UserName] = @UserName WHERE [UserID] = @UserID", conn)
                        cm.Parameters.AddWithValue("@Password", TxtNewPass.Text)
                        cm.Parameters.AddWithValue("@UserName", TxtUserName2.Text)
                        cm.Parameters.AddWithValue("@UserID", TxtUserId.Text)



                        cm.ExecuteNonQuery()
                        sqlquery()

                        MsgBox("Your password updated successfully...", MsgBoxStyle.Information, "Saved")
                        TxtClear()
                        TxtUserName2.Focus()

                    Else
                        TxtNewPass.Text = ""
                        TxtRetypepass.Text = ""
                    End If

                Else
                    MsgBox("Please re-type your password correctly!!!", , "reminder!!!")

                End If

            Catch ex As Exception
                MsgBox("Error saving data: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()

            End Try

        End If

    End Sub
End Class