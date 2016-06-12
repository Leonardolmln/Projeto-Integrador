Option Explicit On
Option Strict On

Public Class ServicoBC
    Public Function ValidateForModification(ByVal servico As Servico) As Boolean
        If (String.IsNullOrWhiteSpace(servico.Status)) Then Return False
        If (String.IsNullOrWhiteSpace(servico.Tipo)) Then Return False
        If (servico.DataCriacao = Nothing) Then Return False
        If (servico.DataServico = Nothing) Then Return False
        If (servico.Cliente Is Nothing) Then Return False
        If (servico.Valor <= 0.0) Then Return False
        Return True
    End Function
End Class
