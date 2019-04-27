Imports System.Data.Odbc

Public Class Pelanggan

    Sub delete_semua()
        meter_text.Clear()
        nama_text.Clear()
        alamat_text.Clear()
        tarif_text.Text = ""
        tarif_text1.Clear()
    End Sub

    Sub random()
        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        'For i As Integer = 48 To 57
        'Letters.Add(i)
        'Next
        'lowercase letters
        'For i As Integer = 97 To 122
        'Letters.Add(i)
        'Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 8
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
        Next

        tarif_text1.Text = SB.ToString

    End Sub

    Sub rename_table()
        With table.ColumnHeadersDefaultCellStyle
            table.Columns(0).HeaderText = "ID Pelanggan"
            table.Columns(1).HeaderText = "No. Meter"
            table.Columns(2).HeaderText = "Nama Pelanggan"
            table.Columns(3).HeaderText = "Alamat"
            table.Columns(4).HeaderText = "Kode Tarif"
            table.Columns(5).HeaderText = "Kode Unik"
            table.Columns(0).Width = 120
        End With
    End Sub

    Sub buat()
        id_text.Clear()
        meter_text.Clear()
        nama_text.Clear()
        alamat_text.Clear()
        tarif_text.Text = ""
        tarif_text1.Clear()
        id_text.Focus()
    End Sub

    Sub tampil()
        koneksi()
        adapter = New OdbcDataAdapter("select * from tb_pelanggan", connect)
        kutil = New DataSet
        adapter.Fill(kutil)
        table.DataSource = kutil.Tables(0)
        table.ReadOnly = True
        tarif_text1.MaxLength = "5"
    End Sub

    Sub automatic()
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan order by id_pelanggan desc", connect)
        reader = command.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            id_text.Text = "PLG" + "0001"
        Else
            id_text.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_pelanggan").ToString, 5, 4)) + 1
            If Len(id_text.Text) = 1 Then
                id_text.Text = "PLG000" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 2 Then
                id_text.Text = "PLG00" & id_text.Text & ""
            ElseIf Len(id_text.Text) = 3 Then
                id_text.Text = "PLG0" & id_text.Text & ""
            End If
        End If
        id_text.Enabled = False
    End Sub

    Sub automatic_nometer()
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan order by nometer desc", connect)
        reader = command.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            meter_text.Text = "81000000" + "1001"
        Else
            'If Microsoft.VisualBasic.Left(reader("nometer"), 6) = 
        End If
        ' End If

    End Sub

    Sub cases()
        Select Case tarif_text.Text
            Case "KT45"
                random()
            Case "KT90"
                random()
            Case "KT130"
                random()
            Case "KT220"
                random()
            Case "KT660"
                random()
        End Select
    End Sub

    Sub cari()
        koneksi()
        command = New OdbcCommand("select * from tb_pelanggan where id_pelanggan='" & id_text.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
    End Sub

    Sub ketemu()
        On Error Resume Next
        meter_text.Text = reader("nometer")
        nama_text.Text = reader("nama_pelanggan")
        alamat_text.Text = reader("alamat_pelanggan")
        tarif_text.Text = reader("kode_tarif")
        tarif_text1.Text = reader("kode_unik")
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketemu()
        tampil()
        id_text.Focus()
        automatic()
        meter_text.MaxLength = 16
        rename_table()
    End Sub

    Private Sub saving_Click(sender As Object, e As EventArgs) Handles saving.Click
        If id_text.Text = "" Or meter_text.Text = "" Or nama_text.Text = "" Or alamat_text.Text = "" Or tarif_text.Text = "" Or tarif_text1.Text = "" Then
            MsgBox("Harap Diisi Dengan Benar")
        Else
            Try
                cari()
                If Not reader.HasRows Then
                    koneksi()
                    Dim simpan As String = "insert into tb_pelanggan values('" & id_text.Text & "', '" & meter_text.Text & "', '" & nama_text.Text & "', '" & alamat_text.Text & "', '" & tarif_text.Text & "', '" & tarif_text1.Text & "')"
                    command = New OdbcCommand(simpan, connect)
                    command.ExecuteNonQuery()
                Else
                    koneksi()
                    Dim ubah As String = "update tb_pelanggan set nometer='" & meter_text.Text & "', nama_pelanggan='" & nama_text.Text & "', alamat_pelanggan='" & alamat_text.Text & "', kode_tarif='" & tarif_text.Text & "', kode_unik='" & tarif_text1.Text & "' where id_pelanggan='" & id_text.Text & "'"
                    command = New OdbcCommand(ubah, connect)
                    command.ExecuteNonQuery()
                End If
                delete_semua()
                tampil()
                automatic()
            Catch ex As Exception
            End Try
        End If
        tarif_text.Enabled = True
    End Sub

    Private Sub table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles table.CellMouseClick
        On Error Resume Next
        id_text.Text = table.Rows(e.RowIndex).Cells(0).Value
        cari()
        If reader.HasRows Then
            tarif_text.Enabled = False
            ketemu()
        End If
    End Sub

    Private Sub deleting_Click(sender As Object, e As EventArgs) Handles deleting.Click
        If MessageBox.Show("Anda yakin ingin menghapus Record ini ?", " Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            Dim delete As String = "delete from tb_pelanggan where id_pelanggan='" & id_text.Text & "'"
            command = New OdbcCommand(delete, connect)
            command.ExecuteNonQuery()
        Else
            delete_semua()
        End If
        delete_semua()
        tampil()
        automatic()
        tarif_text.Enabled = True
    End Sub

    Private Sub refreshing_Click(sender As Object, e As EventArgs) Handles refreshing.Click
        delete_semua()
        automatic()
        tarif_text.Enabled = True
    End Sub

    Private Sub canceling_Click(sender As Object, e As EventArgs) Handles canceling.Click
        Dispose()
    End Sub

    Private Sub tarif_text_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tarif_text.SelectedIndexChanged
        cases()
    End Sub

End Class