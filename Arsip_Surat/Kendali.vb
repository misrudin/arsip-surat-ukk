Public Class Kendali

    Private Sub Kendali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Frm_Login.Show()
        Timer1.Enabled = False
        Me.Hide()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Frm_Menu.Show()
        Timer2.Stop()
    End Sub
End Class