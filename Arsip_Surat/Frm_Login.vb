Imports System.Data.OleDb
Public Class Frm_Login
    Private pindah As Boolean = False
    Private x As Integer
    Private y As Integer


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        garis.Left = 0
        garis.Top = 0
        garis.Height = Me.Height - 1
        garis.Width = Me.Width - 1
        Koneksi()
    End Sub
    Sub masuk()
        cmd = New OleDbCommand("Select * From Pegawai Where Username='" & txtuser.Text & "' and pwd='" & txtpas.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Noti.Text = "Login Gagal, Silahkan coba kembali !"
        Else
            Frm_Menu.txtno.Text = dr(0)

            Kendali.Timer2.Enabled = True
            Close()
        End If
        Exit Sub
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        masuk()
    End Sub

    Private Sub txtuser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.GotFocus
        If txtuser.Text = "Username" Then
            txtuser.Clear()
        End If
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpas.Focus()
        End If
    End Sub

    Private Sub txtuser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If
    End Sub

    Private Sub txtpas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpas.GotFocus
        If txtpas.Text = "Password" Then
            txtpas.UseSystemPasswordChar = True
            txtpas.Text = ""
        End If
    End Sub

    Private Sub txtpas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpas.KeyPress
        If e.KeyChar = Chr(13) Then
            masuk()
        End If
    End Sub

    Private Sub txtpas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpas.Leave
        If txtpas.Text = "" Then
            txtpas.UseSystemPasswordChar = False
            txtpas.Text = "Password"
        End If
    End Sub


    Private Sub lihat_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lihat.MouseDown
        If txtpas.Text <> "Password" Then
            lihat.ForeColor = Color.Silver
            txtpas.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub lihat_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lihat.MouseUp
        If txtpas.Text <> "Password" Then
            lihat.ForeColor = Color.Gray
            txtpas.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        pindah = True
        x = e.X
        y = e.Y
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If pindah Then
            Dim posisi As Point = New Point
            posisi.X = Me.Location.X + (e.X - x)
            posisi.Y = Me.Location.Y + (e.Y - y)
            Me.Location = posisi
            posisi = Nothing
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        pindah = False
    End Sub

End Class