
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data
Imports System.IO

Public Class ItemLst
    Private Sub ItemLst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi

        ItemList()
        lststckquery()

        dgitemlist.DataSource = ds.Tables("TblStock")

    End Sub

    Private Sub dgitemlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgitemlist.CellContentClick

    End Sub

    Private Sub dgitemlist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgitemlist.CellDoubleClick
        Dim cashierFrm As Cashier = CType(Owner, Cashier)
        cashierFrm.TxtItId.Text = dgitemlist.CurrentRow.Cells("ItemID").Value.ToString()
        Me.Close()

    End Sub
End Class