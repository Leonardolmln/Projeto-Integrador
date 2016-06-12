Public Class BuscaFornecedor

    Public Shared currentFornecedor As Fornecedor
    Private FornecedorDAOInstance As FornecedorDAO

    Private Sub BuscaFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BuscaFornecedor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        currentFornecedor = Nothing
    End Sub

    Private Sub BuscaFornecedorBT_Click(sender As Object, e As EventArgs) Handles BuscaFornecedorBT.Click
        Try
            FornecedorDAOInstance = New FornecedorDAO()

            If (NomeRB.Checked = True) Then
                currentFornecedor = FornecedorDAOInstance.FindByRazaoSocial(NomeTF.Text)
            Else : currentFornecedor = FornecedorDAOInstance.FindByCNPJ(CNPJTF.Text)
            End If

            If (currentFornecedor Is Nothing) Then
                MsgBox("Não foi encontrado nenhum fornecedor com a pesquisa realizada", vbInformation)
                Exit Sub
            Else : InfoFornecedor.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub CNPJRB_CheckedChanged(sender As Object, e As EventArgs) Handles CNPJRB.CheckedChanged
        If (CNPJRB.Checked = True) Then
            CNPJTF.Enabled = True
        Else : CNPJTF.Enabled = False
        End If
    End Sub

    Private Sub NomeRB_CheckedChanged(sender As Object, e As EventArgs) Handles NomeRB.CheckedChanged
        If (NomeRB.Checked = True) Then
            NomeTF.Enabled = True
        Else : NomeTF.Enabled = False
        End If
    End Sub

End Class