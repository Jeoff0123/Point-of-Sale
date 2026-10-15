Public Class Resibo
    Private Sub MNUCLOSE4_Click(sender As Object, e As EventArgs) Handles MNUCLOSE4.Click
        Me.Hide()
        Cashier.Show()
    End Sub



    Private Sub MNUPntVw_Click(sender As Object, e As EventArgs) Handles MNUPntVw.Click
        Cashier.report()

    End Sub

    Private Sub Resibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cashier.report()



    End Sub
End Class