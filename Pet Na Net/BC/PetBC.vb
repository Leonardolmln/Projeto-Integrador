Option Explicit On
Option Strict On

Public Class PetBC
    Public Function ValidateForModification(ByVal pet As Pet) As Boolean
        If (pet Is Nothing) Then Return False
        If (pet.Dono Is Nothing) Then Return False
        If (pet.Nascimento = Nothing) Then Return False
        If (String.IsNullOrWhiteSpace(pet.Nome)) Then Return False
        If (TipoPet.GetStatus().Contains(pet.TipoPet) = False) Then Return False
        Return True
    End Function
End Class