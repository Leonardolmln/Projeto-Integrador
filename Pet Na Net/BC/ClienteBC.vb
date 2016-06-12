Option Explicit On
Option Strict On

Public Class ClienteBC
    Public Function ValidateForModification(ByVal cliente As Cliente) As Boolean
        If (cliente Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(cliente.CPF)) Then Return False
        If (cliente.Desconto < 0 OrElse cliente.Desconto > 15) Then Return False
        If (cliente.InicioRelacionamento = Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(cliente.Nome)) Then Return False
        If (String.IsNullOrWhiteSpace(cliente.Endereco)) Then Return False
        If (String.IsNullOrWhiteSpace(cliente.Telefone)) Then Return False
        If (cliente.Pets Is Nothing) Then Return False
        If (cliente.TipoCliente < 0) Then Return False
        Return True
    End Function
End Class
