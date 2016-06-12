Imports System.Text

Public Class ProdutoDAO
    Public Function Insert(ByVal produto As Produto) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("INSERT INTO Produtos (NomeProduto, Validade, TipoProduto, Marca) ")
        query.Append("VALUES(@nome, @validade, @tipo, @marca);")

        conn.AddParameter("@nome", produto.NomeProduto)
        conn.AddParameter("@validade", produto.Validade)
        conn.AddParameter("@tipo", produto.TipoProduto)
        conn.AddParameter("@marca", produto.Marca)

        Return conn.ExecuteCommand(query.ToString)
    End Function

    Public Function Update(ByVal produto As Produto) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Update PRODUTOS ")
        query.Append("SET NomeProduto = @nome, ")
        query.Append("Validade = @validade, ")
        query.Append("TipoProduto = @tipo, ")
        query.Append("Marca = @marca ")
        query.Append("WHERE Id = @id;")

        conn.AddParameter("@nome", produto.NomeProduto)
        conn.AddParameter("@validade", produto.Validade)
        conn.AddParameter("@tipo", produto.TipoProduto)
        conn.AddParameter("@marca", produto.Marca)
        conn.AddParameter("@id", produto.ID)

        Return conn.ExecuteCommand(query.ToString)

    End Function

    Public Function FindAll() As List(Of Produto)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM PRODUTOS;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim produtos As New List(Of Produto)
        For Each row As DataRow In dt.Rows
            Dim produto As New Produto()
            produto.ID = row.Item("Id")
            produto.NomeProduto = row.Item("NomeProduto")
            produto.Validade = row.Item("Validade")
            produto.TipoProduto = row.Item("TipoProduto")
            produto.Marca = row.Item("Marca")
            produtos.Add(produto)
        Next
        Return produtos
    End Function

    Public Function FindByID(ByVal id As Integer) As Produto
        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM Produtos WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim produto As New Produto()
        produto.ID = dt.Rows(0).Item("Id")
        produto.NomeProduto = dt.Rows(0).Item("NomeProduto")
        produto.Validade = dt.Rows(0).Item("Validade")
        produto.TipoProduto = dt.Rows(0).Item("TipoProduto")
        produto.Marca = dt.Rows(0).Item("Marca")

        Return produto
    End Function

    Public Function FindLast() As Produto
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT TOP 1 * FROM Produtos ORDER BY ID DESC;")
        
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        Dim produto As New Produto()
        produto.ID = dt.Rows(0).Item("Id")
        produto.NomeProduto = dt.Rows(0).Item("NomeProduto")
        produto.Validade = dt.Rows(0).Item("Validade")
        produto.TipoProduto = dt.Rows(0).Item("TipoProduto")
        produto.Marca = dt.Rows(0).Item("Marca")

        Return produto
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Produtos WHERE ID = @id")
    End Function

End Class
