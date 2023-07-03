<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBatalPesan
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
        Panel1 = New Panel()
        LabelCari = New Label()
        TextCari = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        kolHapus = New DataGridViewButtonColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(LabelCari)
        Panel1.Controls.Add(TextCari)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1160, 92)
        Panel1.TabIndex = 0
        ' 
        ' LabelCari
        ' 
        LabelCari.AutoSize = True
        LabelCari.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCari.Location = New Point(25, 30)
        LabelCari.Name = "LabelCari"
        LabelCari.Size = New Size(59, 29)
        LabelCari.TabIndex = 1
        LabelCari.Text = "Cari"
        ' 
        ' TextCari
        ' 
        TextCari.Location = New Point(90, 28)
        TextCari.Name = "TextCari"
        TextCari.Size = New Size(329, 31)
        TextCari.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, kolHapus})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 92)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1160, 323)
        DataGridView1.TabIndex = 1
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
        Column2.HeaderText = "Nomor Tagihan"
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
        Column3.HeaderText = "Tanggal Tagihan"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 160
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Total Harga"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 127
        ' 
        ' kolHapus
        ' 
        kolHapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Red
        DataGridViewCellStyle2.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = Color.Red
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        kolHapus.DefaultCellStyle = DataGridViewCellStyle2
        kolHapus.FlatStyle = FlatStyle.Flat
        kolHapus.HeaderText = "Delete"
        kolHapus.MinimumWidth = 8
        kolHapus.Name = "kolHapus"
        kolHapus.ReadOnly = True
        kolHapus.Resizable = DataGridViewTriState.True
        kolHapus.Text = "HAPUS"
        kolHapus.UseColumnTextForButtonValue = True
        kolHapus.Width = 68
        ' 
        ' FormBatalPesan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 415)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormBatalPesan"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelCari As Label
    Friend WithEvents TextCari As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents kolHapus As DataGridViewButtonColumn
End Class
