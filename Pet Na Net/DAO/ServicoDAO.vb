Imports System.Text

Public Class ServicoDAO

    Private FuncionarioDAOInstance As New FuncionarioDAO
    Private ClienteDAOInstance As New ClienteDAO

    Public Function Insert(ByVal servico As Servico) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO Servicos(DataCriacao, IdCliente, Tipo, Valor, Status, DataServico, IdVeterinario) ")
        strSQL.Append("VALUES(@dtCriacao, @IDCli, @tipo, @valor, @status, @dtServico, @idVet);")

        conn.AddParameter("@dtCriacao", servico.DataCriacao)
        conn.AddParameter("@IDCli", servico.Cliente.ID)
        conn.AddParameter("@tipo", servico.Tipo)
        conn.AddParameter("@valor", servico.Valor)
        conn.AddParameter("@status", servico.Status)
        conn.AddParameter("@dtServico", servico.DataServico)
        If (servico.Veterinario Is Nothing) Then : conn.AddParameter("@idVet", 0)
        Else : conn.AddParameter("@idVet", servico.Veterinario.ID)
        End If

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function Update(ByVal servico As Servico) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update Servicos ")
        strSQL.Append("SET DataCriacao = @dtCriacao, ")
        strSQL.Append("IdCliente = @IDCli, ")
        strSQL.Append("Tipo = @tipo, ")
        strSQL.Append("Valor = @valor, ")
        strSQL.Append("Status = @status, ")
        strSQL.Append("DataServico = @dtServico, ")
        strSQL.Append("IdVeterinario = @idvet ")
        strSQL.Append("WHERE Id = @id;")

        conn.AddParameter("@dtCriacao", servico.DataCriacao)
        conn.AddParameter("@IDCli", servico.Cliente.ID)
        conn.AddParameter("@tipo", servico.Tipo)
        conn.AddParameter("@valor", servico.Valor)
        conn.AddParameter("@status", servico.Status)
        conn.AddParameter("@dtServico", servico.DataServico)
        If (servico.Veterinario Is Nothing) Then : conn.AddParameter("@idVet", 0)
        Else : conn.AddParameter("@idVet", servico.Veterinario.ID)
        End If
        conn.AddParameter("@id", servico.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function FindAll() As List(Of Servico)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Servicos;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim servicos As New List(Of Servico)
        For Each row As DataRow In dt.Rows
            Dim servico As New Servico()
            servico.ID = row.Item("Id")
            servico.DataCriacao = CDate(row.Item("DataCriacao"))
            servico.Tipo = row.Item("Tipo")
            servico.Valor = CDbl(row.Item("Valor"))
            servico.Status = row.Item("Status")
            servico.DataServico = row.Item("DataServico")
            servico.Cliente = ClienteDAOInstance.FindByID(row.Item("IdCliente"))

            If (row.Item("IdVeterinario") > 0) Then
                servico.Veterinario = FuncionarioDAOInstance.FindByID(row.Item("IdVeterinario"))
            End If

            If (IsDBNull(row.Item("DataFinalizacao")) = False) Then
                servico.DataFinalizacao = row.Item("DataFinalizacao")
            End If

            If (row.Item("IdFuncionarioFinal") > 0) Then
                servico.FuncionarioFinal = FuncionarioDAOInstance.FindByID(row.Item("IdFuncionarioFinal"))
            End If

            servicos.Add(servico)
        Next
        Return servicos
    End Function

    Public Function FindByID(ByVal id As Integer) As Servico
        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Servicos WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim servico As New Servico()
        servico.ID = dt.Rows(0).Item("Id")
        servico.DataCriacao = CDate(dt.Rows(0).Item("DataCriacao"))
        servico.Tipo = dt.Rows(0).Item("Tipo")
        servico.Valor = CDbl(dt.Rows(0).Item("Valor"))
        servico.Status = dt.Rows(0).Item("Status")
        servico.DataServico = dt.Rows(0).Item("DataServico")
        servico.Cliente = ClienteDAOInstance.FindByID(dt.Rows(0).Item("IdCliente"))

        If (dt.Rows(0).Item("IdVeterinario") > 0) Then
            servico.Veterinario = FuncionarioDAOInstance.FindByID(dt.Rows(0).Item("IdVeterinario"))
        End If

        If (IsDBNull(dt.Rows(0).Item("DataFinalizacao")) = False) Then
            servico.DataFinalizacao = dt.Rows(0).Item("DataFinalizacao")
        End If

        If (dt.Rows(0).Item("IdFuncionarioFinal") > 0) Then
            servico.FuncionarioFinal = FuncionarioDAOInstance.FindByID(dt.Rows(0).Item("IdFuncionarioFinal"))
        End If

        Return servico
    End Function

    Public Function FindByCPFTipoData(ByVal idCliente As Integer, ByVal tipo As String, data As Date) As Servico
        If (idCliente = 0) Then Return Nothing
        If (String.IsNullOrWhiteSpace(tipo)) Then Return Nothing
        If (data = Nothing) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Servicos WHERE IdCliente = @idCli And ")
        query.Append("Tipo = @tipo And ")
        query.Append("Cast(DataServico As Date) = Cast(@dtServico As Date);")

        conn.AddParameter("@idCli", idCliente)
        conn.AddParameter("@tipo", tipo)
        conn.AddParameter("@dtServico", data)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim servico As New Servico()
        servico.ID = dt.Rows(0).Item("Id")
        servico.DataCriacao = CDate(dt.Rows(0).Item("DataCriacao"))
        servico.Tipo = dt.Rows(0).Item("Tipo")
        servico.Valor = CDbl(dt.Rows(0).Item("Valor"))
        servico.Status = dt.Rows(0).Item("Status")
        servico.DataServico = dt.Rows(0).Item("DataServico")
        servico.Cliente = ClienteDAOInstance.FindByID(dt.Rows(0).Item("IdCliente"))

        If (dt.Rows(0).Item("IdVeterinario") > 0) Then
            servico.Veterinario = FuncionarioDAOInstance.FindByID(dt.Rows(0).Item("IdVeterinario"))
        End If

        If (IsDBNull(dt.Rows(0).Item("DataFinalizacao")) = False) Then
            servico.DataFinalizacao = dt.Rows(0).Item("DataFinalizacao")
        End If

        If (dt.Rows(0).Item("IdFuncionarioFinal") > 0) Then
            servico.FuncionarioFinal = FuncionarioDAOInstance.FindByID(dt.Rows(0).Item("IdFuncionarioFinal"))
        End If

        Return servico
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Servicos WHERE ID = @id")
    End Function

    Public Function FinalizarServico(id As String, status As String) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update Servicos ")
        strSQL.Append("SET DataFinalizacao = @dtFinal, ")
        strSQL.Append("Status = @status ")
        strSQL.Append("WHERE Id = @id;")

        conn.AddParameter("@dtFinal", Now)
        conn.AddParameter("@status", status)
        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand(strSQL.ToString)
    End Function

End Class
