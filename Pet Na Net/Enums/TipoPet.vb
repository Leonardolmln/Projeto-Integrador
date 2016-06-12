Option Explicit On
Option Strict On

Public Class TipoPet
    Public Const Cao As String = "Cão"
    Public Const Gato As String = "Gato"
    Public Const Peixe As String = "Peixe"
    Public Const Hamster As String = "Hamster"

    Public Shared Function GetStatus() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Cao)
        list.Add(Gato)
        list.Add(Peixe)
        list.Add(Hamster)
        Return list
    End Function

End Class
