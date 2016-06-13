<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoCliente
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
        Me.NomeTF = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CancelarIMG = New System.Windows.Forms.PictureBox()
        Me.AtualizarBT = New System.Windows.Forms.Button()
        Me.TelefoneMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EnderecoTF = New System.Windows.Forms.TextBox()
        Me.StatusTF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TipoTF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DescontoTF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDTF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InicRelacTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.CPFLB = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeletePetIMG = New System.Windows.Forms.PictureBox()
        Me.AddPetIMG = New System.Windows.Forms.PictureBox()
        Me.TipoPetCB = New System.Windows.Forms.ComboBox()
        Me.PetCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NascTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NomePetTF = New System.Windows.Forms.TextBox()
        Me.IDPet = New System.Windows.Forms.TextBox()
        Me.AtualizarPetBT = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CancelarIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DeletePetIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddPetIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeTF
        '
        Me.NomeTF.Location = New System.Drawing.Point(136, 54)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(199, 20)
        Me.NomeTF.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 71)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Informações do Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.Info
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CPFMTF
        '
        Me.CPFMTF.Enabled = False
        Me.CPFMTF.Location = New System.Drawing.Point(253, 90)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CancelarIMG)
        Me.Panel1.Controls.Add(Me.AtualizarBT)
        Me.Panel1.Controls.Add(Me.TelefoneMTF)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.EnderecoTF)
        Me.Panel1.Controls.Add(Me.StatusTF)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TipoTF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DescontoTF)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.IDTF)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.InicRelacTF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NomeLB)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Location = New System.Drawing.Point(12, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 334)
        Me.Panel1.TabIndex = 10
        '
        'CancelarIMG
        '
        Me.CancelarIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarIMG.Image = Global.Pet_Na_Net.My.Resources.Resources.Remover
        Me.CancelarIMG.Location = New System.Drawing.Point(315, 18)
        Me.CancelarIMG.Name = "CancelarIMG"
        Me.CancelarIMG.Size = New System.Drawing.Size(20, 20)
        Me.CancelarIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CancelarIMG.TabIndex = 26
        Me.CancelarIMG.TabStop = False
        '
        'AtualizarBT
        '
        Me.AtualizarBT.Location = New System.Drawing.Point(104, 286)
        Me.AtualizarBT.Name = "AtualizarBT"
        Me.AtualizarBT.Size = New System.Drawing.Size(146, 23)
        Me.AtualizarBT.TabIndex = 10
        Me.AtualizarBT.Text = "Atualizar Informações"
        Me.AtualizarBT.UseVisualStyleBackColor = True
        '
        'TelefoneMTF
        '
        Me.TelefoneMTF.Location = New System.Drawing.Point(249, 238)
        Me.TelefoneMTF.Mask = "(99) 00000-0000"
        Me.TelefoneMTF.Name = "TelefoneMTF"
        Me.TelefoneMTF.Size = New System.Drawing.Size(86, 20)
        Me.TelefoneMTF.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Telefone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Endereco:"
        '
        'EnderecoTF
        '
        Me.EnderecoTF.Location = New System.Drawing.Point(136, 198)
        Me.EnderecoTF.Name = "EnderecoTF"
        Me.EnderecoTF.Size = New System.Drawing.Size(199, 20)
        Me.EnderecoTF.TabIndex = 8
        '
        'StatusTF
        '
        Me.StatusTF.Enabled = False
        Me.StatusTF.Location = New System.Drawing.Point(233, 18)
        Me.StatusTF.Name = "StatusTF"
        Me.StatusTF.Size = New System.Drawing.Size(75, 20)
        Me.StatusTF.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Status:"
        '
        'TipoTF
        '
        Me.TipoTF.Enabled = False
        Me.TipoTF.Location = New System.Drawing.Point(99, 162)
        Me.TipoTF.Name = "TipoTF"
        Me.TipoTF.Size = New System.Drawing.Size(67, 20)
        Me.TipoTF.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tipo Cliente"
        '
        'DescontoTF
        '
        Me.DescontoTF.Enabled = False
        Me.DescontoTF.Location = New System.Drawing.Point(305, 162)
        Me.DescontoTF.Name = "DescontoTF"
        Me.DescontoTF.Size = New System.Drawing.Size(30, 20)
        Me.DescontoTF.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "% Desconto"
        '
        'IDTF
        '
        Me.IDTF.Enabled = False
        Me.IDTF.Location = New System.Drawing.Point(136, 18)
        Me.IDTF.Name = "IDTF"
        Me.IDTF.Size = New System.Drawing.Size(30, 20)
        Me.IDTF.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Número no Cadastro:"
        '
        'InicRelacTF
        '
        Me.InicRelacTF.Enabled = False
        Me.InicRelacTF.Location = New System.Drawing.Point(268, 126)
        Me.InicRelacTF.Mask = "00\/00\/0000"
        Me.InicRelacTF.Name = "InicRelacTF"
        Me.InicRelacTF.Size = New System.Drawing.Size(67, 20)
        Me.InicRelacTF.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Início Relacionamento:"
        '
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.Location = New System.Drawing.Point(19, 57)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(38, 13)
        Me.NomeLB.TabIndex = 10
        Me.NomeLB.Text = "Nome:"
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(19, 93)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(30, 13)
        Me.CPFLB.TabIndex = 11
        Me.CPFLB.Text = "CPF:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.AtualizarPetBT)
        Me.Panel3.Controls.Add(Me.IDPet)
        Me.Panel3.Controls.Add(Me.DeletePetIMG)
        Me.Panel3.Controls.Add(Me.AddPetIMG)
        Me.Panel3.Controls.Add(Me.TipoPetCB)
        Me.Panel3.Controls.Add(Me.PetCB)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.NascTF)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.NomePetTF)
        Me.Panel3.Location = New System.Drawing.Point(12, 415)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(357, 193)
        Me.Panel3.TabIndex = 11
        '
        'DeletePetIMG
        '
        Me.DeletePetIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeletePetIMG.Image = Global.Pet_Na_Net.My.Resources.Resources.Remover
        Me.DeletePetIMG.Location = New System.Drawing.Point(314, 18)
        Me.DeletePetIMG.Name = "DeletePetIMG"
        Me.DeletePetIMG.Size = New System.Drawing.Size(20, 20)
        Me.DeletePetIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeletePetIMG.TabIndex = 23
        Me.DeletePetIMG.TabStop = False
        '
        'AddPetIMG
        '
        Me.AddPetIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddPetIMG.Image = Global.Pet_Na_Net.My.Resources.Resources.Adicionar
        Me.AddPetIMG.Location = New System.Drawing.Point(288, 18)
        Me.AddPetIMG.Name = "AddPetIMG"
        Me.AddPetIMG.Size = New System.Drawing.Size(20, 20)
        Me.AddPetIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AddPetIMG.TabIndex = 22
        Me.AddPetIMG.TabStop = False
        '
        'TipoPetCB
        '
        Me.TipoPetCB.FormattingEnabled = True
        Me.TipoPetCB.Location = New System.Drawing.Point(136, 126)
        Me.TipoPetCB.Name = "TipoPetCB"
        Me.TipoPetCB.Size = New System.Drawing.Size(199, 21)
        Me.TipoPetCB.TabIndex = 14
        '
        'PetCB
        '
        Me.PetCB.FormattingEnabled = True
        Me.PetCB.Location = New System.Drawing.Point(171, 18)
        Me.PetCB.Name = "PetCB"
        Me.PetCB.Size = New System.Drawing.Size(108, 21)
        Me.PetCB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tipo Pet"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Pet Atual:"
        '
        'NascTF
        '
        Me.NascTF.Enabled = False
        Me.NascTF.Location = New System.Drawing.Point(268, 90)
        Me.NascTF.Mask = "00\/00\/0000"
        Me.NascTF.Name = "NascTF"
        Me.NascTF.Size = New System.Drawing.Size(67, 20)
        Me.NascTF.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Data de Nascimento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nome:"
        '
        'NomePetTF
        '
        Me.NomePetTF.Enabled = False
        Me.NomePetTF.Location = New System.Drawing.Point(136, 54)
        Me.NomePetTF.Name = "NomePetTF"
        Me.NomePetTF.Size = New System.Drawing.Size(199, 20)
        Me.NomePetTF.TabIndex = 12
        '
        'IDPet
        '
        Me.IDPet.Enabled = False
        Me.IDPet.Location = New System.Drawing.Point(136, 18)
        Me.IDPet.Name = "IDPet"
        Me.IDPet.Size = New System.Drawing.Size(30, 20)
        Me.IDPet.TabIndex = 24
        '
        'AtualizarPetBT
        '
        Me.AtualizarPetBT.Location = New System.Drawing.Point(104, 159)
        Me.AtualizarPetBT.Name = "AtualizarPetBT"
        Me.AtualizarPetBT.Size = New System.Drawing.Size(146, 23)
        Me.AtualizarPetBT.TabIndex = 25
        Me.AtualizarPetBT.Text = "Atualizar Pet"
        Me.AtualizarPetBT.UseVisualStyleBackColor = True
        '
        'InfoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 620)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InfoCliente"
        Me.Text = "InfoCliente"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CancelarIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DeletePetIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddPetIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NomeTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NomeLB As System.Windows.Forms.Label
    Friend WithEvents CPFLB As System.Windows.Forms.Label
    Friend WithEvents InicRelacTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IDTF As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DescontoTF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TipoTF As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PetCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NascTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NomePetTF As System.Windows.Forms.TextBox
    Friend WithEvents TipoPetCB As System.Windows.Forms.ComboBox
    Friend WithEvents AddPetIMG As System.Windows.Forms.PictureBox
    Friend WithEvents DeletePetIMG As System.Windows.Forms.PictureBox
    Friend WithEvents StatusTF As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EnderecoTF As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AtualizarBT As System.Windows.Forms.Button
    Friend WithEvents CancelarIMG As System.Windows.Forms.PictureBox
    Friend WithEvents IDPet As System.Windows.Forms.TextBox
    Friend WithEvents AtualizarPetBT As System.Windows.Forms.Button
End Class
