Imports System.Data.OleDb
Public Class FrmTerima

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLap2.ShowDialog()
    End Sub

    Private Sub FrmTerima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        cmd = New OleDbCommand("Update Disposisi Set Status='" & "Diterima" & "' where no_disposisi='" & Frm_Menu.DGV.SelectedRows(0).Cells(0).Value & "'", conn)
        cmd.ExecuteNonQuery()
    End Sub
End Class