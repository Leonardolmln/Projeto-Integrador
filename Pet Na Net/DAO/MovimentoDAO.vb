Imports System.Text

Public Class MovimentoDAO

    Private NotaFiscalDAOInstance As New NotaFiscalDAO
    Private ItemDAOInstance As New ItemDAO
    Private ClienteDAOInstance As New ClienteDAO
    Private FornecedorDAOInstance As New FornecedorDAO

    Public Function Insert(ByVal mov As Movimento) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO Movimentos(IdNotaFiscal, Tipo, Data, IdCliente, IdFornecedor) ")
        strSQL.Append("VALUES(@idNF, @tipo, @data, @idCli, @idForn);")

        conn.AddParameter("@idNF", mov.NotaFiscal.ID)
        conn.AddParameter("@tipo", mov.Tipo)
        conn.AddParameter("@data", mov.Data)

        If (mov.Cliente Is Nothing) Then
            conn.AddParameter("@idCli", 0)
        Else : conn.AddParameter("@idCli", mov.Cliente.ID)
        End If

        If (mov.Fornecedor Is Nothing) Then
            conn.AddParameter("@idForn", 0)
        Else : conn.AddParameter("@idForn", mov.Fornecedor.ID)
        End If

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function Update(ByVal mov As Movimento) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update Movimentos ")
        strSQL.Append("SET IdNotaFiscal = @idNF, ")
        strSQL.Append("Tipo = @tipo, ")
        strSQL.Append("Data = @data, ")
        strSQL.Append("IdCliente = @idCli, ")
        strSQL.Append("IdFornecedor = @idForn ")
        strSQL.Append("WHERE Id = @id;")

        conn.AddParameter("@idNF", mov.NotaFiscal.ID)
        conn.AddParameter("@tipo", mov.Tipo)
        conn.AddParameter("@data", mov.Data)

        If (mov.Cliente Is Nothing) Then
            conn.AddParameter("@idCli", 0)
        Else : conn.AddParameter("@idCli", mov.Cliente.ID)
        End If

        If (mov.Fornecedor Is Nothing) Then
            conn.AddParameter("@idForn", 0)
        Else : conn.AddParameter("@idForn", mov.Fornecedor.ID)
        End If

        conn.AddParameter("@id", mov.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function FindAll() As List(Of Movimento)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Movimentos;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim movimentos As New List(Of Movimento)
        For Each row As DataRow In dt.Rows
            Dim mov As New Movimento()
            mov.ID = row.Item("Id")
            mov.NotaFiscal = NotaFiscalDAOInstance.FindByID(row.Item("IdNotaFiscal"))
            mov.Tipo = row.Item("Tipo")
            mov.Data = row.Item("Data")
            mov.Cliente = ClienteDAOInstance.FindByID(row.Item("IdCliente"))
            mov.Fornecedor = FornecedorDAOInstance.FindByID(row.Item("IdFornecedor"))
            mov.Itens = ItemDAOInstance.FindByMovimento(mov)
            movimentos.Add(mov)
        Next
        Return movimentos
    End Function

    Public Function FindByID(ByVal id As Integer) As Movimento

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Movimentos WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim mov As New Movimento()
        mov.ID = dt.Rows(0).Item("Id")
        mov.NotaFiscal = NotaFiscalDAOInstance.FindByID(dt.Rows(0).Item("IdNotaFiscal"))
        mov.Tipo = dt.Rows(0).Item("Tipo")
        mov.Data = dt.Rows(0).Item("Data")
        mov.Cliente = ClienteDAOInstance.FindByID(dt.Rows(0).Item("IdCliente"))
        mov.Fornecedor = FornecedorDAOInstance.FindByID(dt.Rows(0).Item("IdFornecedor"))
        mov.Itens = ItemDAOInstance.FindByMovimento(mov)

        Return mov
    End Function

    Public Function FindByNF(ByVal nf As NotaFiscal) As Movimento

        If (nf Is Nothing) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Movimentos WHERE IdNotaFiscal = @idNF;")

        conn.AddParameter("@idNF", nf.ID)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim mov As New Movimento()
        mov.ID = dt.Rows(0).Item("Id")
        mov.NotaFiscal = NotaFiscalDAOInstance.FindByID(dt.Rows(0).Item("IdNotaFiscal"))
        mov.Tipo = dt.Rows(0).Item("Tipo")
        mov.Data = dt.Rows(0).Item("Data")

        Try
            mov.Cliente = ClienteDAOInstance.FindByID(dt.Rows(0).Item("IdCliente"))
        Catch ex As Exception
            mov.Cliente = Nothing
        End Try

        Try
            mov.Fornecedor = FornecedorDAOInstance.FindByID(dt.Rows(0).Item("IdFornecedor"))
        Catch ex As Exception
            mov.Fornecedor = Nothing
        End Try

        mov.Itens = ItemDAOInstance.FindByMovimento(mov)

        Return mov
    End Function

    Public Function FindLast() As Movimento
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT TOP 1 * FROM Movimentos ORDER BY ID DESC;")

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim mov As New Movimento()
        mov.ID = dt.Rows(0).Item("Id")
        mov.NotaFiscal = NotaFiscalDAOInstance.FindByID(dt.Rows(0).Item("IdNotaFiscal"))
        mov.Tipo = dt.Rows(0).Item("Tipo")
        mov.Data = dt.Rows(0).Item("Data")
        If (dt.Rows(0).Item("IdCliente") > 0) Then
            mov.Cliente = ClienteDAOInstance.FindByID(dt.Rows(0).Item("IdCliente"))
        ElseIf (dt.Rows(0).Item("IdFornecedor") > 0) Then
            mov.Fornecedor = FornecedorDAOInstance.FindByID(dt.Rows(0).Item("IdFornecedor"))
        End If

        mov.Itens = ItemDAOInstance.FindByMovimento(mov)

        Return mov
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Movimentos WHERE ID = @id")
    End Function

End Class