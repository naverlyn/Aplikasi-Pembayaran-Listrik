<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tarif
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.daya_text = New System.Windows.Forms.TextBox()
        Me.tarif_text = New System.Windows.Forms.TextBox()
        Me.tables = New System.Windows.Forms.DataGridView()
        Me.saving = New System.Windows.Forms.Button()
        Me.refreshing = New System.Windows.Forms.Button()
        Me.deleting = New System.Windows.Forms.Button()
        Me.canceling = New System.Windows.Forms.Button()
        Me.kode_text = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.tables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Tarif :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Daya Tarif :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tarif /kwH :"
        '
        'daya_text
        '
        Me.daya_text.Location = New System.Drawing.Point(80, 33)
        Me.daya_text.Name = "daya_text"
        Me.daya_text.Size = New System.Drawing.Size(253, 20)
        Me.daya_text.TabIndex = 5
        Me.daya_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tarif_text
        '
        Me.tarif_text.Location = New System.Drawing.Point(80, 59)
        Me.tarif_text.Name = "tarif_text"
        Me.tarif_text.Size = New System.Drawing.Size(253, 20)
        Me.tarif_text.TabIndex = 6
        Me.tarif_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tables
        '
        Me.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tables.Location = New System.Drawing.Point(12, 158)
        Me.tables.Name = "tables"
        Me.tables.Size = New System.Drawing.Size(372, 323)
        Me.tables.TabIndex = 8
        '
        'saving
        '
        Me.saving.Location = New System.Drawing.Point(15, 97)
        Me.saving.Name = "saving"
        Me.saving.Size = New System.Drawing.Size(75, 23)
        Me.saving.TabIndex = 9
        Me.saving.Text = "Save"
        Me.saving.UseVisualStyleBackColor = True
        '
        'refreshing
        '
        Me.refreshing.Location = New System.Drawing.Point(96, 97)
        Me.refreshing.Name = "refreshing"
        Me.refreshing.Size = New System.Drawing.Size(75, 23)
        Me.refreshing.TabIndex = 10
        Me.refreshing.Text = "Refresh"
        Me.refreshing.UseVisualStyleBackColor = True
        '
        'deleting
        '
        Me.deleting.Location = New System.Drawing.Point(177, 97)
        Me.deleting.Name = "deleting"
        Me.deleting.Size = New System.Drawing.Size(75, 23)
        Me.deleting.TabIndex = 11
        Me.deleting.Text = "Delete"
        Me.deleting.UseVisualStyleBackColor = True
        '
        'canceling
        '
        Me.canceling.Location = New System.Drawing.Point(258, 97)
        Me.canceling.Name = "canceling"
        Me.canceling.Size = New System.Drawing.Size(75, 23)
        Me.canceling.TabIndex = 12
        Me.canceling.Text = "Cancel"
        Me.canceling.UseVisualStyleBackColor = True
        '
        'kode_text
        '
        Me.kode_text.FormattingEnabled = True
        Me.kode_text.Items.AddRange(New Object() {"KT45", "KT90", "KT130", "KT220", "KT660"})
        Me.kode_text.Location = New System.Drawing.Point(80, 6)
        Me.kode_text.Name = "kode_text"
        Me.kode_text.Size = New System.Drawing.Size(253, 21)
        Me.kode_text.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "/kwH"
        '
        'tarif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 493)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.kode_text)
        Me.Controls.Add(Me.canceling)
        Me.Controls.Add(Me.deleting)
        Me.Controls.Add(Me.refreshing)
        Me.Controls.Add(Me.saving)
        Me.Controls.Add(Me.tables)
        Me.Controls.Add(Me.tarif_text)
        Me.Controls.Add(Me.daya_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tarif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tarif"
        CType(Me.tables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents daya_text As TextBox
    Friend WithEvents tarif_text As TextBox
    Friend WithEvents tables As DataGridView
    Friend WithEvents saving As Button
    Friend WithEvents refreshing As Button
    Friend WithEvents deleting As Button
    Friend WithEvents canceling As Button
    Friend WithEvents kode_text As ComboBox
    Friend WithEvents Label5 As Label
End Class
