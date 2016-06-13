Public Class CadastroServico

    Private ClienteDAOInstance As New ClienteDAO
    Private FuncionarioDAOInstance As New FuncionarioDAO
    Private ServicoDAOInstance As New ServicoDAO
    Private ServicoBCInstance As New ServicoBC

    Private Sub CadastroServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (BuscaCliente.currentCliente IsNot Nothing) Then
            CPFMTF.Text = BuscaCliente.currentCliente.CPF
        End If
        TipoServico.GetStatus().ForEach(Sub(tipo) TipoCB.Items.Add(tipo))
    End Sub

    Private Sub TipoCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoCB.SelectedIndexChanged
        If (TipoCB.Text = TipoServico.Consulta OrElse TipoCB.Text = TipoServico.ReConsulta) Then
            VeterinarioCB.Items.Clear()
            Dim veterinarios As List(Of Funcionario) = FuncionarioDAOInstance.FindAll()
            For Each veterinario As Funcionario In veterinarios
                If (veterinario.GetType().ToString.Contains("Veterinario")) Then VeterinarioCB.Items.Add(veterinario.Nome)
            Next
            VeterinarioCB.Enabled = True
        Else : VeterinarioCB.Enabled = False
        End If
    End Sub

    Private Sub AdicionarServicoBT_Click(sender As Object, e As EventArgs) Handles AdicionarServicoBT.Click
        If (String.IsNullOrWhiteSpace(TipoCB.Text)) Then
            MsgBox("Tipo do serviço não preenchido")
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(ValorTF.Text)) Then
            MsgBox("Valor do serviço não preenchido")
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(DataServicoMTF.Text)) Then
            MsgBox("Data do serviço não preenchido")
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(CPFMTF.Text)) Then
            MsgBox("CPF do cliente não preenchido")
            Exit Sub
        End If

        If (TipoCB.Text = TipoServico.Consulta OrElse TipoCB.Text = TipoServico.ReConsulta) Then
            If (String.IsNullOrWhiteSpace(VeterinarioCB.Text)) Then
                MsgBox("Veterinário não selecionado")
                Exit Sub
            End If
        End If

        Dim cliente As Cliente = ClienteDAOInstance.FindByCPF(CPFMTF.Text)

        Dim servico As Servico = New Servico(Now, cliente, TipoCB.Text, ValorTF.Text, StatusServico.Agendado, DataServicoMTF.Text)

        If (TipoCB.Text = TipoServico.Consulta OrElse TipoCB.Text = TipoServico.ReConsulta) Then
            servico.Veterinario = FuncionarioDAOInstance.FindByNome(VeterinarioCB.Text)
        End If
            
        If (ServicoBCInstance.ValidateForModification(servico) = True) Then

            If (ServicoDAOInstance.Insert(servico) = True) Then
                MsgBox("Serviço adicionado", vbInformation Or vbMsgBoxSetForeground)
                TipoCB.Text = ""
                VeterinarioCB.Text = ""
                ValorTF.Text = ""
                DataServicoMTF.Text = ""
            Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
            End If
        Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
        End If
    End Sub
End Class