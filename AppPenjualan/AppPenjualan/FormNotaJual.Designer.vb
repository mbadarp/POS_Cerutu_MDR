<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotaJual
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
        Me.CRV_struk = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRV_strukjual1 = New AppPenjualan.CRV_strukjual()
        Me.SuspendLayout()
        '
        'CRV_struk
        '
        Me.CRV_struk.ActiveViewIndex = 0
        Me.CRV_struk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_struk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_struk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_struk.Location = New System.Drawing.Point(0, 0)
        Me.CRV_struk.Name = "CRV_struk"
        Me.CRV_struk.ReportSource = Me.CRV_strukjual1
        Me.CRV_struk.Size = New System.Drawing.Size(588, 439)
        Me.CRV_struk.TabIndex = 0
        Me.CRV_struk.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormNotaJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 439)
        Me.Controls.Add(Me.CRV_struk)
        Me.Name = "FormNotaJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNotaJual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV_struk As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRV_strukjual1 As AppPenjualan.CRV_strukjual
End Class
