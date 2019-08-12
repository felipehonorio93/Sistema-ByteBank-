
Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ContasCorrentesAgencia

    Dim agencia As Agencia

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        agencia = New Agencia(277)

        Me.Text = "Contas Correntes Agencia"
        Grp_Conta.Text = "Conta Corrente"
        Lbl_Agencia.Text = "Agencia: " + agencia.agencia.ToString

        Btm_Adicionar.Text = "Adicionar"
        Btm_Remover.Text = "Remover"
        Grp_Busca.Text = "Buscar"
        Btm_Busca.Text = "Buscar"
        Grp_AlterarCC.Text = "Alterar Nome"
        Btm_AlterarCC.Text = "Alterar"

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        If Txt_Conta.Text <> "" And Txt_Nome.Text <> "" Then
            agencia.AbrirContaCorrente(Txt_Conta.Text, Txt_Nome.Text)
            Txt_Array.Text = EscreverElementosArrayIndexador()

        End If

    End Sub

    Private Sub Btm_Remover_Click(sender As Object, e As EventArgs) Handles Btm_Remover.Click
        If Txt_Conta.Text <> "" And Txt_Nome.Text <> "" Then
            agencia.FecharContaCorrente(Txt_Conta.Text, Txt_Nome.Text)
            Txt_Array.Text = EscreverElementosArrayIndexador()

        End If

    End Sub


    Public Function EscreverElementosArrayIndexador() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To agencia.ContasCorrentes.Count - 1
            elementos += agencia.ContasCorrentes(i).ToString + vbCrLf
        Next
        Return elementos

    End Function

    Private Sub Btm_Busca_Click(sender As Object, e As EventArgs) Handles Btm_Busca.Click

        'Try
        '    Dim numero As Integer = Txt_CCBusca.Text
        '    Dim Conta As ContaCorrente = agencia.BuscaCC(numero)
        '    Txt_Resultado.Text = Conta.ToString

        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'End Try

        Try
            Dim numero As Integer = Txt_CCBusca.Text
            Dim Conta As ContaCorrente = agencia.BuscaCC(numero)
            Txt_Resultado.Text = Conta.ToString

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btm_AlterarCC_Click(sender As Object, e As EventArgs) Handles Btm_AlterarCC.Click

        agencia.AlterarCC(Txt_CCAlterar.Text, Txt_NomeAlterar.Text)
        Txt_Array.Text = EscreverElementosArrayIndexador()

    End Sub
End Class