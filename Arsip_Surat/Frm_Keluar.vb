Imports System.IO
Imports System.Data.OleDb
Public Class Frm_Keluar
    Dim opf As New OpenFileDialog
    Dim ms As MemoryStream
    Sub tampil()
        da = New OleDbDataAdapter("Select No_Surat,Tanggal,Jenis_Surat,Deskripsi,Tujuan,pegawai.nama_Pegawai,Operator from pegawai,Surat_Keluar where pegawai.no_pegawai=surat_keluar.pegawai order by no_Surat", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).HeaderText = "No Surat"
        DGV.Columns(2).HeaderText = "Jenis Surat"
        DGV.Columns(5).HeaderText = "Pegawai"

        cmd = New OleDbCommand("Select No_Surat From Surat_Keluar order by No_Surat desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TXTID.Text = "III.A/1.a/001/400140/SMKM/" + Format(Now, "yyyy")
        Else
            TXTID.Text = "III.A/1.a/" + Format(Microsoft.VisualBasic.Mid(dr.Item(0), 11, 3) + 1, "000") + "/400140/SMKM/" + Format(Now, "yyyy")
        End If

        cmd = New OleDbCommand("Select Distinct Jenis_Surat from surat_keluar", conn)
        dr = cmd.ExecuteReader
        CMBJENIS.Items.Clear()
        While dr.Read
            CMBJENIS.Items.Add(dr!jenis_surat)
        End While

        cmd = New OleDbCommand("Select * from pegawai", conn)
        dr = cmd.ExecuteReader
        CMBPEGAWAI.Items.Clear()
        While dr.Read
            CMBPEGAWAI.Items.Add(dr!no_pegawai)
        End While
    End Sub
    Private Sub Frm_Keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()
    End Sub

    Private Sub CMDTUTUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDTUTUP.Click
        Close()

    End Sub

    Private Sub CMDBATAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBATAL.Click
        Bersih(Me)
        tampil()
        TGL.Focus()
        TXTID.ReadOnly = True
    End Sub

    Private Sub CMDSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSIMPAN.Click
        If TXTID.Text = "" Or TXTDES.Text = "" Or TXTTUJUAN.Text = "" Or CMBJENIS.Text = "" Or CMBPEGAWAI.Text = "" Then
            MsgBox("Silahkan Lengkapi data !", vbInformation, "Data Surat Keluar")
        Else

            cmd = New OleDbCommand("Select * From Surat_Keluar Where No_Surat='" & TXTID.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                On Error GoTo handle
                Dim ms As New MemoryStream
                PIC1.Image.Save(ms, PIC1.Image.RawFormat)

                cmd = New OleDbCommand("Insert Into Surat_Keluar (No_Surat,Tanggal,Jenis_Surat,Deskripsi,Tujuan,Pegawai,gambar,operator) values ('" & TXTID.Text & "','" & TGL.Value & "','" & CMBJENIS.Text & "','" & TXTDES.Text & "','" & TXTTUJUAN.Text & "','" & CMBPEGAWAI.Text & "',@gambar,'" & Frm_Menu.txtno.Text & "')", conn)
                cmd.Parameters.Add("@gambar", OleDbType.Binary).Value = ms.ToArray
                cmd.ExecuteNonQuery()
            Else
                On Error GoTo handle

                cmd = New OleDbCommand("Update Surat_Keluar Set Tanggal='" & TGL.Value & "',jenis_Surat='" & CMBJENIS.Text & "',Deskripsi='" & TXTDES.Text & "',Tujuan='" & TXTTUJUAN.Text & "',pegawai='" & CMBPEGAWAI.Text & "',gambar=@gambar,operator='" & Frm_Menu.txtno.Text & "' where No_Surat='" & TXTID.Text & "'", conn)
                Dim ms As New MemoryStream
                PIC1.Image.Save(ms, PIC1.Image.RawFormat)
                cmd.Parameters.Add("@gambar", OleDbType.Binary).Value = ms.ToArray
                cmd.ExecuteNonQuery()
            End If

            Bersih(Me)
            tampil()
            TGL.Focus()
            namafile.Text = ""
            TXTID.ReadOnly = True
        End If

        Exit Sub
Handle:
        MsgBox("Silahkan Isi Gambar !", vbInformation, "Data Pegawai")
    End Sub

    Private Sub CMDPILIH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPILIH.Click
        opf.Filter = "Chose Image (*.JPG;*.PNG;*.GIF) |*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PIC1.Image = Image.FromFile(opf.FileName)
            namafile.Text = opf.FileName
        End If
    End Sub


    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error GoTo handle

        cmd = New OleDbCommand("Select * From surat_keluar Where no_surat='" & DGV.SelectedRows(0).Cells(0).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TXTID.Text = dr!no_surat
            TGL.Text = dr!tanggal
            CMBJENIS.Text = dr!jenis_Surat
            TXTDES.Text = dr!deskripsi
            TXTTUJUAN.Text = dr!tujuan
            CMBPEGAWAI.Text = dr!pegawai

            'gambar
            Dim ms As New MemoryStream(CType(dr.Item("Gambar"), Byte()))
            Dim img As Image = Image.FromStream(ms)
            PIC1.Image = img

        End If

        Exit Sub
handle:

    End Sub

    Private Sub CMDHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDHAPUS.Click
        Dim conf = MsgBox("Hapus Data Surat Keluar " & TXTID.Text & " ?", vbQuestion + vbYesNo, "Data Surat Keluar")
        If conf = vbYes Then
            cmd = New OleDbCommand("Delete From Surat_Keluar Where No_Surat='" & TXTID.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Bersih(Me)
            tampil()
            TGL.Focus()
        End If
    End Sub

    Private Sub TXTCARI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCARI.TextChanged
        da = New OleDbDataAdapter("Select No_Surat,Tanggal,Jenis_Surat,Deskripsi,Tujuan,pegawai.nama_Pegawai from pegawai,Surat_Keluar where no_Surat like '%" & TXTCARI.Text & "%' or Tanggal like '%" & TXTCARI.Text & "%' or Jenis_Surat like '%" & TXTCARI.Text & "%' or Deskripsi like '%" & TXTCARI.Text & "%' or Tujuan like '%" & TXTCARI.Text & "%' or Pegawai like '%" & TXTCARI.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TXTID.ReadOnly = False
        TXTID.Focus()
    End Sub
End Class