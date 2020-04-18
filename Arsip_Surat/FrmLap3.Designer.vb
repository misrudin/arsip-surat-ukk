<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLap3
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
        Me.crpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Lap31 = New Arsip_Surat.Lap3()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'crpt
        '
        Me.crpt.ActiveViewIndex = 0
        Me.crpt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpt.Location = New System.Drawing.Point(0, 64)
        Me.crpt.Margin = New System.Windows.Forms.Padding(4)
        Me.crpt.Name = "crpt"
        Me.crpt.ReportSource = Me.Lap31
        Me.crpt.Size = New System.Drawing.Size(1029, 590)
        Me.crpt.TabIndex = 0
        Me.crpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(570, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(489, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter"
        '
        'tgl2
        '
        Me.tgl2.Location = New System.Drawing.Point(283, 12)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(200, 26)
        Me.tgl2.TabIndex = 4
        '
        'tgl1
        '
        Me.tgl1.Location = New System.Drawing.Point(77, 12)
        Me.tgl1.Name = "tgl1"
        Me.tgl1.Size = New System.Drawing.Size(200, 26)
        Me.tgl1.TabIndex = 5
        '
        'FrmLap3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 655)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tgl2)
        Me.Controls.Add(Me.tgl1)
        Me.Controls.Add(Me.crpt)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLap3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Data Surat Masuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Lap31 As Arsip_Surat.Lap3
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
End Class
