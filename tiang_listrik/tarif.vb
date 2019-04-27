Imports System.Data.Odbc

Public Class tarif

    Sub delete_semua()
        kode_text.Text = "-Pilih-"
        daya_text.Clear()
        tarif_text.Clear()
    End Sub

    Sub membuat()
        kode_text.Text = "-Pilih-"
        daya_text.Clear()
        tarif_text.Clear()
        kode_text.Focus()
    End Sub

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from tb_tarif", connect)
        kutil = New DataSet
        adapter.Fill(kutil)
        tables.DataSource = kutil.Tables(0)
        tables.ReadOnly = True
    End Sub


    Sub buat_case()
        Select Case kode_text.Text
            Case "KT45"
                daya_text.Text = "450 VA"
                tarif_text.Text = "170"
            Case "KT90"
                daya_text.Text = "900 VA"
                tarif_text.Text = "310"
            Case "KT130"
                daya_text.Text = "1300 VA"
                tarif_text.Text = "390"
            Case "KT220"
                daya_text.Text = "2200 VA"
                tarif_text.Text = "400"
            Case "KT660"
                daya_text.Text = "6600 VA"
                tarif_text.Text = "620"
        End Select
    End Sub

    Sub ketemu()
        On Error Resume Next
        kode_text.Enabled = False
        daya_text.Text = reader("daya_tarif")
        tarif_text.Text = reader("tarif_kwh")
    End Sub

    Sub cari()
        koneksi()
        command = New OdbcCommand("select * from tb_tarif where kode_tarif='" & kode_text.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
    End Sub

    Private Sub kode_text_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kode_text.SelectedIndexChanged
        buat_case()
    End Sub

    Private Sub saving_Click(sender As Object, e As EventArgs) Handles saving.Click
        Try
            cari()
            If Not reader.HasRows Then
                koneksi()
                Dim simpan As String = "insert into tb_tarif values('" & kode_text.Text & "', '" & daya_text.Text & "', '" & tarif_text.Text & "')"
                command = New OdbcCommand(simpan, connect)
                command.ExecuteNonQuery()
            Else
                koneksi()
                Dim update As String = "update tb_tarif set daya_tarif='" & daya_text.Text & "', tarif_kwh='" & tarif_text.Text & "' where kode_tarif='" & kode_text.Text & "'"
                command = New OdbcCommand(update, connect)
                command.ExecuteNonQuery()
            End If
            tampil()
            delete_semua()
        Catch ex As Exception
        End Try
        kode_text.Enabled = True
    End Sub

    Private Sub tarif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        kode_text.Text = "-Pilih-"
        kode_text.Enabled = True
    End Sub

    Private Sub refreshing_Click(sender As Object, e As EventArgs) Handles refreshing.Click
        delete_semua()
        kode_text.Enabled = True
    End Sub

    Private Sub deleting_Click(sender As Object, e As EventArgs) Handles deleting.Click
        If MessageBox.Show("Apakah anda yakin ingin menghapus record ini ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim delete As String = "delete from tb_tarif where kode_tarif='" & kode_text.Text & "'"
            command = New OdbcCommand(delete, connect)
            command.ExecuteNonQuery()
            tampil()
            delete_semua()
            kode_text.Enabled = True
        Else
            delete_semua()
            kode_text.Enabled = True
        End If
    End Sub

    Private Sub tables_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tables.CellMouseClick
        On Error Resume Next
        kode_text.Text = tables.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            ketemu()
        End If
    End Sub

    Private Sub canceling_Click(sender As Object, e As EventArgs) Handles canceling.Click
        Me.Close()
    End Sub
End Class