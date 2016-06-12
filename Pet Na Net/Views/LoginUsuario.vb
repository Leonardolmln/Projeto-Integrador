Public Class LoginUsuario

    Private FuncionarioDAOInstance As New FuncionarioDAO
    Private FuncionarioBCInstance As New FuncionarioBC
    Private FormMode As String = "Login"

    Private Sub LoginBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBT.Click
        If (String.IsNullOrWhiteSpace(PasswordTF.Text) OrElse String.IsNullOrWhiteSpace(UserTF.Text)) Then
            MsgBox("Usuário ou senha não preenchidos", vbInformation)
            Exit Sub
        End If

        Select Case FormMode
            Case "Login"
                Dim funcionario As Funcionario = FuncionarioDAOInstance.FindByMatricula(UserTF.Text)
                If (funcionario IsNot Nothing) Then
                    funcionario.Senha = PasswordTF.Text
                    If (FuncionarioDAOInstance.VerifyPassword(funcionario) = False) Then
                        MsgBox("Senha incorreta", vbInformation)
                        Exit Sub
                    End If
                    Home.CurrentUser = funcionario
                    Home.Show()
                    Me.Close()
                Else
                    MsgBox("Funcionário não cadastrado", vbInformation)
                    Exit Sub
                End If
            Case "Sign-Up"
                
        End Select
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserTF.Text = "154789"
        PasswordTF.Text = "Test1234"
    End Sub

    Private Sub RegistroLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegistroLink.LinkClicked
        'Select Case FormMode
        '    Case "Login"
        '        ConfirmPasswordLB.Visible = True
        '        ConfirmPasswordTF.Visible = True
        '        LoginBT.Text = "Registrar-se"
        '        RegistroLink.Text = "Log-In"
        '        FormMode = "Sign-Up"
        '    Case "Sign-Up"

        'End Select
        
    End Sub
End Class
