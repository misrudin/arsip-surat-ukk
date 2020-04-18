Imports System.Data.OleDb
Module Mod_Koneksi
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public ds As DataSet

    Public suratmasuk As String = "No"
    Public suratkeluar As String = "No"
    Public disp As String = "No"
    Public ubahpas As String = "No"
    Public pegawai As String = "No"
    Public laporan As String = "No"

    Public Function rep(ByVal kata As String)
        rep = Replace(kata, "'", "''")
    End Function

    Sub Koneksi()
        conn = New OleDbConnection("provider=Microsoft.Ace.Oledb.12.0; data source=DBSURAT.accdb")
        conn.Open()
    End Sub


    Sub Bersih(ByVal frm As Form)
        For Each obj In frm.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            ElseIf TypeOf obj Is ComboBox Then
                obj.text = ""
            ElseIf TypeOf obj Is DateTimePicker Then
                obj.value = Now
            ElseIf TypeOf obj Is CheckBox Then
                obj.checked = False
            ElseIf TypeOf obj Is PictureBox Then
                obj.Image = Nothing
            End If
        Next

        suratkeluar = "No"
        suratmasuk = "No"
        disp = "No"
        ubahpas = "No"
        pegawai = "No"
        laporan = "No"
    End Sub
End Module
