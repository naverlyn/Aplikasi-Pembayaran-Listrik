Imports System.Data.Odbc

Public Class Login
    Sub delete()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        Label1.Text = ""
        UsernameTextBox.Focus()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        koneksi()
        UsernameTextBox.Focus()
        command = New OdbcCommand("select * from tb_user where nama_user='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'", connect)
        reader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            Me.Visible = False
            Frontend.Show()
            If reader.HasRows Then
                Frontend.Panel1.Text = reader("id_user")
                Frontend.Panel2.Text = reader("nama_user")
                Frontend.Panel3.Text = reader(UCase("status"))
                If Frontend.Panel3.Text <> "Administrator" Then
                    Frontend.UserToolStripMenuItem.Visible = False
                Else
                    Frontend.UserToolStripMenuItem.Visible = True
                End If
            End If
            delete()
        Else
            Label1.Text = "Username atau password salah!"
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
