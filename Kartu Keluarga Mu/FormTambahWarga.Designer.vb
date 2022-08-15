<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahWarga
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
        Me.GBkklama = New System.Windows.Forms.GroupBox()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.CBPilihkk = New System.Windows.Forms.ComboBox()
        Me.TblRegKKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataKKmuDataSet2 = New Kartu_Keluarga_Mu.DataKKmuDataSet2()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TBNunit = New System.Windows.Forms.TextBox()
        Me.TblRegKKTableAdapter = New Kartu_Keluarga_Mu.DataKKmuDataSet2TableAdapters.tblRegKKTableAdapter()
        Me.TblKKmuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblKKmuTableAdapter = New Kartu_Keluarga_Mu.DataKKmuDataSet2TableAdapters.tblKKmuTableAdapter()
        Me.TextBoxSearchKK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxJunit = New System.Windows.Forms.TextBox()
        Me.TextBoxSunit = New System.Windows.Forms.TextBox()
        Me.GBkklama.SuspendLayout()
        CType(Me.TblRegKKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataKKmuDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKKmuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBkklama
        '
        Me.GBkklama.BackColor = System.Drawing.Color.DodgerBlue
        Me.GBkklama.Controls.Add(Me.TextBoxSunit)
        Me.GBkklama.Controls.Add(Me.TextBoxJunit)
        Me.GBkklama.Controls.Add(Me.Button1)
        Me.GBkklama.Controls.Add(Me.Label1)
        Me.GBkklama.Controls.Add(Me.TextBoxSearchKK)
        Me.GBkklama.Controls.Add(Me.ButtonCopy)
        Me.GBkklama.Controls.Add(Me.CBPilihkk)
        Me.GBkklama.Controls.Add(Me.Label17)
        Me.GBkklama.Controls.Add(Me.Label23)
        Me.GBkklama.Controls.Add(Me.Label24)
        Me.GBkklama.Controls.Add(Me.Label25)
        Me.GBkklama.Controls.Add(Me.TBNunit)
        Me.GBkklama.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GBkklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBkklama.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GBkklama.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBkklama.ForeColor = System.Drawing.Color.Gold
        Me.GBkklama.Location = New System.Drawing.Point(0, 0)
        Me.GBkklama.Name = "GBkklama"
        Me.GBkklama.Size = New System.Drawing.Size(368, 226)
        Me.GBkklama.TabIndex = 35
        Me.GBkklama.TabStop = False
        Me.GBkklama.Text = "Pilih KK"
        '
        'ButtonCopy
        '
        Me.ButtonCopy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCopy.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCopy.ForeColor = System.Drawing.Color.Black
        Me.ButtonCopy.Location = New System.Drawing.Point(293, 187)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(63, 27)
        Me.ButtonCopy.TabIndex = 4
        Me.ButtonCopy.Text = "Tambah"
        Me.ButtonCopy.UseVisualStyleBackColor = False
        '
        'CBPilihkk
        '
        Me.CBPilihkk.DataSource = Me.TblRegKKBindingSource
        Me.CBPilihkk.DisplayMember = "Nokk"
        Me.CBPilihkk.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPilihkk.FormattingEnabled = True
        Me.CBPilihkk.Location = New System.Drawing.Point(142, 63)
        Me.CBPilihkk.Name = "CBPilihkk"
        Me.CBPilihkk.Size = New System.Drawing.Size(122, 22)
        Me.CBPilihkk.TabIndex = 0
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(9, 147)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 17)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Nomer Unit:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(9, 119)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 17)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Status Unit:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(9, 91)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 17)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Jenis Unit:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Location = New System.Drawing.Point(9, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 17)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "List KK:"
        '
        'TBNunit
        '
        Me.TBNunit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Nounit", True))
        Me.TBNunit.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNunit.Location = New System.Drawing.Point(142, 147)
        Me.TBNunit.Name = "TBNunit"
        Me.TBNunit.ReadOnly = True
        Me.TBNunit.Size = New System.Drawing.Size(63, 22)
        Me.TBNunit.TabIndex = 3
        '
        'TblRegKKTableAdapter
        '
        Me.TblRegKKTableAdapter.ClearBeforeFill = True
        '
        'TblKKmuBindingSource
        '
        Me.TblKKmuBindingSource.DataMember = "tblKKmu"
        Me.TblKKmuBindingSource.DataSource = Me.DataKKmuDataSet2
        '
        'TblKKmuTableAdapter
        '
        Me.TblKKmuTableAdapter.ClearBeforeFill = True
        '
        'TextBoxSearchKK
        '
        Me.TextBoxSearchKK.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearchKK.Location = New System.Drawing.Point(142, 35)
        Me.TextBoxSearchKK.MaxLength = 16
        Me.TextBoxSearchKK.Name = "TextBoxSearchKK"
        Me.TextBoxSearchKK.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxSearchKK.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "No KK:"
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
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxJunit
        '
        Me.TextBoxJunit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Jenisunit", True))
        Me.TextBoxJunit.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJunit.Location = New System.Drawing.Point(142, 91)
        Me.TextBoxJunit.Name = "TextBoxJunit"
        Me.TextBoxJunit.Size = New System.Drawing.Size(119, 22)
        Me.TextBoxJunit.TabIndex = 39
        '
        'TextBoxSunit
        '
        Me.TextBoxSunit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRegKKBindingSource, "Statusunit", True))
        Me.TextBoxSunit.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSunit.Location = New System.Drawing.Point(142, 119)
        Me.TextBoxSunit.Name = "TextBoxSunit"
        Me.TextBoxSunit.Size = New System.Drawing.Size(119, 22)
        Me.TextBoxSunit.TabIndex = 40
        '
        'FormTambahWarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 226)
        Me.Controls.Add(Me.GBkklama)
        Me.Name = "FormTambahWarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Warga"
        Me.GBkklama.ResumeLayout(False)
        Me.GBkklama.PerformLayout()
        CType(Me.TblRegKKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataKKmuDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKKmuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBkklama As GroupBox
    Friend WithEvents ButtonCopy As Button
    Friend WithEvents CBPilihkk As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TBNunit As TextBox
    Friend WithEvents DataKKmuDataSet2 As DataKKmuDataSet2
    Friend WithEvents TblRegKKBindingSource As BindingSource
    Friend WithEvents TblRegKKTableAdapter As DataKKmuDataSet2TableAdapters.tblRegKKTableAdapter
    Friend WithEvents TblKKmuBindingSource As BindingSource
    Friend WithEvents TblKKmuTableAdapter As DataKKmuDataSet2TableAdapters.tblKKmuTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearchKK As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxSunit As TextBox
    Friend WithEvents TextBoxJunit As TextBox
End Class
