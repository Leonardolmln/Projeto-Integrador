Option Explicit On
Option Strict On

Public Class TipoFuncionario
    Public Const Gerente As String = "Gerente"
    Public Const AssistenteAdm As String = "Assistente Administrativo"
    Public Const Almoxarife As String = "Almoxarife"
    Public Const Veterinario As String = "Veterinário"

    Public Shared Function GetStatus() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Gerente)
        list.Add(AssistenteAdm)
        list.Add(Almoxarife)
        list.Add(Veterinario)
        Return list
    End Function

End Class
