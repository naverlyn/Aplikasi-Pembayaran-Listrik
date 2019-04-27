Imports System.Data.Odbc

Public Class Tagih

    Sub delete_semua()
        id_box.Text = ""
        time_picker.Text = Format(Today)
        meter_box.Clear()
        status_box.Clear()
        nama_label.Text = ""
        id_box.Focus()
    End Sub

    Sub automatic()
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            nama_label.Text = reader.Item("nama_pelanggan")
        Else
            nama_label.Text = "Nama Pelanggan Tidak Ditemukan"
        End If
    End Sub

    Sub rename_table()
        With tables.ColumnHeadersDefaultCellStyle
            tables.Columns(0).HeaderText = "ID Pelanggan"
            tables.Columns(1).HeaderText = "Tanggal"
            tables.Columns(2).HeaderText = "Jumlah Meter"
            tables.Columns(3).HeaderText = "Status"
        End With
    End Sub

    Sub membuat()
        id_box.Text = ""
        time_picker.Text = Format(Today)
        meter_box.Clear()
        nama_label.Text = ""
        id_box.Focus()
    End Sub

    Sub buat_id_box()
        ' On Error Resume Next
        koneksi()
        command = New OdbcCommand("select distinct id_pelanggan from tb_pelanggan", connect)
        reader = command.ExecuteReader
        id_box.Items.Clear()
        Do While reader.Read
            id_box.Items.Add(reader("id_pelanggan"))
        Loop
    End Sub

    Sub tarik_lain()
        koneksi()
        command = New OdbcCommand("select * from tb_penggunaan where id_pelanggan='" & id_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            meter_box.Text = reader("meter_akhir")
        Else
            meter_box.Text = "0"
        End If
    End Sub

    Sub tarik()
        time_picker.Text = reader("tanggal")
        meter_box.Text = reader("jumlah_meter")
        status_box.Text = reader("status_tagih")
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            nama_label.Text = reader.Item("nama_pelanggan")
        Else
            nama_label.Text = "Nama Pelanggan Tidak Ditemukan"
        End If
    End Sub

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from tb_tagih", connect)
        kutil = New DataSet
        adapter.Fill(kutil)
        tables.DataSource = kutil.Tables(0)
        tables.ReadOnly = True
    End Sub

    Sub cari()
        koneksi()
        command = New OdbcCommand("select * from tb_tagih where id_pelanggan='" & id_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
    End Sub

    Private Sub Tagih_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        buat_id_box()
        rename_table()
    End Sub

    Private Sub saving_Click(sender As Object, e As EventArgs) Handles saving.Click
        Try
            If id_box.Text = "" Or time_picker.Text = "" Or meter_box.Text = "" Or status_box.Text = "" Or nama_label.Text = "" Then
                MsgBox("Harap Diisi Dengan Benar")
            Else
                cari()
                If Not reader.HasRows Then
                    koneksi()
                    Dim simpan As String = "insert into tb_tagih values('" & id_box.Text & "', '" & time_picker.Text & "', '" & meter_box.Text & "', '" & status_box.Text & "')"
                    command = New OdbcCommand(simpan, connect)
                    command.ExecuteNonQuery()
                Else
                    koneksi()
                    Dim update As String = "update tb_tagih set tanggal='" & time_picker.Text & "', jumlah_meter='" & meter_box.Text & "', status_tagih='" & status_box.Text & "' where id_pelanggan='" & id_box.Text & "'"
                    command = New OdbcCommand(update, connect)
                    command.ExecuteNonQuery()
                End If
            End If
            delete_semua()
            tampil()
            buat_id_box()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub refreshing_Click(sender As Object, e As EventArgs) Handles refreshing.Click
        delete_semua()
    End Sub

    Private Sub deleting_Click(sender As Object, e As EventArgs) Handles deleting.Click
        If MessageBox.Show("Apakah anda yakin ingin menghapus record ini ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim delete As String = "delete from tb_tagih where id_pelanggan='" & id_box.Text & "'"
            command = New OdbcCommand(delete, connect)
            command.ExecuteNonQuery()
            tampil()
            delete_semua()
            automatic()
        Else
            delete_semua()
        End If
    End Sub

    Private Sub tables_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tables.CellMouseClick
        cari()
        On Error Resume Next
        id_box.Text = tables.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            tarik()
        End If
    End Sub

    Private Sub canceling_Click(sender As Object, e As EventArgs) Handles canceling.Click
        Dispose()
    End Sub

    Private Sub id_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_box.SelectedIndexChanged
        'buat_id_box()
        automatic()
        tarik_lain()
        status_box.Text = "Belum Dibayar"
    End Sub
End Class