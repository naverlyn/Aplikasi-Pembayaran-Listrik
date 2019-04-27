<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tagih
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
        Me.meter_box = New System.Windows.Forms.TextBox()
        Me.status_box = New System.Windows.Forms.TextBox()
        Me.tables = New System.Windows.Forms.DataGridView()
        Me.saving = New System.Windows.Forms.Button()
        Me.refreshing = New System.Windows.Forms.Button()
        Me.deleting = New System.Windows.Forms.Button()
        Me.canceling = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nama_label = New System.Windows.Forms.Label()
        Me.id_box = New System.Windows.Forms.ComboBox()
        Me.time_picker = New System.Windows.Forms.DateTimePicker()
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
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Meter :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status Tagihan :"
        '
        'meter_box
        '
        Me.meter_box.Location = New System.Drawing.Point(112, 64)
        Me.meter_box.Name = "meter_box"
        Me.meter_box.Size = New System.Drawing.Size(237, 20)
        Me.meter_box.TabIndex = 8
        '
        'status_box
        '
        Me.status_box.Location = New System.Drawing.Point(112, 90)
        Me.status_box.Name = "status_box"
        Me.status_box.Size = New System.Drawing.Size(237, 20)
        Me.status_box.TabIndex = 9
        '
        'tables
        '
        Me.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tables.Location = New System.Drawing.Point(12, 197)
        Me.tables.Name = "tables"
        Me.tables.Size = New System.Drawing.Size(758, 268)
        Me.tables.TabIndex = 10
        '
        'saving
        '
        Me.saving.Location = New System.Drawing.Point(16, 153)
        Me.saving.Name = "saving"
        Me.saving.Size = New System.Drawing.Size(90, 23)
        Me.saving.TabIndex = 11
        Me.saving.Text = "Save / Update"
        Me.saving.UseVisualStyleBackColor = True
        '
        'refreshing
        '
        Me.refreshing.Location = New System.Drawing.Point(112, 153)
        Me.refreshing.Name = "refreshing"
        Me.refreshing.Size = New System.Drawing.Size(75, 23)
        Me.refreshing.TabIndex = 12
        Me.refreshing.Text = "Refresh"
        Me.refreshing.UseVisualStyleBackColor = True
        '
        'deleting
        '
        Me.deleting.Location = New System.Drawing.Point(193, 153)
        Me.deleting.Name = "deleting"
        Me.deleting.Size = New System.Drawing.Size(75, 23)
        Me.deleting.TabIndex = 13
        Me.deleting.Text = "Delete"
        Me.deleting.UseVisualStyleBackColor = True
        '
        'canceling
        '
        Me.canceling.Location = New System.Drawing.Point(274, 153)
        Me.canceling.Name = "canceling"
        Me.canceling.Size = New System.Drawing.Size(75, 23)
        Me.canceling.TabIndex = 14
        Me.canceling.Text = "Cancel"
        Me.canceling.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(398, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nama Pelanggan :"
        '
        'nama_label
        '
        Me.nama_label.AutoSize = True
        Me.nama_label.Location = New System.Drawing.Point(499, 15)
        Me.nama_label.Name = "nama_label"
        Me.nama_label.Size = New System.Drawing.Size(0, 13)
        Me.nama_label.TabIndex = 19
        '
        'id_box
        '
        Me.id_box.FormattingEnabled = True
        Me.id_box.Location = New System.Drawing.Point(112, 11)
        Me.id_box.Name = "id_box"
        Me.id_box.Size = New System.Drawing.Size(237, 21)
        Me.id_box.TabIndex = 20
        '
        'time_picker
        '
        Me.time_picker.CustomFormat = "yyyy/MM/dd"
        Me.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time_picker.Location = New System.Drawing.Point(112, 38)
        Me.time_picker.Name = "time_picker"
        Me.time_picker.Size = New System.Drawing.Size(237, 20)
        Me.time_picker.TabIndex = 21
        Me.time_picker.Value = New Date(2019, 3, 12, 0, 0, 0, 0)
        '
        'Tagih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 477)
        Me.Controls.Add(Me.time_picker)
        Me.Controls.Add(Me.id_box)
        Me.Controls.Add(Me.nama_label)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.canceling)
        Me.Controls.Add(Me.deleting)
        Me.Controls.Add(Me.refreshing)
        Me.Controls.Add(Me.saving)
        Me.Controls.Add(Me.tables)
        Me.Controls.Add(Me.status_box)
        Me.Controls.Add(Me.meter_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tagih"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tagih"
        CType(Me.tables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents meter_box As TextBox
    Friend WithEvents status_box As TextBox
    Friend WithEvents tables As DataGridView
    Friend WithEvents saving As Button
    Friend WithEvents refreshing As Button
    Friend WithEvents deleting As Button
    Friend WithEvents canceling As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents nama_label As Label
    Friend WithEvents id_box As ComboBox
    Friend WithEvents time_picker As DateTimePicker
End Class
