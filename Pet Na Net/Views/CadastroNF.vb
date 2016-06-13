Public Class CadastroNF

    Private FornecedorDAOInstance As New FornecedorDAO
    Private ProdutoDAOInstance As New ProdutoDAO
    Private NotaFiscalDAOInstance As New NotaFiscalDAO
    Private MovimentoDAOInstance As New MovimentoDAO
    Private ItemDAOInstance As New ItemDAO

    Private Sub InserirNF_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        UpdateInfo()
    End Sub

    Public Sub UpdateInfo()
        FornecedorCB.Items.Clear()
        For Each Forn As Fornecedor In FornecedorDAOInstance.FindAll()
            FornecedorCB.Items.Add(Forn.RazaoSocial)
        Next
    End Sub

    Private Sub AddFornecedorIMG_Click(sender As Object, e As EventArgs) Handles AddFornecedorIMG.Click
        CadastroFornecedor.Show()
    End Sub

    Private Sub InserirNF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdutosDT.Rows.Add(4)
    End Sub

    Private Sub CadastrarPetBT_Click(sender As Object, e As EventArgs) Handles CadastrarPetBT.Click

        If (String.IsNullOrWhiteSpace(NumNFTF.Text)) Then
            MsgBox("Número da NF não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(FornecedorCB.SelectedItem.ToString)) Then
            MsgBox("Fornecedor não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (String.IsNullOrWhiteSpace(EmissaoTF.Text)) Then
            MsgBox("Emissão não preenchido", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        ElseIf (ProdutosDT.Rows.Count = 0) Then
            MsgBox("Nenhum produto informado", vbInformation Or vbMsgBoxSetForeground)
            Exit Sub
        End If

        Dim nf As New NotaFiscal(NumNFTF.Text, EmissaoTF.Text)
        NotaFiscalDAOInstance.Insert(nf)

        Dim mov As New Movimento(NotaFiscalDAOInstance.FindByNumero(nf.NumeroNF), TipoMovimento.Entrada, Now, FornecedorDAOInstance.FindByRazaoSocial(FornecedorCB.SelectedItem.ToString))
        MovimentoDAOInstance.Insert(mov)

        For Each row As DataGridViewRow In ProdutosDT.Rows
            If (CStr(row.Cells.Item("NomeProduto").Value) <> "" AndAlso _
                CStr(row.Cells.Item("Validade").Value) <> "" AndAlso _
                CStr(row.Cells.Item("Marca").Value) <> "" AndAlso _
                CStr(row.Cells.Item("TipoProduto").Value) <> "" AndAlso _
                CStr(row.Cells.Item("ValorUnitario").Value) <> "" AndAlso _
                CStr(row.Cells.Item("Quantidade").Value) <> "") Then

                Dim produto As New Produto()
                Dim item As New Item()

                produto.NomeProduto = CStr(row.Cells.Item("NomeProduto").Value)
                produto.Validade = CStr(row.Cells.Item("Validade").Value)
                produto.Marca = CStr(row.Cells.Item("Marca").Value)
                produto.TipoProduto = CStr(row.Cells.Item("TipoProduto").Value)

                ProdutoDAOInstance.Insert(produto)

                item.Quantidade = CStr(row.Cells.Item("Quantidade").Value)
                item.ValorUnitario = CStr(row.Cells.Item("ValorUnitario").Value)
                item.ValorTotal = item.Quantidade * item.ValorUnitario
                item.Produto = ProdutoDAOInstance.FindLast()
                item.Movimento = MovimentoDAOInstance.FindLast()

                ItemDAOInstance.Insert(item)

                MsgBox("Inserção realizada com sucesso", vbInformation Or vbMsgBoxSetForeground)

            End If
        Next
    End Sub
End Class