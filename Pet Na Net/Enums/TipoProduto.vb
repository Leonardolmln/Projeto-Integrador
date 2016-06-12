Option Explicit On
Option Strict On

Class TipoProduto

    Public Const Shampoo As String = "Shampoo"
    Public Const Racao As String = "Ração"
    Public Const Sabonete As String = "Sabonete"
    Public Const Acessorio As String = "Acessorio"
    Public Const Medicamento As String = "Medicamento"
    Public Const Brinquedo As String = "Brinquedo"

    Public Shared Function GetStatus() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Shampoo)
        list.Add(Racao)
        list.Add(Sabonete)
        list.Add(Acessorio)
        list.Add(Medicamento)
        list.Add(Brinquedo)
        Return list
    End Function

End Class
