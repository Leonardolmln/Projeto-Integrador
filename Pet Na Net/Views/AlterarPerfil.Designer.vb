<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarPerfil
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FuncionarioLB = New System.Windows.Forms.Label()
        Me.AlterarPerfilBT = New System.Windows.Forms.Button()
        Me.PerfilCB = New System.Windows.Forms.ComboBox()
        Me.CPFLB = New System.Windows.Forms.Label()
        Me.MatriculaMTF = New System.Windows.Forms.MaskedTextBox()
        Me.MatriculaRB = New System.Windows.Forms.RadioButton()
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.NomeRB = New System.Windows.Forms.RadioButton()
        Me.CPFRB = New System.Windows.Forms.RadioButton()
        Me.CadastrarClienteBT = New System.Windows.Forms.Button()
        Me.NomeTF = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FuncionarioLB)
        Me.Panel1.Controls.Add(Me.AlterarPerfilBT)
        Me.Panel1.Controls.Add(Me.PerfilCB)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Controls.Add(Me.MatriculaMTF)
        Me.Panel1.Controls.Add(Me.MatriculaRB)
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.NomeRB)
        Me.Panel1.Controls.Add(Me.CPFRB)
        Me.Panel1.Controls.Add(Me.CadastrarClienteBT)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Location = New System.Drawing.Point(12, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 275)
        Me.Panel1.TabIndex = 11
        '
        'FuncionarioLB
        '
        Me.FuncionarioLB.AutoSize = True
        Me.FuncionarioLB.Location = New System.Drawing.Point(18, 160)
        Me.FuncionarioLB.Name = "FuncionarioLB"
        Me.FuncionarioLB.Size = New System.Drawing.Size(62, 13)
        Me.FuncionarioLB.TabIndex = 35
        Me.FuncionarioLB.Text = "Funcionário"
        '
        'AlterarPerfilBT
        '
        Me.AlterarPerfilBT.Location = New System.Drawing.Point(128, 236)
        Me.AlterarPerfilBT.Name = "AlterarPerfilBT"
        Me.AlterarPerfilBT.Size = New System.Drawing.Size(113, 23)
        Me.AlterarPerfilBT.TabIndex = 34
        Me.AlterarPerfilBT.Text = "Alterar Perfil"
        Me.AlterarPerfilBT.UseVisualStyleBackColor = True
        '
        'PerfilCB
        '
        Me.PerfilCB.FormattingEnabled = True
        Me.PerfilCB.Location = New System.Drawing.Point(186, 192)
        Me.PerfilCB.Name = "PerfilCB"
        Me.PerfilCB.Size = New System.Drawing.Size(150, 21)
        Me.PerfilCB.TabIndex = 33
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(18, 195)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(33, 13)
        Me.CPFLB.TabIndex = 32
        Me.CPFLB.Text = "Perfil:"
        '
        'MatriculaMTF
        '
        Me.MatriculaMTF.Location = New System.Drawing.Point(254, 13)
        Me.MatriculaMTF.Mask = "000000"
        Me.MatriculaMTF.Name = "MatriculaMTF"
        Me.MatriculaMTF.Size = New System.Drawing.Size(82, 20)
        Me.MatriculaMTF.TabIndex = 7
        '
        'MatriculaRB
        '
        Me.MatriculaRB.AutoSize = True
        Me.MatriculaRB.Checked = True
        Me.MatriculaRB.Location = New System.Drawing.Point(18, 16)
        Me.MatriculaRB.Name = "MatriculaRB"
        Me.MatriculaRB.Size = New System.Drawing.Size(120, 17)
        Me.MatriculaRB.TabIndex = 6
        Me.MatriculaRB.TabStop = True
        Me.MatriculaRB.Text = "Busca Por Matricula"
        Me.MatriculaRB.UseVisualStyleBackColor = True
        '
        'CPFMTF
        '
        Me.CPFMTF.Enabled = False
        Me.CPFMTF.Location = New System.Drawing.Point(254, 43)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 2
        '
        'NomeRB
        '
        Me.NomeRB.AutoSize = True
        Me.NomeRB.Location = New System.Drawing.Point(18, 76)
        Me.NomeRB.Name = "NomeRB"
        Me.NomeRB.Size = New System.Drawing.Size(105, 17)
        Me.NomeRB.TabIndex = 3
        Me.NomeRB.Text = "Busca Por Nome"
        Me.NomeRB.UseVisualStyleBackColor = True
        '
        'CPFRB
        '
        Me.CPFRB.AutoSize = True
        Me.CPFRB.Location = New System.Drawing.Point(18, 46)
        Me.CPFRB.Name = "CPFRB"
        Me.CPFRB.Size = New System.Drawing.Size(97, 17)
        Me.CPFRB.TabIndex = 1
        Me.CPFRB.Text = "Busca Por CPF"
        Me.CPFRB.UseVisualStyleBackColor = True
        '
        'CadastrarClienteBT
        '
        Me.CadastrarClienteBT.Location = New System.Drawing.Point(128, 114)
        Me.CadastrarClienteBT.Name = "CadastrarClienteBT"
        Me.CadastrarClienteBT.Size = New System.Drawing.Size(113, 23)
        Me.CadastrarClienteBT.TabIndex = 5
        Me.CadastrarClienteBT.Text = "Buscar Cadastro"
        Me.CadastrarClienteBT.UseVisualStyleBackColor = True
        '
        'NomeTF
        '
        Me.NomeTF.Enabled = False
        Me.NomeTF.Location = New System.Drawing.Point(137, 73)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(199, 20)
        Me.NomeTF.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 71)
        Me.Panel2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Alterar Perfil"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.AlterarPerfil
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'AlterarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 369)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AlterarPerfil"
        Me.Text = "AlterarPerfil"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NomeRB As System.Windows.Forms.RadioButton
    Friend WithEvents CPFRB As System.Windows.Forms.RadioButton
    Friend WithEvents CadastrarClienteBT As System.Windows.Forms.Button
    Friend WithEvents NomeTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MatriculaMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MatriculaRB As System.Windows.Forms.RadioButton
    Friend WithEvents AlterarPerfilBT As System.Windows.Forms.Button
    Friend WithEvents PerfilCB As System.Windows.Forms.ComboBox
    Friend WithEvents CPFLB As System.Windows.Forms.Label
    Friend WithEvents FuncionarioLB As System.Windows.Forms.Label
End Class
