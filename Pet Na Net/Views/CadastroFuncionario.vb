Public Class CadastroFuncionario

    Public FuncionarioBCInstance As New FuncionarioBC
    Public FuncionarioDAOInstance As New FuncionarioDAO

    Private Sub CadastroFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoFuncionario.GetStatus().ForEach(Sub(sts) PerfilCB.Items.Add(sts))
        MatriculaMTF.Text = GenericUtils.GenerateMatricula()
        Do While FuncionarioDAOInstance.FindByMatricula(MatriculaMTF.Text) IsNot Nothing
            MatriculaMTF.Text = GenericUtils.GenerateMatricula()
        Loop
    End Sub

    Private Sub CadastrarFuncionarioBT_Click(sender As Object, e As EventArgs) Handles CadastrarFuncionarioBT.Click

        If (NomeTF.Text = "") Then
            MsgBox("Nome do funcionário não preenchido")
            Exit Sub
        End If

        If (CPFMTF.Text = "") Then
            MsgBox("CPF do funcionário não preenchido")
            Exit Sub
        End If

        If (PerfilCB.Text = "") Then
            MsgBox("Perfil do funcionário não preenchido")
            Exit Sub
        End If

        If (SalarioTF.Text = "") Then
            MsgBox("Salário do funcionário não preenchido")
            Exit Sub
        End If

        If (PerfilCB.Text = "Veterinário") Then
            If (CRMVTF.Text = "") Then
                MsgBox("CRMV do funcionário não preenchido")
                Exit Sub
            End If

            If (ValidadeMTF.Text = "") Then
                MsgBox("Validade do CRMV não preenchida")
                Exit Sub
            End If
        End If

        Try : Dim a As Double = CDbl(SalarioTF.Text)
        Catch exc As Exception
            MsgBox("Salário do funcionário preenchido incorretamente")
            Exit Sub
        End Try

        Select Case PerfilCB.Text
            Case "Veterinário"
                Dim veterinario As Veterinario = New Veterinario(CleanString(CPFMTF.Text), NomeTF.Text, MatriculaMTF.Text, CDbl(SalarioTF.Text), CRMVTF.Text, ValidadeMTF.Text)

                If (FuncionarioDAOInstance.FindByCPF(CPFMTF.Text) IsNot Nothing) Then
                    MsgBox("Este CPF já está cadastrado como funcionário. Inclusão não efetuada", vbCritical Or vbMsgBoxSetForeground)
                    Exit Sub
                End If

                If (FuncionarioBCInstance.ValidateForModification(veterinario) = True) Then
                    veterinario.Senha = GenerateSenha()
                    If (FuncionarioDAOInstance.Insert(veterinario) = True) Then
                        MsgBox("Funcionário Inserido no cadastro informe os dados abaixo ao funcionário: " & Chr(10) & _
                               "Matricula gerada: " & veterinario.Matricula & Chr(10) & _
                               "Senha gerada: " & veterinario.Senha, vbInformation Or vbMsgBoxSetForeground)
                        NomeTF.Text = ""
                        CPFMTF.Text = ""
                        MatriculaMTF.Text = GenerateMatricula()
                        PerfilCB.Text = ""
                        SalarioTF.Text = ""
                        CRMVTF.Text = ""
                        ValidadeMTF.Text = ""
                    Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
                    End If
                Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
                End If
            Case Else
                Dim funcionario As Funcionario = New Funcionario(CleanString(CPFMTF.Text), NomeTF.Text, MatriculaMTF.Text, PerfilCB.Text, CDbl(SalarioTF.Text))

                If (FuncionarioDAOInstance.FindByCPF(CPFMTF.Text) IsNot Nothing) Then
                    MsgBox("Este CPF já está cadastrado como funcionário. Inclusão não efetuada", vbCritical Or vbMsgBoxSetForeground)
                    Exit Sub
                End If

                If (FuncionarioBCInstance.ValidateForModification(funcionario) = True) Then
                    funcionario.Senha = GenerateSenha()
                    If (FuncionarioDAOInstance.Insert(funcionario) = True) Then
                        MsgBox("Funcionário Inserido no cadastro informe os dados abaixo ao funcionário: " & Chr(10) & _
                               "Matricula gerada: " & funcionario.Matricula & Chr(10) & _
                               "Senha gerada: " & funcionario.Senha, vbInformation Or vbMsgBoxSetForeground)
                        NomeTF.Text = ""
                        CPFMTF.Text = ""
                        MatriculaMTF.Text = GenerateMatricula()
                        PerfilCB.Text = ""
                        SalarioTF.Text = ""
                    Else : MsgBox("Ocorreu um problema na inserção dos dados na base, tente novamente")
                    End If
                Else : MsgBox("Um Problema ocorreu durante a validação dos dados do cliente, tente novamente")
                End If
        End Select

        

    End Sub

    Private Sub CPFMTF_LostFocus(sender As Object, e As EventArgs) Handles CPFMTF.LostFocus
        If (CleanString(CPFMTF.Text) <> "") Then CPFMTF.Text = AddZeros(CleanString(CPFMTF.Text))
    End Sub

    Private Sub PerfilCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PerfilCB.SelectedIndexChanged
        If PerfilCB.Text = "Veterinário" Then
            CRMVTF.Enabled = True
            ValidadeMTF.Enabled = True
        Else
            CRMVTF.Enabled = False
            ValidadeMTF.Enabled = False
            CRMVTF.Text = ""
            ValidadeMTF.Text = ""
        End If
    End Sub
End Class