Public Class FrmLap4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.SelectionFormula = "{disposisi.tanggal} in date ('" & tgl1.Value & "') to date ('" & tgl2.Value & "')"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CrystalReportViewer1.SelectionFormula = ""
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub FrmLap4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_Menu.Timer1.Start()
        Frm_Menu.Timer2.Start()
    End Sub

    Private Sub FrmLap4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.RefreshReport()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class