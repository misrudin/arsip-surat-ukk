Imports System.Data.OleDb
Public Class Disposisi

    Sub tampil()
        da = New OleDbDataAdapter("Select No_Disposisi,Tanggal,pegawai.nama_Pegawai,no_Surat,jenis_Surat,isi_disposisi,Status,Operator from Disposisi,pegawai where pegawai.no_pegawai=disposisi.no_pegawai", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).HeaderText = "No Disposisi"
        DGV.Columns(2).HeaderText = "Nama Pegawai"
        DGV.Columns(3).HeaderText = "No Surat"
        DGV.Columns(4).HeaderText = "Jenis Surat"
        DGV.Columns(5).HeaderText = "Isi Disposisi"

        cmd = New OleDbCommand("Select No_Disposisi From Disposisi order by No_Disposisi desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TXTID.Text = "DISP001" + Format(Now, "ddmmyyyy")
        Else
            TXTID.Text = "DISP" + Format(Microsoft.VisualBasic.Mid(dr.Item(0), 5, 3) + 1, "000") + Format(Now, "ddmmyyyy")
        End If

        cmd = New OleDbCommand("Select * from pegawai", conn)
        dr = cmd.ExecuteReader
        CMBPEGAWAI.Items.Clear()
        While dr.Read
            CMBPEGAWAI.Items.Add(dr!no_pegawai)
        End While

        cmd = New OleDbCommand("Select * from Surat_Masuk", conn)
        dr = cmd.ExecuteReader
        CMBSURAT.Items.Clear()
        While dr.Read
            CMBSURAT.Items.Add(dr!No_Surat)
        End While
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    
    Private Sub Disposisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()
    End Sub

    Private Sub CMBSURAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBSURAT.SelectedIndexChanged
        cmd = New OleDbCommand("Select * From surat_masuk Where no_surat='" & CMBSURAT.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtjenis.Text = dr!jenis_surat
            TXTISI.Focus()
        End If
    End Sub

    Private Sub CMBPEGAWAI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBPEGAWAI.SelectedIndexChanged
        cmd = New OleDbCommand("Select * From pegawai Where no_pegawai='" & CMBPEGAWAI.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Nama.Text = "[ " + dr!nama_pegawai + " ]"
            CMBSURAT.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Bersih(Me)
        tampil()
        TGL.Focus()
        TXTSTATUS.Text = "Belum Diterima"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TXTID.Text = "" Or TXTISI.Text = "" Or txtjenis.Text = "" Or CMBPEGAWAI.Text = "" Or CMBSURAT.Text = "" Then
            MsgBox("Silahkan Lengkapi data !", vbInformation, "Data Disposisi")
        Else
            cmd = New OleDbCommand("Select * From Disposisi Where No_disposisi='" & TXTID.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                cmd = New OleDbCommand("Insert Into Disposisi (No_Disposisi,Tanggal,No_Pegawai,No_Surat,Jenis_Surat,Isi_Disposisi,Status,operator) values ('" & TXTID.Text & "','" & TGL.Value & "','" & CMBPEGAWAI.Text & "','" & CMBSURAT.Text & "','" & txtjenis.Text & "','" & TXTISI.Text & "','" & TXTSTATUS.Text & "','" & Frm_Menu.txtno.Text & "')", conn)
                cmd.ExecuteNonQuery()
            Else
                cmd = New OleDbCommand("Update Disposisi Set Tanggal='" & TGL.Value & "',No_pEGAWAI='" & CMBPEGAWAI.Text & "',No_Surat='" & CMBSURAT.Text & "',Jenis_Surat='" & txtjenis.Text & "',Isi_Disposisi='" & TXTISI.Text & "',Status='" & TXTSTATUS.Text & "',operator='" & Frm_Menu.txtno.Text & "' where No_Disposisi='" & TXTID.Text & "'", conn)
                cmd.ExecuteNonQuery()
            End If

            Bersih(Me)
            tampil()
            TGL.Focus()
            TXTSTATUS.Text = "Belum Diterima"
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        TXTID.Text = DGV.SelectedRows(0).Cells(0).Value
        TGL.Value = DGV.SelectedRows(0).Cells(1).Value
        CMBSURAT.Text = DGV.SelectedRows(0).Cells(3).Value
        txtjenis.Text = DGV.SelectedRows(0).Cells(4).Value
        TXTISI.Text = DGV.SelectedRows(0).Cells(5).Value
        TXTSTATUS.Text = DGV.SelectedRows(0).Cells(6).Value

        cmd = New OleDbCommand("Select no_pegawai From Disposisi Where No_Disposisi='" & DGV.SelectedRows(0).Cells(0).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            CMBPEGAWAI.Text = dr!No_Pegawai
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conf = MsgBox("Hapus Data Disposisi " & TXTID.Text & " ?", vbQuestion + vbYesNo, "Dats Disposisi")
        If conf = vbYes Then
            cmd = New OleDbCommand("Delete From Disposisi Where No_Disposisi='" & TXTID.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Bersih(Me)
            tampil()
            TGL.Focus()
        End If
    End Sub


    Private Sub TXTCARI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCARI.TextChanged
        da = New OleDbDataAdapter("Select No_Disposisi,tanggal,pegawai.nama_Pegawai,no_Surat,jenis_Surat,isi_disposisi,status from Disposisi,pegawai WHERE No_Disposisi LIKE '%" & TXTCARI.Text & "%' or tanggal LIKE '%" & TXTCARI.Text & "%' or disposisi.No_Pegawai LIKE '%" & TXTCARI.Text & "%' or pegawai.nama_Pegawai LIKE '%" & TXTCARI.Text & "%' or jenis_surat LIKE '%" & TXTCARI.Text & "%' or isi_disposisi LIKE '%" & TXTCARI.Text & "%' or status LIKE '%" & TXTCARI.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, 0)
        DGV.DataSource = ds.Tables(0)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TXTSTATUS.Text = "Belum Diterima" Then
            TXTSTATUS.BackColor = Color.Yellow
        ElseIf TXTSTATUS.Text = "Diterima" Then
            TXTSTATUS.BackColor = Color.LightSeaGreen
        ElseIf TXTSTATUS.Text = "Diserahkan" Then
            TXTSTATUS.BackColor = Color.Blue
        End If
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class