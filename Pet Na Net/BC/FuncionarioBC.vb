Option Explicit On
Option Strict On

Public Class FuncionarioBC
    Public Function ValidateForModification(ByVal funcionario As Funcionario) As Boolean
        If (funcionario Is Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.CPF)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Nome)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Perfil)) Then Return False
        If (String.IsNullOrWhiteSpace(funcionario.Matricula)) Then Return False
        If (funcionario.Salario <= 0.0) Then Return False
        Return True
    End Function
End Class
