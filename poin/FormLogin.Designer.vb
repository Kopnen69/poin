<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        ButtonLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        ButtonExit = New Guna.UI2.WinForms.Guna2GradientButton()
        LabelLogin = New Label()
        PictureBoxLogin = New PictureBox()
        TextBoxPass = New Guna.UI2.WinForms.Guna2TextBox()
        TextBoxUser = New Guna.UI2.WinForms.Guna2TextBox()
        btnShowHidePassword = New Guna.UI2.WinForms.Guna2ImageButton()
        CType(PictureBoxLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.AutoRoundedCorners = True
        ButtonLogin.BackColor = Color.Transparent
        ButtonLogin.BorderRadius = 23
        ButtonLogin.CustomizableEdges = CustomizableEdges1
        ButtonLogin.DisabledState.BorderColor = Color.DarkGray
        ButtonLogin.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonLogin.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonLogin.FillColor2 = Color.Lime
        ButtonLogin.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.Location = New Point(115, 347)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ButtonLogin.Size = New Size(186, 49)
        ButtonLogin.TabIndex = 2
        ButtonLogin.Text = "Login"
        ' 
        ' ButtonExit
        ' 
        ButtonExit.AutoRoundedCorners = True
        ButtonExit.BackColor = Color.Transparent
        ButtonExit.BorderRadius = 23
        ButtonExit.CustomizableEdges = CustomizableEdges3
        ButtonExit.DisabledState.BorderColor = Color.DarkGray
        ButtonExit.DisabledState.CustomBorderColor = Color.DarkGray
        ButtonExit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonExit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        ButtonExit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        ButtonExit.FillColor = Color.OrangeRed
        ButtonExit.FillColor2 = Color.Firebrick
        ButtonExit.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonExit.ForeColor = Color.White
        ButtonExit.Location = New Point(115, 415)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ButtonExit.Size = New Size(186, 49)
        ButtonExit.TabIndex = 3
        ButtonExit.Text = "Exit"
        ' 
        ' LabelLogin
        ' 
        LabelLogin.AutoSize = True
        LabelLogin.BackColor = Color.Transparent
        LabelLogin.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        LabelLogin.Location = New Point(175, 49)
        LabelLogin.Name = "LabelLogin"
        LabelLogin.Size = New Size(63, 24)
        LabelLogin.TabIndex = 4
        LabelLogin.Text = "Login"
        ' 
        ' PictureBoxLogin
        ' 
        PictureBoxLogin.BackColor = Color.Transparent
        PictureBoxLogin.Image = CType(resources.GetObject("PictureBoxLogin.Image"), Image)
        PictureBoxLogin.Location = New Point(129, 76)
        PictureBoxLogin.Name = "PictureBoxLogin"
        PictureBoxLogin.Size = New Size(160, 145)
        PictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogin.TabIndex = 5
        PictureBoxLogin.TabStop = False
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.CustomizableEdges = CustomizableEdges5
        TextBoxPass.DefaultText = ""
        TextBoxPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBoxPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBoxPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBoxPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBoxPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBoxPass.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBoxPass.Location = New Point(84, 287)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.PasswordChar = ChrW(0)
        TextBoxPass.PlaceholderText = "Password"
        TextBoxPass.SelectedText = ""
        TextBoxPass.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        TextBoxPass.Size = New Size(251, 40)
        TextBoxPass.TabIndex = 6
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.CustomizableEdges = CustomizableEdges7
        TextBoxUser.DefaultText = ""
        TextBoxUser.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBoxUser.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBoxUser.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBoxUser.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBoxUser.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBoxUser.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxUser.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBoxUser.Location = New Point(84, 227)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.PasswordChar = ChrW(0)
        TextBoxUser.PlaceholderText = "Username"
        TextBoxUser.SelectedText = ""
        TextBoxUser.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        TextBoxUser.Size = New Size(251, 39)
        TextBoxUser.TabIndex = 7
        ' 
        ' btnShowHidePassword
        ' 
        btnShowHidePassword.BackColor = Color.Transparent
        btnShowHidePassword.CheckedState.ImageSize = New Size(64, 64)
        btnShowHidePassword.HoverState.ImageSize = New Size(64, 64)
        btnShowHidePassword.Image = CType(resources.GetObject("btnShowHidePassword.Image"), Image)
        btnShowHidePassword.ImageOffset = New Point(0, 0)
        btnShowHidePassword.ImageRotate = 0F
        btnShowHidePassword.ImageSize = New Size(32, 32)
        btnShowHidePassword.Location = New Point(274, 287)
        btnShowHidePassword.Name = "btnShowHidePassword"
        btnShowHidePassword.PressedState.ImageSize = New Size(64, 64)
        btnShowHidePassword.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        btnShowHidePassword.Size = New Size(61, 40)
        btnShowHidePassword.TabIndex = 8
        btnShowHidePassword.UseTransparentBackground = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(422, 560)
        Controls.Add(btnShowHidePassword)
        Controls.Add(TextBoxUser)
        Controls.Add(TextBoxPass)
        Controls.Add(PictureBoxLogin)
        Controls.Add(LabelLogin)
        Controls.Add(ButtonExit)
        Controls.Add(ButtonLogin)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        CType(PictureBoxLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonExit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LabelLogin As Label
    Friend WithEvents PictureBoxLogin As PictureBox
    Friend WithEvents TextBoxPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnShowHidePassword As Guna.UI2.WinForms.Guna2ImageButton
End Class
