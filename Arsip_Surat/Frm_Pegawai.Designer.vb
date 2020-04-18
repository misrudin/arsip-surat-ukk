<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pegawai
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pegawai))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.CMDSIMPAN = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpas = New System.Windows.Forms.TextBox()
        Me.cmbjk = New System.Windows.Forms.ComboBox()
        Me.cmbjab = New System.Windows.Forms.ComboBox()
        Me.CMDHAPUS = New System.Windows.Forms.Button()
        Me.CMDBATAL = New System.Windows.Forms.Button()
        Me.CMDTUTUP = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.SM = New System.Windows.Forms.CheckBox()
        Me.SK = New System.Windows.Forms.CheckBox()
        Me.DIS = New System.Windows.Forms.CheckBox()
        Me.UP = New System.Windows.Forms.CheckBox()
        Me.DP = New System.Windows.Forms.CheckBox()
        Me.LP = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pegawai"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txtid
        '
        Me.Txtid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtid.Location = New System.Drawing.Point(126, 15)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(369, 26)
        Me.Txtid.TabIndex = 0
        '
        'CMDSIMPAN
        '
        Me.CMDSIMPAN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDSIMPAN.Location = New System.Drawing.Point(160, 359)
        Me.CMDSIMPAN.Name = "CMDSIMPAN"
        Me.CMDSIMPAN.Size = New System.Drawing.Size(75, 30)
        Me.CMDSIMPAN.TabIndex = 17
        Me.CMDSIMPAN.Text = "Simpan"
        Me.CMDSIMPAN.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.Color.Gray
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.Black
        Me.DGV.Location = New System.Drawing.Point(1, 398)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(928, 183)
        Me.DGV.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(21, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Pegawai"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnama
        '
        Me.txtnama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnama.Location = New System.Drawing.Point(126, 47)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(639, 26)
        Me.txtnama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(21, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(21, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jabatan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(21, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ALamat"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtalamat
        '
        Me.txtalamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtalamat.Location = New System.Drawing.Point(126, 142)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(639, 50)
        Me.txtalamat.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(21, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "No Telepon"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtno
        '
        Me.txtno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtno.Location = New System.Drawing.Point(126, 262)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(369, 26)
        Me.txtno.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(21, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Username"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtuser
        '
        Me.txtuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtuser.Location = New System.Drawing.Point(126, 294)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(369, 26)
        Me.txtuser.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(21, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpas
        '
        Me.txtpas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpas.Location = New System.Drawing.Point(126, 323)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.Size = New System.Drawing.Size(369, 26)
        Me.txtpas.TabIndex = 9
        Me.txtpas.UseSystemPasswordChar = True
        '
        'cmbjk
        '
        Me.cmbjk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbjk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjk.FormattingEnabled = True
        Me.cmbjk.Location = New System.Drawing.Point(126, 79)
        Me.cmbjk.Name = "cmbjk"
        Me.cmbjk.Size = New System.Drawing.Size(369, 26)
        Me.cmbjk.TabIndex = 2
        '
        'cmbjab
        '
        Me.cmbjab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbjab.FormattingEnabled = True
        Me.cmbjab.Location = New System.Drawing.Point(126, 111)
        Me.cmbjab.Name = "cmbjab"
        Me.cmbjab.Size = New System.Drawing.Size(369, 26)
        Me.cmbjab.TabIndex = 3
        '
        'CMDHAPUS
        '
        Me.CMDHAPUS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDHAPUS.Location = New System.Drawing.Point(241, 359)
        Me.CMDHAPUS.Name = "CMDHAPUS"
        Me.CMDHAPUS.Size = New System.Drawing.Size(75, 30)
        Me.CMDHAPUS.TabIndex = 18
        Me.CMDHAPUS.Text = "Hapus"
        Me.CMDHAPUS.UseVisualStyleBackColor = True
        '
        'CMDBATAL
        '
        Me.CMDBATAL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDBATAL.Location = New System.Drawing.Point(322, 359)
        Me.CMDBATAL.Name = "CMDBATAL"
        Me.CMDBATAL.Size = New System.Drawing.Size(75, 30)
        Me.CMDBATAL.TabIndex = 19
        Me.CMDBATAL.Text = "Batal"
        Me.CMDBATAL.UseVisualStyleBackColor = True
        '
        'CMDTUTUP
        '
        Me.CMDTUTUP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMDTUTUP.Location = New System.Drawing.Point(403, 359)
        Me.CMDTUTUP.Name = "CMDTUTUP"
        Me.CMDTUTUP.Size = New System.Drawing.Size(75, 30)
        Me.CMDTUTUP.TabIndex = 20
        Me.CMDTUTUP.Text = "Tutup"
        Me.CMDTUTUP.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(567, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cari"
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(605, 366)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(312, 26)
        Me.TXTCARI.TabIndex = 21
        '
        'SM
        '
        Me.SM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SM.AutoSize = True
        Me.SM.Location = New System.Drawing.Point(677, 247)
        Me.SM.Name = "SM"
        Me.SM.Size = New System.Drawing.Size(102, 22)
        Me.SM.TabIndex = 13
        Me.SM.Text = "Surat Masuk"
        Me.SM.UseVisualStyleBackColor = True
        '
        'SK
        '
        Me.SK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SK.AutoSize = True
        Me.SK.Location = New System.Drawing.Point(677, 269)
        Me.SK.Name = "SK"
        Me.SK.Size = New System.Drawing.Size(109, 22)
        Me.SK.TabIndex = 14
        Me.SK.Text = "Surat Kelauar"
        Me.SK.UseVisualStyleBackColor = True
        '
        'DIS
        '
        Me.DIS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIS.AutoSize = True
        Me.DIS.Location = New System.Drawing.Point(677, 289)
        Me.DIS.Name = "DIS"
        Me.DIS.Size = New System.Drawing.Size(82, 22)
        Me.DIS.TabIndex = 15
        Me.DIS.Text = "Disposisi"
        Me.DIS.UseVisualStyleBackColor = True
        '
        'UP
        '
        Me.UP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UP.AutoSize = True
        Me.UP.Location = New System.Drawing.Point(541, 247)
        Me.UP.Name = "UP"
        Me.UP.Size = New System.Drawing.Size(121, 22)
        Me.UP.TabIndex = 10
        Me.UP.Text = "Ubah Password"
        Me.UP.UseVisualStyleBackColor = True
        '
        'DP
        '
        Me.DP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DP.AutoSize = True
        Me.DP.Location = New System.Drawing.Point(541, 269)
        Me.DP.Name = "DP"
        Me.DP.Size = New System.Drawing.Size(110, 22)
        Me.DP.TabIndex = 11
        Me.DP.Text = "Data Pegawai"
        Me.DP.UseVisualStyleBackColor = True
        '
        'LP
        '
        Me.LP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LP.AutoSize = True
        Me.LP.Location = New System.Drawing.Point(541, 289)
        Me.LP.Name = "LP"
        Me.LP.Size = New System.Drawing.Size(76, 22)
        Me.LP.TabIndex = 12
        Me.LP.Text = "Laporan"
        Me.LP.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Chocolate
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(536, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(243, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Akses Aplikasi"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic1
        '
        Me.Pic1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic1.ErrorImage = CType(resources.GetObject("Pic1.ErrorImage"), System.Drawing.Image)
        Me.Pic1.Location = New System.Drawing.Point(780, 22)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(127, 156)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 6
        Me.Pic1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(780, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 24)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "...."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(21, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Tanggal Lahir"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(21, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Tanggal Masuk"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tgl1
        '
        Me.tgl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tgl1.Location = New System.Drawing.Point(126, 198)
        Me.tgl1.Name = "tgl1"
        Me.tgl1.Size = New System.Drawing.Size(369, 26)
        Me.tgl1.TabIndex = 5
        '
        'tgl2
        '
        Me.tgl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tgl2.Location = New System.Drawing.Point(126, 230)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(369, 26)
        Me.tgl2.TabIndex = 6
        '
        'Frm_Pegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 581)
        Me.Controls.Add(Me.tgl2)
        Me.Controls.Add(Me.tgl1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.LP)
        Me.Controls.Add(Me.DP)
        Me.Controls.Add(Me.UP)
        Me.Controls.Add(Me.DIS)
        Me.Controls.Add(Me.SK)
        Me.Controls.Add(Me.SM)
        Me.Controls.Add(Me.cmbjk)
        Me.Controls.Add(Me.cmbjab)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.CMDTUTUP)
        Me.Controls.Add(Me.CMDBATAL)
        Me.Controls.Add(Me.CMDHAPUS)
        Me.Controls.Add(Me.CMDSIMPAN)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(945, 619)
        Me.Name = "Frm_Pegawai"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pegawai"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents CMDSIMPAN As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpas As System.Windows.Forms.TextBox
    Friend WithEvents cmbjk As System.Windows.Forms.ComboBox
    Friend WithEvents cmbjab As System.Windows.Forms.ComboBox
    Friend WithEvents CMDHAPUS As System.Windows.Forms.Button
    Friend WithEvents CMDBATAL As System.Windows.Forms.Button
    Friend WithEvents CMDTUTUP As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents SM As System.Windows.Forms.CheckBox
    Friend WithEvents SK As System.Windows.Forms.CheckBox
    Friend WithEvents DIS As System.Windows.Forms.CheckBox
    Friend WithEvents UP As System.Windows.Forms.CheckBox
    Friend WithEvents DP As System.Windows.Forms.CheckBox
    Friend WithEvents LP As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker

End Class
