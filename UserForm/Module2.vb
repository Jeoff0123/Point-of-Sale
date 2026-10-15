Imports System.Data.OleDb
Imports System.IO
Imports System.Data

Module Module2
    Dim conn As New OleDbConnection
    Dim tbluser As New OleDbDataAdapter
    Dim rd As OleDbDataReader
    Dim ds As New DataSet
    Dim recpoint As Integer
    Dim trec As Integer
    Dim sw As Boolean
    Sub opendb()
        Try
            conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Debug\DatabaseKim.mdb")
            Dim tbluser As New OleDbDataAdapter
            ds = New DataSet()
            tbluser.Fill(ds, "tbluser")

            If ds.Tables("tbluser").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("tbluser").Rows.Count) - 1


            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            conn.Close()
        End Try



    End Sub

    Sub sqlquery()
        Try
            tbluser = New OleDbDataAdapter("SELECT [ID],[USERNAME],[POSITION],[PRIVILAGE]", conn)
            ds = New DataSet
            tbluser.Fill(ds, "tbluser")

            If ds.Tables("tbluser").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("tbluser").Rows.Count) - 1


            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

End Module
