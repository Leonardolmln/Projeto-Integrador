Option Explicit On
Option Strict On

Public Class FornecedorBC
    Public Function ValidateForModification(ByVal fornecedor As Fornecedor) As Boolean
        If (fornecedor Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.CNPJ)) Then Return False
        If (fornecedor.Produtos Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.RazaoSocial)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Telefone)) Then Return False
        If (String.IsNullOrWhiteSpace(fornecedor.Endereco)) Then Return False

        Return True
    End Function
End Class
