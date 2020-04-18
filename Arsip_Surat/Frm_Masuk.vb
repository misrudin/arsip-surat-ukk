Imports System.IO
Imports System.Data.OleDb
Public Class Frm_Masuk
    Dim opf As New OpenFileDialog
    Dim ms As MemoryStream

    Sub tampil()
        da = New OleDbDataAdapter("Select No_Surat,Tanggal,Jenis_Surat,Pengirim,Deskripsi,Alamat,No_telepon,Operator from Surat_Masuk", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).HeaderText = "No Surat"
        DGV.Columns(2).HeaderText = "Jenis Surat"
        DGV.Columns(6).HeaderText = "No Telepon"

        cmd = New OleDbCommand("Select Distinct Jenis_Surat from surat_masuk", conn)
        dr = cmd.ExecuteReader
        CMBJENIS.Items.Clear()
        While dr.Read
            CMBJENIS.Items.Add(dr!jenis_surat)
        End While

        cmd = New OleDbCommand("Select Distinct Pengirim from surat_masuk", conn)
        dr = cmd.ExecuteReader
        CMBPENGIRIM.Items.Clear()
        While dr.Read
            CMBPENGIRIM.Items.Add(dr!pengirim)
        End While
    End Sub
    Private Sub CMDTUTUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTUTUP.Click
        Close()

    End Sub

    Private Sub CMDBATAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBATAL.Click
        Bersih(Me)
        tampil()
        TXTID.Focus()
    End Sub

    Private Sub Frm_Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()
    End Sub

    Private Sub CMDSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSIMPAN.Click
        If TXTID.Text = "" Or CMBJENIS.Text = "" Or CMBPENGIRIM.Text = "" Or TXTDES.Text = "" Or TXTALAMAT.Text = "" Or TXTNO.Text = "" Then
            MsgBox("Silahkan Lengkapi data !", vbInformation, "Data Surat Masuk")
        Else
            cmd = New OleDbCommand("Select * From surat_masuk Where No_Surat='" & TXTID.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                On Error GoTo handle
                cmd = New OleDbCommand("Insert Into surat_Masuk (No_Surat,Tanggal,Jenis_Surat,Pengirim,Deskripsi,Alamat,No_Telepon,gambar,operator) values ('" & TXTID.Text & "','" & TGL.Value & "','" & CMBJENIS.Text & "','" & CMBPENGIRIM.Text & "','" & TXTDES.Text & "','" & TXTALAMAT.Text & "','" & TXTNO.Text & "',@gambar,'" & Frm_Menu.txtno.Text & "')", conn)
                Dim ms As New MemoryStream
                PIC1.Image.Save(ms, PIC1.Image.RawFormat)
                cmd.Parameters.Add("@gambar", OleDbType.Binary).Value = ms.ToArray
                cmd.ExecuteNonQuery()
            Else
                On Error GoTo handle
                cmd = New OleDbCommand("Update surat_masuk Set Tanggal='" & TGL.Value & "',jenis_Surat='" & CMBJENIS.Text & "',Pengirim='" & CMBPENGIRIM.Text & "',deskripsi='" & TXTDES.Text & "',alamat='" & TXTALAMAT.Text & "',no_telepon='" & TXTNO.Text & "',gambar=@gambar,operator='" & Frm_Menu.txtno.Text & "' where No_Surat='" & TXTID.Text & "'", conn)
                Dim ms As New MemoryStream
                PIC1.Image.Save(ms, PIC1.Image.RawFormat)
                cmd.Parameters.Add("@gambar", OleDbType.Binary).Value = ms.ToArray
                cmd.ExecuteNonQuery()
            End If

            Bersih(Me)
            tampil()
            TXTID.Focus()
            namafile.Text = ""

        End If

        Exit Sub
handle:
        MsgBox("Silahkan Isi Gambar !", vbInformation, "Data Pegawai")
    End Sub

    Private Sub CMBPILIH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBPILIH.Click
        opf.Filter = "Chose Image (*.JPG;*.PNG;*.GIF) |*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PIC1.Image = Image.FromFile(opf.FileName)
            namafile.Text = opf.FileName
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error GoTo handle

        cmd = New OleDbCommand("Select * From Surat_masuk Where no_surat='" & DGV.SelectedRows(0).Cells(0).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TXTID.Text = dr!no_surat
            TGL.Text = dr!tanggal
            CMBJENIS.Text = dr!jenis_Surat
            CMBPENGIRIM.Text = dr!pengirim
            TXTDES.Text = dr!deskripsi
            TXTALAMAT.Text = dr!alamat
            TXTNO.Text = dr!no_Telepon

        'gambar
        Dim ms As New MemoryStream(CType(dr.Item("Gambar"), Byte()))
        Dim img As Image = Image.FromStream(ms)
        PIC1.Image = img

        End If

        Exit Sub
handle:

    End Sub

    Private Sub CMDHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDHAPUS.Click
        Dim conf = MsgBox("Hapus Data Surat Masuk " & TXTID.Text & " ?", vbQuestion + vbYesNo, "Data Surat Masuk")
        If conf = vbYes Then
            cmd = New OleDbCommand("Delete From Surat_Masuk Where No_Surat='" & TXTID.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Bersih(Me)
            tampil()
            TXTID.Focus()
        End If
    End Sub

    Private Sub TXTCARI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCARI.TextChanged
        da = New OleDbDataAdapter("Select No_Surat,Tanggal,Jenis_Surat,Pengirim,Deskripsi,Alamat,No_telepon from Surat_Masuk where No_Surat like '%" & TXTCARI.Text & "%' or tanggal like '%" & TXTCARI.Text & "%' or jenis_Surat like '%" & TXTCARI.Text & "%' or pengirim like '%" & TXTCARI.Text & "%' or deskripsi like '%" & TXTCARI.Text & "%' or alamat like '%" & TXTCARI.Text & "%' or no_telepon like '%" & TXTCARI.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
    End Sub
End Class