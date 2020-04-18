Public Class Frmlap1
    Private Sub FrmLap1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_Menu.Timer1.Start()
        Frm_Menu.Timer2.Start()
    End Sub

    Private Sub FrmLap1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Crpt.RefreshReport()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class