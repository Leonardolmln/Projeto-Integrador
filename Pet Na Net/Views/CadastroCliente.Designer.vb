<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroCliente
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
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.CPFLB = New System.Windows.Forms.Label()
        Me.NomeTF = New System.Windows.Forms.TextBox()
        Me.CadastrarClienteBT = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TelefoneMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EnderecoTF = New System.Windows.Forms.TextBox()
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.Location = New System.Drawing.Point(11, 88)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(38, 13)
        Me.NomeLB.TabIndex = 0
        Me.NomeLB.Text = "Nome:"
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(11, 118)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(30, 13)
        Me.CPFLB.TabIndex = 1
        Me.CPFLB.Text = "CPF:"
        '
        'NomeTF
        '
        Me.NomeTF.Location = New System.Drawing.Point(73, 86)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(215, 20)
        Me.NomeTF.TabIndex = 1
        '
        'CadastrarClienteBT
        '
        Me.CadastrarClienteBT.Location = New System.Drawing.Point(95, 233)
        Me.CadastrarClienteBT.Name = "CadastrarClienteBT"
        Me.CadastrarClienteBT.Size = New System.Drawing.Size(113, 23)
        Me.CadastrarClienteBT.TabIndex = 5
        Me.CadastrarClienteBT.Text = "Cadastrar Cliente"
        Me.CadastrarClienteBT.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.Novo_Cliente
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TelefoneMTF)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.EnderecoTF)
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.CadastrarClienteBT)
        Me.Panel1.Controls.Add(Me.NomeLB)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Location = New System.Drawing.Point(12, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 279)
        Me.Panel1.TabIndex = 8
        '
        'TelefoneMTF
        '
        Me.TelefoneMTF.Location = New System.Drawing.Point(207, 187)
        Me.TelefoneMTF.Mask = "(99) 00000-0000"
        Me.TelefoneMTF.Name = "TelefoneMTF"
        Me.TelefoneMTF.Size = New System.Drawing.Size(81, 20)
        Me.TelefoneMTF.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Telefone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Endereco:"
        '
        'EnderecoTF
        '
        Me.EnderecoTF.Location = New System.Drawing.Point(73, 150)
        Me.EnderecoTF.Name = "EnderecoTF"
        Me.EnderecoTF.Size = New System.Drawing.Size(215, 20)
        Me.EnderecoTF.TabIndex = 3
        '
        'CPFMTF
        '
        Me.CPFMTF.Location = New System.Drawing.Point(206, 118)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(64, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cadastrar Novo Cliente"
        '
        'CadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 305)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CadastroCliente"
        Me.Text = "Cadastrar Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NomeLB As System.Windows.Forms.Label
    Friend WithEvents CPFLB As System.Windows.Forms.Label
    Friend WithEvents NomeTF As System.Windows.Forms.TextBox
    Friend WithEvents CadastrarClienteBT As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EnderecoTF As System.Windows.Forms.TextBox

End Class
