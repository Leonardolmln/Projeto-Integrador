Public Class BuscaServico

    Public Shared currentServico As Servico
    Private ServicoDAOInstance As New ServicoDAO
    Private ClienteDAOInstance As New ClienteDAO

    Private Sub BuscaServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (BuscaCliente.currentCliente IsNot Nothing) Then
            CPFMTF.Text = BuscaCliente.currentCliente.CPF
        End If
        TipoServico.GetStatus().ForEach(Sub(tipo) TipoServicoCB.Items.Add(tipo))
    End Sub

    Private Sub BuscarNFBT_Click(sender As Object, e As EventArgs) Handles BuscarNFBT.Click
        If (TipoServicoCB.Text = "") Then
            MsgBox("Tipo do serviço não preenchido")
            Exit Sub
        End If

        If (DataServicoMTF.Text = "") Then
            MsgBox("Data do serviço não preenchido")
            Exit Sub
        End If

        If (CPFMTF.Text = "") Then
            MsgBox("CPF do cliente não preenchido")
            Exit Sub
        End If

        Dim cliente As Cliente = ClienteDAOInstance.FindByCPF(CPFMTF.Text)

        currentServico = ServicoDAOInstance.FindByCPFTipoData(cliente.ID, TipoServicoCB.Text, DataServicoMTF.Text)

        If (currentServico Is Nothing) Then
            MsgBox("Não há serviços na base com os parâmetros informados")
        Else : InfoServico.Show()
        End If

    End Sub
End Class