<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenis
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Text_Jenis = New TextBox()
        Label1 = New Label()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        ButtonSimpan = New Guna.UI2.WinForms.Guna2GradientButton()
        ButtonCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        SuspendLayout()
        ' 
        ' Text_Jenis
        ' 
        Text_Jenis.Location = New Point(12, 71)
        Text_Jenis.Name = "Text_Jenis"
        Text_Jenis.Size = New Size(419, 31)
        Text_Jenis.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 26)
        Label1.TabIndex = 2
        Label1.Text = "Tambahkan Jenis Produk"
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.BackColor = Color.Transparent
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(391, 3)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox1.Size = New Size(68, 44)
        Guna2ControlBox1.TabIndex = 4
        Guna2ControlBox1.UseTransparentBackground = True
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.CustomizableEdges = CustomizableEdges3
        ButtonSimpan.DisabledState.BorderColor = Color.DarkGray
        ButtonSimpan.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonSimpan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonSimpan.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonSimpan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonSimpan.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonSimpan.FillColor2 = Color.LightGray
        ButtonSimpan.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonSimpan.ForeColor = Color.Black
        ButtonSimpan.Location = New Point(12, 122)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ButtonSimpan.Size = New Size(133, 44)
        ButtonSimpan.TabIndex = 5
        ButtonSimpan.Text = "SIMPAN"
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.CustomizableEdges = CustomizableEdges1
        ButtonCancel.DisabledState.BorderColor = Color.DarkGray
        ButtonCancel.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonCancel.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonCancel.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonCancel.FillColor2 = Color.LightGray
        ButtonCancel.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonCancel.ForeColor = Color.Black
        ButtonCancel.Location = New Point(167, 122)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ButtonCancel.Size = New Size(133, 44)
        ButtonCancel.TabIndex = 6
        ButtonCancel.Text = "BATAL"
        ' 
        ' FormJenis
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Black
        ClientSize = New Size(471, 188)
        Controls.Add(ButtonCancel)
        Controls.Add(ButtonSimpan)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Label1)
        Controls.Add(Text_Jenis)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "FormJenis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormJenis"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Text_Jenis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonSimpan As Guna.UI2.WinForms.Guna2GradientButton
End Class
