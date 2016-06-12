<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaFornecedor
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
        Me.CNPJTF = New System.Windows.Forms.MaskedTextBox()
        Me.NomeRB = New System.Windows.Forms.RadioButton()
        Me.CNPJRB = New System.Windows.Forms.RadioButton()
        Me.BuscaFornecedorBT = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.CNPJTF)
        Me.Panel1.Controls.Add(Me.NomeRB)
        Me.Panel1.Controls.Add(Me.CNPJRB)
        Me.Panel1.Controls.Add(Me.BuscaFornecedorBT)
        Me.Panel1.Controls.Add(Me.NomeTF)
        Me.Panel1.Location = New System.Drawing.Point(12, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 131)
        Me.Panel1.TabIndex = 11
        '
        'CNPJTF
        '
        Me.CNPJTF.Enabled = False
        Me.CNPJTF.Location = New System.Drawing.Point(233, 11)
        Me.CNPJTF.Mask = "00\.000\.000\/0000\-00"
        Me.CNPJTF.Name = "CNPJTF"
        Me.CNPJTF.Size = New System.Drawing.Size(103, 20)
        Me.CNPJTF.TabIndex = 2
        '
        'NomeRB
        '
        Me.NomeRB.AutoSize = True
        Me.NomeRB.Location = New System.Drawing.Point(18, 53)
        Me.NomeRB.Name = "NomeRB"
        Me.NomeRB.Size = New System.Drawing.Size(105, 17)
        Me.NomeRB.TabIndex = 3
        Me.NomeRB.Text = "Busca Por Nome"
        Me.NomeRB.UseVisualStyleBackColor = True
        '
        'CNPJRB
        '
        Me.CNPJRB.AutoSize = True
        Me.CNPJRB.Checked = True
        Me.CNPJRB.Location = New System.Drawing.Point(18, 14)
        Me.CNPJRB.Name = "CNPJRB"
        Me.CNPJRB.Size = New System.Drawing.Size(104, 17)
        Me.CNPJRB.TabIndex = 1
        Me.CNPJRB.TabStop = True
        Me.CNPJRB.Text = "Busca Por CNPJ"
        Me.CNPJRB.UseVisualStyleBackColor = True
        '
        'BuscaFornecedorBT
        '
        Me.BuscaFornecedorBT.Location = New System.Drawing.Point(128, 92)
        Me.BuscaFornecedorBT.Name = "BuscaFornecedorBT"
        Me.BuscaFornecedorBT.Size = New System.Drawing.Size(113, 23)
        Me.BuscaFornecedorBT.TabIndex = 5
        Me.BuscaFornecedorBT.Text = "Buscar Fornecedor"
        Me.BuscaFornecedorBT.UseVisualStyleBackColor = True
        '
        'NomeTF
        '
        Me.NomeTF.Enabled = False
        Me.NomeTF.Location = New System.Drawing.Point(137, 52)
        Me.NomeTF.Name = "NomeTF"
        Me.NomeTF.Size = New System.Drawing.Size(199, 20)
        Me.NomeTF.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 10)
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
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar Fornecedor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.Busca
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BuscaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 220)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BuscaFornecedor"
        Me.Text = "BuscarFornecedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NomeRB As System.Windows.Forms.RadioButton
    Friend WithEvents CNPJRB As System.Windows.Forms.RadioButton
    Friend WithEvents BuscaFornecedorBT As System.Windows.Forms.Button
    Friend WithEvents NomeTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CNPJTF As System.Windows.Forms.MaskedTextBox
End Class
