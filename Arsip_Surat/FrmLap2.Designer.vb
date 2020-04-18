<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLap2
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
        Me.CRPT = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Lap21 = New Arsip_Surat.Lap2()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'CRPT
        '
        Me.CRPT.ActiveViewIndex = 0
        Me.CRPT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRPT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRPT.Location = New System.Drawing.Point(0, 61)
        Me.CRPT.Margin = New System.Windows.Forms.Padding(4)
        Me.CRPT.Name = "CRPT"
        Me.CRPT.ReportSource = Me.Lap21
        Me.CRPT.Size = New System.Drawing.Size(1183, 531)
        Me.CRPT.TabIndex = 0
        Me.CRPT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(574, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter"
        '
        'tgl2
        '
        Me.tgl2.Location = New System.Drawing.Point(287, 12)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(200, 26)
        Me.tgl2.TabIndex = 4
        '
        'tgl1
        '
        Me.tgl1.Location = New System.Drawing.Point(81, 12)
        Me.tgl1.Name = "tgl1"
        Me.tgl1.Size = New System.Drawing.Size(200, 26)
        Me.tgl1.TabIndex = 5
        '
        'FrmLap2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 591)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tgl2)
        Me.Controls.Add(Me.tgl1)
        Me.Controls.Add(Me.CRPT)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLap2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Data Surat Keluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRPT As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Lap21 As Arsip_Surat.Lap2
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
End Class
