Imports System.IO
Imports System.Data.OleDb
Public Class Frm_Pegawai
    Dim opf As New OpenFileDialog
    Dim ms As MemoryStream
    Sub tampil()
        da = New OleDbDataAdapter("Select No_Pegawai,Nama_Pegawai,Jenis_Kelamin,Jabatan,Alamat,Tanggal_Lahir,Tanggal_masuk,No_Telepon,Username from Pegawai order by no_Pegawai", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).HeaderText = "No Pegawai"
        DGV.Columns(1).HeaderText = "Nama Pegawai"
        DGV.Columns(2).HeaderText = "Jenis Kelamin"
        DGV.Columns(5).HeaderText = "Tanggal Lahir"
        DGV.Columns(6).HeaderText = "Tanggal Masuk"
        DGV.Columns(7).HeaderText = "No Telepon"

        cmd = New OleDbCommand("Select No_Pegawai From Pegawai order by no_Pegawai desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Txtid.Text = "PEG001"
        Else
            Txtid.Text = "PEG" + Format(Microsoft.VisualBasic.Right(dr.Item(0), 3) + 1, "000")

        End If

        cmd = New OleDbCommand("Select Distinct jabatan from pegawai", conn)
        dr = cmd.ExecuteReader
        cmbjab.Items.Clear()
        While dr.Read
            cmbjab.Items.Add(dr!jabatan)
        End While
    End Sub
    Private Sub Frm_Pegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()

        cmbjk.Items.Add("Laki - Laki")
        cmbjk.Items.Add("Perempuan")

    End Sub

    Private Sub CMDSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSIMPAN.Click
        If Txtid.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtno.Text = "" Or txtpas.Text = "" Or txtuser.Text = "" Or cmbjk.Text = "" Or cmbjab.Text = "" Then
            MsgBox("Silahkan Lengkapi data !", vbInformation, "Data Pegawai")
        Else
            cmd = New OleDbCommand("Select * From Pegawai Where No_Pegawai='" & Txtid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                On Error GoTo handle
                cmd = New OleDbCommand("Insert Into Pegawai (No_Pegawai,Nama_Pegawai,Jenis_Kelamin,Jabatan,Alamat,No_Telepon,Username,Pwd,sm,sk,ds,dp,up,lp,gambar,tanggal_lahir,tanggal_masuk) values ('" & Txtid.Text & "','" & txtnama.Text & "','" & cmbjk.Text & "','" & cmbjab.Text & "','" & txtalamat.Text & "','" & txtno.Text & "','" & txtuser.Text & "','" & txtpas.Text & "','" & suratmasuk & "','" & suratkeluar & "','" & disp & "','" & pegawai & "','" & ubahpas & "','" & laporan & "',@gambar,'" & tgl1.Value & "','" & tgl2.Value & "')", conn)
                Dim ms As New MemoryStream
                Pic1.Image.Save(ms, Pic1.Image.RawFormat)
                cmd.Parameters.Add("@gambar", OleDbType.Binary).Value = ms.ToArray

                cmd.ExecuteNonQuery()
            Else
                On Error GoTo handle
                cmd = New OleDbCommand("Update Pegawai Set Nama_Pegawai='" & txtnama.Text & "',jenis_kelamin='" & cmbjk.Text & "',jabatan='" & cmbjab.Text & "',alamat='" & txtalamat.Text & "',No_telepon='" & txtno.Text & "',Username='" & txtuser.Text & "',pwd='" & txtpas.Text & "',sm='" & suratmasuk & "',sk='" & suratkeluar & "',ds='" & disp & "',dp='" & pegawai & "',up='" & ubahpas & "',lp='" & laporan & "',gambar=@gambar,tanggal_lahir='" & tgl1.Value & "',tanggal_masuk='" & tgl2.Value & "' where no_Pegawai='" & Txtid.Text & "'", conn)
                Dim ms As New MemoryStream
                Pic1.Image.Save(ms, Pic1.Image.RawFormat)
                cmd.Parameters.Add("@gambar", OleDbType.Binary).Value = ms.ToArray

                cmd.ExecuteNonQuery()
            End If

            Bersih(Me)
            tampil()
            Txtid.Focus()
        End If

        Exit Sub
handle:
        MsgBox("Silahkan Isi Gambar !", vbInformation, "Data Pegawai")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        opf.Filter = "Chose Image (*.JPG;*.PNG;*.GIF) |*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pic1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub CMDBATAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBATAL.Click
        Bersih(Me)
        tampil()
        Txtid.Focus()
    End Sub

    Private Sub UP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UP.CheckedChanged
        If UP.Checked = True Then
            ubahpas = "Yes"
        Else
            ubahpas = "No"
        End If
    End Sub

    Private Sub DP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DP.CheckedChanged
        If DP.Checked = True Then
            pegawai = "Yes"
        Else
            pegawai = "No"
        End If
    End Sub

    Private Sub LP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LP.CheckedChanged
        If LP.Checked = True Then
            laporan = "Yes"
        Else
            laporan = "No"
        End If
    End Sub

    Private Sub SM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SM.CheckedChanged
        If SM.Checked = True Then
            suratmasuk = "Yes"
        Else
            suratmasuk = "No"
        End If
    End Sub

    Private Sub SK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SK.CheckedChanged
        If SK.Checked = True Then
            suratkeluar = "Yes"
        Else
            suratkeluar = "No"
        End If
    End Sub

    Private Sub DIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIS.CheckedChanged
        If DIS.Checked = True Then
            disp = "Yes"
        Else
            disp = "No"
        End If
    End Sub

    Private Sub CMDTUTUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTUTUP.Click
        Close()
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error GoTo handle

        cmd = New OleDbCommand("Select * From Pegawai Where No_Pegawai='" & DGV.SelectedRows(0).Cells(0).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Txtid.Text = dr!no_Pegawai
            txtnama.Text = dr!Nama_Pegawai
            cmbjk.Text = dr!Jenis_Kelamin
            cmbjab.Text = dr!Jabatan
            txtalamat.Text = dr!alamat
            txtno.Text = dr!no_telepon
            txtuser.Text = dr!username
            txtpas.Text = dr!pwd
            tgl1.Value = dr!tanggal_lahir
            tgl2.Value = dr!tanggal_masuk

            If dr!sm = "Yes" Then
                SM.Checked = True
            Else
                SM.Checked = False
            End If

            If dr!sk = "Yes" Then
                SK.Checked = True
            Else
                SK.Checked = False
            End If

            If dr!ds = "Yes" Then
                DIS.Checked = True
            Else
                DIS.Checked = False
            End If

            If dr!dp = "Yes" Then
                DP.Checked = True
            Else
                DP.Checked = False
            End If

            If dr!up = "Yes" Then
                UP.Checked = True
            Else
                UP.Checked = False
            End If

            If dr!lp = "Yes" Then
                LP.Checked = True
            Else
                LP.Checked = False
            End If

            'gambar
            Dim ms As New MemoryStream(CType(dr.Item("Gambar"), Byte()))
            Dim img As Image = Image.FromStream(ms)
            Pic1.Image = img

        End If

        Exit Sub
handle:

    End Sub

    Private Sub TXTCARI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCARI.TextChanged
        da = New OleDbDataAdapter("Select No_Pegawai,Nama_Pegawai,Jenis_Kelamin,Jabatan,Alamat,No_Telepon,Username from Pegawai where no_Pegawai like '%" & TXTCARI.Text & "%' or Nama_Pegawai like '%" & TXTCARI.Text & "%' or jenis_kelamin like '%" & TXTCARI.Text & "%' or jabatan like '%" & TXTCARI.Text & "%' or alamat like '%" & TXTCARI.Text & "%' or no_telepon like '%" & TXTCARI.Text & "%' or username like '%" & TXTCARI.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
    End Sub

    Private Sub CMDHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDHAPUS.Click
        Dim conf = MsgBox("Hapus Data Pegawai " & Txtid.Text & " ?", vbQuestion + vbYesNo, "Data Pegawai")
        If conf = vbYes Then
            If Txtid.Text <> Frm_Menu.txtno.Text Then
                cmd = New OleDbCommand("Delete From Pegawai Where No_Pegawai='" & Txtid.Text & "'", conn)
                cmd.ExecuteNonQuery()
            Else
                MsgBox("Maaf,," & vbCrLf & "Data Pegawai Sedang Anda Gunakan !!!" & vbCrLf & "Anda tidak diperbolehkan menghapus saat ini.", vbCritical + vbInformation + vbOKOnly, "Opsss..")
            End If
            Bersih(Me)
            tampil()
            Txtid.Focus()
        End If
    End Sub
End Class
