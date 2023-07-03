<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStok
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Panel2 = New Panel()
        ButtonUpdateStok = New Button()
        Label11 = New Label()
        Text_Cari = New TextBox()
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
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Guna2GradientButton2)
        Panel1.Controls.Add(Guna2GradientButton1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1243, 49)
        Panel1.TabIndex = 0
        ' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges1
        Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton2.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Guna2GradientButton2.FillColor2 = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Guna2GradientButton2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton2.ForeColor = Color.White
        Guna2GradientButton2.Location = New Point(89, 28)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientButton2.Size = New Size(630, 10)
        Guna2GradientButton2.TabIndex = 2
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Guna2GradientButton1.FillColor2 = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(37, 12)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton1.Size = New Size(615, 10)
        Guna2GradientButton1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(ButtonUpdateStok)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Text_Cari)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 49)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1243, 54)
        Panel2.TabIndex = 1
        ' 
        ' ButtonUpdateStok
        ' 
        ButtonUpdateStok.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonUpdateStok.BackColor = Color.Orange
        ButtonUpdateStok.FlatStyle = FlatStyle.Flat
        ButtonUpdateStok.Location = New Point(1026, 9)
        ButtonUpdateStok.Name = "ButtonUpdateStok"
        ButtonUpdateStok.Size = New Size(205, 34)
        ButtonUpdateStok.TabIndex = 16
        ButtonUpdateStok.Text = "Update Stok"
        ButtonUpdateStok.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(12, 14)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 24)
        Label11.TabIndex = 15
        Label11.Text = "Cari Produk"
        ' 
        ' Text_Cari
        ' 
        Text_Cari.Location = New Point(148, 11)
        Text_Cari.Name = "Text_Cari"
        Text_Cari.Size = New Size(351, 31)
        Text_Cari.TabIndex = 14
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
        DataGridView1.Location = New Point(0, 103)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1243, 526)
        DataGridView1.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 57
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "KODE PRODUK"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 178
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "NAMA PRODUK"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 177
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "JENIS"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 102
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "SATUAN"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "LOKASI"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 119
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "HARGA"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 116
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "PAJAK%"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.Width = 126
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "TOTAL HARGA"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.Width = 172
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "STOK"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.Width = 102
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "BARCODE"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.Resizable = DataGridViewTriState.True
        Column11.SortMode = DataGridViewColumnSortMode.Automatic
        Column11.Visible = False
        Column11.Width = 150
        ' 
        ' FormStok
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 629)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormStok"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormStok"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Text_Cari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonUpdateStok As Button
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
End Class
