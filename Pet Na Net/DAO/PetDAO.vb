Imports System.Text

Public Class PetDAO
    Public Function Insert(ByVal pet As Pet) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Insert INTO Pets(Nome, Nascimento, IDCliente, TipoPet) ")
        query.Append("VALUES(@nome, @nasc, @idDono, @tipo)")

        conn.AddParameter("@nome", pet.Nome)
        conn.AddParameter("@nasc", pet.Nascimento)
        conn.AddParameter("@idDono", pet.Dono.ID)
        conn.AddParameter("@tipo", pet.TipoPet)

        Return conn.ExecuteCommand(query.ToString)

    End Function

    Public Function Update(ByVal pet As Pet) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Update PETS ")
        query.Append("SET Nome = @nome, ")
        query.Append("Nascimento = @nasc, ")
        query.Append("IDCliente = @idDono, ")
        query.Append("TipoPet = @tipo ")
        query.Append("WHERE Id = @id;")

        conn.AddParameter("@nome", pet.Nome)
        conn.AddParameter("@nasc", pet.Nascimento)
        conn.AddParameter("@idDono", pet.Dono.ID)
        conn.AddParameter("@tipo", pet.TipoPet)
        conn.AddParameter("@id", pet.ID)

        Return conn.ExecuteCommand(query.ToString)

        Return False

    End Function

    Public Function FindAll() As List(Of Pet)
        Dim conn As New Connection

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM PETS;")

        Dim pets As New List(Of Pet)

        For Each row As DataRow In dt.Rows
            Dim pet As New Pet()
            pet.ID = row.Item("Id")
            pet.Nome = row.Item("Nome")
            pet.Nascimento = row.Item("CPF")
            pet.TipoPet = row.Item("TipoPet")
            pets.Add(pet)
            'Inner JOIN -> Fazer PETS / Clientes
        Next

        Return pets
    End Function

    Public Function FindByIDCliente(idCliente As Long) As List(Of Pet)
        If (idCliente = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", idCliente)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM PETS WHERE IDCliente = @id")

        Dim pets As New List(Of Pet)

        For Each row As DataRow In dt.Rows
            Dim pet As New Pet()
            pet.ID = row.Item("Id")
            pet.Nome = row.Item("Nome")
            pet.Nascimento = row.Item("Nascimento")
            pet.TipoPet = row.Item("TipoPet")
            pets.Add(pet)
            'Inner JOIN -> Fazer PETS / Clientes
        Next

        Return pets
    End Function

    Public Function FindByID(ByVal id As Integer) As Pet
        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT * FROM PETS WHERE ID = @id")

        Dim pet As New Pet()

        pet.ID = dt.Rows(0).Item("Id")
        pet.Nome = dt.Rows(0).Item("Nome")
        pet.Nascimento = dt.Rows(0).Item("CPF")
        pet.TipoPet = dt.Rows(0).Item("TipoPet")
        'Inner JOIN -> Fazer PETS / Clientes

        Return pet
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Pets WHERE ID = @id")
    End Function

End Class
