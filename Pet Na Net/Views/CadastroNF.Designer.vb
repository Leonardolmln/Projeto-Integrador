<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroNF
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProdutosDT = New System.Windows.Forms.DataGridView()
        Me.NomeProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Validade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProduto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CadastrarPetBT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FornecedorCB = New System.Windows.Forms.ComboBox()
        Me.AddFornecedorIMG = New System.Windows.Forms.PictureBox()
        Me.NumNFTF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmissaoTF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpresaLB = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AddFornecedorIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ProdutosDT)
        Me.Panel3.Controls.Add(Me.CadastrarPetBT)
        Me.Panel3.Location = New System.Drawing.Point(13, 217)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(533, 203)
        Me.Panel3.TabIndex = 14
        '
        'ProdutosDT
        '
        Me.ProdutosDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ProdutosDT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.ProdutosDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeProduto, Me.Validade, Me.Marca, Me.TipoProduto, Me.ValorUnitario, Me.Quantidade})
        Me.ProdutosDT.Location = New System.Drawing.Point(14, 15)
        Me.ProdutosDT.Name = "ProdutosDT"
        Me.ProdutosDT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.ProdutosDT.RowTemplate.Height = 45
        Me.ProdutosDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ProdutosDT.Size = New System.Drawing.Size(503, 120)
        Me.ProdutosDT.TabIndex = 4
        '
        'NomeProduto
        '
        Me.NomeProduto.HeaderText = "Nome do Produto"
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.Width = 105
        '
        'Validade
        '
        Me.Validade.HeaderText = "Validade"
        Me.Validade.Name = "Validade"
        Me.Validade.Width = 73
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 62
        '
        'TipoProduto
        '
        Me.TipoProduto.HeaderText = "Tipo do Produto"
        Me.TipoProduto.Items.AddRange(New Object() {"Shampoo", "Racao", "Sabonete", "Acessorios", "Medicamento", "Brinquedos"})
        Me.TipoProduto.Name = "TipoProduto"
        Me.TipoProduto.Width = 80
        '
        'ValorUnitario
        '
        Me.ValorUnitario.HeaderText = "Valor Unitário"
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ValorUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorUnitario.Width = 68
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantidade.Width = 68
        '
        'CadastrarPetBT
        '
        Me.CadastrarPetBT.Location = New System.Drawing.Point(211, 161)
        Me.CadastrarPetBT.Name = "CadastrarPetBT"
        Me.CadastrarPetBT.Size = New System.Drawing.Size(113, 23)
        Me.CadastrarPetBT.TabIndex = 5
        Me.CadastrarPetBT.Text = "Inserir Nota Fiscal"
        Me.CadastrarPetBT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FornecedorCB)
        Me.Panel1.Controls.Add(Me.AddFornecedorIMG)
        Me.Panel1.Controls.Add(Me.NumNFTF)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.EmissaoTF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.EmpresaLB)
        Me.Panel1.Location = New System.Drawing.Point(13, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 133)
        Me.Panel1.TabIndex = 13
        '
        'FornecedorCB
        '
        Me.FornecedorCB.FormattingEnabled = True
        Me.FornecedorCB.Location = New System.Drawing.Point(285, 53)
        Me.FornecedorCB.Name = "FornecedorCB"
        Me.FornecedorCB.Size = New System.Drawing.Size(199, 21)
        Me.FornecedorCB.TabIndex = 2
        '
        'AddFornecedorIMG
        '
        Me.AddFornecedorIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddFornecedorIMG.Image = Global.Pet_Na_Net.My.Resources.Resources.Adicionar
        Me.AddFornecedorIMG.Location = New System.Drawing.Point(493, 54)
        Me.AddFornecedorIMG.Name = "AddFornecedorIMG"
        Me.AddFornecedorIMG.Size = New System.Drawing.Size(20, 20)
        Me.AddFornecedorIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AddFornecedorIMG.TabIndex = 23
        Me.AddFornecedorIMG.TabStop = False
        '
        'NumNFTF
        '
        Me.NumNFTF.Location = New System.Drawing.Point(412, 18)
        Me.NumNFTF.Name = "NumNFTF"
        Me.NumNFTF.Size = New System.Drawing.Size(102, 20)
        Me.NumNFTF.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Número NF:"
        '
        'EmissaoTF
        '
        Me.EmissaoTF.Location = New System.Drawing.Point(447, 90)
        Me.EmissaoTF.Mask = "00\/00\/0000"
        Me.EmissaoTF.Name = "EmissaoTF"
        Me.EmissaoTF.Size = New System.Drawing.Size(67, 20)
        Me.EmissaoTF.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Data Emissão:"
        '
        'EmpresaLB
        '
        Me.EmpresaLB.AutoSize = True
        Me.EmpresaLB.Location = New System.Drawing.Point(19, 57)
        Me.EmpresaLB.Name = "EmpresaLB"
        Me.EmpresaLB.Size = New System.Drawing.Size(64, 13)
        Me.EmpresaLB.TabIndex = 10
        Me.EmpresaLB.Text = "Fornecedor:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(13, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 71)
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inserir Nota Fiscal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pet_Na_Net.My.Resources.Resources.NovaNF
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CadastroNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 432)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CadastroNF"
        Me.Text = "InserirNF"
        Me.Panel3.ResumeLayout(False)
        CType(Me.ProdutosDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AddFornecedorIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NumNFTF As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmissaoTF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmpresaLB As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AddFornecedorIMG As System.Windows.Forms.PictureBox
    Friend WithEvents FornecedorCB As System.Windows.Forms.ComboBox
    Friend WithEvents CadastrarPetBT As System.Windows.Forms.Button
    Friend WithEvents ProdutosDT As System.Windows.Forms.DataGridView
    Friend WithEvents NomeProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Validade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoProduto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ValorUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
