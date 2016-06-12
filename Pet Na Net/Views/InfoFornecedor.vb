Public Class InfoFornecedor

    Private FornecedorDAOInstance As New FornecedorDAO

    Private Sub InfoFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InfoCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        UpdateInfo()
    End Sub

    Public Sub UpdateInfo()
        BuscaFornecedor.currentFornecedor = FornecedorDAOInstance.FindByID(BuscaFornecedor.currentFornecedor.ID)
        
        IDTF.Text = BuscaFornecedor.currentFornecedor.ID
        NomeTF.Text = BuscaFornecedor.currentFornecedor.RazaoSocial
        CNPJTF.Text = BuscaFornecedor.currentFornecedor.CNPJ
        EnderecoTF.Text = BuscaFornecedor.currentFornecedor.Endereco
        TelefoneMTF.Text = BuscaFornecedor.currentFornecedor.Telefone
    End Sub

End Class