Imports System.Text

Public Class FornecedorDAO
    Public Function Insert(ByVal fornecedor As Fornecedor) As Boolean
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("INSERT INTO Fornecedores (RazaoSocial, CNPJ, Endereco, Telefone) ")
        query.Append("VALUES(@razaoSocial, @cnpj, @end, @tel);")
        
        conn.AddParameter("@razaoSocial", fornecedor.RazaoSocial)
        conn.AddParameter("@cnpj", CleanString(fornecedor.CNPJ))
        conn.AddParameter("@end", fornecedor.Endereco)
        conn.AddParameter("@tel", fornecedor.Telefone)

        Return conn.ExecuteCommand(query.ToString)
    End Function

    Public Function Update(ByVal fornecedor As Fornecedor) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Update FORNECEDORES ")
        query.Append("SET RazaoSocial = @razaoSocial, ")
        query.Append("CNPJ = @cnpj, ")
        query.Append("Endereco = @end, ")
        query.Append("Telefone = @tel ")
        query.Append("WHERE Id = @id;")

        conn.AddParameter("@razaoSocial", fornecedor.RazaoSocial)
        conn.AddParameter("@cnpj", CleanString(fornecedor.CNPJ))
        conn.AddParameter("@end", fornecedor.Endereco)
        conn.AddParameter("@tel", fornecedor.Telefone)
        conn.AddParameter("@id", fornecedor.ID)

        Return conn.ExecuteCommand(query.ToString)

    End Function

    Public Function FindAll() As List(Of Fornecedor)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM FORNECEDORES;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim fornecedores As New List(Of Fornecedor)
        For Each row As DataRow In dt.Rows
            Dim fornecedor As New Fornecedor()
            fornecedor.ID = row.Item("Id")
            fornecedor.RazaoSocial = row.Item("RazaoSocial")
            fornecedor.CNPJ = row.Item("CNPJ")
            fornecedor.Endereco = row.Item("Endereco")
            fornecedor.Telefone = row.Item("Telefone")
            fornecedores.Add(fornecedor)
        Next
        Return fornecedores
    End Function

    Public Function FindByID(ByVal id As Integer) As Fornecedor
        If (id = 0) Then Return Nothing
        Dim conn As New Connection
        Dim query As New StringBuilder
        query.Append("SELECT * FROM FORNECEDORES WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim fornecedor As New Fornecedor()

        fornecedor.ID = dt.Rows(0).Item("Id")
        fornecedor.RazaoSocial = dt.Rows(0).Item("RazaoSocial")
        fornecedor.CNPJ = dt.Rows(0).Item("CNPJ")
        fornecedor.Endereco = dt.Rows(0).Item("Endereco")
        fornecedor.Telefone = dt.Rows(0).Item("Telefone")

        Return fornecedor
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Fornecedores WHERE ID = @id")
    End Function

    Public Function FindByCNPJ(ByVal cnpj As String) As Fornecedor
        If (String.IsNullOrWhiteSpace(cnpj)) Then Return Nothing
        Dim conn As New Connection

        conn.AddParameter("@cnpj", CleanString(cnpj))

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Fornecedores WHERE CNPJ = @cnpj")

        If (dt.Rows.Count = 0) Then Return Nothing

        Dim fornecedor As New Fornecedor()

        fornecedor.ID = dt.Rows(0).Item("Id")
        fornecedor.RazaoSocial = dt.Rows(0).Item("RazaoSocial")
        fornecedor.CNPJ = dt.Rows(0).Item("CNPJ")
        fornecedor.Endereco = dt.Rows(0).Item("Endereco")
        fornecedor.Telefone = dt.Rows(0).Item("Telefone")

        Return fornecedor
    End Function

    Public Function FindByRazaoSocial(ByVal razaoSocial As String) As Fornecedor
        If (String.IsNullOrWhiteSpace(razaoSocial)) Then Return Nothing
        Dim conn As New Connection

        conn.AddParameter("@razao", razaoSocial)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Fornecedores WHERE RazaoSocial = @razao")

        If (dt.Rows.Count = 0) Then Return Nothing

        Dim fornecedor As New Fornecedor()

        fornecedor.ID = dt.Rows(0).Item("Id")
        fornecedor.RazaoSocial = dt.Rows(0).Item("RazaoSocial")
        fornecedor.CNPJ = dt.Rows(0).Item("CNPJ")
        fornecedor.Endereco = dt.Rows(0).Item("Endereco")
        fornecedor.Telefone = dt.Rows(0).Item("Telefone")

        Return fornecedor
    End Function
End Class
