<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroServico
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
        Me.CPFMTF = New System.Windows.Forms.MaskedTextBox()
        Me.CPFLB = New System.Windows.Forms.Label()
        Me.DataServicoMTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TipoCB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VeterinarioCB = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ValorTF = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AdicionarServicoBT = New System.Windows.Forms.Button()
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CPFMTF)
        Me.Panel1.Controls.Add(Me.CPFLB)
        Me.Panel1.Controls.Add(Me.DataServicoMTF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TipoCB)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.VeterinarioCB)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ValorTF)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.AdicionarServicoBT)
        Me.Panel1.Controls.Add(Me.NomeLB)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 337)
        Me.Panel1.TabIndex = 9
        '
        'CPFMTF
        '
        Me.CPFMTF.Location = New System.Drawing.Point(206, 92)
        Me.CPFMTF.Mask = "000\.000\.000\-00"
        Me.CPFMTF.Name = "CPFMTF"
        Me.CPFMTF.Size = New System.Drawing.Size(82, 20)
        Me.CPFMTF.TabIndex = 1
        '
        'CPFLB
        '
        Me.CPFLB.AutoSize = True
        Me.CPFLB.Location = New System.Drawing.Point(11, 92)
        Me.CPFLB.Name = "CPFLB"
        Me.CPFLB.Size = New System.Drawing.Size(80, 13)
        Me.CPFLB.TabIndex = 41
        Me.CPFLB.Text = "CPF do Cliente:"
        '
        'DataServicoMTF
        '
        Me.DataServicoMTF.Location = New System.Drawing.Point(191, 253)
        Me.DataServicoMTF.Mask = "00\/00\/0000\ 00\:00"
        Me.DataServicoMTF.Name = "DataServicoMTF"
        Me.DataServicoMTF.Size = New System.Drawing.Size(96, 20)
        Me.DataServicoMTF.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Data do Serviço"
        '
        'TipoCB
        '
        Me.TipoCB.FormattingEnabled = True
        Me.TipoCB.Location = New System.Drawing.Point(73, 128)
        Me.TipoCB.Name = "TipoCB"
        Me.TipoCB.Size = New System.Drawing.Size(215, 21)
        Me.TipoCB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Veterinário:"
        '
        'VeterinarioCB
        '
        Me.VeterinarioCB.Enabled = False
        Me.VeterinarioCB.FormattingEnabled = True
        Me.VeterinarioCB.Location = New System.Drawing.Point(73, 212)
        Me.VeterinarioCB.Name = "VeterinarioCB"
        Me.VeterinarioCB.Size = New System.Drawing.Size(214, 21)
        Me.VeterinarioCB.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Valor:"
        '
        'ValorTF
        '
        Me.ValorTF.Location = New System.Drawing.Point(73, 170)
        Me.ValorTF.Name = "ValorTF"
        Me.ValorTF.Size = New System.Drawing.Size(215, 20)
        Me.ValorTF.TabIndex = 3
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
        Me.Label1.Location = New System.Drawing.Point(89, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cadastrar Serviço"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.Novo_Serviço
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'AdicionarServicoBT
        '
        Me.AdicionarServicoBT.Location = New System.Drawing.Point(94, 295)
        Me.AdicionarServicoBT.Name = "AdicionarServicoBT"
        Me.AdicionarServicoBT.Size = New System.Drawing.Size(113, 23)
        Me.AdicionarServicoBT.TabIndex = 6
        Me.AdicionarServicoBT.Text = "Adicionar Serviço"
        Me.AdicionarServicoBT.UseVisualStyleBackColor = True
        '
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.Location = New System.Drawing.Point(11, 131)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(31, 13)
        Me.NomeLB.TabIndex = 0
        Me.NomeLB.Text = "Tipo:"
        '
        'CadastroServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 362)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CadastroServico"
        Me.Text = "CadastroServico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ValorTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AdicionarServicoBT As System.Windows.Forms.Button
    Friend WithEvents NomeLB As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VeterinarioCB As System.Windows.Forms.ComboBox
    Friend WithEvents TipoCB As System.Windows.Forms.ComboBox
    Friend WithEvents DataServicoMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CPFMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPFLB As System.Windows.Forms.Label
End Class
