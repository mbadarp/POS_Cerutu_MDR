<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataPelanggan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(925, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Lihat Data Pelanggan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataPelanggan
        '
        Me.DataPelanggan.ActiveViewIndex = -1
        Me.DataPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataPelanggan.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataPelanggan.Location = New System.Drawing.Point(0, 47)
        Me.DataPelanggan.Name = "DataPelanggan"
        Me.DataPelanggan.Size = New System.Drawing.Size(1078, 476)
        Me.DataPelanggan.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(923, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 524)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataPelanggan)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormLaporan"
        Me.Text = "FormLaporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataPelanggan As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
