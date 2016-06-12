Imports System.Text

Public Class ItemDAO

    Private ProdutoDAOInstance As New ProdutoDAO

    Public Function Insert(ByVal item As Item) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO Itens(IdMovimento, Quantidade, ValorUnitario, ValorTotal, IdProduto) ")
        strSQL.Append("VALUES(@idMov, @qtde, @vlUnit, @vlTotal, @idProd);")

        conn.AddParameter("@idMov", item.Movimento.ID)
        conn.AddParameter("@qtde", item.Quantidade)
        conn.AddParameter("@vlUnit", item.ValorUnitario)
        conn.AddParameter("@vlTotal", item.ValorTotal)
        conn.AddParameter("@idProd", item.Produto.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function Update(ByVal item As Item) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update Itens ")
        strSQL.Append("SET IdMovimento = @idMov, ")
        strSQL.Append("Quantidade = @qtde, ")
        strSQL.Append("ValorUnitario = @vlUnit, ")
        strSQL.Append("ValorTotal = @vlTotal, ")
        strSQL.Append("IdProduto = @idProd ")
        strSQL.Append("WHERE Id = @id;")

        conn.AddParameter("@idMov", item.Movimento.ID)
        conn.AddParameter("@qtde", item.Quantidade)
        conn.AddParameter("@vlUnit", item.ValorUnitario)
        conn.AddParameter("@vlTotal", item.ValorTotal)
        conn.AddParameter("@idProd", item.Produto.ID)
        conn.AddParameter("@id", item.ID)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function FindAll() As List(Of Item)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM ITENS;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim itens As New List(Of Item)
        For Each row As DataRow In dt.Rows
            Dim item As New Item()
            item.ID = row.Item("Id")
            item.Quantidade = row.Item("Quantidade")
            item.ValorUnitario = row.Item("ValorUnitario")
            item.ValorTotal = row.Item("ValorTotal")
            item.Produto = ProdutoDAOInstance.FindByID(row.Item("IdProduto"))
            itens.Add(item)
        Next
        Return itens
    End Function

    Public Function FindByMovimento(mov As Movimento) As List(Of Item)

        If (mov Is Nothing) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Itens WHERE IdMovimento = @idMov;")

        conn.AddParameter("@idMov", mov.ID)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim itens As New List(Of Item)
        For Each row As DataRow In dt.Rows
            Dim item As New Item()
            item.ID = row.Item("Id")
            item.Quantidade = row.Item("Quantidade")
            item.ValorUnitario = row.Item("ValorUnitario")
            item.ValorTotal = row.Item("ValorTotal")
            item.Produto = ProdutoDAOInstance.FindByID(row.Item("IdProduto"))
            itens.Add(item)
        Next
        Return itens
    End Function

    Public Function FindByID(ByVal id As Integer) As Item

        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Itens WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        
        Dim item As New Item()
        item.ID = dt.Rows(0).Item("Id")
        item.Quantidade = dt.Rows(0).Item("Quantidade")
        item.ValorUnitario = dt.Rows(0).Item("ValorUnitario")
        item.ValorTotal = dt.Rows(0).Item("ValorTotal")
        item.Produto = ProdutoDAOInstance.FindByID(dt.Rows(0).Item("IdProduto"))

        Return item
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Itens WHERE ID = @id")
    End Function

End Class
