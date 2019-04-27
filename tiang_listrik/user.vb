Imports System.Data.Odbc

Public Class user

    Sub delete_semua()
        id_text.Clear()
        nama_text.Clear()
        pw_text.Clear()
        alamat_text.Clear()
        status_combobox.Text = "-Pilih-"
    End Sub

    Sub bikin()
        id_text.Clear()
        nama_text.Clear()
        pw_text.Clear()
        alamat_text.Clear()
        status_combobox.Text = "-Pilih-"
        id_text.Focus()
    End Sub

    Sub menampilkan()
        koneksi()
        adapter = New OdbcDataAdapter("select * from tb_user", connect)
        kutil = New DataSet
        adapter.Fill(kutil)
        tables.DataSource = kutil.Tables(0)
        tables.ReadOnly = True
    End Sub

    Sub khusus_status()
        koneksi()
        command = New OdbcCommand("select distinct status from tb_user", connect)
        reader = command.ExecuteReader
        status_combobox.Items.Clear()
        Do While reader.Read
            status_combobox.Items.Add(reader("status"))
        Loop
    End Sub

    'sub cari nanti aja
    Sub cari()
        koneksi()
        command = New OdbcCommand("select * from tb_user where id_user='" & id_text.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
    End Sub

    Sub ketemu()
        On Error Resume Next
        nama_text.Text = reader("nama_user")
        alamat_text.Text = reader("alamat")
        status_combobox.Text = reader("status")
        pw_text.Text = reader("password")
        nama_text.Focus()
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menampilkan()
        khusus_status()
        id_text.Focus()
        status_combobox.Text = "-Pilih-"
    End Sub

    Private Sub canceling_Click(sender As Object, e As EventArgs) Handles canceling.Click
        Dispose()
    End Sub

    Private Sub saving_Click(sender As Object, e As EventArgs) Handles saving.Click
        If id_text.Text = "" Or nama_text.Text = "" Or pw_text.Text = "" Or alamat_text.Text = "" Or status_combobox.Text = "-Pilih-" Then
            MsgBox("Mohon isi kolom dengan benar sekali lagi!")
            Exit Sub
        End If
        Try
            cari()
            If Not reader.HasRows Then
                koneksi()
                Dim simpan As String = "insert into tb_user values('" & id_text.Text & "', '" & nama_text.Text & "', '" & pw_text.Text & "', '" & alamat_text.Text & "', '" & status_combobox.Text & "')"
                command = New OdbcCommand(simpan, connect)
                command.ExecuteNonQuery()
            Else
                koneksi()
                Dim ubah As String = "update tb_user set nama_user='" & nama_text.Text & "', password='" & pw_text.Text & "', alamat='" & alamat_text.Text & "', status='" & status_combobox.Text & "' where id_user='" & id_text.Text & "'"
                command = New OdbcCommand(ubah, connect)
                command.ExecuteNonQuery()
            End If
            delete_semua()
            menampilkan()
            khusus_status()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tables_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tables.CellMouseClick
        On Error Resume Next
        id_text.Text = tables.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            ketemu()
        End If
    End Sub

    Private Sub deleting_Click(sender As Object, e As EventArgs) Handles deleting.Click
        koneksi()
        If MessageBox.Show("Hapus ?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            Dim delete As String = "delete from tb_user where id_user='" & id_text.Text & "'"
            command = New OdbcCommand(delete, connect)
            command.ExecuteNonQuery()
        Else
            delete_semua()
        End If
        delete_semua()
        menampilkan()
    End Sub

    Private Sub refreshing_Click(sender As Object, e As EventArgs) Handles refreshing.Click
        delete_semua()
    End Sub

    Private Sub tables_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles tables.CellEndEdit

    End Sub

    Private Sub status_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_combobox.SelectedIndexChanged

    End Sub
End Class
