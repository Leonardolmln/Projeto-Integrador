<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroPet
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
        Me.NascimentoMTF = New System.Windows.Forms.MaskedTextBox()
        Me.TipoPetCB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClienteIDLB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CadastrarPetBT = New System.Windows.Forms.Button()
        Me.NomePetTF = New System.Windows.Forms.TextBox()
        Me.NascimentoLB = New System.Windows.Forms.Label()
        Me.NomePetLB = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NascimentoMTF)
        Me.Panel1.Controls.Add(Me.TipoPetCB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ClienteIDLB)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CadastrarPetBT)
        Me.Panel1.Controls.Add(Me.NomePetTF)
        Me.Panel1.Controls.Add(Me.NascimentoLB)
        Me.Panel1.Controls.Add(Me.NomePetLB)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 260)
        Me.Panel1.TabIndex = 21
        '
        'NascimentoMTF
        '
        Me.NascimentoMTF.Location = New System.Drawing.Point(211, 143)
        Me.NascimentoMTF.Mask = "00\/00\/0000"
        Me.NascimentoMTF.Name = "NascimentoMTF"
        Me.NascimentoMTF.Size = New System.Drawing.Size(67, 20)
        Me.NascimentoMTF.TabIndex = 2
        '
        'TipoPetCB
        '
        Me.TipoPetCB.FormattingEnabled = True
        Me.TipoPetCB.Location = New System.Drawing.Point(179, 172)
        Me.TipoPetCB.Name = "TipoPetCB"
        Me.TipoPetCB.Size = New System.Drawing.Size(99, 21)
        Me.TipoPetCB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tipo do Pet:"
        '
        'ClienteIDLB
        '
        Me.ClienteIDLB.AutoSize = True
        Me.ClienteIDLB.Location = New System.Drawing.Point(230, 86)
        Me.ClienteIDLB.Name = "ClienteIDLB"
        Me.ClienteIDLB.Size = New System.Drawing.Size(44, 13)
        Me.ClienteIDLB.TabIndex = 26
        Me.ClienteIDLB.Text = "ClientID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cliente:"
        '
        'CadastrarPetBT
        '
        Me.CadastrarPetBT.Location = New System.Drawing.Point(102, 219)
        Me.CadastrarPetBT.Name = "CadastrarPetBT"
        Me.CadastrarPetBT.Size = New System.Drawing.Size(113, 23)
        Me.CadastrarPetBT.TabIndex = 4
        Me.CadastrarPetBT.Text = "Cadastrar Pet"
        Me.CadastrarPetBT.UseVisualStyleBackColor = True
        '
        'NomePetTF
        '
        Me.NomePetTF.Location = New System.Drawing.Point(178, 114)
        Me.NomePetTF.Name = "NomePetTF"
        Me.NomePetTF.Size = New System.Drawing.Size(100, 20)
        Me.NomePetTF.TabIndex = 1
        '
        'NascimentoLB
        '
        Me.NascimentoLB.AutoSize = True
        Me.NascimentoLB.Location = New System.Drawing.Point(28, 146)
        Me.NascimentoLB.Name = "NascimentoLB"
        Me.NascimentoLB.Size = New System.Drawing.Size(66, 13)
        Me.NascimentoLB.TabIndex = 22
        Me.NascimentoLB.Text = "Nascimento:"
        '
        'NomePetLB
        '
        Me.NomePetLB.AutoSize = True
        Me.NomePetLB.Location = New System.Drawing.Point(28, 116)
        Me.NomePetLB.Name = "NomePetLB"
        Me.NomePetLB.Size = New System.Drawing.Size(57, 13)
        Me.NomePetLB.TabIndex = 21
        Me.NomePetLB.Text = "Nome Pet:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 71)
        Me.Panel2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cadastrar Novo Pet"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Pet_Na_Net.My.Resources.Resources.Novo_Pet
        Me.PictureBox2.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'CadastroPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 285)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CadastroPet"
        Me.Text = "Cadastrar Pet"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NascimentoMTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TipoPetCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClienteIDLB As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CadastrarPetBT As System.Windows.Forms.Button
    Friend WithEvents NomePetTF As System.Windows.Forms.TextBox
    Friend WithEvents NascimentoLB As System.Windows.Forms.Label
    Friend WithEvents NomePetLB As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
