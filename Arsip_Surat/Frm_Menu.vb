Imports System.Data.OleDb
Imports System.IO
Public Class Frm_Menu
    Sub tampil()
        da = New OleDbDataAdapter("Select No_Disposisi,Tanggal,Pegawai.Nama_Pegawai,No_Surat,Jenis_Surat,Isi_Disposisi,Status from Disposisi,pegawai where disposisi.no_pegawai like '%" & txtno.Text & "%' and pegawai.no_pegawai=disposisi.no_pegawai", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).HeaderText = "No Disposisi"
        DGV.Columns(2).HeaderText = "Nama Pegawai"
        DGV.Columns(3).HeaderText = "No Surat"
        DGV.Columns(4).HeaderText = "Jenis Surat"
        DGV.Columns(5).HeaderText = "Isi Disposisi"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim conf = MsgBox("Tutup Aplikasi ?", vbQuestion + vbYesNo, "Arsip Surat Smk Muma")
        If conf = vbYes Then
            End
        End If
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim conf = MsgBox("Anda yakin Akan Logout ?", vbQuestion + vbYesNo, "Arsip Surat Smk Muma")
        If conf = vbYes Then
            Kendali.Timer1.Enabled = True
            Close()
        End If
    End Sub

    Private Sub TambahDataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataPegawaiToolStripMenuItem.Click
        Frm_Pegawai.ShowDialog()
    End Sub

    Private Sub DataSuratKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSuratKeluarToolStripMenuItem.Click
        Frm_Keluar.ShowDialog()
    End Sub

    Private Sub DataSuratMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSuratMasukToolStripMenuItem.Click
        Frm_Masuk.ShowDialog()
    End Sub

    Private Sub DisposisiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisposisiToolStripMenuItem.Click
        Disposisi.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jam.Text = Now
        If UP.Text = "Yes" Then
            UbahPasswordToolStripMenuItem.Enabled = True
        Else
            UbahPasswordToolStripMenuItem.Enabled = False
        End If

        If DP.Text = "Yes" Then
            TambahDataPegawaiToolStripMenuItem.Enabled = True
        Else
            TambahDataPegawaiToolStripMenuItem.Enabled = False
        End If

        If LP.Text = "Yes" Then
            LaporanToolStripMenuItem.Enabled = True
        Else
            LaporanToolStripMenuItem.Enabled = False
        End If

        If SM.Text = "Yes" Then
            DataSuratMasukToolStripMenuItem.Enabled = True
        Else
            DataSuratMasukToolStripMenuItem.Enabled = False
        End If

        If SK.Text = "Yes" Then
            DataSuratKeluarToolStripMenuItem.Enabled = True
        Else
            DataSuratKeluarToolStripMenuItem.Enabled = False
        End If

        If DiS.Text = "Yes" Then
            DisposisiToolStripMenuItem.Enabled = True
        Else
            DisposisiToolStripMenuItem.Enabled = False
        End If

        munculkandatasaya()
    End Sub

    Private Sub Frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()
    End Sub

    Sub munculkandatasaya()
        cmd = New OleDbCommand("Select * From Pegawai Where No_Pegawai='" & txtno.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            UP.Text = dr("UP")
            DP.Text = dr("DP")
            LP.Text = dr("LP")
            SM.Text = dr("SM")
            SK.Text = dr("SK")
            DiS.Text = dr("DS")

            txtnama.Text = dr(1)
            txtjk.Text = dr(2)
            txtjab.Text = dr(3)
            txtuser.Text = dr("username")

            Me.Text = "Arsip Surat Smk Muhmammadiyah Majenang " + "- Login[ " + dr(1) + " ]"

            Dim ms As New MemoryStream(CType(dr.Item("Gambar"), Byte()))
            Dim img As Image = Image.FromStream(ms)
            gbr.Image = img
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        tampil()
        For i = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(6).Value = "Diterima" Then
                DGV.Rows(i).DefaultCellStyle.BackColor = Color.LightSeaGreen
            End If
        Next

    End Sub

    Private Sub SuratKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratKeluarToolStripMenuItem.Click
        Timer1.Stop()
        Timer2.Stop()
        FrmLap2.ShowDialog()
    End Sub

    Private Sub SuratMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratMasukToolStripMenuItem.Click
        Timer1.Stop()
        Timer2.Stop()
        FrmLap3.ShowDialog()
    End Sub

    Private Sub DisposisiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisposisiToolStripMenuItem1.Click
        Timer1.Stop()
        Timer2.Stop()
        FrmLap4.ShowDialog()
    End Sub

  
    Private Sub DataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        Timer1.Stop()
        Timer2.Stop()
        Frmlap1.ShowDialog()
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        cmd = New OleDbCommand("Select * From Surat_Masuk Where No_Surat='" & DGV.SelectedRows(0).Cells(3).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim ms As New MemoryStream(CType(dr.Item("Gambar"), Byte()))
            Dim img As Image = Image.FromStream(ms)
            FrmTerima.Gbr.Image = img
        End If
        FrmTerima.ShowDialog()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        Frm_Password.txtno.Text = txtno.Text
        Frm_Password.ShowDialog()
    End Sub
End Class