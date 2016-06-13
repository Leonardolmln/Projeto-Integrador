Public Class InfoNF

    Private MovimentoDAOInstance As New MovimentoDAO
    Private NotaFiscalDAOInstance As New NotaFiscalDAO
    Private FornecedorDAOInstance As New FornecedorDAO
    Private ProdutoDAOInstance As New ProdutoDAO
    Private ItemDAOInstance As New ItemDAO


    Private Sub InfoNF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdutosDT.Rows.Add(4)
    End Sub

    Private Sub InfoNF_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FornecedorCB.Items.Clear()
        For Each Fornecedor As Fornecedor In FornecedorDAOInstance.FindAll()
            FornecedorCB.Items.Add(Fornecedor.RazaoSocial)
        Next
        UpdateInfo()
    End Sub

    Public Sub UpdateInfo()
        BuscaNF.currentMovimento = MovimentoDAOInstance.FindByID(BuscaNF.currentMovimento.ID)
        
        NumNFTF.Text = BuscaNF.currentMovimento.NotaFiscal.NumeroNF
        FornecedorCB.Text = BuscaNF.currentMovimento.Fornecedor.RazaoSocial
        EmissaoTF.Text = BuscaNF.currentMovimento.NotaFiscal.Emissao

        For cont As Integer = 0 To BuscaNF.currentMovimento.Itens.Count - 1
            ProdutosDT.Rows(cont).Cells.Item("NomeProduto").Value = BuscaNF.currentMovimento.Itens(cont).Produto.NomeProduto
            ProdutosDT.Rows(cont).Cells.Item("Validade").Value = BuscaNF.currentMovimento.Itens(cont).Produto.Validade
            ProdutosDT.Rows(cont).Cells.Item("Marca").Value = BuscaNF.currentMovimento.Itens(cont).Produto.Marca
            ProdutosDT.Rows(cont).Cells.Item("TipoProduto").Value = BuscaNF.currentMovimento.Itens(cont).Produto.TipoProduto
            ProdutosDT.Rows(cont).Cells.Item("ValorUnitario").Value = BuscaNF.currentMovimento.Itens(cont).ValorUnitario
            ProdutosDT.Rows(cont).Cells.Item("Quantidade").Value = BuscaNF.currentMovimento.Itens(cont).Quantidade
        Next

    End Sub

End Class