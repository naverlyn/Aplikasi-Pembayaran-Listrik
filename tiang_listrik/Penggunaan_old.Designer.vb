<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penggunaan_old
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nama_appear = New System.Windows.Forms.Label()
        Me.id_box = New System.Windows.Forms.TextBox()
        Me.bulan_picker = New System.Windows.Forms.DateTimePicker()
        Me.akhir_box = New System.Windows.Forms.TextBox()
        Me.awal_box = New System.Windows.Forms.TextBox()
        Me.saving = New System.Windows.Forms.Button()
        Me.refreshing = New System.Windows.Forms.Button()
        Me.deleting = New System.Windows.Forms.Button()
        Me.canceling = New System.Windows.Forms.Button()
        Me.tables = New System.Windows.Forms.DataGridView()
        CType(Me.tables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pelanggan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penggunaan :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meter Awal :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Meter Akhir :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Pelanggan :"
        '
        'nama_appear
        '
        Me.nama_appear.AutoSize = True
        Me.nama_appear.Location = New System.Drawing.Point(523, 15)
        Me.nama_appear.Name = "nama_appear"
        Me.nama_appear.Size = New System.Drawing.Size(10, 13)
        Me.nama_appear.TabIndex = 6
        Me.nama_appear.Text = " "
        '
        'id_box
        '
        Me.id_box.Location = New System.Drawing.Point(156, 12)
        Me.id_box.Name = "id_box"
        Me.id_box.Size = New System.Drawing.Size(200, 20)
        Me.id_box.TabIndex = 7
        '
        'bulan_picker
        '
        Me.bulan_picker.CustomFormat = "yyyy/MM/dd"
        Me.bulan_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bulan_picker.Location = New System.Drawing.Point(156, 38)
        Me.bulan_picker.Name = "bulan_picker"
        Me.bulan_picker.Size = New System.Drawing.Size(200, 20)
        Me.bulan_picker.TabIndex = 8
        Me.bulan_picker.Value = New Date(2019, 3, 12, 0, 0, 0, 0)
        '
        'akhir_box
        '
        Me.akhir_box.Location = New System.Drawing.Point(156, 90)
        Me.akhir_box.Name = "akhir_box"
        Me.akhir_box.Size = New System.Drawing.Size(200, 20)
        Me.akhir_box.TabIndex = 10
        '
        'awal_box
        '
        Me.awal_box.Location = New System.Drawing.Point(156, 64)
        Me.awal_box.Name = "awal_box"
        Me.awal_box.Size = New System.Drawing.Size(200, 20)
        Me.awal_box.TabIndex = 11
        '
        'saving
        '
        Me.saving.Location = New System.Drawing.Point(15, 157)
        Me.saving.Name = "saving"
        Me.saving.Size = New System.Drawing.Size(86, 23)
        Me.saving.TabIndex = 12
        Me.saving.Text = "Save / Update"
        Me.saving.UseVisualStyleBackColor = True
        '
        'refreshing
        '
        Me.refreshing.Location = New System.Drawing.Point(107, 157)
        Me.refreshing.Name = "refreshing"
        Me.refreshing.Size = New System.Drawing.Size(75, 23)
        Me.refreshing.TabIndex = 13
        Me.refreshing.Text = "Refresh"
        Me.refreshing.UseVisualStyleBackColor = True
        '
        'deleting
        '
        Me.deleting.Location = New System.Drawing.Point(188, 157)
        Me.deleting.Name = "deleting"
        Me.deleting.Size = New System.Drawing.Size(75, 23)
        Me.deleting.TabIndex = 14
        Me.deleting.Text = "Delete"
        Me.deleting.UseVisualStyleBackColor = True
        '
        'canceling
        '
        Me.canceling.Location = New System.Drawing.Point(269, 157)
        Me.canceling.Name = "canceling"
        Me.canceling.Size = New System.Drawing.Size(75, 23)
        Me.canceling.TabIndex = 15
        Me.canceling.Text = "Cancel"
        Me.canceling.UseVisualStyleBackColor = True
        '
        'tables
        '
        Me.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tables.Location = New System.Drawing.Point(12, 211)
        Me.tables.Name = "tables"
        Me.tables.Size = New System.Drawing.Size(723, 242)
        Me.tables.TabIndex = 16
        '
        'Penggunaan_old
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 465)
        Me.Controls.Add(Me.tables)
        Me.Controls.Add(Me.canceling)
        Me.Controls.Add(Me.deleting)
        Me.Controls.Add(Me.refreshing)
        Me.Controls.Add(Me.saving)
        Me.Controls.Add(Me.awal_box)
        Me.Controls.Add(Me.akhir_box)
        Me.Controls.Add(Me.bulan_picker)
        Me.Controls.Add(Me.id_box)
        Me.Controls.Add(Me.nama_appear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penggunaan_old"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penggunaan"
        CType(Me.tables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nama_appear As Label
    Friend WithEvents id_box As TextBox
    Friend WithEvents bulan_picker As DateTimePicker
    Friend WithEvents akhir_box As TextBox
    Friend WithEvents awal_box As TextBox
    Friend WithEvents saving As Button
    Friend WithEvents refreshing As Button
    Friend WithEvents deleting As Button
    Friend WithEvents canceling As Button
    Friend WithEvents tables As DataGridView
End Class
