Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Public Class FuncionarioDAO
    Public Function Insert(ByVal funcionario As Funcionario) As Boolean

        If (FindByMatricula(funcionario.Matricula) IsNot Nothing) Then Return False

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Insert INTO FUNCIONARIOS (Nome, CPF, Matricula, Perfil, Salario, Senha) ")
        query.Append("VALUES(@nome, @cpf, @matricula, @perfil, @salario, @senha)")

        conn.AddParameter("@nome", funcionario.Nome)
        conn.AddParameter("@cpf", CleanString(funcionario.CPF))
        conn.AddParameter("@matricula", funcionario.Matricula)
        conn.AddParameter("@perfil", funcionario.Perfil)
        conn.AddParameter("@salario", funcionario.Salario)
        conn.AddParameter("@senha", funcionario.Senha)

        Return conn.ExecuteCommand(query.ToString)

    End Function

    Public Function Insert(ByVal veterinario As Veterinario) As Boolean

        If (FindByMatricula(veterinario.Matricula) IsNot Nothing) Then Return False

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Insert INTO FUNCIONARIOS (Nome, CPF, Matricula, Perfil, Salario, CRMV, ValidadeCRMV, Senha) ")
        query.Append("VALUES(@nome, @cpf, @matricula, @perfil, @salario, @crmv, @validCRMV, @senha)")

        conn.AddParameter("@nome", veterinario.Nome)
        conn.AddParameter("@cpf", CleanString(veterinario.CPF))
        conn.AddParameter("@matricula", veterinario.Matricula)
        conn.AddParameter("@perfil", veterinario.Perfil)
        conn.AddParameter("@salario", veterinario.Salario)
        conn.AddParameter("@crmv", veterinario.CRMV)
        conn.AddParameter("@validCRMV", veterinario.ValidadeCRMV)
        conn.AddParameter("@senha", veterinario.Senha)

        Return conn.ExecuteCommand(query.ToString)

    End Function

    Public Function Update(ByVal funcionario As Funcionario) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Update FUNCIONARIOS ")
        query.Append("SET Nome = @nome, ")
        query.Append("SET CPF = @cpf, ")
        query.Append("SET Matricula = @matricula, ")
        query.Append("SET Perfil = @perfil, ")
        query.Append("SET Salario = @salario ")
        query.Append("WHERE Id = @id;")

        conn.AddParameter("@nome", funcionario.Nome)
        conn.AddParameter("@cpf", CleanString(funcionario.CPF))
        conn.AddParameter("@matricula", funcionario.Matricula)
        conn.AddParameter("@perfil", funcionario.Perfil)
        conn.AddParameter("@salario", funcionario.Salario)
        conn.AddParameter("@id", funcionario.ID)

        Return conn.ExecuteCommand(query.ToString)

        Return False

    End Function

    Public Function Update(ByVal veterinario As Veterinario) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Update FUNCIONARIOS ")
        query.Append("SET Nome = @nome, ")
        query.Append("SET CPF = @cpf, ")
        query.Append("SET Matricula = @matricula, ")
        query.Append("SET Perfil = @perfil, ")
        query.Append("SET Salario = @salario, ")
        query.Append("SET CRMV = @crmv, ")
        query.Append("SET ValidadeCRMV = @validCRMV ")
        query.Append("WHERE Id = @id;")
        conn.AddParameter("@nome", veterinario.Nome)
        conn.AddParameter("@cpf", CleanString(veterinario.CPF))
        conn.AddParameter("@matricula", veterinario.Matricula)
        conn.AddParameter("@perfil", veterinario.Perfil)
        conn.AddParameter("@salario", veterinario.Salario)
        conn.AddParameter("@crmv", veterinario.CRMV)
        conn.AddParameter("@validCRMV", veterinario.ValidadeCRMV)
        conn.AddParameter("@id", veterinario.ID)

        Return conn.ExecuteCommand(query.ToString)

        Return False

    End Function

    Public Function UpdatePerfil(ByVal funcionario As Funcionario) As Boolean

        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("Update FUNCIONARIOS ")
        query.Append("SET Perfil = @perfil ")
        query.Append("WHERE Id = @id;")

        conn.AddParameter("@perfil", funcionario.Perfil)
        conn.AddParameter("@id", funcionario.ID)

        Return conn.ExecuteCommand(query.ToString)

        Return False

    End Function

    Public Function FindAll() As List(Of Funcionario)
        Dim conn As New Connection

        Dim query As New StringBuilder
        query.Append("SELECT * FROM FUNCIONARIOS;")
        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)
        Dim funcionarios As New List(Of Funcionario)
        For Each row As DataRow In dt.Rows
            Dim funcionario As New Funcionario()
            funcionario.ID = row.Item("Id")
            funcionario.Nome = row.Item("Nome")
            funcionario.CPF = row.Item("CPF")
            funcionario.Matricula = row.Item("Matricula")
            funcionario.Perfil = row.Item("Perfil")
            funcionario.Salario = row.Item("Salario")

            If (funcionario.Perfil = TipoFuncionario.Veterinario) Then
                Dim vet As New Veterinario(funcionario.ID, funcionario.CPF, funcionario.Nome, funcionario.Matricula, funcionario.Salario, row.Item("CRMV"), row.Item("ValidadeCRMV"))
                funcionarios.Add(vet)
            Else : funcionarios.Add(funcionario)
            End If

        Next
        Return funcionarios
    End Function

    Public Function FindByID(ByVal id As Integer) As Funcionario
        If (id = 0) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder

        query.Append("SELECT * FROM FUNCIONARIOS WHERE ID = @id;")

        conn.AddParameter("@id", id)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing) Then Return Nothing
        If (dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario

        funcionario.ID = dt.Rows(0).Item("Id")
        funcionario.Nome = dt.Rows(0).Item("Nome")
        funcionario.CPF = dt.Rows(0).Item("CPF")
        funcionario.Matricula = dt.Rows(0).Item("Matricula")
        funcionario.Perfil = dt.Rows(0).Item("Perfil")
        funcionario.Salario = dt.Rows(0).Item("Salario")

        If (funcionario.Perfil = TipoFuncionario.Veterinario) Then
            Dim vet As New Veterinario(funcionario.ID, funcionario.CPF, funcionario.Nome, funcionario.Matricula, funcionario.Salario, dt.Rows(0).Item("CRMV"), dt.Rows(0).Item("ValidadeCRMV"))
            Return vet
        Else : Return funcionario
        End If

    End Function

    Public Function FindByMatricula(ByVal mat As String) As Funcionario

        If (String.IsNullOrWhiteSpace(mat)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder

        query.Append("SELECT * FROM FUNCIONARIOS WHERE Matricula = @mat;")

        conn.AddParameter("@mat", mat)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing) Then Return Nothing
        If (dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario

        funcionario.ID = dt.Rows(0).Item("Id")
        funcionario.Nome = dt.Rows(0).Item("Nome")
        funcionario.CPF = dt.Rows(0).Item("CPF")
        funcionario.Matricula = dt.Rows(0).Item("Matricula")
        funcionario.Perfil = dt.Rows(0).Item("Perfil")
        funcionario.Salario = dt.Rows(0).Item("Salario")

        If (funcionario.Perfil = TipoFuncionario.Veterinario) Then
            Dim vet As New Veterinario(funcionario.ID, funcionario.CPF, funcionario.Nome, funcionario.Matricula, funcionario.Salario, dt.Rows(0).Item("CRMV"), dt.Rows(0).Item("ValidadeCRMV"))
            Return vet
        Else : Return funcionario
        End If

    End Function

    Public Function FindByCPF(ByVal cpf As String) As Funcionario

        If (String.IsNullOrWhiteSpace(cpf)) Then Return Nothing
        Dim conn As New Connection

        Dim query As New StringBuilder

        query.Append("SELECT * FROM FUNCIONARIOS WHERE CPF = @cpf;")

        conn.AddParameter("@cpf", CleanString(cpf))

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing) Then Return Nothing
        If (dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario

        funcionario.ID = dt.Rows(0).Item("Id")
        funcionario.Nome = dt.Rows(0).Item("Nome")
        funcionario.CPF = dt.Rows(0).Item("CPF")
        funcionario.Matricula = dt.Rows(0).Item("Matricula")
        funcionario.Perfil = dt.Rows(0).Item("Perfil")
        funcionario.Salario = dt.Rows(0).Item("Salario")

        If (funcionario.Perfil = TipoFuncionario.Veterinario) Then
            Dim vet As New Veterinario(funcionario.ID, funcionario.CPF, funcionario.Nome, funcionario.Matricula, funcionario.Salario, dt.Rows(0).Item("CRMV"), dt.Rows(0).Item("ValidadeCRMV"))
            Return vet
        Else : Return funcionario
        End If

    End Function

    Public Function FindByNome(ByVal nome As String) As Funcionario

        If (String.IsNullOrWhiteSpace(nome)) Then Return Nothing

        Dim conn As New Connection

        Dim query As New StringBuilder

        query.Append("SELECT * FROM FUNCIONARIOS WHERE Nome = @nome;")

        conn.AddParameter("@nome", nome)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing) Then Return Nothing
        If (dt.Rows.Count = 0) Then Return Nothing

        Dim funcionario As New Funcionario

        funcionario.ID = dt.Rows(0).Item("Id")
        funcionario.Nome = dt.Rows(0).Item("Nome")
        funcionario.CPF = dt.Rows(0).Item("CPF")
        funcionario.Matricula = dt.Rows(0).Item("Matricula")
        funcionario.Perfil = dt.Rows(0).Item("Perfil")
        funcionario.Salario = dt.Rows(0).Item("Salario")

        If (funcionario.Perfil = TipoFuncionario.Veterinario) Then
            Dim vet As New Veterinario(funcionario.ID, funcionario.CPF, funcionario.Nome, funcionario.Matricula, funcionario.Salario, dt.Rows(0).Item("CRMV"), dt.Rows(0).Item("ValidadeCRMV"))
            Return vet
        Else : Return funcionario
        End If

    End Function

    Public Function FindByCRMV(ByVal crmv As String) As Veterinario

        If (String.IsNullOrWhiteSpace(crmv)) Then Return Nothing
        Dim conn As New Connection

        Dim query As New StringBuilder

        query.Append("SELECT * FROM FUNCIONARIOS WHERE CRMV = @crmv;")

        conn.AddParameter("@crmv", crmv)

        Dim dt As DataTable = conn.ExecuteSelect(query.ToString)

        If (dt Is Nothing) Then Return Nothing
        If (dt.Rows.Count = 0) Then Return Nothing

        Dim veterinario As New Veterinario

        veterinario.ID = dt.Rows(0).Item("Id")
        veterinario.Nome = dt.Rows(0).Item("Nome")
        veterinario.CPF = dt.Rows(0).Item("CPF")
        veterinario.Matricula = dt.Rows(0).Item("Matricula")
        veterinario.Perfil = dt.Rows(0).Item("Perfil")
        veterinario.Salario = dt.Rows(0).Item("Salario")
        veterinario.CRMV = dt.Rows(0).Item("CRMV")
        veterinario.ValidadeCRMV = dt.Rows(0).Item("ValidadeCRMV")
        Return veterinario

    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim conn As New Connection

        conn.AddParameter("@id", id)

        Return conn.ExecuteCommand("DELETE FROM Funcionarios WHERE ID = @id")
    End Function

    Public Function VerifyPassword(ByVal func As Funcionario) As Boolean
        Dim conn As New Connection
        Dim daoInstance As New PetDAO

        If (func.Matricula Is Nothing) Then Return False

        conn.AddParameter("@mat", func.Matricula)

        Dim dt As DataTable = conn.ExecuteSelect("SELECT Senha FROM Funcionarios WHERE Matricula = @mat")

        If (dt Is Nothing) Then Return False

        If (dt.Rows.Count = 0) Then Return False

        If (func.Senha.Equals(dt.Rows(0).Item("Senha"))) Then Return True

        Return False
    End Function
End Class
