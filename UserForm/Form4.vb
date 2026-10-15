Public Class Form4
    Public Property Password As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassad.PasswordChar = "*"
        txtpassad.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Password = txtpassad.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtpassad_TextChanged(sender As Object, e As EventArgs) Handles txtpassad.TextChanged

    End Sub

    Private Sub txtpassad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Password = txtpassad.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub
End Class