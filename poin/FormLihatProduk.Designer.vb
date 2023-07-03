<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLihatProduk
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
        Panel1 = New Panel()
        Label1 = New Label()
        Column11 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.ForeColor = Color.Orange
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1062, 74)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 43)
        Label1.TabIndex = 0
        Label1.Text = "daftar barang"
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "carapembayaran"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 179
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "totalhargaqty"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 155
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "qty"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 74
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "totalhargaproduk"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 187
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "pajak"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 90
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "harga"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 93
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "satuan"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "jenisproduk"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 141
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "namaproduk"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "kodeproduk"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 146
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "notagihan"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 74)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1062, 220)
        DataGridView1.TabIndex = 1
        ' 
        ' FormLihatProduk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 294)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormLihatProduk"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
