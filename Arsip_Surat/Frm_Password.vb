Imports System.IO
Imports System.Data.OleDb
Public Class Frm_Password
    Dim opf As New OpenFileDialog
    Sub tampil()
        cmd = New OleDbCommand("Select * From Pegawai Where No_Pegawai='" & txtno.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then

            txtnama.Text = dr(1)
            txtalamat.Text = dr("Alamat")
            txtnotlp.Text = dr("No_Telepon")
            txtuser.Text = dr("username")

            Dim ms As New MemoryStream(CType(dr.Item("Gambar"), Byte()))
            Dim img As Image = Image.FromStream(ms)
            gbr.Image = img
        End If
    End Sub
    Private pindah As Boolean = False
    Private x As Integer
    Private y As Integer

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
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Close()
    End Sub

    Private Sub Frm_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()

        garis.Left = 0
        garis.Top = 0
        garis.Height = Me.Height - 1
        garis.Width = Me.Width - 1

    End Sub

    Private Sub tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutup.Click
        Close()
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        Bersih(Me)
        tampil()
    End Sub

    Private Sub cmdSimapn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimapn.Click
        cmd = New OleDbCommand("Select * From Pegawai Where Username='" & txtuser.Text & "' and pwd='" & txtpas.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Password Salah!", vbInformation, "Ubah Passwoord")
        Else
            If txtnew.Text = "" Then
                MsgBox("Password Baru belum dimasukan!", vbInformation, "Ubah Password")
            Else
                cmd = New OleDbCommand("Update pegawai set Pwd ='" & txtnew.Text & "' where no_pegawai='" & txtno.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Close()
            End If
          
        End If
        Exit Sub
    End Sub
End Class