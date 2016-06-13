<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroFuncionario
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
        Me.ValidadeMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CRMVTF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SalarioTF = New System.Windows.Forms.TextBox()
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomeTF = New System.Windows.Forms.TextBox()
        Me.PerfilCB = New System.Windows.Forms.ComboBox()
        Me.MatriculaMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CadastrarFuncionarioBT = New System.Windows.Forms.Button()
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.CPFLB = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ValidadeMTF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CRMVTF)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.SalarioTF)
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Controls.Add(Me.PerfilCB)
        Me.Panel1.Controls.Add(Me.MatriculaMTF)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.CadastrarFuncionarioBT)
        Me.Panel1.Controls.Add(Me.NomeLB)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 345)
        Me.Panel1.TabIndex = 9
        '
        'ValidadeMTF
        '
        Me.ValidadeMTF.Enabled = False
        Me.ValidadeMTF.Location = New System.Drawing.Point(211, 251)
        Me.ValidadeMTF.Mask = "00\/00\/0000"
        Me.ValidadeMTF.Name = "ValidadeMTF"
        Me.ValidadeMTF.Size = New System.Drawing.Size(82, 20)
        Me.ValidadeMTF.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Validade:"
        '
        'CRMVTF
        '
        Me.CRMVTF.Enabled = False
        Me.CRMVTF.Location = New System.Drawing.Point(68, 251)
        Me.CRMVTF.MaxLength = 10
        Me.CRMVTF.Name = "CRMVTF"
        Me.CRMVTF.Size = New System.Drawing.Size(82, 20)
        Me.CRMVTF.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "CRMV:"
        '
        'SalarioTF
        '
        Me.SalarioTF.Location = New System.Drawing.Point(211, 212)
        Me.SalarioTF.Name = "SalarioTF"
        Me.SalarioTF.Size = New System.Drawing.Size(82, 20)
        Me.SalarioTF.TabIndex = 5
        '
        'CPFMTF
        '
        Me.CPFMTF.Location = New System.Drawing.Point(211, 147)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "CPF:"
        '
        'NomeTF
        '
        Me.NomeTF.Location = New System.Drawing.Point(68, 115)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(225, 20)
        Me.NomeTF.TabIndex = 2
        '
        'PerfilCB
        '
        Me.PerfilCB.FormattingEnabled = True
        Me.PerfilCB.Location = New System.Drawing.Point(68, 177)
        Me.PerfilCB.Name = "PerfilCB"
        Me.PerfilCB.Size = New System.Drawing.Size(225, 21)
        Me.PerfilCB.TabIndex = 4
        '
        'MatriculaMTF
        '
        Me.MatriculaMTF.Enabled = False
        Me.MatriculaMTF.Location = New System.Drawing.Point(211, 85)
        Me.MatriculaMTF.Mask = "000000"
        Me.MatriculaMTF.Name = "MatriculaMTF"
        Me.MatriculaMTF.Size = New System.Drawing.Size(82, 20)
        Me.MatriculaMTF.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Salário:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 71)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cadastrar Funcionário"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.Funcionario
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CadastrarFuncionarioBT
        '
        Me.CadastrarFuncionarioBT.Location = New System.Drawing.Point(91, 304)
        Me.CadastrarFuncionarioBT.Name = "CadastrarFuncionarioBT"
        Me.CadastrarFuncionarioBT.Size = New System.Drawing.Size(121, 23)
        Me.CadastrarFuncionarioBT.TabIndex = 8
        Me.CadastrarFuncionarioBT.Text = "Cadastrar Funcionário"
        Me.CadastrarFuncionarioBT.UseVisualStyleBackColor = True
        '
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.Location = New System.Drawing.Point(11, 88)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(53, 13)
        Me.NomeLB.TabIndex = 0
        Me.NomeLB.Text = "Matricula:"
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(11, 180)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(33, 13)
        Me.CPFLB.TabIndex = 1
        Me.CPFLB.Text = "Perfil:"
        '
        'CadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 370)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CadastroFuncionario"
        Me.Text = "CadastroFuncionario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CadastrarFuncionarioBT As System.Windows.Forms.Button
    Friend WithEvents NomeLB As System.Windows.Forms.Label
    Friend WithEvents CPFLB As System.Windows.Forms.Label
    Friend WithEvents MatriculaMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PerfilCB As System.Windows.Forms.ComboBox
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomeTF As System.Windows.Forms.TextBox
    Friend WithEvents SalarioTF As System.Windows.Forms.TextBox
    Friend WithEvents ValidadeMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CRMVTF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
