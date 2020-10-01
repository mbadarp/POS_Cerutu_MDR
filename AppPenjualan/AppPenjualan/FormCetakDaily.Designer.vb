<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakDaily
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
        Me.CRDaily = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(800, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CRDaily
        '
        Me.CRDaily.ActiveViewIndex = -1
        Me.CRDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRDaily.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRDaily.Location = New System.Drawing.Point(5, 63)
        Me.CRDaily.Name = "CRDaily"
        Me.CRDaily.Size = New System.Drawing.Size(779, 462)
        Me.CRDaily.TabIndex = 1
        '
        'FormCetakDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 527)
        Me.Controls.Add(Me.CRDaily)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormCetakDaily"
        Me.Text = "FormCetakDaily"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CRDaily As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
