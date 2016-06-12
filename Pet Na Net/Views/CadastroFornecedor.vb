Public Class CadastroFornecedor

    Public FornecedorBCInstance As New FornecedorBC
    Public FornecedorDAOInstance As New FornecedorDAO


    Private Sub CadastroFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CadastrarFornecedorBT_Click(sender As Object, e As EventArgs) Handles CadastrarFornecedorBT.Click
        If (NomeTF.Text = "") Then
            MsgBox("Razão Social do fornecedor não preenchido")
            Exit Sub
        End If

        If (CNPJMTF.Text = "") Then
            MsgBox("CNPJ do fornecedor não preenchido")
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

        Dim fornecedor As Fornecedor = New Fornecedor(NomeTF.Text, CNPJMTF.Text, EnderecoTF.Text, TelefoneMTF.Text)

        If (FornecedorDAOInstance.FindByCNPJ(CNPJMTF.Text) IsNot Nothing) Then
            Dim answer = MsgBox("Este CNPJ já está cadastrado no banco de dados, deseja ir até a tela de cadastro desse fornecedor ?", vbYesNo)
            If (answer = vbYes) Then
                BuscaFornecedor.currentFornecedor = FornecedorDAOInstance.FindByCNPJ(CNPJMTF.Text)
                InfoFornecedor.Show()
            Else
                MsgBox("Inclusão não efetuada", vbCritical)
            End If
            Exit Sub
        End If

        NomeTF.Text = ""
        CNPJMTF.Text = ""
        EnderecoTF.Text = ""
        TelefoneMTF.Text = ""

        If (FornecedorBCInstance.ValidateForModification(fornecedor) = True) Then
            Dim result As Boolean = FornecedorDAOInstance.Insert(fornecedor)
            If (result = True) Then
                BuscaFornecedor.currentFornecedor = FornecedorDAOInstance.FindByCNPJ(CNPJMTF.Text)
                CadastroNF.UpdateInfo()
                MsgBox("Fornecedor Inserido no cadastro")
            Else
                MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
            End If
        Else
            MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
        End If

    End Sub

End Class