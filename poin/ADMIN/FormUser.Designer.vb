<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TextBoxNama = New TextBox()
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        ComboBoxTugas = New Guna.UI2.WinForms.Guna2ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ButtonDaftar = New Guna.UI2.WinForms.Guna2GradientButton()
        ButtonBatal = New Guna.UI2.WinForms.Guna2GradientButton()
        SuspendLayout()
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(35, 48)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.PlaceholderText = "nama"
        TextBoxNama.Size = New Size(370, 31)
        TextBoxNama.TabIndex = 0
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(35, 124)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "username"
        TextBoxUsername.Size = New Size(370, 31)
        TextBoxUsername.TabIndex = 1
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(35, 197)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PlaceholderText = "password"
        TextBoxPassword.Size = New Size(370, 31)
        TextBoxPassword.TabIndex = 2
        ' 
        ' ComboBoxTugas
        ' 
        ComboBoxTugas.BackColor = Color.Transparent
        ComboBoxTugas.CustomizableEdges = CustomizableEdges1
        ComboBoxTugas.DrawMode = DrawMode.OwnerDrawFixed
        ComboBoxTugas.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxTugas.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ComboBoxTugas.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ComboBoxTugas.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxTugas.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        ComboBoxTugas.ItemHeight = 30
        ComboBoxTugas.Items.AddRange(New Object() {"Admin", "Kasir"})
        ComboBoxTugas.Location = New Point(35, 273)
        ComboBoxTugas.Name = "ComboBoxTugas"
        ComboBoxTugas.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ComboBoxTugas.Size = New Size(293, 36)
        ComboBoxTugas.TabIndex = 3
        ComboBoxTugas.Tag = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(35, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 24)
        Label1.TabIndex = 6
        Label1.Text = "Nama" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(35, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 24)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(35, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 24)
        Label3.TabIndex = 8
        Label3.Text = "Masukkan Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(35, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 24)
        Label4.TabIndex = 9
        Label4.Text = "Tugas"
        ' 
        ' ButtonDaftar
        ' 
        ButtonDaftar.CustomizableEdges = CustomizableEdges3
        ButtonDaftar.DisabledState.BorderColor = Color.DarkGray
        ButtonDaftar.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonDaftar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonDaftar.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonDaftar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonDaftar.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonDaftar.FillColor2 = Color.DarkGray
        ButtonDaftar.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonDaftar.ForeColor = Color.Black
        ButtonDaftar.Location = New Point(35, 369)
        ButtonDaftar.Name = "ButtonDaftar"
        ButtonDaftar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ButtonDaftar.Size = New Size(133, 44)
        ButtonDaftar.TabIndex = 10
        ButtonDaftar.Text = "Registrasi"
        ' 
        ' ButtonBatal
        ' 
        ButtonBatal.CustomizableEdges = CustomizableEdges5
        ButtonBatal.DisabledState.BorderColor = Color.DarkGray
        ButtonBatal.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonBatal.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonBatal.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonBatal.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonBatal.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonBatal.FillColor2 = Color.DarkGray
        ButtonBatal.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonBatal.ForeColor = Color.Black
        ButtonBatal.Location = New Point(195, 369)
        ButtonBatal.Name = "ButtonBatal"
        ButtonBatal.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        ButtonBatal.Size = New Size(133, 44)
        ButtonBatal.TabIndex = 11
        ButtonBatal.Text = "Batal"
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Orange
        ClientSize = New Size(463, 450)
        Controls.Add(ButtonBatal)
        Controls.Add(ButtonDaftar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBoxTugas)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(TextBoxNama)
        Name = "FormUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ComboBoxTugas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDaftar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonBatal As Guna.UI2.WinForms.Guna2GradientButton
End Class
