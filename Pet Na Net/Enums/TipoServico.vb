Option Explicit On
Option Strict On

Class TipoServico

    Public Const Tosa As String = "Tosa"
    Public Const Banho As String = "Banho"
    Public Const BanhoTosa As String = "Banho e Tosa"
    Public Const Consulta As String = "Consulta"
    Public Const ReConsulta As String = "Re-Consulta"
    
    Public Shared Function GetStatus() As List(Of String)
        Dim list As New List(Of String)
        list.Add(Tosa)
        list.Add(Banho)
        list.Add(BanhoTosa)
        list.Add(Consulta)
        list.Add(ReConsulta)
        Return list
    End Function

End Class
