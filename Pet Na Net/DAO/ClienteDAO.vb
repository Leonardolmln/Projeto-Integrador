Imports System.Text

Public Class ClienteDAO
    Public Function Insert(ByVal cliente As Cliente) As Boolean
        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Insert INTO Clientes(Nome, CPF, InicioRelacionamento, Desconto, TipoCliente, Endereco, Telefone) ")
        strSQL.Append("VALUES(@nome, @cpf, @relac, @desc, @tipo, @end, @tel);")

        conn.AddParameter("@nome", cliente.Nome)
        conn.AddParameter("@cpf", CleanString(cliente.CPF))
        conn.AddParameter("@relac", CDate(cliente.InicioRelacionamento))
        conn.AddParameter("@desc", cliente.Desconto)
        conn.AddParameter("@tipo", cliente.TipoCliente)
        conn.AddParameter("@end", cliente.Endereco)
        conn.AddParameter("@tel", cliente.Telefone)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function Update(ByVal cliente As Cliente) As Boolean

        Dim conn As New Connection
        Dim strSQL As New StringBuilder

        strSQL.Append("Update Clientes ")
        strSQL.Append("SET Nome = @nome, ")
        strSQL.Append("CPF = @cpf, ")
        strSQL.Append("InicioRelacionamento = @relac, ")
        strSQL.Append("Desconto = @desc, ")
        strSQL.Append("Endereco = @end, ")
        strSQL.Append("Telefone = @tel, ")
        strSQL.Append("Status = @sts, ")
        strSQL.Append("TipoCliente = @tipo ")
        strSQL.Append("WHERE Id = @id;")

        conn.AddParameter("@nome", cliente.Nome)
        conn.AddParameter("@cpf", CleanString(cliente.CPF))
        conn.AddParameter("@relac", CDate(cliente.InicioRelacionamento))
        conn.AddParameter("@desc", cliente.Desconto)
        conn.AddParameter("@tipo", cliente.TipoCliente)
        conn.AddParameter("@id", cliente.ID)
        conn.AddParameter("@end", cliente.Endereco)
        conn.AddParameter("@tel", cliente.Telefone)
        conn.AddParameter("@sts", cliente.Status)

        Return conn.ExecuteCommand(strSQL.ToString)

    End Function

    Public Function FindAll() As List(Of Cliente)
        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes;")

        Dim clientes As New List(Of Cliente)

        For Each row As DataRow In dt.Rows
            Dim cliente As New Cliente()
            cliente.ID = row.Item("Id")
            cliente.Nome = row.Item("Nome")
            cliente.CPF = row.Item("CPF")
            cliente.InicioRelacionamento = row.Item("InicioRelacionamento")
            cliente.Desconto = row.Item("Desconto")
            cliente.TipoCliente = row.Item("TipoCliente")
            cliente.Endereco = row.Item("Endereco")
            cliente.Telefone = row.Item("Telefone")
            cliente.Status = row.Item("Status")
            clientes.Add(cliente)
        Next

        Return clientes

    End Function

    Public Function FindByID(ByVal id As Integer) As Cliente
        If (id = 0) Then Return Nothing

        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE ID = @id")

        Dim cliente As New Cliente()

        cliente.ID = dt.Rows(0).Item("Id")
        cliente.Nome = dt.Rows(0).Item("Nome")
        cliente.CPF = dt.Rows(0).Item("CPF")
        cliente.InicioRelacionamento = dt.Rows(0).Item("InicioRelacionamento")
        cliente.Desconto = dt.Rows(0).Item("Desconto")
        cliente.TipoCliente = dt.Rows(0).Item("TipoCliente")
        cliente.Pets = daoInstance.FindByIDCliente(cliente.ID)
        cliente.Endereco = dt.Rows(0).Item("Endereco")
        cliente.Telefone = dt.Rows(0).Item("Telefone")
        cliente.Status = dt.Rows(0).Item("Status")

        Return cliente
    End Function

    Public Function FindByCPF(ByVal cpf As String) As Cliente

        If (String.IsNullOrWhiteSpace(cpf)) Then Return Nothing

        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        conn.AddParameter("@cpf", CleanString(cpf))

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE CPF = @cpf")

        If (dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New Cliente()

        cliente.ID = dt.Rows(0).Item("Id")
        cliente.Nome = dt.Rows(0).Item("Nome")
        cliente.CPF = dt.Rows(0).Item("CPF")
        cliente.InicioRelacionamento = dt.Rows(0).Item("InicioRelacionamento")
        cliente.Desconto = dt.Rows(0).Item("Desconto")
        cliente.TipoCliente = dt.Rows(0).Item("TipoCliente")
        cliente.Pets = daoInstance.FindByIDCliente(cliente.ID)
        cliente.Endereco = dt.Rows(0).Item("Endereco")
        cliente.Telefone = dt.Rows(0).Item("Telefone")
        cliente.Status = dt.Rows(0).Item("Status")

        Return cliente
    End Function

    Public Function FindByNome(ByVal nome As String) As Cliente
        If (String.IsNullOrWhiteSpace(nome)) Then Return Nothing
        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        conn.AddParameter("@nome", nome)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM Clientes WHERE Nome = @nome")

        If (dt.Rows.Count = 0) Then Return Nothing

        Dim cliente As New Cliente()

        cliente.ID = dt.Rows(0).Item("Id")
        cliente.Nome = dt.Rows(0).Item("Nome")
        cliente.CPF = dt.Rows(0).Item("CPF")
        cliente.InicioRelacionamento = dt.Rows(0).Item("InicioRelacionamento")
        cliente.Desconto = dt.Rows(0).Item("Desconto")
        cliente.TipoCliente = dt.Rows(0).Item("TipoCliente")
        cliente.Pets = daoInstance.FindByIDCliente(cliente.ID)
        cliente.Endereco = dt.Rows(0).Item("Endereco")
        cliente.Telefone = dt.Rows(0).Item("Telefone")
        cliente.Status = dt.Rows(0).Item("Status")

        Return cliente
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Clientes WHERE ID = @id")
    End Function
End Class
