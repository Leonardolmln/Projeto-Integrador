Public Class LoginUsuario

    Private FuncionarioDAOInstance As New FuncionarioDAO
    Private FuncionarioBCInstance As New FuncionarioBC
    
    Private Sub LoginBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBT.Click
        If (String.IsNullOrWhiteSpace(UserTF.Text)) Then
            MsgBox("Usuário não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(PasswordTF.Text)) Then
            MsgBox("Senha não preenchida", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim funcionario As Funcionario = FuncionarioDAOInstance.FindByMatricula(UserTF.Text)
        If (funcionario IsNot Nothing) Then
            funcionario.Senha = PasswordTF.Text
            If (FuncionarioDAOInstance.VerifyPassword(funcionario) = False) Then
                MsgBox("Senha incorreta", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            End If
            Home.CurrentUser = funcionario
            Home.Show()
            Me.Close()
        Else
            MsgBox("Funcionário não cadastrado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserTF.Text = "154789"
        PasswordTF.Text = "Test1234"
    End Sub

End Class
