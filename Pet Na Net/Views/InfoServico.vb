Public Class InfoServico

    Private ServicoDAOInstance As New ServicoDAO
    Private ServicoBCInstance As New ServicoBC

    Private Sub InfoServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoServico.GetStatus().ForEach(Sub(tipo) TipoCB.Items.Add(tipo))
        StatusServico.GetStatus().ForEach(Sub(sts) StatusCB.Items.Add(sts))
    End Sub

    Private Sub InfoServico_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        UpdateInfo()
    End Sub

    Public Sub UpdateInfo()
        BuscaServico.currentServico = ServicoDAOInstance.FindByID(BuscaServico.currentServico.ID)

        IDTF.Text = BuscaServico.currentServico.ID
        CPFMTF.Text = BuscaServico.currentServico.Cliente.CPF
        ValorTF.Text = BuscaServico.currentServico.Valor
        DataCriacaoMTF.Text = BuscaServico.currentServico.DataCriacao
        DataServicoMTF.Text = BuscaServico.currentServico.DataServico
        TipoCB.Text = BuscaServico.currentServico.Tipo
        StatusCB.Text = BuscaServico.currentServico.Status
        If (StatusCB.Text = StatusServico.Cancelado OrElse StatusCB.Text = StatusServico.Finalizado) Then
            StatusCB.Enabled = False
            DataCriacaoMTF.Enabled = False
            ValorTF.Enabled = False
            DataServicoMTF.Enabled = False
        End If
        If (BuscaServico.currentServico.Veterinario IsNot Nothing) Then
            VeterinarioTF.Text = BuscaServico.currentServico.Veterinario.Nome
        End If
    End Sub

    Private Sub AtualizarBT_Click(sender As Object, e As EventArgs) Handles AtualizarBT.Click
        If (String.IsNullOrWhiteSpace(ValorTF.Text)) Then
            MsgBox("Valor do serviço não preenchido")
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(DataServicoMTF.Text)) Then
            MsgBox("Data do serviço não preenchido")
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(StatusCB.Text)) Then
            MsgBox("Status do serviço não preenchido")
            Exit Sub
        End If

        If (StatusCB.Text <> BuscaServico.currentServico.Status) Then
            If (StatusCB.Text = StatusServico.Cancelado) Then
                If (MsgBox("Tem certeza que deseja cancelar o serviço", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbNo) Then
                    Exit Sub
                End If
            ElseIf (StatusCB.Text = StatusServico.Finalizado) Then
                If (MsgBox("Tem certeza que deseja finalizar o serviço", vbYesNo Or vbInformation Or vbMsgBoxSetForeground) = vbNo) Then
                    Exit Sub
                End If
            End If
        End If

        BuscaServico.currentServico.Valor = ValorTF.Text
        BuscaServico.currentServico.DataServico = DataServicoMTF.Text
        BuscaServico.currentServico.Status = StatusCB.Text

        If (ServicoBCInstance.ValidateForModification(BuscaServico.currentServico) = True) Then
            If (ServicoDAOInstance.Update(BuscaServico.currentServico) = True) Then
                Me.UpdateInfo()
                MsgBox("Atualização efetuada", vbInformation Or vbMsgBoxSetForeground)
            Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
            End If
        Else : MsgBox("Um Problema ocorreu durante a validação dos dados do serviço, tente novamente")
        End If

    End Sub
End Class