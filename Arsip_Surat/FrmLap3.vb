Public Class FrmLap3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        crpt.SelectionFormula = "{Surat_Masuk.tanggal} in date ('" & tgl1.Value & "') to date ('" & tgl2.Value & "')"
        crpt.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        crpt.SelectionFormula = ""
        crpt.RefreshReport()
    End Sub

    Private Sub FrmLap3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_Menu.Timer1.Start()
        Frm_Menu.Timer2.Start()
    End Sub

    Private Sub FrmLap3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crpt.RefreshReport()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class