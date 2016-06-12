<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginUsuario
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTF As System.Windows.Forms.TextBox
    Friend WithEvents LoginBT As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTF = New System.Windows.Forms.TextBox()
        Me.LoginBT = New System.Windows.Forms.Button()
        Me.ConfirmPasswordTF = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordLB = New System.Windows.Forms.Label()
        Me.RegistroLink = New System.Windows.Forms.LinkLabel()
        Me.UserTF = New System.Windows.Forms.MaskedTextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Pet_Na_Net.My.Resources.Resources.Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 2)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Matricula"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 51)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTF
        '
        Me.PasswordTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTF.Location = New System.Drawing.Point(174, 75)
        Me.PasswordTF.Name = "PasswordTF"
        Me.PasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTF.Size = New System.Drawing.Size(220, 21)
        Me.PasswordTF.TabIndex = 2
        '
        'LoginBT
        '
        Me.LoginBT.Location = New System.Drawing.Point(186, 161)
        Me.LoginBT.Name = "LoginBT"
        Me.LoginBT.Size = New System.Drawing.Size(94, 23)
        Me.LoginBT.TabIndex = 4
        Me.LoginBT.Text = "Login"
        '
        'ConfirmPasswordTF
        '
        Me.ConfirmPasswordTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordTF.Location = New System.Drawing.Point(174, 124)
        Me.ConfirmPasswordTF.Name = "ConfirmPasswordTF"
        Me.ConfirmPasswordTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTF.Size = New System.Drawing.Size(220, 21)
        Me.ConfirmPasswordTF.TabIndex = 3
        Me.ConfirmPasswordTF.Visible = False
        '
        'ConfirmPasswordLB
        '
        Me.ConfirmPasswordLB.Location = New System.Drawing.Point(173, 100)
        Me.ConfirmPasswordLB.Name = "ConfirmPasswordLB"
        Me.ConfirmPasswordLB.Size = New System.Drawing.Size(220, 23)
        Me.ConfirmPasswordLB.TabIndex = 6
        Me.ConfirmPasswordLB.Text = "Confirmar Senha"
        Me.ConfirmPasswordLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfirmPasswordLB.Visible = False
        '
        'RegistroLink
        '
        Me.RegistroLink.AutoSize = True
        Me.RegistroLink.Location = New System.Drawing.Point(315, 166)
        Me.RegistroLink.Name = "RegistroLink"
        Me.RegistroLink.Size = New System.Drawing.Size(63, 13)
        Me.RegistroLink.TabIndex = 5
        Me.RegistroLink.TabStop = True
        Me.RegistroLink.Text = "Registrar-se"
        '
        'UserTF
        '
        Me.UserTF.Location = New System.Drawing.Point(174, 28)
        Me.UserTF.Mask = "000000"
        Me.UserTF.Name = "UserTF"
        Me.UserTF.Size = New System.Drawing.Size(220, 20)
        Me.UserTF.TabIndex = 1
        '
        'LoginUsuario
        '
        Me.AcceptButton = Me.LoginBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 194)
        Me.Controls.Add(Me.UserTF)
        Me.Controls.Add(Me.RegistroLink)
        Me.Controls.Add(Me.ConfirmPasswordTF)
        Me.Controls.Add(Me.ConfirmPasswordLB)
        Me.Controls.Add(Me.LoginBT)
        Me.Controls.Add(Me.PasswordTF)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginUsuario"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmPasswordTF As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPasswordLB As System.Windows.Forms.Label
    Friend WithEvents RegistroLink As System.Windows.Forms.LinkLabel
    Friend WithEvents UserTF As System.Windows.Forms.MaskedTextBox

End Class
