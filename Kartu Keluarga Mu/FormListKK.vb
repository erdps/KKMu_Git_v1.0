Public Class FormListKK
    Private Sub FormListKK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataKKmuDataSet2.tblRegKK' table. You can move, or remove it, as needed.
        Me.TblRegKKTableAdapter.Fill(Me.DataKKmuDataSet2.tblRegKK)
        DGVKK.AllowUserToAddRows = False
        LabelJmlKK.Text = DGVKK.RowCount

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Me.Validate()
        Me.TblRegKKBindingSource.RemoveCurrent()
        Me.TblRegKKTableAdapter.Update(Me.DataKKmuDataSet2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class