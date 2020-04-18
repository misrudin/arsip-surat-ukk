Public Class FrmLap2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRPT.SelectionFormula = "{Surat_keluar.tanggal} in date ('" & tgl1.Value & "') to date ('" & tgl2.Value & "')"
        CRPT.RefreshReport()
    End Sub

    Private Sub FrmLap2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_Menu.Timer1.Start()
        Frm_Menu.Timer2.Start()
    End Sub

    Private Sub FrmLap2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CRPT.RefreshReport()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRPT.SelectionFormula = ""
        CRPT.RefreshReport()
    End Sub
End Class