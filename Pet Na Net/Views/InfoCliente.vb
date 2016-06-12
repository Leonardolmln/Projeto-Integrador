Public Class InfoCliente

    Private ClienteDAOInstance As New ClienteDAO
    Private ClienteBCInstance As New ClienteBC
    Private PetDAOInstance As New PetDAO

    Private Sub InfoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InfoCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TipoPetCB.Items.Clear()
        For Each Str As String In TipoPet.GetStatus()
            TipoPetCB.Items.Add(Str)
        Next
        UpdateInfo()
    End Sub

    Public Sub UpdateInfo()
        BuscaCliente.currentCliente = ClienteDAOInstance.FindByID(BuscaCliente.currentCliente.ID)
        BuscaCliente.currentCliente.updateTipoCliente()
        BuscaCliente.currentCliente.updateDesconto()

        IDTF.Text = BuscaCliente.currentCliente.ID
        NomeTF.Text = BuscaCliente.currentCliente.Nome
        CPFMTF.Text = BuscaCliente.currentCliente.CPF
        StatusTF.Text = BuscaCliente.currentCliente.Status
        EnderecoTF.Text = BuscaCliente.currentCliente.Endereco
        TelefoneMTF.Text = BuscaCliente.currentCliente.Telefone
        InicRelacTF.Text = BuscaCliente.currentCliente.InicioRelacionamento
        TipoTF.Text = [Enum].GetName(TipoCliente.Gold.GetType, BuscaCliente.currentCliente.TipoCliente)
        DescontoTF.Text = BuscaCliente.currentCliente.Desconto

        If (BuscaCliente.currentCliente.Pets.Count = 0) Then
            NomePetTF.Enabled = False
            NascTF.Enabled = False
            TipoPetCB.Enabled = False
            PetCB.Enabled = False
            PetCB.Items.Clear()
            PetCB.Text = "Sem Pets Para Visualização"
            NomePetTF.Text = ""
            NascTF.Text = ""
            TipoPetCB.Text = ""
        Else
            NomePetTF.Enabled = True
            NascTF.Enabled = True
            TipoPetCB.Enabled = True
            PetCB.Enabled = True
            PetCB.Items.Clear()

            BuscaCliente.currentCliente.Pets.ForEach(Sub(pet) PetCB.Items.Add(pet.Nome))

            NomePetTF.Text = BuscaCliente.currentCliente.Pets(0).Nome
            NascTF.Text = BuscaCliente.currentCliente.Pets(0).Nascimento
            TipoPetCB.Text = BuscaCliente.currentCliente.Pets(0).TipoPet
            PetCB.Text = BuscaCliente.currentCliente.Pets(0).Nome
        End If

        ClienteDAOInstance.Update(BuscaCliente.currentCliente)

    End Sub

    Private Sub AddPetIMG_Click(sender As Object, e As EventArgs) Handles AddPetIMG.Click
        Dim cadPet As New CadastroPet(BuscaCliente.currentCliente)
        cadPet.Show()
    End Sub

    Private Sub PetCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PetCB.SelectedIndexChanged
        If (PetCB.Text = "") Then
            NomePetTF.Text = ""
            NascTF.Text = ""
            TipoPetCB.Text = ""
        Else
            Dim pet As Pet = BuscaCliente.currentCliente.Pets.Find(Function(obj) obj.Nome = PetCB.Text)
            NomePetTF.Text = pet.Nome
            NascTF.Text = pet.Nascimento
            TipoPetCB.Text = pet.TipoPet
        End If
    End Sub

    Private Sub DeletePetIMG_Click(sender As Object, e As EventArgs) Handles DeletePetIMG.Click
        If (MsgBox("Deseja mesmo excluir o pet do cadastro do cliente ?", vbYesNo) = vbYes) Then
            Dim pet As Pet = BuscaCliente.currentCliente.Pets.Find(Function(obj) obj.Nome = PetCB.Text)
            PetDAOInstance.Delete(pet.ID)
            UpdateInfo()
        End If
    End Sub

    Private Sub AtualizarBT_Click(sender As Object, e As EventArgs) Handles AtualizarBT.Click
        Dim updtCliente As New Cliente

        updtCliente.ID = IDTF.Text
        updtCliente.Nome = NomeTF.Text
        updtCliente.CPF = CPFMTF.Text
        updtCliente.Status = StatusTF.Text
        updtCliente.Endereco = EnderecoTF.Text
        updtCliente.Telefone = TelefoneMTF.Text
        updtCliente.InicioRelacionamento = InicRelacTF.Text
        updtCliente.TipoCliente = [Enum].Parse(TipoCliente.Gold.GetType, TipoTF.Text)

        If (ClienteBCInstance.ValidateForModification(updtCliente) = True) Then

            If (ClienteDAOInstance.Update(updtCliente) = True) Then
                Me.UpdateInfo()
                MsgBox("Atualização efetuada", vbInformation)
            Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
            End If
        Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
        End If

    End Sub

    Private Sub CancelarIMG_Click(sender As Object, e As EventArgs) Handles CancelarIMG.Click
        If (MsgBox("A ação a seguir realizará o cancelamento do relacionamento com o cliente." & Chr(10) & _
                   "As informações serão mantidas, porém o status do cadastro se tornará Cancelado" & Chr(10) & _
                   "Deseja mesmo cancelar o relacionamento ?", vbYesNo) = vbYes) Then
            BuscaCliente.currentCliente.Status = StatusCadastro.CancelLoja

            If (ClienteBCInstance.ValidateForModification(BuscaCliente.currentCliente) = True) Then

                If (ClienteDAOInstance.Update(BuscaCliente.currentCliente) = True) Then
                    Me.UpdateInfo()
                    MsgBox("Atualização efetuada", vbInformation)
                Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
                End If
            Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
            End If

        End If
    End Sub
End Class