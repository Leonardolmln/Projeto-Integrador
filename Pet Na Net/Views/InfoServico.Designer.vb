<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoServico
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
        Me.AtualizarBT = New System.Windows.Forms.Button()
        Me.Veterinário = New System.Windows.Forms.Label()
        Me.VeterinarioTF = New System.Windows.Forms.TextBox()
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.CPFLB = New System.Windows.Forms.Label()
        Me.StatusCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TipoCB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataServicoMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataCriacaoMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDTF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.ValorTF = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Controls.Add(Me.AtualizarBT)
        Me.Panel1.Controls.Add(Me.Veterinário)
        Me.Panel1.Controls.Add(Me.VeterinarioTF)
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Controls.Add(Me.StatusCB)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TipoCB)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DataServicoMTF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataCriacaoMTF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.IDTF)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NomeLB)
        Me.Panel1.Controls.Add(Me.ValorTF)
        Me.Panel1.Location = New System.Drawing.Point(13, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 287)
        Me.Panel1.TabIndex = 15
        '
        'AtualizarBT
        '
        Me.AtualizarBT.Location = New System.Drawing.Point(135, 244)
        Me.AtualizarBT.Name = "AtualizarBT"
        Me.AtualizarBT.Size = New System.Drawing.Size(111, 23)
        Me.AtualizarBT.TabIndex = 53
        Me.AtualizarBT.Text = "Atualizar Servico"
        Me.AtualizarBT.UseVisualStyleBackColor = True
        '
        'Veterinário
        '
        Me.Veterinário.AutoSize = True
        Me.Veterinário.Location = New System.Drawing.Point(15, 190)
        Me.Veterinário.Name = "Veterinário"
        Me.Veterinário.Size = New System.Drawing.Size(57, 13)
        Me.Veterinário.TabIndex = 52
        Me.Veterinário.Text = "Veterinário"
        '
        'VeterinarioTF
        '
        Me.VeterinarioTF.Enabled = False
        Me.VeterinarioTF.Location = New System.Drawing.Point(136, 187)
        Me.VeterinarioTF.Name = "VeterinarioTF"
        Me.VeterinarioTF.Size = New System.Drawing.Size(152, 20)
        Me.VeterinarioTF.TabIndex = 51
        '
        'CPFMTF
        '
        Me.CPFMTF.Enabled = False
        Me.CPFMTF.Location = New System.Drawing.Point(136, 46)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 50
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(15, 49)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(80, 13)
        Me.CPFLB.TabIndex = 49
        Me.CPFLB.Text = "CPF do Cliente:"
        '
        'StatusCB
        '
        Me.StatusCB.FormattingEnabled = True
        Me.StatusCB.Location = New System.Drawing.Point(136, 215)
        Me.StatusCB.Name = "StatusCB"
        Me.StatusCB.Size = New System.Drawing.Size(152, 21)
        Me.StatusCB.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Status:"
        '
        'TipoCB
        '
        Me.TipoCB.Enabled = False
        Me.TipoCB.FormattingEnabled = True
        Me.TipoCB.Location = New System.Drawing.Point(136, 158)
        Me.TipoCB.Name = "TipoCB"
        Me.TipoCB.Size = New System.Drawing.Size(152, 21)
        Me.TipoCB.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Tipo do Serviço:"
        '
        'DataServicoMTF
        '
        Me.DataServicoMTF.Location = New System.Drawing.Point(136, 130)
        Me.DataServicoMTF.Mask = "00\/00\/0000\ 00\:00"
        Me.DataServicoMTF.Name = "DataServicoMTF"
        Me.DataServicoMTF.Size = New System.Drawing.Size(96, 20)
        Me.DataServicoMTF.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Data do Serviço"
        '
        'DataCriacaoMTF
        '
        Me.DataCriacaoMTF.Enabled = False
        Me.DataCriacaoMTF.Location = New System.Drawing.Point(136, 102)
        Me.DataCriacaoMTF.Mask = "00\/00\/0000\ 00\:00"
        Me.DataCriacaoMTF.Name = "DataCriacaoMTF"
        Me.DataCriacaoMTF.Size = New System.Drawing.Size(96, 20)
        Me.DataCriacaoMTF.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Data da Criação"
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
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Número do Serviço:"
        '
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.Location = New System.Drawing.Point(15, 77)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(85, 13)
        Me.NomeLB.TabIndex = 10
        Me.NomeLB.Text = "Valor do Serviço"
        '
        'ValorTF
        '
        Me.ValorTF.Location = New System.Drawing.Point(136, 74)
        Me.ValorTF.Name = "ValorTF"
        Me.ValorTF.Size = New System.Drawing.Size(47, 20)
        Me.ValorTF.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(13, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 71)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Informações do Serviço"
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
        'InfoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InfoServico"
        Me.Text = "InfoServico"
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
    Friend WithEvents ValorTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataServicoMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataCriacaoMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TipoCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPFLB As System.Windows.Forms.Label
    Friend WithEvents Veterinário As System.Windows.Forms.Label
    Friend WithEvents VeterinarioTF As System.Windows.Forms.TextBox
    Friend WithEvents AtualizarBT As System.Windows.Forms.Button
End Class
