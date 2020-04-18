<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Keluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TGL = New System.Windows.Forms.DateTimePicker()
        Me.CMBJENIS = New System.Windows.Forms.ComboBox()
        Me.CMDTUTUP = New System.Windows.Forms.Button()
        Me.CMDBATAL = New System.Windows.Forms.Button()
        Me.CMDHAPUS = New System.Windows.Forms.Button()
        Me.CMDPILIH = New System.Windows.Forms.Button()
        Me.CMDSIMPAN = New System.Windows.Forms.Button()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTTUJUAN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTDES = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBPEGAWAI = New System.Windows.Forms.ComboBox()
        Me.PIC1 = New System.Windows.Forms.PictureBox()
        Me.namafile = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TGL
        '
        Me.TGL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TGL.Location = New System.Drawing.Point(119, 40)
        Me.TGL.Name = "TGL"
        Me.TGL.Size = New System.Drawing.Size(300, 26)
        Me.TGL.TabIndex = 0
        '
        'CMBJENIS
        '
        Me.CMBJENIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMBJENIS.FormattingEnabled = True
        Me.CMBJENIS.Location = New System.Drawing.Point(119, 75)
        Me.CMBJENIS.Name = "CMBJENIS"
        Me.CMBJENIS.Size = New System.Drawing.Size(300, 26)
        Me.CMBJENIS.TabIndex = 1
        '
        'CMDTUTUP
        '
        Me.CMDTUTUP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDTUTUP.Location = New System.Drawing.Point(363, 289)
        Me.CMDTUTUP.Name = "CMDTUTUP"
        Me.CMDTUTUP.Size = New System.Drawing.Size(75, 30)
        Me.CMDTUTUP.TabIndex = 9
        Me.CMDTUTUP.Text = "Tutup"
        Me.CMDTUTUP.UseVisualStyleBackColor = True
        '
        'CMDBATAL
        '
        Me.CMDBATAL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDBATAL.Location = New System.Drawing.Point(282, 289)
        Me.CMDBATAL.Name = "CMDBATAL"
        Me.CMDBATAL.Size = New System.Drawing.Size(75, 30)
        Me.CMDBATAL.TabIndex = 8
        Me.CMDBATAL.Text = "Batal"
        Me.CMDBATAL.UseVisualStyleBackColor = True
        '
        'CMDHAPUS
        '
        Me.CMDHAPUS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDHAPUS.Location = New System.Drawing.Point(201, 289)
        Me.CMDHAPUS.Name = "CMDHAPUS"
        Me.CMDHAPUS.Size = New System.Drawing.Size(75, 30)
        Me.CMDHAPUS.TabIndex = 7
        Me.CMDHAPUS.Text = "Hapus"
        Me.CMDHAPUS.UseVisualStyleBackColor = True
        '
        'CMDPILIH
        '
        Me.CMDPILIH.Location = New System.Drawing.Point(119, 243)
        Me.CMDPILIH.Name = "CMDPILIH"
        Me.CMDPILIH.Size = New System.Drawing.Size(56, 24)
        Me.CMDPILIH.TabIndex = 5
        Me.CMDPILIH.Text = "...."
        Me.CMDPILIH.UseVisualStyleBackColor = True
        '
        'CMDSIMPAN
        '
        Me.CMDSIMPAN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDSIMPAN.Location = New System.Drawing.Point(120, 289)
        Me.CMDSIMPAN.Name = "CMDSIMPAN"
        Me.CMDSIMPAN.Size = New System.Drawing.Size(75, 30)
        Me.CMDSIMPAN.TabIndex = 6
        Me.CMDSIMPAN.Text = "Simpan"
        Me.CMDSIMPAN.UseVisualStyleBackColor = True
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TXTCARI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTCARI.Location = New System.Drawing.Point(563, 296)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(279, 26)
        Me.TXTCARI.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Cari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Pilih Gambar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Pegawai"
        '
        'TXTTUJUAN
        '
        Me.TXTTUJUAN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTTUJUAN.Location = New System.Drawing.Point(119, 179)
        Me.TXTTUJUAN.Name = "TXTTUJUAN"
        Me.TXTTUJUAN.Size = New System.Drawing.Size(541, 26)
        Me.TXTTUJUAN.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Tujuan"
        '
        'TXTDES
        '
        Me.TXTDES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTDES.Location = New System.Drawing.Point(119, 107)
        Me.TXTDES.Multiline = True
        Me.TXTDES.Name = "TXTDES"
        Me.TXTDES.Size = New System.Drawing.Size(541, 66)
        Me.TXTDES.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Jenis Surat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Tanggal"
        '
        'TXTID
        '
        Me.TXTID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTID.Location = New System.Drawing.Point(119, 8)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.ReadOnly = True
        Me.TXTID.Size = New System.Drawing.Size(391, 26)
        Me.TXTID.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "No Surat"
        '
        'CMBPEGAWAI
        '
        Me.CMBPEGAWAI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMBPEGAWAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPEGAWAI.FormattingEnabled = True
        Me.CMBPEGAWAI.Location = New System.Drawing.Point(119, 211)
        Me.CMBPEGAWAI.Name = "CMBPEGAWAI"
        Me.CMBPEGAWAI.Size = New System.Drawing.Size(300, 26)
        Me.CMBPEGAWAI.TabIndex = 4
        '
        'PIC1
        '
        Me.PIC1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PIC1.Location = New System.Drawing.Point(672, 12)
        Me.PIC1.Name = "PIC1"
        Me.PIC1.Size = New System.Drawing.Size(170, 220)
        Me.PIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC1.TabIndex = 52
        Me.PIC1.TabStop = False
        '
        'namafile
        '
        Me.namafile.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namafile.Location = New System.Drawing.Point(181, 247)
        Me.namafile.Name = "namafile"
        Me.namafile.Size = New System.Drawing.Size(660, 16)
        Me.namafile.TabIndex = 53
        Me.namafile.Text = "-"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.Color.Gray
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.Black
        Me.DGV.Location = New System.Drawing.Point(0, 328)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(853, 248)
        Me.DGV.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(516, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 26)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Custom"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 576)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.namafile)
        Me.Controls.Add(Me.PIC1)
        Me.Controls.Add(Me.TGL)
        Me.Controls.Add(Me.CMBPEGAWAI)
        Me.Controls.Add(Me.CMBJENIS)
        Me.Controls.Add(Me.CMDTUTUP)
        Me.Controls.Add(Me.CMDBATAL)
        Me.Controls.Add(Me.CMDHAPUS)
        Me.Controls.Add(Me.CMDPILIH)
        Me.Controls.Add(Me.CMDSIMPAN)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTTUJUAN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTDES)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(870, 614)
        Me.Name = "Frm_Keluar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Surat Keluar"
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TGL As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBJENIS As System.Windows.Forms.ComboBox
    Friend WithEvents CMDTUTUP As System.Windows.Forms.Button
    Friend WithEvents CMDBATAL As System.Windows.Forms.Button
    Friend WithEvents CMDHAPUS As System.Windows.Forms.Button
    Friend WithEvents CMDPILIH As System.Windows.Forms.Button
    Friend WithEvents CMDSIMPAN As System.Windows.Forms.Button
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTTUJUAN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTDES As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMBPEGAWAI As System.Windows.Forms.ComboBox
    Friend WithEvents PIC1 As System.Windows.Forms.PictureBox
    Friend WithEvents namafile As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
