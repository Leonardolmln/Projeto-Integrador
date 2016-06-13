Imports System.Globalization
Imports System.Data.Sql

Public Class CadastroPet

    Private cliente As Cliente
    Private ClienteDAOInstance As New ClienteDAO
    Private PetBCInstance As New PetBC
    Private PetDAOInstance As New PetDAO

    Public Sub New(cliente As Cliente)
        InitializeComponent()
        Me.cliente = cliente
        cliente.ID = ClienteDAOInstance.FindByCPF(cliente.CPF).ID
        ClienteIDLB.Text = cliente.ID
    End Sub

    Private Sub CadastrarPetBT_Click(sender As Object, e As EventArgs) Handles CadastrarPetBT.Click

        If (String.IsNullOrWhiteSpace(NomePetTF.Text)) Then
            MsgBox("Nome do Pet não informado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim pet As New Pet(NomePetTF.Text, NascimentoMTF.Text, Me.cliente, TipoPetCB.Text)

        If (PetBCInstance.ValidateForModification(pet) = True) Then
            Dim result As Boolean = PetDAOInstance.Insert(pet)
            If (result = True) Then
                Try
                    BuscaCliente.currentCliente.Pets = PetDAOInstance.FindByIDCliente(ClienteIDLB.Text)
                Catch ex As Exception
                End Try
                InfoCliente.UpdateInfo()
                If (MsgBox("Você Inseriu o Pet " & NomePetTF.Text & " para o Cliente " & cliente.Nome & ". Deseja inserir outro Pet ? ", vbYesNo) <> vbYes) Then
                    InfoCliente.Show()
                    Me.Close()
                Else
                    NascimentoMTF.Text = ""
                    NomePetTF.Text = ""
                End If
            Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
            End If
        Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
        End If
    End Sub

    Private Sub CadastroPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Str As String In TipoPet.GetStatus()
            TipoPetCB.Items.Add(Str)
        Next
    End Sub
End Class