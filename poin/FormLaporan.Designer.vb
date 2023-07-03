<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        LabelTotal = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        RadioButtonBulanIni = New RadioButton()
        RadioButtonHariIni = New RadioButton()
        ButtonFilter = New Guna.UI2.WinForms.Guna2GradientButton()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Labelcari = New Label()
        TextBoxCari = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        kolProduk = New DataGridViewButtonColumn()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(LabelTotal)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1104, 100)
        Panel1.TabIndex = 0
        ' 
        ' LabelTotal
        ' 
        LabelTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LabelTotal.AutoSize = True
        LabelTotal.BackColor = Color.Transparent
        LabelTotal.Font = New Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotal.ForeColor = Color.Orange
        LabelTotal.Location = New Point(964, 24)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(128, 61)
        LabelTotal.TabIndex = 2
        LabelTotal.Text = "0.00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 43)
        Label1.TabIndex = 1
        Label1.Text = "Laporan Penjualan"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(RadioButtonBulanIni)
        Panel2.Controls.Add(RadioButtonHariIni)
        Panel2.Controls.Add(ButtonFilter)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Labelcari)
        Panel2.Controls.Add(TextBoxCari)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1104, 83)
        Panel2.TabIndex = 1
        ' 
        ' RadioButtonBulanIni
        ' 
        RadioButtonBulanIni.AutoSize = True
        RadioButtonBulanIni.Location = New Point(385, 26)
        RadioButtonBulanIni.Name = "RadioButtonBulanIni"
        RadioButtonBulanIni.Size = New Size(104, 29)
        RadioButtonBulanIni.TabIndex = 8
        RadioButtonBulanIni.TabStop = True
        RadioButtonBulanIni.Text = "Bulan Ini"
        RadioButtonBulanIni.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonHariIni
        ' 
        RadioButtonHariIni.AutoSize = True
        RadioButtonHariIni.Location = New Point(286, 26)
        RadioButtonHariIni.Name = "RadioButtonHariIni"
        RadioButtonHariIni.Size = New Size(93, 29)
        RadioButtonHariIni.TabIndex = 7
        RadioButtonHariIni.TabStop = True
        RadioButtonHariIni.Text = "Hari Ini"
        RadioButtonHariIni.UseVisualStyleBackColor = True
        ' 
        ' ButtonFilter
        ' 
        ButtonFilter.CustomizableEdges = CustomizableEdges1
        ButtonFilter.DisabledState.BorderColor = Color.DarkGray
        ButtonFilter.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonFilter.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonFilter.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonFilter.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonFilter.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonFilter.FillColor2 = Color.Black
        ButtonFilter.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonFilter.ForeColor = Color.White
        ButtonFilter.Location = New Point(897, 20)
        ButtonFilter.Name = "ButtonFilter"
        ButtonFilter.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ButtonFilter.Size = New Size(143, 34)
        ButtonFilter.TabIndex = 6
        ButtonFilter.Text = "Cari"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(709, 23)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(163, 31)
        DateTimePicker2.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(529, 23)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(163, 31)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Labelcari
        ' 
        Labelcari.AutoSize = True
        Labelcari.Location = New Point(12, 31)
        Labelcari.Name = "Labelcari"
        Labelcari.Size = New Size(42, 25)
        Labelcari.TabIndex = 1
        Labelcari.Text = "Cari"
        ' 
        ' TextBoxCari
        ' 
        TextBoxCari.Location = New Point(74, 25)
        TextBoxCari.Name = "TextBoxCari"
        TextBoxCari.Size = New Size(191, 31)
        TextBoxCari.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column7, Column5, kolProduk})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 183)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1104, 423)
        DataGridView1.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 59
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Nomor Transaksi"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Column3.DefaultCellStyle = DataGridViewCellStyle1
        Column3.HeaderText = "Tanggal"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 109
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Bulan"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Visible = False
        Column4.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "bulantahun"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Visible = False
        Column7.Width = 150
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Total Keseluruhan"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 170
        ' 
        ' kolProduk
        ' 
        kolProduk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle2.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        kolProduk.DefaultCellStyle = DataGridViewCellStyle2
        kolProduk.FlatStyle = FlatStyle.Flat
        kolProduk.HeaderText = "Lihat Produk"
        kolProduk.MinimumWidth = 8
        kolProduk.Name = "kolProduk"
        kolProduk.ReadOnly = True
        kolProduk.Text = "DETAIL"
        kolProduk.UseColumnTextForButtonValue = True
        kolProduk.Width = 105
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1104, 606)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormLaporan"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents ButtonFilter As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Labelcari As Label
    Friend WithEvents RadioButtonBulanIni As RadioButton
    Friend WithEvents RadioButtonHariIni As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents kolProduk As DataGridViewButtonColumn
End Class
