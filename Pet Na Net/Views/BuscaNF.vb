Public Class BuscaNF

    Public Shared currentMovimento As Movimento
    Private NFDAOInstance As New NotaFiscalDAO
    Private MovimentoDAOInstance As New MovimentoDAO
    Private FornecedorDAOInstance As New FornecedorDAO

    Private Sub BuscaNF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuscaNF_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        currentMovimento = Nothing

        FornecedorCB.Items.Clear()
        For Each Fornecedor As Fornecedor In FornecedorDAOInstance.FindAll()
            FornecedorCB.Items.Add(Fornecedor.RazaoSocial)
        Next
    End Sub

    Private Sub BuscarNFBT_Click(sender As Object, e As EventArgs) Handles BuscarNFBT.Click
        Try
            
            If (NumNFRB.Checked = True) Then
                currentMovimento = MovimentoDAOInstance.FindByNF(NFDAOInstance.FindByNumeroForn(NumNFTF.Text, FornecedorCB.SelectedItem.ToString))
            End If

            If (currentMovimento Is Nothing) Then
                MsgBox("Não foi encontrada nota fiscal com os parâmetros informados", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            Else : InfoNF.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
End Class