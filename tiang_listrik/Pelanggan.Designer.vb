<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_text = New System.Windows.Forms.TextBox()
        Me.meter_text = New System.Windows.Forms.TextBox()
        Me.nama_text = New System.Windows.Forms.TextBox()
        Me.alamat_text = New System.Windows.Forms.TextBox()
        Me.tarif_text1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.table = New System.Windows.Forms.DataGridView()
        Me.saving = New System.Windows.Forms.Button()
        Me.deleting = New System.Windows.Forms.Button()
        Me.refreshing = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.search_text = New System.Windows.Forms.TextBox()
        Me.searching = New System.Windows.Forms.Button()
        Me.canceling = New System.Windows.Forms.Button()
        Me.tarif_text = New System.Windows.Forms.ComboBox()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pelanggan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Meter :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat Pelanggan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Tarif :"
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(121, 281)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(232, 20)
        Me.id_text.TabIndex = 5
        '
        'meter_text
        '
        Me.meter_text.Location = New System.Drawing.Point(121, 307)
        Me.meter_text.Name = "meter_text"
        Me.meter_text.Size = New System.Drawing.Size(232, 20)
        Me.meter_text.TabIndex = 6
        '
        'nama_text
        '
        Me.nama_text.Location = New System.Drawing.Point(121, 333)
        Me.nama_text.Name = "nama_text"
        Me.nama_text.Size = New System.Drawing.Size(232, 20)
        Me.nama_text.TabIndex = 7
        '
        'alamat_text
        '
        Me.alamat_text.Location = New System.Drawing.Point(121, 359)
        Me.alamat_text.Name = "alamat_text"
        Me.alamat_text.Size = New System.Drawing.Size(232, 20)
        Me.alamat_text.TabIndex = 8
        '
        'tarif_text1
        '
        Me.tarif_text1.Location = New System.Drawing.Point(197, 385)
        Me.tarif_text1.Name = "tarif_text1"
        Me.tarif_text1.Size = New System.Drawing.Size(156, 20)
        Me.tarif_text1.TabIndex = 10
        Me.tarif_text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "-"
        '
        'table
        '
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Location = New System.Drawing.Point(12, 12)
        Me.table.Name = "table"
        Me.table.Size = New System.Drawing.Size(740, 262)
        Me.table.TabIndex = 12
        '
        'saving
        '
        Me.saving.Location = New System.Drawing.Point(16, 421)
        Me.saving.Name = "saving"
        Me.saving.Size = New System.Drawing.Size(92, 23)
        Me.saving.TabIndex = 13
        Me.saving.Text = "Save / Update"
        Me.saving.UseVisualStyleBackColor = True
        '
        'deleting
        '
        Me.deleting.Location = New System.Drawing.Point(116, 421)
        Me.deleting.Name = "deleting"
        Me.deleting.Size = New System.Drawing.Size(75, 23)
        Me.deleting.TabIndex = 14
        Me.deleting.Text = "Delete"
        Me.deleting.UseVisualStyleBackColor = True
        '
        'refreshing
        '
        Me.refreshing.Location = New System.Drawing.Point(197, 421)
        Me.refreshing.Name = "refreshing"
        Me.refreshing.Size = New System.Drawing.Size(75, 23)
        Me.refreshing.TabIndex = 15
        Me.refreshing.Text = "Refresh"
        Me.refreshing.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cari Pelanggan :"
        '
        'search_text
        '
        Me.search_text.Location = New System.Drawing.Point(499, 281)
        Me.search_text.Name = "search_text"
        Me.search_text.Size = New System.Drawing.Size(172, 20)
        Me.search_text.TabIndex = 17
        '
        'searching
        '
        Me.searching.Location = New System.Drawing.Point(677, 280)
        Me.searching.Name = "searching"
        Me.searching.Size = New System.Drawing.Size(75, 23)
        Me.searching.TabIndex = 18
        Me.searching.Text = "Search"
        Me.searching.UseVisualStyleBackColor = True
        '
        'canceling
        '
        Me.canceling.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.canceling.Location = New System.Drawing.Point(278, 421)
        Me.canceling.Name = "canceling"
        Me.canceling.Size = New System.Drawing.Size(75, 23)
        Me.canceling.TabIndex = 20
        Me.canceling.Text = "Cancel"
        Me.canceling.UseVisualStyleBackColor = True
        '
        'tarif_text
        '
        Me.tarif_text.FormattingEnabled = True
        Me.tarif_text.Items.AddRange(New Object() {"KT45", "KT90", "KT130", "KT220", "KT660"})
        Me.tarif_text.Location = New System.Drawing.Point(121, 385)
        Me.tarif_text.Name = "tarif_text"
        Me.tarif_text.Size = New System.Drawing.Size(54, 21)
        Me.tarif_text.TabIndex = 21
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 477)
        Me.Controls.Add(Me.tarif_text)
        Me.Controls.Add(Me.canceling)
        Me.Controls.Add(Me.searching)
        Me.Controls.Add(Me.search_text)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.refreshing)
        Me.Controls.Add(Me.deleting)
        Me.Controls.Add(Me.saving)
        Me.Controls.Add(Me.table)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tarif_text1)
        Me.Controls.Add(Me.alamat_text)
        Me.Controls.Add(Me.nama_text)
        Me.Controls.Add(Me.meter_text)
        Me.Controls.Add(Me.id_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents id_text As TextBox
    Friend WithEvents meter_text As TextBox
    Friend WithEvents nama_text As TextBox
    Friend WithEvents alamat_text As TextBox
    Friend WithEvents tarif_text1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents table As DataGridView
    Friend WithEvents saving As Button
    Friend WithEvents deleting As Button
    Friend WithEvents refreshing As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents search_text As TextBox
    Friend WithEvents searching As Button
    Friend WithEvents canceling As Button
    Friend WithEvents tarif_text As ComboBox
End Class
