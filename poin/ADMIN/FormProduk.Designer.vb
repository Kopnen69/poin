<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormProduk))
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewImageColumn()
        Panel2 = New Panel()
        Label11 = New Label()
        Text_Cari = New TextBox()
        TabPage2 = New TabPage()
        ButtonClear = New Guna.UI2.WinForms.Guna2GradientButton()
        ButtonHapus = New Guna.UI2.WinForms.Guna2GradientButton()
        ButtonEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        ButtonSimpan = New Guna.UI2.WinForms.Guna2GradientButton()
        Combo_Jenis = New ComboBox()
        ButtonTambah = New Button()
        Combo_Pajak = New Guna.UI2.WinForms.Guna2ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ButtonCari = New Button()
        PictureBarcode = New PictureBox()
        Text_Total = New TextBox()
        Text_Harga = New TextBox()
        Text_Lokasi = New TextBox()
        Text_CariKode = New TextBox()
        Combo_Satuan = New Guna.UI2.WinForms.Guna2ComboBox()
        Text_NamaProduk = New TextBox()
        Text_Kode = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(PictureBarcode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = SystemColors.ButtonHighlight
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1158, 58)
        Panel1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(0, 56)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1158, 542)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Orange
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage1.ForeColor = SystemColors.ActiveCaptionText
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.RightToLeft = RightToLeft.No
        TabPage1.Size = New Size(1150, 508)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DAFTAR PRODUK"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 50)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1144, 455)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 57
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "KODE PRODUK"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 178
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "NAMA PRODUK"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "JENIS"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 102
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "SATUAN"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "LOKASI"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 119
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "HARGA"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 116
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "PAJAK%"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 126
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "TOTAL HARGA"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 172
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "STOK"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Visible = False
        Column10.Width = 150
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "BARCODE"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Resizable = DataGridViewTriState.True
        Column11.SortMode = DataGridViewColumnSortMode.Automatic
        Column11.Visible = False
        Column11.Width = 150
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Text_Cari)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1144, 47)
        Panel2.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(5, 11)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 24)
        Label11.TabIndex = 13
        Label11.Text = "Cari Produk"
        ' 
        ' Text_Cari
        ' 
        Text_Cari.Location = New Point(141, 8)
        Text_Cari.Name = "Text_Cari"
        Text_Cari.PlaceholderText = "cari...."
        Text_Cari.Size = New Size(287, 30)
        Text_Cari.TabIndex = 12
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Orange
        TabPage2.Controls.Add(ButtonClear)
        TabPage2.Controls.Add(ButtonHapus)
        TabPage2.Controls.Add(ButtonEdit)
        TabPage2.Controls.Add(ButtonSimpan)
        TabPage2.Controls.Add(Combo_Jenis)
        TabPage2.Controls.Add(ButtonTambah)
        TabPage2.Controls.Add(Combo_Pajak)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(ButtonCari)
        TabPage2.Controls.Add(PictureBarcode)
        TabPage2.Controls.Add(Text_Total)
        TabPage2.Controls.Add(Text_Harga)
        TabPage2.Controls.Add(Text_Lokasi)
        TabPage2.Controls.Add(Text_CariKode)
        TabPage2.Controls.Add(Combo_Satuan)
        TabPage2.Controls.Add(Text_NamaProduk)
        TabPage2.Controls.Add(Text_Kode)
        TabPage2.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1150, 508)
        TabPage2.TabIndex = 1
        TabPage2.Text = "KELOLA PRODUK"
        ' 
        ' ButtonClear
        ' 
        ButtonClear.CustomizableEdges = CustomizableEdges1
        ButtonClear.DisabledState.BorderColor = Color.DarkGray
        ButtonClear.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonClear.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonClear.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonClear.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonClear.FillColor = Color.DimGray
        ButtonClear.FillColor2 = Color.DarkSlateGray
        ButtonClear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonClear.ForeColor = Color.White
        ButtonClear.Location = New Point(784, 433)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ButtonClear.Size = New Size(171, 39)
        ButtonClear.TabIndex = 31
        ButtonClear.Text = "CLEAR"
        ' 
        ' ButtonHapus
        ' 
        ButtonHapus.CustomizableEdges = CustomizableEdges3
        ButtonHapus.DisabledState.BorderColor = Color.DarkGray
        ButtonHapus.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonHapus.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonHapus.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonHapus.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonHapus.FillColor = Color.DarkSlateGray
        ButtonHapus.FillColor2 = Color.DimGray
        ButtonHapus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonHapus.ForeColor = Color.White
        ButtonHapus.Location = New Point(590, 433)
        ButtonHapus.Name = "ButtonHapus"
        ButtonHapus.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ButtonHapus.Size = New Size(171, 39)
        ButtonHapus.TabIndex = 30
        ButtonHapus.Text = "HAPUS"
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.CustomizableEdges = CustomizableEdges5
        ButtonEdit.DisabledState.BorderColor = Color.DarkGray
        ButtonEdit.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonEdit.FillColor = Color.DimGray
        ButtonEdit.FillColor2 = Color.DarkSlateGray
        ButtonEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonEdit.ForeColor = Color.White
        ButtonEdit.Location = New Point(396, 433)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        ButtonEdit.Size = New Size(171, 39)
        ButtonEdit.TabIndex = 29
        ButtonEdit.Text = "EDIT"
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.CustomizableEdges = CustomizableEdges7
        ButtonSimpan.DisabledState.BorderColor = Color.DarkGray
        ButtonSimpan.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonSimpan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonSimpan.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonSimpan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonSimpan.FillColor = Color.DarkSlateGray
        ButtonSimpan.FillColor2 = Color.DimGray
        ButtonSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSimpan.ForeColor = Color.White
        ButtonSimpan.Location = New Point(202, 433)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        ButtonSimpan.Size = New Size(171, 39)
        ButtonSimpan.TabIndex = 28
        ButtonSimpan.Text = "SIMPAN"
        ' 
        ' Combo_Jenis
        ' 
        Combo_Jenis.FormattingEnabled = True
        Combo_Jenis.Location = New Point(202, 214)
        Combo_Jenis.Name = "Combo_Jenis"
        Combo_Jenis.Size = New Size(221, 32)
        Combo_Jenis.TabIndex = 27
        ' 
        ' ButtonTambah
        ' 
        ButtonTambah.Location = New Point(432, 214)
        ButtonTambah.Name = "ButtonTambah"
        ButtonTambah.Size = New Size(39, 34)
        ButtonTambah.TabIndex = 26
        ButtonTambah.Text = "+"
        ButtonTambah.UseVisualStyleBackColor = True
        ' 
        ' Combo_Pajak
        ' 
        Combo_Pajak.BackColor = Color.Transparent
        Combo_Pajak.CustomizableEdges = CustomizableEdges9
        Combo_Pajak.DrawMode = DrawMode.OwnerDrawFixed
        Combo_Pajak.DropDownStyle = ComboBoxStyle.DropDownList
        Combo_Pajak.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Combo_Pajak.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Combo_Pajak.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Combo_Pajak.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        Combo_Pajak.ItemHeight = 30
        Combo_Pajak.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30"})
        Combo_Pajak.Location = New Point(706, 89)
        Combo_Pajak.Name = "Combo_Pajak"
        Combo_Pajak.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Combo_Pajak.Size = New Size(249, 36)
        Combo_Pajak.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(614, 214)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 24)
        Label10.TabIndex = 20
        Label10.Text = "Barcode"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(614, 155)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 24)
        Label9.TabIndex = 19
        Label9.Text = "Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(614, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 24)
        Label8.TabIndex = 18
        Label8.Text = "Pajak"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(614, 38)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 24)
        Label7.TabIndex = 17
        Label7.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(103, 329)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 48)
        Label6.TabIndex = 16
        Label6.Text = "Lokasi" & vbCrLf & "Produk"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(103, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 24)
        Label5.TabIndex = 15
        Label5.Text = "Satuan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(103, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 24)
        Label4.TabIndex = 14
        Label4.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(100, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 24)
        Label3.TabIndex = 13
        Label3.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(100, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 24)
        Label2.TabIndex = 12
        Label2.Text = "Kode"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(100, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 24)
        Label1.TabIndex = 11
        Label1.Text = "Cari"
        ' 
        ' ButtonCari
        ' 
        ButtonCari.Location = New Point(445, 32)
        ButtonCari.Name = "ButtonCari"
        ButtonCari.Size = New Size(112, 34)
        ButtonCari.TabIndex = 10
        ButtonCari.Text = "Cari"
        ButtonCari.UseVisualStyleBackColor = True
        ' 
        ' PictureBarcode
        ' 
        PictureBarcode.BackColor = Color.White
        PictureBarcode.Location = New Point(614, 245)
        PictureBarcode.Name = "PictureBarcode"
        PictureBarcode.Size = New Size(341, 132)
        PictureBarcode.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBarcode.TabIndex = 9
        PictureBarcode.TabStop = False
        ' 
        ' Text_Total
        ' 
        Text_Total.Location = New Point(706, 149)
        Text_Total.Name = "Text_Total"
        Text_Total.Size = New Size(249, 30)
        Text_Total.TabIndex = 8
        ' 
        ' Text_Harga
        ' 
        Text_Harga.Location = New Point(706, 38)
        Text_Harga.Name = "Text_Harga"
        Text_Harga.Size = New Size(249, 30)
        Text_Harga.TabIndex = 7
        ' 
        ' Text_Lokasi
        ' 
        Text_Lokasi.Location = New Point(202, 347)
        Text_Lokasi.Name = "Text_Lokasi"
        Text_Lokasi.Size = New Size(221, 30)
        Text_Lokasi.TabIndex = 6
        ' 
        ' Text_CariKode
        ' 
        Text_CariKode.Location = New Point(202, 32)
        Text_CariKode.Name = "Text_CariKode"
        Text_CariKode.Size = New Size(221, 30)
        Text_CariKode.TabIndex = 5
        ' 
        ' Combo_Satuan
        ' 
        Combo_Satuan.BackColor = Color.Transparent
        Combo_Satuan.CustomizableEdges = CustomizableEdges11
        Combo_Satuan.DrawMode = DrawMode.OwnerDrawFixed
        Combo_Satuan.DropDownStyle = ComboBoxStyle.DropDownList
        Combo_Satuan.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Combo_Satuan.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Combo_Satuan.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Combo_Satuan.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        Combo_Satuan.ItemHeight = 30
        Combo_Satuan.Items.AddRange(New Object() {"Buah ", "Kg", "M", "L", "g"})
        Combo_Satuan.Location = New Point(202, 279)
        Combo_Satuan.Name = "Combo_Satuan"
        Combo_Satuan.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Combo_Satuan.Size = New Size(221, 36)
        Combo_Satuan.TabIndex = 3
        ' 
        ' Text_NamaProduk
        ' 
        Text_NamaProduk.Location = New Point(202, 149)
        Text_NamaProduk.Name = "Text_NamaProduk"
        Text_NamaProduk.Size = New Size(221, 30)
        Text_NamaProduk.TabIndex = 1
        ' 
        ' Text_Kode
        ' 
        Text_Kode.Location = New Point(202, 89)
        Text_Kode.Name = "Text_Kode"
        Text_Kode.Size = New Size(221, 30)
        Text_Kode.TabIndex = 0
        ' 
        ' FormProduk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 597)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FormProduk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormProduk"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBarcode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCari As Button
    Friend WithEvents PictureBarcode As PictureBox
    Friend WithEvents Text_Total As TextBox
    Friend WithEvents Text_Harga As TextBox
    Friend WithEvents Text_Lokasi As TextBox
    Friend WithEvents Text_CariKode As TextBox
    Friend WithEvents Combo_Satuan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Text_NamaProduk As TextBox
    Friend WithEvents Text_Kode As TextBox
    Friend WithEvents Combo_Pajak As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Text_Cari As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Combo_Jenis As ComboBox
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonHapus As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonSimpan As Guna.UI2.WinForms.Guna2GradientButton
End Class
