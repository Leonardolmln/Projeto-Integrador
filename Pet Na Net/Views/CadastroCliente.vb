Public Class CadastroCliente

    Public ClienteBCInstance As New ClienteBC
    Public ClienteDAOInstance As New ClienteDAO

    Private Sub CadastroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CadastrarClienteBT_Click(sender As Object, e As EventArgs) Handles CadastrarClienteBT.Click

        If (NomeTF.Text = "") Then
            MsgBox("Nome do cliente não preenchido")
            Exit Sub
        End If

        If (CPFMTF.Text = "") Then
            MsgBox("CPF do cliente não preenchido")
            Exit Sub
        End If

        If (EnderecoTF.Text = "") Then
            MsgBox("Endereço do cliente não preenchido")
            Exit Sub
        End If

        If (TelefoneMTF.Text = "") Then
            MsgBox("Telefone do cliente não preenchido")
            Exit Sub
        End If

        Dim cliente As Cliente = New Cliente(NomeTF.Text, CPFMTF.Text, EnderecoTF.Text, TelefoneMTF.Text)

        If (ClienteDAOInstance.FindByCPF(CPFMTF.Text) IsNot Nothing) Then

            If (MsgBox("Este CPF já está cadastrado no banco de dados, deseja ir até a tela de cadastro desse cliente", vbYesNo) = vbYes) Then
                BuscaCliente.currentCliente = ClienteDAOInstance.FindByCPF(CPFMTF.Text)
                InfoCliente.Show()
            Else : MsgBox("Inclusão não efetuada", vbCritical)
            End If

            Exit Sub
        End If

        If (ClienteBCInstance.ValidateForModification(cliente) = True) Then

            If (ClienteDAOInstance.Insert(cliente) = True) Then
                BuscaCliente.currentCliente = ClienteDAOInstance.FindByCPF(CPFMTF.Text)

                If (MsgBox("Cliente Inserido no cadastro, deseja cadastrar Pets para este cliente ?", vbYesNo) = vbYes) Then
                    Me.Hide()
                    Dim CadastroPet As New CadastroPet(cliente)
                    CadastroPet.Show()
                Else : InfoCliente.Show()
                End If

                NomeTF.Text = ""
                CPFMTF.Text = ""
                EnderecoTF.Text = ""
                TelefoneMTF.Text = ""
            Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
            End If
        Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
        End If

    End Sub

    Private Sub CPFMTF_LostFocus(sender As Object, e As EventArgs) Handles CPFMTF.LostFocus
        If (CleanString(CPFMTF.Text) <> "") Then CPFMTF.Text = AddZeros(CleanString(CPFMTF.Text))
    End Sub

End Class
