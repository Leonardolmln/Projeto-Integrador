Option Explicit On
Option Strict On

Public Class VeterinarioBC
    Public Function ValidateForModification(ByVal veterinario As Veterinario) As Boolean
        Dim funcionarioBCInstance As New FuncionarioBC
        funcionarioBCInstance.ValidateForModification(veterinario)
        If (String.IsNullOrWhiteSpace(veterinario.CRMV)) Then Return False
        If (veterinario.ValidadeCRMV = Nothing) Then Return False
        Return True
    End Function
End Class
