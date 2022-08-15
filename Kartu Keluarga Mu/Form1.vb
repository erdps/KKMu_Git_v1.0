Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Form1

    'Dim conn As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim da As New SqlDataAdapter
    'Dim ds As New DataSet
    'Dim WithEvents PD As New PrintDocument
    'Dim PPD As New PrintPreviewDialog
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataKKmuDataSet2.tblRegKK' table. You can move, or remove it, as needed.
        Me.TblRegKKTableAdapter.Fill(Me.DataKKmuDataSet2.tblRegKK)
        'TODO: This line of code loads data into the 'DataKKmuDataSet2.tblKKmu' table. You can move, or remove it, as needed.
        Me.TblKKmuTableAdapter.Fill(Me.DataKKmuDataSet2.tblKKmu)
        DGVkkmu.Sort(DGVkkmu.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        DGVkkmu.AllowUserToAddRows = False

        'Dim abcd As Integer
        'For x As Integer = 0 To DGVkkmu.Rows.Count - 1
        'If abcd = 0 Then
        '   abcd = DGVkkmu.Rows(x).Cells(0).Value
        'Else
        '   If abcd < DGVkkmu.Rows(x).Cells(0).Value Then abcd = DGVkkmu.Rows(x).Cells(0).Value
        'End If
        'Next
        'Label22.Text = abcd

        Label20.Text = DGVkkmu.RowCount

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonTambahKK.Click
        FormTambahKKBaru.Show()
        TblKKmuBindingSource.AddNew()

        ButtonTambahKK.Visible = False
        ButtonTambahWarga.Visible = False
        ButtonUbah.Visible = False
        ButtonTutup.Visible = False
        ButtonTampil.Visible = False
    End Sub

    Private Sub ButtonTambahWarga_Click(sender As Object, e As EventArgs) Handles ButtonTambahWarga.Click
        Dim resulttw As DialogResult = MessageBox.Show("Apakah anda ingin menambahkan Warga? ", "Tambah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resulttw = DialogResult.No Then
            Me.Validate()
        ElseIf resulttw = DialogResult.Yes Then
            FormTambahWarga.Show()
            GBKK.Show()

            ButtonTambahWarga.Visible = False
            ButtonTambahKK.Visible = False
            ButtonUbah.Visible = False
            ButtonTutup.Visible = False
            ButtonTampil.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        If Len(Trim(TextBoxNoKK.Text)) = 0 Then
            MessageBox.Show("Anda belum mengisi nomer KK", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNoKK.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBoxJunit.Text)) = 0 Then
            MessageBox.Show("Anda belum memilih Jenis Unit", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxJunit.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBoxSunit.Text)) = 0 Then
            MessageBox.Show("Anda belum memilih Status Unit", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxSunit.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBoxNunit.Text)) = 0 Then
            MessageBox.Show("Anda belum mengisi Nomer Unit", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNunit.Focus()
            Exit Sub
        End If
        '
        'Member Ex
        '
        If Len(Trim(TextBoxNama.Text)) = 0 Then
            MessageBox.Show("Anda belum mengisi Nama Warga", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNama.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBoxUmurmember.Text)) = 0 Then
            MessageBox.Show("Anda belum Menjumlahkan Umur Warga", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxUmurmember.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBoxLP.Text)) = 0 Then
            MessageBox.Show("Anda belum memilih Jenis Kelamin Warga", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxLP.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBoxPekerjaan.Text)) = 0 Then
            MessageBox.Show("Anda belum mengisi Pekerjaan Warga", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxPekerjaan.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBoxHubkel.Text)) = 0 Then
            MessageBox.Show("Anda belum memilih Hubungan Keluarga Warga", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxHubkel.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBoxStatus.Text)) = 0 Then
            MessageBox.Show("Anda belum memilih Status Warga", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxStatus.Focus()
            Exit Sub
        End If

        Try
            Me.Validate()
            Me.TblKKmuBindingSource.EndEdit()
            Me.TblRegKKBindingSource.EndEdit()
            Me.TblKKmuTableAdapter.Update(Me.DataKKmuDataSet2)
            Me.TblRegKKTableAdapter.Update(Me.DataKKmuDataSet2)
            MessageBox.Show("Data berhasil di update")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GBKK.Hide()
        GBanggota.Hide()
        ComboBoxHubkel.Items.Add("Istri")
        ComboBoxHubkel.Items.Add("Anak")
        ComboBoxHubkel.Items.Add("Cucu")
        ComboBoxHubkel.Items.Add("Menantu")
        ComboBoxHubkel.Items.Add("Saudara")
        ComboBoxHubkel.Items.Add("Sepupu")
        ComboBoxHubkel.Items.Add("Keponakan")

        ButtonTambahKK.Visible = True
        ButtonTambahWarga.Visible = True
        ButtonUbah.Visible = True
        ButtonTampil.Visible = True
        ButtonHapus.Visible = False
        ButtonSimpan.Visible = False
    End Sub

    Private Sub ButtonLihat_Click(sender As Object, e As EventArgs) Handles ButtonTampil.Click
        GBKK.Show()
        GBanggota.Show()
        ButtonTutup.Visible = True
        TextBoxNoKK.ReadOnly = True
        TextBoxNunit.ReadOnly = True
        TextBoxNama.ReadOnly = True
        TextBoxUmurmember.ReadOnly = True
        TextBoxTelp.ReadOnly = True
        TextBoxPekerjaan.ReadOnly = True
        TextBoxKTP.ReadOnly = True
        TextBoxKK.ReadOnly = True
        TextBoxSKT.ReadOnly = True
        ButtonHapus.Visible = True
        ButtonTampil.Visible = False
        ButtonTambahKK.Visible = False
        ButtonTambahWarga.Visible = False
        ButtonUbah.Visible = False

    End Sub

    Private Sub ButtonTutup_Click(sender As Object, e As EventArgs) Handles ButtonTutup.Click
        GBKK.Hide()
        GBanggota.Hide()
        ButtonTampil.Visible = True
        TextBoxNoKK.ReadOnly = False
        TextBoxNunit.ReadOnly = False
        TextBoxNama.ReadOnly = False
        TextBoxUmurmember.ReadOnly = False
        TextBoxTelp.ReadOnly = False
        TextBoxPekerjaan.ReadOnly = False
        TextBoxKTP.ReadOnly = False
        TextBoxKK.ReadOnly = False
        TextBoxSKT.ReadOnly = False
        ButtonTutup.Visible = False
        ButtonHapus.Visible = False
        ButtonTambahKK.Visible = True
        ButtonTambahWarga.Visible = True
        ButtonUbah.Visible = True
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        'DGVkkmu. cegah user untuk memilih baris lain
        GBanggota.Show()
        GBKK.Show()
        ButtonSimpanedit.Show()
        ButtonTampil.Visible = False
    End Sub

    Private Sub ButtonSimpanedit_Click(sender As Object, e As EventArgs) Handles ButtonSimpanedit.Click
        Try
            Me.Validate()
            Me.TblKKmuBindingSource.EndEdit()
            Me.TblKKmuTableAdapter.Update(Me.DataKKmuDataSet2)
            MessageBox.Show("Data berhasil di update")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GBKK.Hide()
        GBanggota.Hide()
        ButtonTambahKK.Visible = True
        ButtonSimpan.Visible = False
        ButtonSimpanedit.Visible = False
        ButtonTampil.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click

        Dim result As DialogResult = MessageBox.Show("Apakah anda ingin menghapus " & TextBoxNama.Text & " dari Database?", "Hapus data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Me.Validate()
        ElseIf result = DialogResult.Yes Then
            Me.Validate()
            Me.TblKKmuBindingSource.RemoveCurrent()
            Me.TblKKmuTableAdapter.Update(Me.DataKKmuDataSet2)
        End If
        'If TextBoxNoKK.Text = "" Then
        'MessageBox.Show("Anda tidak dapat menghapus baris ini", "Anda belum memilih Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'Exit Sub

        'End If


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With DGVkkmu
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(DGVkkmu.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(DGVkkmu.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Me.TblKKmuBindingSource.Filter = "NoKK LIKE '" & TextBoxSearch.Text & "%' OR Nama LIKE '" & TextBoxSearch.Text & "%'"
        If TextBoxSearch.Text = "" Then
            ButtonRef.Visible = False
        Else
            ButtonRef.Visible = True
        End If

    End Sub

    Private Sub TextBoxSearch1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch1.TextChanged
        Me.TblKKmuBindingSource.Filter = "Status LIKE '" & TextBoxSearch1.Text & "%' OR Kode LIKE '" & TextBoxSearch1.Text & "%'"
        If TextBoxSearch1.Text = "" Then
            ButtonRef.Visible = False
        Else
            ButtonRef.Visible = True
        End If

    End Sub
    '
    'Kalkulasi Umur
    '
    Private Sub ButtonUmurKepala_Click(sender As Object, e As EventArgs) Handles ButtonUmurKepala.Click
        Dim tglLahir, tglSkrg, umur As Integer

        tglLahir = Year(DateTimePickermember.Value)
        tglSkrg = Year(Now)
        umur = tglSkrg - tglLahir

        TextBoxUmurmember.Text = umur
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxJunit.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBoxSunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxSunit.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxLP.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxKode.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxHubkel.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBoxNoKK_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ButtonRef_Click(sender As Object, e As EventArgs) Handles ButtonRef.Click
        TblKKmuBindingSource.RemoveFilter()
        TextBoxSearch.Text = ""
        TextBoxSearch1.Text = ""
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        'Dim jmlwarga As Integer
        '
        'For Each nk As DataGridViewRow In DGVkkmu.Rows
        'If nk.Cells(1).Value() Then
        'jmlwarga += nk.Cells(1).Value
        'End If
        'Next
        'Label22.Text = DGVkkmu.ColumnCount
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        ButtonTambahKK.Visible = True
        ButtonTambahWarga.Visible = True
        ButtonUbah.Visible = True
        ButtonTampil.Visible = True
        GBKK.Visible = False
        GBanggota.Visible = False
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        FormListKK.Show()
    End Sub
End Class
