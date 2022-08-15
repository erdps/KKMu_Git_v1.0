<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTambahKKBaru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GBkkbaru = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBoxNokkbaru = New System.Windows.Forms.TextBox()
        Me.TblRegKKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataKKmuDataSet2 = New Kartu_Keluarga_Mu.DataKKmuDataSet2()
        Me.TextBoxNobaru = New System.Windows.Forms.TextBox()
        Me.ButtonTambahKKbaru = New System.Windows.Forms.Button()
        Me.ComboBoxSunitbaru = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ComboBoxJunitbaru = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBoxNunitbaru = New System.Windows.Forms.TextBox()
        Me.TblRegKKTableAdapter = New Kartu_Keluarga_Mu.DataKKmuDataSet2TableAdapters.tblRegKKTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GBkkbaru.SuspendLayout()
        CType(Me.TblRegKKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataKKmuDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBkkbaru
        '
        Me.GBkkbaru.BackColor = System.Drawing.Color.DodgerBlue
        Me.GBkkbaru.Controls.Add(Me.Button1)
        Me.GBkkbaru.Controls.Add(Me.Label30)
        Me.GBkkbaru.Controls.Add(Me.TextBoxNokkbaru)
        Me.GBkkbaru.Controls.Add(Me.TextBoxNobaru)
        Me.GBkkbaru.Controls.Add(Me.ButtonTambahKKbaru)
        Me.GBkkbaru.Controls.Add(Me.ComboBoxSunitbaru)
        Me.GBkkbaru.Controls.Add(Me.Label26)
        Me.GBkkbaru.Controls.Add(Me.Label27)
        Me.GBkkbaru.Controls.Add(Me.Label28)
        Me.GBkkbaru.Controls.Add(Me.ComboBoxJunitbaru)
        Me.GBkkbaru.Controls.Add(Me.Label29)
        Me.GBkkbaru.Controls.Add(Me.TextBoxNunitbaru)
        Me.GBkkbaru.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GBkkbaru.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBkkbaru.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GBkkbaru.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBkkbaru.ForeColor = System.Drawing.Color.Gold
        Me.GBkkbaru.Location = New System.Drawing.Point(0, 0)
        Me.GBkkbaru.Name = "GBkkbaru"
        Me.GBkkbaru.Size = New System.Drawing.Size(368, 226)
        Me.GBkkbaru.TabIndex = 36
        Me.GBkkbaru.TabStop = False
        Me.GBkkbaru.Text = "Data KK Baru"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label30.Location = New System.Drawing.Point(9, 34)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 17)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "No:"
        '
        'TextBoxNokkbaru
        '
        Me.TextBoxNokkbaru.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Nokk", True))
        Me.TextBoxNokkbaru.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNokkbaru.Location = New System.Drawing.Point(142, 62)
        Me.TextBoxNokkbaru.MaxLength = 16
        Me.TextBoxNokkbaru.Name = "TextBoxNokkbaru"
        Me.TextBoxNokkbaru.Size = New System.Drawing.Size(123, 22)
        Me.TextBoxNokkbaru.TabIndex = 1
        '
        'TblRegKKBindingSource
        '
        Me.TblRegKKBindingSource.DataMember = "tblRegKK"
        Me.TblRegKKBindingSource.DataSource = Me.DataKKmuDataSet2
        '
        'DataKKmuDataSet2
        '
        Me.DataKKmuDataSet2.DataSetName = "DataKKmuDataSet2"
        Me.DataKKmuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxNobaru
        '
        Me.TextBoxNobaru.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Id", True))
        Me.TextBoxNobaru.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNobaru.Location = New System.Drawing.Point(142, 34)
        Me.TextBoxNobaru.Name = "TextBoxNobaru"
        Me.TextBoxNobaru.Size = New System.Drawing.Size(31, 22)
        Me.TextBoxNobaru.TabIndex = 0
        '
        'ButtonTambahKKbaru
        '
        Me.ButtonTambahKKbaru.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonTambahKKbaru.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonTambahKKbaru.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambahKKbaru.ForeColor = System.Drawing.Color.Black
        Me.ButtonTambahKKbaru.Location = New System.Drawing.Point(293, 187)
        Me.ButtonTambahKKbaru.Name = "ButtonTambahKKbaru"
        Me.ButtonTambahKKbaru.Size = New System.Drawing.Size(63, 27)
        Me.ButtonTambahKKbaru.TabIndex = 5
        Me.ButtonTambahKKbaru.Text = "Tambah"
        Me.ButtonTambahKKbaru.UseVisualStyleBackColor = False
        '
        'ComboBoxSunitbaru
        '
        Me.ComboBoxSunitbaru.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Statusunit", True))
        Me.ComboBoxSunitbaru.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSunitbaru.FormattingEnabled = True
        Me.ComboBoxSunitbaru.Items.AddRange(New Object() {"Milik Pribadi", "Kontrak/Sewa"})
        Me.ComboBoxSunitbaru.Location = New System.Drawing.Point(142, 119)
        Me.ComboBoxSunitbaru.Name = "ComboBoxSunitbaru"
        Me.ComboBoxSunitbaru.Size = New System.Drawing.Size(122, 22)
        Me.ComboBoxSunitbaru.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(9, 147)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(93, 17)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Nomer Unit:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Location = New System.Drawing.Point(9, 119)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 17)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Status Unit:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Location = New System.Drawing.Point(9, 91)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 17)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Jenis Unit:"
        '
        'ComboBoxJunitbaru
        '
        Me.ComboBoxJunitbaru.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Jenisunit", True))
        Me.ComboBoxJunitbaru.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxJunitbaru.FormattingEnabled = True
        Me.ComboBoxJunitbaru.Items.AddRange(New Object() {"Rumah", "Petakan", "Ruko", "Masjid/Mushola", "Kantor", "Sekolah"})
        Me.ComboBoxJunitbaru.Location = New System.Drawing.Point(142, 91)
        Me.ComboBoxJunitbaru.Name = "ComboBoxJunitbaru"
        Me.ComboBoxJunitbaru.Size = New System.Drawing.Size(122, 22)
        Me.ComboBoxJunitbaru.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.Location = New System.Drawing.Point(9, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 17)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Nomer KK:"
        '
        'TextBoxNunitbaru
        '
        Me.TextBoxNunitbaru.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Nounit", True))
        Me.TextBoxNunitbaru.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNunitbaru.Location = New System.Drawing.Point(142, 147)
        Me.TextBoxNunitbaru.Name = "TextBoxNunitbaru"
        Me.TextBoxNunitbaru.Size = New System.Drawing.Size(63, 22)
        Me.TextBoxNunitbaru.TabIndex = 4
        '
        'TblRegKKTableAdapter
        '
        Me.TblRegKKTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(224, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 27)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormTambahKKBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 226)
        Me.Controls.Add(Me.GBkkbaru)
        Me.Name = "FormTambahKKBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah KK"
        Me.GBkkbaru.ResumeLayout(False)
        Me.GBkkbaru.PerformLayout()
        CType(Me.TblRegKKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataKKmuDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBkkbaru As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBoxNokkbaru As TextBox
    Friend WithEvents TextBoxNobaru As TextBox
    Friend WithEvents ButtonTambahKKbaru As Button
    Friend WithEvents ComboBoxSunitbaru As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents ComboBoxJunitbaru As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBoxNunitbaru As TextBox
    Friend WithEvents DataKKmuDataSet2 As DataKKmuDataSet2
    Friend WithEvents TblRegKKBindingSource As BindingSource
    Friend WithEvents TblRegKKTableAdapter As DataKKmuDataSet2TableAdapters.tblRegKKTableAdapter
    Friend WithEvents Button1 As Button
End Class
