Imports System.Text

Public Class NotaFiscalDAO
    Public Function Insert(ByVal nf As NotaFiscal) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO NotasFiscais(Numero, Emissao) ")
        strSQL.Append("VALUES(@num, @emissao);")

        conn.AddParameter("@num", nf.NumeroNF)
        conn.AddParameter("@emissao", nf.Emissao)
        
        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function Update(ByVal nf As NotaFiscal) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update NotasFiscais ")
        strSQL.Append("SET Numero = @num, ")
        strSQL.Append("Emissao = @emissao ")
        strSQL.Append("WHERE Id = @id;")

        conn.AddParameter("@num", nf.NumeroNF)
        conn.AddParameter("@emissao", nf.Emissao)
        conn.AddParameter("@id", nf.ID)
        
        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function FindAll() As List(Of NotaFiscal)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM NOTASFISCAIS;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim nfs As New List(Of NotaFiscal)
        For Each row As DataRow In dt.Rows
            Dim nf As New NotaFiscal()
            nf.ID = row.Item("Id")
            nf.NumeroNF = row.Item("Numero")
            nf.Emissao = row.Item("Emissao")
            nfs.Add(nf)
        Next
        Return nfs
    End Function

    Public Function FindByID(ByVal id As Integer) As NotaFiscal
        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM NOTASFISCAIS WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim nf As New NotaFiscal()

        nf.ID = dt.Rows(0).Item("Id")
        nf.NumeroNF = dt.Rows(0).Item("Numero")
        nf.Emissao = dt.Rows(0).Item("Emissao")

        Return nf
    End Function

    Public Function FindByNumero(ByVal num As String) As NotaFiscal
        If (String.IsNullOrWhiteSpace(num)) Then Return Nothing
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM NOTASFISCAIS WHERE Numero = @numero;")

        conn.AddParameter("@numero", num)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim nf As New NotaFiscal()

        nf.ID = dt.Rows(0).Item("Id")
        nf.NumeroNF = dt.Rows(0).Item("Numero")
        nf.Emissao = dt.Rows(0).Item("Emissao")

        Return nf
    End Function

    Public Function FindByNumeroForn(ByVal num As String, ByVal razaoSocial As String) As NotaFiscal
        If (String.IsNullOrWhiteSpace(razaoSocial)) Then Return Nothing
        If (String.IsNullOrWhiteSpace(num)) Then Return Nothing
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Select NotasFiscais.Id, NotasFiscais.Numero, NotasFiscais.Emissao From NotasFiscais ")
        query.Append("Inner Join Movimentos On NotasFiscais.Id = Movimentos.IdNotaFiscal ")
        query.Append("Inner Join Fornecedores On Movimentos.IdFornecedor = Fornecedores.Id ")
        query.Append("Where Fornecedores.RazaoSocial = @razSoc And NotasFiscais.Numero = @numNF")

        conn.AddParameter("@numNF", num)
        conn.AddParameter("@razSoc", razaoSocial)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim nf As New NotaFiscal()

        nf.ID = dt.Rows(0).Item("Id")
        nf.NumeroNF = dt.Rows(0).Item("Numero")
        nf.Emissao = dt.Rows(0).Item("Emissao")

        Return nf
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM NotasFiscais WHERE ID = @id")
    End Function

End Class
