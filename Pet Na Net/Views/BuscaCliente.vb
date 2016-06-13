Public Class BuscaCliente

    Public Shared currentCliente As Cliente
    Private clienteDAO As New ClienteDAO

    Private Sub BuscaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuscaCliente_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        currentCliente = Nothing
    End Sub

    Private Sub BuscarClienteBT_Click(sender As Object, e As EventArgs) Handles BuscarClienteBT.Click
        Try
            If (NomeRB.Checked = True) Then
                currentCliente = clienteDAO.FindByNome(NomeTF.Text)
            Else : currentCliente = clienteDAO.FindByCPF(CPFMTF.Text)
            End If

            If (currentCliente Is Nothing) Then
                MsgBox("Não foi encontrado nenhum cliente com a pesquisa realizada", vbInformation Or vbMsgBoxSetForeground)
                Exit Sub
            Else : InfoCliente.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
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

    
    Private Sub CPFMTF_LostFocus(sender As Object, e As EventArgs) Handles CPFMTF.LostFocus
        If (CleanString(CPFMTF.Text) <> "") Then CPFMTF.Text = AddZeros(CleanString(CPFMTF.Text))
    End Sub

End Class