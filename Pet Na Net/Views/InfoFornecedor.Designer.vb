<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoFornecedor
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
        Me.TelefoneMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EnderecoTF = New System.Windows.Forms.TextBox()
        Me.CNPJTF = New System.Windows.Forms.MaskedTextBox()
        Me.IDTF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.CPFLB = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.TelefoneMTF)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.EnderecoTF)
        Me.Panel1.Controls.Add(Me.CNPJTF)
        Me.Panel1.Controls.Add(Me.IDTF)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NomeLB)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Location = New System.Drawing.Point(13, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 211)
        Me.Panel1.TabIndex = 13
        '
        'TelefoneMTF
        '
        Me.TelefoneMTF.Location = New System.Drawing.Point(253, 170)
        Me.TelefoneMTF.Mask = "(99) 00000-0000"
        Me.TelefoneMTF.Name = "TelefoneMTF"
        Me.TelefoneMTF.Size = New System.Drawing.Size(81, 20)
        Me.TelefoneMTF.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Telefone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Endereco:"
        '
        'EnderecoTF
        '
        Me.EnderecoTF.Location = New System.Drawing.Point(136, 132)
        Me.EnderecoTF.Name = "EnderecoTF"
        Me.EnderecoTF.Size = New System.Drawing.Size(199, 20)
        Me.EnderecoTF.TabIndex = 4
        '
        'CNPJTF
        '
        Me.CNPJTF.Enabled = False
        Me.CNPJTF.Location = New System.Drawing.Point(232, 94)
        Me.CNPJTF.Mask = "00\.000\.000\/0000\-00"
        Me.CNPJTF.Name = "CNPJTF"
        Me.CNPJTF.Size = New System.Drawing.Size(103, 20)
        Me.CNPJTF.TabIndex = 3
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
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.Location = New System.Drawing.Point(19, 59)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(73, 13)
        Me.NomeLB.TabIndex = 10
        Me.NomeLB.Text = "Razão Social:"
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(19, 97)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(37, 13)
        Me.CPFLB.TabIndex = 11
        Me.CPFLB.Text = "CNPJ:"
        '
        'NomeTF
        '
        Me.NomeTF.Enabled = False
        Me.NomeTF.Location = New System.Drawing.Point(136, 56)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(199, 20)
        Me.NomeTF.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(13, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 71)
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Informações do Fornecedor"
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
        'InfoFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 308)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InfoFornecedor"
        Me.Text = "InfoFornecedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IDTF As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomeLB As System.Windows.Forms.Label
    Friend WithEvents CPFLB As System.Windows.Forms.Label
    Friend WithEvents NomeTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CNPJTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EnderecoTF As System.Windows.Forms.TextBox
End Class
