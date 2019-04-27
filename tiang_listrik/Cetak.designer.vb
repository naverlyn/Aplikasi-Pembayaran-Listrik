<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak
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
        Me.struk = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'struk
        '
        Me.struk.ActiveViewIndex = -1
        Me.struk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.struk.Cursor = System.Windows.Forms.Cursors.Default
        Me.struk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.struk.Location = New System.Drawing.Point(0, 0)
        Me.struk.Name = "struk"
        Me.struk.Size = New System.Drawing.Size(697, 447)
        Me.struk.TabIndex = 0
        Me.struk.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 447)
        Me.Controls.Add(Me.struk)
        Me.Name = "Cetak"
        Me.Text = "cetak_struk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents struk As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
