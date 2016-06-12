Select Numero, Emissao, Data, RazaoSocial, CNPJ, Endereco, Telefone, Quantidade, ValorUnitario, NomeProduto, Validade, TipoProduto, Marca From NotasFiscais
Inner Join Movimentos On Movimentos.IdNotaFiscal = NotasFiscais.Id
Inner Join Fornecedores On Fornecedores.Id = Movimentos.IdFornecedor
Inner Join Itens On Itens.IdMovimento = Movimentos.Id
Inner Join Produtos On Produtos.Id = Itens.IdProduto