Imports System.Data.OleDb
Imports System.IO
Imports System.Data


Public Class UsFrm



    Private Sub UsFrm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        opendb()
        sqlquery()




    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        If MsgBox("Do you want to close the current window?", MsgBoxStyle.YesNo, "Closed") = MsgBoxResult.Yes Then
            Me.Close()
            Category.Show()
        End If

    End Sub

    Private Sub MNUFIRST_Click(sender As Object, e As EventArgs) Handles MNUFIRST.Click

    End Sub
End Class