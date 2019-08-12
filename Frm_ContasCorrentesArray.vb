Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ContasCorrentesArray

    Dim Lista As New Lista(Of ContaCorrente)

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Contas Correntes Array"
        Lbl_Agencia.Text = "Agencia"
        Lbl_Conta.Text = "Conta"
        Btm_Adicionar.Text = "Adicionar"
        Btm_Remover.Text = "Remover"
        Grp_AdicionarVarios.Text = "Adicionar Vários"

        Btm_AdicionaVarios.Text = "Adicionar"
        Lbl_Agencia1.Text = "Agencia 1"
        Lbl_Conta1.Text = "Conta 1"
        Lbl_Agencia2.Text = "Agencia 2"
        Lbl_Conta2.Text = "Conta 2"
        Lbl_Agencia3.Text = "Agencia 3"
        Lbl_Conta3.Text = "Conta 3"
        Lbl_Agencia4.Text = "Agencia 4"
        Lbl_Conta4.Text = "Conta 4"

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        If Txt_Agencia.Text <> "" And Txt_Conta.Text <> "" Then
            Dim conta As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text)
            Lista.Adicionar(conta)
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Private Sub Btm_Remover_Click(sender As Object, e As EventArgs) Handles Btm_Remover.Click
        If Txt_Agencia.Text <> "" And Txt_Conta.Text <> "" Then
            Dim conta As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text)
            Lista.Remover(conta)
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Public Function EscreverElementosArray() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To Lista.tamanho - 1
            elementos += Lista(i).agencia.ToString + " - " + Lista(i).numero.ToString + vbCrLf
        Next
        Return elementos

    End Function

    Public Function EscreverElementosArrayIndexador() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To Lista.tamanho - 1
            elementos += Lista(i).agencia.ToString + " - " + Lista(i).numero.ToString + vbCrLf
        Next
        Return elementos

    End Function

    Private Sub Btm_AdicionaVarios_Click(sender As Object, e As EventArgs) Handles Btm_AdicionaVarios.Click

        If Txt_Agencia1.Text <> "" And Txt_Conta1.Text <> "" Then
            Dim Conta1 As New ContaCorrente(Txt_Agencia1.Text, Txt_Conta1.Text)
            If Txt_Agencia2.Text <> "" And Txt_Conta2.Text <> "" Then
                Dim Conta2 As New ContaCorrente(Txt_Agencia2.Text, Txt_Conta2.Text)
                If txt_Agencia3.Text <> "" And Txt_Conta3.Text <> "" Then
                    Dim Conta3 As New ContaCorrente(txt_Agencia3.Text, Txt_Conta3.Text)
                    If Txt_Agencia4.Text <> "" And Txt_Conta4.Text <> "" Then
                        Dim Conta4 As New ContaCorrente(Txt_Agencia4.Text, Txt_Conta4.Text)
                        Lista.AdicionarVariosUmAUm(Conta1, Conta2, Conta3, Conta4)
                        Txt_Array.Text = EscreverElementosArrayIndexador()
                    Else
                        Lista.AdicionarVariosUmAUm(Conta1, Conta2, Conta3)
                        Txt_Array.Text = EscreverElementosArrayIndexador()
                    End If
                Else
                    Lista.AdicionarVariosUmAUm(Conta1, Conta2)
                    Txt_Array.Text = EscreverElementosArrayIndexador()
                End If
            Else
                Lista.AdicionarVariosUmAUm(Conta1)
                Txt_Array.Text = EscreverElementosArrayIndexador()
            End If
        End If
    End Sub
End Class