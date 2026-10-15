
Imports System.Data.OleDb
Imports System.Data
Imports System.IO


Module Module1
    Public conn As New OleDb.OleDbConnection
    Public abs As New OleDbDataAdapter
    Public stck As New OleDbDataAdapter
    Public ListStck As New OleDbDataAdapter
    Public temp As New OleDbDataAdapter
    Public trns As New OleDbDataAdapter

    Public cm As New OleDbCommand
    Public ds As New DataSet
    Public tempds As New DataSet
    Public transds As New DataSet


    Public recpoint As Integer
    Public trec As Integer
    Public sw As Boolean
    Public xtry As Integer
    Public xname As String
    Public xpost As String
    Public xpriv As String

    Public xDesc As String
    Public xUP As String
    Public xGTotal As Double
    Public xtempq As String
    Public xqty As String
    Public xin As String
    Public xtotal As String
    Public xAmount As String
    Public stocksqty As String
    Public xItemName As String
    Public critlev As String
    Public xtime As String


    Sub opendb()
        Try
            conn = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\DataBase2\JeoffDB.mdb")
            abs = New OleDbDataAdapter("SELECT * FROM DataBaseTB", conn)
            ds = New DataSet()
            abs.Fill(ds, "DataBaseTB")

            If ds.Tables("DataBaseTB").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("DataBaseTB").Rows.Count) - 1

            End If
        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally

            conn.Close()

        End Try
    End Sub


    Sub sqlquery()
        Try
            abs = New OleDbDataAdapter("SELECT [UserID],[UserName],[Position],[Privilege] FROM  DataBaseTB ", conn)
            ds = New DataSet()
            abs.Fill(ds, "DataBaseTB")

            If ds.Tables("DataBaseTB").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("DataBaseTB").Rows.Count) - 1

            End If
        Catch ex As OleDbException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub openstckdb()
        Try
            conn = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\DataBase2\JeoffDB.mdb")
            stck = New OleDbDataAdapter("SELECT * FROM TblStock", conn)
            ds = New DataSet()
            stck.Fill(ds, "TblStock")

            If ds.Tables("TblStock").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("TblStock").Rows.Count) - 1

            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally

            conn.Close()

        End Try
    End Sub

    Sub sqlstckquery()
        Try

            stck = New OleDbDataAdapter("SELECT [ItemID],[ItemName],[ItemDescription],[Quantity],[BuyingPrice],[SellingPrice],[Critical] FROM  TblStock ", conn)
            ds = New DataSet()
            stck.Fill(ds, "TblStock")

            If ds.Tables("TblStock").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("TblStock").Rows.Count) - 1

            End If
        Catch ex As OleDbException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub opendbtemp()
        Try
            conn = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\DataBase2\JeoffDB.mdb")
            temp = New OleDbDataAdapter("SELECT * FROM CashierTB", conn)
            tempds = New DataSet()
            temp.Fill(tempds, "CashierTB")

            If tempds.Tables("CashierTB").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(tempds.Tables("CashierTB").Rows.Count) - 1

            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally

            conn.Close()

        End Try

    End Sub

    Sub sqlquerytemp()
        Try

            temp = New OleDbDataAdapter("SELECT [Item ID],[ItemName],[Quantity],[UnitPrice],[Total] FROM  CashierTB", conn)
            tempds = New DataSet()
            temp.Fill(tempds, "CashierTB")

            If tempds.Tables("CashierTB").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(tempds.Tables("CashierTB").Rows.Count) - 1

            End If
        Catch ex As OleDbException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub opentransdb()

        Try
            conn = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\DataBase2\JeoffDB.mdb")
            trns = New OleDbDataAdapter("SELECT * FROM Trans", conn)
            transds = New DataSet
            trns.Fill(transds, "Trans")

            If transds.Tables("Trans").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(transds.Tables("Trans").Rows.Count) - 1

            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error!")
        Finally

            conn.Close()

        End Try
    End Sub
    Sub sqltransquery()
        Try

            trns = New OleDbDataAdapter("SELECT [Item ID],[Item Name],[Quantity],[UnitPrice],[Total],[Time Transaction],[Cashier Name] FROM  Trans", conn)
            transds = New DataSet()
            trns.Fill(transds, "Trans")

            If transds.Tables("Trans").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(transds.Tables("Trans").Rows.Count) - 1

            End If
        Catch ex As OleDbException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub ItemList()
        Try
            conn = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\DataBase2\JeoffDB.mdb")
            ListStck = New OleDbDataAdapter("SELECT * FROM TblStock", conn)
            ds = New DataSet()
            ListStck.Fill(ds, "TblStock")

            If ds.Tables("TblStock").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("TblStock").Rows.Count) - 1

            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally

            conn.Close()

        End Try
    End Sub

    Sub lststckquery()
        Try

            ListStck = New OleDbDataAdapter("SELECT [ItemID],[ItemName] FROM  TblStock ", conn)
            ds = New DataSet()
            ListStck.Fill(ds, "TblStock")

            If ds.Tables("TblStock").Rows.Count > 0 Then
                recpoint = 0
                trec = CInt(ds.Tables("TblStock").Rows.Count) - 1

            End If
        Catch ex As OleDbException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

End Module
