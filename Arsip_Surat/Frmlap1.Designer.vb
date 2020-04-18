<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlap1
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
        Me.Crpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Lap11 = New Arsip_Surat.Lap1()
        Me.SuspendLayout()
        '
        'Crpt
        '
        Me.Crpt.ActiveViewIndex = 0
        Me.Crpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crpt.Location = New System.Drawing.Point(0, 0)
        Me.Crpt.Name = "Crpt"
        Me.Crpt.ReportSource = Me.Lap11
        Me.Crpt.Size = New System.Drawing.Size(793, 502)
        Me.Crpt.TabIndex = 0
        Me.Crpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frmlap1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 502)
        Me.Controls.Add(Me.Crpt)
        Me.Name = "Frmlap1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Data Pegawai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Lap11 As Arsip_Surat.Lap1
End Class
