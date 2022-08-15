Public Class FormTambahKKBaru

    Private Sub FormTambahKKBaru_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataKKmuDataSet2.tblRegKK' table. You can move, or remove it, as needed.
        Me.TblRegKKTableAdapter.Fill(Me.DataKKmuDataSet2.tblRegKK)
        TblRegKKBindingSource.AddNew()
        TextBoxNobaru.Focus()
    End Sub

    Private Sub ButtonTambahKKbaru_Click(sender As Object, e As EventArgs) Handles ButtonTambahKKbaru.Click
        If Len(Trim(TextBoxNobaru.Text)) = 0 Then
            MessageBox.Show("Anda belum memasukan No urut", "Gagal menambahkan Data!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNobaru.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBoxNokkbaru.Text)) = 0 Then
            MessageBox.Show("Anda belum memasukan No urut", "Gagal menambahkan Data!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNokkbaru.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBoxJunitbaru.Text)) = 0 Then
            MessageBox.Show("Anda belum memasukan No urut", "Gagal menambahkan Data!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxJunitbaru.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBoxSunitbaru.Text)) = 0 Then
            MessageBox.Show("Anda belum memasukan No urut", "Gagal menambahkan Data!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxSunitbaru.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBoxNunitbaru.Text)) = 0 Then
            MessageBox.Show("Anda belum memasukan No urut", "Gagal menambahkan Data!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNunitbaru.Focus()
            Exit Sub
        End If

        Form1.GBKK.Show()
        Form1.GBanggota.Show()
        Form1.TextBoxNama.Focus()

        Try
            Me.Validate()
            Me.TblRegKKBindingSource.EndEdit()
            Me.TblRegKKTableAdapter.Update(Me.DataKKmuDataSet2)
            MessageBox.Show("Silahkan masukan data Kepala Keluarga", "Masukan data Kepala Keluarga")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Form1.ComboBoxHubkel.Text = "Kepala Keluarga"
        Form1.ComboBoxHubkel.Items.Remove("Istri")
        Form1.ComboBoxHubkel.Items.Remove("Anak")
        Form1.ComboBoxHubkel.Items.Remove("Cucu")
        Form1.ComboBoxHubkel.Items.Remove("Menantu")
        Form1.ComboBoxHubkel.Items.Remove("Saudara")
        Form1.ComboBoxHubkel.Items.Remove("Sepupu")
        Form1.ComboBoxHubkel.Items.Remove("Keponakan")

        Form1.TextBoxNo.Text = TextBoxNobaru.Text
        Form1.TextBoxNoKK.Text = TextBoxNokkbaru.Text
        Form1.ComboBoxJunit.Text = ComboBoxJunitbaru.Text
        Form1.ComboBoxSunit.Text = ComboBoxSunitbaru.Text
        Form1.TextBoxNunit.Text = TextBoxNunitbaru.Text

        'Dim show As String
        'show = DataGridView1.Rows(3).Cells(2).Value
        'ComboBoxJunit.Text = show
        'TextBoxSunit.Text = show
        Form1.ButtonTambahKK.Visible = False
        Form1.ButtonSimpan.Visible = True
        Form1.ButtonUbah.Visible = False
        Form1.ButtonHapus.Visible = False
        Form1.ButtonTampil.Visible = False

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Validate()
        Form1.TblKKmuBindingSource.RemoveCurrent()
        Form1.TblKKmuTableAdapter.Update(Me.DataKKmuDataSet2)
        Form1.ButtonTambahKK.Visible = True
        Form1.ButtonTambahWarga.Visible = True
        Form1.ButtonUbah.Visible = True
        Form1.ButtonTampil.Visible = True
        Form1.GBKK.Visible = False

    End Sub
End Class