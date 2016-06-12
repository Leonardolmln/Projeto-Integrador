Public Class AlterarPerfil

    Public Shared currentFuncionario As Funcionario
    Public Shared funcionarioDAO As New FuncionarioDAO

    Private Sub AlterarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoFuncionario.GetStatus().ForEach(Sub(sts) PerfilCB.Items.Add(sts))
    End Sub

    Private Sub AlterarPerfil_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        currentFuncionario = Nothing
    End Sub

    Private Sub CPFMTF_LostFocus(sender As Object, e As EventArgs) Handles CPFMTF.LostFocus
        If (CleanString(CPFMTF.Text) <> "") Then CPFMTF.Text = AddZeros(CleanString(CPFMTF.Text))
    End Sub

    Private Sub CPFRB_CheckedChanged(sender As Object, e As EventArgs) Handles CPFRB.CheckedChanged
        If (CPFRB.Checked = True) Then
            CPFMTF.Enabled = True
        Else : CPFMTF.Enabled = False
        End If
    End Sub

    Private Sub NomeRB_CheckedChanged(sender As Object, e As EventArgs) Handles NomeRB.CheckedChanged
        If (NomeRB.Checked = True) Then
            NomeTF.Enabled = True
        Else : NomeTF.Enabled = False
        End If
    End Sub

    Private Sub MatriculaRB_CheckedChanged(sender As Object, e As EventArgs) Handles MatriculaRB.CheckedChanged
        If (MatriculaRB.Checked = True) Then
            MatriculaMTF.Enabled = True
        Else : MatriculaMTF.Enabled = False
        End If
    End Sub

    Private Sub CadastrarClienteBT_Click(sender As Object, e As EventArgs) Handles CadastrarClienteBT.Click
        Try
            If (NomeRB.Checked = True) Then : currentFuncionario = funcionarioDAO.FindByNome(NomeTF.Text)
            ElseIf (MatriculaRB.Checked = True) Then : currentFuncionario = funcionarioDAO.FindByMatricula(MatriculaMTF.Text)
            Else : currentFuncionario = funcionarioDAO.FindByCPF(CPFMTF.Text)
            End If

            If (currentFuncionario Is Nothing) Then
                MsgBox("Não foi encontrado nenhum cliente com a pesquisa realizada", vbInformation)
                Exit Sub
            Else
                FuncionarioLB.Text = currentFuncionario.Matricula + " - " + currentFuncionario.Nome
                PerfilCB.Text = currentFuncionario.Perfil
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub AlterarPerfilBT_Click(sender As Object, e As EventArgs) Handles AlterarPerfilBT.Click
        If (String.IsNullOrWhiteSpace(PerfilCB.Text)) Then MsgBox("Perfil ñão informado", vbInformation OrElse vbMsgBoxSetForeground)
        If (currentFuncionario Is Nothing) Then MsgBox("Funcionário não foi buscado", vbInformation OrElse vbMsgBoxSetForeground)
        currentFuncionario.Perfil = PerfilCB.Text
        funcionarioDAO.UpdatePerfil(currentFuncionario)
        MsgBox("Perfil do funcionário atualizado", vbInformation OrElse vbMsgBoxSetForeground)
    End Sub
End Class