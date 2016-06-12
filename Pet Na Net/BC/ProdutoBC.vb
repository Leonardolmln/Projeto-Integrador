Option Explicit On
Option Strict On

Public Class ProdutoBC
    Public Function ValidateForModification(ByVal produto As Produto) As Boolean
        If (produto Is Nothing) Then Return False
        If (produto.Fornecedor Is Nothing) Then Return False
        If (produto.TipoProduto = "") Then Return False
        If (produto.Validade = Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(produto.NomeProduto)) Then Return False
        Return True
    End Function
End Class
