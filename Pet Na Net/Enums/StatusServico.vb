Option Explicit On
Option Strict On

Class StatusServico

    Public Const Agendado As String = "Agendado"
    Public Const Finalizado As String = "Finalizado"
    Public Const Cancelado As String = "Cancelado"

    Public Shared Function GetStatus() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Agendado)
        list.Add(Finalizado)
        list.Add(Cancelado)
        Return list
    End Function

End Class
