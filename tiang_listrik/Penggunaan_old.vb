Imports System.Data.Odbc
Public Class Penggunaan_old

    Sub delete_semua()
        id_box.Focus()
        id_box.Clear()
        bulan_picker.Text = Format(Today)
        awal_box.Clear()
        akhir_box.Clear()
        nama_appear.Text = ""
    End Sub

    Sub buat_balik()
        id_box.Focus()
        id_box.Clear()
        bulan_picker.Text = Format(Today)
        awal_box.Clear()
        akhir_box.Clear()
        nama_appear.Text = ""
    End Sub

    Sub rename_table()
        With tables.ColumnHeadersDefaultCellStyle
            tables.Columns(0).HeaderText = "ID Pelanggan"
            tables.Columns(1).HeaderText = "Tanggal"
            tables.Columns(2).HeaderText = "Meter Awal"
            tables.Columns(3).HeaderText = "Meter Akhir"
            tables.Columns(0).Width = 120
        End With
    End Sub

    Sub cari()
        koneksi()
        command = New OdbcCommand("select * from tb_penggunaan where id_pelanggan='" & id_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
    End Sub

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from tb_penggunaan", connect)
        kutil = New DataSet
        adapter.Fill(kutil)
        tables.DataSource = kutil.Tables(0)
        tables.ReadOnly = True
    End Sub

    Sub tarik_nama()
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_box.Text & "'", connect)
        reader = command.ExecuteReader

        If reader.HasRows Then
            nama_appear.Text = reader.Item("nama_pelanggan")
        Else
            nama_appear.Text = "Nama Pelanggan Tidak Ditemukan"
        End If
        id_box.Enabled = False
    End Sub

    Sub tarik1()
        'bulan_picker.Text = reader("bulan_pelanggan")
        awal_box.Text = reader("meter_akhir")
        'akhir_box.Text = reader("meter_akhir")
    End Sub

    Private Sub saving_Click(sender As Object, e As EventArgs) Handles saving.Click
        Try
            If id_box.Text = "" Or bulan_picker.Text = "" Or awal_box.Text = "" Or akhir_box.Text = "" Or nama_appear.Text = "" Then
                MsgBox("Harap Diisi Dengan Benar")
            Else
                If Int(akhir_box.Text) < Int(awal_box.Text) Then
                    MsgBox("nominal salah")
                Else
                    cari()
                    If Not reader.HasRows Then
                        'cari()
                        koneksi()
                        Dim save As String = "insert into tb_penggunaan values('" & id_box.Text & "', '" & bulan_picker.Text & "', '" & awal_box.Text & "', '" & akhir_box.Text & "')"
                        command = New OdbcCommand(save, connect)
                        command.ExecuteNonQuery()
                    Else
                        koneksi()
                        Dim kurang As String = akhir_box.Text - awal_box.Text
                        Dim total As String = kurang
                        Dim update As String = "update tb_penggunaan set bulan_pelanggan='" & bulan_picker.Text & "', meter_awal='" & awal_box.Text & "', meter_akhir='" & total & "' where id_pelanggan='" & id_box.Text & "'"
                        command = New OdbcCommand(update, connect)
                        command.ExecuteNonQuery()

                        Dim edit As String = "update tb_tagih set jumlah_meter='" & total & "' where id_pelanggan='" & id_box.Text & "'"
                        command = New OdbcCommand(edit, connect)
                        command.ExecuteNonQuery()
                    End If
                End If
            End If
            delete_semua()
            tampil()
            id_box.Enabled = True
            awal_box.Enabled = True
            id_box.Focus()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Penggunaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        cari()
        id_box.Focus()
        rename_table()
    End Sub
    Private Sub id_box_KeyDown(sender As Object, e As KeyEventArgs) Handles id_box.KeyDown
        'On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            cari()
            tarik_nama()
            id_box.Enabled = False
            awal_box.Text = "0"
            awal_box.Enabled = False
            akhir_box.Focus()
        End If
    End Sub

    Private Sub refreshing_Click(sender As Object, e As EventArgs) Handles refreshing.Click
        delete_semua()
        id_box.Enabled = True
        awal_box.Enabled = True
    End Sub

    Private Sub deleting_Click(sender As Object, e As EventArgs) Handles deleting.Click
        Try
            koneksi()
            Dim delete As String = "delete from tb_penggunaan where id_pelanggan='" & id_box.Text & "'"
            command = New OdbcCommand(delete, connect)
            command.ExecuteNonQuery()
            delete_semua()
            tampil()
            id_box.Enabled = True
            awal_box.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tables_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tables.CellMouseClick
        'On Error Resume Next
        id_box.Text = tables.Rows(e.RowIndex).Cells(0).Value
        bulan_picker.Text = tables.Rows(e.RowIndex).Cells(1).Value
        cari()
        If reader.HasRows Then
            'koneksi()
            tarik1()
            tarik_nama()
            awal_box.Enabled = False
        End If
    End Sub

    Private Sub canceling_Click(sender As Object, e As EventArgs) Handles canceling.Click
        Dispose()
    End Sub
End Class