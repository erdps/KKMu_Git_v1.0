<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListKK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DGVKK = New System.Windows.Forms.DataGridView()
        Me.DataKKmuDataSet2 = New Kartu_Keluarga_Mu.DataKKmuDataSet2()
        Me.TblRegKKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRegKKTableAdapter = New Kartu_Keluarga_Mu.DataKKmuDataSet2TableAdapters.tblRegKKTableAdapter()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NokkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NounitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelJmlKK = New System.Windows.Forms.Label()
        CType(Me.DGVKK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataKKmuDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRegKKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVKK
        '
        Me.DGVKK.AutoGenerateColumns = False
        Me.DGVKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NokkDataGridViewTextBoxColumn, Me.JenisunitDataGridViewTextBoxColumn, Me.StatusunitDataGridViewTextBoxColumn, Me.NounitDataGridViewTextBoxColumn})
        Me.DGVKK.DataSource = Me.TblRegKKBindingSource
        Me.DGVKK.Location = New System.Drawing.Point(6, 36)
        Me.DGVKK.Name = "DGVKK"
        Me.DGVKK.Size = New System.Drawing.Size(428, 407)
        Me.DGVKK.TabIndex = 0
        '
        'DataKKmuDataSet2
        '
        Me.DataKKmuDataSet2.DataSetName = "DataKKmuDataSet2"
        Me.DataKKmuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRegKKBindingSource
        '
        Me.TblRegKKBindingSource.DataMember = "tblRegKK"
        Me.TblRegKKBindingSource.DataSource = Me.DataKKmuDataSet2
        '
        'TblRegKKTableAdapter
        '
        Me.TblRegKKTableAdapter.ClearBeforeFill = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonHapus.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.ForeColor = System.Drawing.Color.Black
        Me.ButtonHapus.Location = New System.Drawing.Point(235, 4)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(63, 27)
        Me.ButtonHapus.TabIndex = 7
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(304, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(51, 7)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxSearch.TabIndex = 28
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label63.Location = New System.Drawing.Point(3, 7)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(42, 17)
        Me.Label63.TabIndex = 27
        Me.Label63.Text = "Cari:"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 30
        '
        'NokkDataGridViewTextBoxColumn
        '
        Me.NokkDataGridViewTextBoxColumn.DataPropertyName = "Nokk"
        Me.NokkDataGridViewTextBoxColumn.HeaderText = "KK"
        Me.NokkDataGridViewTextBoxColumn.Name = "NokkDataGridViewTextBoxColumn"
        Me.NokkDataGridViewTextBoxColumn.Width = 105
        '
        'JenisunitDataGridViewTextBoxColumn
        '
        Me.JenisunitDataGridViewTextBoxColumn.DataPropertyName = "Jenisunit"
        Me.JenisunitDataGridViewTextBoxColumn.HeaderText = "Jenis Unit"
        Me.JenisunitDataGridViewTextBoxColumn.Name = "JenisunitDataGridViewTextBoxColumn"
        '
        'StatusunitDataGridViewTextBoxColumn
        '
        Me.StatusunitDataGridViewTextBoxColumn.DataPropertyName = "Statusunit"
        Me.StatusunitDataGridViewTextBoxColumn.HeaderText = "Status Unit"
        Me.StatusunitDataGridViewTextBoxColumn.Name = "StatusunitDataGridViewTextBoxColumn"
        '
        'NounitDataGridViewTextBoxColumn
        '
        Me.NounitDataGridViewTextBoxColumn.DataPropertyName = "Nounit"
        Me.NounitDataGridViewTextBoxColumn.HeaderText = "No Unit"
        Me.NounitDataGridViewTextBoxColumn.Name = "NounitDataGridViewTextBoxColumn"
        Me.NounitDataGridViewTextBoxColumn.Width = 50
        '
        'LabelJmlKK
        '
        Me.LabelJmlKK.AutoSize = True
        Me.LabelJmlKK.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJmlKK.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelJmlKK.Location = New System.Drawing.Point(402, 15)
        Me.LabelJmlKK.Name = "LabelJmlKK"
        Me.LabelJmlKK.Size = New System.Drawing.Size(32, 18)
        Me.LabelJmlKK.TabIndex = 32
        Me.LabelJmlKK.Text = "200"
        '
        'FormListKK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(440, 450)
        Me.Controls.Add(Me.LabelJmlKK)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.DGVKK)
        Me.Name = "FormListKK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KK Terdaftar"
        CType(Me.DGVKK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataKKmuDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRegKKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVKK As DataGridView
    Friend WithEvents DataKKmuDataSet2 As DataKKmuDataSet2
    Friend WithEvents TblRegKKBindingSource As BindingSource
    Friend WithEvents TblRegKKTableAdapter As DataKKmuDataSet2TableAdapters.tblRegKKTableAdapter
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NokkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NounitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabelJmlKK As Label
End Class
