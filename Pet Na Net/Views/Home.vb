Public Class Home

    Public Shared CurrentUser As Funcionario

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatriculaLB.Text = CurrentUser.Matricula
        NomeLB.Text = Strings.Split(CurrentUser.Nome)(0)
        PerfilLB.Text = CurrentUser.Perfil

        Select Case CurrentUser.Perfil
            Case "Gerente"
                EstoqueGB.Enabled = True
                ClienteGB.Enabled = True
                ServicoGB.Enabled = True
                AcessoGB.Enabled = True
            Case "Assistente Administrativo"
                EstoqueGB.Enabled = True
                ClienteGB.Enabled = True
                ServicoGB.Enabled = True
            Case "Almoxarife"
                EstoqueGB.Enabled = True
                ClienteGB.Enabled = True
            Case "Veterinário"
                ClienteGB.Enabled = True
                ServicoGB.Enabled = True
        End Select

    End Sub

    Private Sub BuscaPanel_Click(sender As Object, e As EventArgs) Handles BuscaPanel.Click, BuscaIMG.Click, BuscaLB.Click
        BuscaCliente.Show()
    End Sub

    Private Sub NovoPanel_Click(sender As Object, e As EventArgs) Handles NovoPanel.Click, NovoIMG.Click, NovoLB.Click
        CadastroCliente.Show()
    End Sub

    Private Sub BuscaFornPanel_Click(sender As Object, e As EventArgs) Handles BuscaFornPanel.Click, BuscaFornIMG.Click, BuscaFornLB.Click
        BuscaFornecedor.Show()
    End Sub

    Private Sub NovoFornPanel_Click(sender As Object, e As EventArgs) Handles NovoFornPanel.Click, NovoFornIMG.Click, NovoFornLB.Click
        CadastroFornecedor.Show()
    End Sub

    Private Sub NovaNFPanel_Click(sender As Object, e As EventArgs) Handles NovaNFPanel.Click, NovaNFIMG.Click, NovaNFLB.Click
        CadastroNF.Show()
    End Sub

    Private Sub BuscaNFPanel_Click(sender As Object, e As EventArgs) Handles BuscarNFPanel.Click, BuscarNFIMG.Click, BuscarNFLB.Click
        BuscaNF.Show()
    End Sub

    Private Sub IncluirFuncLB_Click(sender As Object, e As EventArgs) Handles IncluirFuncPanel.Click, IncluirFuncIMG.Click, IncluirFuncLB.Click
        CadastroFuncionario.Show()
    End Sub

    Private Sub AlterarPerfilLB_Click(sender As Object, e As EventArgs) Handles AlterarPerfilPanel.Click, AlterarPerfilIMG.Click, AlterarPerfilLB.Click
        AlterarPerfil.Show()
    End Sub

    Private Sub BuscaServLB_Click(sender As Object, e As EventArgs) Handles BuscaServLB.Click, BuscaServPanel.Click, BuscaServIMG.Click
        BuscaServico.Show()
    End Sub

    Private Sub NovoServLB_Click(sender As Object, e As EventArgs) Handles NovoServLB.Click, NovoServPanel.Click, NovoServIMG.Click
        CadastroServico.Show()
    End Sub

    Private Sub FinalizarServLB_Click(sender As Object, e As EventArgs)

    End Sub
End Class