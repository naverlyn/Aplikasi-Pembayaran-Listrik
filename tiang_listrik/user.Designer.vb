<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tables = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_text = New System.Windows.Forms.TextBox()
        Me.nama_text = New System.Windows.Forms.TextBox()
        Me.pw_text = New System.Windows.Forms.TextBox()
        Me.alamat_text = New System.Windows.Forms.TextBox()
        Me.DataSet11 = New tiang_listrik.DataSet1()
        Me.saving = New System.Windows.Forms.Button()
        Me.refreshing = New System.Windows.Forms.Button()
        Me.deleting = New System.Windows.Forms.Button()
        Me.canceling = New System.Windows.Forms.Button()
        Me.status_combobox = New System.Windows.Forms.ComboBox()
        Me.DataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.tables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tables
        '
        Me.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tables.Location = New System.Drawing.Point(357, 12)
        Me.tables.Name = "tables"
        Me.tables.Size = New System.Drawing.Size(581, 461)
        Me.tables.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID user :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama User :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Status :"
        '
        'id_text
        '
        Me.id_text.Location = New System.Drawing.Point(89, 12)
        Me.id_text.Name = "id_text"
        Me.id_text.Size = New System.Drawing.Size(241, 20)
        Me.id_text.TabIndex = 6
        '
        'nama_text
        '
        Me.nama_text.Location = New System.Drawing.Point(89, 38)
        Me.nama_text.Name = "nama_text"
        Me.nama_text.Size = New System.Drawing.Size(241, 20)
        Me.nama_text.TabIndex = 7
        '
        'pw_text
        '
        Me.pw_text.Location = New System.Drawing.Point(89, 64)
        Me.pw_text.Name = "pw_text"
        Me.pw_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(33)
        Me.pw_text.Size = New System.Drawing.Size(241, 20)
        Me.pw_text.TabIndex = 8
        '
        'alamat_text
        '
        Me.alamat_text.Location = New System.Drawing.Point(89, 90)
        Me.alamat_text.Name = "alamat_text"
        Me.alamat_text.Size = New System.Drawing.Size(241, 20)
        Me.alamat_text.TabIndex = 9
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'saving
        '
        Me.saving.Location = New System.Drawing.Point(12, 159)
        Me.saving.Name = "saving"
        Me.saving.Size = New System.Drawing.Size(75, 23)
        Me.saving.TabIndex = 11
        Me.saving.Text = "Save"
        Me.saving.UseVisualStyleBackColor = True
        '
        'refreshing
        '
        Me.refreshing.Location = New System.Drawing.Point(93, 159)
        Me.refreshing.Name = "refreshing"
        Me.refreshing.Size = New System.Drawing.Size(75, 23)
        Me.refreshing.TabIndex = 12
        Me.refreshing.Text = "Refresh"
        Me.refreshing.UseVisualStyleBackColor = True
        '
        'deleting
        '
        Me.deleting.Location = New System.Drawing.Point(174, 159)
        Me.deleting.Name = "deleting"
        Me.deleting.Size = New System.Drawing.Size(75, 23)
        Me.deleting.TabIndex = 13
        Me.deleting.Text = "Delete"
        Me.deleting.UseVisualStyleBackColor = True
        '
        'canceling
        '
        Me.canceling.Location = New System.Drawing.Point(255, 159)
        Me.canceling.Name = "canceling"
        Me.canceling.Size = New System.Drawing.Size(75, 23)
        Me.canceling.TabIndex = 14
        Me.canceling.Text = "Cancel"
        Me.canceling.UseVisualStyleBackColor = True
        '
        'status_combobox
        '
        Me.status_combobox.FormattingEnabled = True
        Me.status_combobox.Location = New System.Drawing.Point(89, 116)
        Me.status_combobox.Name = "status_combobox"
        Me.status_combobox.Size = New System.Drawing.Size(241, 21)
        Me.status_combobox.TabIndex = 15
        '
        'DataSet11BindingSource
        '
        Me.DataSet11BindingSource.DataSource = Me.DataSet11
        Me.DataSet11BindingSource.Position = 0
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 485)
        Me.Controls.Add(Me.status_combobox)
        Me.Controls.Add(Me.canceling)
        Me.Controls.Add(Me.deleting)
        Me.Controls.Add(Me.refreshing)
        Me.Controls.Add(Me.saving)
        Me.Controls.Add(Me.alamat_text)
        Me.Controls.Add(Me.pw_text)
        Me.Controls.Add(Me.nama_text)
        Me.Controls.Add(Me.id_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.tables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tables As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents id_text As TextBox
    Friend WithEvents nama_text As TextBox
    Friend WithEvents pw_text As TextBox
    Friend WithEvents alamat_text As TextBox
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents saving As Button
    Friend WithEvents refreshing As Button
    Friend WithEvents deleting As Button
    Friend WithEvents canceling As Button
    Friend WithEvents status_combobox As ComboBox
    Friend WithEvents DataSet11BindingSource As BindingSource
End Class
