Imports System.Data.Odbc

Public Class Pembayaran

    Sub delete_semua()
        id_pelanggan_box.Text = ""
        bayar_box.Clear()
        nama_blink.Text = ""
        admin_box.Clear()
        nometer_box.Clear()
        bayar1_box.Clear()
        pemakaian_box.Clear()
        daya_box.Clear()
        kode_tarif_box.Clear()
        unik_box.Clear()
        bayar1_box.Clear()
        kebalian_box.Clear()
        id_pembayaran_box.Focus()
        status.Text = ""
        time_picker.Text = Format(Today)
    End Sub

    Sub banding()
        koneksi()
        command = New OdbcCommand("select * id_pelanggan from tb_pembayaran, where id_pelanggan='" & id_pelanggan_box.Text & "' and tanggal='" & time_picker.Text & "'", connect)
        reader = command.ExecuteReader
        If reader.Read Then
            status.Text = "Sudah Dibayar"
        Else
            status.Text = "Belum Dibayar"
        End If
    End Sub

    Sub rename_table()
        With tables.ColumnHeadersDefaultCellStyle
            tables.Columns(0).HeaderText = "ID Pembayaran"
            tables.Columns(1).HeaderText = "ID Pelanggan"
            tables.Columns(2).HeaderText = "Tanggal"
            tables.Columns(3).HeaderText = "Total Bayar"
            tables.Columns(4).HeaderText = "Biaya Admin"
            tables.Columns(0).Width = "120"
        End With
    End Sub

    Sub automatic()
        koneksi()
        command = New OdbcCommand("select * from tb_pembayaran order by id_bayar desc", connect)
        reader = command.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_pembayaran_box.Text = "PEM" + "0001"
        Else
            id_pembayaran_box.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_bayar").ToString, 6, 4)) + 1
            If Len(id_pembayaran_box.Text) = 1 Then
                id_pembayaran_box.Text = "PEM000" & id_pembayaran_box.Text & ""
            ElseIf Len(id_pembayaran_box.Text) = 2 Then
                id_pembayaran_box.Text = "PEM00" & id_pembayaran_box.Text & ""
            ElseIf Len(id_pembayaran_box.Text) = 3 Then
                id_pembayaran_box.Text = "PEM0" & id_pembayaran_box.Text & ""
            End If
        End If
        id_pembayaran_box.Enabled = False
    End Sub

    Sub hitung()
        koneksi()
        command = New OdbcCommand("select * from tb_tagih where id_pelanggan='" & id_pelanggan_box.Text & "'", connect)
        reader = command.ExecuteReader
        If reader.Read Then
            Dim jumlah As String = reader("jumlah_meter")
            command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_pelanggan_box.Text & "'", connect)
            reader = command.ExecuteReader
            If reader.Read Then
                Dim tambah As String = reader("kode_tarif")
                command = New OdbcCommand("select * from tb_tarif where kode_tarif='" & tambah & "'", connect)
                reader = command.ExecuteReader
                If reader.Read Then
                    Dim tarif1 As String = reader("tarif_kwh")
                    Dim tb As String = jumlah * tarif1
                    Dim pajak As String = (tb * 3) / 100
                    bayar_box.Text = Microsoft.VisualBasic.Str((pajak + 3000))
                    bayar_box.Text = FormatNumber(bayar_box.Text, 0)
                End If
            End If
        End If
    End Sub

    Sub tarik_semua()
        koneksi()
        '---- panggil id pelanggan di tb_tagih---'
        command = New OdbcCommand("select * from tb_tagih where id_pelanggan ='" & id_pelanggan_box.Text & "'", connect)
        reader = command.ExecuteReader
        If reader.Read() Then
            Dim jml As String = reader("jumlah_meter")
            '---- panggil id pelanggan di tb_pelanggan---'

            command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan = '" & id_pelanggan_box.Text & "' ", connect)
            reader = command.ExecuteReader
            If reader.Read Then
                Dim tambah As String = reader("kode_tarif")

                command = New OdbcCommand("select * from tb_tarif where kode_tarif = '" & tambah & "' ", connect)
                reader = command.ExecuteReader
                If reader.Read Then
                    Dim tarif1 As String = reader("tarif_kwh")
                    Dim tb As String = jml * tarif1

                    '-------- ppj(Pajak Penerangan Jalan)
                    Dim ppj As String = (tb * 3) / 100

                    '-------- pertambahan materai
                    bayar_box.Text = Microsoft.VisualBasic.Str((ppj + 3000) + tb + admin_box.Text)
                    bayar_box.Text = FormatNumber(bayar_box.Text, 0)
                End If
            End If
        End If
    End Sub

    Sub buat_id()
        koneksi()
        command = New OdbcCommand("select distinct id_pelanggan from tb_pelanggan", connect)
        reader = command.ExecuteReader
        id_pelanggan_box.Items.Clear()
        Do While reader.Read
            id_pelanggan_box.Items.Add(reader("id_pelanggan"))
        Loop
    End Sub

    Sub buat_baru()
        id_pelanggan_box.Text = ""
        id_pembayaran_box.Clear()
        bayar_box.Clear()
        nama_blink.Text = ""
        admin_box.Clear()
        id_pembayaran_box.Focus()
    End Sub

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from tb_pembayaran", connect)
        kutil = New DataSet
        adapter.Fill(kutil)
        tables.DataSource = kutil.Tables(0)
        tables.ReadOnly = True
    End Sub

    Sub cari()
        koneksi()
        command = New OdbcCommand("select * from tb_pembayaran where id_bayar='" & id_pembayaran_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
    End Sub

    Sub tariks()
        koneksi()
        Dim ccd As String = "select * from pembayaran_detail where id='" & id_pembayaran_box.Text & "'"
        command = New OdbcCommand(ccd, connect)
        reader = command.ExecuteReader
        reader.Read()
        id_pelanggan_box.Text = reader.Item("id_pelanggan")
        nama_blink.Text = reader.Item("nama_pelanggan")
        nometer_box.Text = reader.Item("nometer")
        kode_tarif_box.Text = reader.Item("kode_tarif")
        unik_box.Text = reader.Item("kode_unik")
        pemakaian_box.Text = reader.Item("pemakaian")
        daya_box.Text = reader.Item("daya")
        time_picker.Text = reader.Item("tanggal")
        bayar_box.Text = reader.Item("total")
        admin_box.Text = reader.Item("biaya_admin")
        bayar1_box.Text = reader.Item("bayar")
        kebalian_box.Text = reader.Item("kembalian")
        status.Text = reader.Item("status")
    End Sub

    Sub tarik_nama()
        koneksi()
        Dim commnd As String = "select * from tb_pelanggan where id_pelanggan='" & id_pelanggan_box.Text & "'"
        command = New OdbcCommand(commnd, connect)
        reader = command.ExecuteReader
        reader.Read()
        id_pelanggan_box.Text = reader.Item("id_pelanggan")
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_pelanggan_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            nama_blink.Text = reader.Item("nama_pelanggan")
            kode_tarif_box.Text = reader("kode_tarif")
            unik_box.Text = reader("kode_unik")
            nometer_box.Text = reader("nometer")
        Else
            nama_blink.Text = "Nama Pelanggan Tidak Ditemukan"
        End If
        'id_pelanggan_box.Enabled = False
        command = New OdbcCommand("select * from tb_tarif where kode_tarif='" & kode_tarif_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            daya_box.Text = reader("daya_tarif")
        End If
        command = New OdbcCommand("select * from tb_penggunaan where id_pelanggan='" & id_pelanggan_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            pemakaian_box.Text = reader("meter_akhir")
        End If
        command = New OdbcCommand("select * from tb_tagih where id_pelanggan='" & id_pelanggan_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            status.Text = reader("status_tagih")
        End If
    End Sub

    Sub enable_all()
        kode_tarif_box.Enabled = True
        unik_box.Enabled = True
        pemakaian_box.Enabled = True
        daya_box.Enabled = True
        bayar_box.Enabled = True
        admin_box.Enabled = True
        nometer_box.Enabled = True
    End Sub

    Sub false_all()
        kode_tarif_box.Enabled = False
        nometer_box.Enabled = False
        unik_box.Enabled = False
        pemakaian_box.Enabled = False
        daya_box.Enabled = False
        bayar_box.Enabled = False
        admin_box.Enabled = False
    End Sub

    Sub tarik1()
        command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_pelanggan_box.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            nama_blink.Text = reader.Item("nama_pelanggan")
        Else
            nama_blink.Text = "Nama Pelanggan Tidak Ditemukan"
        End If
    End Sub

    Private Sub saving_Click(sender As Object, e As EventArgs) Handles saving.Click
        If id_pembayaran_box.Text = "" Or id_pelanggan_box.Text = "" Or nama_blink.Text = "" Or kode_tarif_box.Text = "" Or unik_box.Text = "" Or nometer_box.Text = "" Or pemakaian_box.Text = "" Or daya_box.Text = "" Or time_picker.Text = "" Or bayar_box.Text = "" Or admin_box.Text = "" Or bayar1_box.Text = "" Or kebalian_box.Text = "" Or status.Text = "" Then
            MsgBox("Harap Diisi Dengan Benar")
            bayar1_box.Focus()
        Else
            Try
                cari()
                If Not reader.HasRows Then
                    koneksi()
                    Dim simpan As String = "insert into tb_pembayaran values('" & id_pembayaran_box.Text & "', '" & id_pelanggan_box.Text & "', '" & time_picker.Text & "', '" & bayar_box.Text & "', '" & admin_box.Text & "')"
                    command = New OdbcCommand(simpan, connect)
                    command.ExecuteNonQuery()
                Else
                    koneksi()
                    Dim update As String = "update tb_pembayaran set id_pelanggan='" & id_pelanggan_box.Text & "', tanggal='" & time_picker.Text & "', bulan_bayar='" & bayar_box.Text & "', biaya_admin='" & admin_box.Text & "' where id_bayar='" & id_pembayaran_box.Text & "'"
                    command = New OdbcCommand(update, connect)
                    command.ExecuteNonQuery()
                End If
                If Not reader.HasRows Then
                    koneksi()
                    Dim detail As String = "insert into pembayaran_detail values('" & id_pembayaran_box.Text & "', '" & id_pelanggan_box.Text & "', '" & nama_blink.Text & "', '" & nometer_box.Text & "', '" & kode_tarif_box.Text & "', '" & unik_box.Text & "', '" & pemakaian_box.Text & "', '" & daya_box.Text & "', '" & time_picker.Text & "', '" & bayar_box.Text & "', '" & admin_box.Text & "', '" & bayar1_box.Text & "', '" & kebalian_box.Text & "', 'Sudah Dibayar')"
                    command = New OdbcCommand(detail, connect)
                    command.ExecuteNonQuery()
                Else
                    koneksi()
                    Dim edit As String = "update pembayaran_detail set id_pelanggan='" & id_pelanggan_box.Text & "', nama_pelanggan='" & nama_blink.Text & "', nometer='" & nometer_box.Text & "', kode_tarif='" & kode_tarif_box.Text & "', kode_unik='" & unik_box.Text & "', pemakaian='" & pemakaian_box.Text & "', daya='" & daya_box.Text & "', tanggal='" & time_picker.Text & "', total='" & bayar1_box.Text & "', biaya_admin='" & admin_box.Text & "', bayar='" & bayar1_box.Text & "', kembalian='" & kebalian_box.Text & "', status='Sudah Dibayar' where id='" & id_pembayaran_box.Text & "'"
                    command = New OdbcCommand(edit, connect)
                    command.ExecuteNonQuery()
                End If
                If Not reader.HasRows Then
                    koneksi()
                    Dim edit_status As String = "update tb_tagih set status_tagih='Sudah Dibayar' where id_pelanggan='" & id_pelanggan_box.Text & "'"
                    command = New OdbcCommand(edit_status, connect)
                    command.ExecuteNonQuery()
                End If
                If MessageBox.Show("Cetak Struk ?", "PERHATIAN..", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Cetak.struk.SelectionFormula = "{pembayaran_detail.id}='" & id_pembayaran_box.Text & "'"
                    Cetak.struk.ReportSource = "C:\Users\LENOVO\Documents\Visual Studio 2015\Projects\tiang_listrik\tiang_listrik\bin\Debug\laporan\tes_struk.rpt"
                    Cetak.struk.RefreshReport()
                    Cetak.Show()
                Else
                    Dispose()
                End If
            Catch ex As Exception
            End Try
            delete_semua()
            tampil()
            enable_all()
            automatic()

        End If
    End Sub

    Private Sub id_pelanggan_box_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cari()
            tarik_nama()

        End If
    End Sub

    Private Sub tables_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tables.CellContentClick

    End Sub

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        automatic()
        buat_id()
        tarik_semua()
        rename_table()
    End Sub

    Private Sub refreshing_Click(sender As Object, e As EventArgs) Handles refreshing.Click
        delete_semua()
        time_picker.Text = Format(Today)
        automatic()
        enable_all()
        automatic()
    End Sub

    Private Sub deleting_Click(sender As Object, e As EventArgs) Handles deleting.Click
        Try
            koneksi()
            Dim delete As String = "delete from tb_pembayaran where id_bayar='" & id_pembayaran_box.Text & "'"
            command = New OdbcCommand(delete, connect)
            command.ExecuteNonQuery()
        Catch ex As Exception
            tampil()
            delete_semua()
            time_picker.Text = Format(Today)
            automatic()
            id_pelanggan_box.Enabled = True
        End Try
        koneksi()
        Dim delete_lain As String = "delete from pembayaran_detail where id_pelanggan='" & id_pelanggan_box.Text & "'"
        command = New OdbcCommand(delete_lain, connect)
        command.ExecuteNonQuery()
        tampil()
        automatic()
        delete_semua()
        enable_all()
    End Sub

    Private Sub canceling_Click(sender As Object, e As EventArgs) Handles canceling.Click
        Dispose()
    End Sub

    Private Sub id_pelanggan_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_pelanggan_box.SelectedIndexChanged
        hitung()
        tarik_nama()
        admin_box.Text = FormatNumber("2500", 0)
        false_all()
    End Sub

    Private Sub bayar1_box_KeyDown(sender As Object, e As KeyEventArgs) Handles bayar1_box.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim bayar1 As String = bayar1_box.Text - bayar_box.Text

            kebalian_box.Text = bayar1
        End If
    End Sub

    Private Sub tables_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles tables.CellEndEdit

    End Sub

    Private Sub tables_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tables.CellMouseClick
        id_pembayaran_box.Text = tables.Rows(e.RowIndex).Cells(0).Value
        id_pelanggan_box.Text = tables.Rows(e.RowIndex).Cells(1).Value
        cari()
        If reader.HasRows Then
            'tarik_nama() "deprecated"
            tariks()
            false_all()
        End If
    End Sub

    Private Sub time_picker_ValueChanged(sender As Object, e As EventArgs) Handles time_picker.ValueChanged

    End Sub
End Class