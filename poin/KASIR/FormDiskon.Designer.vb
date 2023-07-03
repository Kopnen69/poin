<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiskon
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
        TextDiskon = New TextBox()
        ButtonUpdateDiskon = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TextDiskon
        ' 
        TextDiskon.Location = New Point(41, 91)
        TextDiskon.Name = "TextDiskon"
        TextDiskon.Size = New Size(288, 31)
        TextDiskon.TabIndex = 0
        ' 
        ' ButtonUpdateDiskon
        ' 
        ButtonUpdateDiskon.FlatStyle = FlatStyle.Flat
        ButtonUpdateDiskon.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonUpdateDiskon.Location = New Point(41, 171)
        ButtonUpdateDiskon.Name = "ButtonUpdateDiskon"
        ButtonUpdateDiskon.Size = New Size(288, 34)
        ButtonUpdateDiskon.TabIndex = 1
        ButtonUpdateDiskon.Text = "PERBARUI DISKON"
        ButtonUpdateDiskon.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(41, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 24)
        Label1.TabIndex = 2
        Label1.Text = "Masukkan Diskon"
        ' 
        ' FormDiskon
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Orange
        ClientSize = New Size(370, 262)
        Controls.Add(Label1)
        Controls.Add(ButtonUpdateDiskon)
        Controls.Add(TextDiskon)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormDiskon"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextDiskon As TextBox
    Friend WithEvents ButtonUpdateDiskon As Button
    Friend WithEvents Label1 As Label
End Class
