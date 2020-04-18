<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disposisi
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TGL = New System.Windows.Forms.DateTimePicker()
        Me.CMBSURAT = New System.Windows.Forms.ComboBox()
        Me.CMBPEGAWAI = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTISI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.TXTSTATUS = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TGL
        '
        Me.TGL.Location = New System.Drawing.Point(119, 43)
        Me.TGL.Name = "TGL"
        Me.TGL.Size = New System.Drawing.Size(300, 26)
        Me.TGL.TabIndex = 0
        '
        'CMBSURAT
        '
        Me.CMBSURAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSURAT.FormattingEnabled = True
        Me.CMBSURAT.Location = New System.Drawing.Point(119, 113)
        Me.CMBSURAT.Name = "CMBSURAT"
        Me.CMBSURAT.Size = New System.Drawing.Size(300, 26)
        Me.CMBSURAT.TabIndex = 2
        '
        'CMBPEGAWAI
        '
        Me.CMBPEGAWAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPEGAWAI.FormattingEnabled = True
        Me.CMBPEGAWAI.Location = New System.Drawing.Point(119, 78)
        Me.CMBPEGAWAI.Name = "CMBPEGAWAI"
        Me.CMBPEGAWAI.Size = New System.Drawing.Size(300, 26)
        Me.CMBPEGAWAI.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(363, 323)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Tutup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(282, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(201, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXTCARI
        '
        Me.TXTCARI.Location = New System.Drawing.Point(516, 330)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(326, 26)
        Me.TXTCARI.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(478, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 18)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Cari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Isi Disposisi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Jenis Surat"
        '
        'TXTISI
        '
        Me.TXTISI.Location = New System.Drawing.Point(119, 183)
        Me.TXTISI.Multiline = True
        Me.TXTISI.Name = "TXTISI"
        Me.TXTISI.Size = New System.Drawing.Size(675, 66)
        Me.TXTISI.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "No Surat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "No Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Tanggal"
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(119, 11)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.ReadOnly = True
        Me.TXTID.Size = New System.Drawing.Size(391, 26)
        Me.TXTID.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "No Disposisi"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(429, 81)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(13, 18)
        Me.Nama.TabIndex = 59
        Me.Nama.Text = "-"
        '
        'TXTSTATUS
        '
        Me.TXTSTATUS.BackColor = System.Drawing.Color.Yellow
        Me.TXTSTATUS.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSTATUS.ForeColor = System.Drawing.Color.Red
        Me.TXTSTATUS.Location = New System.Drawing.Point(121, 260)
        Me.TXTSTATUS.Name = "TXTSTATUS"
        Me.TXTSTATUS.Size = New System.Drawing.Size(204, 30)
        Me.TXTSTATUS.TabIndex = 56
        Me.TXTSTATUS.Text = "Belum Diterima"
        Me.TXTSTATUS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DGV.Location = New System.Drawing.Point(1, 362)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(853, 216)
        Me.DGV.TabIndex = 9
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(120, 148)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.ReadOnly = True
        Me.txtjenis.Size = New System.Drawing.Size(299, 26)
        Me.txtjenis.TabIndex = 62
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Disposisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 576)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TGL)
        Me.Controls.Add(Me.CMBSURAT)
        Me.Controls.Add(Me.CMBPEGAWAI)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTSTATUS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTISI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtjenis)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(870, 614)
        Me.Name = "Disposisi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disposisi"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TGL As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBSURAT As System.Windows.Forms.ComboBox
    Friend WithEvents CMBPEGAWAI As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTISI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents TXTSTATUS As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtjenis As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
