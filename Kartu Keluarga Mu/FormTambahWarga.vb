Public Class FormTambahWarga
    Private Sub TambahWarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataKKmuDataSet2.tblKKmu' table. You can move, or remove it, as needed.
        Me.TblKKmuTableAdapter.Fill(Me.DataKKmuDataSet2.tblKKmu)
        'TODO: This line of code loads data into the 'DataKKmuDataSet2.tblRegKK' table. You can move, or remove it, as needed.
        Me.TblRegKKTableAdapter.Fill(Me.DataKKmuDataSet2.tblRegKK)

    End Sub

    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click

        Form1.GBKK.Show()
        Form1.GBanggota.Show()
        Form1.TblKKmuBindingSource.AddNew()
        Form1.TextBoxNama.Focus()

        Form1.TextBoxNoKK.Text = CBPilihkk.Text
        Form1.ComboBoxJunit.Text = TextBoxJunit.Text
        Form1.ComboBoxSunit.Text = TextBoxSunit.Text
        Form1.TextBoxNunit.Text = TBNunit.Text


        Form1.ButtonTambahKK.Visible = False
        Form1.ButtonSimpan.Visible = True
        Form1.ButtonUbah.Visible = False
        Form1.ButtonHapus.Visible = False
        Form1.ButtonTampil.Visible = False

        Me.Hide()
    End Sub

    Private Sub TextBoxSearchKK_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchKK.TextChanged
        Form1.TblKKmuBindingSource.Filter = "NoKK LIKE '" & TextBoxSearchKK.Text & "%'"
        TblRegKKBindingSource.Filter = "NoKK LIKE '" & TextBoxSearchKK.Text & "%'"
        CBPilihkk.Text = TextBoxSearchKK.Text
        'TextBoxJunit.Text = ""
        'TextBoxSunit.Text = ""
        'TBNunit.Text = ""

    End Sub

    Private Sub CBPilihkk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPilihkk.SelectedIndexChanged
        Form1.TblKKmuBindingSource.Filter = "NoKK LIKE '" & CBPilihkk.Text & "%'"
        TextBoxSearchKK.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        Form1.ButtonTambahKK.Visible = True
        Form1.ButtonTambahWarga.Visible = True
        Form1.ButtonUbah.Visible = True
        Form1.ButtonTampil.Visible = True
        Form1.GBKK.Visible = False

    End Sub
End Class