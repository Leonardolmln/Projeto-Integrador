Select IdMovimento, Numero, Emissao, Data, RazaoSocial, CNPJ, Endereco, Telefone, Quantidade, ValorUnitario, NomeProduto, Validade, TipoProduto, Marca From NotasFiscais
Inner Join Movimentos On Movimentos.IdNotaFiscal = NotasFiscais.Id
Inner Join Fornecedores On Fornecedores.Id = Movimentos.IdFornecedor
Inner Join Itens On Itens.IdMovimento = Movimentos.Id
Inner Join Produtos On Produtos.Id = Itens.IdProduto

Select * From NotasFiscais
Select * From Movimentos
Select * From Itens
Select * From Produtos

--Delete From Produtos Where Id < 19
--Delete From NotasFiscais Where Id != 15
--Delete From Movimentos Where Id != 9