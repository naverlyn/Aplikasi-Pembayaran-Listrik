<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nama_blink = New System.Windows.Forms.Label()
        Me.id_pembayaran_box = New System.Windows.Forms.TextBox()
        Me.time_picker = New System.Windows.Forms.DateTimePicker()
        Me.bayar_box = New System.Windows.Forms.TextBox()
        Me.admin_box = New System.Windows.Forms.TextBox()
        Me.tables = New System.Windows.Forms.DataGridView()
        Me.saving = New System.Windows.Forms.Button()
        Me.refreshing = New System.Windows.Forms.Button()
        Me.deleting = New System.Windows.Forms.Button()
        Me.canceling = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.kode_tarif_box = New System.Windows.Forms.TextBox()
        Me.unik_box = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pemakaian_box = New System.Windows.Forms.TextBox()
        Me.daya_box = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.id_pelanggan_box = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.kebalian_box = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bayar1_box = New System.Windows.Forms.TextBox()
        Me.nometer_box = New System.Windows.Forms.TextBox()
        CType(Me.tables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pembayaran :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Pelanggan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(646, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(646, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Biaya Admin :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Pelanggan :"
        '
        'nama_blink
        '
        Me.nama_blink.AutoSize = True
        Me.nama_blink.Location = New System.Drawing.Point(550, 15)
        Me.nama_blink.Name = "nama_blink"
        Me.nama_blink.Size = New System.Drawing.Size(0, 13)
        Me.nama_blink.TabIndex = 6
        '
        'id_pembayaran_box
        '
        Me.id_pembayaran_box.Location = New System.Drawing.Point(117, 12)
        Me.id_pembayaran_box.Name = "id_pembayaran_box"
        Me.id_pembayaran_box.Size = New System.Drawing.Size(230, 20)
        Me.id_pembayaran_box.TabIndex = 7
        '
        'time_picker
        '
        Me.time_picker.CustomFormat = "yyyy/MM/dd"
        Me.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time_picker.Location = New System.Drawing.Point(751, 121)
        Me.time_picker.Name = "time_picker"
        Me.time_picker.Size = New System.Drawing.Size(230, 20)
        Me.time_picker.TabIndex = 9
        Me.time_picker.Value = New Date(2019, 3, 12, 0, 0, 0, 0)
        '
        'bayar_box
        '
        Me.bayar_box.Location = New System.Drawing.Point(751, 147)
        Me.bayar_box.Name = "bayar_box"
        Me.bayar_box.Size = New System.Drawing.Size(230, 20)
        Me.bayar_box.TabIndex = 10
        '
        'admin_box
        '
        Me.admin_box.Location = New System.Drawing.Point(751, 173)
        Me.admin_box.Name = "admin_box"
        Me.admin_box.Size = New System.Drawing.Size(230, 20)
        Me.admin_box.TabIndex = 11
        '
        'tables
        '
        Me.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tables.Location = New System.Drawing.Point(12, 285)
        Me.tables.Name = "tables"
        Me.tables.Size = New System.Drawing.Size(969, 197)
        Me.tables.TabIndex = 12
        '
        'saving
        '
        Me.saving.Location = New System.Drawing.Point(17, 224)
        Me.saving.Name = "saving"
        Me.saving.Size = New System.Drawing.Size(94, 23)
        Me.saving.TabIndex = 13
        Me.saving.Text = "Save / Update"
        Me.saving.UseVisualStyleBackColor = True
        '
        'refreshing
        '
        Me.refreshing.Location = New System.Drawing.Point(117, 224)
        Me.refreshing.Name = "refreshing"
        Me.refreshing.Size = New System.Drawing.Size(75, 23)
        Me.refreshing.TabIndex = 14
        Me.refreshing.Text = "Refresh"
        Me.refreshing.UseVisualStyleBackColor = True
        '
        'deleting
        '
        Me.deleting.Location = New System.Drawing.Point(198, 224)
        Me.deleting.Name = "deleting"
        Me.deleting.Size = New System.Drawing.Size(75, 23)
        Me.deleting.TabIndex = 15
        Me.deleting.Text = "Delete"
        Me.deleting.UseVisualStyleBackColor = True
        '
        'canceling
        '
        Me.canceling.Location = New System.Drawing.Point(279, 224)
        Me.canceling.Name = "canceling"
        Me.canceling.Size = New System.Drawing.Size(75, 23)
        Me.canceling.TabIndex = 16
        Me.canceling.Text = "Cancel"
        Me.canceling.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Input bedasarkan ID :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(368, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nometer :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Kode Tarif :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Pemakaian :"
        '
        'kode_tarif_box
        '
        Me.kode_tarif_box.Location = New System.Drawing.Point(116, 116)
        Me.kode_tarif_box.Name = "kode_tarif_box"
        Me.kode_tarif_box.Size = New System.Drawing.Size(62, 20)
        Me.kode_tarif_box.TabIndex = 23
        '
        'unik_box
        '
        Me.unik_box.Location = New System.Drawing.Point(198, 116)
        Me.unik_box.Name = "unik_box"
        Me.unik_box.Size = New System.Drawing.Size(148, 20)
        Me.unik_box.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Daya kwH :"
        '
        'pemakaian_box
        '
        Me.pemakaian_box.Location = New System.Drawing.Point(116, 141)
        Me.pemakaian_box.Name = "pemakaian_box"
        Me.pemakaian_box.Size = New System.Drawing.Size(230, 20)
        Me.pemakaian_box.TabIndex = 26
        '
        'daya_box
        '
        Me.daya_box.Location = New System.Drawing.Point(117, 167)
        Me.daya_box.Name = "daya_box"
        Me.daya_box.Size = New System.Drawing.Size(229, 20)
        Me.daya_box.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(646, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Status :"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(748, 253)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 13)
        Me.status.TabIndex = 29
        '
        'id_pelanggan_box
        '
        Me.id_pelanggan_box.FormattingEnabled = True
        Me.id_pelanggan_box.Location = New System.Drawing.Point(116, 89)
        Me.id_pelanggan_box.Name = "id_pelanggan_box"
        Me.id_pelanggan_box.Size = New System.Drawing.Size(230, 21)
        Me.id_pelanggan_box.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(646, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Kembalian :"
        '
        'kebalian_box
        '
        Me.kebalian_box.Location = New System.Drawing.Point(751, 225)
        Me.kebalian_box.Name = "kebalian_box"
        Me.kebalian_box.Size = New System.Drawing.Size(230, 20)
        Me.kebalian_box.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(649, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Bayar :"
        '
        'bayar1_box
        '
        Me.bayar1_box.Location = New System.Drawing.Point(751, 199)
        Me.bayar1_box.Name = "bayar1_box"
        Me.bayar1_box.Size = New System.Drawing.Size(230, 20)
        Me.bayar1_box.TabIndex = 34
        '
        'nometer_box
        '
        Me.nometer_box.Location = New System.Drawing.Point(452, 89)
        Me.nometer_box.Name = "nometer_box"
        Me.nometer_box.Size = New System.Drawing.Size(181, 20)
        Me.nometer_box.TabIndex = 35
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 494)
        Me.Controls.Add(Me.nometer_box)
        Me.Controls.Add(Me.bayar1_box)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.kebalian_box)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.id_pelanggan_box)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.daya_box)
        Me.Controls.Add(Me.pemakaian_box)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.unik_box)
        Me.Controls.Add(Me.kode_tarif_box)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.canceling)
        Me.Controls.Add(Me.deleting)
        Me.Controls.Add(Me.refreshing)
        Me.Controls.Add(Me.saving)
        Me.Controls.Add(Me.tables)
        Me.Controls.Add(Me.admin_box)
        Me.Controls.Add(Me.bayar_box)
        Me.Controls.Add(Me.time_picker)
        Me.Controls.Add(Me.id_pembayaran_box)
        Me.Controls.Add(Me.nama_blink)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        CType(Me.tables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nama_blink As Label
    Friend WithEvents id_pembayaran_box As TextBox
    Friend WithEvents time_picker As DateTimePicker
    Friend WithEvents bayar_box As TextBox
    Friend WithEvents admin_box As TextBox
    Friend WithEvents tables As DataGridView
    Friend WithEvents saving As Button
    Friend WithEvents refreshing As Button
    Friend WithEvents deleting As Button
    Friend WithEvents canceling As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents kode_tarif_box As TextBox
    Friend WithEvents unik_box As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents pemakaian_box As TextBox
    Friend WithEvents daya_box As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents status As Label
    Friend WithEvents id_pelanggan_box As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents kebalian_box As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents bayar1_box As TextBox
    Friend WithEvents nometer_box As TextBox
End Class
