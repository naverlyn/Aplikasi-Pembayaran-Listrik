Public Class Frontend

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        user.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Pelanggan.Show()
    End Sub

    Private Sub TarifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem.Click
        tarif.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Visible = False
    End Sub

    Private Sub TagihToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihToolStripMenuItem.Click
        Tagih.Show()
    End Sub

    Private Sub PenggunaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaanToolStripMenuItem.Click
        Penggunaan_old.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Cetak.Show()
    End Sub
End Class